using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HASTANE_OTOMASYONU
{
    public partial class HastaGirisi : Form
    {
        SqlConnection con;
        SqlDataReader rdr;
        SqlCommand com;

        public HastaGirisi()
        {
            InitializeComponent();
        }

        private void GeriDon_Click(object sender, EventArgs e)
        {
            OtomasyonaGiris BasaDon = new OtomasyonaGiris();
            BasaDon.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string kullanici = HastaTC.Text;
            string sifre = HastaSifre.Text;
            con = new SqlConnection("Data Source=.;Initial Catalog=HASTANE_OTOMASYONU;Integrated Security=True");
            com = new SqlCommand();
            con.Open();
            com.Connection = con;
            com.CommandText = "Select * From  HastaGirisi Where HastaKullaniciadi = '" + HastaTC.Text + "' and HastaSifre = '" + HastaSifre.Text + "'";
            rdr = com.ExecuteReader();

            if (rdr.Read())
            {
                HastaEkrani hastaEk = new HastaEkrani();
                hastaEk.label222.Text = HastaTC.Text;
                hastaEk.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı!");
            }
            con.Close();
        }

        private void HastaTC_TextChanged(object sender, EventArgs e)
        { }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.CheckState == CheckState.Checked)
            {
                HastaSifre.UseSystemPasswordChar = true;
                checkBox1.Text = "Göster";
            }
            else if (checkBox1.CheckState == CheckState.Unchecked)
            {
                HastaSifre.UseSystemPasswordChar = false;
                checkBox1.Text = "Gizle";
            }
        }

        private void KayitOl_Click(object sender, EventArgs e)
        {
            HastaKayitEkrani hastakayit = new HastaKayitEkrani();
            hastakayit.Show();
            this.Hide();
        }
    }
}
