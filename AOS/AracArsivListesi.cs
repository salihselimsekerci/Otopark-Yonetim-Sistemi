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
    public partial class AracArsivListesi : Form
    {
        public AracArsivListesi()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(GirisPenceresi.globel_baglanti_adresi);//BAĞLANTI ADRESİ
        SqlDataAdapter Komutlar;//TABLO ÇEKMEK İÇİN KULLANILIR
        SqlCommand komut;//SQL İFADELERİ İÇİN KULLANILIR
        SqlDataReader oku;//ÇEKİLEN VERİLERİN ALANLARINA GÖRE TEKER TEKER OKUMA
        DataSet veriseti = new DataSet();//VERİ SETİDİR
        private void AracArsivListesi_Load(object sender, EventArgs e)
        {
            tabloyu_getir();
            tabloyu_duzenle();
        }
        private void tabloyu_getir()
        {
            veriseti.Clear();//TABLOLARI SİLER 
            try
            {
                baglanti.Open();//VERİTABANINA BAĞLANTI AÇILDI
                Komutlar = new SqlDataAdapter("select * from Arac_Tablosu where arsiv=0", baglanti);//SİSTEMDE AKTİF OLAN MÜŞTERİLERNİN ÇAĞIRMA
                Komutlar.Fill(veriseti, "Arac_Tablosu");//TABLOYU SAKLAMA
                baglanti.Close();//VERİTABANI BAĞLANTISI KAPATILDI
                tablolari_listele_dgv.DataSource = veriseti.Tables["Arac_Tablosu"];//SAKLANAN TABLOYU GÖSTERME
            }
            catch (Exception)
            {
                baglanti.Close();//VERİTABANI BAĞLANTISI KAPATILDI
            }
        }
        private void tabloyu_duzenle()
        {
            tablolari_listele_dgv.Columns["arsiv"].Visible = false;
            tablolari_listele_dgv.Columns["plaka"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;//OTOMATİK BOYUTLANDIRMA İŞLEMLERİ
            tablolari_listele_dgv.Columns["marka"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;//OTOMATİK BOYUTLANDIRMA İŞLEMLERİ
            tablolari_listele_dgv.Columns["model"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;//OTOMATİK BOYUTLANDIRMA İŞLEMLERİ
            tablolari_listele_dgv.Columns["kategori"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;//OTOMATİK BOYUTLANDIRMA İŞLEMLERİ
            tablolari_listele_dgv.Columns["renk"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;//OTOMATİK BOYUTLANDIRMA İŞLEMLERİ


            tablolari_listele_dgv.Columns["plaka"].HeaderText = "PLAKA NUMARASI";//VERİTABANINDA GÖZÜKEN ALAN ADI DEĞİŞTİRİLİR.
            tablolari_listele_dgv.Columns["marka"].HeaderText = "MARKA";//VERİTABANINDA GÖZÜKEN ALAN ADI DEĞİŞ
            tablolari_listele_dgv.Columns["model"].HeaderText = "MODEL";//VERİTABANINDA GÖZÜKEN ALAN ADI DEĞİŞTİRİLİR
            tablolari_listele_dgv.Columns["kategori"].HeaderText = "KATEGORİ";//VERİTABANINDA GÖZÜKEN ALAN ADI DEĞİŞTİRİLİR
            tablolari_listele_dgv.Columns["renk"].HeaderText = "RENK";//VERİTABANINDA GÖZÜKEN ALAN ADI DEĞİŞTİRİLİR.
        }

    }
}
