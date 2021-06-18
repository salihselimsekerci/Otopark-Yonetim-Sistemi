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

namespace AOS
{
    public partial class Yer_Ekle_Penceresi : Form
    {
        public Yer_Ekle_Penceresi()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(GirisPenceresi.globel_baglanti_adresi);//BAĞLANTI ADRESİ
        SqlCommand komut;//SQL İFADELERİ İÇİN KULLANILIR
        SqlDataReader oku;//ÇEKİLEN VERİLERİN ALANLARINA GÖRE TEKER TEKER OKUMA
        DataSet veriseti = new DataSet();//VERİ SETİDİR
        private void Yer_Ekle_Penceresi_Load(object sender, EventArgs e)
        {
            /*OTOPARK YERLERİ*/
            otopark_yeri_comboBox3.Items.Add("A1");
            otopark_yeri_comboBox3.Items.Add("A2");
            otopark_yeri_comboBox3.Items.Add("A3");
            otopark_yeri_comboBox3.Items.Add("A4");

            otopark_yeri_comboBox3.Items.Add("B1");
            otopark_yeri_comboBox3.Items.Add("B2");
            otopark_yeri_comboBox3.Items.Add("B3");
            otopark_yeri_comboBox3.Items.Add("B4");

            otopark_yeri_comboBox3.Items.Add("C1");
            otopark_yeri_comboBox3.Items.Add("C2");
            otopark_yeri_comboBox3.Items.Add("C3");
            otopark_yeri_comboBox3.Items.Add("C4");

            otopark_yeri_comboBox3.Items.Add("D1");
            otopark_yeri_comboBox3.Items.Add("D2");
            otopark_yeri_comboBox3.Items.Add("D3");
            otopark_yeri_comboBox3.Items.Add("D4");

            /*EĞER YER DOLU İSE O YERİ TEKRAR BİR GİRİŞ YAPILMASINI ENGELLEME*/
            baglanti.Open();//VERİTABANINA BAĞLANTI AÇILDI
            komut = new SqlCommand("select yer_adi from Arac_Giris_Cikis_Tablosu where arsiv=1", baglanti);//YER ADINI ÇEKME
            oku = komut.ExecuteReader();//KOMUTLARI ÇALIŞTIRIP VERİLERİ SAKLADIĞIMIZ KOMUT
            while (oku.Read())//OKUMA
            {
                otopark_yeri_comboBox3.Items.Remove(oku["yer_adi"]);//YER ÇIKARMA
            }
            baglanti.Close();//VERİTABANI BAĞLANTISI KAPATILDI

            otopark_yeri_comboBox3.SelectedIndex = 0;
          
            MusteriTCcekme();//MÜŞTERİ TCSİNİ ÇEKME FOKSİYONU
            AracPLAKAcekme();//PLAKA BİLGİLERİNİ ÇEKME
            if (musteri_comboBox1.Items.Count > 0)//EĞER SEÇİM KUTUSUNDA ELEMAN VARSA SEÇ
            {
                musteri_comboBox1.SelectedIndex = 0;//İLK ELEMANI/İNDEXSİ SEÇ
            }
            if (arac_comboBox2.Items.Count > 0)//EĞER SEÇİM KUTUSUNDA ELEMAN VARSA SEÇ
            {
                arac_comboBox2.SelectedIndex = 0;//İLK ELEMANI/İNDEXSİ SEÇ
            }
        }
        private void MusteriTCcekme()//MÜŞTERİ TCSİNİ ÇEKME FOKSİYONU
        {
            try
            {
                musteri_comboBox1.Items.Clear();//EKLEME GÜNCELLEMEDEN SONRA TEKRAR YÜKLENECEK VE VERİLERİN ÜST ÜSTÜ GELMEMESİ İÇİN SİLME İŞLEMİ YAPILIYOR
                baglanti.Open();//VERİTABANINA BAĞLANTI AÇILDI
                komut = new SqlCommand("select tc from Musteri_Tablosu where arsiv=1", baglanti);//TC NUMARALARINI ÇEKME
                oku = komut.ExecuteReader();//KOMUTLARI ÇALIŞTIRIP VERİLERİ SAKLADIĞIMIZ KOMUT
                while (oku.Read())//OKUMA
                {
                    musteri_comboBox1.Items.Add(oku["tc"]);//TC EKLER
                }
                baglanti.Close();//VERİTABANI BAĞLANTISI KAPATILDI
            }
            catch (Exception HATA)
            {
                baglanti.Close();//VERİTABANI BAĞLANTISI KAPATILDI
                MessageBox.Show(HATA.ToString() + "\nSİSTEM DIŞI HATA OLUŞMUŞTUR...", "KONTROL DIŞI HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);//HATA BİLGİSİ MESAJ PENCERESİ İLE KULLANICIYA GÖSTERİLDİ.
            }
        }

        private void AracPLAKAcekme()//ARAÇ PLAKASINI ÇEKME FOKSİYONU
        {
            try
            {
                arac_comboBox2.Items.Clear();//EKLEME GÜNCELLEMEDEN SONRA TEKRAR YÜKLENECEK VE VERİLERİN ÜST ÜSTÜ GELMEMESİ İÇİN SİLME İŞLEMİ YAPILIYOR
                baglanti.Open();//VERİTABANINA BAĞLANTI AÇILDI
                komut = new SqlCommand("select plaka from Arac_Tablosu where arsiv=1", baglanti);//PLAKA NUMARALARINI ÇEKME
                oku = komut.ExecuteReader();//KOMUTLARI ÇALIŞTIRIP VERİLERİ SAKLADIĞIMIZ KOMUT
                while (oku.Read())//OKUMA
                {

                    arac_comboBox2.Items.Add(oku["plaka"]);//PLAKA EKLER
                }
                baglanti.Close();//VERİTABANI BAĞLANTISI KAPATILDI

                /*EĞER PLAKA ZATEN OTOPARKTA MEVCUT İSE TEKRAR EKLENEMEZ.*/
                baglanti.Open();//VERİTABANINA BAĞLANTI AÇILDI
                komut = new SqlCommand("select arac_plaka from Arac_Giris_Cikis_Tablosu where arsiv=1", baglanti);//PLAKA NUMARALARINI ÇEKME
                oku = komut.ExecuteReader();//KOMUTLARI ÇALIŞTIRIP VERİLERİ SAKLADIĞIMIZ KOMUT
                while (oku.Read())//OKUMA
                {
                    arac_comboBox2.Items.Remove(oku["arac_plaka"]);//PLAKA ÇIKARMA
                }
                baglanti.Close();//VERİTABANI BAĞLANTISI KAPATILDI


            }
            catch (Exception HATA)
            {
                baglanti.Close();//VERİTABANI BAĞLANTISI KAPATILDI
                MessageBox.Show(HATA.ToString() + "\nSİSTEM DIŞI HATA OLUŞMUŞTUR...", "KONTROL DIŞI HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);//HATA BİLGİSİ MESAJ PENCERESİ İLE KULLANICIYA GÖSTERİLDİ.
            }
        }

        string veritabanindan_cekilen_bilgileri_birlestir = "";//ÇEKİLEN BİLGİLERİ SAKLAMA VE BİRLEŞTİRME DEĞİŞKENİ

        private void musteri_comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            veritabanindan_cekilen_bilgileri_birlestir = "";
            try
            {
                baglanti.Open();//VERİTABANINA BAĞLANTI AÇILDI
                komut = new SqlCommand("select * from Musteri_Tablosu where tc='" + musteri_comboBox1.Text + "'", baglanti);//MÜŞTERİ BİLGİLERİ
                oku = komut.ExecuteReader();//KOMUTLARI ÇALIŞTIRIP VERİLERİ SAKLADIĞIMIZ KOMUT
                if (oku.Read())//OKUMA
                {/*ÇEKİLEN BİLGİLERİ BİRLEŞTİRME YAPILAN YERDİR DİKKAT += KULLANILARAK BİRLEŞTİRİLİR \n ile bir alt satıra geçer*/
                    veritabanindan_cekilen_bilgileri_birlestir += "AD:" + oku["ad"].ToString() + "\n";
                    veritabanindan_cekilen_bilgileri_birlestir += "SOYAD:" + oku["soyad"].ToString() + "\n";
                    veritabanindan_cekilen_bilgileri_birlestir += "CİNSİYET:" + oku["cinsiyet"].ToString()+"\n";
                    veritabanindan_cekilen_bilgileri_birlestir += "TELEFON:" + oku["telefon"].ToString();

                }
                baglanti.Close();//VERİTABANI BAĞLANTISI KAPATILDI
                bilgi1_musteri.Text = veritabanindan_cekilen_bilgileri_birlestir;//labelda gösterme
                

            }
            catch (Exception HATA)
            {
                baglanti.Close();//VERİTABANI BAĞLANTISI KAPATILDI
                MessageBox.Show(HATA.ToString() + "\nSİSTEM DIŞI HATA OLUŞMUŞTUR...", "KONTROL DIŞI HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);//HATA BİLGİSİ MESAJ PENCERESİ İLE KULLANICIYA GÖSTERİLDİ.
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            musteri_penceresi musteri_islemleri = new musteri_penceresi();
            musteri_islemleri.ShowDialog();
            MusteriTCcekme();
        }

        private void arac_comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            veritabanindan_cekilen_bilgileri_birlestir = "";
            try
            {
                baglanti.Open();//VERİTABANINA BAĞLANTI AÇILDI
                komut = new SqlCommand("select * from Arac_Tablosu where plaka='" + arac_comboBox2.Text + "'", baglanti);//ARAÇ BİLGİLERİ
                oku = komut.ExecuteReader();//KOMUTLARI ÇALIŞTIRIP VERİLERİ SAKLADIĞIMIZ KOMUT
                if (oku.Read())//OKUMA
                {/*ÇEKİLEN BİLGİLERİ BİRLEŞTİRME YAPILAN YERDİR DİKKAT += KULLANILARAK BİRLEŞTİRİLİR \n ile bir alt satıra geçer*/
                    veritabanindan_cekilen_bilgileri_birlestir += "PLAKA:" + oku["plaka"].ToString() + "\n";
                    veritabanindan_cekilen_bilgileri_birlestir += "MARKA:" + oku["marka"].ToString() + "\n";
                    veritabanindan_cekilen_bilgileri_birlestir += "MODEL:" + oku["model"].ToString() + "\n";
                    veritabanindan_cekilen_bilgileri_birlestir += "KATEGORİ:" + oku["kategori"].ToString()+"\n";
                    veritabanindan_cekilen_bilgileri_birlestir += "RENK:" + oku["renk"].ToString();
                }
                baglanti.Close();//VERİTABANI BAĞLANTISI KAPATILDI
                bilgi2_arac.Text = veritabanindan_cekilen_bilgileri_birlestir;//labelda gösterme
            }
            catch (Exception HATA)
            {
                baglanti.Close();//VERİTABANI BAĞLANTISI KAPATILDI
                MessageBox.Show(HATA.ToString() + "\nSİSTEM DIŞI HATA OLUŞMUŞTUR...", "KONTROL DIŞI HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);//HATA BİLGİSİ MESAJ PENCERESİ İLE KULLANICIYA GÖSTERİLDİ.
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            arac_penceresi arac_islemleri = new arac_penceresi();//TANIMLAMA
            arac_islemleri.ShowDialog();//ARAÇ İŞLEMLERİ PENCERESİNİ AÇMA
            AracPLAKAcekme();//EĞER BİR DEĞİŞİKLİK OLDU İSE VERİLERİ YENİLEME
        }

        private void iptal_et_btn_Click(object sender, EventArgs e)
        {
            this.Close();//PENCEREYİ KAPATMA
        }

        private void ekle_buton_Click(object sender, EventArgs e)
        {
            yer_kaydet();
        }
        private void yer_kaydet()//YER BİLGİLERİ EKLEME FOKSİYONU
        {
            try
            {
                baglanti.Open();//VERİTABANINA BAĞLANIR
                komut = new SqlCommand("insert into Arac_Giris_Cikis_Tablosu(yer_adi,arac_plaka,musteri_tc,giris_tarihi,arsiv) values('" + otopark_yeri_comboBox3.Text + "','" + arac_comboBox2.Text + "','" + musteri_comboBox1.Text + "','" + dateTimePicker1.Text + "',1)", baglanti);//YER VERİLERİNİ EKLER
                komut.ExecuteNonQuery();//SQL İFADELERİNİN ÇALIŞIR
                baglanti.Close();//VERİTABANI BAĞLANTISI KAPATILIR
                MessageBox.Show("OTOPARK YERİNE ARAÇ EKLENDI.", "OTOPARK EKLEME İŞLEMİ", MessageBoxButtons.OK, MessageBoxIcon.Information);//YER EKLENDİĞİ HAKKINDA BİLGİ VERİR.
            }
            catch (Exception)//HATA VARSA;
            {
                baglanti.Close();//VERİTABANI BAĞLANTISI KAPATILIR
                MessageBox.Show("HATA OLUŞTU\nSEBEP:\nBU T.C KİMLİK NONA AİT MÜŞTERİ OLABİLİR\nSİSTEMSEL HATALAR", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);//HATA HAKKINDA BİLGİ VERİRLİR.
            }
        }
    }
}
