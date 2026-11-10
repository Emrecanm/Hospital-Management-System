using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HASTANE_OTOMASYONU
{
    public partial class AdminHastalarEkrani : Form
    {

        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adptr;

        public AdminHastalarEkrani()
        {
            InitializeComponent();
        }

        private void AnaMenu_Click(object sender, EventArgs e)
        {
            OtomasyonaGiris menuDon = new OtomasyonaGiris();
            menuDon.Show();
            this.Hide();
        }

        private void GeriDon_Click(object sender, EventArgs e)
        {
            AdminEkrani geriDon = new AdminEkrani();
            geriDon.label2.Text = label12.Text;
            geriDon.Show();
            this.Hide();
        }

        public void HastaKayitlariGetir()
        {
            con = new SqlConnection("Data Source=.;Initial Catalog=HASTANE_OTOMASYONU;Integrated Security=True");
            con.Open();
            adptr = new SqlDataAdapter("Select * From Hastalar", con);
            DataTable Dtable = new DataTable();
            adptr.Fill(Dtable);
            TabloyuYazdir.DataSource = Dtable;
            con.Close();
        }

        private void HastalariListele_Click(object sender, EventArgs e)
        {
            HastaKayitlariGetir();
        }

        private void HastaAra_Click(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=.;Initial Catalog=HASTANE_OTOMASYONU;Integrated Security=True");
            con.Open();
            string hastaIsmi = "Select * From Hastalar where HastaAdi = @isim";
            cmd = new SqlCommand(hastaIsmi, con);
            cmd.Parameters.AddWithValue("@isim", HastaAdiAra.Text);
            adptr = new SqlDataAdapter(cmd);
            DataTable Dtable = new DataTable();
            adptr.Fill(Dtable);
            TabloyuYazdir.DataSource = Dtable;
            con.Close();
        }

        private void HastaSil_Click(object sender, EventArgs e)
        {
            int seciliKayit = TabloyuYazdir.SelectedCells[0].RowIndex;
            con = new SqlConnection("Data Source=.;Initial Catalog=HASTANE_OTOMASYONU;Integrated Security=True");
            con.Open();
            cmd = new SqlCommand("Delete From Hastalar Where HastaID=@id", con);
            cmd.Parameters.AddWithValue("@id", TabloyuYazdir.Rows[seciliKayit].Cells[0].Value);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Silme İşlemi Tamamlandı.");
            con.Close();
            HastaKayitlariGetir();

        }

        private void HastaEkleVeyaGüncelle_Click(object sender, EventArgs e)
        {
            HastaEkleVeyaGuncelle HastaG_E = new HastaEkleVeyaGuncelle();
            HastaG_E.label2.Text = label12.Text;
            HastaG_E.Show();
            this.Hide();
        }

        private void TabloyuYazdir_MouseClick(object sender, MouseEventArgs e)
        {

        }
    }
}
