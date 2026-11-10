namespace HASTANE_OTOMASYONU
{
    partial class SilinenRandevular
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
            label444 = new Label();
            AnaMenu = new Button();
            GeriDon = new Button();
            button1 = new Button();
            Goster = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)Goster).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.Cyan;
            label1.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(738, 71);
            label1.TabIndex = 0;
            label1.Text = "Hoş Geldiniz : ";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label444
            // 
            label444.AutoSize = true;
            label444.BackColor = Color.Cyan;
            label444.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label444.Location = new Point(141, 22);
            label444.Name = "label444";
            label444.Size = new Size(0, 27);
            label444.TabIndex = 1;
            label444.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // AnaMenu
            // 
            AnaMenu.BackColor = Color.Cyan;
            AnaMenu.BackgroundImage = Properties.Resources.home;
            AnaMenu.BackgroundImageLayout = ImageLayout.Zoom;
            AnaMenu.FlatStyle = FlatStyle.Flat;
            AnaMenu.Location = new Point(662, 10);
            AnaMenu.Name = "AnaMenu";
            AnaMenu.Size = new Size(63, 54);
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
            GeriDon.Location = new Point(593, 10);
            GeriDon.Name = "GeriDon";
            GeriDon.Size = new Size(63, 54);
            GeriDon.TabIndex = 3;
            GeriDon.UseVisualStyleBackColor = false;
            GeriDon.Click += GeriDon_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Cyan;
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Palatino Linotype", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            button1.Location = new Point(12, 84);
            button1.Name = "button1";
            button1.Size = new Size(713, 54);
            button1.TabIndex = 4;
            button1.Text = "SİLİNEN RANDEVULARI GÖSTER";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Goster
            // 
            Goster.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Goster.Location = new Point(12, 156);
            Goster.Name = "Goster";
            Goster.RowHeadersWidth = 51;
            Goster.Size = new Size(713, 270);
            Goster.TabIndex = 5;
            // 
            // SilinenRandevular
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(737, 438);
            Controls.Add(Goster);
            Controls.Add(button1);
            Controls.Add(GeriDon);
            Controls.Add(AnaMenu);
            Controls.Add(label444);
            Controls.Add(label1);
            Name = "SilinenRandevular";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SilinenRandevular";
            ((System.ComponentModel.ISupportInitialize)Goster).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        public Label label444;
        private Button AnaMenu;
        private Button GeriDon;
        private Button button1;
        private DataGridView Goster;
    }
}