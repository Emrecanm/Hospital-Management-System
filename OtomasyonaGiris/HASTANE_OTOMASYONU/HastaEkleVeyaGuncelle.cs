using System;
using System.Collections.Generic;
using System.Collections.Immutable;
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
    public partial class HastaEkleVeyaGuncelle : Form
    {

        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adptr;

        public HastaEkleVeyaGuncelle()
        {
            InitializeComponent();
        }

        private void AnaMenu_Click(object sender, EventArgs e)
        {
            OtomasyonaGiris anaMenu = new OtomasyonaGiris();
            anaMenu.Show();
            this.Hide();
        }

        private void GeriDOn_Click(object sender, EventArgs e)
        {
            AdminHastalarEkrani geriDon = new AdminHastalarEkrani();
            geriDon.label12.Text = label2.Text;
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

        private void HastalariGöster_Click(object sender, EventArgs e)
        {
            HastaKayitlariGetir();
        }

        private void HastaEkle_Click(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=.;Initial Catalog=HASTANE_OTOMASYONU;Integrated Security=True");
            con.Open();

            string kayit = "Insert Into Hastalar (HastaAdi,HastaSoyadi,HastaTc,HastaDogumTarihi,HastaCinsiyeti,HastaAnneAdi,HastaBabaAdi,HastaTelefonu,HastaneID,KlinikID,DokorID) Values (@ad,@soyad,@tc,@doktar,@cinsiyet,@annead,@babaad,@tel,@hid,@kid,@did)";
            cmd = new SqlCommand(kayit, con);
            cmd.Parameters.AddWithValue("@ad", Hadi.Text.ToString());
            cmd.Parameters.AddWithValue("@soyad", Hsoyadi.Text.ToString());
            cmd.Parameters.AddWithValue("@tc", Htc.Text.ToString());
            cmd.Parameters.AddWithValue("@doktar", doktar.Text.ToString());
            cmd.Parameters.AddWithValue("@cinsiyet", Cinsiyet.Text.ToString());
            cmd.Parameters.AddWithValue("@annead", AnneAdi.Text.ToString());
            cmd.Parameters.AddWithValue("@babaad", BabaAdi.Text.ToString());
            cmd.Parameters.AddWithValue("@tel", Tel.Text.ToString());
            cmd.Parameters.AddWithValue("@hid", HastaneID.Text.ToString());
            cmd.Parameters.AddWithValue("@kid", KlinikID.Text.ToString());
            cmd.Parameters.AddWithValue("@did", Doktorid.Text.ToString());

            cmd.ExecuteNonQuery();
            MessageBox.Show("Kayıt Ekleme İşleminiz Gerçekleşmiştir.");
            con.Close();
            HastaKayitlariGetir();
        }

        int i = 0;
        private void TabloyuYazdir_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            i = e.RowIndex;
            Hadi.Text = TabloyuYazdir.Rows[i].Cells[1].Value.ToString();
            Hsoyadi.Text = TabloyuYazdir.Rows[i].Cells[2].Value.ToString();
            Htc.Text = TabloyuYazdir.Rows[i].Cells[3].Value.ToString();
            doktar.Text = TabloyuYazdir.Rows[i].Cells[4].Value.ToString();
            Cinsiyet.Text = TabloyuYazdir.Rows[i].Cells[5].Value.ToString();
            AnneAdi.Text = TabloyuYazdir.Rows[i].Cells[6].Value.ToString();
            BabaAdi.Text = TabloyuYazdir.Rows[i].Cells[7].Value.ToString();
            Tel.Text = TabloyuYazdir.Rows[i].Cells[8].Value.ToString();
            HastaneID.Text = TabloyuYazdir.Rows[i].Cells[9].Value.ToString();
            KlinikID.Text = TabloyuYazdir.Rows[i].Cells[10].Value.ToString();
            Doktorid.Text = TabloyuYazdir.Rows[i].Cells[11].Value.ToString();
        }

        private void HastaGuncelle_Click(object sender, EventArgs e)
        {

            con = new SqlConnection("Data Source=.;Initial Catalog=HASTANE_OTOMASYONU;Integrated Security=True");
            con.Open();

            string kayitGuncelle = ("Update Hastalar set HastaAdi=@adi, HastaSoyadi=@soyad, HastaTC=@tc, HastaDogumTarihi=@doktar, HastaCinsiyeti=@cinsiyet, HastaAnneAdi=@annead, HastaBabaAdi=@babaad, HastaTelefonu=@tel where HastaID=@id");
            cmd = new SqlCommand(kayitGuncelle, con);

            cmd.Parameters.AddWithValue("@adi", Hadi.Text.ToString());
            cmd.Parameters.AddWithValue("@soyad", Hsoyadi.Text.ToString());
            cmd.Parameters.AddWithValue("@tc", Htc.Text.ToString());
            cmd.Parameters.AddWithValue("@doktar", doktar.Text.ToString());
            cmd.Parameters.AddWithValue("@cinsiyet", Cinsiyet.Text.ToString());
            cmd.Parameters.AddWithValue("@annead", AnneAdi.Text.ToString());
            cmd.Parameters.AddWithValue("@babaad", BabaAdi.Text.ToString());
            cmd.Parameters.AddWithValue("@tel", Tel.Text.ToString());
            cmd.Parameters.AddWithValue("@id", TabloyuYazdir.Rows[i].Cells[0].Value);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Kayıt Başarıya Güncellendi.");
            con.Close();
            HastaKayitlariGetir();
        }

        private void YazilariTemizle_Click(object sender, EventArgs e)
        {
            Hadi.Text = " ";
            Hsoyadi.Text = " ";
            Htc.Text = " ";
            doktar.Text = " ";
            Cinsiyet.Text = " ";
            AnneAdi.Text = " ";
            BabaAdi.Text = " ";
            Tel.Text = " ";
        }
    }
}
