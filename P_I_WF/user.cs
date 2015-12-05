using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P_I_WF
{
    public partial class user : Form
    {
        public user()
        {
            InitializeComponent();
        }

        private void user_Load(object sender, EventArgs e)
        {

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
