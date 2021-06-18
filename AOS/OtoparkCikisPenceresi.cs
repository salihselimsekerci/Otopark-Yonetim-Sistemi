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
    public partial class OtoparkCikisPenceresi : Form
    {
        public OtoparkCikisPenceresi()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(GirisPenceresi.globel_baglanti_adresi);//BAĞLANTI ADRESİ
        SqlDataAdapter Komutlar;//TABLO ÇEKMEK İÇİN KULLANILIR
        SqlCommand komut;//SQL İFADELERİ İÇİN KULLANILIR
        SqlDataReader oku;//ÇEKİLEN VERİLERİN ALANLARINA GÖRE TEKER TEKER OKUMA
        DataSet veriseti = new DataSet();//TABLO SAKLAMA
        private void OtoparkCikisPenceresi_Load(object sender, EventArgs e)
        {
            verileri_getir();
            hesapla();
        }
        string bilgileri_birlestir = "";
        DateTime bTarih;
        private void verileri_getir()
        {
            bilgileri_birlestir = "";
            try
            {
                baglanti.Open();//VERİTABANINA BAĞLANTI
                komut = new SqlCommand("select yer_adi,giris_tarihi,plaka,marka,model,tc,ad,soyad from Arac_Giris_Cikis_Tablosu inner join Arac_Tablosu on Arac_Tablosu.plaka=Arac_Giris_Cikis_Tablosu.arac_plaka inner join Musteri_Tablosu on Musteri_Tablosu.tc=Arac_Giris_Cikis_Tablosu.musteri_tc where yer_adi='" + Anapencere.yer_adi + "' and Arac_Giris_Cikis_Tablosu.arsiv=1", baglanti);//YERE GÖRE TÜM BİLGİLERİ GETİRİR
                oku = komut.ExecuteReader();//KOMUTU ÇALIŞTIRMA
                if (oku.Read())//VERİ VAR İSE;
                {
                    bTarih = Convert.ToDateTime(oku["giris_tarihi"].ToString());
                    bilgileri_birlestir += "YER:"+oku["yer_adi"].ToString() + "\n";
                    bilgileri_birlestir += "Giriş Saati:"+oku["giris_tarihi"].ToString() + "\n";
                    bilgileri_birlestir += "Plaka No:"+oku["plaka"].ToString() + "\n";
                    bilgileri_birlestir += "Marka/Model:"+oku["marka"].ToString() +"/"+ oku["model"].ToString()+"\n";
                    bilgileri_birlestir += "TC/AD/SOYAD:" + oku["tc"].ToString() +"/"+ oku["ad"].ToString() +"/"+ oku["soyad"].ToString(); 
                }
                baglanti.Close();//VERİTABANI BAĞLANTISI KAPATILDI
                bilgi.Text = bilgileri_birlestir;
            }
            catch (Exception HATA)//HATA VARSA;
            {
                baglanti.Close();//VERİTABANI BAĞLANTISI KAPATILIR
                MessageBox.Show("HATA OLUŞTU" + HATA, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);//HATA HAKKINDA BİLGİ VERİRLİR.
            }
        }
        private void hesapla()
        {
            /*
             SÜRE MANTIĞI
             Otoparka giriş yaptıktan sonra kesin ödenecek miktar 12 liradir.
             * 0-1-- >12lira
             * 1-2-->22 lira
             * 2-3-->33 lira
             * 3-4'saatten sonra 42 lira
             4'saatten sonra ise 50 liara
             */
            try
            {
                TimeSpan Sonuc = Convert.ToDateTime(dateTimePicker1.Text) - bTarih;
                sure_tb.Text = Convert.ToInt32(Sonuc.TotalHours).ToString();
                if (Convert.ToInt32(sure_tb.Text) >= 0 && Convert.ToInt32(sure_tb.Text) <= 1)
                {
                    ucret_tb.Text = "12";
                }
                else if (Convert.ToInt32(sure_tb.Text) > 1 && Convert.ToInt32(sure_tb.Text) <= 2)
                {
                    ucret_tb.Text = "22";
                }
                else if (Convert.ToInt32(sure_tb.Text) > 2 && Convert.ToInt32(sure_tb.Text) <= 3)
                {
                    ucret_tb.Text = "33";
                }
                else if (Convert.ToInt32(sure_tb.Text) > 3 && Convert.ToInt32(sure_tb.Text) <= 4)
                {
                    ucret_tb.Text = "42";
                }
                else if (Convert.ToInt32(sure_tb.Text) > 4)
                {
                    ucret_tb.Text = "50";
                }
            }
            catch (Exception)
            {
            }
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            hesapla();
        }

        private void Cikar_buton_Click(object sender, EventArgs e)
        {
            if (ucret_tb.Text != "" && sure_tb.Text != "")//AD SOYAD BOŞ GEÇİLEMEZ
            {
                otoparktan_cikar();//MÜŞTERİ BİLGİLERİ GÜNCELLER
                this.Close();//PENCEREYİ KAPATIR TEK İŞLEM YAPILMASINI İZİN VERMEK İÇİN
            }
            else
            {
                MessageBox.Show("ÜCRET VEYA SÜRE BOŞ GEÇİLEMEZ...", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);//HATALI GİRİŞTE VERİLEN UYARI MESAJI
            }
        }
        private void otoparktan_cikar()//OTOPARK ÇIKIŞI
        {
            /*"GETİR BUTONUNA BASILDIKTAN SONRA BİLGİLER DEĞİŞTİRİLİR VE GÜNCELLEME İŞLEMİ YAPILIR."*/
            try
            {
                baglanti.Open();//VERİTABANINA BAĞLANIR
                komut = new SqlCommand("update Arac_Giris_Cikis_Tablosu set cikis_tarihi='" + dateTimePicker1.Text + "',ucret=" + ucret_tb.Text + ",arsiv=0 where yer_adi='" + Anapencere.yer_adi + "' and arsiv=1", baglanti);//ÇIKIŞ İŞLEMLERİ
                komut.ExecuteNonQuery();//SQL İFADELERİNİN ÇALIŞIR
                baglanti.Close();//VERİTABANI BAĞLANTISI KAPATILIR
                MessageBox.Show("OTOPARK ÇIKIŞ YAPILDI.", "OTOPARK İŞLEMİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception HATA)//HATA VARSA;
            {
                baglanti.Close();//VERİTABANI BAĞLANTISI KAPATILIR
                MessageBox.Show("HATA OLUŞTU" + HATA, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);//HATA HAKKINDA BİLGİ VERİRLİR.
            }
        }

        private void iptal_et_btn_Click(object sender, EventArgs e)
        {
            this.Close();//PENCEREYİ KAPATIR.
        }
    }
}
