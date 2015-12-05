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
            this.ListView1 = new System.Windows.Forms.ListView();
            this.show = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.time = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.leading = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.links = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // b_auth
            // 
            this.b_auth.Location = new System.Drawing.Point(583, 12);
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
            this.label1.Location = new System.Drawing.Point(92, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(401, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Для получения расширенного функционала пройдите процедуру регистрации";
            // 
            // ListView1
            // 
            this.ListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.show,
            this.time,
            this.leading,
            this.links});
            this.ListView1.Location = new System.Drawing.Point(13, 82);
            this.ListView1.Name = "ListView1";
            this.ListView1.Size = new System.Drawing.Size(893, 230);
            this.ListView1.TabIndex = 2;
            this.ListView1.UseCompatibleStateImageBehavior = false;
            this.ListView1.View = System.Windows.Forms.View.Details;
            this.ListView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // show
            // 
            this.show.Text = "Передача";
            this.show.Width = 100;
            // 
            // time
            // 
            this.time.Text = "Время";
            this.time.Width = 70;
            // 
            // leading
            // 
            this.leading.Text = "Имя ведущего";
            this.leading.Width = 120;
            // 
            // links
            // 
            this.links.Text = "Подробное описание";
            this.links.Width = 120;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 350);
            this.Controls.Add(this.ListView1);
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
        private System.Windows.Forms.ListView ListView1;
        private System.Windows.Forms.ColumnHeader show;
        private System.Windows.Forms.ColumnHeader time;
        private System.Windows.Forms.ColumnHeader leading;
        private System.Windows.Forms.ColumnHeader links;
    }
}

