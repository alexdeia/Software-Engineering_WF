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
            l_con.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void b_save_Click(object sender, EventArgs e)
        {
            //l_con.Open();

            //// DATABASE (Local): Formulate the SQL command.
            //String strSqlCommand = "SELECT * FROM tvprog";
            //System.Data.SQLite.SQLiteCommand oLocalCommand = new System.Data.SQLite.SQLiteCommand(strSqlCommand, l_con);

            //// DATABASE (Local): Get the data records.
            //SQLiteDataAdapter oLocalAdapter = new SQLiteDataAdapter(oLocalCommand);
            //oLocalAdapter.AcceptChangesDuringUpdate = true;
            //DataSet oLocalSet = new DataSet();
            //oLocalAdapter.Fill(oLocalSet, "tvprog");

            //// 
            //SQLiteCommandBuilder oBuilder = new SQLiteCommandBuilder(oLocalAdapter);

            //// Try to write to some changes.
            //String strValue = oLocalSet.Tables[0].Rows[0][7].ToString();
            //oLocalSet.Tables[0].Rows[0][7] = 8;
            //strValue = oLocalSet.Tables[0].Rows[0][7].ToString();
            //oLocalSet.AcceptChanges();
            //oLocalAdapter.UpdateCommand = oBuilder.GetUpdateCommand();
            //oLocalAdapter.Update(oLocalSet.Tables[0]);

            //// Clean up.
            //oLocalSet.Dispose();
            //oLocalAdapter.Dispose();
            //oLocalCommand.Dispose();
            //oLocalCommand = null;

            ////SQLiteDataAdapter da = new SQLiteDataAdapter("SELECT * FROM tvprog", l_con);
            ////da.UpdateCommand = new SQLiteCommand("UPDATE * FROM tvprog", l_con);
            ////SQLiteCommandBuilder cb = new SQLiteCommandBuilder(da);
            ////da.UpdateCommand = cb.GetUpdateCommand();
            //l_con.Close();


            ////l_con.Open();
            ////SQLiteCommand cmd_save = l_con.CreateCommand();
            ////cmd_save.CommandText = "UPDATE * FROM tvprog";
            ////SQLiteDataReader drs = cmd_save.ExecuteReader(CommandBehavior.CloseConnection);
            ////DataTable dts = new DataTable();
            ////dts.Load(drs);
            ////dataGridView1.DataSource = dts;
            ////l_con.Close();
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
                    MessageBox.Show("Запись отредактирована!");

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
    }
}
