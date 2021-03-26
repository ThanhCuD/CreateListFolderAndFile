using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreateFolder
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combo.SelectedItem.ToString() == "Create Folder")
            {
                Form1 form1 = new Form1();
                form1.ShowDialog();
            }
            else
            {
                Nric nric = new Nric();
                nric.ShowDialog();
            }
        }
    }
}
