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
    public partial class MusteriArsiv : Form
    {
        public MusteriArsiv()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(GirisPenceresi.globel_baglanti_adresi);//BAĞLANTI ADRESİ
        SqlDataAdapter Komutlar;//tablolari çekmek için kullanılıyor
        SqlCommand komut;//sql ifadeleri özellikle insert,delete,update vss...
        SqlDataReader oku;//çekilen verileri teker teker okumamızı sağlar
        DataSet veriseti = new DataSet();//VERİSETİ
        private void MusteriArsiv_Load(object sender, EventArgs e)
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
                Komutlar = new SqlDataAdapter("select * from Musteri_Tablosu where arsiv=0", baglanti);//SİSTEMDE AKTİF OLAN MÜŞTERİLERNİN ÇAĞIRMA
                Komutlar.Fill(veriseti, "Musteri_Tablosu");//TABLOYU SAKLAMA
                baglanti.Close();//VERİTABANI BAĞLANTISI KAPATILDI
                tablolari_listele_dgv.DataSource = veriseti.Tables["Musteri_Tablosu"];//SAKLANAN TABLOYU GÖSTERME
            }
            catch (Exception)
            {
                baglanti.Close();//VERİTABANI BAĞLANTISI KAPATILDI
            }
        }
        private void tabloyu_duzenle()
        {
            tablolari_listele_dgv.Columns["arsiv"].Visible = false;
            tablolari_listele_dgv.Columns["tc"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;//OTOMATİK BOYUTLANDIRMA İŞLEMLERİ
            tablolari_listele_dgv.Columns["ad"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;//OTOMATİK BOYUTLANDIRMA İŞLEMLERİ
            tablolari_listele_dgv.Columns["soyad"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;//OTOMATİK BOYUTLANDIRMA İŞLEMLERİ
            tablolari_listele_dgv.Columns["cinsiyet"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;//OTOMATİK BOYUTLANDIRMA İŞLEMLERİ
            tablolari_listele_dgv.Columns["telefon"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;//OTOMATİK BOYUTLANDIRMA İŞLEMLERİ


            tablolari_listele_dgv.Columns["tc"].HeaderText = "T.C NO";//VERİTABANINDA GÖZÜKEN ALAN ADI DEĞİŞTİRİLİR.
            tablolari_listele_dgv.Columns["ad"].HeaderText = "AD";//VERİTABANINDA GÖZÜKEN ALAN ADI DEĞİŞ
            tablolari_listele_dgv.Columns["soyad"].HeaderText = "SOYAD";//VERİTABANINDA GÖZÜKEN ALAN ADI DEĞİŞTİRİLİR
            tablolari_listele_dgv.Columns["cinsiyet"].HeaderText = "CİNSİYET";//VERİTABANINDA GÖZÜKEN ALAN ADI DEĞİŞTİRİLİR
            tablolari_listele_dgv.Columns["telefon"].HeaderText = "TELEFON";//VERİTABANINDA GÖZÜKEN ALAN ADI DEĞİŞTİRİLİR.
        }
    }
}
