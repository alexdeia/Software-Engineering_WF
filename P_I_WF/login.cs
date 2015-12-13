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
        public SQLiteConnection l_con = new SQLiteConnection(@"data source=|DataDirectory|\users.db");
        public login()
        {
            InitializeComponent();
        }

        private void b_login_Click(object sender, EventArgs e)
        {

            //SqlConnection l_con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Program Files\Project\P_I_WF\users.mdf;Integrated Security=True;Connect Timeout=30;");
            //SqlConnection l_con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\users.mdf;Integrated Security=True;Connect Timeout=30;");
            //SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM [Table] WHERE login LIKE "+login_box.Text+" AND password LIKE "+password_box.Text, l_con);
            SQLiteDataAdapter sda = new SQLiteDataAdapter("SELECT COUNT(*) FROM [usersss] WHERE login = '" + login_box.Text + "' AND password = '" + password_box.Text + "' AND groups = 'admin'", l_con);
            SQLiteDataAdapter sde = new SQLiteDataAdapter("SELECT COUNT(*) FROM [usersss] WHERE login = '" + login_box.Text + "' AND password = '" + password_box.Text + "' AND groups = 'editor'", l_con);
            SQLiteDataAdapter sdu = new SQLiteDataAdapter("SELECT COUNT(*) FROM [usersss] WHERE login = '" + login_box.Text + "' AND password = '" + password_box.Text + "' AND groups = 'user'", l_con);
            DataTable dta = new DataTable();
            DataTable dte = new DataTable();
            DataTable dtu = new DataTable();
            sda.Fill(dta);
            sde.Fill(dte);
            sdu.Fill(dtu);
            if (dtu.Rows[0][0].ToString() == "1" && login_box.Text != string.Empty && password_box.Text != string.Empty)
            {
                MessageBox.Show("Вы успешно авторизованы, " + login_box.Text);
                this.Hide();
                user u = new user();
                u.l_hello.Text = "Добро пожаловать, " + login_box.Text;
                u.Show();
            }

            else if (dte.Rows[0][0].ToString() == "1" && login_box.Text != string.Empty && password_box.Text != string.Empty)
            {
                MessageBox.Show("Вы успешно авторизованы, " + login_box.Text);
                this.Hide();
                admin adm = new admin();
                adm.l_hello.Text = "Добро пожаловать, " + login_box.Text;
                adm.gb_admin.Enabled = false;
                adm.Show();

            }
            else if (dta.Rows[0][0].ToString() == "1" && login_box.Text != string.Empty && password_box.Text != string.Empty)
            {
                MessageBox.Show("Вы успешно авторизованы, " + login_box.Text);
                this.Hide();
                admin adm = new admin();
                adm.l_hello.Text = "Добро пожаловать, " + login_box.Text;
                adm.Show();

            }
            else if (login_box.Text == string.Empty)
            { MessageBox.Show("Введите логин"); }

            else if (password_box.Text == string.Empty)
            { MessageBox.Show("Введите пароль"); }

            else { MessageBox.Show("Неправильный логин/пароль"); }
        }

        private void password_box_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void cb_pass_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_pass.Checked == true) { password_box.UseSystemPasswordChar = false; } else { password_box.UseSystemPasswordChar = true; }
        }

        private void b_reg_Click(object sender, EventArgs e)
        {
            try
            {
                l_con.Open();
                SQLiteCommand cmd_reg = l_con.CreateCommand();
                cmd_reg.CommandText = "INSERT INTO [usersss] ([login],[password], [groups]) VALUES ('" + login_box.Text + "', '" + password_box.Text + "', 'user')";
                if (cmd_reg.ExecuteNonQuery() == 1)
                    MessageBox.Show("Вы успешно зарегистрированы!");
                l_con.Close();
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void login_Load(object sender, EventArgs e)
        {

        }
    }
}