namespace HASTANE_OTOMASYONU
{
    partial class AdminHastalarEkrani
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminHastalarEkrani));
            label1 = new Label();
            label12 = new Label();
            AnaMenu = new Button();
            GeriDon = new Button();
            HastalariListele = new Button();
            HastaAra = new Button();
            HastaSil = new Button();
            TabloyuYazdir = new DataGridView();
            HastaAdiAra = new TextBox();
            labisim = new Label();
            HastaEkleVeyaGüncelle = new Button();
            ((System.ComponentModel.ISupportInitialize)TabloyuYazdir).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.Cyan;
            label1.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(-1, -2);
            label1.Name = "label1";
            label1.Size = new Size(898, 74);
            label1.TabIndex = 0;
            label1.Text = "Hoş Geldiniz :";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Cyan;
            label12.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label12.Location = new Point(137, 20);
            label12.Name = "label12";
            label12.Size = new Size(0, 27);
            label12.TabIndex = 1;
            // 
            // AnaMenu
            // 
            AnaMenu.BackColor = Color.Cyan;
            AnaMenu.BackgroundImage = Properties.Resources.home;
            AnaMenu.BackgroundImageLayout = ImageLayout.Zoom;
            AnaMenu.FlatStyle = FlatStyle.Flat;
            AnaMenu.Location = new Point(825, 12);
            AnaMenu.Name = "AnaMenu";
            AnaMenu.Size = new Size(62, 48);
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
            GeriDon.Location = new Point(761, 12);
            GeriDon.Name = "GeriDon";
            GeriDon.Size = new Size(56, 47);
            GeriDon.TabIndex = 3;
            GeriDon.UseVisualStyleBackColor = false;
            GeriDon.Click += GeriDon_Click;
            // 
            // HastalariListele
            // 
            HastalariListele.BackColor = Color.Cyan;
            HastalariListele.FlatStyle = FlatStyle.Flat;
            HastalariListele.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            HastalariListele.Image = (Image)resources.GetObject("HastalariListele.Image");
            HastalariListele.ImageAlign = ContentAlignment.MiddleRight;
            HastalariListele.Location = new Point(12, 84);
            HastalariListele.Name = "HastalariListele";
            HastalariListele.Size = new Size(174, 72);
            HastalariListele.TabIndex = 4;
            HastalariListele.Text = "Hastaları \r\nListele\r\n";
            HastalariListele.TextAlign = ContentAlignment.MiddleLeft;
            HastalariListele.UseVisualStyleBackColor = false;
            HastalariListele.Click += HastalariListele_Click;
            // 
            // HastaAra
            // 
            HastaAra.BackColor = Color.Cyan;
            HastaAra.FlatStyle = FlatStyle.Flat;
            HastaAra.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            HastaAra.Image = (Image)resources.GetObject("HastaAra.Image");
            HastaAra.ImageAlign = ContentAlignment.MiddleRight;
            HastaAra.Location = new Point(12, 172);
            HastaAra.Name = "HastaAra";
            HastaAra.Size = new Size(174, 72);
            HastaAra.TabIndex = 5;
            HastaAra.Text = "Hasta Ara";
            HastaAra.TextAlign = ContentAlignment.MiddleLeft;
            HastaAra.UseVisualStyleBackColor = false;
            HastaAra.Click += HastaAra_Click;
            // 
            // HastaSil
            // 
            HastaSil.BackColor = Color.Cyan;
            HastaSil.FlatStyle = FlatStyle.Flat;
            HastaSil.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            HastaSil.Image = (Image)resources.GetObject("HastaSil.Image");
            HastaSil.ImageAlign = ContentAlignment.MiddleRight;
            HastaSil.Location = new Point(12, 264);
            HastaSil.Name = "HastaSil";
            HastaSil.Size = new Size(174, 72);
            HastaSil.TabIndex = 6;
            HastaSil.Text = "Hasta Sil";
            HastaSil.TextAlign = ContentAlignment.MiddleLeft;
            HastaSil.UseVisualStyleBackColor = false;
            HastaSil.Click += HastaSil_Click;
            // 
            // TabloyuYazdir
            // 
            TabloyuYazdir.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TabloyuYazdir.Location = new Point(12, 342);
            TabloyuYazdir.Name = "TabloyuYazdir";
            TabloyuYazdir.RowHeadersWidth = 51;
            TabloyuYazdir.Size = new Size(875, 306);
            TabloyuYazdir.TabIndex = 7;
            TabloyuYazdir.MouseClick += TabloyuYazdir_MouseClick;
            // 
            // HastaAdiAra
            // 
            HastaAdiAra.BackColor = Color.Cyan;
            HastaAdiAra.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            HastaAdiAra.Location = new Point(192, 192);
            HastaAdiAra.Name = "HastaAdiAra";
            HastaAdiAra.Size = new Size(186, 34);
            HastaAdiAra.TabIndex = 8;
            // 
            // labisim
            // 
            labisim.AutoSize = true;
            labisim.FlatStyle = FlatStyle.Flat;
            labisim.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            labisim.Location = new Point(253, 162);
            labisim.Name = "labisim";
            labisim.Size = new Size(51, 27);
            labisim.TabIndex = 9;
            labisim.Text = "İsim";
            // 
            // HastaEkleVeyaGüncelle
            // 
            HastaEkleVeyaGüncelle.BackColor = Color.Cyan;
            HastaEkleVeyaGüncelle.FlatStyle = FlatStyle.Flat;
            HastaEkleVeyaGüncelle.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            HastaEkleVeyaGüncelle.Image = (Image)resources.GetObject("HastaEkleVeyaGüncelle.Image");
            HastaEkleVeyaGüncelle.ImageAlign = ContentAlignment.MiddleRight;
            HastaEkleVeyaGüncelle.Location = new Point(633, 155);
            HastaEkleVeyaGüncelle.Name = "HastaEkleVeyaGüncelle";
            HastaEkleVeyaGüncelle.Size = new Size(252, 106);
            HastaEkleVeyaGüncelle.TabIndex = 11;
            HastaEkleVeyaGüncelle.Text = "Hasta Ekle\r\nVeya Güncelle\r\n";
            HastaEkleVeyaGüncelle.TextAlign = ContentAlignment.MiddleLeft;
            HastaEkleVeyaGüncelle.UseVisualStyleBackColor = false;
            HastaEkleVeyaGüncelle.Click += HastaEkleVeyaGüncelle_Click;
            // 
            // AdminHastalarEkrani
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(897, 643);
            Controls.Add(HastaEkleVeyaGüncelle);
            Controls.Add(labisim);
            Controls.Add(HastaAdiAra);
            Controls.Add(TabloyuYazdir);
            Controls.Add(HastaSil);
            Controls.Add(HastaAra);
            Controls.Add(HastalariListele);
            Controls.Add(GeriDon);
            Controls.Add(AnaMenu);
            Controls.Add(label12);
            Controls.Add(label1);
            Name = "AdminHastalarEkrani";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminHastalarEkrani";
            ((System.ComponentModel.ISupportInitialize)TabloyuYazdir).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        public Label label12;
        private Button AnaMenu;
        private Button GeriDon;
        private Button HastalariListele;
        private Button HastaAra;
        private Button HastaSil;
        private DataGridView TabloyuYazdir;
        private TextBox HastaAdiAra;
        private Label labisim;
        private Button HastaEkleVeyaGüncelle;
    }
}