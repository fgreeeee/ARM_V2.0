namespace ARM_V2._0
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Text_ID = new System.Windows.Forms.TextBox();
            this.Text_Find = new System.Windows.Forms.TextBox();
            this.text_KOD = new System.Windows.Forms.TextBox();
            this.text_PROD = new System.Windows.Forms.TextBox();
            this.text_PRICE = new System.Windows.Forms.TextBox();
            this.text_IDKLIENT = new System.Windows.Forms.TextBox();
            this.BTN_SAVE = new System.Windows.Forms.Button();
            this.BTN_DELETE = new System.Windows.Forms.Button();
            this.RTN_CHANGE = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.text_DATE = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.text_PAY1 = new System.Windows.Forms.ComboBox();
            this.text_STAT1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.InactiveBorder;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1188, 442);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(12, 498);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID Заказа";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(12, 534);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Код";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(397, 498);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Товар";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(397, 537);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Статус";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(397, 578);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Оплата";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(792, 498);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Цена";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(792, 537);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 16);
            this.label7.TabIndex = 7;
            this.label7.Text = "ID Клиента";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label8.Location = new System.Drawing.Point(792, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 16);
            this.label8.TabIndex = 8;
            this.label8.Text = "Поиск";
            // 
            // Text_ID
            // 
            this.Text_ID.Location = new System.Drawing.Point(112, 495);
            this.Text_ID.Name = "Text_ID";
            this.Text_ID.Size = new System.Drawing.Size(196, 22);
            this.Text_ID.TabIndex = 9;
            // 
            // Text_Find
            // 
            this.Text_Find.Location = new System.Drawing.Point(894, 8);
            this.Text_Find.Name = "Text_Find";
            this.Text_Find.Size = new System.Drawing.Size(196, 22);
            this.Text_Find.TabIndex = 10;
            this.Text_Find.TextChanged += new System.EventHandler(this.Text_Find_TextChanged);
            // 
            // text_KOD
            // 
            this.text_KOD.Location = new System.Drawing.Point(112, 531);
            this.text_KOD.Name = "text_KOD";
            this.text_KOD.Size = new System.Drawing.Size(196, 22);
            this.text_KOD.TabIndex = 11;
            // 
            // text_PROD
            // 
            this.text_PROD.Location = new System.Drawing.Point(493, 495);
            this.text_PROD.Name = "text_PROD";
            this.text_PROD.Size = new System.Drawing.Size(196, 22);
            this.text_PROD.TabIndex = 12;
            // 
            // text_PRICE
            // 
            this.text_PRICE.Location = new System.Drawing.Point(894, 495);
            this.text_PRICE.Name = "text_PRICE";
            this.text_PRICE.Size = new System.Drawing.Size(196, 22);
            this.text_PRICE.TabIndex = 15;
            // 
            // text_IDKLIENT
            // 
            this.text_IDKLIENT.Location = new System.Drawing.Point(894, 534);
            this.text_IDKLIENT.Name = "text_IDKLIENT";
            this.text_IDKLIENT.Size = new System.Drawing.Size(196, 22);
            this.text_IDKLIENT.TabIndex = 16;
            // 
            // BTN_SAVE
            // 
            this.BTN_SAVE.Location = new System.Drawing.Point(12, 561);
            this.BTN_SAVE.Name = "BTN_SAVE";
            this.BTN_SAVE.Size = new System.Drawing.Size(95, 44);
            this.BTN_SAVE.TabIndex = 17;
            this.BTN_SAVE.Text = "Сохранить";
            this.BTN_SAVE.UseVisualStyleBackColor = true;
            this.BTN_SAVE.Click += new System.EventHandler(this.BTN_SAVE_Click);
            // 
            // BTN_DELETE
            // 
            this.BTN_DELETE.Location = new System.Drawing.Point(112, 561);
            this.BTN_DELETE.Name = "BTN_DELETE";
            this.BTN_DELETE.Size = new System.Drawing.Size(95, 44);
            this.BTN_DELETE.TabIndex = 18;
            this.BTN_DELETE.Text = "Удалить";
            this.BTN_DELETE.UseVisualStyleBackColor = true;
            this.BTN_DELETE.Click += new System.EventHandler(this.BTN_DELETE_Click);
            // 
            // RTN_CHANGE
            // 
            this.RTN_CHANGE.Location = new System.Drawing.Point(212, 561);
            this.RTN_CHANGE.Name = "RTN_CHANGE";
            this.RTN_CHANGE.Size = new System.Drawing.Size(96, 44);
            this.RTN_CHANGE.TabIndex = 19;
            this.RTN_CHANGE.Text = "Изменить";
            this.RTN_CHANGE.UseVisualStyleBackColor = true;
            this.RTN_CHANGE.Click += new System.EventHandler(this.RTN_CHANGE_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::ARM_V2._0.Properties.Resources.cd1aa941c2c173b39c5015c350beda901;
            this.pictureBox1.Location = new System.Drawing.Point(1173, 490);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(27, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.6F);
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label9.Location = new System.Drawing.Point(12, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 18);
            this.label9.TabIndex = 23;
            this.label9.Text = "Заказы";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.label10.Location = new System.Drawing.Point(94, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 18);
            this.label10.TabIndex = 24;
            this.label10.Text = "Клиенты";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // text_DATE
            // 
            this.text_DATE.Location = new System.Drawing.Point(894, 575);
            this.text_DATE.Name = "text_DATE";
            this.text_DATE.Size = new System.Drawing.Size(196, 22);
            this.text_DATE.TabIndex = 25;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label11.Location = new System.Drawing.Point(792, 578);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(91, 16);
            this.label11.TabIndex = 26;
            this.label11.Text = "Дата выдачи";
            // 
            // text_PAY1
            // 
            this.text_PAY1.FormattingEnabled = true;
            this.text_PAY1.Items.AddRange(new object[] {
            "Оплачено",
            "Не оплачено",
            "Возврат"});
            this.text_PAY1.Location = new System.Drawing.Point(493, 573);
            this.text_PAY1.Name = "text_PAY1";
            this.text_PAY1.Size = new System.Drawing.Size(196, 24);
            this.text_PAY1.TabIndex = 27;
            // 
            // text_STAT1
            // 
            this.text_STAT1.FormattingEnabled = true;
            this.text_STAT1.Items.AddRange(new object[] {
            "Выдан",
            "Возврат"});
            this.text_STAT1.Location = new System.Drawing.Point(493, 532);
            this.text_STAT1.Name = "text_STAT1";
            this.text_STAT1.Size = new System.Drawing.Size(196, 24);
            this.text_STAT1.TabIndex = 28;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkViolet;
            this.BackgroundImage = global::ARM_V2._0.Properties.Resources.Без_имени_1;
            this.ClientSize = new System.Drawing.Size(1212, 619);
            this.Controls.Add(this.text_STAT1);
            this.Controls.Add(this.text_PAY1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.text_DATE);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.RTN_CHANGE);
            this.Controls.Add(this.BTN_DELETE);
            this.Controls.Add(this.BTN_SAVE);
            this.Controls.Add(this.text_IDKLIENT);
            this.Controls.Add(this.text_PRICE);
            this.Controls.Add(this.text_PROD);
            this.Controls.Add(this.text_KOD);
            this.Controls.Add(this.Text_Find);
            this.Controls.Add(this.Text_ID);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Заказы";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Text_ID;
        private System.Windows.Forms.TextBox Text_Find;
        private System.Windows.Forms.TextBox text_KOD;
        private System.Windows.Forms.TextBox text_PROD;
        private System.Windows.Forms.TextBox text_PRICE;
        private System.Windows.Forms.TextBox text_IDKLIENT;
        private System.Windows.Forms.Button BTN_SAVE;
        private System.Windows.Forms.Button BTN_DELETE;
        private System.Windows.Forms.Button RTN_CHANGE;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox text_DATE;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox text_PAY1;
        private System.Windows.Forms.ComboBox text_STAT1;
    }
}