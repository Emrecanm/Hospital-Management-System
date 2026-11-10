namespace HASTANE_OTOMASYONU
{
    partial class DoktorGirisi
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
            AnaMenu = new Button();
            DoktorKullaniciAdi = new TextBox();
            label2 = new Label();
            label3 = new Label();
            DoktorSifre = new TextBox();
            Giris = new Button();
            checkBox1 = new CheckBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.Cyan;
            label1.Font = new Font("Palatino Linotype", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(-1, -4);
            label1.Name = "label1";
            label1.Size = new Size(584, 119);
            label1.TabIndex = 0;
            label1.Text = "DOKTOR GİRİŞ EKRANI";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // AnaMenu
            // 
            AnaMenu.BackColor = Color.Cyan;
            AnaMenu.BackgroundImage = Properties.Resources.turn_back;
            AnaMenu.BackgroundImageLayout = ImageLayout.Zoom;
            AnaMenu.FlatStyle = FlatStyle.Flat;
            AnaMenu.Location = new Point(12, 12);
            AnaMenu.Name = "AnaMenu";
            AnaMenu.Size = new Size(69, 47);
            AnaMenu.TabIndex = 1;
            AnaMenu.UseVisualStyleBackColor = false;
            AnaMenu.Click += AnaMenu_Click;
            // 
            // DoktorKullaniciAdi
            // 
            DoktorKullaniciAdi.BackColor = Color.Cyan;
            DoktorKullaniciAdi.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold);
            DoktorKullaniciAdi.Location = new Point(149, 161);
            DoktorKullaniciAdi.Name = "DoktorKullaniciAdi";
            DoktorKullaniciAdi.Size = new Size(181, 34);
            DoktorKullaniciAdi.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold);
            label2.Location = new Point(11, 164);
            label2.Name = "label2";
            label2.Size = new Size(132, 27);
            label2.TabIndex = 3;
            label2.Text = "Kullanıcı Adı";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold);
            label3.Location = new Point(87, 266);
            label3.Name = "label3";
            label3.Size = new Size(56, 27);
            label3.TabIndex = 5;
            label3.Text = "Şifre";
            // 
            // DoktorSifre
            // 
            DoktorSifre.BackColor = Color.Cyan;
            DoktorSifre.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold);
            DoktorSifre.Location = new Point(149, 263);
            DoktorSifre.Name = "DoktorSifre";
            DoktorSifre.Size = new Size(181, 34);
            DoktorSifre.TabIndex = 4;
            DoktorSifre.UseSystemPasswordChar = true;
            // 
            // Giris
            // 
            Giris.BackColor = Color.Cyan;
            Giris.FlatStyle = FlatStyle.Flat;
            Giris.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            Giris.Location = new Point(351, 205);
            Giris.Name = "Giris";
            Giris.Size = new Size(147, 53);
            Giris.TabIndex = 6;
            Giris.Text = "Giriş";
            Giris.UseVisualStyleBackColor = false;
            Giris.Click += Giris_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Palatino Linotype", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            checkBox1.Location = new Point(351, 269);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(84, 27);
            checkBox1.TabIndex = 7;
            checkBox1.Text = "Göster";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // DoktorGirisi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(579, 356);
            Controls.Add(checkBox1);
            Controls.Add(Giris);
            Controls.Add(label3);
            Controls.Add(DoktorSifre);
            Controls.Add(label2);
            Controls.Add(DoktorKullaniciAdi);
            Controls.Add(AnaMenu);
            Controls.Add(label1);
            Name = "DoktorGirisi";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DoktorGirisi";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button AnaMenu;
        private TextBox DoktorKullaniciAdi;
        private Label label2;
        private Label label3;
        private TextBox DoktorSifre;
        private Button Giris;
        private CheckBox checkBox1;
    }
}