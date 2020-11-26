using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace yazilimYapimiKelimeOyunu
{
    public partial class KelimeOyunu : Form
    {
        //---global variables---
        Random random = new Random();   //random değişkeni
        TextBox[] txtHarfler = new TextBox[8];   //textBox'lar
        char[] randomOlusturulanHarfler = new char[8];    //random oluşturulan harflerin bulundugu dizi
        char[] manuelGirilenHarfler = new char[8];
        //string[] olusturulabilecekKelimeler = new string[500];
        List<string> olusturulabilecekKelimeler = new List<string>();
        List<char> jokerler = new List<char>();
        char[] harfler = new char[]   
            {
                'a','b','c','ç','d','e','f','g','ğ','h','ı','i','j','k','l','m','n','o','ö','p','r','s','ş','t','u','ü','v','y','z'
            };      
        List<string> kelimeListesi = new List<string>();    // kelimelerin bulunduğu liste
        int value;  // random harfleri uretmek icin kullanilan indis degeri
        int dogruHarfSayaci = 0;
        int jokerOlabilecekHarfSayaci = 0;
        char jokerOlabilecekHarf;
        int yanlisHarfSayaci = 0;
        int longestWordIndex = 0;


        public KelimeOyunu()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            lblPuan.Text = "0";
            lblJokerHarf.Text = "-";
            lblEnUzunKelime.Text = "-";
            if (radioManual.Checked == false && radioRandom.Checked == false)
                MessageBox.Show("Önce seçeneklerden birini seçmelisiniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
           
            // oyun tekrar başlatıldığında karışıklık çıkmasın diye yapılan temizleme.
            for (int i = 0; i < txtHarfler.Length; i++)
                this.Controls.Remove(txtHarfler[i]);

            //veritabanı bağlantısı
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Fatih\\Downloads\\KelimeÖdevi.accdb");
            OleDbCommand comm = new OleDbCommand();
            comm.Connection = baglanti;
            comm.CommandText = "Select * from kelimeler";
            baglanti.Open();
            OleDbDataReader dr = comm.ExecuteReader();

            //veritabanından alınan verilerin listeye aktarımı
            while (dr.Read())
                kelimeListesi.Add(dr["kelime"].ToString());
            string[] harflerdenOlusturulabilenKelimeler = new string[kelimeListesi.Count];
            
            //harfler random istenirse
            if (radioRandom.Checked == true)
            {
                // harflerin bulunacağı textBoxları oluşturuyoruz
                createTextBoxes();
                
                // textBox'ları readonly yapıyoruz
                for (int i = 0; i < txtHarfler.Length; i++)
                    txtHarfler[i].ReadOnly = true;

                // 8 tane rastgele harfi textBox'lara yazdırıyoruz
                printRandomNumbers(txtHarfler); 
            }
           
            
            // kullanıcı harfleri kendi girmek isterse
            if(radioManual.Checked == true)
            {
                //yenile butonunu gizliyoruz
                btnYenile.Visible = false;
                // 8 adet textbox oluşturuyoruz, bunları kullanıcı dolduracak
                createTextBoxes();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnKelimeyiBul_Click(object sender, EventArgs e)
        {
            olusturulabilecekKelimeler.Clear();
            jokerler.Clear();
            Array.Clear(manuelGirilenHarfler, 0, 8);
            
            //kullanıcı harflerin random gelmesini isterse
            if (radioRandom.Checked == true)
            {
                wordAndJokerCheck(randomOlusturulanHarfler, olusturulabilecekKelimeler);

                longestWordIndex = olusturulabilecekKelimeler[0].Length;
                for (int i = 0; i < olusturulabilecekKelimeler.Count-1; i++)
                {
                    if (olusturulabilecekKelimeler[i+1].Length > olusturulabilecekKelimeler[longestWordIndex].Length)
                        longestWordIndex = i+1;
                }
                lblEnUzunKelime.Text = olusturulabilecekKelimeler[longestWordIndex].ToUpper();
                lblJokerHarf.Text = jokerler[longestWordIndex].ToString().ToUpper();
                
                puanlama(olusturulabilecekKelimeler[longestWordIndex]);
            }

            //kullanıcı harfleri kendi girmek isterse
            if(radioManual.Checked == true)
            {
                // kullanıcının textBox'lara yazdığı harfleri diziye aktarıyoruz.
                for (int i = 0; i < txtHarfler.Length; i++)
                  manuelGirilenHarfler[i] = Convert.ToChar(txtHarfler[i].Text);

                wordAndJokerCheck(manuelGirilenHarfler,olusturulabilecekKelimeler);
                longestWordIndex = olusturulabilecekKelimeler[0].Length;
                for (int i = 0; i < olusturulabilecekKelimeler.Count - 1; i++)
                {
                    if (olusturulabilecekKelimeler[i + 1].Length > olusturulabilecekKelimeler[longestWordIndex].Length)
                        longestWordIndex = i + 1;
                }
                lblEnUzunKelime.Text = olusturulabilecekKelimeler[longestWordIndex].ToUpper();
                lblJokerHarf.Text = jokerler[longestWordIndex].ToString().ToUpper();
                
                puanlama(olusturulabilecekKelimeler[longestWordIndex]);
            }

        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            //textBox'ları temizliyoruz
            for (int i = 0; i < txtHarfler.Length; i++)
                txtHarfler[i].Text = "";
            // tekrardan 8 tane harf oluşturuyoruz rastgele
            printRandomNumbers(txtHarfler);
        }

        // random harfleri textBox'lara yazdırmak için kullanılan fonksiyon
        public void printRandomNumbers(TextBox[] txt)
        {
            Array.Clear(randomOlusturulanHarfler, 0, 8);
            for (int i = 0; i < 8; i++)
            {
                value = random.Next(0, 28);
                txt[i].Text = harfler[value].ToString().ToUpper();
                randomOlusturulanHarfler[i] = harfler[value];
            }
        }

        // textBox'ları oluşturmak için kullanılan fonksiyon
        public void createTextBoxes()
        {
            int locationCounter = 78;   // yerleştirme konusunda kullandığım bir sayaç

            // 8 adet textbox oluşturuyoruz
            for (int i = 0; i < txtHarfler.Length; i++)
            {
                txtHarfler[i] = new TextBox();
                txtHarfler[i].Text = "";
                txtHarfler[i].Location = new Point(locationCounter + 26, 195);
                txtHarfler[i].Size = new Size(20, 20);
                txtHarfler[i].TextAlign = HorizontalAlignment.Center;
                txtHarfler[i].MaxLength = 1;
                this.Controls.Add(txtHarfler[i]);
                locationCounter += 26;
            }
        }

        // kelime ve joker kontrolü için kullanılan fonksiyon
        void wordAndJokerCheck(char[] harfler,List<string> olusturulanKelimeler)
        {
            // en uzun kelimeyi bulmak için döngü
            for (int i = 0; i < kelimeListesi.Count; i++)
            {
                char[] anlamliKelimelerinHarfleri = kelimeListesi[i].ToCharArray();
                // anlamlı kelimelerin harfleriyle random/manual oluşturulan harfleri kıyaslıyoruz
                for (int j = 0; j < anlamliKelimelerinHarfleri.Length; j++)
                {
                    for (int z = 0; z < harfler.Length; z++)
                    {
                        if (anlamliKelimelerinHarfleri[j] == harfler[z])
                        {
                            dogruHarfSayaci++;
                            break;
                        }
                        else
                            yanlisHarfSayaci++;
                    }

                    if (yanlisHarfSayaci == 8)
                    {
                        jokerOlabilecekHarfSayaci++;
                        jokerOlabilecekHarf = anlamliKelimelerinHarfleri[j];
                    }
                    yanlisHarfSayaci = 0;
                }
                if (dogruHarfSayaci == kelimeListesi[i].Length || dogruHarfSayaci + jokerOlabilecekHarfSayaci == kelimeListesi[i].Length)
                {
                    if (jokerOlabilecekHarfSayaci <= 1)
                    {
                        if (jokerOlabilecekHarfSayaci + dogruHarfSayaci >= 3 && dogruHarfSayaci + jokerOlabilecekHarfSayaci <= 9)
                        {
                            

                            //joker varsa
                            if (jokerOlabilecekHarfSayaci == 0)
                            {
                                olusturulanKelimeler.Add(kelimeListesi[i]);
                                jokerler.Add('-');
                            }
                            //joker yoksa
                            else
                            {
                                olusturulanKelimeler.Add(kelimeListesi[i]);
                                jokerler.Add(jokerOlabilecekHarf); 
                            }
                        }
                    }
                }
                jokerOlabilecekHarfSayaci = 0;
                dogruHarfSayaci = 0;
            } 
        }

        void puanlama(string enUzunKelime)
        {
            if (enUzunKelime.Length == 3)
                lblPuan.Text = enUzunKelime.Length + " PUAN";
            else if (enUzunKelime.Length == 4)
                lblPuan.Text = enUzunKelime.Length + " PUAN";
            else if (enUzunKelime.Length == 5)
                lblPuan.Text = enUzunKelime.Length + " PUAN";
            else if (enUzunKelime.Length == 6)
                lblPuan.Text = enUzunKelime.Length + 1 + " PUAN";
            else if (enUzunKelime.Length == 7)
                lblPuan.Text = enUzunKelime.Length + 2 + " PUAN";
            else if (enUzunKelime.Length == 8)
                lblPuan.Text = enUzunKelime.Length + 3 + " PUAN";
            else if (enUzunKelime.Length == 9)
                lblPuan.Text = enUzunKelime.Length + 6 + " PUAN";
        }

    }
}
