using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HASTANE_OTOMASYONU
{
    public partial class HastaneyeGorePoliklinikSayilari : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adptr;

        public HastaneyeGorePoliklinikSayilari()
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
            geriDon.label2.Text = label66.Text;
            geriDon.Show();
            this.Hide();
        }

        private void PolSayisi1_Click(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=.;Initial Catalog=HASTANE_OTOMASYONU;Integrated Security=True");
            con.Open();
            adptr = new SqlDataAdapter("exec AtaturkUniversitesiPoliklinikSayilari", con);
            DataTable Dtable = new DataTable();
            adptr.Fill(Dtable);
            PoliklinikSayisi.DataSource = Dtable;
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=.;Initial Catalog=HASTANE_OTOMASYONU;Integrated Security=True");
            con.Open();
            adptr = new SqlDataAdapter("exec OltuDevletHastanesiPoliklinikSayilari", con);
            DataTable Dtable = new DataTable();
            adptr.Fill(Dtable);
            PoliklinikSayisi.DataSource = Dtable;
            con.Close();
        }
    }
}
