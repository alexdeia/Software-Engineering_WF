namespace P_I_WF
{
    partial class admin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(admin));
            this.l_hello = new System.Windows.Forms.Label();
            this.b_exit = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.b_add = new System.Windows.Forms.Button();
            this.tb_show = new System.Windows.Forms.TextBox();
            this.tb_leading = new System.Windows.Forms.TextBox();
            this.tb_links = new System.Windows.Forms.TextBox();
            this.tb_comments = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.mtb_time = new System.Windows.Forms.MaskedTextBox();
            this.mtb_duration = new System.Windows.Forms.MaskedTextBox();
            this.mtb_advert = new System.Windows.Forms.MaskedTextBox();
            this.b_edit = new System.Windows.Forms.Button();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lv_user = new System.Windows.Forms.ListView();
            this.login = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groups = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tb_login = new System.Windows.Forms.TextBox();
            this.b_toadmin = new System.Windows.Forms.Button();
            this.b_toeditor = new System.Windows.Forms.Button();
            this.b_touser = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.gb_admin = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gb_admin.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // l_hello
            // 
            this.l_hello.AutoSize = true;
            this.l_hello.Location = new System.Drawing.Point(286, 9);
            this.l_hello.Name = "l_hello";
            this.l_hello.Size = new System.Drawing.Size(110, 13);
            this.l_hello.TabIndex = 1;
            this.l_hello.Text = "Добро пожаловать, ";
            // 
            // b_exit
            // 
            this.b_exit.Location = new System.Drawing.Point(475, 4);
            this.b_exit.Name = "b_exit";
            this.b_exit.Size = new System.Drawing.Size(88, 22);
            this.b_exit.TabIndex = 2;
            this.b_exit.Text = "Выход";
            this.b_exit.UseVisualStyleBackColor = true;
            this.b_exit.Click += new System.EventHandler(this.b_exit_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(847, 199);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // b_add
            // 
            this.b_add.Location = new System.Drawing.Point(348, 83);
            this.b_add.Name = "b_add";
            this.b_add.Size = new System.Drawing.Size(79, 34);
            this.b_add.TabIndex = 5;
            this.b_add.Text = "Добавить";
            this.b_add.UseVisualStyleBackColor = true;
            this.b_add.Click += new System.EventHandler(this.b_add_Click);
            // 
            // tb_show
            // 
            this.tb_show.Location = new System.Drawing.Point(6, 52);
            this.tb_show.Name = "tb_show";
            this.tb_show.Size = new System.Drawing.Size(100, 20);
            this.tb_show.TabIndex = 6;
            // 
            // tb_leading
            // 
            this.tb_leading.Location = new System.Drawing.Point(218, 52);
            this.tb_leading.Name = "tb_leading";
            this.tb_leading.Size = new System.Drawing.Size(100, 20);
            this.tb_leading.TabIndex = 8;
            // 
            // tb_links
            // 
            this.tb_links.Location = new System.Drawing.Point(324, 52);
            this.tb_links.Name = "tb_links";
            this.tb_links.Size = new System.Drawing.Size(103, 20);
            this.tb_links.TabIndex = 9;
            // 
            // tb_comments
            // 
            this.tb_comments.Location = new System.Drawing.Point(209, 96);
            this.tb_comments.Name = "tb_comments";
            this.tb_comments.Size = new System.Drawing.Size(133, 20);
            this.tb_comments.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Передача";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(112, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Дата эфира";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(221, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Ведущий";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(324, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Описание";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Продолжительность";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(112, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Рекламных пауз";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(209, 80);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Комментарии";
            // 
            // mtb_time
            // 
            this.mtb_time.Location = new System.Drawing.Point(112, 52);
            this.mtb_time.Mask = "00:00";
            this.mtb_time.Name = "mtb_time";
            this.mtb_time.Size = new System.Drawing.Size(100, 20);
            this.mtb_time.TabIndex = 21;
            this.mtb_time.ValidatingType = typeof(System.DateTime);
            this.mtb_time.Leave += new System.EventHandler(this.mtb_time_Leave);
            // 
            // mtb_duration
            // 
            this.mtb_duration.Location = new System.Drawing.Point(6, 98);
            this.mtb_duration.Mask = "000";
            this.mtb_duration.Name = "mtb_duration";
            this.mtb_duration.Size = new System.Drawing.Size(101, 20);
            this.mtb_duration.TabIndex = 22;
            this.mtb_duration.Leave += new System.EventHandler(this.mtb_duration_Leave);
            // 
            // mtb_advert
            // 
            this.mtb_advert.Location = new System.Drawing.Point(115, 98);
            this.mtb_advert.Mask = "000";
            this.mtb_advert.Name = "mtb_advert";
            this.mtb_advert.Size = new System.Drawing.Size(88, 20);
            this.mtb_advert.TabIndex = 23;
            // 
            // b_edit
            // 
            this.b_edit.Location = new System.Drawing.Point(348, 133);
            this.b_edit.Name = "b_edit";
            this.b_edit.Size = new System.Drawing.Size(79, 23);
            this.b_edit.TabIndex = 24;
            this.b_edit.Text = "Изменить";
            this.b_edit.UseVisualStyleBackColor = true;
            this.b_edit.Click += new System.EventHandler(this.b_edit_Click);
            // 
            // tb_id
            // 
            this.tb_id.Location = new System.Drawing.Point(6, 136);
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(24, 20);
            this.tb_id.TabIndex = 25;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(4, 120);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(18, 13);
            this.label9.TabIndex = 26;
            this.label9.Text = "ID";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(30, 139);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(319, 13);
            this.label10.TabIndex = 27;
            this.label10.Text = "Для редактирования записи укажите ID передачи и нажмите";
            // 
            // lv_user
            // 
            this.lv_user.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.login,
            this.groups});
            this.lv_user.Location = new System.Drawing.Point(224, 16);
            this.lv_user.Name = "lv_user";
            this.lv_user.Size = new System.Drawing.Size(184, 148);
            this.lv_user.TabIndex = 28;
            this.lv_user.UseCompatibleStateImageBehavior = false;
            this.lv_user.View = System.Windows.Forms.View.Details;
            // 
            // login
            // 
            this.login.Text = "Логин";
            this.login.Width = 98;
            // 
            // groups
            // 
            this.groups.Text = "Группа";
            this.groups.Width = 79;
            // 
            // tb_login
            // 
            this.tb_login.Location = new System.Drawing.Point(6, 93);
            this.tb_login.Name = "tb_login";
            this.tb_login.Size = new System.Drawing.Size(98, 20);
            this.tb_login.TabIndex = 29;
            // 
            // b_toadmin
            // 
            this.b_toadmin.Location = new System.Drawing.Point(110, 41);
            this.b_toadmin.Name = "b_toadmin";
            this.b_toadmin.Size = new System.Drawing.Size(97, 37);
            this.b_toadmin.TabIndex = 30;
            this.b_toadmin.Text = "Администратор";
            this.b_toadmin.UseVisualStyleBackColor = true;
            this.b_toadmin.Click += new System.EventHandler(this.b_toadmin_Click);
            // 
            // b_toeditor
            // 
            this.b_toeditor.Location = new System.Drawing.Point(110, 84);
            this.b_toeditor.Name = "b_toeditor";
            this.b_toeditor.Size = new System.Drawing.Size(97, 37);
            this.b_toeditor.TabIndex = 31;
            this.b_toeditor.Text = "Редактор";
            this.b_toeditor.UseVisualStyleBackColor = true;
            this.b_toeditor.Click += new System.EventHandler(this.b_toeditor_Click);
            // 
            // b_touser
            // 
            this.b_touser.Location = new System.Drawing.Point(110, 127);
            this.b_touser.Name = "b_touser";
            this.b_touser.Size = new System.Drawing.Size(97, 37);
            this.b_touser.TabIndex = 32;
            this.b_touser.Text = "Пользователь";
            this.b_touser.UseVisualStyleBackColor = true;
            this.b_touser.Click += new System.EventHandler(this.b_touser_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(27, 77);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 13);
            this.label11.TabIndex = 33;
            this.label11.Text = "Логин";
            // 
            // gb_admin
            // 
            this.gb_admin.Controls.Add(this.lv_user);
            this.gb_admin.Controls.Add(this.tb_login);
            this.gb_admin.Controls.Add(this.label11);
            this.gb_admin.Controls.Add(this.b_toadmin);
            this.gb_admin.Controls.Add(this.b_touser);
            this.gb_admin.Controls.Add(this.b_toeditor);
            this.gb_admin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gb_admin.Location = new System.Drawing.Point(452, 237);
            this.gb_admin.Name = "gb_admin";
            this.gb_admin.Size = new System.Drawing.Size(414, 189);
            this.gb_admin.TabIndex = 34;
            this.gb_admin.TabStop = false;
            this.gb_admin.Text = "Редактирование прав";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.b_add);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.tb_show);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.tb_leading);
            this.groupBox1.Controls.Add(this.tb_id);
            this.groupBox1.Controls.Add(this.tb_links);
            this.groupBox1.Controls.Add(this.b_edit);
            this.groupBox1.Controls.Add(this.tb_comments);
            this.groupBox1.Controls.Add(this.mtb_advert);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.mtb_duration);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.mtb_time);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(15, 237);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(431, 189);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Добавить новую запись";
            // 
            // admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 431);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gb_admin);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.b_exit);
            this.Controls.Add(this.l_hello);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "admin";
            this.Text = "Панель редакции и администрации телеканала Alpha";
            this.Load += new System.EventHandler(this.admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gb_admin.ResumeLayout(false);
            this.gb_admin.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label l_hello;
        private System.Windows.Forms.Button b_exit;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button b_add;
        private System.Windows.Forms.TextBox tb_show;
        private System.Windows.Forms.TextBox tb_leading;
        private System.Windows.Forms.TextBox tb_links;
        private System.Windows.Forms.TextBox tb_comments;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox mtb_time;
        private System.Windows.Forms.MaskedTextBox mtb_duration;
        private System.Windows.Forms.MaskedTextBox mtb_advert;
        private System.Windows.Forms.Button b_edit;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ListView lv_user;
        private System.Windows.Forms.ColumnHeader login;
        private System.Windows.Forms.ColumnHeader groups;
        private System.Windows.Forms.TextBox tb_login;
        public System.Windows.Forms.Button b_toadmin;
        public System.Windows.Forms.Button b_toeditor;
        public System.Windows.Forms.Button b_touser;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.GroupBox gb_admin;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}