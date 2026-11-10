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
    public partial class EkleVeyaGuncelle : Form
    {

        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adptr;

        public EkleVeyaGuncelle()
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
            AdminDoktorlarEkrani GeriDon = new AdminDoktorlarEkrani();
            GeriDon.label3.Text = label2.Text;
            GeriDon.Show();
            this.Hide();
        }

        public void TabloyuGetir()
        {
            con = new SqlConnection("Data Source=.;Initial Catalog=HASTANE_OTOMASYONU;Integrated Security=True");
            con.Open();
            adptr = new SqlDataAdapter("Select * From Doktorlar", con);
            DataTable Dtable = new DataTable();
            adptr.Fill(Dtable);
            TaboyuGoster.DataSource = Dtable;
            con.Close();
        }

        private void DoktorlarıGoster_Click(object sender, EventArgs e)
        {
            TabloyuGetir();
        }

        int i = 0;

        private void DoktorGuncelle_Click(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=.;Initial Catalog=HASTANE_OTOMASYONU;Integrated Security=True");
            con.Open();

            string kayitGuncelle = ("Update Doktorlar set HastaneID=@hID, KlinikID=@kID, Brans=@brns, DoktorAdi=@Dadi, DoktorSoyadi=@dSoyad, DoktorTC=@tc, DoktorTelefon=@dTel, DoktorDogumTarihi=@dogTar, DoktorCinsiyet=@dCins where DoktorID=@id");
            cmd = new SqlCommand(kayitGuncelle, con);

            cmd.Parameters.AddWithValue("@hID", hasID.Text.ToString());
            cmd.Parameters.AddWithValue("@kID", KlnID.Text.ToString());
            cmd.Parameters.AddWithValue("@brns", Brans.Text.ToString());
            cmd.Parameters.AddWithValue("@Dadi", adi.Text.ToString());
            cmd.Parameters.AddWithValue("@dSoyad", soyadi.Text.ToString());
            cmd.Parameters.AddWithValue("@tc", tc.Text.ToString());
            cmd.Parameters.AddWithValue("@dTel", tel.Text.ToString());
            cmd.Parameters.AddWithValue("@dogTar", doktar.Text.ToString());
            cmd.Parameters.AddWithValue("@dCins", cinsiyet.Text.ToString());
            cmd.Parameters.AddWithValue("@id", TaboyuGoster.Rows[i].Cells[0].Value);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Kayıt Başarıya Güncellendi.");
            con.Close();
            TabloyuGetir();

        }

        private void TaboyuGoster_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            i = e.RowIndex;
            hasID.Text = TaboyuGoster.Rows[i].Cells[1].Value.ToString();
            KlnID.Text = TaboyuGoster.Rows[i].Cells[2].Value.ToString();
            Brans.Text = TaboyuGoster.Rows[i].Cells[3].Value.ToString();
            adi.Text = TaboyuGoster.Rows[i].Cells[4].Value.ToString();
            soyadi.Text = TaboyuGoster.Rows[i].Cells[5].Value.ToString();
            tc.Text = TaboyuGoster.Rows[i].Cells[6].Value.ToString();
            tel.Text = TaboyuGoster.Rows[i].Cells[7].Value.ToString();
            doktar.Text = TaboyuGoster.Rows[i].Cells[8].Value.ToString();
            cinsiyet.Text = TaboyuGoster.Rows[i].Cells[9].Value.ToString();
        }

        private void DoktorEkle_Click(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=.;Initial Catalog=HASTANE_OTOMASYONU;Integrated Security=True");
            con.Open();

            string kayit = "Insert Into Doktorlar (HastaneID,KlinikID,Brans,DoktorAdi,DoktorSoyadi,DoktorTC,DoktorTelefon,DoktorDogumTarihi,DoktorCinsiyet) Values (@hID,@kID,@brans,@adi,@Soyadi,@tc,@tel,@doktar,@cinsiyet)";
            cmd = new SqlCommand(kayit, con);
            cmd.Parameters.AddWithValue("@hID", hasID.Text.ToString());
            cmd.Parameters.AddWithValue("@kID", KlnID.Text.ToString());
            cmd.Parameters.AddWithValue("@brans", Brans.Text).ToString();
            cmd.Parameters.AddWithValue("@adi", adi.Text.ToString());
            cmd.Parameters.AddWithValue("@soyadi", soyadi.Text.ToString());
            cmd.Parameters.AddWithValue("@tc", tc.Text.ToString());
            cmd.Parameters.AddWithValue("@tel", tel.Text.ToString());
            cmd.Parameters.AddWithValue("@doktar", doktar.Text.ToString());
            cmd.Parameters.AddWithValue("@cinsiyet", cinsiyet.Text.ToString());

            cmd.ExecuteNonQuery();
            MessageBox.Show("Kayıt Ekleme İşleminiz Gerçekleşmiştir.");
            con.Close();
            TabloyuGetir();
        }

        public void TexleriTemizle()
        {
            hasID.Text = " ";
            KlnID.Text = " ";
            Brans.Text = " ";
            adi.Text = " ";
            soyadi.Text = " ";
            tc.Text = " ";
            tel.Text = " ";
            doktar.Text = " ";
            cinsiyet.Text = " ";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TexleriTemizle();
        }

        private void EkleVeyaGuncelle_Load(object sender, EventArgs e)
        {

        }
    }
}
