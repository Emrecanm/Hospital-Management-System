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
    public partial class PoliklinikEkleVeyaGuncelle : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adptr;

        public PoliklinikEkleVeyaGuncelle()
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
            AdminPoliklinikEkrani GeriDon = new AdminPoliklinikEkrani();
            GeriDon.label22.Text = label33.Text;
            GeriDon.Show();
            this.Hide();
        }

        public void TabloyuGetir()
        {
            con = new SqlConnection("Data Source=.;Initial Catalog=HASTANE_OTOMASYONU;Integrated Security=True");
            con.Open();
            adptr = new SqlDataAdapter("Select * From Poliklinik", con);
            DataTable Dtable = new DataTable();
            adptr.Fill(Dtable);
            TabloyuGoster.DataSource = Dtable;
            con.Close();
        }

        private void KayitlariGetir_Click(object sender, EventArgs e)
        {
            TabloyuGetir();
        }

        private void KlinikEkle_Click(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=.;Initial Catalog=HASTANE_OTOMASYONU;Integrated Security=True");
            con.Open();

            string kayit = "Insert Into Poliklinik (HastaneID,KlinikAdi,KlinikAdedi) Values (@hID,@adi,@adet)";
            cmd = new SqlCommand(kayit, con);
            cmd.Parameters.AddWithValue("@hID", HastID.Text.ToString());
            cmd.Parameters.AddWithValue("@adi", KlinikAdi.Text.ToString());
            cmd.Parameters.AddWithValue("@adet", KlinikAdedi.Text).ToString();

            cmd.ExecuteNonQuery();
            MessageBox.Show("Kayıt Ekleme İşleminiz Gerçekleşmiştir.");
            con.Close();
            TabloyuGetir();
        }

        int i = 0;
        private void KlinikGuncelle_Click(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=.;Initial Catalog=HASTANE_OTOMASYONU;Integrated Security=True");
            con.Open();

            string kayitGuncelle = ("Update Poliklinik set HastaneID=@hID, KlinikAdi=@ad, KlinikAdedi=@adet  where KlinikID=@id");
            cmd = new SqlCommand(kayitGuncelle, con);

            cmd.Parameters.AddWithValue("@hID", HastID.Text.ToString());
            cmd.Parameters.AddWithValue("@ad", KlinikAdi.Text.ToString());
            cmd.Parameters.AddWithValue("@adet", KlinikAdedi.Text.ToString());
            cmd.Parameters.AddWithValue("@id", TabloyuGoster.Rows[i].Cells[0].Value);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Kayıt Başarıya Güncellendi.");
            con.Close();
            TabloyuGetir();
        }

        private void TabloyuGoster_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            i = e.RowIndex;
            HastID.Text = TabloyuGoster.Rows[i].Cells[1].Value.ToString();
            KlinikAdi.Text = TabloyuGoster.Rows[i].Cells[2].Value.ToString();
            KlinikAdedi.Text = TabloyuGoster.Rows[i].Cells[3].Value.ToString();
        }

        private void YazilariTemizle_Click(object sender, EventArgs e)
        {
            HastID.Text = " ";
            KlinikAdi.Text = " ";
            KlinikAdedi.Text = " ";
        }
    }
}
