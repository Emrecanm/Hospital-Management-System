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
using System.Configuration;

namespace HASTANE_OTOMASYONU
{

    public partial class AdminGirisi : Form
    {

        SqlConnection con;
        SqlDataReader rdr;
        SqlCommand com;

        public AdminGirisi()
        {
            InitializeComponent();
        }

        private void TurnBack_Click(object sender, EventArgs e)
        {
            OtomasyonaGiris BasaDon = new OtomasyonaGiris();
            BasaDon.Show();
            this.Hide();
        }

        private void AdminGiris_Click(object sender, EventArgs e)
        {
            string kullanici = AdminKullaniciAdi.Text;
            string sifre = AdminSifre.Text;
            con = new SqlConnection("Data Source=.;Initial Catalog=HASTANE_OTOMASYONU;Integrated Security=True");
            com = new SqlCommand();
            con.Open();
            com.Connection = con;
            com.CommandText = "Select * From  AdminGirisi Where AdminKullaniciAdi = '" + AdminKullaniciAdi.Text + "' and AdminSifre = '" + AdminSifre.Text + "'";
            rdr = com.ExecuteReader();

            if (rdr.Read())
            {
                AdminEkrani adminEkrani = new AdminEkrani();
                adminEkrani.label2.Text = AdminKullaniciAdi.Text;
                adminEkrani.Show();
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
            if(checkBox1.CheckState==CheckState.Checked)
            {
                AdminSifre.UseSystemPasswordChar = true;
                checkBox1.Text = "Göster";
            }
            else if(checkBox1.CheckState==CheckState.Unchecked)
            {
                AdminSifre.UseSystemPasswordChar=false;
                checkBox1.Text = "Gizle";
            }
        }
    }
}
