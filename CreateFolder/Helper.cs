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
                        gitProcess.OutputDataReceived += (sender, e) => {
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
                        var fileType = line.Substring(line.LastIndexOf("."));
                        arr.Add(line);
                    }
                }
            }
            return arr;
        }
    }
}
