using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace P_I_WF
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void b_login_Click(object sender, EventArgs e)
        {
            SqlConnection l_con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Program Files\Project\P_I_WF\users.mdf;Integrated Security=True;Connect Timeout=30;");
            //SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM [Table] WHERE login LIKE "+login_box.Text+" AND password LIKE "+password_box.Text, l_con);
            SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM [Table] WHERE login = '" + login_box.Text + "' AND password = '" + password_box.Text + "'", l_con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
                MessageBox.Show("OK");
            else MessageBox.Show("NO");
        }
    }
}
