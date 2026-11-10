namespace HASTANE_OTOMASYONU
{
    partial class HastaRandevuAl
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
            label333 = new Label();
            tc = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            saat = new ComboBox();
            hastaneAd = new ComboBox();
            klinikAd = new ComboBox();
            DoktorAd = new ComboBox();
            Goster = new DataGridView();
            RandevularıGetir = new Button();
            button1 = new Button();
            tarih = new ComboBox();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)Goster).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.Cyan;
            label1.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(-1, -3);
            label1.Name = "label1";
            label1.Size = new Size(1005, 68);
            label1.TabIndex = 0;
            label1.Text = "Hoş Geldiniz : ";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            label1.Click += label1_Click;
            // 
            // label333
            // 
            label333.AutoSize = true;
            label333.BackColor = Color.Cyan;
            label333.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label333.Location = new Point(143, 18);
            label333.Name = "label333";
            label333.Size = new Size(0, 27);
            label333.TabIndex = 1;
            label333.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tc
            // 
            tc.BackColor = Color.Cyan;
            tc.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold | FontStyle.Italic);
            tc.Location = new Point(703, 86);
            tc.Name = "tc";
            tc.Size = new Size(250, 34);
            tc.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold | FontStyle.Italic);
            label2.Location = new Point(594, 89);
            label2.Name = "label2";
            label2.Size = new Size(103, 27);
            label2.TabIndex = 3;
            label2.Text = "Hasta TC ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold | FontStyle.Italic);
            label3.Location = new Point(550, 173);
            label3.Name = "label3";
            label3.Size = new Size(147, 27);
            label3.TabIndex = 5;
            label3.Text = "Randevu Tarihi";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold | FontStyle.Italic);
            label4.Location = new Point(555, 248);
            label4.Name = "label4";
            label4.Size = new Size(142, 27);
            label4.TabIndex = 7;
            label4.Text = "Randevu Saati";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold | FontStyle.Italic);
            label5.Location = new Point(35, 89);
            label5.Name = "label5";
            label5.Size = new Size(122, 27);
            label5.TabIndex = 9;
            label5.Text = "Hastane Adı";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold | FontStyle.Italic);
            label6.Location = new Point(56, 168);
            label6.Name = "label6";
            label6.Size = new Size(101, 27);
            label6.TabIndex = 11;
            label6.Text = "Klinik Adı";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold | FontStyle.Italic);
            label7.Location = new Point(45, 251);
            label7.Name = "label7";
            label7.Size = new Size(112, 27);
            label7.TabIndex = 13;
            label7.Text = "Doktor Adı";
            // 
            // saat
            // 
            saat.BackColor = Color.Cyan;
            saat.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            saat.FormattingEnabled = true;
            saat.Items.AddRange(new object[] { "13:00", "13:30", "14:00", "14:30", "15:00", "15:50", "16:00" });
            saat.Location = new Point(703, 240);
            saat.Name = "saat";
            saat.Size = new Size(250, 35);
            saat.TabIndex = 15;
            // 
            // hastaneAd
            // 
            hastaneAd.BackColor = Color.Cyan;
            hastaneAd.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            hastaneAd.FormattingEnabled = true;
            hastaneAd.Items.AddRange(new object[] { "Atatürk Üniversitesi", "Oltu Devlet Hastanesi" });
            hastaneAd.Location = new Point(177, 86);
            hastaneAd.Name = "hastaneAd";
            hastaneAd.Size = new Size(250, 35);
            hastaneAd.TabIndex = 16;
            // 
            // klinikAd
            // 
            klinikAd.BackColor = Color.Cyan;
            klinikAd.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            klinikAd.FormattingEnabled = true;
            klinikAd.Items.AddRange(new object[] { "Anatomi", "Dahiliye", "Diyaliz", "Enfeksiyon Hastalıkları", "Patoloji", "Biyokimya" });
            klinikAd.Location = new Point(177, 168);
            klinikAd.Name = "klinikAd";
            klinikAd.Size = new Size(250, 35);
            klinikAd.TabIndex = 17;
            // 
            // DoktorAd
            // 
            DoktorAd.BackColor = Color.Cyan;
            DoktorAd.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            DoktorAd.FormattingEnabled = true;
            DoktorAd.Items.AddRange(new object[] { "Doc. Dr Mete Yağanoğlu", "Öğretim Üyesi Aslan Dağlı", "Öğretim üyesi Sena Yüklü", "Cerrah Alhan Farklı", "" });
            DoktorAd.Location = new Point(177, 248);
            DoktorAd.Name = "DoktorAd";
            DoktorAd.Size = new Size(250, 35);
            DoktorAd.TabIndex = 18;
            // 
            // Goster
            // 
            Goster.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Goster.Location = new Point(43, 394);
            Goster.Name = "Goster";
            Goster.RowHeadersWidth = 51;
            Goster.Size = new Size(910, 188);
            Goster.TabIndex = 19;
            // 
            // RandevularıGetir
            // 
            RandevularıGetir.BackColor = Color.Cyan;
            RandevularıGetir.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            RandevularıGetir.Location = new Point(43, 342);
            RandevularıGetir.Name = "RandevularıGetir";
            RandevularıGetir.Size = new Size(910, 46);
            RandevularıGetir.TabIndex = 21;
            RandevularıGetir.Text = "AKTİF RANDEVULARIM";
            RandevularıGetir.UseVisualStyleBackColor = false;
            RandevularıGetir.Click += RandevularıGetir_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Cyan;
            button1.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            button1.Location = new Point(43, 290);
            button1.Name = "button1";
            button1.Size = new Size(910, 46);
            button1.TabIndex = 22;
            button1.Text = "RANDEVUYU ONAYLA";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // tarih
            // 
            tarih.BackColor = Color.Cyan;
            tarih.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            tarih.FormattingEnabled = true;
            tarih.Items.AddRange(new object[] { "01-02-2024", "01-03-2024", "01-04-2024", "01-05-2024", "01-06-2024", "01-07-2024", "01-08-2024", "01-09-2024", "01-10-2024", "01-11-2024", "01-12-2024", "01-13-2024", "01-13-2024", "01-15-2024" });
            tarih.Location = new Point(703, 168);
            tarih.Name = "tarih";
            tarih.Size = new Size(250, 35);
            tarih.TabIndex = 24;
            // 
            // button2
            // 
            button2.BackColor = Color.Cyan;
            button2.BackgroundImage = Properties.Resources.home1;
            button2.BackgroundImageLayout = ImageLayout.Zoom;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(932, 4);
            button2.Name = "button2";
            button2.Size = new Size(60, 51);
            button2.TabIndex = 25;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // HastaRandevuAl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(1004, 594);
            Controls.Add(button2);
            Controls.Add(tarih);
            Controls.Add(button1);
            Controls.Add(RandevularıGetir);
            Controls.Add(Goster);
            Controls.Add(DoktorAd);
            Controls.Add(klinikAd);
            Controls.Add(hastaneAd);
            Controls.Add(saat);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(tc);
            Controls.Add(label333);
            Controls.Add(label1);
            Name = "HastaRandevuAl";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HastaRandevuAl";
            ((System.ComponentModel.ISupportInitialize)Goster).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        public Label label333;
        private TextBox tc;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private ComboBox saat;
        private ComboBox hastaneAd;
        private ComboBox klinikAd;
        private ComboBox DoktorAd;
        private DataGridView Goster;
        private Button RandevularıGetir;
        private Button button1;
        private ComboBox tarih;
        private Button button2;
    }
}