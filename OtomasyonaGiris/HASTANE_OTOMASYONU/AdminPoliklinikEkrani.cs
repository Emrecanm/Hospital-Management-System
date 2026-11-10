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
    public partial class AdminPoliklinikEkrani : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adptr;

        public AdminPoliklinikEkrani()
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
            geriDon.label2.Text = label22.Text;
            geriDon.Show();
            this.Hide();
        }

        public void KayitlariGetir()
        {
            con = new SqlConnection("Data Source=.;Initial Catalog=HASTANE_OTOMASYONU;Integrated Security=True");
            con.Open();
            adptr = new SqlDataAdapter("Select * From POliklinik", con);
            DataTable Dtable = new DataTable();
            adptr.Fill(Dtable);
            TabloyuYazdir.DataSource = Dtable;
            con.Close();
        }

        private void PoliklinikListele_Click(object sender, EventArgs e)
        {
            KayitlariGetir();
        }

        private void PoliklinikAra_Click(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=.;Initial Catalog=HASTANE_OTOMASYONU;Integrated Security=True");
            con.Open();
            string dktrIsmi = "Select * From Poliklinik where KlinikAdi = @isim";
            cmd = new SqlCommand(dktrIsmi, con);
            cmd.Parameters.AddWithValue("@isim", PoliklinikAdi.Text);
            adptr = new SqlDataAdapter(cmd);
            DataTable Dtable = new DataTable();
            adptr.Fill(Dtable);
            TabloyuYazdir.DataSource = Dtable;
            con.Close();
        }

        private void PoliklinikSil_Click(object sender, EventArgs e)
        {
            int seciliKayit = TabloyuYazdir.SelectedCells[0].RowIndex;
            con = new SqlConnection("Data Source=.;Initial Catalog=HASTANE_OTOMASYONU;Integrated Security=True");
            con.Open();
            cmd = new SqlCommand("Delete From Poliklinik Where KlinikID=@id", con);
            cmd.Parameters.AddWithValue("@id", TabloyuYazdir.Rows[seciliKayit].Cells[0].Value);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Silme İşlemi Tamamlandı.");
            con.Close();
            KayitlariGetir();
        }

        private void PolEkleVeyaGuncelle_Click(object sender, EventArgs e)
        {
            PoliklinikEkleVeyaGuncelle EveyaGuncelle=new PoliklinikEkleVeyaGuncelle();
            EveyaGuncelle.label33.Text = label22.Text;
            EveyaGuncelle.Show();
            this.Hide();
        }
    }
}
