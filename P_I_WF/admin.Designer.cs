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
            this.b_add = new System.Windows.Forms.Button();
            this.tb_show = new System.Windows.Forms.TextBox();
            this.tb_leading = new System.Windows.Forms.TextBox();
            this.tb_links = new System.Windows.Forms.TextBox();
            this.tb_comments = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
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
            // b_add
            // 
            this.b_add.Location = new System.Drawing.Point(773, 300);
            this.b_add.Name = "b_add";
            this.b_add.Size = new System.Drawing.Size(86, 23);
            this.b_add.TabIndex = 5;
            this.b_add.Text = "Добавить";
            this.b_add.UseVisualStyleBackColor = true;
            this.b_add.Click += new System.EventHandler(this.b_add_Click);
            // 
            // tb_show
            // 
            this.tb_show.Location = new System.Drawing.Point(12, 306);
            this.tb_show.Name = "tb_show";
            this.tb_show.Size = new System.Drawing.Size(100, 20);
            this.tb_show.TabIndex = 6;
            // 
            // tb_leading
            // 
            this.tb_leading.Location = new System.Drawing.Point(224, 306);
            this.tb_leading.Name = "tb_leading";
            this.tb_leading.Size = new System.Drawing.Size(100, 20);
            this.tb_leading.TabIndex = 8;
            // 
            // tb_links
            // 
            this.tb_links.Location = new System.Drawing.Point(330, 306);
            this.tb_links.Name = "tb_links";
            this.tb_links.Size = new System.Drawing.Size(100, 20);
            this.tb_links.TabIndex = 9;
            // 
            // tb_comments
            // 
            this.tb_comments.Location = new System.Drawing.Point(664, 305);
            this.tb_comments.Name = "tb_comments";
            this.tb_comments.Size = new System.Drawing.Size(100, 20);
            this.tb_comments.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 265);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Добавить новую запись";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 290);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Передача";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(118, 290);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Дата эфира";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(227, 290);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Ведущий";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(330, 290);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Описание";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(436, 290);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Продолжительность";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(558, 289);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Рекламных пауз";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(665, 289);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Комментарии";
            // 
            // mtb_time
            // 
            this.mtb_time.Location = new System.Drawing.Point(118, 306);
            this.mtb_time.Mask = "00:00";
            this.mtb_time.Name = "mtb_time";
            this.mtb_time.Size = new System.Drawing.Size(100, 20);
            this.mtb_time.TabIndex = 21;
            this.mtb_time.ValidatingType = typeof(System.DateTime);
            this.mtb_time.Leave += new System.EventHandler(this.mtb_time_Leave);
            // 
            // mtb_duration
            // 
            this.mtb_duration.Location = new System.Drawing.Point(436, 306);
            this.mtb_duration.Mask = "000";
            this.mtb_duration.Name = "mtb_duration";
            this.mtb_duration.Size = new System.Drawing.Size(116, 20);
            this.mtb_duration.TabIndex = 22;
            this.mtb_duration.Leave += new System.EventHandler(this.mtb_duration_Leave);
            // 
            // mtb_advert
            // 
            this.mtb_advert.Location = new System.Drawing.Point(558, 305);
            this.mtb_advert.Mask = "000";
            this.mtb_advert.Name = "mtb_advert";
            this.mtb_advert.Size = new System.Drawing.Size(100, 20);
            this.mtb_advert.TabIndex = 23;
            // 
            // b_edit
            // 
            this.b_edit.Location = new System.Drawing.Point(773, 329);
            this.b_edit.Name = "b_edit";
            this.b_edit.Size = new System.Drawing.Size(86, 23);
            this.b_edit.TabIndex = 24;
            this.b_edit.Text = "Изменить";
            this.b_edit.UseVisualStyleBackColor = true;
            this.b_edit.Click += new System.EventHandler(this.b_edit_Click);
            // 
            // tb_id
            // 
            this.tb_id.Location = new System.Drawing.Point(12, 347);
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(26, 20);
            this.tb_id.TabIndex = 25;
            // 
            // admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 568);
            this.Controls.Add(this.tb_id);
            this.Controls.Add(this.b_edit);
            this.Controls.Add(this.mtb_advert);
            this.Controls.Add(this.mtb_duration);
            this.Controls.Add(this.mtb_time);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_comments);
            this.Controls.Add(this.tb_links);
            this.Controls.Add(this.tb_leading);
            this.Controls.Add(this.tb_show);
            this.Controls.Add(this.b_add);
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
        private System.Windows.Forms.Button b_add;
        private System.Windows.Forms.TextBox tb_show;
        private System.Windows.Forms.TextBox tb_leading;
        private System.Windows.Forms.TextBox tb_links;
        private System.Windows.Forms.TextBox tb_comments;
        private System.Windows.Forms.Label label1;
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
    }
}