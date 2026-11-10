namespace HASTANE_OTOMASYONU
{
    partial class Silinen_EklenenHastalar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Silinen_EklenenHastalar));
            label1 = new Label();
            label777 = new Label();
            AnaMenu = new Button();
            geriDon = new Button();
            goster = new DataGridView();
            EklenenHastalar = new Button();
            SilinenHastalar = new Button();
            ((System.ComponentModel.ISupportInitialize)goster).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.Cyan;
            label1.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(0, -4);
            label1.Name = "label1";
            label1.Size = new Size(875, 67);
            label1.TabIndex = 0;
            label1.Text = "Hoş Geldiniz : ";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label777
            // 
            label777.AutoSize = true;
            label777.BackColor = Color.Cyan;
            label777.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label777.Location = new Point(139, 16);
            label777.Name = "label777";
            label777.Size = new Size(0, 27);
            label777.TabIndex = 1;
            label777.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // AnaMenu
            // 
            AnaMenu.BackColor = Color.Cyan;
            AnaMenu.BackgroundImage = Properties.Resources.home;
            AnaMenu.BackgroundImageLayout = ImageLayout.Zoom;
            AnaMenu.FlatStyle = FlatStyle.Flat;
            AnaMenu.Location = new Point(812, 6);
            AnaMenu.Name = "AnaMenu";
            AnaMenu.Size = new Size(48, 51);
            AnaMenu.TabIndex = 2;
            AnaMenu.UseVisualStyleBackColor = false;
            AnaMenu.Click += AnaMenu_Click;
            // 
            // geriDon
            // 
            geriDon.BackColor = Color.Cyan;
            geriDon.BackgroundImage = Properties.Resources.turn_back;
            geriDon.BackgroundImageLayout = ImageLayout.Zoom;
            geriDon.FlatStyle = FlatStyle.Flat;
            geriDon.Location = new Point(758, 6);
            geriDon.Name = "geriDon";
            geriDon.Size = new Size(48, 51);
            geriDon.TabIndex = 3;
            geriDon.UseVisualStyleBackColor = false;
            geriDon.Click += geriDon_Click;
            // 
            // goster
            // 
            goster.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            goster.Location = new Point(12, 186);
            goster.Name = "goster";
            goster.RowHeadersWidth = 51;
            goster.Size = new Size(848, 291);
            goster.TabIndex = 4;
            // 
            // EklenenHastalar
            // 
            EklenenHastalar.BackColor = Color.Cyan;
            EklenenHastalar.FlatStyle = FlatStyle.Flat;
            EklenenHastalar.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            EklenenHastalar.Image = (Image)resources.GetObject("EklenenHastalar.Image");
            EklenenHastalar.ImageAlign = ContentAlignment.MiddleRight;
            EklenenHastalar.Location = new Point(12, 100);
            EklenenHastalar.Name = "EklenenHastalar";
            EklenenHastalar.Size = new Size(356, 60);
            EklenenHastalar.TabIndex = 5;
            EklenenHastalar.Text = "Sonradan Eklenen Hastlar";
            EklenenHastalar.TextAlign = ContentAlignment.MiddleLeft;
            EklenenHastalar.UseVisualStyleBackColor = false;
            EklenenHastalar.Click += EklenenHastalar_Click;
            // 
            // SilinenHastalar
            // 
            SilinenHastalar.BackColor = Color.Cyan;
            SilinenHastalar.FlatStyle = FlatStyle.Flat;
            SilinenHastalar.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            SilinenHastalar.Image = (Image)resources.GetObject("SilinenHastalar.Image");
            SilinenHastalar.ImageAlign = ContentAlignment.MiddleRight;
            SilinenHastalar.Location = new Point(508, 100);
            SilinenHastalar.Name = "SilinenHastalar";
            SilinenHastalar.Size = new Size(352, 60);
            SilinenHastalar.TabIndex = 6;
            SilinenHastalar.Text = "Sonradan Silinen Hastlar";
            SilinenHastalar.TextAlign = ContentAlignment.MiddleLeft;
            SilinenHastalar.UseVisualStyleBackColor = false;
            SilinenHastalar.Click += SilinenHastalar_Click;
            // 
            // Silinen_EklenenHastalar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(872, 489);
            Controls.Add(SilinenHastalar);
            Controls.Add(EklenenHastalar);
            Controls.Add(goster);
            Controls.Add(geriDon);
            Controls.Add(AnaMenu);
            Controls.Add(label777);
            Controls.Add(label1);
            Name = "Silinen_EklenenHastalar";
            Text = "Silinen_EklenenHastalar";
            ((System.ComponentModel.ISupportInitialize)goster).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button AnaMenu;
        private Button geriDon;
        public Label label777;
        private DataGridView goster;
        private Button EklenenHastalar;
        private Button SilinenHastalar;
    }
}