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
    public partial class SilinenRandevular : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adptr;

        public SilinenRandevular()
        {
            InitializeComponent();
        }

        private void AnaMenu_Click(object sender, EventArgs e)
        {
            OtomasyonaGiris BasaDon = new OtomasyonaGiris();
            BasaDon.Show();
            this.Hide();
        }

        private void GeriDon_Click(object sender, EventArgs e)
        {
            AdminEkrani geriDon = new AdminEkrani();
            geriDon.label2.Text = label444.Text;
            geriDon.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=.;Initial Catalog=HASTANE_OTOMASYONU;Integrated Security=True");
            con.Open();
            adptr = new SqlDataAdapter("Select * From SilinmisRandevular", con);
            DataTable Dtable = new DataTable();
            adptr.Fill(Dtable);
            Goster.DataSource = Dtable;
            con.Close();
        }
    }
}
