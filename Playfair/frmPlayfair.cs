using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Playfair
{
    public partial class frmPlayfair : Form
    {
        public frmPlayfair()
        {
            InitializeComponent();
        }

        string anahtar = ""; //kullanıcının girmek isteyeb
        string karakterler; //"abcçdefgğhıijklmnoöprsştuüvyzqwx.,: ";
        char[,] kutu = new char[6,6]; //play fair karakter matrisi.
        char[,] ikililer = new char[200, 2]; int ikiliSayisi = 0; //playfair 2lileri.
        char[,] sonuc = new char[200, 2];//şifrele ya da deşifreleden elde edilen sonuç.
        int[] yer = new int[4];//ikililerin yerleri için.
        Random rnd = new Random();

        //Türkçede olmayan karakterleri temizler (deşifrelenen metin için kullanılıyor.)
        public string temizle(string metin)
        {
            string temizMetin="";

            for (int i = 0; i < metin.Length; i++)
            {
                if (metin[i] != 'q' && metin[i] != 'w' && metin[i] != 'x')
                    temizMetin += metin[i];
            }

            return temizMetin;
        }

        //şifrelenen ya da deşifrelenen metni sonuç ekranında gösterir.
        public string sonucuYaz()
        {
            string sonucMetni = "";

            for(int i = 0; i < ikiliSayisi; i++)
            {
                sonucMetni += sonuc[i, 0].ToString() + sonuc[i, 1].ToString();
            }

            return sonucMetni;
        }

        //ikilileri ayrı ayrı ele alarak Playfair deşifreleme yapar.
        public void desifrele()
        {
            for (int i = 0; i < ikiliSayisi; i++)
            {
                //ikilinin yerlerini bul.
                yerBul(ikililer[i, 0], ikililer[i, 1]);

                if (yer[0] == yer[2]) // aynı satırda iseler,
                {
                    sonuc[i, 0] = kutu[yer[0], (yer[1] + 5) % 6];
                    sonuc[i, 1] = kutu[yer[2], (yer[3] + 5) % 6];
                }
                else if (yer[1] == yer[3]) // aynı stunda iseler,
                {
                    sonuc[i, 0] = kutu[(yer[0] + 5) % 6, yer[1]];
                    sonuc[i, 1] = kutu[(yer[2] + 5) % 6, yer[3]];
                }
                else //satır ve stunları farklı ise,
                {
                    sonuc[i, 0] = kutu[yer[0], yer[3]];
                    sonuc[i, 1] = kutu[yer[2], yer[1]];
                }
            }
        }

        //ikilileri ayrı ayrı ele alarak Playfair şifreleme yapar.
        public void sifrele()
        {
            for (int i = 0; i < ikiliSayisi; i++)
            {
                //ikilinin yerlerini bul.
                yerBul(ikililer[i,0], ikililer[i,1]);

                if (yer[0] == yer[2]) // aynı satırda iseler,
                {
                    sonuc[i, 0] = kutu[yer[0], (yer[1]+1) % 6];
                    sonuc[i, 1] = kutu[yer[2], (yer[3]+1) % 6];
                }
                else if (yer[1] == yer[3]) // aynı stunda iseler,
                {
                    sonuc[i, 0] = kutu[(yer[0]+1) % 6, yer[1]];
                    sonuc[i, 1] = kutu[(yer[2]+1) % 6, yer[3]];
                }
                else //satır ve stunları farklı ise,
                {
                    sonuc[i, 0] = kutu[yer[0],yer[3]];
                    sonuc[i, 1] = kutu[yer[2],yer[1]];
                }
            }
        }

        //İstenilen ikilinin anahtar matrisindeki satır ve stununu bulur.
        public void yerBul(char ch1, char ch2)
        {
            // yer[0] = 1. karakterin satırı, yer[1] = 1. karakterin stunu
            // yer[2] = 2. karakterin satırı, yer[3] = 2. karakterin stunu

            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    if (kutu[i,j] == ch1)
                    {
                        yer[0] = i; //satır no.
                        yer[1] = j; //stun no.
                    }
                    else if (kutu[i, j] == ch2)
                    {
                        yer[2] = i;
                        yer[3] = j;
                    }
                }
            }
        }

        //Girdi metninden ikili karakter dizisini oluşturur.
        public void ikilileriOlustur(string metin)
        {
            int j = 0;

            for (int i = 0; i < metin.Length; )
            {
                ikililer[j, 0] = metin[i];//ikililerin ilk elemanı direk yazılabilir.

                if (i == metin.Length - 1)
                {   //tek sayıda karakter barındıran metinler için son adım:
                    //alt satırda i+1'inci eleman kontrol edildiğinden, hata almamak için ilk önce bu if yazıldı.
                    ikililer[j, 1] = 'w';
                    j++;
                    break;
                }
                else if (metin[i] != metin[i + 1])
                {
                    ikililer[j, 1] = metin[i + 1];
                    i += 2;
                }
                else
                {
                    ikililer[j, 1] = 'x';
                    i++;
                }

                j++;
            }

            ikiliSayisi = j;
        }

        //rastgele anahtar matrisi oluştur
        public void anahtarUret()
        {
            int k = 0;
            int j = 0;
            int index = 0;

            karakterler = "abcçdefgğhıijklmnoöprsştuüvyzqwx.,: ";
            int i = karakterler.Length;

            while (i > 0)
            {
                index = rnd.Next(0, i); // karakterler içinden birini seçmek için random index al.
                kutu[k, j] = karakterler[index]; //matrise işle.
                karakterler = karakterler.Remove(index, 1); //işlenen karakteri çıkart.

                i--;
                j++;

                if (j % 6 == 0)
                {
                    k++;
                    j = 0;
                }
            }
        }

        //anahtar matrisini oluşturur.
        public void kutuOlustur()
        {
            int j = 0;
            int k = 0;
            int i = anahtar.Length;
            int index1 = 0;

            karakterler = "abcçdefgğhıijklmnoöprsştuüvyzqwx.,: ";

            //anahtarı işle.
            while(i > 0)
            {
                //anahtarı kutuya işle ve karakter kümesinden, kutuya işlenenleri çıkar.
                index1 = karakterler.IndexOf(anahtar[anahtar.Length - i]);//tekrarlı harfin 2 defa kutuya alınmaması için.
                if (index1 >= 0)
                {
                    kutu[k,j] = anahtar[anahtar.Length - i];
                    karakterler = karakterler.Remove(index1, 1);
                    j++;
                }
                
                i--;

                if (j == 6) 
                {
                    k++;
                    j = 0;
                }
            }

            i = 0; //i, kalan karakterleri işlemek için tekrar kullanılacak.

            //kalan karakterleri işle.
            while (i < karakterler.Length)
            {
                kutu[k,j] = karakterler[i];

                i++;
                j++;

                if (j % 6 == 0)
                {
                    k++;
                    j = 0;
                }
            }
        }

        //anahtar matrisini ekrana yazar.
        public void kutuyuEkranaYaz()
        {
            txtMatris.Text = "";

            for (int i = 1; i < 7; i++)
            {
                for (int j = 1; j < 7; j++)
                {
                    txtMatris.Text += kutu[i - 1, j - 1] + "\r\t";
                }
                txtMatris.Text += "\r\n\r\n";
            }
        }

        //metin içinde tanınmayacak karakter olup olmadığını kontrol eder.
        public string girdiKontrol(string metin)
        {
            //tanınabilen karakterler : "a - z ", 'q' , 'w' , 'x' , '.' , ',' , ':' , ' '

            // şirede tanımlı olmayan bir karakter gelmiş ise sil.
            for (int i = metin.Length - 1; i >= 0;i-- ){
                if (!(metin[i] == '.' || metin[i] == ',' ||
                    metin[i] == ':' || metin[i] == ' ' ||
                    (metin[i] >= 97 && metin[i] <= 122) ||
                    metin[i] == 'ü' || metin[i] == 'ö' ||
                    metin[i] == 'ç' || metin[i] == 'ş' ||
                    metin[i] == 'ğ' || metin[i] == 'ı'))
                {
                    metin = metin.Remove(i, 1);
                }
            }
            return metin;
        }

        private void txtAnahtar_TextChanged(object sender, EventArgs e)
        {
            if (txtAnahtar.Text == "")
            {
                //txtMetin.Enabled = false;
                //txtSonuc.Enabled = false;
                anahtar = "";
            }
            else 
            {
                //txtMetin.Enabled = true;
                //txtSonuc.Enabled = true;
                txtAnahtar.Text = girdiKontrol(txtAnahtar.Text);
                txtAnahtar.Select(txtAnahtar.Text.Length, 0);//imleç, text boxın sonunda kalsın.
                anahtar = txtAnahtar.Text;
            }
            kutuOlustur();
            kutuyuEkranaYaz();
        }

        private void txtMetin_TextChanged(object sender, EventArgs e)
        {
            if (txtMetin.Text == "")
            {
                btnDesifrele.Enabled = false;
                btnSifrele.Enabled = false;
            }
            else
            {
                txtMetin.Text = girdiKontrol(txtMetin.Text);
                txtMetin.Select(txtMetin.Text.Length, 0);//imleç, text boxın sonunda kalsın.
                btnDesifrele.Enabled = true;
                btnSifrele.Enabled = true;
            }

            if(txtMetin.Text.Length < 200)
                lblGirdiMetniSay.Text = "("+ (199 - txtMetin.Text.Length).ToString() +")";
        }

        private void btnSifrele_Click(object sender, EventArgs e)
        {
            ikilileriOlustur(txtMetin.Text);
            sifrele();
            txtSonuc.Text = sonucuYaz();
        }

        private void btnDegistir_Click(object sender, EventArgs e)
        {
            txtMetin.Text = txtSonuc.Text;
            txtSonuc.Text = "";
        }

        private void btnDesifrele_Click(object sender, EventArgs e)
        {
            txtSonuc.Text = "";

            ikilileriOlustur(txtMetin.Text);
            desifrele();

            if (cbTemizle.Checked == true)
                // çözülmiş şifre ikililerini bir string haline getirir ve q,w,x 'ten temizler.
                txtSonuc.Text = temizle(sonucuYaz());
            else
                txtSonuc.Text = sonucuYaz();
        }

        private void frmPlayfair_Load(object sender, EventArgs e)
        {
            kutuOlustur();
            kutuyuEkranaYaz();
        }

        private void btnAnahtarUret_Click(object sender, EventArgs e)
        {
            anahtarUret();
            kutuyuEkranaYaz();
        }
    }
}
