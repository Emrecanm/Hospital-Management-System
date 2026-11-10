using Microsoft.VisualBasic.ApplicationServices;
using System.Text;

namespace GörselProgramlamaFinaleHazirlik
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string str1 = "Atatürk Üniversitesi";
            //MessageBox.Show(str1.Length.ToString());
            //foreach (char ch1 in str1)
            //{
            //    listBox1.Items.Add(ch1.ToString());
            //}


            //string str1 = "bu ";
            //string str2 = "gün ";
            //string str3 = "am ";
            //int a1 = 23;
            //int a2 = 45;
            //string str4 = " derece ";
            //string str5 = "sikişmek ";
            //string str6 = "istiyorum ";
            //string cumle = String.Concat(str1, str2, str3, a2, str4, str5,str6);
            //listBox1.Items.Add(cumle);

            //string cumle2 = str1 + str2 + str3 + a1 + str4 + str5;
            //MessageBox.Show(cumle2);

            ////string cumle3 = a1 + a2;// dönüşüm hatası
            ////MessageBox.Show(cumle2);


            //string cumle4 = str4 + a1 + a2;
            //MessageBox.Show(cumle4);

            //string cumle5 = a1 + a2 + str4;
            //MessageBox.Show(cumle5);

            //string str1 = "Galatasaray", str2 = "galatasaraz";
            //int sira = String.Compare(str2, str1, true);
            //MessageBox.Show(sira.ToString());

            //string str1 = "Galatasaray", str2 = "galatasaray";
            //int sira = String.Compare(str2, str1);
            //MessageBox.Show(sira.ToString());

            //string str1 = "Galatasaray", str2 = "Fenerbahçe";
            //int sira = String.Compare(str2, str1);
            //MessageBox.Show(sira.ToString());

            //string str1 = "Galatasaray", str2 = "galatasaray";
            //int sira = String.Compare(str2, str1, true);
            //MessageBox.Show(sira.ToString());

            //string str = "EmrecanDüzenli";
            //str = str.Insert(7, " taşşaku talat ve fitnat ");
            //MessageBox.Show(str.ToString());

            //string str1 = "EmrecanDüzenli";
            //str = str.Remove(7,6);
            //MessageBox.Show(str.ToString());

            //string str1 = "emrecan tunç orospusu";
            //string[] str2 = str1.Split('o');
            //foreach (string str3 in str2)
            //{
            //    listBox1.Items.Add(str3);
            //}

            //string[] str1 = { "Olmak", "ya da", "olmamak", "işte", "bütün", "mesele", "bu!" };
            //string str2 = String.Join(" am ", str1);
            //MessageBox.Show(str2);

            //string str1 = "Olmak ya da olmamak, işte bütün mesele bu!";
            //MessageBox.Show(str1.IndexOf("o").ToString());
            //MessageBox.Show(str1.IndexOf("o").ToString());
            //MessageBox.Show(str1.IndexOf('!').ToString());
            //MessageBox.Show(str1.IndexOf("Z").ToString());
            //MessageBox.Show(str1.IndexOf("a").ToString());
            //MessageBox.Show(str1.IndexOf(" ").ToString());
            //MessageBox.Show(str1.IndexOf("işte").ToString());

            //string str1 = "Olmak ya da olmamak, işte bütün mesele bu!";
            //MessageBox.Show(str1.LastIndexOf(" ").ToString());
            //MessageBox.Show(str1.LastIndexOf("Z").ToString());
            //MessageBox.Show(str1.LastIndexOf("a").ToString());
            //MessageBox.Show(str1.LastIndexOf("o").ToString());

            //string str1 = "Olmak ya da olmamak, işte bütün mesele bu!";
            //char[] ch1 = { ',', '!', ' ' };
            //int indeks = str1.IndexOfAny(ch1);
            //MessageBox.Show(indeks.ToString());

            //string str1 = "Olmak ya da olmamak, işte bütün mesele bu!";
            //char[] ch1 = { ',', '!', ' ' };
            //int indeks = str1.LastIndexOfAny(ch1);
            //MessageBox.Show(indeks.ToString());

            //string str1 = "    Atatürk   Üniversitesi    ";
            //listBox1.Items.Add(str1);
            //str1 = str1.Trim();
            //listBox1.Items.Add(str1);

            //string str1 = "Olmak ya da olmamak, işte bütün mesele bu!";
            //char[] ch1 = { ' ', '!', 'a' };
            //str1 = str1.Trim(ch1);
            //MessageBox.Show(str1);

            //int inta = 5; int intb = 10;
            //double dbla = 1.1; double dblb = 2.2;
            //MessageBox.Show(topla(inta, intb).ToString());
            //MessageBox.Show(topla(dbla, dblb).ToString());
            //MessageBox.Show(topla(inta, dblb).ToString());

            //string[] sehirler = { "ANKARA", "İSTANBUL", "ERZURUM", "BOLU" };
            //yaz(sehirler);


            //string yol2 = "C:\\Users\\emrec\\OneDrive\\Masaüstü\\Klasor1";
            //Directory.CreateDirectory(yol2);
            //MessageBox.Show("Klasör Oluşturulmuştur Çıkış Yapabilirsiniz.");

            //string yol = "C:\\Users\\emrec\\OneDrive\\Masaüstü\\GAMES2";
            //bool kontrol = Directory.Exists(yol);
            //MessageBox.Show(kontrol.ToString());

            //string[] altklasor = Directory.GetDirectories("c:\\Program Files");
            //listBox1.Items.AddRange(altklasor);

            //string[] altklasor = Directory.GetDirectories("c:\\Program Files");
            //listBox1.Items.AddRange(altklasor);

            //string yer = Directory.GetDirectoryRoot("c:\\WINDOWS");
            //this.Text = yer;

            //string[] surucu = Directory.GetLogicalDrives();
            //listBox1.Items.AddRange(surucu);

            //string[] ad = Directory.GetFileSystemEntries("c:\\Riot Games", "VALORANT");
            //listBox1.Items.AddRange(ad);

            //FileInfo dosya = new FileInfo("C:\\Users\\emrec\\OneDrive\\Masaüstü\\Yeni klasör\\emre.txt");
            //dosya.CopyTo("C:\\Users\\emrec\\OneDrive\\Masaüstü\\Yeni klasör\\deneme2.txt", true);

            //FileInfo dosya = new FileInfo("C:\\Users\\emrec\\OneDrive\\Masaüstü\\GAMES");
            //MessageBox.Show(dosya.CreationTime.ToString());

            //string yol = "C:\\Users\\emrec\\OneDrive\\Masaüstü\\Yeni klasör\\emre.txt";
            //FileInfo dosya1 = new FileInfo(yol);
            //if (dosya1.Exists)
            //{
            //    StreamReader oku = new StreamReader(yol);
            //    string satir;
            //    while ((satir = oku.ReadLine()) != null)
            //    {
            //        MessageBox.Show(satir);
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("böyle bir dosya YOK!!!");
            //}

            //StreamWriter yaz = new StreamWriter("C:\\Users\\emrec\\OneDrive\\Masaüstü\\Yeni klasör\\emre.txt");
            //yaz.WriteLine(textBox1.Text);
            //yaz.Close();

            //StreamWriter yaz = new StreamWriter("C:\\Users\\emrec\\OneDrive\\Masaüstü\\Yeni klasör\\emre.txt", true);
            //yaz.WriteLine(textBox1.Text);
            //yaz.Close();

            //listBox1.Items.Add(textBox1.Text.ToString());
            //listBox2.Items.Add(textBox2.Text.ToString());
            //listBox3.Items.Add(textBox3.Text.ToString());

            //StreamWriter yaz = new StreamWriter("C:\\Users\\emrec\\OneDrive\\Masaüstü\\Yeni klasör\\emre.txt",true);
            //yaz.WriteLine(textBox1.Text.ToString());
            //yaz.WriteLine(textBox2.Text.ToString());
            //yaz.WriteLine(textBox3.Text.ToString());
            //yaz.Close();

            //string ad = "EMRECAN ADAMDIR.";
            //MessageBox.Show(ad.IndexOf(" ").ToString());
            //--------------------------------------------------------------------------------------------------
            //-------------/////ÖZET/////-------------------//

            //int[,] dizi = { { 10, 20 }, { 30, 40 }, { 50, 60 } };

            //string[] dizi2 = {  "ad", "soyad" ,  "Emre ", "can" ,  "Adam", "adm"  };

            //MessageBox.Show(dizi.Rank.ToString());
            //MessageBox.Show(dizi.GetLength(1).ToString());
            //System.Array.Reverse(dizi2);
            //foreach(string i in dizi2)
            //{
            //    listBox1.Items.Add(i);
            //}


            //Random rassal=new Random();
            //int rasgele = rassal.Next();
            //MessageBox.Show(rasgele.ToString());
            //int rasgele2 = rassal.Next(100);
            //MessageBox.Show(rasgele2.ToString());
            //int rasgele3= rassal.Next(10,50);
            //MessageBox.Show(rasgele3.ToString());


            //string str1 = "D";
            //string str2 = "d";
            //int kiyas= string.Compare(str1,str2);
            //int kiyas2 = string.Compare(str1,str2,true);
            //MessageBox.Show(kiyas2.ToString());


            //string str = "Emrecan Düzenli";
            //str = str.Insert(8, "ali ");
            //MessageBox.Show(str.ToString());
            //str= str.Remove(4,3);
            //MessageBox.Show(str.ToString());


            //string str = "Adam Olana Çok Bile!!";
            //string[] str2= str.Split(' ');
            //foreach (string i in str2)
            //{
            //    listBox1.Items.Add(i);
            //}


            //string[] str1 = { "Adam", "Olana", "Çok", "Bile" };
            //string str2 = string.Join("-", str1);
            //MessageBox.Show(str2);


            //string str = "Emrecan Düzenli Oltu Erzurum.";
            //char[] eleman = { 'D', 'N', '.' };
            //MessageBox.Show(str.IndexOf("ltu").ToString());
            //MessageBox.Show(str.LastIndexOf("m").ToString());
            //MessageBox.Show(str.IndexOfAny(eleman).ToString());
            //MessageBox.Show(str.LastIndexOfAny(eleman).ToString());


            //string str = "adam adam";
            //char[] eleman = { 'a' };
            ////MessageBox.Show(str.Trim());
            //MessageBox.Show(str.Trim(eleman));


            //string str = "Olmak Ya da Olmamak Sikimde Değil!";
            //listBox1.Items.Add(str.Substring(6));
            //listBox1.Items.Add(str.Substring(6,4));
            //listBox1.Items.Add(str.Replace(" ","-"));


            string yol = "C:\\Users\\emrec\\OneDrive\\Masaüstü\\GAMES";
            //Directory.CreateDirectory(yol);
            //Directory.Delete(yol);
            //bool varMi= Directory.Exists(yol);
            //MessageBox.Show(varMi.ToString());
            //string[] icinde = Directory.GetDirectories(yol);
            //string[] icinde = Directory.GetFiles(yol);
            //foreach (string a in icinde)
            //    listBox1.Items.Add(a);
            //string surucu = Directory.GetDirectoryRoot(yol);
            //string[] suruculer = Directory.GetLogicalDrives();
            //foreach (string s in suruculer)
            //{
            //    listBox1.Items.Add(s);  
            //}
            string[] arama = Directory.GetFileSystemEntries(yol, "Boga2 Full Client");
            foreach(string i  in arama)
            {
                listBox1.Items.Add(i);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //string yol = "C:\\Users\\emrec\\OneDrive\\Masaüstü\\Yeni klasör\\emrec.txt";
            //FileInfo dosya1 = new FileInfo(yol);
            //if (dosya1.Exists)
            //{
            //    StreamReader oku = new StreamReader(yol);
            //    string satir;
            //    for (int i=0;i<=9;i+=3)
            //    {
            //        listBox1.Items.Add(oku.ReadLine());
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("böyle bir dosya YOK!!!");
            //}
        }
    }
}
