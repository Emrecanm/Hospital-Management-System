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
    public partial class DoktorGirisi : Form
    {
        SqlConnection con;
        SqlDataReader rdr;
        SqlCommand com;

        public DoktorGirisi()
        {
            InitializeComponent();
        }

        private void Giris_Click(object sender, EventArgs e)
        {
            string kullanici = DoktorKullaniciAdi.Text;
            string sifre = DoktorSifre.Text;
            con = new SqlConnection("Data Source=.;Initial Catalog=HASTANE_OTOMASYONU;Integrated Security=True");
            com = new SqlCommand();
            con.Open();
            com.Connection = con;
            com.CommandText = "Select * From  DoktorGirisi Where DoktorKullaniciAdi = '" + DoktorKullaniciAdi.Text + "' and DoktorSifre = '" + DoktorSifre.Text + "'";
            rdr = com.ExecuteReader();

            if (rdr.Read())
            {
                DoktorEkrani doktorEkrani = new DoktorEkrani();
                doktorEkrani.label23.Text = DoktorKullaniciAdi.Text;
                doktorEkrani.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı!");
            }
            con.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.CheckState == CheckState.Checked)
            {
                DoktorSifre.UseSystemPasswordChar = true;
                checkBox1.Text = "Göster";
            }
            else if (checkBox1.CheckState == CheckState.Unchecked)
            {
                DoktorSifre.UseSystemPasswordChar = false;
                checkBox1.Text = "Gizle";
            }
        }

        private void AnaMenu_Click(object sender, EventArgs e)
        {
            OtomasyonaGiris BasaDon = new OtomasyonaGiris();
            BasaDon.Show();
            this.Hide();
        }
    }
}
