using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HASTANE_OTOMASYONU
{
    public partial class HemsireEkleVEyaGuncelle : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adptr;

        public HemsireEkleVEyaGuncelle()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OtomasyonaGiris anaMenu = new OtomasyonaGiris();
            anaMenu.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdminHemsirelerEkrani geriDon = new AdminHemsirelerEkrani();
            geriDon.label11.Text = label21.Text;
            geriDon.Show();
            this.Hide();
        }

        public void HemsireaKayitlariGetir()
        {
            con = new SqlConnection("Data Source=.;Initial Catalog=HASTANE_OTOMASYONU;Integrated Security=True");
            con.Open();
            adptr = new SqlDataAdapter("Select * From Hemsireler", con);
            DataTable Dtable = new DataTable();
            adptr.Fill(Dtable);
            TabloyuGoster.DataSource = Dtable;
            con.Close();
        }

        private void HemsireleriGoster_Click(object sender, EventArgs e)
        {
            HemsireaKayitlariGetir();
        }

        private void HemsireEkle_Click(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=.;Initial Catalog=HASTANE_OTOMASYONU;Integrated Security=True");
            con.Open();

            string kayit = "Insert Into Hemsireler (HastaneID,KlinikID,HemsireAdi,HemsireSoyadi,HemsireTC,HemsireCinsiyeti) Values (@hid,@kid,@ad,@soyad,@tc,@cinsiyet)";
            cmd = new SqlCommand(kayit, con);
            cmd.Parameters.AddWithValue("@hid", hastID.Text.ToString());
            cmd.Parameters.AddWithValue("@kid", kilID.Text.ToString());
            cmd.Parameters.AddWithValue("@ad", adi.Text.ToString());
            cmd.Parameters.AddWithValue("@soyad", soyadi.Text.ToString());
            cmd.Parameters.AddWithValue("@tc", tc.Text.ToString());
            cmd.Parameters.AddWithValue("@cinsiyet", cinsiyet.Text.ToString());

            cmd.ExecuteNonQuery();
            MessageBox.Show("Kayıt Ekleme İşleminiz Gerçekleşmiştir.");
            con.Close();
            HemsireaKayitlariGetir();
        }

        int i = 0;
        private void TabloyuGoster_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            i = e.RowIndex;
            hastID.Text = TabloyuGoster.Rows[i].Cells[1].Value.ToString();
            kilID.Text = TabloyuGoster.Rows[i].Cells[2].Value.ToString();
            adi.Text = TabloyuGoster.Rows[i].Cells[3].Value.ToString();
            soyadi.Text = TabloyuGoster.Rows[i].Cells[4].Value.ToString();
            tc.Text = TabloyuGoster.Rows[i].Cells[5].Value.ToString();
            cinsiyet.Text = TabloyuGoster.Rows[i].Cells[6].Value.ToString();
        }

        private void HemsireGuncelle_Click(object sender, EventArgs e)
        {

            con = new SqlConnection("Data Source=.;Initial Catalog=HASTANE_OTOMASYONU;Integrated Security=True");
            con.Open();

            string kayitGuncelle = ("Update Hemsireler set HastaneID=@hid, KlinikID=@kid, HemsireAdi=@ad, HemsireSoyadi=@soyad, HemsireTC=@tc, HemsireCinsiyeti=@cinsiyet where HemsireID=@id");
            cmd = new SqlCommand(kayitGuncelle, con);

            cmd.Parameters.AddWithValue("@hid", hastID.Text.ToString());
            cmd.Parameters.AddWithValue("@kid", kilID.Text.ToString());
            cmd.Parameters.AddWithValue("@ad", adi.Text.ToString());
            cmd.Parameters.AddWithValue("@soyad", soyadi.Text.ToString());
            cmd.Parameters.AddWithValue("@tc", tc.Text.ToString());
            cmd.Parameters.AddWithValue("@cinsiyet", cinsiyet.Text.ToString());
            cmd.Parameters.AddWithValue("@id", TabloyuGoster.Rows[i].Cells[0].Value);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Kayıt Başarıya Güncellendi.");
            con.Close();
            HemsireaKayitlariGetir();
        }



        private void YazilariTemizle_Click(object sender, EventArgs e)
        {
            hastID.Text = " ";
            kilID.Text = " ";
            adi.Text = " ";
            soyadi.Text = " ";
            tc.Text = " ";
            cinsiyet.Text = " ";
        }
    }
}

