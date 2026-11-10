namespace HASTANE_OTOMASYONU
{
    partial class PoliklinikEkleVeyaGuncelle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PoliklinikEkleVeyaGuncelle));
            label1 = new Label();
            label33 = new Label();
            AnaMenu = new Button();
            GeriDon = new Button();
            HastID = new TextBox();
            label2 = new Label();
            label3 = new Label();
            KlinikAdi = new TextBox();
            label4 = new Label();
            KlinikAdedi = new TextBox();
            label5 = new Label();
            TabloyuGoster = new DataGridView();
            KlinikEkle = new Button();
            KlinikGuncelle = new Button();
            YazilariTemizle = new Button();
            KayitlariGetir = new Button();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)TabloyuGoster).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.Cyan;
            label1.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold);
            label1.Location = new Point(-1, -2);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(1111, 82);
            label1.TabIndex = 0;
            label1.Text = " Hoş Geldiniz : ";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label33
            // 
            label33.AutoSize = true;
            label33.BackColor = Color.Cyan;
            label33.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold);
            label33.Location = new Point(145, 25);
            label33.Margin = new Padding(5, 0, 5, 0);
            label33.Name = "label33";
            label33.Size = new Size(0, 27);
            label33.TabIndex = 1;
            label33.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // AnaMenu
            // 
            AnaMenu.BackColor = Color.Cyan;
            AnaMenu.BackgroundImage = Properties.Resources.home;
            AnaMenu.BackgroundImageLayout = ImageLayout.Zoom;
            AnaMenu.FlatStyle = FlatStyle.Flat;
            AnaMenu.Location = new Point(1028, 12);
            AnaMenu.Margin = new Padding(3, 2, 3, 2);
            AnaMenu.Name = "AnaMenu";
            AnaMenu.Size = new Size(66, 56);
            AnaMenu.TabIndex = 2;
            AnaMenu.UseVisualStyleBackColor = false;
            AnaMenu.Click += AnaMenu_Click;
            // 
            // GeriDon
            // 
            GeriDon.BackColor = Color.Cyan;
            GeriDon.BackgroundImage = Properties.Resources.turn_back;
            GeriDon.BackgroundImageLayout = ImageLayout.Zoom;
            GeriDon.FlatStyle = FlatStyle.Flat;
            GeriDon.Location = new Point(957, 12);
            GeriDon.Margin = new Padding(3, 2, 3, 2);
            GeriDon.Name = "GeriDon";
            GeriDon.Size = new Size(66, 56);
            GeriDon.TabIndex = 3;
            GeriDon.UseVisualStyleBackColor = false;
            GeriDon.Click += GeriDon_Click;
            // 
            // HastID
            // 
            HastID.BackColor = Color.Cyan;
            HastID.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold | FontStyle.Italic);
            HastID.Location = new Point(145, 159);
            HastID.Margin = new Padding(3, 2, 3, 2);
            HastID.Name = "HastID";
            HastID.Size = new Size(209, 34);
            HastID.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold | FontStyle.Italic);
            label2.Location = new Point(19, 162);
            label2.Name = "label2";
            label2.Size = new Size(111, 27);
            label2.TabIndex = 5;
            label2.Text = "HastaneID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold | FontStyle.Italic);
            label3.Location = new Point(85, 226);
            label3.Name = "label3";
            label3.Size = new Size(43, 27);
            label3.TabIndex = 7;
            label3.Text = "Adı";
            // 
            // KlinikAdi
            // 
            KlinikAdi.BackColor = Color.Cyan;
            KlinikAdi.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold | FontStyle.Italic);
            KlinikAdi.Location = new Point(145, 219);
            KlinikAdi.Margin = new Padding(3, 2, 3, 2);
            KlinikAdi.Name = "KlinikAdi";
            KlinikAdi.Size = new Size(209, 34);
            KlinikAdi.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold | FontStyle.Italic);
            label4.Location = new Point(67, 280);
            label4.Name = "label4";
            label4.Size = new Size(63, 27);
            label4.TabIndex = 9;
            label4.Text = "Adedi";
            // 
            // KlinikAdedi
            // 
            KlinikAdedi.BackColor = Color.Cyan;
            KlinikAdedi.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold | FontStyle.Italic);
            KlinikAdedi.Location = new Point(145, 278);
            KlinikAdedi.Margin = new Padding(3, 2, 3, 2);
            KlinikAdedi.Name = "KlinikAdedi";
            KlinikAdedi.Size = new Size(209, 34);
            KlinikAdedi.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold | FontStyle.Italic);
            label5.Location = new Point(103, 104);
            label5.Name = "label5";
            label5.Size = new Size(141, 27);
            label5.TabIndex = 10;
            label5.Text = "Klinik Bilgileri";
            // 
            // TabloyuGoster
            // 
            TabloyuGoster.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TabloyuGoster.Location = new Point(431, 204);
            TabloyuGoster.Margin = new Padding(3, 2, 3, 2);
            TabloyuGoster.Name = "TabloyuGoster";
            TabloyuGoster.RowHeadersWidth = 51;
            TabloyuGoster.Size = new Size(663, 408);
            TabloyuGoster.TabIndex = 11;
            TabloyuGoster.CellMouseClick += TabloyuGoster_CellMouseClick;
            // 
            // KlinikEkle
            // 
            KlinikEkle.BackColor = Color.Cyan;
            KlinikEkle.FlatStyle = FlatStyle.Flat;
            KlinikEkle.Image = (Image)resources.GetObject("KlinikEkle.Image");
            KlinikEkle.ImageAlign = ContentAlignment.MiddleRight;
            KlinikEkle.Location = new Point(19, 434);
            KlinikEkle.Margin = new Padding(3, 2, 3, 2);
            KlinikEkle.Name = "KlinikEkle";
            KlinikEkle.Size = new Size(335, 74);
            KlinikEkle.TabIndex = 12;
            KlinikEkle.Text = "Klinik Ekle";
            KlinikEkle.TextAlign = ContentAlignment.MiddleLeft;
            KlinikEkle.UseVisualStyleBackColor = false;
            KlinikEkle.Click += KlinikEkle_Click;
            // 
            // KlinikGuncelle
            // 
            KlinikGuncelle.BackColor = Color.Cyan;
            KlinikGuncelle.FlatStyle = FlatStyle.Flat;
            KlinikGuncelle.Image = (Image)resources.GetObject("KlinikGuncelle.Image");
            KlinikGuncelle.ImageAlign = ContentAlignment.MiddleRight;
            KlinikGuncelle.Location = new Point(695, 104);
            KlinikGuncelle.Margin = new Padding(3, 2, 3, 2);
            KlinikGuncelle.Name = "KlinikGuncelle";
            KlinikGuncelle.Size = new Size(400, 74);
            KlinikGuncelle.TabIndex = 13;
            KlinikGuncelle.Text = "Klinik Güncelle";
            KlinikGuncelle.TextAlign = ContentAlignment.MiddleLeft;
            KlinikGuncelle.UseVisualStyleBackColor = false;
            KlinikGuncelle.Click += KlinikGuncelle_Click;
            // 
            // YazilariTemizle
            // 
            YazilariTemizle.BackColor = Color.Cyan;
            YazilariTemizle.FlatStyle = FlatStyle.Flat;
            YazilariTemizle.Image = (Image)resources.GetObject("YazilariTemizle.Image");
            YazilariTemizle.ImageAlign = ContentAlignment.MiddleRight;
            YazilariTemizle.Location = new Point(19, 538);
            YazilariTemizle.Margin = new Padding(3, 2, 3, 2);
            YazilariTemizle.Name = "YazilariTemizle";
            YazilariTemizle.Size = new Size(335, 74);
            YazilariTemizle.TabIndex = 14;
            YazilariTemizle.Text = "Yazıları Temizle";
            YazilariTemizle.TextAlign = ContentAlignment.MiddleLeft;
            YazilariTemizle.UseVisualStyleBackColor = false;
            YazilariTemizle.Click += YazilariTemizle_Click;
            // 
            // KayitlariGetir
            // 
            KayitlariGetir.BackColor = Color.Cyan;
            KayitlariGetir.FlatStyle = FlatStyle.Flat;
            KayitlariGetir.Image = (Image)resources.GetObject("KayitlariGetir.Image");
            KayitlariGetir.ImageAlign = ContentAlignment.MiddleRight;
            KayitlariGetir.Location = new Point(19, 340);
            KayitlariGetir.Margin = new Padding(3, 2, 3, 2);
            KayitlariGetir.Name = "KayitlariGetir";
            KayitlariGetir.Size = new Size(335, 74);
            KayitlariGetir.TabIndex = 15;
            KayitlariGetir.Text = "Poliklinikleri Göster";
            KayitlariGetir.TextAlign = ContentAlignment.MiddleLeft;
            KayitlariGetir.UseVisualStyleBackColor = false;
            KayitlariGetir.Click += KayitlariGetir_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(431, 118);
            label6.Name = "label6";
            label6.Size = new Size(258, 60);
            label6.TabIndex = 16;
            label6.Text = "Güncellemek İstediğiniz\r\nSatıra Basınız.\r\n";
            label6.TextAlign = ContentAlignment.TopRight;
            // 
            // PoliklinikEkleVeyaGuncelle
            // 
            AutoScaleDimensions = new SizeF(14F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(1107, 622);
            Controls.Add(label6);
            Controls.Add(KayitlariGetir);
            Controls.Add(YazilariTemizle);
            Controls.Add(KlinikGuncelle);
            Controls.Add(KlinikEkle);
            Controls.Add(TabloyuGoster);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(KlinikAdedi);
            Controls.Add(label3);
            Controls.Add(KlinikAdi);
            Controls.Add(label2);
            Controls.Add(HastID);
            Controls.Add(GeriDon);
            Controls.Add(AnaMenu);
            Controls.Add(label33);
            Controls.Add(label1);
            Font = new Font("Palatino Linotype", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            Margin = new Padding(5, 4, 5, 4);
            Name = "PoliklinikEkleVeyaGuncelle";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PoliklinikEkleVeyaGuncelle";
            ((System.ComponentModel.ISupportInitialize)TabloyuGoster).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        public Label label33;
        private Button AnaMenu;
        private Button GeriDon;
        private TextBox HastID;
        private Label label2;
        private Label label3;
        private TextBox KlinikAdi;
        private Label label4;
        private TextBox KlinikAdedi;
        private Label label5;
        private DataGridView TabloyuGoster;
        private Button KlinikEkle;
        private Button KlinikGuncelle;
        private Button YazilariTemizle;
        private Button KayitlariGetir;
        private Label label6;
    }
}