namespace HASTANE_OTOMASYONU
{
    partial class AdminHemsirelerEkrani
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminHemsirelerEkrani));
            label1 = new Label();
            label11 = new Label();
            AnaMenu = new Button();
            button1 = new Button();
            HemsireleriListele = new Button();
            HemsireAra = new Button();
            HemsireSil = new Button();
            HemsireAdiAra = new TextBox();
            label2 = new Label();
            TabloyuYazdir = new DataGridView();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)TabloyuYazdir).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.Cyan;
            label1.Font = new Font("Palatino Linotype", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(-3, -1);
            label1.Name = "label1";
            label1.Size = new Size(902, 75);
            label1.TabIndex = 0;
            label1.Text = "Hoş Geldiniz : ";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Cyan;
            label11.Font = new Font("Palatino Linotype", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(171, 23);
            label11.Name = "label11";
            label11.Size = new Size(0, 31);
            label11.TabIndex = 1;
            // 
            // AnaMenu
            // 
            AnaMenu.BackColor = Color.Cyan;
            AnaMenu.BackgroundImage = Properties.Resources.home;
            AnaMenu.BackgroundImageLayout = ImageLayout.Zoom;
            AnaMenu.FlatStyle = FlatStyle.Flat;
            AnaMenu.Location = new Point(832, 12);
            AnaMenu.Name = "AnaMenu";
            AnaMenu.Size = new Size(54, 53);
            AnaMenu.TabIndex = 2;
            AnaMenu.UseVisualStyleBackColor = false;
            AnaMenu.Click += AnaMenu_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Cyan;
            button1.BackgroundImage = Properties.Resources.turn_back;
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(772, 12);
            button1.Name = "button1";
            button1.Size = new Size(54, 53);
            button1.TabIndex = 3;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // HemsireleriListele
            // 
            HemsireleriListele.BackColor = Color.Cyan;
            HemsireleriListele.FlatStyle = FlatStyle.Flat;
            HemsireleriListele.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            HemsireleriListele.Image = (Image)resources.GetObject("HemsireleriListele.Image");
            HemsireleriListele.ImageAlign = ContentAlignment.MiddleRight;
            HemsireleriListele.Location = new Point(12, 87);
            HemsireleriListele.Name = "HemsireleriListele";
            HemsireleriListele.Size = new Size(175, 69);
            HemsireleriListele.TabIndex = 4;
            HemsireleriListele.Text = "Hemşireleri\r\nListeler";
            HemsireleriListele.TextAlign = ContentAlignment.MiddleLeft;
            HemsireleriListele.UseVisualStyleBackColor = false;
            HemsireleriListele.Click += HemsireleriListele_Click;
            // 
            // HemsireAra
            // 
            HemsireAra.BackColor = Color.Cyan;
            HemsireAra.FlatStyle = FlatStyle.Flat;
            HemsireAra.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            HemsireAra.Image = (Image)resources.GetObject("HemsireAra.Image");
            HemsireAra.ImageAlign = ContentAlignment.MiddleRight;
            HemsireAra.Location = new Point(12, 172);
            HemsireAra.Name = "HemsireAra";
            HemsireAra.Size = new Size(175, 68);
            HemsireAra.TabIndex = 5;
            HemsireAra.Text = "Hemşire\r\nAra";
            HemsireAra.TextAlign = ContentAlignment.MiddleLeft;
            HemsireAra.UseVisualStyleBackColor = false;
            HemsireAra.Click += HemsireAra_Click;
            // 
            // HemsireSil
            // 
            HemsireSil.BackColor = Color.Cyan;
            HemsireSil.FlatStyle = FlatStyle.Flat;
            HemsireSil.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            HemsireSil.Image = (Image)resources.GetObject("HemsireSil.Image");
            HemsireSil.ImageAlign = ContentAlignment.MiddleRight;
            HemsireSil.Location = new Point(12, 256);
            HemsireSil.Name = "HemsireSil";
            HemsireSil.Size = new Size(175, 68);
            HemsireSil.TabIndex = 6;
            HemsireSil.Text = "Hemsire\r\nSil";
            HemsireSil.TextAlign = ContentAlignment.MiddleLeft;
            HemsireSil.UseVisualStyleBackColor = false;
            HemsireSil.Click += HemsireSil_Click;
            // 
            // HemsireAdiAra
            // 
            HemsireAdiAra.BackColor = Color.Cyan;
            HemsireAdiAra.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            HemsireAdiAra.Location = new Point(193, 190);
            HemsireAdiAra.Name = "HemsireAdiAra";
            HemsireAdiAra.Size = new Size(187, 34);
            HemsireAdiAra.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label2.Location = new Point(255, 160);
            label2.Name = "label2";
            label2.Size = new Size(51, 27);
            label2.TabIndex = 8;
            label2.Text = "İsim";
            // 
            // TabloyuYazdir
            // 
            TabloyuYazdir.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TabloyuYazdir.Location = new Point(12, 330);
            TabloyuYazdir.Name = "TabloyuYazdir";
            TabloyuYazdir.RowHeadersWidth = 51;
            TabloyuYazdir.Size = new Size(874, 293);
            TabloyuYazdir.TabIndex = 9;
            // 
            // button2
            // 
            button2.BackColor = Color.Cyan;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleRight;
            button2.Location = new Point(658, 153);
            button2.Name = "button2";
            button2.Size = new Size(228, 106);
            button2.TabIndex = 10;
            button2.Text = "Hemşire Ekle\r\nVeya Güncelle";
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // AdminHemsirelerEkrani
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(898, 636);
            Controls.Add(button2);
            Controls.Add(TabloyuYazdir);
            Controls.Add(label2);
            Controls.Add(HemsireAdiAra);
            Controls.Add(HemsireSil);
            Controls.Add(HemsireAra);
            Controls.Add(HemsireleriListele);
            Controls.Add(button1);
            Controls.Add(AnaMenu);
            Controls.Add(label11);
            Controls.Add(label1);
            Name = "AdminHemsirelerEkrani";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminHemsirelerEkrani";
            ((System.ComponentModel.ISupportInitialize)TabloyuYazdir).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        public Label label11;
        private Button AnaMenu;
        private Button button1;
        private Button HemsireleriListele;
        private Button HemsireAra;
        private Button HemsireSil;
        private TextBox HemsireAdiAra;
        private Label label2;
        private DataGridView TabloyuYazdir;
        private Button button2;
    }
}