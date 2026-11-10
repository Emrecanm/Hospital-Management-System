namespace HASTANE_OTOMASYONU
{
    partial class OtomasyonaGiris
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            AdminGirisi = new Button();
            DoktorGirisi = new Button();
            HastaGirisi = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Cyan;
            label1.Font = new Font("Palatino Linotype", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(0, -4);
            label1.Name = "label1";
            label1.Size = new Size(881, 123);
            label1.TabIndex = 0;
            label1.Text = "         \r\n        HASTANE OTOMASYONUNA HOŞ GELDİNİZ    🏥      \r\n\r\n";
            // 
            // AdminGirisi
            // 
            AdminGirisi.BackgroundImage = Properties.Resources.admin_with_cogwheels;
            AdminGirisi.BackgroundImageLayout = ImageLayout.Stretch;
            AdminGirisi.FlatStyle = FlatStyle.Flat;
            AdminGirisi.Location = new Point(84, 210);
            AdminGirisi.Name = "AdminGirisi";
            AdminGirisi.Size = new Size(164, 167);
            AdminGirisi.TabIndex = 1;
            AdminGirisi.UseVisualStyleBackColor = true;
            AdminGirisi.Click += AdminGirisi_Click;
            // 
            // DoktorGirisi
            // 
            DoktorGirisi.BackgroundImage = Properties.Resources.doctor;
            DoktorGirisi.BackgroundImageLayout = ImageLayout.Stretch;
            DoktorGirisi.FlatStyle = FlatStyle.Flat;
            DoktorGirisi.Location = new Point(359, 210);
            DoktorGirisi.Name = "DoktorGirisi";
            DoktorGirisi.Size = new Size(164, 167);
            DoktorGirisi.TabIndex = 2;
            DoktorGirisi.UseVisualStyleBackColor = true;
            DoktorGirisi.Click += DoktorGirisi_Click;
            // 
            // HastaGirisi
            // 
            HastaGirisi.BackgroundImage = Properties.Resources.patient;
            HastaGirisi.BackgroundImageLayout = ImageLayout.Stretch;
            HastaGirisi.FlatStyle = FlatStyle.Flat;
            HastaGirisi.Location = new Point(638, 210);
            HastaGirisi.Name = "HastaGirisi";
            HastaGirisi.Size = new Size(164, 167);
            HastaGirisi.TabIndex = 3;
            HastaGirisi.UseVisualStyleBackColor = true;
            HastaGirisi.Click += HastaGirisi_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold);
            label2.Location = new Point(100, 380);
            label2.Name = "label2";
            label2.Size = new Size(133, 27);
            label2.TabIndex = 4;
            label2.Text = "Admin Girişi";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold);
            label3.Location = new Point(376, 380);
            label3.Name = "label3";
            label3.Size = new Size(135, 27);
            label3.TabIndex = 5;
            label3.Text = "Doktor Girişi";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold);
            label4.Location = new Point(661, 380);
            label4.Name = "label4";
            label4.Size = new Size(122, 27);
            label4.TabIndex = 6;
            label4.Text = "Hasta Girişi";
            // 
            // OtomasyonaGiris
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(878, 468);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(HastaGirisi);
            Controls.Add(DoktorGirisi);
            Controls.Add(AdminGirisi);
            Controls.Add(label1);
            Name = "OtomasyonaGiris";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "OtomasyonGiris";
            FormClosing += OtomasyonaGiris_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button AdminGirisi;
        private Button DoktorGirisi;
        private Button HastaGirisi;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}
