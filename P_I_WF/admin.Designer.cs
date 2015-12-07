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
            this.l_hello = new System.Windows.Forms.Label();
            this.b_exit = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.b_save = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tb_show = new System.Windows.Forms.TextBox();
            this.tb_time = new System.Windows.Forms.TextBox();
            this.tb_leading = new System.Windows.Forms.TextBox();
            this.tb_links = new System.Windows.Forms.TextBox();
            this.tb_duration = new System.Windows.Forms.TextBox();
            this.tb_advert = new System.Windows.Forms.TextBox();
            this.tb_comments = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // l_hello
            // 
            this.l_hello.AutoSize = true;
            this.l_hello.Location = new System.Drawing.Point(12, 9);
            this.l_hello.Name = "l_hello";
            this.l_hello.Size = new System.Drawing.Size(110, 13);
            this.l_hello.TabIndex = 1;
            this.l_hello.Text = "Добро пожаловать, ";
            // 
            // b_exit
            // 
            this.b_exit.Location = new System.Drawing.Point(201, 4);
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
            this.dataGridView1.Location = new System.Drawing.Point(12, 63);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(847, 179);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // b_save
            // 
            this.b_save.Location = new System.Drawing.Point(748, 248);
            this.b_save.Name = "b_save";
            this.b_save.Size = new System.Drawing.Size(111, 46);
            this.b_save.TabIndex = 4;
            this.b_save.Text = "Сохранить";
            this.b_save.UseVisualStyleBackColor = true;
            this.b_save.Click += new System.EventHandler(this.b_save_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(773, 303);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tb_show
            // 
            this.tb_show.Location = new System.Drawing.Point(15, 306);
            this.tb_show.Name = "tb_show";
            this.tb_show.Size = new System.Drawing.Size(100, 20);
            this.tb_show.TabIndex = 6;
            // 
            // tb_time
            // 
            this.tb_time.Location = new System.Drawing.Point(121, 306);
            this.tb_time.Name = "tb_time";
            this.tb_time.Size = new System.Drawing.Size(100, 20);
            this.tb_time.TabIndex = 7;
            // 
            // tb_leading
            // 
            this.tb_leading.Location = new System.Drawing.Point(227, 306);
            this.tb_leading.Name = "tb_leading";
            this.tb_leading.Size = new System.Drawing.Size(100, 20);
            this.tb_leading.TabIndex = 8;
            // 
            // tb_links
            // 
            this.tb_links.Location = new System.Drawing.Point(333, 306);
            this.tb_links.Name = "tb_links";
            this.tb_links.Size = new System.Drawing.Size(100, 20);
            this.tb_links.TabIndex = 9;
            // 
            // tb_duration
            // 
            this.tb_duration.Location = new System.Drawing.Point(439, 306);
            this.tb_duration.Name = "tb_duration";
            this.tb_duration.Size = new System.Drawing.Size(100, 20);
            this.tb_duration.TabIndex = 10;
            // 
            // tb_advert
            // 
            this.tb_advert.Location = new System.Drawing.Point(545, 306);
            this.tb_advert.Name = "tb_advert";
            this.tb_advert.Size = new System.Drawing.Size(100, 20);
            this.tb_advert.TabIndex = 11;
            // 
            // tb_comments
            // 
            this.tb_comments.Location = new System.Drawing.Point(651, 306);
            this.tb_comments.Name = "tb_comments";
            this.tb_comments.Size = new System.Drawing.Size(100, 20);
            this.tb_comments.TabIndex = 12;
            // 
            // admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 568);
            this.Controls.Add(this.tb_comments);
            this.Controls.Add(this.tb_advert);
            this.Controls.Add(this.tb_duration);
            this.Controls.Add(this.tb_links);
            this.Controls.Add(this.tb_leading);
            this.Controls.Add(this.tb_time);
            this.Controls.Add(this.tb_show);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.b_save);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.b_exit);
            this.Controls.Add(this.l_hello);
            this.Name = "admin";
            this.Text = "admin";
            this.Load += new System.EventHandler(this.admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label l_hello;
        private System.Windows.Forms.Button b_exit;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button b_save;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tb_show;
        private System.Windows.Forms.TextBox tb_time;
        private System.Windows.Forms.TextBox tb_leading;
        private System.Windows.Forms.TextBox tb_links;
        private System.Windows.Forms.TextBox tb_duration;
        private System.Windows.Forms.TextBox tb_advert;
        private System.Windows.Forms.TextBox tb_comments;
    }
}