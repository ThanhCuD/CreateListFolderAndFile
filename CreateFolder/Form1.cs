using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace CreateFolder
{
    public partial class Form1 : Form
    {
        private Helper helper;
        public Form1()
        {
            Cursor.Current = Cursors.WaitCursor;
            InitializeComponent();
            helper = new Helper();
            tbNumtake.Text = "10";
            bt_OpenSavePath.Enabled = true;
            InitConfig();
            Cursor.Current = Cursors.Default;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void InitConfig()
        {
            try
            {
                var configs = helper.GetConfigs();
                if (configs != null && configs.Count() > 0)
                {
                    var gitExtKey = configs.Where(x => x.Key == HelperModel.GitExeFolder).FirstOrDefault();
                    tbGitExePath.Text = string.IsNullOrEmpty(gitExtKey.Value) ? "" : gitExtKey.Value;

                    var projectPathKey = configs.Where(x => x.Key == HelperModel.ProjectFolder).FirstOrDefault();
                    tbProjectPath.Text = string.IsNullOrEmpty(projectPathKey.Value) ? "" : projectPathKey.Value;

                    var destinationPathKey = configs.Where(x => x.Key == HelperModel.DestinationFolder).FirstOrDefault();
                    tbSavePath.Text = string.IsNullOrEmpty(destinationPathKey.Value) ? "" : destinationPathKey.Value;

                    var includeFileTypesKey = configs.Where(x => x.Key == HelperModel.IncludeFileTypes).FirstOrDefault();
                    tbFileSelect.Text = string.IsNullOrEmpty(includeFileTypesKey.Value) ? "" : includeFileTypesKey.Value;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnGetFile_Click(object sender, EventArgs e)
        {
            
            Cursor.Current = Cursors.WaitCursor;
            checkedListBox_Result.Items.Clear();
            try
            {
                if (!string.IsNullOrEmpty(cbBeginCommit.Text) && !string.IsNullOrEmpty(cbEndCommit.Text))
                {
                    DirectoryInfo di = new DirectoryInfo(tbProjectPath.Text);
                    var allowedFileTypes = tbFileSelect.Text.Split(new string[] { ";" }, StringSplitOptions.RemoveEmptyEntries).ToList();
                    if (di.Exists)
                    {
                        var items = checkedListBox_Result.Items;
                        var result = helper.GetFiles(cbBeginCommit.Text, cbEndCommit.Text, di.FullName);
                        var arrFile = helper.GetListFile(result);
                        
                        var hasDllFIle = arrFile.Select(_ => _.LastIndexOf(".")!=-1 ? _.Substring(_.LastIndexOf(".")) : _)
                            .Any(_ => _ == ".cs");
                        if (hasDllFIle)
                        {
                            items.Add("bin/SitefinityWebApp.dll", true);
                        }
                        foreach (var item in arrFile)
                        {
                            var index = item.LastIndexOf(".");
                            if (index > -1)
                            {
                                var fileType = item.Substring(index);
                                if (cbCAAS.Checked)
                                {
                                    var list = item.Split('/').ToList();
                                    list.RemoveAt(0);
                                    var newItem = string.Join("/", list);
                                    items.Add(newItem, allowedFileTypes.Contains(fileType));
                                }
                                else
                                {
                                    items.Add(item, allowedFileTypes.Contains(fileType));
                                }
                            }
                        }
                        
                    }
                }
                if (checkedListBox_Result.Items.Count > 0)
                {
                    btnGeneratePackage.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Cursor.Current = Cursors.Default;
        }

        private void Btn_UpdateConfig_Click(object sender, EventArgs e)
        {
            try
            {
                var appConfigs = new List<AppConfigModel>()
            {
                new AppConfigModel()
                {
                    Key = HelperModel.GitExeFolder,
                    Value = tbGitExePath.Text
                },
                new AppConfigModel()
                {
                    Key = HelperModel.ProjectFolder,
                    Value = tbProjectPath.Text
                },
                new AppConfigModel()
                {
                    Key = HelperModel.DestinationFolder,
                    Value = tbSavePath.Text
                },
                new AppConfigModel()
                {
                    Key = HelperModel.IncludeFileTypes,
                    Value = tbFileSelect.Text
                }
            };
                helper.UpdateAppConfigs(appConfigs);
                if (!string.IsNullOrEmpty(tbProjectPath.Text))
                {
                    var numTake = tbNumtake.Text != null ? int.Parse(tbNumtake.Text) : 10;
                    var datasource = helper.UpdateBeginAndEndCommit(tbProjectPath.Text, numTake);
                    if (datasource != null)
                    {
                        var clone = new List<string>(datasource);
                        cbBeginCommit.DataSource = datasource;
                        cbEndCommit.DataSource = clone;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnGeneratePackage_Click(object sender, EventArgs e)
        {
            try
            {
                var checkedItems = checkedListBox_Result.CheckedItems;
                if (checkedItems.Count > 0)
                {
                    helper.GenerateFilesForDeployment(checkedItems, tbProjectPath.Text, tbSavePath.Text, ref checkListBox_Package);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bt_OpenSavePath_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", tbSavePath.Text);
        }

        private void btCleanSaveFolder_Click(object sender, EventArgs e)
        {
            DirectoryInfo di = new DirectoryInfo(tbSavePath.Text);
            foreach (FileInfo file in di.GetFiles())
            {
                file.Delete();
            }
            foreach (DirectoryInfo dir in di.GetDirectories())
            {
                dir.Delete(true);
            }
        }

        private void bt_copy_address_Click(object sender, EventArgs e)
        {
            var checkedItems = checkListBox_Package.CheckedItems;
            var result = "";
            foreach (var item in checkedItems)
            {
                var z = item.ToString();

                string builder = z.Replace(tbSavePath.Text + "\\", "");
                result += builder + Environment.NewLine;
            }
            Thread thread = new Thread(() => Clipboard.SetText(result));
            thread.SetApartmentState(ApartmentState.STA); //Set the thread to STA
            thread.Start();
            thread.Join();
        }
    }
}
