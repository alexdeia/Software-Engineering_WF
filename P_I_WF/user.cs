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
    public partial class user : Form
    {
        public SQLiteConnection l_con = new SQLiteConnection(@"data source=|DataDirectory|\users.db");
        public user()
        {
            InitializeComponent();
        }

        private void user_Load(object sender, EventArgs e)
        {
            SQLiteCommand cm = new SQLiteCommand("SELECT * FROM [tvprog] ORDER BY time", l_con);

            try
            {

                SQLiteDataAdapter dautv = new SQLiteDataAdapter(cm);
                DataTable dtutv = new DataTable();
                dautv.Fill(dtutv);

                foreach (DataRow drutv in dtutv.Rows)
                {
                    ListViewItem item = new ListViewItem(drutv["show"].ToString());
                    item.SubItems.Add(drutv["time"].ToString());
                    item.SubItems.Add(drutv["leading"].ToString());
                    item.SubItems.Add(drutv["duration"].ToString());
                    item.SubItems.Add(drutv["advert"].ToString());
                    item.SubItems.Add(drutv["comments"].ToString());

                    lv_user_tv.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void b_close_Click(object sender, EventArgs e)
        {

            
        }

        private void b_exit_Click(object sender, EventArgs e)
        {
            this.Close();
            login l = new login();
            l.Show();
        }
    }
}
