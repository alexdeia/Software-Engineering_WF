namespace P_I_WF
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.b_auth = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // b_auth
            // 
            this.b_auth.Location = new System.Drawing.Point(697, 23);
            this.b_auth.Name = "b_auth";
            this.b_auth.Size = new System.Drawing.Size(108, 23);
            this.b_auth.TabIndex = 0;
            this.b_auth.Text = "Авторизация";
            this.b_auth.UseVisualStyleBackColor = true;
            this.b_auth.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 350);
            this.Controls.Add(this.b_auth);
            this.Name = "Form1";
            this.Text = "Телепрограмма";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button b_auth;
    }
}

