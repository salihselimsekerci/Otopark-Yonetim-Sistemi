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
    public partial class musteri_penceresi : Form
    {
        public musteri_penceresi()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(GirisPenceresi.globel_baglanti_adresi);//BAĞLANTI ADRESİ
        SqlDataAdapter Komutlar;//TABLO ÇEKMEK İÇİN KULLANILIR
        SqlCommand komut;//SQL İFADELERİ İÇİN KULLANILIR
        SqlDataReader oku;//ÇEKİLEN VERİLERİN ALANLARINA GÖRE TEKER TEKER OKUMA
        DataSet veriseti = new DataSet();//VERİ SETİDİR
        private void _musteri_penceresi_Load(object sender, EventArgs e)
        {
            //MaxLength'ler ;veritabanında alanların karakter sayısıdır.sınırlamassak hata verir örnek tc-11 karakterli 12 giriş yapılmaması için maxkullanıldı.

            tcno_masked.MaxLength = 11;

            adi_textbox.MaxLength = soyadi_textbox.MaxLength = 20;
            telefon_maskedtextbox.MaxLength = 10;
            getir_buton.Enabled = false;

            cinsiyet_combobox.Items.Add("BAY");//cinsiyet seçim kutusu
            cinsiyet_combobox.Items.Add("BAYAN");//cinsiyet seçim kutusu
            cinsiyet_combobox.SelectedIndex = 0;//cinsiyet seçimi otomatik

            konu_combo.Items.Add("T.C KİMLİK NO");//arama konuları
            konu_combo.Items.Add("AD");//arama konuları
            konu_combo.Items.Add("SOYAD");//arama konuları
            konu_combo.SelectedIndex = 0;//arama konusu
            tabloyu_getir();
            tabloyu_duzenle();

            musteri_bilgileri_guncelle_buton.Enabled =musteriguncellemeToolStripMenuItem.Enabled= false;//KAPATILMA NEDENİ TC NUMARASI GİRİLDİKTEN SONRA İLK BİLGİLERİN GETİRİLMESİNİ SAĞLAMAK
        }
        private void tabloyu_getir()
        {
            veriseti.Clear();//TABLOLARI SİLER 
            try
            {
                baglanti.Open();//VERİTABANINA BAĞLANTI AÇILDI
                Komutlar = new SqlDataAdapter("select * from Musteri_Tablosu where arsiv=1", baglanti);//SİSTEMDE AKTİF OLAN MÜŞTERİLERNİN ÇAĞIRMA
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

        private void musteri_ekle_buton_Click(object sender, EventArgs e)
        {
            if (tcno_masked.Text != "" && tcno_masked.TextLength == 11)//TC KUTUSU BOŞ GEÇİLEMEZ VE 11 KARAKTER OLMALI
            {
                if (adi_textbox.Text != "" && soyadi_textbox.Text != "")//AD SOYAD BOŞ OLAMAZ
                {
                    musteriyi_kaydet();//YENİ MÜŞTERİ KAYDI FOKSİYONU
                    tabloyu_getir();//TABLOYU YENİDEN GETİRİR.(GÜNCELLEME İŞLEMİ)
                }
                else
                {
                    MessageBox.Show("AD VEYA SOYAD KUTULARI BOŞ GEÇİLEMEZ...", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);//HATALI GİRİŞTE VERİLEN UYARI MESAJI
                }

            }
            else
            {
                MessageBox.Show("T.C KİMLİK NO BOŞ GEÇİLEMEZ VEYA TC EKSİK GİRİLMİŞ OLABİLİR...", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);//HATALI GİRİŞTE VERİLEN UYARI MESAJI
            }
        }
        private void musteriyi_kaydet()//MÜŞTERİ BİLGİLERİ EKLEME FOKSİYONU
        {
            try
            {
                baglanti.Open();//VERİTABANINA BAĞLANIR
                komut = new SqlCommand("insert into Musteri_Tablosu values('" + tcno_masked.Text + "','" + adi_textbox.Text + "','" + soyadi_textbox.Text + "','" + cinsiyet_combobox.Text + "','" + telefon_maskedtextbox.Text + "',1)", baglanti);//MÜŞTERİ VERİ KAYDI
                komut.ExecuteNonQuery();//SQL İFADELERİNİN ÇALIŞIR
                baglanti.Close();//VERİTABANI BAĞLANTISI KAPATILIR
                MessageBox.Show("MÜŞTERİNİN T.C KİMLİK NO:" + tcno_masked.Text + "\nMÜŞTERİNİN ADI SOYADI:" + adi_textbox.Text + " " + soyadi_textbox.Text + "\nMÜŞTERİ SİSTEME EKLENDI.", "MÜŞTERİ EKLEME İŞLEMİ", MessageBoxButtons.OK, MessageBoxIcon.Information);//MÜŞTERİ EKLENDİĞİ HAKKINDA BİLGİ VERİR.
            }
            catch (Exception)//HATA VARSA;
            {
                baglanti.Close();//VERİTABANI BAĞLANTISI KAPATILIR
                MessageBox.Show("HATA OLUŞTU\nSEBEP:\nBU T.C KİMLİK NONA AİT MÜŞTERİ OLABİLİR\nSİSTEMSEL HATALAR", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);//HATA HAKKINDA BİLGİ VERİRLİR.
            }
        }
        bool sistemde_varmi = false;//KONTROL AMAÇLI OLUŞTURULAN BOOL VERİTİPİ TC KONTOLU İÇİN
        private void musteri_bilgileri_guncelle_buton_Click(object sender, EventArgs e)
        {
            if (tcno_masked.Text != "" && tcno_masked.TextLength == 11)//TC KUTUSU BOŞ GEÇİLEMEZ VE 11 KARAKTER OLMALI
            {
                if (sistemde_varmi == true)//T.C SİSTEMDE VAR MI KONTROLU 
                {
                    if (adi_textbox.Text != "" && soyadi_textbox.Text != "")//AD SOYAD BOŞ GEÇİLEMEZ
                    {
                        musteri_bilgilerini_guncelle();//MÜŞTERİ BİLGİLERİ GÜNCELLER
                        tabloyu_getir();//TABLOYU YENİLEME
                        musteri_bilgileri_guncelle_buton.Enabled = musteriguncellemeToolStripMenuItem.Enabled = false;//GÜNCELLEME İŞLEMİ YAPILDIKTAN SONRA KAPATILIR.
                    }
                    else
                    {
                        MessageBox.Show("AD VEYA SOYAD KUTULARI BOŞ GEÇİLEMEZ...", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);//HATALI GİRİŞTE VERİLEN UYARI MESAJI
                    }
                }
                else
                {
                    MessageBox.Show("GÜNCELLEMEK İSTEDİĞİNİZ T.C KİMLİK NOLU MÜŞTERİ BULUNAMADI...", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);//HATALI GİRİŞTE VERİLEN UYARI MESAJI
                }
            }
            else
            {
                MessageBox.Show("T.C KİMLİK NO BOŞ GEÇİLEMEZ VEYA TC EKSİK GİRİLMİŞ OLABİLİR...", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);//HATALI GİRİŞTE VERİLEN UYARI MESAJI
            }
        }
        private void musteri_bilgilerini_guncelle()//MÜŞTERİ BİLGİLERİ GÜNCELLEME FOKSİYONU
        {
            /*"GETİR BUTONUNA BASILDIKTAN SONRA BİLGİLER DEĞİŞTİRİLİR VE GÜNCELLEME İŞLEMİ YAPILIR."*/
            try
            {
                baglanti.Open();//VERİTABANINA BAĞLANIR
                komut = new SqlCommand("update Musteri_Tablosu set ad='" + adi_textbox.Text + "',soyad='" + soyadi_textbox.Text + "',cinsiyet='" + cinsiyet_combobox.Text + "',telefon='" + telefon_maskedtextbox.Text + "' where tc='" + tcno_masked.Text + "'", baglanti);//MÜŞTERİ BİLGİLERİNİ GÜNCELLEME FOKSİYONU
                komut.ExecuteNonQuery();//SQL İFADELERİNİN ÇALIŞIR
                baglanti.Close();//VERİTABANI BAĞLANTISI KAPATILIR
                MessageBox.Show("MÜŞTERİ T.C KİMLİK NO:" + tcno_masked.Text + "\nMÜŞTERİ ADI SOYADI:" + adi_textbox.Text + " " + soyadi_textbox.Text + "\nMÜŞTERİ BİLGİLERİ GÜNCELLENDİ.", "MÜŞTERİ GÜNCELLEME İŞLEMİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception HATA)//HATA VARSA;
            {
                baglanti.Close();//VERİTABANI BAĞLANTISI KAPATILIR
                MessageBox.Show("HATA OLUŞTU"+HATA, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);//HATA HAKKINDA BİLGİ VERİRLİR.
            }
        }

        private void tcno_masked_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            try
            {
                baglanti.Open();//VERİTABANINA BAĞLANTI
                komut = new SqlCommand("select tc from Musteri_Tablosu where tc='" + tcno_masked.Text + "'", baglanti);//BU T.C AİT VERİ VAR MI KONTROLU
                oku = komut.ExecuteReader();//KOMUTU ÇALIŞTIRMA VERİ ALMA
                if (oku.Read())//VERİ VAR İSE;
                {
                    sistemde_varmi = true;//BU T.C SİSTEMDE VAR DEMEK
                    getir_buton.Enabled = true;//EĞER SİSTEMDE VAR İSE BİLGİLERİ GETİREBİLMESİ İÇİN GEREKEN BUTONU AKTIFLEŞTİR.
                }
                else//VERİ YOK İSE;
                {
                    sistemde_varmi = false;//BU T.C SİSTEMDE YOK DEMEK
                    getir_buton.Enabled = false;//EĞER SİSTEMDE YOK İSE BİLGİLERİ GETİREBİLMESİ İÇİN GEREKEN BUTONU PASİFLEŞTİR.
                }
                baglanti.Close();//VERİTABANI BAĞLANTISI KAPATILDI
            }
            catch (Exception HATA)//HATA VARSA;
            {
                baglanti.Close();//VERİTABANI BAĞLANTISI KAPATILIR
                MessageBox.Show("HATA OLUŞTU" + HATA, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);//HATA HAKKINDA BİLGİ VERİRLİR.
            }
        }
        bool arsivden_cikar = false;
        private void getir_buton_Click(object sender, EventArgs e)
        {
            arsivden_cikan_bilgi_icin_tekrar_calistir://Goto KOMUTU YARDIMIYLA ARŞİVDEN ÇIKARILAN BİLGİLERİ TEKRAR KONTROL EDİP BİLGİLERİNİ NESNELERE EKLEMEYİ SAĞLAR.
            arsivden_cikar = false;
            try
            {
                baglanti.Open();//VERİTABANINA BAĞLANTI
                komut = new SqlCommand("select * from Musteri_Tablosu where tc='" + tcno_masked.Text + "'", baglanti);//T.C GÖRE ARAMA YAPAN KOMUT
                oku = komut.ExecuteReader();//KOMUTU ÇALIŞTIRMA
                if (oku.Read())//VERİ VAR İSE;
                {//VERİTABANINDAN BİLGİLERİ TEXTBOX VE COMBOBOXLARA GETİR.
                    if (Convert.ToInt32(oku["arsiv"])== 1)
                    {
                        adi_textbox.Text = oku["ad"].ToString();
                        soyadi_textbox.Text = oku["soyad"].ToString();
                        if (oku["cinsiyet"].ToString() == "BAY")
                        {
                            cinsiyet_combobox.SelectedIndex = 0;//BAY İSE 0
                        }
                        else
                        {
                            cinsiyet_combobox.SelectedIndex = 1;//BAYAN İSE 1
                        }
                        telefon_maskedtextbox.Text = oku["telefon"].ToString();
                        musteri_bilgileri_guncelle_buton.Enabled = musteriguncellemeToolStripMenuItem.Enabled = true;//GÜNCELLEME İŞLEMİ YAPILMASINI İZİN VERİLİR
                    }
                    else if (Convert.ToInt32(oku["arsiv"]) == 0)
                    {
                        if (MessageBox.Show("TC NO:" + tcno_masked.Text + " ARŞİVDE GÖZÜKMEKTEDİR ARŞİVDEN ÇIKARILSIN MI?", "SORU", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)//ARŞİVDEN ÇIKARMA İŞLEMLERİ
                        {
                            arsivden_cikar = true;
                            musteri_bilgileri_guncelle_buton.Enabled = musteriguncellemeToolStripMenuItem.Enabled = true;//GÜNCELLEME İŞLEMİ YAPILMASINI İZİN VERİLİR
                        }
                    }
                    else
                    {
                        musteri_bilgileri_guncelle_buton.Enabled = musteriguncellemeToolStripMenuItem.Enabled = false;//GÜNCELLEME İŞLEMİ KAPATILIR.
                    }

                }
                baglanti.Close();//VERİTABANI BAĞLANTISI KAPATILDI
                if (arsivden_cikar==true)
                {
                    baglanti.Open();//VERİTABANINA BAĞLANIR
                    komut = new SqlCommand("update Musteri_Tablosu set arsiv=1", baglanti);//MÜŞTERİYİ ARŞİVDEN ÇIKARIR.
                    komut.ExecuteNonQuery();//SQL İFADELERİNİN ÇALIŞIR
                    baglanti.Close();//VERİTABANI BAĞLANTISI KAPATILIR
                    tabloyu_getir();
                    goto arsivden_cikan_bilgi_icin_tekrar_calistir;
                }
            }
            catch (Exception HATA)//HATA VARSA;
            {
                baglanti.Close();//VERİTABANI BAĞLANTISI KAPATILIR
                MessageBox.Show("HATA OLUŞTU" + HATA, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);//HATA HAKKINDA BİLGİ VERİRLİR.
            }
        }

        private void musteri_cikar_buton_Click(object sender, EventArgs e)
        {/*ÇIKARMA İŞLEMLERİNDE HEM AKTİF HEM PASİF(ARŞİVDE) OLAN KİŞİLERİ YANI SİSTEMDE BULUNAN TÜM KİŞİLERİ SİLEBİLİRSİNİZ.*/
            if (tcno_masked.Text != "" && tcno_masked.TextLength == 11)//TC KUTUSU BOŞ GEÇİLEMEZ VE 11 KARAKTER OLMALI
            {
                if (sistemde_varmi == true)//SİSTEMDE VAR MI KONTROLU
                {
                    if (MessageBox.Show("MÜŞTERİ SİSTEMDEN ÇIKARILSIN MI ?", "SORU", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)//MÜŞTERİYİ ÇIKARMAK İSTEDİĞİNİZDEN EMİNMİSİNİZ KONTROLU CEVAP YES İSE;
                    {
                        musteri_cikar();//MÜŞTERİ ÇIKARMA FOKSİYONU
                    }
                }
                else
                {
                    MessageBox.Show("SİSTEMDE ÇIKARMAK İSTEDİĞİNİZ T.C KİMLİK NOLU MÜŞTERİ BULUNAMADI...", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);//HATALI GİRİŞTE VERİLEN UYARI MESAJI
                }
            }
            else
            {
                MessageBox.Show("SİSTEMDEN ÇIKARMAK İÇİN T.C KİMLİK NUMARASI GEREKMEKTEDİR...[T.C KUTUSUNU DOLDURUNUZ...]", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);//HATALI GİRİŞTE VERİLEN UYARI MESAJI
            }
        }
        private void musteri_cikar()//MÜŞTERİ ÇIKARMA FOKSİYONU
        {
            try
            {
                baglanti.Open();//VERİTABANINA BAĞLANIR
                komut = new SqlCommand("update Musteri_Tablosu set arsiv=0 where tc='" + tcno_masked.Text + "'", baglanti);//ÇIKARMA KOMUTU
                komut.ExecuteNonQuery();//SQL İFADELERİNİN ÇALIŞIR
                baglanti.Close();//VERİTABANI BAĞLANTISI KAPATILIR
                MessageBox.Show(tcno_masked.Text + " T.C KİMLİK NOLU MÜŞTERİ SİSTEMDEN ÇIKARILDI.", "MÜŞTERİ ÇIKARMA İŞLEMİ", MessageBoxButtons.OK, MessageBoxIcon.Information);//MÜŞTERİ SİLİNDİĞİNDE HAKKINDA BİLGİ VERİR.
                tabloyu_getir();//TABLOYU YENİLEME
            }
            catch (Exception HATA)//HATA VARSA;
            {
                baglanti.Close();//VERİTABANI BAĞLANTISI KAPATILIR
                MessageBox.Show("HATA OLUŞTU" + HATA, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);//HATA HAKKINDA BİLGİ VERİRLİR.
            }
        }

        private void pecereyi_kapat_buton_Click(object sender, EventArgs e)
        {
            this.Close();//PENCEREYİ KAPATMA KOMUTU
        }

        private void Arsiv_button_Click(object sender, EventArgs e)
        {
            MusteriArsiv Musteri_Arsiv_Penceresi = new MusteriArsiv();//ARŞİVE ULAŞMAK İÇİN TANIMLAMA
            Musteri_Arsiv_Penceresi.ShowDialog();//ARŞİVİ EK PENCERE OLARAK AÇMA(DİĞER PENCERELERDE İŞLEM YAPILMAZ.)
        }

        private void tumunu_goster_buton_Click(object sender, EventArgs e)
        {
            tabloyu_getir();//TABLOYU YENİLEME
        }

        private void arama_yap_buton_Click(object sender, EventArgs e)
        {
            if (arama_tb.Text != "")//ARAMA KONUSU BOŞ DEĞİLSE;
            {
                arama_yap();//ARAMA YAP
            }
            else
            {
                MessageBox.Show("ARAMA BİLGİSİ BULUNAMADI", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);//HATALI GİRİŞTE VERİLEN UYARI MESAJI
            }
        }
        private void arama_yap()
        {
            veriseti.Clear();//SAKLANAN ESKİ TABLOLAR SİLİNİR.
            baglanti.Open();//BAĞLANTIYI AÇAR
            if (konu_combo.Text == "T.C KİMLİK NO")//ARAMA KONUSU KONTROLU
            {
                Komutlar = new SqlDataAdapter("select * from Musteri_Tablosu where tc like '%" + arama_tb.Text + "%'", baglanti);//ARAMA KONUSUNA GÖRE ARAMA KOMUTU OLUŞTURUR
            }
            else if (konu_combo.Text == "AD")//ARAMA KONUSU KONTROLU
            {
                Komutlar = new SqlDataAdapter("select * from Musteri_Tablosu where ad like '%" + arama_tb.Text + "%'", baglanti);//ARAMA KONUSUNA GÖRE ARAMA KOMUTU OLUŞTURUR
            }
            else if (konu_combo.Text == "SOYAD")//ARAMA KONUSU KONTROLU
            {
                Komutlar = new SqlDataAdapter("select * from Musteri_Tablosu where soyad like '%" + arama_tb.Text + "%'", baglanti);//ARAMA KONUSUNA GÖRE ARAMA KOMUTU OLUŞTURUR
            }
            Komutlar.Fill(veriseti, "ogretmen_tablosu");//TABLOYU YÜKLER
            baglanti.Close();//BAĞLANTIYI KAPATIR
            tablolari_listele_dgv.DataSource = veriseti.Tables["ogretmen_tablosu"];//TABLOYU PENCEREDE GÖSTERİR
        }

        private void arama_tb_TextChanged(object sender, EventArgs e)
        {
            if (otomatik_arama_cb.Checked == true)//OTOMATİK ARAMA İŞARETLİ İSE;
            {
                arama_yap();//ARAMA YAPAR
            }
        }
    }
}
