namespace HASTANE_OTOMASYONU
{
    partial class DoktorEkrani
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoktorEkrani));
            label1 = new Label();
            AnaMenu = new Button();
            label23 = new Label();
            HastalariListele = new Button();
            HastaAra = new Button();
            HastaSil = new Button();
            HastaSayisi = new Button();
            TabloyuGoster = new DataGridView();
            HastaAdi = new TextBox();
            label2 = new Label();
            label3 = new Label();
            TedaviEkle = new RichTextBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)TabloyuGoster).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.Cyan;
            label1.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(-3, -2);
            label1.Name = "label1";
            label1.Size = new Size(1105, 81);
            label1.TabIndex = 0;
            label1.Text = " Hoş Geldiniz :";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // AnaMenu
            // 
            AnaMenu.BackColor = Color.Cyan;
            AnaMenu.BackgroundImage = Properties.Resources.home;
            AnaMenu.BackgroundImageLayout = ImageLayout.Zoom;
            AnaMenu.FlatStyle = FlatStyle.Flat;
            AnaMenu.ForeColor = Color.Black;
            AnaMenu.Location = new Point(1027, 12);
            AnaMenu.Name = "AnaMenu";
            AnaMenu.Size = new Size(61, 54);
            AnaMenu.TabIndex = 1;
            AnaMenu.UseVisualStyleBackColor = false;
            AnaMenu.Click += AnaMenu_Click;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.BackColor = Color.Cyan;
            label23.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label23.Location = new Point(149, 24);
            label23.Name = "label23";
            label23.Size = new Size(0, 27);
            label23.TabIndex = 2;
            label23.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // HastalariListele
            // 
            HastalariListele.BackColor = Color.Cyan;
            HastalariListele.FlatStyle = FlatStyle.Flat;
            HastalariListele.Image = (Image)resources.GetObject("HastalariListele.Image");
            HastalariListele.ImageAlign = ContentAlignment.MiddleRight;
            HastalariListele.Location = new Point(11, 108);
            HastalariListele.Name = "HastalariListele";
            HastalariListele.Size = new Size(247, 51);
            HastalariListele.TabIndex = 3;
            HastalariListele.Text = "Hastalarımı Listele";
            HastalariListele.TextAlign = ContentAlignment.MiddleLeft;
            HastalariListele.UseVisualStyleBackColor = false;
            HastalariListele.Click += HastalariListele_Click;
            // 
            // HastaAra
            // 
            HastaAra.BackColor = Color.Cyan;
            HastaAra.FlatStyle = FlatStyle.Flat;
            HastaAra.Image = (Image)resources.GetObject("HastaAra.Image");
            HastaAra.ImageAlign = ContentAlignment.MiddleRight;
            HastaAra.Location = new Point(11, 166);
            HastaAra.Name = "HastaAra";
            HastaAra.Size = new Size(247, 51);
            HastaAra.TabIndex = 4;
            HastaAra.Text = "Hastalarımdan Ara";
            HastaAra.TextAlign = ContentAlignment.MiddleLeft;
            HastaAra.UseVisualStyleBackColor = false;
            HastaAra.Click += HastaAra_Click;
            // 
            // HastaSil
            // 
            HastaSil.BackColor = Color.Cyan;
            HastaSil.FlatStyle = FlatStyle.Flat;
            HastaSil.Image = (Image)resources.GetObject("HastaSil.Image");
            HastaSil.ImageAlign = ContentAlignment.MiddleRight;
            HastaSil.Location = new Point(11, 226);
            HastaSil.Name = "HastaSil";
            HastaSil.Size = new Size(247, 51);
            HastaSil.TabIndex = 5;
            HastaSil.Text = "Hastalarımdan Sil";
            HastaSil.TextAlign = ContentAlignment.MiddleLeft;
            HastaSil.UseVisualStyleBackColor = false;
            HastaSil.Click += HastaSil_Click;
            // 
            // HastaSayisi
            // 
            HastaSayisi.BackColor = Color.Cyan;
            HastaSayisi.FlatStyle = FlatStyle.Flat;
            HastaSayisi.Image = (Image)resources.GetObject("HastaSayisi.Image");
            HastaSayisi.ImageAlign = ContentAlignment.MiddleRight;
            HastaSayisi.Location = new Point(11, 285);
            HastaSayisi.Name = "HastaSayisi";
            HastaSayisi.Size = new Size(247, 51);
            HastaSayisi.TabIndex = 6;
            HastaSayisi.Text = "İlaç Yaz";
            HastaSayisi.TextAlign = ContentAlignment.MiddleLeft;
            HastaSayisi.UseVisualStyleBackColor = false;
            HastaSayisi.Click += HastaSayisi_Click;
            // 
            // TabloyuGoster
            // 
            TabloyuGoster.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TabloyuGoster.Location = new Point(463, 177);
            TabloyuGoster.Margin = new Padding(2);
            TabloyuGoster.Name = "TabloyuGoster";
            TabloyuGoster.RowHeadersWidth = 51;
            TabloyuGoster.Size = new Size(625, 403);
            TabloyuGoster.TabIndex = 8;
            TabloyuGoster.CellMouseClick += TabloyuGoster_CellMouseClick;
            // 
            // HastaAdi
            // 
            HastaAdi.BackColor = Color.Cyan;
            HastaAdi.Location = new Point(264, 177);
            HastaAdi.Name = "HastaAdi";
            HastaAdi.Size = new Size(194, 30);
            HastaAdi.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Info;
            label2.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(332, 147);
            label2.Name = "label2";
            label2.Size = new Size(51, 27);
            label2.TabIndex = 10;
            label2.Text = "isim";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.Info;
            label3.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.Location = new Point(633, 119);
            label3.Name = "label3";
            label3.Size = new Size(267, 27);
            label3.TabIndex = 11;
            label3.Text = "GÜNCEL HASTALARINIZ";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TedaviEkle
            // 
            TedaviEkle.BackColor = Color.Cyan;
            TedaviEkle.ForeColor = SystemColors.ControlText;
            TedaviEkle.Location = new Point(11, 432);
            TedaviEkle.Name = "TedaviEkle";
            TedaviEkle.Size = new Size(247, 148);
            TedaviEkle.TabIndex = 12;
            TedaviEkle.Text = "";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.Info;
            label4.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label4.Location = new Point(12, 375);
            label4.Name = "label4";
            label4.Size = new Size(229, 54);
            label4.TabIndex = 13;
            label4.Text = "İlaç Yazmak İstediğiniz \r\nHastya Basın.";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // DoktorEkrani
            // 
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(1100, 602);
            Controls.Add(label4);
            Controls.Add(TedaviEkle);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(HastaAdi);
            Controls.Add(TabloyuGoster);
            Controls.Add(HastaSayisi);
            Controls.Add(HastaSil);
            Controls.Add(HastaAra);
            Controls.Add(HastalariListele);
            Controls.Add(label23);
            Controls.Add(AnaMenu);
            Controls.Add(label1);
            Font = new Font("Palatino Linotype", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            Name = "DoktorEkrani";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DoktorEkrani";
            ((System.ComponentModel.ISupportInitialize)TabloyuGoster).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button AnaMenu;
        public Label label23;
        private Button HastalariListele;
        private Button HastaAra;
        private Button HastaSil;
        private Button HastaSayisi;
        private DataGridView TabloyuGoster;
        private TextBox HastaAdi;
        public Label label2;
        public Label label3;
        private RichTextBox TedaviEkle;
        public Label label4;
    }
}