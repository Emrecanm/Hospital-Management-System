namespace HASTANE_OTOMASYONU
{
    partial class AdminPoliklinikEkrani
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminPoliklinikEkrani));
            label1 = new Label();
            label22 = new Label();
            AnaMenu = new Button();
            GeriDon = new Button();
            PoliklinikListele = new Button();
            PoliklinikAra = new Button();
            PoliklinikSil = new Button();
            PoliklinikAdi = new TextBox();
            label2 = new Label();
            label3 = new Label();
            TabloyuYazdir = new DataGridView();
            PolEkleVeyaGuncelle = new Button();
            ((System.ComponentModel.ISupportInitialize)TabloyuYazdir).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.Cyan;
            label1.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold);
            label1.Location = new Point(-5, -1);
            label1.Name = "label1";
            label1.Size = new Size(912, 72);
            label1.TabIndex = 0;
            label1.Text = " Hoş Geldiniz :";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.BackColor = Color.Cyan;
            label22.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold);
            label22.Location = new Point(162, 20);
            label22.Name = "label22";
            label22.Size = new Size(0, 27);
            label22.TabIndex = 1;
            // 
            // AnaMenu
            // 
            AnaMenu.BackColor = Color.Cyan;
            AnaMenu.BackgroundImage = Properties.Resources.home1;
            AnaMenu.BackgroundImageLayout = ImageLayout.Zoom;
            AnaMenu.FlatStyle = FlatStyle.Flat;
            AnaMenu.Location = new Point(830, 8);
            AnaMenu.Name = "AnaMenu";
            AnaMenu.Size = new Size(62, 53);
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
            GeriDon.Location = new Point(762, 8);
            GeriDon.Name = "GeriDon";
            GeriDon.Size = new Size(62, 53);
            GeriDon.TabIndex = 3;
            GeriDon.UseVisualStyleBackColor = false;
            GeriDon.Click += GeriDon_Click;
            // 
            // PoliklinikListele
            // 
            PoliklinikListele.BackColor = Color.Cyan;
            PoliklinikListele.FlatStyle = FlatStyle.Flat;
            PoliklinikListele.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            PoliklinikListele.Image = (Image)resources.GetObject("PoliklinikListele.Image");
            PoliklinikListele.ImageAlign = ContentAlignment.MiddleRight;
            PoliklinikListele.Location = new Point(12, 85);
            PoliklinikListele.Name = "PoliklinikListele";
            PoliklinikListele.Size = new Size(184, 72);
            PoliklinikListele.TabIndex = 4;
            PoliklinikListele.Text = "Poliklinikleri\r\nListele\r\n";
            PoliklinikListele.TextAlign = ContentAlignment.MiddleLeft;
            PoliklinikListele.UseVisualStyleBackColor = false;
            PoliklinikListele.Click += PoliklinikListele_Click;
            // 
            // PoliklinikAra
            // 
            PoliklinikAra.BackColor = Color.Cyan;
            PoliklinikAra.FlatStyle = FlatStyle.Flat;
            PoliklinikAra.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            PoliklinikAra.Image = (Image)resources.GetObject("PoliklinikAra.Image");
            PoliklinikAra.ImageAlign = ContentAlignment.MiddleRight;
            PoliklinikAra.Location = new Point(12, 172);
            PoliklinikAra.Name = "PoliklinikAra";
            PoliklinikAra.Size = new Size(184, 72);
            PoliklinikAra.TabIndex = 5;
            PoliklinikAra.Text = "Poliklinik\r\nAra\r\n";
            PoliklinikAra.TextAlign = ContentAlignment.MiddleLeft;
            PoliklinikAra.UseVisualStyleBackColor = false;
            PoliklinikAra.Click += PoliklinikAra_Click;
            // 
            // PoliklinikSil
            // 
            PoliklinikSil.BackColor = Color.Cyan;
            PoliklinikSil.FlatStyle = FlatStyle.Flat;
            PoliklinikSil.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            PoliklinikSil.Image = (Image)resources.GetObject("PoliklinikSil.Image");
            PoliklinikSil.ImageAlign = ContentAlignment.MiddleRight;
            PoliklinikSil.Location = new Point(12, 259);
            PoliklinikSil.Name = "PoliklinikSil";
            PoliklinikSil.Size = new Size(184, 72);
            PoliklinikSil.TabIndex = 6;
            PoliklinikSil.Text = "Poliklinik\r\nSil\r\n";
            PoliklinikSil.TextAlign = ContentAlignment.MiddleLeft;
            PoliklinikSil.UseVisualStyleBackColor = false;
            PoliklinikSil.Click += PoliklinikSil_Click;
            // 
            // PoliklinikAdi
            // 
            PoliklinikAdi.BackColor = Color.Cyan;
            PoliklinikAdi.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            PoliklinikAdi.Location = new Point(202, 197);
            PoliklinikAdi.Name = "PoliklinikAdi";
            PoliklinikAdi.Size = new Size(195, 34);
            PoliklinikAdi.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label2.Location = new Point(268, 167);
            label2.Name = "label2";
            label2.Size = new Size(51, 27);
            label2.TabIndex = 8;
            label2.Text = "İsim";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label3.Location = new Point(202, 268);
            label3.Name = "label3";
            label3.Size = new Size(198, 54);
            label3.TabIndex = 9;
            label3.Text = "Silinecek Polikliniğin\r\nSatırına Basınız";
            // 
            // TabloyuYazdir
            // 
            TabloyuYazdir.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TabloyuYazdir.Location = new Point(12, 337);
            TabloyuYazdir.Name = "TabloyuYazdir";
            TabloyuYazdir.RowHeadersWidth = 51;
            TabloyuYazdir.Size = new Size(880, 297);
            TabloyuYazdir.TabIndex = 10;
            // 
            // PolEkleVeyaGuncelle
            // 
            PolEkleVeyaGuncelle.BackColor = Color.Cyan;
            PolEkleVeyaGuncelle.FlatStyle = FlatStyle.Flat;
            PolEkleVeyaGuncelle.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            PolEkleVeyaGuncelle.Image = (Image)resources.GetObject("PolEkleVeyaGuncelle.Image");
            PolEkleVeyaGuncelle.ImageAlign = ContentAlignment.MiddleRight;
            PolEkleVeyaGuncelle.Location = new Point(639, 139);
            PolEkleVeyaGuncelle.Name = "PolEkleVeyaGuncelle";
            PolEkleVeyaGuncelle.Size = new Size(241, 121);
            PolEkleVeyaGuncelle.TabIndex = 11;
            PolEkleVeyaGuncelle.Text = "Poliklinik \r\nEkle Veya\r\nGüncelle";
            PolEkleVeyaGuncelle.TextAlign = ContentAlignment.MiddleLeft;
            PolEkleVeyaGuncelle.UseVisualStyleBackColor = false;
            PolEkleVeyaGuncelle.Click += PolEkleVeyaGuncelle_Click;
            // 
            // AdminPoliklinikEkrani
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(902, 635);
            Controls.Add(PolEkleVeyaGuncelle);
            Controls.Add(TabloyuYazdir);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(PoliklinikAdi);
            Controls.Add(PoliklinikSil);
            Controls.Add(PoliklinikAra);
            Controls.Add(PoliklinikListele);
            Controls.Add(GeriDon);
            Controls.Add(AnaMenu);
            Controls.Add(label22);
            Controls.Add(label1);
            Name = "AdminPoliklinikEkrani";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminPoliklinikEkrani";
            ((System.ComponentModel.ISupportInitialize)TabloyuYazdir).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        public Label label22;
        private Button AnaMenu;
        private Button GeriDon;
        private Button PoliklinikListele;
        private Button PoliklinikAra;
        private Button PoliklinikSil;
        private TextBox PoliklinikAdi;
        private Label label2;
        private Label label3;
        private DataGridView TabloyuYazdir;
        private Button PolEkleVeyaGuncelle;
    }
}