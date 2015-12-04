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
            this.SuspendLayout();
            // 
            // l_hello
            // 
            this.l_hello.AutoSize = true;
            this.l_hello.Location = new System.Drawing.Point(12, 9);
            this.l_hello.Name = "l_hello";
            this.l_hello.Size = new System.Drawing.Size(110, 13);
            this.l_hello.TabIndex = 0;
            this.l_hello.Text = "Добро пожаловать, ";
            // 
            // user
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 268);
            this.Controls.Add(this.l_hello);
            this.Name = "user";
            this.Text = "user";
            this.Load += new System.EventHandler(this.user_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label l_hello;
    }
}