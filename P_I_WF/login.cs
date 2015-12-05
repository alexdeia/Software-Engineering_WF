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
using System.Data.SQLite;

namespace P_I_WF
{
    public partial class login : Form
    {
        public SQLiteConnection l_con = new SQLiteConnection(@"data source=D:\Program Files\Project\P_I_WF\users.db");
        public login()
        {
            InitializeComponent();
        }

        private void b_login_Click(object sender, EventArgs e)
        {
            
            //SqlConnection l_con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Program Files\Project\P_I_WF\users.mdf;Integrated Security=True;Connect Timeout=30;");
            //SqlConnection l_con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\users.mdf;Integrated Security=True;Connect Timeout=30;");
            //SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM [Table] WHERE login LIKE "+login_box.Text+" AND password LIKE "+password_box.Text, l_con);
            SQLiteDataAdapter sda = new SQLiteDataAdapter("SELECT COUNT(*) FROM [users] WHERE login = '" + login_box.Text + "' AND password = '" + password_box.Text + "'", l_con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                MessageBox.Show("Вы успешно авторизированы");
                this.Hide();
                user u = new user();
                u.l_hello.Text = "Добро пожаловать, " + login_box.Text;
                u.Show();
            
            } else { 
                MessageBox.Show("Неправильный логин/пароль");

            }
        }

        private void password_box_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void cb_pass_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_pass.Checked == true) { password_box.UseSystemPasswordChar = false; } else { password_box.UseSystemPasswordChar = true; }
        }

    }
}
