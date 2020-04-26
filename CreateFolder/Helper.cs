using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreateFolder
{
    public class Helper
    {
        string rootWebsite = "Website";
        string rootData = "Data";
        string rootConfig = "Config";

        public string GetFiles(string beginCommit, string endCommit, string workDirectory)
        {
            var command = string.Format(" show --name-only --oneline {0}^..{1}", beginCommit, endCommit);
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

        public IEnumerable<string> GetListFile(string str)
        {
            var arr = new List<string>();
            using (var reader = new StringReader(str))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (line.Contains("/"))
                    {
                        arr.Add(line);
                    }
                }
            }
            arr = arr.Distinct().ToList();
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
                throw ex;
            }

            return "All Configs updated";
        }

        public IEnumerable<string> UpdateBeginAndEndCommit(string workDirectory, int take)
        {
            var str = LoadBeginEndCommit(workDirectory, take);
            var arr = new List<string>();
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

        public void GenerateFilesForDeployment(CheckedListBox.CheckedItemCollection checkedItems, string projectPath, string destinationPath, ref CheckedListBox checkPagake)
        {
            try
            {
                CreateOrCleanDirectory(destinationPath);
                checkPagake.Items.Clear();
                var listFile = new List<string>();
                foreach (var checkItem in checkedItems)
                {
                    var source = Path.Combine(projectPath, checkItem.ToString().Replace("/", "\\"));
                    var arr = checkItem.ToString().Split('/');
                    if(arr[1] == "App_Data")
                    {
                        arr[0] = rootData;
                    }
                    else
                    {
                        arr[0] = rootWebsite;
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
                        listFile.Add(destination);
                    }
                }
                listFile = listFile.OrderBy(_ => _).ToList();
                foreach (var item in listFile)
                {
                    checkPagake.Items.Add(item, false);
                }
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
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
    }

    public class AppConfigModel
    {
        public string Key { get; set; }
        public string Value { get; set; }
    }
}
