using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HASTANE_OTOMASYONU
{
    public partial class AdminRandevuEkrani : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adptr;

        public AdminRandevuEkrani()
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
            geriDon.label2.Text = label44.Text;
            geriDon.Show();
            this.Hide();
        }

        public void KayitlariGetir()
        {
            con = new SqlConnection("Data Source=.;Initial Catalog=HASTANE_OTOMASYONU;Integrated Security=True");
            con.Open();
            adptr = new SqlDataAdapter("Select * From Randevu", con);
            DataTable Dtable = new DataTable();
            adptr.Fill(Dtable);
            TabloyuYazdir.DataSource = Dtable;
            con.Close();
        }

        private void TabloyuGetir_Click(object sender, EventArgs e)
        {
            KayitlariGetir();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int seciliKayit = TabloyuYazdir.SelectedCells[0].RowIndex;
            con = new SqlConnection("Data Source=.;Initial Catalog=HASTANE_OTOMASYONU;Integrated Security=True");
            con.Open();
            cmd = new SqlCommand("Delete From Randevu Where RandevuID=@id", con);
            cmd.Parameters.AddWithValue("@id", TabloyuYazdir.Rows[seciliKayit].Cells[0].Value);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Silme İşlemi Tamamlandı.");
            con.Close();
            KayitlariGetir();
        }
    }
}
