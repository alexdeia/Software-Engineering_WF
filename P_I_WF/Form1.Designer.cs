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
            this.label1 = new System.Windows.Forms.Label();
            this.lv_guest = new System.Windows.Forms.ListView();
            this.show = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.time = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.leading = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // b_auth
            // 
            this.b_auth.Location = new System.Drawing.Point(439, 12);
            this.b_auth.Name = "b_auth";
            this.b_auth.Size = new System.Drawing.Size(146, 23);
            this.b_auth.TabIndex = 0;
            this.b_auth.Text = "Авторизация";
            this.b_auth.UseVisualStyleBackColor = true;
            this.b_auth.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(401, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Для получения расширенного функционала пройдите процедуру регистрации";
            // 
            // lv_guest
            // 
            this.lv_guest.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.show,
            this.time,
            this.leading});
            this.lv_guest.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lv_guest.Location = new System.Drawing.Point(12, 79);
            this.lv_guest.Name = "lv_guest";
            this.lv_guest.Size = new System.Drawing.Size(573, 241);
            this.lv_guest.TabIndex = 2;
            this.lv_guest.UseCompatibleStateImageBehavior = false;
            this.lv_guest.View = System.Windows.Forms.View.Details;
            this.lv_guest.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // show
            // 
            this.show.Text = "Передача";
            this.show.Width = 176;
            // 
            // time
            // 
            this.time.Text = "Время";
            this.time.Width = 174;
            // 
            // leading
            // 
            this.leading.Text = "Имя ведущего";
            this.leading.Width = 218;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 350);
            this.Controls.Add(this.lv_guest);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.b_auth);
            this.Name = "Form1";
            this.Text = "Телепрограмма";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button b_auth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lv_guest;
        private System.Windows.Forms.ColumnHeader show;
        private System.Windows.Forms.ColumnHeader time;
        private System.Windows.Forms.ColumnHeader leading;
    }
}

