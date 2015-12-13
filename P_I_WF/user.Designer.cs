namespace P_I_WF
{
    partial class user
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
            this.lv_user_tv = new System.Windows.Forms.ListView();
            this.show = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.time = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.leading = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.duration = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.advert = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.comments = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // l_hello
            // 
            this.l_hello.AutoSize = true;
            this.l_hello.Location = new System.Drawing.Point(188, 11);
            this.l_hello.Name = "l_hello";
            this.l_hello.Size = new System.Drawing.Size(110, 13);
            this.l_hello.TabIndex = 0;
            this.l_hello.Text = "Добро пожаловать, ";
            // 
            // b_exit
            // 
            this.b_exit.Location = new System.Drawing.Point(390, 6);
            this.b_exit.Name = "b_exit";
            this.b_exit.Size = new System.Drawing.Size(88, 22);
            this.b_exit.TabIndex = 1;
            this.b_exit.Text = "Выход";
            this.b_exit.UseVisualStyleBackColor = true;
            this.b_exit.Click += new System.EventHandler(this.b_exit_Click);
            // 
            // lv_user_tv
            // 
            this.lv_user_tv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.show,
            this.time,
            this.leading,
            this.duration,
            this.advert,
            this.comments});
            this.lv_user_tv.Location = new System.Drawing.Point(12, 36);
            this.lv_user_tv.Name = "lv_user_tv";
            this.lv_user_tv.Size = new System.Drawing.Size(802, 234);
            this.lv_user_tv.TabIndex = 2;
            this.lv_user_tv.UseCompatibleStateImageBehavior = false;
            this.lv_user_tv.View = System.Windows.Forms.View.Details;
            // 
            // show
            // 
            this.show.Text = "Название передачи";
            this.show.Width = 141;
            // 
            // time
            // 
            this.time.Text = "Дата начала";
            this.time.Width = 174;
            // 
            // leading
            // 
            this.leading.Text = "Ведущий";
            this.leading.Width = 105;
            // 
            // duration
            // 
            this.duration.Text = "Продолжительность";
            this.duration.Width = 121;
            // 
            // advert
            // 
            this.advert.Text = "Рекламных пауз";
            this.advert.Width = 99;
            // 
            // comments
            // 
            this.comments.Text = "Комментарии";
            this.comments.Width = 149;
            // 
            // user
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 284);
            this.Controls.Add(this.lv_user_tv);
            this.Controls.Add(this.b_exit);
            this.Controls.Add(this.l_hello);
            this.Name = "user";
            this.Text = "Программа телепередач канала Alpha";
            this.Load += new System.EventHandler(this.user_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label l_hello;
        private System.Windows.Forms.Button b_exit;
        private System.Windows.Forms.ListView lv_user_tv;
        private System.Windows.Forms.ColumnHeader show;
        private System.Windows.Forms.ColumnHeader time;
        private System.Windows.Forms.ColumnHeader leading;
        private System.Windows.Forms.ColumnHeader duration;
        private System.Windows.Forms.ColumnHeader advert;
        private System.Windows.Forms.ColumnHeader comments;
    }
}