namespace HASTANE_OTOMASYONU
{
    partial class HastaGirisi
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
            GeriDon = new Button();
            HastaTC = new TextBox();
            label2 = new Label();
            label3 = new Label();
            HastaSifre = new TextBox();
            KayitOl = new Button();
            button2 = new Button();
            checkBox1 = new CheckBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.Cyan;
            label1.Font = new Font("Palatino Linotype", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(-1, -3);
            label1.Name = "label1";
            label1.Size = new Size(586, 113);
            label1.TabIndex = 0;
            label1.Text = "HASTA GİRİŞ EKRANI";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // GeriDon
            // 
            GeriDon.BackColor = Color.Cyan;
            GeriDon.BackgroundImage = Properties.Resources.turn_back;
            GeriDon.BackgroundImageLayout = ImageLayout.Zoom;
            GeriDon.FlatStyle = FlatStyle.Flat;
            GeriDon.Location = new Point(12, 12);
            GeriDon.Name = "GeriDon";
            GeriDon.Size = new Size(68, 48);
            GeriDon.TabIndex = 1;
            GeriDon.UseVisualStyleBackColor = false;
            GeriDon.Click += GeriDon_Click;
            // 
            // HastaTC
            // 
            HastaTC.BackColor = Color.Cyan;
            HastaTC.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            HastaTC.Location = new Point(159, 138);
            HastaTC.Name = "HastaTC";
            HastaTC.Size = new Size(207, 34);
            HastaTC.TabIndex = 2;
            HastaTC.TextChanged += HastaTC_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Palatino Linotype", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(-1, 141);
            label2.Name = "label2";
            label2.Size = new Size(154, 31);
            label2.TabIndex = 3;
            label2.Text = "Kullanici Adı";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Palatino Linotype", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.Location = new Point(86, 243);
            label3.Name = "label3";
            label3.Size = new Size(65, 31);
            label3.TabIndex = 5;
            label3.Text = "Şifre";
            // 
            // HastaSifre
            // 
            HastaSifre.BackColor = Color.Cyan;
            HastaSifre.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            HastaSifre.Location = new Point(159, 243);
            HastaSifre.Name = "HastaSifre";
            HastaSifre.Size = new Size(207, 34);
            HastaSifre.TabIndex = 4;
            HastaSifre.UseSystemPasswordChar = true;
            // 
            // KayitOl
            // 
            KayitOl.BackColor = Color.Cyan;
            KayitOl.BackgroundImageLayout = ImageLayout.Zoom;
            KayitOl.FlatStyle = FlatStyle.Flat;
            KayitOl.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            KayitOl.Location = new Point(12, 305);
            KayitOl.Name = "KayitOl";
            KayitOl.Size = new Size(535, 48);
            KayitOl.TabIndex = 6;
            KayitOl.Text = "Kayıt Ol";
            KayitOl.UseVisualStyleBackColor = false;
            KayitOl.Click += KayitOl_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Cyan;
            button2.BackgroundImageLayout = ImageLayout.Zoom;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button2.Location = new Point(424, 184);
            button2.Name = "button2";
            button2.Size = new Size(146, 47);
            button2.TabIndex = 7;
            button2.Text = "Giriş Yap";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Palatino Linotype", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            checkBox1.Location = new Point(372, 246);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(89, 28);
            checkBox1.TabIndex = 8;
            checkBox1.Text = "Göster";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // HastaGirisi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(582, 365);
            Controls.Add(checkBox1);
            Controls.Add(button2);
            Controls.Add(KayitOl);
            Controls.Add(label3);
            Controls.Add(HastaSifre);
            Controls.Add(label2);
            Controls.Add(HastaTC);
            Controls.Add(GeriDon);
            Controls.Add(label1);
            Name = "HastaGirisi";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HastaGirisi";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button GeriDon;
        private TextBox HastaTC;
        private Label label2;
        private Label label3;
        private TextBox HastaSifre;
        private Button KayitOl;
        private Button button2;
        private CheckBox checkBox1;
    }
}