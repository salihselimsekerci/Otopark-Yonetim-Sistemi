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
    public partial class OtoparkArsivi : Form
    {
        public OtoparkArsivi()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(GirisPenceresi.globel_baglanti_adresi);//BAĞLANTI ADRESİ
        SqlDataAdapter Komutlar;//TABLO ÇEKMEK İÇİN KULLANILIR
        SqlCommand komut;//SQL İFADELERİ İÇİN KULLANILIR
        SqlDataReader oku;//ÇEKİLEN VERİLERİN ALANLARINA GÖRE TEKER TEKER OKUMA
        DataSet veriseti = new DataSet();//VERİ SETİDİR
        private void OtoparkArsivi_Load(object sender, EventArgs e)
        {
            tabloyu_getir();
            tabloyu_duzenle();
        }
        private void tabloyu_getir()
        {/*3 TABLO BİR BİRİNE BAĞLANIRARAK BİR TABLO OLUŞTURULMUŞTUR.*/
            veriseti.Clear();//TABLOLARI SİLER 
            try
            {
                baglanti.Open();//VERİTABANINA BAĞLANTI AÇILDI
                Komutlar = new SqlDataAdapter("select yer_adi,giris_tarihi,cikis_tarihi,ucret,plaka,marka,model,kategori,renk,tc,ad,soyad,cinsiyet,telefon from Arac_Giris_Cikis_Tablosu inner join Arac_Tablosu on Arac_Tablosu.plaka=Arac_Giris_Cikis_Tablosu.arac_plaka inner join Musteri_Tablosu on Musteri_Tablosu.tc=Arac_Giris_Cikis_Tablosu.musteri_tc where Arac_Giris_Cikis_Tablosu.arsiv=0", baglanti);//YERLERİ VE O YERE HANGİ ARAÇ VE KİŞİ KAYDETTİĞİ
                Komutlar.Fill(veriseti, "Arac_Giris_Cikis_Tablosu");//TABLOYU SAKLAMA
                baglanti.Close();//VERİTABANI BAĞLANTISI KAPATILDI
                tablolari_listele_dgv.DataSource = veriseti.Tables["Arac_Giris_Cikis_Tablosu"];//SAKLANAN TABLOYU GÖSTERME
            }
            catch (Exception)
            {
                baglanti.Close();//VERİTABANI BAĞLANTISI KAPATILDI
            }
        }
        private void tabloyu_duzenle()
        {
            tablolari_listele_dgv.Columns["yer_adi"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;//OTOMATİK BOYUTLANDIRMA İŞLEMLERİ
            tablolari_listele_dgv.Columns["giris_tarihi"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;//OTOMATİK BOYUTLANDIRMA İŞLEMLERİ
            tablolari_listele_dgv.Columns["cikis_tarihi"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;//OTOMATİK BOYUTLANDIRMA İŞLEMLERİ
            tablolari_listele_dgv.Columns["ucret"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;//OTOMATİK BOYUTLANDIRMA İŞLEMLERİ
            tablolari_listele_dgv.Columns["plaka"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;//OTOMATİK BOYUTLANDIRMA İŞLEMLERİ
            tablolari_listele_dgv.Columns["marka"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;//OTOMATİK BOYUTLANDIRMA İŞLEMLERİ
            tablolari_listele_dgv.Columns["model"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;//OTOMATİK BOYUTLANDIRMA İŞLEMLERİ
            tablolari_listele_dgv.Columns["kategori"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;//OTOMATİK BOYUTLANDIRMA İŞLEMLERİ
            tablolari_listele_dgv.Columns["renk"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;//OTOMATİK BOYUTLANDIRMA İŞLEMLERİ
            tablolari_listele_dgv.Columns["tc"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;//OTOMATİK BOYUTLANDIRMA İŞLEMLERİ
            tablolari_listele_dgv.Columns["ad"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;//OTOMATİK BOYUTLANDIRMA İŞLEMLERİ
            tablolari_listele_dgv.Columns["soyad"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;//OTOMATİK BOYUTLANDIRMA İŞLEMLERİ
            tablolari_listele_dgv.Columns["cinsiyet"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;//OTOMATİK BOYUTLANDIRMA İŞLEMLERİ
            tablolari_listele_dgv.Columns["telefon"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;//OTOMATİK BOYUTLANDIRMA İŞLEMLERİ
           

            tablolari_listele_dgv.Columns["yer_adi"].HeaderText = "YER ADI";//VERİTABANINDA GÖZÜKEN ALAN ADI DEĞİŞTİRİLİR.
            tablolari_listele_dgv.Columns["giris_tarihi"].HeaderText = "GİRİŞ ZAMANI";//VERİTABANINDA GÖZÜKEN ALAN ADI DEĞİŞTİRİLİR.
            tablolari_listele_dgv.Columns["cikis_tarihi"].HeaderText = "ÇIKIŞ ZAMANI";//VERİTABANINDA GÖZÜKEN ALAN ADI DEĞİŞTİRİLİR.
            tablolari_listele_dgv.Columns["ucret"].HeaderText = "ÜCRET";//VERİTABANINDA GÖZÜKEN ALAN ADI DEĞİŞTİRİLİR.
            tablolari_listele_dgv.Columns["plaka"].HeaderText = "PLAKA";//VERİTABANINDA GÖZÜKEN ALAN ADI DEĞİŞTİRİLİR.
            tablolari_listele_dgv.Columns["marka"].HeaderText = "MARKA";//VERİTABANINDA GÖZÜKEN ALAN ADI DEĞİŞTİRİLİR.
            tablolari_listele_dgv.Columns["model"].HeaderText = "MODEL";//VERİTABANINDA GÖZÜKEN ALAN ADI DEĞİŞTİRİLİR.
            tablolari_listele_dgv.Columns["kategori"].HeaderText = "KATEGORİ";//VERİTABANINDA GÖZÜKEN ALAN ADI DEĞİŞTİRİLİR.
            tablolari_listele_dgv.Columns["renk"].HeaderText = "RENK";//VERİTABANINDA GÖZÜKEN ALAN ADI DEĞİŞTİRİLİR.
            tablolari_listele_dgv.Columns["tc"].HeaderText = "T.C NO";//VERİTABANINDA GÖZÜKEN ALAN ADI DEĞİŞTİRİLİR.
            tablolari_listele_dgv.Columns["ad"].HeaderText = "AD";//VERİTABANINDA GÖZÜKEN ALAN ADI DEĞİŞTİRİLİR.
            tablolari_listele_dgv.Columns["soyad"].HeaderText = "SOYAD";//VERİTABANINDA GÖZÜKEN ALAN ADI DEĞİŞTİRİLİR.
            tablolari_listele_dgv.Columns["cinsiyet"].HeaderText = "CİNSİYET";//VERİTABANINDA GÖZÜKEN ALAN ADI DEĞİŞTİRİLİR.
            tablolari_listele_dgv.Columns["telefon"].HeaderText = "TELEFON";//VERİTABANINDA GÖZÜKEN ALAN ADI DEĞİŞTİRİLİR.
        }
    }
}
