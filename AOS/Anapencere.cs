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
    public partial class Anapencere : Form
    {
        public Anapencere()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(GirisPenceresi.globel_baglanti_adresi);//BAĞLANTI ADRESİ
        SqlDataAdapter Komutlar;//TABLO ÇEKMEK İÇİN KULLANILIR
        SqlCommand komut;//SQL İFADELERİ İÇİN KULLANILIR
        SqlDataReader oku;//ÇEKİLEN VERİLERİN ALANLARINA GÖRE TEKER TEKER OKUMA
        DataSet veriseti = new DataSet();//VERİ SETİDİR
        private void Anapencere_Load(object sender, EventArgs e)
        {
            tabloyu_getir();
            tabloyu_duzenle();
            yer_sayilari();
        }
        private void tabloyu_getir()
        {/*3 TABLO BİR BİRİNE BAĞLANIRARAK BİR TABLO OLUŞTURULMUŞTUR.*/
            veriseti.Clear();//TABLOLARI SİLER 
            try
            {
                baglanti.Open();//VERİTABANINA BAĞLANTI AÇILDI
                Komutlar = new SqlDataAdapter("select yer_adi,giris_tarihi,plaka,marka,model,tc,ad,soyad  from Arac_Giris_Cikis_Tablosu inner join Arac_Tablosu on Arac_Tablosu.plaka=Arac_Giris_Cikis_Tablosu.arac_plaka inner join Musteri_Tablosu on Musteri_Tablosu.tc=Arac_Giris_Cikis_Tablosu.musteri_tc where Arac_Giris_Cikis_Tablosu.arsiv=1", baglanti);//YERLERİ VE O YERE HANGİ ARAÇ VE KİŞİ KAYDETTİĞİ
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
            tablolari_listele_dgv.Columns["plaka"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;//OTOMATİK BOYUTLANDIRMA İŞLEMLERİ
            tablolari_listele_dgv.Columns["marka"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;//OTOMATİK BOYUTLANDIRMA İŞLEMLERİ
            tablolari_listele_dgv.Columns["model"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;//OTOMATİK BOYUTLANDIRMA İŞLEMLERİ
            tablolari_listele_dgv.Columns["tc"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;//OTOMATİK BOYUTLANDIRMA İŞLEMLERİ
            tablolari_listele_dgv.Columns["ad"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;//OTOMATİK BOYUTLANDIRMA İŞLEMLERİ
            tablolari_listele_dgv.Columns["soyad"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;//OTOMATİK BOYUTLANDIRMA İŞLEMLERİ


            tablolari_listele_dgv.Columns["yer_adi"].HeaderText = "YER ADI";//VERİTABANINDA GÖZÜKEN ALAN ADI DEĞİŞTİRİLİR.
            tablolari_listele_dgv.Columns["giris_tarihi"].HeaderText = "GİRİŞ ZAMANI";//VERİTABANINDA GÖZÜKEN ALAN ADI DEĞİŞTİRİLİR.
            tablolari_listele_dgv.Columns["plaka"].HeaderText = "PLAKA";//VERİTABANINDA GÖZÜKEN ALAN ADI DEĞİŞTİRİLİR.
            tablolari_listele_dgv.Columns["marka"].HeaderText = "MARKA";//VERİTABANINDA GÖZÜKEN ALAN ADI DEĞİŞTİRİLİR.
            tablolari_listele_dgv.Columns["model"].HeaderText = "MODEL";//VERİTABANINDA GÖZÜKEN ALAN ADI DEĞİŞTİRİLİR.
            tablolari_listele_dgv.Columns["tc"].HeaderText = "T.C NO";//VERİTABANINDA GÖZÜKEN ALAN ADI DEĞİŞTİRİLİR.
            tablolari_listele_dgv.Columns["ad"].HeaderText = "AD";//VERİTABANINDA GÖZÜKEN ALAN ADI DEĞİŞTİRİLİR.
            tablolari_listele_dgv.Columns["soyad"].HeaderText = "SOYAD";//VERİTABANINDA GÖZÜKEN ALAN ADI DEĞİŞTİRİLİR.
        }
        private void yer_sayilari()
        {
            dolu_yer_label.Text = "DOLU YER:" + (tablolari_listele_dgv.RowCount-1).ToString();
            bos_yer_label.Text = "BOŞ YER:" + (16-tablolari_listele_dgv.RowCount).ToString();
            toplam_yer_lable.Text = "TOPLAM YER:16";
        }

        private void musteri_buton_Click(object sender, EventArgs e)
        {
            musteri_penceresi musteri_islemleri = new musteri_penceresi();
            musteri_islemleri.ShowDialog();
        }

        private void arac_buton_Click(object sender, EventArgs e)
        {
            arac_penceresi arac_islemleri = new arac_penceresi();
            arac_islemleri.ShowDialog();
        }

        private void otopark_giris_buton_Click(object sender, EventArgs e)
        {
            Yer_Ekle_Penceresi otopark_giris_islemleri = new Yer_Ekle_Penceresi();
            otopark_giris_islemleri.ShowDialog();
            tabloyu_getir();
        }
        public static string yer_adi = "";
        private void otopark_cikis_buton_Click(object sender, EventArgs e)
        {
            //SEÇİLİ YERİ ÇIKARMA İŞLEMLERİ
            try
            {
                yer_adi = "";
                if (tablolari_listele_dgv.CurrentRow.Cells[0].Value.ToString() != "")
                {
                    yer_adi = tablolari_listele_dgv.CurrentRow.Cells[0].Value.ToString();
                    OtoparkCikisPenceresi Otopark_cikis_islmeleri = new OtoparkCikisPenceresi();
                    Otopark_cikis_islmeleri.ShowDialog();
                    tabloyu_getir();
                }
                else
                {
                    MessageBox.Show("YER SEÇİNİZ...", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("YER SEÇİNİZ...", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            
        }

        private void otopark_arsiv_buton_Click(object sender, EventArgs e)
        {
            OtoparkArsivi arsiv = new OtoparkArsivi();
            arsiv.ShowDialog();
        }

        private void istatistikler_buton_Click(object sender, EventArgs e)
        {
            istatistik_penceresi ist = new istatistik_penceresi();
            ist.ShowDialog();
        }

        private void kapatma_buton_Click(object sender, EventArgs e)
        {
            cikis_yap();
        }
        private void cikis_yap()
        {
            if (MessageBox.Show("ÇIKIŞ YAPILSIN MI ?", "SORU", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)//PENCERE KAPATILSIN MI 'EVET' İSE KAPATIYOR//PENCERE KAPATILSIN MI 'EVET' İSE KAPATIYOR
            {
                Application.Exit();//PROGRAM TAMAMEN KAPATILIR.
            }
        }

        private void ogreticiiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ÖĞRETİCİYE HOŞ GELDİNİZ\n\nMenülerin Kısa Yol Tuşları Nelerdir?\nMantığı soldan sağa doğrı f1-fx kadardır.\nYani 5 menu var ise f1,f2,f3,f4,f5'dir\nDikkat Pencere kapatma ve çıkma işlemleri CTRL+F4 iledir.", "ÖĞRETİCİ", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void Anapencere_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();//EĞER X TUŞUNDAN KAPATILIRSA ARKAPLANDA Kİ PROGRAMLARIDA KAPATMAYI SAĞLAR (SADECE ANAPENCERE İÇİNDİR.)
        }


    }
}
