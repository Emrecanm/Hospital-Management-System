namespace HASTANE_OTOMASYONU
{
    partial class HastaneyeGoreDoktorSayisi
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
            label55 = new Label();
            button1 = new Button();
            button2 = new Button();
            SayiyiGoster = new DataGridView();
            AnaMenu = new Button();
            GeriDon = new Button();
            ((System.ComponentModel.ISupportInitialize)SayiyiGoster).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.Cyan;
            label1.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(-4, -2);
            label1.Name = "label1";
            label1.Size = new Size(607, 74);
            label1.TabIndex = 0;
            label1.Text = "Hoş Geldiniz : ";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label55
            // 
            label55.AutoSize = true;
            label55.BackColor = Color.Cyan;
            label55.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label55.Location = new Point(138, 22);
            label55.Name = "label55";
            label55.Size = new Size(0, 27);
            label55.TabIndex = 1;
            label55.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // button1
            // 
            button1.BackColor = Color.Cyan;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            button1.Location = new Point(12, 95);
            button1.Name = "button1";
            button1.Size = new Size(576, 51);
            button1.TabIndex = 2;
            button1.Text = "Atatürk Üniversitesi Doktor Sayısı";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Cyan;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            button2.Location = new Point(12, 160);
            button2.Name = "button2";
            button2.Size = new Size(576, 51);
            button2.TabIndex = 3;
            button2.Text = "Oltu Devlet Hastanesi Doktor Sayısı";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // SayiyiGoster
            // 
            SayiyiGoster.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            SayiyiGoster.Location = new Point(12, 226);
            SayiyiGoster.Name = "SayiyiGoster";
            SayiyiGoster.RowHeadersWidth = 51;
            SayiyiGoster.Size = new Size(576, 163);
            SayiyiGoster.TabIndex = 4;
            // 
            // AnaMenu
            // 
            AnaMenu.BackColor = Color.Cyan;
            AnaMenu.BackgroundImage = Properties.Resources.home;
            AnaMenu.BackgroundImageLayout = ImageLayout.Zoom;
            AnaMenu.FlatStyle = FlatStyle.Flat;
            AnaMenu.ForeColor = Color.Black;
            AnaMenu.Location = new Point(533, 13);
            AnaMenu.Name = "AnaMenu";
            AnaMenu.Size = new Size(55, 49);
            AnaMenu.TabIndex = 5;
            AnaMenu.UseVisualStyleBackColor = false;
            AnaMenu.Click += AnaMenu_Click;
            // 
            // GeriDon
            // 
            GeriDon.BackColor = Color.Cyan;
            GeriDon.BackgroundImage = Properties.Resources.turn_back;
            GeriDon.BackgroundImageLayout = ImageLayout.Zoom;
            GeriDon.FlatStyle = FlatStyle.Flat;
            GeriDon.ForeColor = Color.Black;
            GeriDon.Location = new Point(472, 13);
            GeriDon.Name = "GeriDon";
            GeriDon.Size = new Size(55, 49);
            GeriDon.TabIndex = 6;
            GeriDon.UseVisualStyleBackColor = false;
            GeriDon.Click += button3_Click;
            // 
            // HastaneyeGoreDoktorSayisi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(600, 401);
            Controls.Add(GeriDon);
            Controls.Add(AnaMenu);
            Controls.Add(SayiyiGoster);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label55);
            Controls.Add(label1);
            Name = "HastaneyeGoreDoktorSayisi";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HastaneyeGoreDoktorSayisi";
            ((System.ComponentModel.ISupportInitialize)SayiyiGoster).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        public Label label55;
        private Button button1;
        private Button button2;
        private DataGridView SayiyiGoster;
        private Button AnaMenu;
        private Button GeriDon;
    }
}