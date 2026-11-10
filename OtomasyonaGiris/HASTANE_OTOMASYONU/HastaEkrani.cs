using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HASTANE_OTOMASYONU
{
    public partial class HastaEkrani : Form
    {
        public HastaEkrani()
        {
            InitializeComponent();
        }

        private void AnaMenu_Click(object sender, EventArgs e)
        {
            OtomasyonaGiris giris = new OtomasyonaGiris();
            giris.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("182 Yi Arayarak Randevu İşlemlerinizi Yapabilirsiniz.");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HastaRandevuAl randevu =new HastaRandevuAl();
            randevu.label333.Text = label222.Text;
            randevu.Show();
            this.Hide();
        }
    }
}
