using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HASTANE_OTOMASYONU
{
    public partial class AdminDoktorlarEkrani : Form
    {

        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adptr;

        public AdminDoktorlarEkrani()
        {
            InitializeComponent();
        }

        private void GeriDon_Click(object sender, EventArgs e)
        {
            AdminEkrani geriDon = new AdminEkrani();
            geriDon.label2.Text = label3.Text;
            geriDon.Show();
            this.Hide();
        }

        private void MenuDon_Click(object sender, EventArgs e)
        {
            OtomasyonaGiris menuDon = new OtomasyonaGiris();
            menuDon.Show();
            this.Hide();
        }

        public void KayitlariGetir()
        {
            con = new SqlConnection("Data Source=.;Initial Catalog=HASTANE_OTOMASYONU;Integrated Security=True");
            con.Open();
            adptr = new SqlDataAdapter("select * from dbo.DoktorlariCagir()", con);
            DataTable Dtable = new DataTable();
            adptr.Fill(Dtable);
            TabloyuYazdir.DataSource = Dtable;
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            KayitlariGetir();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=.;Initial Catalog=HASTANE_OTOMASYONU;Integrated Security=True");
            con.Open();
            string dktrIsmi = "Select * From Doktorlar where DoktorAdi = @isim";
            cmd = new SqlCommand(dktrIsmi, con);
            cmd.Parameters.AddWithValue("@isim", AranacakDktrAdi.Text);
            adptr = new SqlDataAdapter(cmd);
            DataTable Dtable = new DataTable();
            adptr.Fill(Dtable);
            TabloyuYazdir.DataSource = Dtable;
            con.Close();
        }


        private void SilinecekDoktorAdi_Click(object sender, EventArgs e)
        {
            int seciliKayit = TabloyuYazdir.SelectedCells[0].RowIndex;
            con = new SqlConnection("Data Source=.;Initial Catalog=HASTANE_OTOMASYONU;Integrated Security=True");
            con.Open();
            cmd = new SqlCommand("Delete From Doktorlar Where DoktorID=@id", con);
            cmd.Parameters.AddWithValue("@id", TabloyuYazdir.Rows[seciliKayit].Cells[0].Value);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Silme İşlemi Tamamlandı.");
            con.Close();
            KayitlariGetir();
        }

        private void EkleVeyaGuncelle_Click(object sender, EventArgs e)
        {
            EkleVeyaGuncelle doktorG_E = new EkleVeyaGuncelle();
            doktorG_E.label2.Text = label3.Text;
            doktorG_E.Show();
            this.Hide();
        }
    }
}
