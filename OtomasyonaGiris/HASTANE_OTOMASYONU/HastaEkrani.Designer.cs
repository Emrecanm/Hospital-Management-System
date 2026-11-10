namespace HASTANE_OTOMASYONU
{
    partial class HastaEkrani
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
            label222 = new Label();
            button1 = new Button();
            AnaMenu = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.Cyan;
            label1.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(-2, -1);
            label1.Name = "label1";
            label1.Size = new Size(677, 65);
            label1.TabIndex = 0;
            label1.Text = "Hoş Geldin : ";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label222
            // 
            label222.AutoSize = true;
            label222.BackColor = Color.Cyan;
            label222.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label222.Location = new Point(121, 18);
            label222.Name = "label222";
            label222.Size = new Size(0, 27);
            label222.TabIndex = 1;
            label222.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // button1
            // 
            button1.BackColor = Color.Cyan;
            button1.Font = new Font("Palatino Linotype", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button1.Location = new Point(25, 102);
            button1.Name = "button1";
            button1.Size = new Size(619, 66);
            button1.TabIndex = 2;
            button1.Text = "ONLİNE RANDEVU AL";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // AnaMenu
            // 
            AnaMenu.BackColor = Color.Cyan;
            AnaMenu.BackgroundImage = Properties.Resources.home1;
            AnaMenu.BackgroundImageLayout = ImageLayout.Zoom;
            AnaMenu.FlatStyle = FlatStyle.Flat;
            AnaMenu.Location = new Point(607, 7);
            AnaMenu.Name = "AnaMenu";
            AnaMenu.Size = new Size(53, 48);
            AnaMenu.TabIndex = 3;
            AnaMenu.UseVisualStyleBackColor = false;
            AnaMenu.Click += AnaMenu_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Cyan;
            button2.Font = new Font("Palatino Linotype", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button2.Location = new Point(25, 199);
            button2.Name = "button2";
            button2.Size = new Size(619, 66);
            button2.TabIndex = 4;
            button2.Text = "TELEFON İLE RANDEVU AL";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // HastaEkrani
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(672, 306);
            Controls.Add(button2);
            Controls.Add(AnaMenu);
            Controls.Add(button1);
            Controls.Add(label222);
            Controls.Add(label1);
            Name = "HastaEkrani";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HastaEkrani";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        public Label label222;
        private Button button1;
        private Button AnaMenu;
        private Button button2;
    }
}