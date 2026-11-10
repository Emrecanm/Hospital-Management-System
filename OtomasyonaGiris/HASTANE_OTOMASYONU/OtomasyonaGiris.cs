using System.Data.SqlClient;

namespace HASTANE_OTOMASYONU
{
    public partial class OtomasyonaGiris : Form
    {
        public OtomasyonaGiris()
        {
            InitializeComponent();
        }

        private void AdminGirisi_Click(object sender, EventArgs e)
        {
            AdminGirisi adminGirisi = new AdminGirisi();
            adminGirisi.Show();
            this.Hide();
        }

        private void DoktorGirisi_Click(object sender, EventArgs e)
        {
            DoktorGirisi doktorGirisi = new DoktorGirisi();
            doktorGirisi.Show();
            this.Hide();
        }

        private void HastaGirisi_Click(object sender, EventArgs e)
        {
            HastaGirisi hastaGirisi = new HastaGirisi();
            hastaGirisi.Show();
            this.Hide();
        }

        private void OtomasyonaGiris_FormClosing(object sender, FormClosingEventArgs e)
        {}
    }
}
