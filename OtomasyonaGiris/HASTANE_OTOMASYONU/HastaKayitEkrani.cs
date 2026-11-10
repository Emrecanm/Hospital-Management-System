using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HASTANE_OTOMASYONU
{
    public partial class HastaKayitEkrani : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adptr;

        public HastaKayitEkrani()
        {
            InitializeComponent();
        }

        private void GeriDon_Click(object sender, EventArgs e)
        {
            HastaGirisi hGris = new HastaGirisi();
            hGris.Show();
            this.Hide();
        }

        private void KayitOl_Click(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=.;Initial Catalog=HASTANE_OTOMASYONU;Integrated Security=True");
            con.Open();

            string kayit = "Insert Into Hastalar (HastaAdi,HastaSoyadi,HastaTc,HastaDogumTarihi,HastaCinsiyeti,HastaAnneAdi,HastaBabaAdi,HastaTelefonu) Values (@ad,@soyad,@tc,@doktar,@cinsiyet,@annead,@babaad,@tel)";
            cmd = new SqlCommand(kayit, con);
            cmd.Parameters.AddWithValue("@ad", ad.Text.ToString());
            cmd.Parameters.AddWithValue("@soyad", soyad.Text.ToString());
            cmd.Parameters.AddWithValue("@tc", tc.Text.ToString());
            cmd.Parameters.AddWithValue("@doktar", doktar.Text.ToString());
            cmd.Parameters.AddWithValue("@cinsiyet", cinsiyet.Text.ToString());
            cmd.Parameters.AddWithValue("@annead", annead.Text.ToString());
            cmd.Parameters.AddWithValue("@babaad", babaad.Text.ToString());
            cmd.Parameters.AddWithValue("@tel", tel.Text.ToString());

            string kayit2 = "Insert Into HastaGirisi (HastaneID,HastaKullaniciAdi,HastaSifre) Values (@hid,@kad,@ksifre)";
            cmd = new SqlCommand(kayit2, con);
            cmd.Parameters.AddWithValue("@hid", HastaneID.Text.ToString());
            cmd.Parameters.AddWithValue("@kad", KullaniciAdi.Text.ToString());
            cmd.Parameters.AddWithValue("@ksifre", Sifre.Text.ToString());

            cmd.ExecuteNonQuery();
            MessageBox.Show("Kayıt İşleminiz Gerçekleşti. \n Giriş Yapa Basarak Giriş Yapabilirsiniz.");
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HastaGirisi hGirs = new HastaGirisi();
            hGirs.Show();
            this.Hide();
        }
    }
}
