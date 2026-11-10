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
using System.Reflection.Emit;

namespace HASTANE_OTOMASYONU
{
    public partial class HastaneyeGoreDoktorSayisi : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adptr;

        public HastaneyeGoreDoktorSayisi()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=.;Initial Catalog=HASTANE_OTOMASYONU;Integrated Security=True");
            con.Open();
            adptr = new SqlDataAdapter("exec AtaturkUniversitesiDoktorSayisi", con);
            DataTable Dtable = new DataTable();
            adptr.Fill(Dtable);
            SayiyiGoster.DataSource = Dtable;
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=.;Initial Catalog=HASTANE_OTOMASYONU;Integrated Security=True");
            con.Open();
            adptr = new SqlDataAdapter("exec OtuDevletHastanesiDoktorSayisi", con);
            DataTable Dtable = new DataTable();
            adptr.Fill(Dtable);
            SayiyiGoster.DataSource = Dtable;
            con.Close();
        }

        private void AnaMenu_Click(object sender, EventArgs e)
        {
            OtomasyonaGiris menuDon = new OtomasyonaGiris();
            menuDon.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AdminEkrani geriDon = new AdminEkrani();
            geriDon.label2.Text = label55.Text;
            geriDon.Show();
            this.Hide();
        }
    }
}
