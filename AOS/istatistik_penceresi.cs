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
    public partial class istatistik_penceresi : Form
    {
        public istatistik_penceresi()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(GirisPenceresi.globel_baglanti_adresi);//BAĞLANTI ADRESİ
        SqlDataAdapter Komutlar;//TABLO ÇEKMEK İÇİN KULLANILIR
        SqlCommand komut;//SQL İFADELERİ İÇİN KULLANILIR
        SqlDataReader oku;//ÇEKİLEN VERİLERİN ALANLARINA GÖRE TEKER TEKER OKUMA
        private void istatistik_penceresi_Load(object sender, EventArgs e)
        {
            /*BU İŞLEMLER TAMAMEN GİRİŞ ÇIKIŞ İŞLEMİ YAPILMIŞ ARAÇLAR ÜZERİNDE GERÇEKLEŞİR.*/
            konu_cb.Items.Add("TOPLAM YAPILMIŞ GİRİŞ ÇIKIŞ İŞLEMLERİ SAYISI");//GENEL BİLGİ
            konu_cb.Items.Add("TOPLAM YAPILMIŞ GİRİŞ ÇIKIŞ İŞLEMLERİ ÜCRETİ");//GENEL BİLGİ
            konu_cb.Items.Add("EN ÇOK FARK EDİLEN YER İSMİ");//BU BİLGİ BU ALANA DAHA FAZLA BAKIM YAPILMASI AMACIYLA YAZILDI
            konu_cb.Items.Add("EN FAZLA PARK EDEN ARAÇIN BİLGİLERİ");//EN FAZLA GİRİŞ ÇIKIŞ BİLGİSİ
            konu_cb.Items.Add("EN FAZLA PARK EDEN MÜŞTERİ BİLGİLERİ");//MÜŞTERİYİ BİLGİ VERMEK AMACIYLA :)
  

        }

        private void sorgu_buton_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();//VERİTABANINA BAĞLANTI AÇILDI
                if (konu_cb.SelectedIndex == 0)//TOPLAM YAPILMIŞ GİRİŞ ÇIKIŞ İŞLEMLERİ SAYISI
                {
                    komut = new SqlCommand("select COUNT(*) as 'giris_cikis_sayisi' from Arac_Giris_Cikis_Tablosu inner join Arac_Tablosu on Arac_Tablosu.plaka=Arac_Giris_Cikis_Tablosu.arac_plaka inner join Musteri_Tablosu on Musteri_Tablosu.tc=Arac_Giris_Cikis_Tablosu.musteri_tc where Arac_Giris_Cikis_Tablosu.arsiv=0", baglanti);//İST BİLGİLERİ
                }
                else if (konu_cb.SelectedIndex == 1)//TOPLAM YAPILMIŞ GİRİŞ ÇIKIŞ İŞLEMLERİ ÜCRETİ
                {
                    komut = new SqlCommand("select sum(ucret) as 'totalucret' from Arac_Giris_Cikis_Tablosu inner join Arac_Tablosu on Arac_Tablosu.plaka=Arac_Giris_Cikis_Tablosu.arac_plaka inner join Musteri_Tablosu on Musteri_Tablosu.tc=Arac_Giris_Cikis_Tablosu.musteri_tc where Arac_Giris_Cikis_Tablosu.arsiv=0", baglanti);//İST BİLGİLERİ
                }
                else if (konu_cb.SelectedIndex == 2)//EN ÇOK FARK EDİLEN YER İSMİ
                {
                    komut = new SqlCommand("SELECT top 1 yer_adi from Arac_Giris_Cikis_Tablosu where arsiv=0 group by yer_adi", baglanti);//İST BİLGİLERİ
                }
                else if (konu_cb.SelectedIndex == 3)//EN FAZLA PARK EDEN ARAÇIN BİLGİLERİ
                {
                    komut = new SqlCommand("select * from Arac_Tablosu where plaka in (SELECT top 1 arac_plaka from Arac_Giris_Cikis_Tablosu  where arsiv=0 group by arac_plaka)", baglanti);//İST BİLGİLERİ
                }
                else if (konu_cb.SelectedIndex == 4)//EN FAZLA PARK EDEN MÜŞTERİ BİLGİLERİ
                {
                    komut = new SqlCommand("select * from Musteri_Tablosu where tc=(SELECT top 1 musteri_tc from Arac_Giris_Cikis_Tablosu  where arsiv=0 group by musteri_tc)", baglanti);//İST BİLGİLERİ
                }
                
                oku = komut.ExecuteReader();//KOMUTLARI ÇALIŞTIRIP VERİLERİ SAKLADIĞIMIZ KOMUT
                if (oku.Read())//OKUMA
                {
                    if (konu_cb.SelectedIndex == 0)//TOPLAM YAPILMIŞ GİRİŞ ÇIKIŞ İŞLEMLERİ SAYISI
                    {
                        sonuc_label.Text = "TOPLAM OTOPARK GİRİŞ-ÇIKIŞI SAYISI:"+oku["giris_cikis_sayisi"].ToString();
                    }
                    else if (konu_cb.SelectedIndex == 1)//TOPLAM YAPILMIŞ GİRİŞ ÇIKIŞ İŞLEMLERİ ÜCRETİ
                    {
                        sonuc_label.Text = "TOPLAM OTOPARK GİRİŞ-ÇIKIŞI ÜCRETİ:" + oku["totalucret"].ToString();
                    }
                    else if (konu_cb.SelectedIndex == 2)//EN ÇOK FARK EDİLEN YER İSMİ
                    {
                        sonuc_label.Text = "EN ÇOK FARK EDİLEN YER İSMİ:" + oku["yer_adi"].ToString();
                    }
                    else if (konu_cb.SelectedIndex == 3)//EN FAZLA PARK EDEN ARAÇIN BİLGİLERİ
                    {
                        sonuc_label.Text = "PLAKA/MARKA/MODEL/KATEGORİ/RENK:" + oku["plaka"].ToString() + "/" + oku["marka"].ToString() + "/" + oku["model"].ToString() + "/" + oku["kategori"].ToString() + "/" + oku["renk"].ToString();
                    }
                    else if (konu_cb.SelectedIndex == 4)//EN FAZLA PARK EDEN MÜŞTERİ BİLGİLERİ
                    {
                        sonuc_label.Text = "TC/AD/SOYAD/CİNSİYET/TELEFON:" + oku["tc"].ToString() + "/" + oku["ad"].ToString() + "/" + oku["soyad"].ToString() + "/" + oku["cinsiyet"].ToString() + "/" + oku["telefon"].ToString();
                    }

                }
                baglanti.Close();//VERİTABANI BAĞLANTISI KAPATILDI
            }
            catch (Exception HATA)
            {
                baglanti.Close();//VERİTABANI BAĞLANTISI KAPATILDI
                MessageBox.Show(HATA.ToString() + "\nSİSTEM DIŞI HATA OLUŞMUŞTUR...", "KONTROL DIŞI HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);//HATA BİLGİSİ MESAJ PENCERESİ İLE KULLANICIYA GÖSTERİLDİ.
            }
           
        }
    }
}
