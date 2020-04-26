using System;
using System.Configuration;
using System.Diagnostics;
using System.IO;
using System.Linq;
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
            Cursor.Current = Cursors.Default;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnGetFile_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            checkedListBox_Result.Items.Clear();

            if (!string.IsNullOrEmpty(tbBeginCommit.Text) && !string.IsNullOrEmpty(tbEndCommit.Text))
            {
                DirectoryInfo di = new DirectoryInfo(tbProjectPath.Text);
                var allowedFileTypes = tbFileSelect.Text.Split(new string[] { ";" }, StringSplitOptions.RemoveEmptyEntries).ToList();
                if (di.Exists)
                {
                    var items = checkedListBox_Result.Items;
                    var result = helper.GetFiles(tbBeginCommit.Text, tbEndCommit.Text, di.FullName);
                    using (var reader = new StringReader(result))
                    {
                        string line;
                        while ((line = reader.ReadLine()) != null)
                        {
                            if (line.Contains("/"))
                            {
                                var fileType = line.Substring(line.LastIndexOf("."));
                                items.Add(line, allowedFileTypes.Contains(fileType));
                            }
                        }
                    }
                }

            }
            Cursor.Current = Cursors.Default;
        }
    }
}
