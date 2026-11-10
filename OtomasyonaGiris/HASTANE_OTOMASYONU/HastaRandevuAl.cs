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
    public partial class HastaRandevuAl : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adptr;

        public HastaRandevuAl()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        { }

        private void button1_Click(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=.;Initial Catalog=HASTANE_OTOMASYONU;Integrated Security=True");
            con.Open();

            string kayit = "Insert Into Randevu (HastaTC, HastaneAdi, KlinikAdi, DoktorAdi, RandevuTarihi, RandevuSaati) Values (@tc, @had, @kad, @dad, @rtar, @rsaat)";
            cmd = new SqlCommand(kayit, con);
            cmd.Parameters.AddWithValue("@tc", tc.Text.ToString());
            cmd.Parameters.AddWithValue("@had", hastaneAd.Text);
            cmd.Parameters.AddWithValue("@kad", klinikAd.Text);
            cmd.Parameters.AddWithValue("@dad", DoktorAd.Text);
            cmd.Parameters.AddWithValue("@rtar", tarih.Text.ToString());
            cmd.Parameters.AddWithValue("@rsaat", saat.Text.ToString());

            cmd.ExecuteNonQuery();
            MessageBox.Show("Randevu Alma İşleminiz Gerçekleşmiştir.");
            con.Close();
        }

        private void RandevularıGetir_Click(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=.;Initial Catalog=HASTANE_OTOMASYONU;Integrated Security=True");
            con.Open();
            adptr = new SqlDataAdapter("Select * From Randevu where HastaTC='52546542354'", con);
            DataTable Dtable = new DataTable();
            adptr.Fill(Dtable);
            Goster.DataSource = Dtable;
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OtomasyonaGiris basaDon = new OtomasyonaGiris();
            basaDon.Show();
            this.Hide();
        }
    }
}
