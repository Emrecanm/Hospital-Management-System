namespace HASTANE_OTOMASYONU
{
    partial class HastaKayitEkrani
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
            GeriDon = new Button();
            label2 = new Label();
            ad = new TextBox();
            soyad = new TextBox();
            label3 = new Label();
            tc = new TextBox();
            label4 = new Label();
            cinsiyet = new TextBox();
            label5 = new Label();
            doktar = new TextBox();
            label6 = new Label();
            annead = new TextBox();
            label7 = new Label();
            babaad = new TextBox();
            label8 = new Label();
            tel = new TextBox();
            label9 = new Label();
            label10 = new Label();
            Sifre = new TextBox();
            label11 = new Label();
            KullaniciAdi = new TextBox();
            label12 = new Label();
            HastaneID = new TextBox();
            label13 = new Label();
            KayitOl = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.Cyan;
            label1.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(-5, -5);
            label1.Name = "label1";
            label1.Size = new Size(770, 81);
            label1.TabIndex = 0;
            label1.Text = "HASTA KAYIT EKRANINA HOŞ GELDİNİZ";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // GeriDon
            // 
            GeriDon.BackColor = Color.Cyan;
            GeriDon.BackgroundImage = Properties.Resources.turn_back;
            GeriDon.BackgroundImageLayout = ImageLayout.Zoom;
            GeriDon.FlatStyle = FlatStyle.Flat;
            GeriDon.Location = new Point(12, 12);
            GeriDon.Name = "GeriDon";
            GeriDon.Size = new Size(76, 47);
            GeriDon.TabIndex = 1;
            GeriDon.UseVisualStyleBackColor = false;
            GeriDon.Click += GeriDon_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold | FontStyle.Italic);
            label2.Location = new Point(96, 184);
            label2.Name = "label2";
            label2.Size = new Size(43, 27);
            label2.TabIndex = 2;
            label2.Text = "Adı";
            // 
            // ad
            // 
            ad.BackColor = Color.Cyan;
            ad.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold | FontStyle.Italic);
            ad.Location = new Point(145, 181);
            ad.Name = "ad";
            ad.Size = new Size(205, 34);
            ad.TabIndex = 3;
            // 
            // soyad
            // 
            soyad.BackColor = Color.Cyan;
            soyad.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold | FontStyle.Italic);
            soyad.Location = new Point(145, 233);
            soyad.Name = "soyad";
            soyad.Size = new Size(205, 34);
            soyad.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold | FontStyle.Italic);
            label3.Location = new Point(67, 236);
            label3.Name = "label3";
            label3.Size = new Size(72, 27);
            label3.TabIndex = 4;
            label3.Text = "Soyadı";
            // 
            // tc
            // 
            tc.BackColor = Color.Cyan;
            tc.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold | FontStyle.Italic);
            tc.Location = new Point(145, 284);
            tc.Name = "tc";
            tc.Size = new Size(205, 34);
            tc.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold | FontStyle.Italic);
            label4.Location = new Point(101, 287);
            label4.Name = "label4";
            label4.Size = new Size(38, 27);
            label4.TabIndex = 6;
            label4.Text = "TC";
            // 
            // cinsiyet
            // 
            cinsiyet.BackColor = Color.Cyan;
            cinsiyet.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold | FontStyle.Italic);
            cinsiyet.Location = new Point(145, 385);
            cinsiyet.Name = "cinsiyet";
            cinsiyet.Size = new Size(205, 34);
            cinsiyet.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold | FontStyle.Italic);
            label5.Location = new Point(53, 388);
            label5.Name = "label5";
            label5.Size = new Size(86, 27);
            label5.TabIndex = 8;
            label5.Text = "Cinsiyet";
            // 
            // doktar
            // 
            doktar.BackColor = Color.Cyan;
            doktar.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold | FontStyle.Italic);
            doktar.Location = new Point(145, 333);
            doktar.Name = "doktar";
            doktar.Size = new Size(205, 34);
            doktar.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold | FontStyle.Italic);
            label6.Location = new Point(6, 336);
            label6.Name = "label6";
            label6.Size = new Size(133, 27);
            label6.TabIndex = 10;
            label6.Text = "Doğum Tarihi";
            // 
            // annead
            // 
            annead.BackColor = Color.Cyan;
            annead.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold | FontStyle.Italic);
            annead.Location = new Point(145, 440);
            annead.Name = "annead";
            annead.Size = new Size(205, 34);
            annead.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold | FontStyle.Italic);
            label7.Location = new Point(47, 443);
            label7.Name = "label7";
            label7.Size = new Size(92, 27);
            label7.TabIndex = 12;
            label7.Text = "Anne Adı";
            // 
            // babaad
            // 
            babaad.BackColor = Color.Cyan;
            babaad.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold | FontStyle.Italic);
            babaad.Location = new Point(145, 492);
            babaad.Name = "babaad";
            babaad.Size = new Size(205, 34);
            babaad.TabIndex = 15;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold | FontStyle.Italic);
            label8.Location = new Point(46, 495);
            label8.Name = "label8";
            label8.Size = new Size(93, 27);
            label8.TabIndex = 14;
            label8.Text = "Baba Adı";
            // 
            // tel
            // 
            tel.BackColor = Color.Cyan;
            tel.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold | FontStyle.Italic);
            tel.Location = new Point(145, 552);
            tel.Name = "tel";
            tel.Size = new Size(205, 34);
            tel.TabIndex = 17;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold | FontStyle.Italic);
            label9.Location = new Point(101, 555);
            label9.Name = "label9";
            label9.Size = new Size(38, 27);
            label9.TabIndex = 16;
            label9.Text = "Tel";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Palatino Linotype", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label10.Location = new Point(96, 117);
            label10.Name = "label10";
            label10.Size = new Size(165, 30);
            label10.TabIndex = 18;
            label10.Text = "Hasta Bİlgileri";
            // 
            // Sifre
            // 
            Sifre.BackColor = Color.Cyan;
            Sifre.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold | FontStyle.Italic);
            Sifre.Location = new Point(503, 287);
            Sifre.Name = "Sifre";
            Sifre.Size = new Size(205, 34);
            Sifre.TabIndex = 24;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold | FontStyle.Italic);
            label11.Location = new Point(445, 291);
            label11.Name = "label11";
            label11.Size = new Size(52, 27);
            label11.TabIndex = 23;
            label11.Text = "Şifre";
            // 
            // KullaniciAdi
            // 
            KullaniciAdi.BackColor = Color.Cyan;
            KullaniciAdi.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold | FontStyle.Italic);
            KullaniciAdi.Location = new Point(503, 236);
            KullaniciAdi.Name = "KullaniciAdi";
            KullaniciAdi.Size = new Size(205, 34);
            KullaniciAdi.TabIndex = 22;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold | FontStyle.Italic);
            label12.Location = new Point(370, 239);
            label12.Name = "label12";
            label12.Size = new Size(127, 27);
            label12.TabIndex = 21;
            label12.Text = "Kullanıcı Adı";
            // 
            // HastaneID
            // 
            HastaneID.BackColor = Color.Cyan;
            HastaneID.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold | FontStyle.Italic);
            HastaneID.Location = new Point(503, 184);
            HastaneID.Name = "HastaneID";
            HastaneID.Size = new Size(205, 34);
            HastaneID.TabIndex = 20;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold | FontStyle.Italic);
            label13.Location = new Point(386, 187);
            label13.Name = "label13";
            label13.Size = new Size(111, 27);
            label13.TabIndex = 19;
            label13.Text = "HastaneID";
            // 
            // KayitOl
            // 
            KayitOl.BackColor = Color.Cyan;
            KayitOl.BackgroundImageLayout = ImageLayout.Zoom;
            KayitOl.FlatStyle = FlatStyle.Flat;
            KayitOl.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            KayitOl.Location = new Point(503, 368);
            KayitOl.Name = "KayitOl";
            KayitOl.Size = new Size(205, 68);
            KayitOl.TabIndex = 25;
            KayitOl.Text = "KAYIT OL";
            KayitOl.UseVisualStyleBackColor = false;
            KayitOl.Click += KayitOl_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Cyan;
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            button1.Location = new Point(503, 458);
            button1.Name = "button1";
            button1.Size = new Size(205, 68);
            button1.TabIndex = 26;
            button1.Text = "GİRİŞ YAP";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // HastaKayitEkrani
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(764, 650);
            Controls.Add(button1);
            Controls.Add(KayitOl);
            Controls.Add(Sifre);
            Controls.Add(label11);
            Controls.Add(KullaniciAdi);
            Controls.Add(label12);
            Controls.Add(HastaneID);
            Controls.Add(label13);
            Controls.Add(label10);
            Controls.Add(tel);
            Controls.Add(label9);
            Controls.Add(babaad);
            Controls.Add(label8);
            Controls.Add(annead);
            Controls.Add(label7);
            Controls.Add(doktar);
            Controls.Add(label6);
            Controls.Add(cinsiyet);
            Controls.Add(label5);
            Controls.Add(tc);
            Controls.Add(label4);
            Controls.Add(soyad);
            Controls.Add(label3);
            Controls.Add(ad);
            Controls.Add(label2);
            Controls.Add(GeriDon);
            Controls.Add(label1);
            Name = "HastaKayitEkrani";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HastaKayitEkrani";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button GeriDon;
        private Label label2;
        private TextBox ad;
        private TextBox soyad;
        private Label label3;
        private TextBox tc;
        private Label label4;
        private TextBox cinsiyet;
        private Label label5;
        private TextBox doktar;
        private Label label6;
        private TextBox annead;
        private Label label7;
        private TextBox babaad;
        private Label label8;
        private TextBox tel;
        private Label label9;
        private Label label10;
        private TextBox Sifre;
        private Label label11;
        private TextBox KullaniciAdi;
        private Label label12;
        private TextBox HastaneID;
        private Label label13;
        private Button KayitOl;
        private Button button1;
    }
}