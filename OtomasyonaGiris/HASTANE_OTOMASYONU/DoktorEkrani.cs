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
    public partial class DoktorEkrani : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adptr;

        public DoktorEkrani()
        {
            InitializeComponent();
        }

        private void AnaMenu_Click(object sender, EventArgs e)
        {
            OtomasyonaGiris menuDon = new OtomasyonaGiris();
            menuDon.Show();
            this.Hide();
        }

        public void KayitlariGetir()
        {
            con = new SqlConnection("Data Source=.;Initial Catalog=HASTANE_OTOMASYONU;Integrated Security=True");
            con.Open();
            if (label23.Text == "mtygnoglu")
            {
                adptr = new SqlDataAdapter("select * from dbo.DoktorlaraGoreHastalar(1)", con);
                DataTable Dtable = new DataTable();
                adptr.Fill(Dtable);
                TabloyuGoster.DataSource = Dtable;
                con.Close(); ;
            }
            if (label23.Text == "emrecandznli")
            {
                adptr = new SqlDataAdapter("select * from dbo.DoktorlaraGoreHastalar(6)", con);
                DataTable Dtable = new DataTable();
                adptr.Fill(Dtable);
                TabloyuGoster.DataSource = Dtable;
                con.Close();
            }
        }

        private void HastalariListele_Click(object sender, EventArgs e)
        {
            KayitlariGetir();
        }

        private void HastaAra_Click(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=.;Initial Catalog=HASTANE_OTOMASYONU;Integrated Security=True");
            con.Open();
            string hastaIsmi = "Select * From Hastalar where HastaAdi = @isim";
            cmd = new SqlCommand(hastaIsmi, con);
            cmd.Parameters.AddWithValue("@isim", HastaAdi.Text);
            adptr = new SqlDataAdapter(cmd);
            DataTable Dtable = new DataTable();
            adptr.Fill(Dtable);
            TabloyuGoster.DataSource = Dtable;
            con.Close();
        }

        private void HastaSil_Click(object sender, EventArgs e)
        {
            int seciliKayit = TabloyuGoster.SelectedCells[0].RowIndex;
            con = new SqlConnection("Data Source=.;Initial Catalog=HASTANE_OTOMASYONU;Integrated Security=True");
            con.Open();
            cmd = new SqlCommand("Delete From Hastalar Where HastaID=@id", con);
            cmd.Parameters.AddWithValue("@id", TabloyuGoster.Rows[seciliKayit].Cells[0].Value);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Silme İşlemi Tamamlandı.");
            KayitlariGetir();
            con.Close();
        }
        int i = 0;
        private void HastaSayisi_Click(object sender, EventArgs e)
        {
            int seciliKayit = TabloyuGoster.SelectedCells[0].RowIndex;
            con = new SqlConnection("Data Source=.;Initial Catalog=HASTANE_OTOMASYONU;Integrated Security=True");
            con.Open();

            string kayitGuncelle = ("Update Hastalar set Tedavi=@tdvi where HastaID=@id");
            cmd = new SqlCommand(kayitGuncelle, con);

            cmd.Parameters.AddWithValue("@tdvi", TedaviEkle.Text.ToString());
            cmd.Parameters.AddWithValue("@id", TabloyuGoster.Rows[seciliKayit].Cells[0].Value);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Tedavi Eklendi.");
            con.Close();
            KayitlariGetir();
        }

        private void TabloyuGoster_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {}
    }
}
