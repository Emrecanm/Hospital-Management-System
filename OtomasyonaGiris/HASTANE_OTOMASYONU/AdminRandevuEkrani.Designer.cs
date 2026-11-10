namespace HASTANE_OTOMASYONU
{
    partial class AdminRandevuEkrani
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminRandevuEkrani));
            label1 = new Label();
            label44 = new Label();
            AnaMenu = new Button();
            button1 = new Button();
            TabloyuYazdir = new DataGridView();
            TabloyuGetir = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)TabloyuYazdir).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.Cyan;
            label1.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(-3, -3);
            label1.Name = "label1";
            label1.Size = new Size(916, 76);
            label1.TabIndex = 0;
            label1.Text = "Hoş Geldiniz :";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label44
            // 
            label44.AutoSize = true;
            label44.BackColor = Color.Cyan;
            label44.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label44.Location = new Point(143, 22);
            label44.Name = "label44";
            label44.Size = new Size(0, 27);
            label44.TabIndex = 1;
            // 
            // AnaMenu
            // 
            AnaMenu.BackColor = Color.Cyan;
            AnaMenu.BackgroundImage = Properties.Resources.home;
            AnaMenu.BackgroundImageLayout = ImageLayout.Zoom;
            AnaMenu.FlatStyle = FlatStyle.Flat;
            AnaMenu.Location = new Point(838, 10);
            AnaMenu.Name = "AnaMenu";
            AnaMenu.Size = new Size(56, 54);
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
            button1.Location = new Point(776, 12);
            button1.Name = "button1";
            button1.Size = new Size(56, 54);
            button1.TabIndex = 3;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // TabloyuYazdir
            // 
            TabloyuYazdir.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TabloyuYazdir.Location = new Point(12, 181);
            TabloyuYazdir.Name = "TabloyuYazdir";
            TabloyuYazdir.RowHeadersWidth = 51;
            TabloyuYazdir.Size = new Size(882, 446);
            TabloyuYazdir.TabIndex = 14;
            // 
            // TabloyuGetir
            // 
            TabloyuGetir.BackColor = Color.Cyan;
            TabloyuGetir.FlatStyle = FlatStyle.Flat;
            TabloyuGetir.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            TabloyuGetir.Image = (Image)resources.GetObject("TabloyuGetir.Image");
            TabloyuGetir.ImageAlign = ContentAlignment.MiddleRight;
            TabloyuGetir.Location = new Point(12, 88);
            TabloyuGetir.Name = "TabloyuGetir";
            TabloyuGetir.Size = new Size(318, 70);
            TabloyuGetir.TabIndex = 15;
            TabloyuGetir.Text = "Randevuları Listele";
            TabloyuGetir.TextAlign = ContentAlignment.MiddleLeft;
            TabloyuGetir.UseVisualStyleBackColor = false;
            TabloyuGetir.Click += TabloyuGetir_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Cyan;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.ImageAlign = ContentAlignment.MiddleRight;
            button3.Location = new Point(540, 88);
            button3.Name = "button3";
            button3.Size = new Size(354, 70);
            button3.TabIndex = 17;
            button3.Text = "Randevuyu\r\nSil";
            button3.TextAlign = ContentAlignment.MiddleLeft;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // AdminRandevuEkrani
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(906, 622);
            Controls.Add(button3);
            Controls.Add(TabloyuGetir);
            Controls.Add(TabloyuYazdir);
            Controls.Add(button1);
            Controls.Add(AnaMenu);
            Controls.Add(label44);
            Controls.Add(label1);
            Name = "AdminRandevuEkrani";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminRandevuEkrani";
            ((System.ComponentModel.ISupportInitialize)TabloyuYazdir).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        public Label label44;
        private Button AnaMenu;
        private Button button1;
        private DataGridView TabloyuYazdir;
        private Button TabloyuGetir;
        private Button button3;
    }
}