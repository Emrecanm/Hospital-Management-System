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
    public partial class AdminEkrani : Form
    {
        public AdminEkrani()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OtomasyonaGiris BasaDon = new OtomasyonaGiris();
            BasaDon.Show();
            this.Hide();
        }

        private void Doktorlar_Click(object sender, EventArgs e)
        {
            AdminDoktorlarEkrani doktorgecis = new AdminDoktorlarEkrani();
            doktorgecis.label3.Text = label2.Text;
            doktorgecis.Show();
            this.Hide();
        }

        private void Hastalar_Click(object sender, EventArgs e)
        {
            AdminHastalarEkrani hastalarEkrani = new AdminHastalarEkrani();
            hastalarEkrani.label12.Text = label2.Text;
            hastalarEkrani.Show();
            this.Hide();
        }

        private void Hemsireler_Click(object sender, EventArgs e)
        {
            AdminHemsirelerEkrani hemsireEkrani = new AdminHemsirelerEkrani();
            hemsireEkrani.label11.Text = label2.Text;
            hemsireEkrani.Show();
            this.Hide();
        }

        private void Poliklinikler_Click(object sender, EventArgs e)
        {
            AdminPoliklinikEkrani pol = new AdminPoliklinikEkrani();
            pol.label22.Text = label2.Text;
            pol.Show();
            this.Hide();
        }

        private void Randevular_Click(object sender, EventArgs e)
        {
            AdminRandevuEkrani ranE = new AdminRandevuEkrani();
            ranE.label44.Text = label2.Text;
            ranE.Show();
            this.Hide();
        }

        private void HstnGrPlknkSylr_Click(object sender, EventArgs e)
        {
            HastaneyeGoreDoktorSayisi dokSay = new HastaneyeGoreDoktorSayisi();
            dokSay.label55.Text = label2.Text;
            dokSay.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            HastaneyeGorePoliklinikSayilari polSay = new HastaneyeGorePoliklinikSayilari();
            polSay.label66.Text = label2.Text;
            polSay.Show();
            this.Hide();
        }

        private void TedabiEdlmsHastalar_Click(object sender, EventArgs e)
        {
            TedaviEdilmisHastalar tvdedlms = new TedaviEdilmisHastalar();
            tvdedlms.label111.Text = label2.Text;
            tvdedlms.Show();
            this.Hide();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SilinenRandevular silran = new SilinenRandevular();
            silran.label444.Text = label2.Text;
            silran.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Silinen_EklenenHastalar sil_ek = new Silinen_EklenenHastalar();
            sil_ek.label777.Text = label2.Text;
            sil_ek.Show();
            this.Hide();
        }
    }
}
