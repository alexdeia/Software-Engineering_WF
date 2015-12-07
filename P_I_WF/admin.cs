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
    public partial class admin : Form
    {
        public SQLiteConnection l_con = new SQLiteConnection(@"data source=D:\Program Files\Project\P_I_WF\users.db");
        public admin()
        {
            InitializeComponent();
        }

        private void b_exit_Click(object sender, EventArgs e)
        {
            this.Close();
            login l = new login();
            l.Show();
        }

        private void admin_Load(object sender, EventArgs e)
        {
            l_con.Open();
            SQLiteCommand cmd_view = l_con.CreateCommand();
            cmd_view.CommandText = "SELECT * FROM tvprog";
            SQLiteDataReader dr = cmd_view.ExecuteReader(CommandBehavior.CloseConnection);
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
            // dataGridView1.DataBind();
            l_con.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            l_con.Open();
            SQLiteCommand cmd_save = l_con.CreateCommand();
            cmd_save.CommandText = "UPDATE * FROM tvprog";
            SQLiteDataReader drs = cmd_save.ExecuteReader(CommandBehavior.CloseConnection);
            DataTable dts = new DataTable();
            dts.Load(drs);
            dataGridView1.DataSource = dts;
            l_con.Close();
        }

        private void b_save_Click(object sender, EventArgs e)
        {

        }
    }
}
