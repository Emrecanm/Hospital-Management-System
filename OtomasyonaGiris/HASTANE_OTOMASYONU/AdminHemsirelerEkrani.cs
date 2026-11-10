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
    public partial class AdminHemsirelerEkrani : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adptr;

        public AdminHemsirelerEkrani()
        {
            InitializeComponent();
        }

        private void AnaMenu_Click(object sender, EventArgs e)
        {
            OtomasyonaGiris menuDon = new OtomasyonaGiris();
            menuDon.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminEkrani geriDon = new AdminEkrani();
            geriDon.label2.Text = label11.Text;
            geriDon.Show();
            this.Hide();
        }

        public void HemsireKayitlariGetir()
        {
            con = new SqlConnection("Data Source=.;Initial Catalog=HASTANE_OTOMASYONU;Integrated Security=True");
            con.Open();
            adptr = new SqlDataAdapter("select * from dbo.HemsireleriCagir()", con);
            DataTable Dtable = new DataTable();
            adptr.Fill(Dtable);
            TabloyuYazdir.DataSource = Dtable;
            con.Close();
        }

        private void HemsireleriListele_Click(object sender, EventArgs e)
        {
            HemsireKayitlariGetir();
        }

        private void HemsireAra_Click(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=.;Initial Catalog=HASTANE_OTOMASYONU;Integrated Security=True");
            con.Open();
            string hastaIsmi = "Select * From Hemsireler where HemsireAdi = @isim";
            cmd = new SqlCommand(hastaIsmi, con);
            cmd.Parameters.AddWithValue("@isim", HemsireAdiAra.Text);
            adptr = new SqlDataAdapter(cmd);
            DataTable Dtable = new DataTable();
            adptr.Fill(Dtable);
            TabloyuYazdir.DataSource = Dtable;
            con.Close();
        }

        private void HemsireSil_Click(object sender, EventArgs e)
        {
            int seciliKayit = TabloyuYazdir.SelectedCells[0].RowIndex;
            con = new SqlConnection("Data Source=.;Initial Catalog=HASTANE_OTOMASYONU;Integrated Security=True");
            con.Open();
            cmd = new SqlCommand("Delete From Hemsireler Where HemsireID=@id", con);
            cmd.Parameters.AddWithValue("@id", TabloyuYazdir.Rows[seciliKayit].Cells[0].Value);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Silme İşlemi Tamamlandı.");
            con.Close();
            HemsireKayitlariGetir();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            HemsireEkleVEyaGuncelle ekleVEyaGuncelle = new HemsireEkleVEyaGuncelle();
            ekleVEyaGuncelle.label21.Text = label11.Text;
            ekleVEyaGuncelle.Show();
            this.Hide();

        }
    }
}