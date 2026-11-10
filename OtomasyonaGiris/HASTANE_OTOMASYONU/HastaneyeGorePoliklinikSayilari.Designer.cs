namespace HASTANE_OTOMASYONU
{
    partial class HastaneyeGorePoliklinikSayilari
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
            label66 = new Label();
            AnaMenu = new Button();
            button1 = new Button();
            PolSayisi1 = new Button();
            button2 = new Button();
            PoliklinikSayisi = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)PoliklinikSayisi).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.Cyan;
            label1.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(-5, -1);
            label1.Name = "label1";
            label1.Size = new Size(606, 68);
            label1.TabIndex = 0;
            label1.Text = "Hoş Geldiniz : ";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label66
            // 
            label66.AutoSize = true;
            label66.BackColor = Color.Cyan;
            label66.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label66.Location = new Point(142, 20);
            label66.Name = "label66";
            label66.Size = new Size(0, 27);
            label66.TabIndex = 1;
            label66.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // AnaMenu
            // 
            AnaMenu.BackColor = Color.Cyan;
            AnaMenu.BackgroundImage = Properties.Resources.home;
            AnaMenu.BackgroundImageLayout = ImageLayout.Zoom;
            AnaMenu.FlatStyle = FlatStyle.Flat;
            AnaMenu.Location = new Point(535, 10);
            AnaMenu.Name = "AnaMenu";
            AnaMenu.Size = new Size(53, 50);
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
            button1.Location = new Point(476, 10);
            button1.Name = "button1";
            button1.Size = new Size(53, 50);
            button1.TabIndex = 3;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // PolSayisi1
            // 
            PolSayisi1.BackColor = Color.Cyan;
            PolSayisi1.FlatStyle = FlatStyle.Flat;
            PolSayisi1.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            PolSayisi1.Location = new Point(12, 81);
            PolSayisi1.Name = "PolSayisi1";
            PolSayisi1.Size = new Size(576, 53);
            PolSayisi1.TabIndex = 4;
            PolSayisi1.Text = "Atatürk üniversitesi Poliklinik Sayisi";
            PolSayisi1.UseVisualStyleBackColor = false;
            PolSayisi1.Click += PolSayisi1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Cyan;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            button2.Location = new Point(12, 151);
            button2.Name = "button2";
            button2.Size = new Size(576, 53);
            button2.TabIndex = 5;
            button2.Text = "Oltu Devlet Hastanesi Poliklinik Sayisi";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // PoliklinikSayisi
            // 
            PoliklinikSayisi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PoliklinikSayisi.Location = new Point(12, 227);
            PoliklinikSayisi.Name = "PoliklinikSayisi";
            PoliklinikSayisi.RowHeadersWidth = 51;
            PoliklinikSayisi.Size = new Size(576, 160);
            PoliklinikSayisi.TabIndex = 6;
            // 
            // HastaneyeGorePoliklinikSayilari
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(600, 399);
            Controls.Add(PoliklinikSayisi);
            Controls.Add(button2);
            Controls.Add(PolSayisi1);
            Controls.Add(button1);
            Controls.Add(AnaMenu);
            Controls.Add(label66);
            Controls.Add(label1);
            Name = "HastaneyeGorePoliklinikSayilari";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HastaneyeGorePoliklinikSayilari";
            ((System.ComponentModel.ISupportInitialize)PoliklinikSayisi).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        public Label label66;
        private Button AnaMenu;
        private Button button1;
        private Button PolSayisi1;
        private Button button2;
        private DataGridView PoliklinikSayisi;
    }
}