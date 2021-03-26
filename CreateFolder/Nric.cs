using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CreateFolder
{
    public partial class Nric : Form
    {
        public Nric()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string connetionString = string.Empty;
            var table = "table";
            var table2 = "table";
            var configs = new Helper().GetConfigs();
            if (configs != null && configs.Count() > 0)
            {
                connetionString = configs.Where(x => x.Key == HelperModel.ConnectionString).FirstOrDefault()?.Value;
                table = configs.Where(x => x.Key == HelperModel.Table).FirstOrDefault()?.Value;
                table2 = configs.Where(x => x.Key == HelperModel.Table2).FirstOrDefault()?.Value;
            }
            var connection = new SqlConnection(connetionString);
            connection.Open();
            var rs = new List<string>();
            using (DbCommand command = connection.CreateCommand())
            {
                command.CommandText = "SELECT nric FROM " + table;
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    rs.Add(reader["nric"].ToString());
                }
            }
            using (DbCommand command = connection.CreateCommand())
            {
                command.CommandText = "select identity_no from " + table2;
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    rs.Add(reader["identity_no"].ToString());
                }
            }
            connection.Close();
            var str = Gennerate(rs);
            Clipboard.SetText(str);
            textBox1.Text = str;
        }

        private void Nric_Load(object sender, EventArgs e)
        {

        }
        private string Gennerate(List<string> lst)
        {
            var str = "";
            int i = 0;
            do
            {
                var sb = new StringBuilder();
                sb.Append("S");
                sb.Append(i.ToString().PadLeft(7, '0'));
                sb.Append("D");
                str = sb.ToString();
                i++;
            } while (lst.Contains(str));
            return str.ToString();
        }
    }
    public class Table
    {
        public string Nric { get; set; }
    }
}
