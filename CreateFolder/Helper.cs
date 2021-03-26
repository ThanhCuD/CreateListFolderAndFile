using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace CreateFolder
{
    public class Helper
    {
        string rootWebsite = "Website";
        string rootData = "Data";

        public string GetFiles(string beginCommit, string endCommit, string workDirectory)
        {
            var command = string.Format(" log --name-status --oneline {0}^..{1}", beginCommit, endCommit);
            var gitFilePath = ConfigurationManager.AppSettings["GitExeFolder"] ?? "C:\\Program Files\\Git\\bin\\git.exe";
            try
            {
                using (Process gitProcess = new Process())
                {
                    var timeout = 10000;

                    ProcessStartInfo gitInfo = new ProcessStartInfo
                    {
                        CreateNoWindow = true,
                        RedirectStandardError = true,
                        RedirectStandardOutput = true,
                        FileName = gitFilePath,
                        UseShellExecute = false
                    };

                    gitInfo.Arguments = command;
                    gitInfo.WorkingDirectory = workDirectory;

                    gitProcess.StartInfo = gitInfo;

                    StringBuilder stdout_str = new StringBuilder();
                    StringBuilder stderr_str = new StringBuilder();

                    using (AutoResetEvent outputWaitHandle = new AutoResetEvent(false))
                    using (AutoResetEvent errorWaitHandle = new AutoResetEvent(false))
                    {
                        gitProcess.OutputDataReceived += (sender, e) =>
                        {
                            if (e.Data == null)
                            {
                                outputWaitHandle.Set();
                            }
                            else
                            {
                                stdout_str.AppendLine(e.Data);
                            }
                        };
                        gitProcess.ErrorDataReceived += (sender, e) =>
                        {
                            if (e.Data == null)
                            {
                                errorWaitHandle.Set();
                            }
                            else
                            {
                                stderr_str.AppendLine(e.Data);
                            }
                        };

                        gitProcess.Start();

                        gitProcess.BeginOutputReadLine();
                        gitProcess.BeginErrorReadLine();

                        if (gitProcess.WaitForExit(timeout) &&
                            outputWaitHandle.WaitOne(timeout) &&
                            errorWaitHandle.WaitOne(timeout))
                        {
                            return string.IsNullOrEmpty(stdout_str.ToString()) ? stderr_str.ToString() : stdout_str.ToString();
                        }
                        else
                        {
                            WriteLog("At Helper>GetFiles TimeOut");
                            return "";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                int linenum = 0;
                try
                {
                    linenum = Convert.ToInt32(ex.StackTrace.Substring(ex.StackTrace.LastIndexOf(' ')));
                }
                catch
                {
                    //Stack trace is not available!
                }

                WriteLog("At Line :" + linenum + ": " + ex);
                return "";
            }
        }

        public IEnumerable<string> GetListFile(string str)
        {
            var arr = new List<string>();

            
            try
            {
                using (var reader = new StringReader(str))
                {
                    string line;
                    var changeDll = false;
                    while ((line = reader.ReadLine()) != null)
                    {
                        if (!changeDll) {
                            changeDll = line.EndsWith(".cs");
                        }
                        if (line.Contains("/") && !line.Contains(" ") && !line.EndsWith(".cs"))
                        {
                            if(line.StartsWith("M") || line.StartsWith("A"))
                            {
                                line = "N" + line.Substring(1);
                            }
                            arr.Add(line);
                        }
                    }
                    if (changeDll)
                    {
                        arr.Add("N\tbin/SitefinityWebApp.dll");
                    }
                }
                arr = arr.Distinct().ToList();
            }
            catch (Exception ex)
            {
                int linenum = 0;
                try
                {
                    linenum = Convert.ToInt32(ex.StackTrace.Substring(ex.StackTrace.LastIndexOf(' ')));
                }
                catch
                {
                    //Stack trace is not available!
                }
                WriteLog("At Line :" + linenum + ": " + ex);
            }
            return arr;
        }

        public IEnumerable<AppConfigModel> GetConfigs()
        {
            var configList = new List<AppConfigModel>();
            try
            {
                var configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                var allKeys = ConfigurationManager.AppSettings.AllKeys;
                var settings = configFile.AppSettings.Settings;
                foreach (var key in allKeys)
                {
                    configList.Add(new AppConfigModel()
                    {
                        Key = key,
                        Value = settings[key].Value
                    });
                }
            }
            catch (Exception ex)
            {
                configList.Add(new AppConfigModel()
                {
                    Key = "Error",
                    Value = ex.Message
                });
            }
            return configList;
        }

        public string UpdateAppConfigs(List<AppConfigModel> appConfigs)
        {
            try
            {
                var configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                var settings = configFile.AppSettings.Settings;

                foreach (var config in appConfigs)
                {
                    if (settings[config.Key] == null)
                    {
                        return "No Config Found";
                    }
                    else
                    {
                        settings[config.Key].Value = config.Value;
                    }
                    configFile.Save(ConfigurationSaveMode.Modified);
                    ConfigurationManager.RefreshSection(configFile.AppSettings.SectionInformation.Name);
                }
            }
            catch (Exception ex)
            {
                int linenum = 0;
                try
                {
                    linenum = Convert.ToInt32(ex.StackTrace.Substring(ex.StackTrace.LastIndexOf(' ')));
                }
                catch
                {
                    //Stack trace is not available!
                }
                WriteLog("At Line :" + linenum + ": " + ex);
            }

            return "All Configs updated";
        }

        public IEnumerable<string> UpdateBeginAndEndCommit(string workDirectory, int take)
        {
            var arr = new List<string>();
            try
            {
                var str = LoadBeginEndCommit(workDirectory, take);
                using (var reader = new StringReader(str))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        var hash = line.Substring(0, 7);
                        arr.Add(hash);
                    }
                }
                return arr;
            }
            catch (Exception ex)
            {
                int linenum = 0;
                try
                {
                    linenum = Convert.ToInt32(ex.StackTrace.Substring(ex.StackTrace.LastIndexOf(' ')));
                }
                catch
                {
                    //Stack trace is not available!
                }
                WriteLog("At Line :" + linenum + ": " + ex);
                return arr;
            }
        }

        public void GenerateFilesForDeployment(CheckedListBox.CheckedItemCollection checkedItems, string projectPath, string destinationPath, ref CheckedListBox checkPagake)
        {
            try
            {
                CreateOrCleanDirectory(destinationPath);
                checkPagake.Items.Clear();
                var lst = new List<string>();
                var lstItem = new List<string>();
                for (int i = 0; i < checkedItems.Count; i++)
                {
                    lstItem.Add(checkedItems[i].ToString());
                }
                lstItem = lstItem.OrderBy(_ => _).ToList();
                foreach (var checkItem in checkedItems)
                {
                    var arrTemp = checkItem.ToString().Split('\t');
                    if (arrTemp.Length == 2)
                    {
                        if (arrTemp[0] != "D")
                        {
                            var source = Path.Combine(projectPath, arrTemp[1].Replace("/", "\\"));
                            var arr = arrTemp[1].Split('/').ToList();
                            if (arr[0] == "App_Data")
                            {
                                arr.Insert(0, rootData);
                            }
                            else
                            {
                                arr.Insert(0, rootWebsite);
                            }
                            var item = string.Join("\\", arr);
                            if (File.Exists(source))
                            {
                                var destination = Path.Combine(destinationPath, item);
                                var directory = Path.GetDirectoryName(destination);
                                if (!Directory.Exists(directory))
                                {
                                    Directory.CreateDirectory(directory);
                                }
                                File.Copy(source, destination);
                                lst.Add(destination);
                            }
                        }
                    }
                }
                lst = lst.OrderBy(_ => _).ToList();
                foreach (var item in lst)
                {
                    checkPagake.Items.Add(item, true);
                }
            }
            catch (Exception ex)
            {
                int linenum = 0;
                try
                {
                    linenum = Convert.ToInt32(ex.StackTrace.Substring(ex.StackTrace.LastIndexOf(' ')));
                }
                catch
                {
                    //Stack trace is not available!
                }
                WriteLog("At Line :" + linenum + ": " + ex);
                throw ex;
            }
        }
        public void WriteLog(string strLog)
        {
            StreamWriter log;
            FileStream fileStream = null;
            DirectoryInfo logDirInfo = null;
            FileInfo logFileInfo;

            string logFilePath = "C:\\Logs\\";
            logFilePath = logFilePath + "Log-" + System.DateTime.Today.ToString("MM-dd-yyyy") + "." + "txt";
            logFileInfo = new FileInfo(logFilePath);
            logDirInfo = new DirectoryInfo(logFileInfo.DirectoryName);
            if (!logDirInfo.Exists) logDirInfo.Create();
            if (!logFileInfo.Exists)
            {
                fileStream = logFileInfo.Create();
            }
            else
            {
                fileStream = new FileStream(logFilePath, FileMode.Append);
            }
            log = new StreamWriter(fileStream);
            log.WriteLine(strLog);
            log.Close();
        }
        #region Private Method
        private string LoadBeginEndCommit(string workDirectory, int take)
        {
            var command = string.Format("log --oneline -n {0}", take);
            var gitFilePath = ConfigurationManager.AppSettings["GitExeFolder"] ?? "C:\\Program Files\\Git\\bin\\git.exe";
            try
            {
                using (Process gitProcess = new Process())
                {
                    var timeout = 10000;

                    ProcessStartInfo gitInfo = new ProcessStartInfo
                    {
                        CreateNoWindow = true,
                        RedirectStandardError = true,
                        RedirectStandardOutput = true,
                        FileName = gitFilePath,
                        UseShellExecute = false
                    };

                    gitInfo.Arguments = command;
                    gitInfo.WorkingDirectory = workDirectory;

                    gitProcess.StartInfo = gitInfo;

                    StringBuilder stdout_str = new StringBuilder();
                    StringBuilder stderr_str = new StringBuilder();

                    using (AutoResetEvent outputWaitHandle = new AutoResetEvent(false))
                    using (AutoResetEvent errorWaitHandle = new AutoResetEvent(false))
                    {
                        gitProcess.OutputDataReceived += (sender, e) =>
                        {
                            if (e.Data == null)
                            {
                                outputWaitHandle.Set();
                            }
                            else
                            {
                                stdout_str.AppendLine(e.Data);
                            }
                        };
                        gitProcess.ErrorDataReceived += (sender, e) =>
                        {
                            if (e.Data == null)
                            {
                                errorWaitHandle.Set();
                            }
                            else
                            {
                                stderr_str.AppendLine(e.Data);
                            }
                        };

                        gitProcess.Start();

                        gitProcess.BeginOutputReadLine();
                        gitProcess.BeginErrorReadLine();

                        if (gitProcess.WaitForExit(timeout) &&
                            outputWaitHandle.WaitOne(timeout) &&
                            errorWaitHandle.WaitOne(timeout))
                        {
                            return string.IsNullOrEmpty(stdout_str.ToString()) ? stderr_str.ToString() : stdout_str.ToString();
                        }
                        else
                        {
                            throw new Exception("Time out");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void CreateOrCleanDirectory(string path)
        {
            var di = new DirectoryInfo(path);
            if (!di.Exists)
            {
                CreateDirectory(path);
            }
            else
            {
                foreach (FileInfo file in di.GetFiles())
                {
                    file.Delete();
                }
                foreach (DirectoryInfo dir in di.GetDirectories())
                {
                    dir.Delete(true);
                }
            }
        }

        private void CreateDirectory(string path)
        {
            var di = new DirectoryInfo(path);
            Directory.CreateDirectory(di.FullName);
        }
        #endregion

    }
    public class HelperModel
    {
        public static string GitExeFolder = "GitExeFolder";
        public static string ProjectFolder = "ProjectFolder";
        public static string DestinationFolder = "DestinationFolder";
        public static string IncludeFileTypes = "IncludeFileTypes";
        public static string RootLog = "RootLog";
        public static string ConnectionString = "ConnectionString";
        public static string Table = "Table";
        public static string Table2 = "Table2";
    }

    public class AppConfigModel
    {
        public string Key { get; set; }
        public string Value { get; set; }
    }
}
