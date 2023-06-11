namespace ARM_V2._0
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textpass = new System.Windows.Forms.TextBox();
            this.textlogin = new System.Windows.Forms.TextBox();
            this.exit = new System.Windows.Forms.Button();
            this.singin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(190, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "Добро пожаловать ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(109, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Пароль";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(109, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Логин";
            // 
            // textpass
            // 
            this.textpass.Location = new System.Drawing.Point(112, 219);
            this.textpass.Name = "textpass";
            this.textpass.Size = new System.Drawing.Size(281, 22);
            this.textpass.TabIndex = 10;
            // 
            // textlogin
            // 
            this.textlogin.Location = new System.Drawing.Point(112, 167);
            this.textlogin.Name = "textlogin";
            this.textlogin.Size = new System.Drawing.Size(281, 22);
            this.textlogin.TabIndex = 9;
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(163, 324);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(183, 33);
            this.exit.TabIndex = 8;
            this.exit.Text = "Выход";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click_1);
            // 
            // singin
            // 
            this.singin.Location = new System.Drawing.Point(163, 276);
            this.singin.Name = "singin";
            this.singin.Size = new System.Drawing.Size(184, 42);
            this.singin.TabIndex = 7;
            this.singin.Text = "Войти";
            this.singin.UseVisualStyleBackColor = true;
            this.singin.Click += new System.EventHandler(this.singin_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.BackgroundImage = global::ARM_V2._0.Properties.Resources.Без_имени_1;
            this.ClientSize = new System.Drawing.Size(498, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textpass);
            this.Controls.Add(this.textlogin);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.singin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textpass;
        private System.Windows.Forms.TextBox textlogin;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button singin;
    }
}

