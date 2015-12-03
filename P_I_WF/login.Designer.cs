namespace P_I_WF
{
    partial class login
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
            this.b_login = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.password_box = new System.Windows.Forms.TextBox();
            this.login_box = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // b_login
            // 
            this.b_login.Location = new System.Drawing.Point(140, 159);
            this.b_login.Name = "b_login";
            this.b_login.Size = new System.Drawing.Size(75, 23);
            this.b_login.TabIndex = 9;
            this.b_login.Text = "Войти";
            this.b_login.UseVisualStyleBackColor = true;
            this.b_login.Click += new System.EventHandler(this.b_login_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Пароль";
            // 
            // password_box
            // 
            this.password_box.Location = new System.Drawing.Point(140, 118);
            this.password_box.Name = "password_box";
            this.password_box.Size = new System.Drawing.Size(100, 20);
            this.password_box.TabIndex = 7;
            // 
            // login_box
            // 
            this.login_box.Location = new System.Drawing.Point(140, 78);
            this.login_box.Name = "login_box";
            this.login_box.Size = new System.Drawing.Size(100, 20);
            this.login_box.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Логин";
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.b_login);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.password_box);
            this.Controls.Add(this.login_box);
            this.Controls.Add(this.label1);
            this.Name = "login";
            this.Text = "Авторизация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button b_login;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox password_box;
        private System.Windows.Forms.TextBox login_box;
        private System.Windows.Forms.Label label1;
    }
}