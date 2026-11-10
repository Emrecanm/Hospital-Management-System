namespace HASTANE_OTOMASYONU
{
    partial class AdminDoktorlarEkrani
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminDoktorlarEkrani));
            label1 = new Label();
            label3 = new Label();
            MenuDon = new Button();
            GeriDon = new Button();
            button1 = new Button();
            DoktorAra = new Button();
            SilinecekDoktorAdi = new Button();
            AranacakDktrAdi = new TextBox();
            label2 = new Label();
            TabloyuYazdir = new DataGridView();
            EkleVeyaGuncelle = new Button();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)TabloyuYazdir).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.Cyan;
            label1.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(1, -3);
            label1.Name = "label1";
            label1.Size = new Size(906, 71);
            label1.TabIndex = 0;
            label1.Text = "Hoş Geldiniz :";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Cyan;
            label3.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.Location = new Point(141, 19);
            label3.Name = "label3";
            label3.Size = new Size(0, 27);
            label3.TabIndex = 1;
            // 
            // MenuDon
            // 
            MenuDon.BackColor = Color.Cyan;
            MenuDon.BackgroundImage = Properties.Resources.home;
            MenuDon.BackgroundImageLayout = ImageLayout.Zoom;
            MenuDon.FlatStyle = FlatStyle.Flat;
            MenuDon.ForeColor = SystemColors.ControlText;
            MenuDon.Location = new Point(823, 9);
            MenuDon.Name = "MenuDon";
            MenuDon.Size = new Size(64, 51);
            MenuDon.TabIndex = 3;
            MenuDon.UseVisualStyleBackColor = false;
            MenuDon.Click += MenuDon_Click;
            // 
            // GeriDon
            // 
            GeriDon.BackColor = Color.Cyan;
            GeriDon.BackgroundImage = Properties.Resources.turn_back;
            GeriDon.BackgroundImageLayout = ImageLayout.Zoom;
            GeriDon.FlatStyle = FlatStyle.Flat;
            GeriDon.ForeColor = SystemColors.ControlText;
            GeriDon.Location = new Point(753, 9);
            GeriDon.Name = "GeriDon";
            GeriDon.Size = new Size(64, 51);
            GeriDon.TabIndex = 4;
            GeriDon.UseVisualStyleBackColor = false;
            GeriDon.Click += GeriDon_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Cyan;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleRight;
            button1.Location = new Point(12, 80);
            button1.Name = "button1";
            button1.Size = new Size(176, 67);
            button1.TabIndex = 5;
            button1.Text = "Doktorları\r\nListele";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // DoktorAra
            // 
            DoktorAra.BackColor = Color.Cyan;
            DoktorAra.FlatStyle = FlatStyle.Flat;
            DoktorAra.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            DoktorAra.Image = (Image)resources.GetObject("DoktorAra.Image");
            DoktorAra.ImageAlign = ContentAlignment.MiddleRight;
            DoktorAra.Location = new Point(12, 164);
            DoktorAra.Name = "DoktorAra";
            DoktorAra.Size = new Size(176, 67);
            DoktorAra.TabIndex = 6;
            DoktorAra.Text = "Doktor\r\nAra\r\n";
            DoktorAra.TextAlign = ContentAlignment.MiddleLeft;
            DoktorAra.UseVisualStyleBackColor = false;
            DoktorAra.Click += button2_Click;
            // 
            // SilinecekDoktorAdi
            // 
            SilinecekDoktorAdi.BackColor = Color.Cyan;
            SilinecekDoktorAdi.FlatStyle = FlatStyle.Flat;
            SilinecekDoktorAdi.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            SilinecekDoktorAdi.Image = (Image)resources.GetObject("SilinecekDoktorAdi.Image");
            SilinecekDoktorAdi.ImageAlign = ContentAlignment.MiddleRight;
            SilinecekDoktorAdi.Location = new Point(12, 252);
            SilinecekDoktorAdi.Name = "SilinecekDoktorAdi";
            SilinecekDoktorAdi.Size = new Size(176, 67);
            SilinecekDoktorAdi.TabIndex = 7;
            SilinecekDoktorAdi.Text = "Doktor\r\nSil\r\n";
            SilinecekDoktorAdi.TextAlign = ContentAlignment.MiddleLeft;
            SilinecekDoktorAdi.UseVisualStyleBackColor = false;
            SilinecekDoktorAdi.Click += SilinecekDoktorAdi_Click;
            // 
            // AranacakDktrAdi
            // 
            AranacakDktrAdi.BackColor = Color.Cyan;
            AranacakDktrAdi.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            AranacakDktrAdi.Location = new Point(204, 181);
            AranacakDktrAdi.Name = "AranacakDktrAdi";
            AranacakDktrAdi.Size = new Size(193, 34);
            AranacakDktrAdi.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label2.Location = new Point(275, 151);
            label2.Name = "label2";
            label2.Size = new Size(51, 27);
            label2.TabIndex = 9;
            label2.Text = "İsim";
            // 
            // TabloyuYazdir
            // 
            TabloyuYazdir.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TabloyuYazdir.Location = new Point(12, 325);
            TabloyuYazdir.Name = "TabloyuYazdir";
            TabloyuYazdir.RowHeadersWidth = 51;
            TabloyuYazdir.Size = new Size(875, 307);
            TabloyuYazdir.TabIndex = 12;
            // 
            // EkleVeyaGuncelle
            // 
            EkleVeyaGuncelle.BackColor = Color.Cyan;
            EkleVeyaGuncelle.FlatStyle = FlatStyle.Flat;
            EkleVeyaGuncelle.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            EkleVeyaGuncelle.Image = (Image)resources.GetObject("EkleVeyaGuncelle.Image");
            EkleVeyaGuncelle.ImageAlign = ContentAlignment.MiddleRight;
            EkleVeyaGuncelle.Location = new Point(623, 136);
            EkleVeyaGuncelle.Name = "EkleVeyaGuncelle";
            EkleVeyaGuncelle.Size = new Size(250, 122);
            EkleVeyaGuncelle.TabIndex = 13;
            EkleVeyaGuncelle.Text = "Doktor Ekle\r\nveya\r\nGüncelle\r\n";
            EkleVeyaGuncelle.TextAlign = ContentAlignment.MiddleLeft;
            EkleVeyaGuncelle.UseVisualStyleBackColor = false;
            EkleVeyaGuncelle.Click += EkleVeyaGuncelle_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label4.Location = new Point(194, 265);
            label4.Name = "label4";
            label4.Size = new Size(187, 54);
            label4.TabIndex = 14;
            label4.Text = "Silinecek Doktorun \r\nSatırına Basınız.\r\n";
            // 
            // AdminDoktorlarEkrani
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(899, 638);
            Controls.Add(label4);
            Controls.Add(EkleVeyaGuncelle);
            Controls.Add(TabloyuYazdir);
            Controls.Add(label2);
            Controls.Add(AranacakDktrAdi);
            Controls.Add(SilinecekDoktorAdi);
            Controls.Add(DoktorAra);
            Controls.Add(button1);
            Controls.Add(GeriDon);
            Controls.Add(MenuDon);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "AdminDoktorlarEkrani";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminDoktorlarEkrani";
            ((System.ComponentModel.ISupportInitialize)TabloyuYazdir).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        public Label label3;
        private Button MenuDon;
        private Button GeriDon;
        private Button button1;
        private Button DoktorAra;
        private Button SilinecekDoktorAdi;
        private TextBox AranacakDktrAdi;
        private Label label2;
        private DataGridView TabloyuYazdir;
        private Button EkleVeyaGuncelle;
        private Label label4;
    }
}