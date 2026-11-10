namespace HASTANE_OTOMASYONU
{
    partial class TedaviEdilmisHastalar
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
            label111 = new Label();
            AnaMenu = new Button();
            GeriDon = new Button();
            button1 = new Button();
            HastalarıGetir = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)HastalarıGetir).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.Cyan;
            label1.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(0, -2);
            label1.Name = "label1";
            label1.Size = new Size(922, 71);
            label1.TabIndex = 0;
            label1.Text = "Hoş Geldiniz : ";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label111
            // 
            label111.AutoSize = true;
            label111.BackColor = Color.Cyan;
            label111.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label111.ForeColor = SystemColors.ControlText;
            label111.Location = new Point(146, 20);
            label111.Name = "label111";
            label111.Size = new Size(0, 27);
            label111.TabIndex = 1;
            label111.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // AnaMenu
            // 
            AnaMenu.BackColor = Color.Cyan;
            AnaMenu.BackgroundImage = Properties.Resources.home;
            AnaMenu.BackgroundImageLayout = ImageLayout.Zoom;
            AnaMenu.FlatStyle = FlatStyle.Flat;
            AnaMenu.Location = new Point(848, 8);
            AnaMenu.Name = "AnaMenu";
            AnaMenu.Size = new Size(60, 55);
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
            GeriDon.Location = new Point(782, 8);
            GeriDon.Name = "GeriDon";
            GeriDon.Size = new Size(60, 55);
            GeriDon.TabIndex = 3;
            GeriDon.UseVisualStyleBackColor = false;
            GeriDon.Click += GeriDon_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Cyan;
            button1.Font = new Font("Palatino Linotype", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            button1.Location = new Point(12, 86);
            button1.Name = "button1";
            button1.Size = new Size(896, 65);
            button1.TabIndex = 4;
            button1.Text = "Tedavi Edilmiş Hastaları Göster";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // HastalarıGetir
            // 
            HastalarıGetir.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            HastalarıGetir.Location = new Point(12, 169);
            HastalarıGetir.Name = "HastalarıGetir";
            HastalarıGetir.RowHeadersWidth = 51;
            HastalarıGetir.Size = new Size(896, 269);
            HastalarıGetir.TabIndex = 5;
            // 
            // TedaviEdilmisHastalar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(920, 450);
            Controls.Add(HastalarıGetir);
            Controls.Add(button1);
            Controls.Add(GeriDon);
            Controls.Add(AnaMenu);
            Controls.Add(label111);
            Controls.Add(label1);
            Name = "TedaviEdilmisHastalar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TedaviEdilmisHastalar";
            ((System.ComponentModel.ISupportInitialize)HastalarıGetir).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        public Label label111;
        private Button AnaMenu;
        private Button GeriDon;
        private Button button1;
        private DataGridView HastalarıGetir;
    }
}