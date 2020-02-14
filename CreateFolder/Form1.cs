using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreateFolder
{
    public partial class Form1 : Form
    {
        private static string[] files;
        public Form1()
        {
            InitializeComponent();
            txtAddressSave.ReadOnly = true;
            txtAddRoot.ReadOnly = true;
            txtAdsChild.ReadOnly = true;
            txtAddressSave.Text = ConfigurationManager.AppSettings["AddressSave"];
            txtAddRoot.Text = ConfigurationManager.AppSettings["AddRoot"];
            txtAdsChild.Text = ConfigurationManager.AppSettings["AdsChild"];
        }

        private void btMake_Click(object sender, EventArgs e)
        {
            var addressSave = txtAddressSave.Text;
            var addressRoot = txtAddRoot.Text;
            var addresChild = txtAdsChild.Text;
            if(!IsValid( addressRoot, addresChild, addressSave ))
            {
                MessageBox.Show("Please enter input correct");
            }
            else
            {
                CreateRootFolder(addressRoot, addresChild, addressSave);
            }
        }
        private bool IsValid(string addressRoot, string addresChild, string addessSave)
        {
            if (string.IsNullOrEmpty(addressRoot) || string.IsNullOrEmpty(addessSave) || string.IsNullOrEmpty(addresChild)) return false;
            if (!addresChild.Contains(addressRoot)) return false;
            return true;
        }
        private void CreateRootFolder(string addressRoot,string addressChild, string addressSave)
        {
            var arr = addressRoot.Split('\\');
            var root = arr[arr.Length - 1];
            var arrChild = addressChild.Substring(addressChild.IndexOf(root)).Split('\\');

            if (arrChild != null)
            {
                var targetPath = addressSave;
                foreach (var item in arrChild)
                {
                    targetPath += "\\" + item;
                    if (!System.IO.Directory.Exists(targetPath))
                        System.IO.Directory.CreateDirectory(targetPath);
                }
                if(files == null)
                {
                    files = System.IO.Directory.GetFiles(addressChild);
                }
                if (files.Length == 0)
                {
                    MessageBox.Show("No File To choose. Please check again!!", "Message");
                    files = null;
                    return;
                }
                foreach (string s in files)
                {
                    var fileName = System.IO.Path.GetFileName(s);
                    var destFile = System.IO.Path.Combine(targetPath, fileName);
                    System.IO.File.Copy(s, destFile, true);
                }
                MessageBox.Show("Done", "Message");
                Process.Start(targetPath);
                files = null;
            }
            else
            {
                MessageBox.Show("Failed", "Message");
            }
        }

        private void bt_Choose_Save_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    txtAddressSave.Text = fbd.SelectedPath;
                }
            }
        }

        private void bt_ChooseRoot_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    txtAddRoot.Text = fbd.SelectedPath;
                }
            }
        }

        private void bt_ChooseChild_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                if (txtAddRoot.Text!=null && txtAddRoot.Text != "")
                {
                    fbd.SelectedPath = txtAddRoot.Text;
                }
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    txtAdsChild.Text = fbd.SelectedPath;
                }
            }
        }

        private void bt_Choose_Files_Click(object sender, EventArgs e)
        {
            using (var fdl = new OpenFileDialog())
            {
                fdl.Multiselect = true;
                if (!string.IsNullOrEmpty(txtAdsChild.Text))
                {
                    fdl.InitialDirectory = txtAdsChild.Text;
                }
                DialogResult result = fdl.ShowDialog();
                if (result == DialogResult.OK)
                {
                    files = fdl.FileNames;
                }
            }
        }

        private void btConfig_Click(object sender, EventArgs e)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);
            config.AppSettings.Settings.Remove("AddressSave");
            config.AppSettings.Settings.Add("AddressSave", txtAddressSave.Text);
            config.AppSettings.Settings.Remove("AddRoot");
            config.AppSettings.Settings.Add("AddRoot", txtAddRoot.Text);
            config.AppSettings.Settings.Remove("AdsChild");
            config.AppSettings.Settings.Add("AdsChild", txtAdsChild.Text);
            config.Save(ConfigurationSaveMode.Modified);
            MessageBox.Show("Done", "Message");
        }
    }
}
