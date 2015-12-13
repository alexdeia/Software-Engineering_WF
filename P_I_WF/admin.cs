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
        public SQLiteConnection l_con = new SQLiteConnection(@"data source=|DataDirectory|\users.db");

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
            l_con.Close();

            SQLiteCommand cm = new SQLiteCommand("SELECT * FROM [usersss] ORDER BY id", l_con);

            try
            {
                SQLiteDataAdapter dau = new SQLiteDataAdapter(cm);
                DataTable dtu = new DataTable();
                dau.Fill(dtu);

                foreach (DataRow dru in dtu.Rows)
                {
                    ListViewItem item = new ListViewItem(dru["login"].ToString());
                    item.SubItems.Add(dru["groups"].ToString());

                    lv_user.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }


        private void b_add_Click(object sender, EventArgs e)
        {

            try
            {
                l_con.Open();
                SQLiteCommand cmd_add = l_con.CreateCommand();
                cmd_add.CommandText = "INSERT INTO [tvprog] ([show],[time],[leading],[links],[duration],[advert],[comments]) VALUES ('" + tb_show.Text + "', '" + mtb_time.Text + "', '" + tb_leading.Text + "', '" + tb_links.Text + "', '" + mtb_duration.Text + "', '" + mtb_advert.Text + "', '" + tb_comments.Text + "')";
                if (cmd_add.ExecuteNonQuery() == 1)
                    MessageBox.Show("Запись добавлена!");

                SQLiteCommand cmd_view = l_con.CreateCommand();
                cmd_view.CommandText = "SELECT * FROM tvprog";
                SQLiteDataReader dr = cmd_view.ExecuteReader(CommandBehavior.CloseConnection);
                DataTable dt = new DataTable();
                dt.Load(dr);
                dataGridView1.DataSource = dt;

                l_con.Close();
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void mtb_duration_Leave(object sender, EventArgs e)
        {
            try
            {
                int a = int.Parse(mtb_duration.Text);
                if (a < 30)
                    MessageBox.Show("Введите значение больше 30");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void mtb_time_Leave(object sender, EventArgs e)
        {
            //try
            //{
            //    DateTime a = DateTime.Parse(mtb_duration.Text);
            //    if (a.Hour < 4)
            //        MessageBox.Show("Введите значение больше 4:00");
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }

        private void b_edit_Click(object sender, EventArgs e)
        {
            try
            {
                l_con.Open();
                SQLiteCommand cmd_edit = l_con.CreateCommand();
               // cmd_edit.CommandText = "UPDATE [tvprog] SET show,time,leading,links,duration,advert,comments VALUES ('" + tb_show.Text + "', '" + mtb_time.Text + "', '" + tb_leading.Text + "', '" + tb_links.Text + "', '" + mtb_duration.Text + "', '" + mtb_advert.Text + "', '" + tb_comments.Text + "' WHERE id = '" + tb_id + "')";
                cmd_edit.CommandText = "UPDATE [tvprog] SET show = '" + tb_show.Text + "', time = '" + mtb_time.Text + "', leading = '" + tb_leading.Text + "', links = '" + tb_links.Text + "', duration = '" + mtb_duration.Text + "', advert = '" + mtb_advert.Text + "', comments = '" + tb_comments.Text + "' WHERE id ='"+ tb_id.Text + "'";
                if (cmd_edit.ExecuteNonQuery() == 1)
                    MessageBox.Show("Запись отредактирована! Перелогинтесь для обновления.");

                SQLiteCommand cmd_view = l_con.CreateCommand();
                cmd_view.CommandText = "SELECT * FROM tvprog";
                SQLiteDataReader dr = cmd_view.ExecuteReader(CommandBehavior.CloseConnection);
                DataTable dt = new DataTable();
                dt.Load(dr);
                dataGridView1.DataSource = dt;

                l_con.Close();
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void b_toadmin_Click(object sender, EventArgs e)
        {
            if (tb_login.Text != string.Empty)
            {
                try
                {
                    l_con.Open();
                    SQLiteCommand cmd_toadmin = l_con.CreateCommand();
                    cmd_toadmin.CommandText = "UPDATE [usersss] SET groups = 'admin' WHERE login ='" + tb_login.Text + "'";
                    if (cmd_toadmin.ExecuteNonQuery() == 1)
                        MessageBox.Show("" + tb_login.Text + " стал администратором.");

                    l_con.Close();

                }
                catch (SQLiteException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else { MessageBox.Show("Введите логин пользователя!"); }

        }

        private void b_toeditor_Click(object sender, EventArgs e)
        {
            if (tb_login.Text != string.Empty)
            {
                try
            {
                l_con.Open();
                SQLiteCommand cmd_toeditor = l_con.CreateCommand();
                cmd_toeditor.CommandText = "UPDATE [usersss] SET groups = 'editor' WHERE login ='" + tb_login.Text + "'";
                if (cmd_toeditor.ExecuteNonQuery() == 1)
                    MessageBox.Show("" + tb_login.Text + " стал редактором.");

                l_con.Close();

            }
            catch (SQLiteException ex)
            {
                MessageBox.Show(ex.Message);
            }
            }
            else { MessageBox.Show("Введите логин пользователя!"); }
        }

        private void b_touser_Click(object sender, EventArgs e)
        {
            if (tb_login.Text != string.Empty)
            {
                try
            {
                l_con.Open();
                SQLiteCommand cmd_touser = l_con.CreateCommand();
                cmd_touser.CommandText = "UPDATE [usersss] SET groups = 'user' WHERE login ='" + tb_login.Text + "'";
                if (cmd_touser.ExecuteNonQuery() == 1)
                    MessageBox.Show("" + tb_login.Text + " стал простым пользователем.");

                l_con.Close();

            }
            catch (SQLiteException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
            else { MessageBox.Show("Введите логин пользователя!"); }
}
    }
}
