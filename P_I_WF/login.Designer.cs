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
            this.b_reg = new System.Windows.Forms.Button();
            this.cb_pass = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // b_login
            // 
            this.b_login.Location = new System.Drawing.Point(19, 116);
            this.b_login.Name = "b_login";
            this.b_login.Size = new System.Drawing.Size(192, 23);
            this.b_login.TabIndex = 9;
            this.b_login.Text = "Войти";
            this.b_login.UseVisualStyleBackColor = true;
            this.b_login.Click += new System.EventHandler(this.b_login_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Пароль";
            // 
            // password_box
            // 
            this.password_box.Location = new System.Drawing.Point(77, 64);
            this.password_box.Name = "password_box";
            this.password_box.Size = new System.Drawing.Size(134, 20);
            this.password_box.TabIndex = 7;
            this.password_box.UseSystemPasswordChar = true;
            this.password_box.TextChanged += new System.EventHandler(this.password_box_TextChanged);
            // 
            // login_box
            // 
            this.login_box.Location = new System.Drawing.Point(77, 24);
            this.login_box.Name = "login_box";
            this.login_box.Size = new System.Drawing.Size(134, 20);
            this.login_box.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Логин";
            // 
            // b_reg
            // 
            this.b_reg.Location = new System.Drawing.Point(19, 154);
            this.b_reg.Name = "b_reg";
            this.b_reg.Size = new System.Drawing.Size(192, 23);
            this.b_reg.TabIndex = 10;
            this.b_reg.Text = "Зерегистрироваться";
            this.b_reg.UseVisualStyleBackColor = true;
            this.b_reg.Click += new System.EventHandler(this.b_reg_Click);
            // 
            // cb_pass
            // 
            this.cb_pass.AutoSize = true;
            this.cb_pass.Location = new System.Drawing.Point(77, 93);
            this.cb_pass.Name = "cb_pass";
            this.cb_pass.Size = new System.Drawing.Size(114, 17);
            this.cb_pass.TabIndex = 11;
            this.cb_pass.Text = "Показать пароль";
            this.cb_pass.UseVisualStyleBackColor = true;
            this.cb_pass.CheckedChanged += new System.EventHandler(this.cb_pass_CheckedChanged);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 195);
            this.Controls.Add(this.cb_pass);
            this.Controls.Add(this.b_reg);
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
        private System.Windows.Forms.Button b_reg;
        private System.Windows.Forms.CheckBox cb_pass;
    }
}