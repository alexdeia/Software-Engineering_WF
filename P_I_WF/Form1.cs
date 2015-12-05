using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace P_I_WF
{
    public partial class Form1 : Form
    {
        login l = new login();
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            l.Show();
            this.Hide();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SQLiteConnection l_con = new SQLiteConnection(@"data source=D:\Program Files\Project\P_I_WF\users.db");
            SQLiteDataAdapter sda = new SQLiteDataAdapter("SELECT * FROM [users]", l_con);
            DataTable dt = new DataTable();
            DataSet DS = new DataSet();
            sda.Fill(dt);
            sda.Fill(DS);
        }

    }
}
