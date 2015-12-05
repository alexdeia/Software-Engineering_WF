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
            this.listView1 = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // l_hello
            // 
            this.l_hello.AutoSize = true;
            this.l_hello.Location = new System.Drawing.Point(143, 14);
            this.l_hello.Name = "l_hello";
            this.l_hello.Size = new System.Drawing.Size(110, 13);
            this.l_hello.TabIndex = 0;
            this.l_hello.Text = "Добро пожаловать, ";
            // 
            // b_exit
            // 
            this.b_exit.Location = new System.Drawing.Point(345, 9);
            this.b_exit.Name = "b_exit";
            this.b_exit.Size = new System.Drawing.Size(88, 22);
            this.b_exit.TabIndex = 1;
            this.b_exit.Text = "Выход";
            this.b_exit.UseVisualStyleBackColor = true;
            this.b_exit.Click += new System.EventHandler(this.b_exit_Click);
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(25, 72);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(613, 234);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            // 
            // user
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 340);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.b_exit);
            this.Controls.Add(this.l_hello);
            this.Name = "user";
            this.Text = "user";
            this.Load += new System.EventHandler(this.user_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label l_hello;
        private System.Windows.Forms.Button b_exit;
        private System.Windows.Forms.ListView listView1;
    }
}