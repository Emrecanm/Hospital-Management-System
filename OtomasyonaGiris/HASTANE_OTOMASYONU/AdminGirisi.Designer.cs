namespace HASTANE_OTOMASYONU
{
    partial class AdminGirisi
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
            label1 = new Label();
            label2 = new Label();
            AdminKullaniciAdi = new TextBox();
            AdminSifre = new TextBox();
            label3 = new Label();
            AdminGiris = new Button();
            TurnBack = new Button();
            checkBox1 = new CheckBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Cyan;
            label1.Font = new Font("Palatino Linotype", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(-2, -3);
            label1.Name = "label1";
            label1.Size = new Size(583, 114);
            label1.TabIndex = 0;
            label1.Text = "\r\n                   ADİMİN GİRİŞ EKRANI               \r\n\r\n";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(22, 166);
            label2.Name = "label2";
            label2.Size = new Size(132, 27);
            label2.TabIndex = 1;
            label2.Text = "Kullanıcı Adı";
            // 
            // AdminKullaniciAdi
            // 
            AdminKullaniciAdi.BackColor = Color.Cyan;
            AdminKullaniciAdi.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            AdminKullaniciAdi.Location = new Point(160, 163);
            AdminKullaniciAdi.Name = "AdminKullaniciAdi";
            AdminKullaniciAdi.Size = new Size(180, 34);
            AdminKullaniciAdi.TabIndex = 2;
            // 
            // AdminSifre
            // 
            AdminSifre.BackColor = Color.Cyan;
            AdminSifre.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            AdminSifre.Location = new Point(160, 263);
            AdminSifre.Name = "AdminSifre";
            AdminSifre.Size = new Size(180, 34);
            AdminSifre.TabIndex = 4;
            AdminSifre.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.Location = new Point(98, 270);
            label3.Name = "label3";
            label3.Size = new Size(56, 27);
            label3.TabIndex = 3;
            label3.Text = "Şifre";
            // 
            // AdminGiris
            // 
            AdminGiris.BackColor = Color.Cyan;
            AdminGiris.FlatStyle = FlatStyle.Flat;
            AdminGiris.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            AdminGiris.Location = new Point(368, 207);
            AdminGiris.Name = "AdminGiris";
            AdminGiris.Size = new Size(143, 47);
            AdminGiris.TabIndex = 5;
            AdminGiris.Text = "GİRİŞ";
            AdminGiris.UseVisualStyleBackColor = false;
            AdminGiris.Click += AdminGiris_Click;
            // 
            // TurnBack
            // 
            TurnBack.BackColor = Color.Cyan;
            TurnBack.BackgroundImage = Properties.Resources.turn_back;
            TurnBack.BackgroundImageLayout = ImageLayout.Zoom;
            TurnBack.FlatStyle = FlatStyle.Flat;
            TurnBack.Location = new Point(12, 12);
            TurnBack.Name = "TurnBack";
            TurnBack.Size = new Size(68, 45);
            TurnBack.TabIndex = 6;
            TurnBack.UseVisualStyleBackColor = false;
            TurnBack.Click += TurnBack_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Palatino Linotype", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            checkBox1.Location = new Point(346, 270);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(88, 27);
            checkBox1.TabIndex = 7;
            checkBox1.Text = " Göster";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // AdminGirisi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(581, 355);
            Controls.Add(checkBox1);
            Controls.Add(TurnBack);
            Controls.Add(AdminGiris);
            Controls.Add(AdminSifre);
            Controls.Add(label3);
            Controls.Add(AdminKullaniciAdi);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AdminGirisi";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminGirisi";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox AdminSifre;
        private Label label3;
        private Button AdminGiris;
        private Button TurnBack;
        private CheckBox checkBox1;
        public TextBox AdminKullaniciAdi;
    }
}