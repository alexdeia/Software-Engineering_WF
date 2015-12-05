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
        public SQLiteConnection l_con = new SQLiteConnection(@"data source=D:\Program Files\Project\P_I_WF\users.db");
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SQLiteCommand cm = new SQLiteCommand("SELECT * FROM [tvprog] ORDER BY time", l_con);

            try
            {
                //SQLiteDataReader dr = cm.ExecuteReader();

                //while (dr.Read())
                //{
                //    ListViewItem item = new ListViewItem(dr["show"].ToString());
                //    item.SubItems.Add(dr["time"].ToString());
                //    item.SubItems.Add(dr["leading"].ToString());
                //    item.SubItems.Add(dr["links"].ToString());

                //    ListView1.Items.Add(item);
                //}
                SQLiteDataAdapter da = new SQLiteDataAdapter(cm);
                DataTable dt = new DataTable();
                da.Fill(dt);

                foreach (DataRow dr in dt.Rows)
                {
                    ListViewItem item = new ListViewItem(dr["show"].ToString());
                    item.SubItems.Add(dr["time"].ToString());
                    item.SubItems.Add(dr["leading"].ToString());
                    item.SubItems.Add(dr["links"].ToString());

                    ListView1.Items.Add(item);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
}

        private void button1_Click(object sender, EventArgs e)
        {
            l.Show();
            this.Hide();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //SQLiteDataAdapter sda = new SQLiteDataAdapter("SELECT * FROM [users]", l_con);
            //DataTable dt = new DataTable();
            //DataSet DS = new DataSet();
            //sda.Fill(dt);
            //sda.Fill(DS);
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            try
            {
                l_con.Open();
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.ExitThread();
            }
        }
    }
}
