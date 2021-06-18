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
    public partial class arac_penceresi : Form
    {
        public arac_penceresi()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(GirisPenceresi.globel_baglanti_adresi);//BAĞLANTI ADRESİ
        SqlDataAdapter Komutlar;//TABLO ÇEKMEK İÇİN KULLANILIR
        SqlCommand komut;//SQL İFADELERİ İÇİN KULLANILIR
        SqlDataReader oku;//ÇEKİLEN VERİLERİN ALANLARINA GÖRE TEKER TEKER OKUMA
        DataSet veriseti = new DataSet();//VERİ SETİDİR
        private void aracpenceresi_Load(object sender, EventArgs e)
        {
            //MaxLength'ler ;veritabanında alanların karakter sayısıdır.sınırlamassak hata verir örnek tc-11 karakterli 12 giriş yapılmaması için maxkullanıldı.
            //ÖRNEK MARKALAR
            //Markalar
            marka_combo.Items.Add("Audi");//A1 A3 A4	A5 A6 A7 A8 R8 RS MODELLER
            marka_combo.Items.Add("BMW");// 116d 116i 118d	118i 120d 218i 220d MODELLER
            marka_combo.Items.Add("Ferrari");// 348  360 430 458 612 California F355 MODELLER
            marka_combo.Items.Add("Fiat");//Albea 500-Ailesi Bravo Croma Palio Panda MODELLER

            //Katagori ekleme
            kategori_combo.Items.Add("Otomobil");
            kategori_combo.Items.Add("Taksi");
            kategori_combo.Items.Add("Minibüs");
            kategori_combo.Items.Add("Çekici");
            kategori_combo.Items.Add("Motosiklet");
            //Renkler ekleme
            renk_combo.Items.Add("Beyaz");
            renk_combo.Items.Add("Siyah");
            renk_combo.Items.Add("Lacivert");
            renk_combo.Items.Add("Turuncu");
            renk_combo.Items.Add("Kırmızı");
            renk_combo.Items.Add("Yeşil");
            renk_combo.Items.Add("Sarı");
            renk_combo.Items.Add("Gri");
            model_combo.SelectedIndex = marka_combo.SelectedIndex = kategori_combo.SelectedIndex = renk_combo.SelectedIndex = 0;//SEÇİM KUTUSUNDAKİ 1.SIRADAKI VERİYİ SEÇME 

            plaka_no_tb.MaxLength = 15;//PLAKA BİLGİSİNİN EN FAZLA ALACAĞI DEĞER VERİTABANINDAN KAYNAKLI.

            getir_buton.Enabled = false;//PLAKA KONTROL


            konu_combo.Items.Add("PLAKA NO");//arama konuları
            konu_combo.Items.Add("MARKA");//arama konuları
            konu_combo.Items.Add("MODEL");//arama konuları
            konu_combo.Items.Add("RENK");//arama konuları
            konu_combo.SelectedIndex = 0;//arama konusu

            arac_bilgileri_guncelle_buton.Enabled =arac_guncelleToolStripMenuItem.Enabled= false;//KAPATILMA NEDENİ PLAKA NUMARASI GİRİLDİKTEN SONRA İLK BİLGİLERİN GETİRİLMESİNİ SAĞLAMAK
            tabloyu_getir();
            tabloyu_duzenle();
        }
        private void tabloyu_getir()
        {
            veriseti.Clear();//TABLOLARI SİLER 
            try
            {
                baglanti.Open();//VERİTABANINA BAĞLANTI AÇILDI
                Komutlar = new SqlDataAdapter("select * from Arac_Tablosu where arsiv=1", baglanti);//SİSTEMDE AKTİF OLAN MÜŞTERİLERNİN ÇAĞIRMA
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

        private void marka_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MARKA COMBOBOXİN İÇİNDEN SEÇİM YAPILDIĞINDA ÇALIŞIR
            model_combo.Items.Clear();//TÜM MODELLER SİLİNİR
            if (marka_combo.Text == "Audi")//EĞER AUDİ İSE AUDİ AİT MODELLER EKLENİR
            {
                //MODEL EKLEME
                model_combo.Items.Add("A1");
                model_combo.Items.Add("A3");
                model_combo.Items.Add("A4");
                model_combo.Items.Add("A5");
                model_combo.Items.Add("A6");
                model_combo.Items.Add("A7");
                model_combo.Items.Add("A8");
                model_combo.Items.Add("R8");
                model_combo.Items.Add("RS");
            }
            else if (marka_combo.Text == "BMW")//EĞER BMW İSE BMW AİT MODELLER EKLENİR
            {
                //MODEL EKLEME
                model_combo.Items.Add("116d");
                model_combo.Items.Add("116i");
                model_combo.Items.Add("118d");
                model_combo.Items.Add("118i");
                model_combo.Items.Add("120d");
                model_combo.Items.Add("218i");
                model_combo.Items.Add("220d");
            }
            else if (marka_combo.Text == "Ferrari")//EĞER Ferrari İSE Ferrari AİT MODELLER EKLENİR
            {
                //MODEL EKLEME
                model_combo.Items.Add("348");
                model_combo.Items.Add("360");
                model_combo.Items.Add("430");
                model_combo.Items.Add("458");
                model_combo.Items.Add("612");
                model_combo.Items.Add("California");
                model_combo.Items.Add("F355");
            }
            else if (marka_combo.Text == "Fiat")//EĞER Fiat İSE Fiat AİT MODELLER EKLENİR
            {
                //MODEL EKLEME
                model_combo.Items.Add("Albea");
                model_combo.Items.Add("500-Ailesi");
                model_combo.Items.Add("Bravo");
                model_combo.Items.Add("Croma");
                model_combo.Items.Add("Panda");
                model_combo.Items.Add("Palio");
            }
            model_combo.SelectedIndex = 0;
        }

        private void arac_ekle_buton_Click(object sender, EventArgs e)
        {
            if (plaka_no_tb.Text != "" && plaka_no_tb.TextLength > 5)//PLAKA NUMARASI KONTROL
            {
                araci_kaydet();//YENİ ARAÇ KAYDI FOKSİYONU
                tabloyu_getir();//TABLOYU YENİDEN GETİRİR.(GÜNCELLEME İŞLEMİ)
            }
            else
            {
                MessageBox.Show("PLAKA EKSİK VEYA BOŞ GEÇİLEMEZ...", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);//HATALI GİRİŞTE VERİLEN UYARI MESAJI
            }
        }
        private void araci_kaydet()//ARAÇ BİLGİLERİ EKLEME FOKSİYONU
        {
            try
            {
                baglanti.Open();//VERİTABANINA BAĞLANIR
                komut = new SqlCommand("insert into Arac_Tablosu values('" + plaka_no_tb.Text + "','" + marka_combo.Text + "','" + model_combo.Text + "','" + kategori_combo.Text + "','" + renk_combo.Text + "',1)", baglanti);//ARAÇ VERİ KAYDI
                komut.ExecuteNonQuery();//SQL İFADELERİNİN ÇALIŞIR
                baglanti.Close();//VERİTABANI BAĞLANTISI KAPATILIR
                tabloyu_getir();
                MessageBox.Show(plaka_no_tb.Text + "\n NUMARALI ARAÇ SİSTEME EKLENDI.", "ARAÇ EKLEME İŞLEMİ", MessageBoxButtons.OK, MessageBoxIcon.Information);//ARAÇ EKLENDİĞİ HAKKINDA BİLGİ VERİR.
            }
            catch (Exception)//HATA VARSA;
            {
                baglanti.Close();//VERİTABANI BAĞLANTISI KAPATILIR
                MessageBox.Show("HATA OLUŞTU\nSEBEP(LER):\n-PLAKA NUMARASI SİSTEMDE VARDIR.\n-SİSTEMDEN HATA", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);//HATA HAKKINDA BİLGİ VERİRLİR.
            }
        }
        bool sistemde_varmi = false;//KONTROL AMAÇLI OLUŞTURULAN BOOL VERİTİPİ PLAKA KONTOLU İÇİN
        private void plaka_no_tb_TextChanged(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();//VERİTABANINA BAĞLANTI
                komut = new SqlCommand("select plaka from Arac_Tablosu where plaka='" + plaka_no_tb.Text + "'", baglanti);//BU PLAKAYA AİT VERİ VAR MI KONTROLU
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
        bool arsivden_cikar = false;//ARŞİVDE Kİ ARAÇLAR İÇİN KULLANILIR
        private void getir_buton_Click(object sender, EventArgs e)
        {
        arsivden_cikan_bilgi_icin_tekrar_calistir://Goto KOMUTU YARDIMIYLA ARŞİVDEN ÇIKARILAN BİLGİLERİ TEKRAR KONTROL EDİP BİLGİLERİNİ NESNELERE EKLEMEYİ SAĞLAR.
            arsivden_cikar = false;
            try
            {
                baglanti.Open();//VERİTABANINA BAĞLANTI
                komut = new SqlCommand("select * from Arac_Tablosu where plaka='" + plaka_no_tb.Text + "'", baglanti);//PLAKAYA GÖRE ARAMA YAPAN KOMUT
                oku = komut.ExecuteReader();//KOMUTU ÇALIŞTIRMA
                if (oku.Read())//VERİ VAR İSE;
                {//VERİTABANINDAN BİLGİLERİ TEXTBOX VE COMBOBOXLARA GETİR.
                    if (Convert.ToInt32(oku["arsiv"]) == 1)
                    {
                        marka_combo.SelectedIndex = marka_combo.Items.IndexOf(oku["marka"].ToString());//GETİREN BİLGİYİ KAÇINDI İNDEXTE OLDUĞUNU BULUP SELECTEDİNDEX İLE SEÇİYORUZ.
                        model_combo.SelectedIndex = model_combo.Items.IndexOf(oku["model"].ToString());//GETİREN BİLGİYİ KAÇINDI İNDEXTE OLDUĞUNU BULUP SELECTEDİNDEX İLE SEÇİYORUZ.
                        kategori_combo.SelectedIndex = kategori_combo.Items.IndexOf(oku["kategori"].ToString());//GETİREN BİLGİYİ KAÇINDI İNDEXTE OLDUĞUNU BULUP SELECTEDİNDEX İLE SEÇİYORUZ.
                        renk_combo.SelectedIndex = renk_combo.Items.IndexOf(oku["renk"].ToString());//GETİREN BİLGİYİ KAÇINDI İNDEXTE OLDUĞUNU BULUP SELECTEDİNDEX İLE SEÇİYORUZ.
                        arac_bilgileri_guncelle_buton.Enabled = arac_guncelleToolStripMenuItem.Enabled = true;//GÜNCELLEME İŞLEMİ YAPILMASINI İZİN VERİLİR
                    }
                    else if (Convert.ToInt32(oku["arsiv"]) == 0)
                    {
                        if (MessageBox.Show("PLAKA:" + plaka_no_tb.Text + " ARŞİVDE GÖZÜKMEKTEDİR ARŞİVDEN ÇIKARILSIN MI?", "SORU", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)//ARŞİVDEN ÇIKARMA İŞLEMLERİ
                        {
                            arsivden_cikar = true;
                            arac_bilgileri_guncelle_buton.Enabled = arac_guncelleToolStripMenuItem.Enabled = true;//GÜNCELLEME İŞLEMİ YAPILMASINI İZİN VERİLİR
                        }
                    }
                    else
                    {
                        arac_bilgileri_guncelle_buton.Enabled = arac_guncelleToolStripMenuItem.Enabled = false;//GÜNCELLEME İŞLEMİ KAPATILIR.
                    }

                }
                baglanti.Close();//VERİTABANI BAĞLANTISI KAPATILDI
                if (arsivden_cikar == true)
                {
                    baglanti.Open();//VERİTABANINA BAĞLANIR
                    komut = new SqlCommand("update Arac_Tablosu set arsiv=1", baglanti);//ARAÇ ARŞİVDEN ÇIKARIR.
                    komut.ExecuteNonQuery();//SQL İFADELERİNİN ÇALIŞIR
                    baglanti.Close();//VERİTABANI BAĞLANTISI KAPATILIR
                    tabloyu_getir();//TABLO YENİLENİR
                    goto arsivden_cikan_bilgi_icin_tekrar_calistir;//TEKRAR BAŞA GELİP ARŞİVDE OLAN BİLGİYİ GÖSTERİR 
                }
            }
            catch (Exception HATA)//HATA VARSA;
            {
                baglanti.Close();//VERİTABANI BAĞLANTISI KAPATILIR
                MessageBox.Show("HATA OLUŞTU" + HATA, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);//HATA HAKKINDA BİLGİ VERİRLİR.
            }
        }

        private void arac_bilgileri_guncelle_buton_Click(object sender, EventArgs e)
        {
            if (plaka_no_tb.Text != "" && plaka_no_tb.TextLength > 5)//PLAKA NUMARASI KONTROL
            {
                musteri_bilgilerini_guncelle();//YENİ ARAÇ KAYDI FOKSİYONU
                tabloyu_getir();//TABLOYU YENİDEN GETİRİR.(GÜNCELLEME İŞLEMİ)
                arac_bilgileri_guncelle_buton.Enabled = arac_guncelleToolStripMenuItem.Enabled = false;//GÜNCELLEME İŞLEMİ YAPILDIKTAN SONRA KAPATILIR.
            }
            else
            {
                MessageBox.Show("PLAKA EKSİK VEYA BOŞ GEÇİLEMEZ...", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);//HATALI GİRİŞTE VERİLEN UYARI MESAJI
            }
        }
        private void musteri_bilgilerini_guncelle()//ARAÇ BİLGİLERİ GÜNCELLEME FOKSİYONU
        {
            /*"GETİR BUTONUNA BASILDIKTAN SONRA BİLGİLER DEĞİŞTİRİLİR VE GÜNCELLEME İŞLEMİ YAPILIR."*/
            try
            {
                baglanti.Open();//VERİTABANINA BAĞLANIR
                komut = new SqlCommand("update Arac_Tablosu set marka='" + marka_combo.Text + "',model='" + model_combo.Text + "',kategori='" + kategori_combo.Text + "',renk='" + renk_combo.Text + "' where plaka='" + plaka_no_tb.Text + "'", baglanti);//MÜŞTERİ BİLGİLERİNİ GÜNCELLEME FOKSİYONU
                komut.ExecuteNonQuery();//SQL İFADELERİNİN ÇALIŞIR
                baglanti.Close();//VERİTABANI BAĞLANTISI KAPATILIR
                MessageBox.Show(plaka_no_tb.Text + "PLAKALI ARAÇ BİLGİLERİ GÜNCELLENDİ.", "ARAÇ GÜNCELLEME İŞLEMİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception HATA)//HATA VARSA;
            {
                baglanti.Close();//VERİTABANI BAĞLANTISI KAPATILIR
                MessageBox.Show("HATA OLUŞTU" + HATA, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);//HATA HAKKINDA BİLGİ VERİRLİR.
            }
        }

        private void arac_cikar_buton_Click(object sender, EventArgs e)
        {
            /*ARŞİVLEME YAPILIR*/
            if (sistemde_varmi == true)//SİSTEMDE VAR MI KONTROLU
            {
                if (MessageBox.Show(plaka_no_tb.Text + "PLAKAYA AİT ARAÇ SİSTEMDEN ÇIKARILSIN MI ?", "SORU", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)//ARAÇ ÇIKARMAK İSTEDİĞİNİZDEN EMİNMİSİNİZ KONTROLU CEVAP YES İSE;
                {
                    arac_cikar();//ARAÇ ARŞİVLEME FOKSİYONU
                }
            }
            else
            {
                MessageBox.Show("SİSTEMDE ÇIKARMAK İSTEDİĞİNİZ ARAÇ BULUNAMADI...", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);//HATALI GİRİŞTE VERİLEN UYARI MESAJI
            }
        }
        private void arac_cikar()//ARAÇ ÇIKARMA FOKSİYONU
        {
            try
            {
                baglanti.Open();//VERİTABANINA BAĞLANIR
                komut = new SqlCommand("update Arac_Tablosu set arsiv=0 where plaka='" + plaka_no_tb.Text + "'", baglanti);//ÇIKARMA KOMUTU
                komut.ExecuteNonQuery();//SQL İFADELERİNİN ÇALIŞIR
                baglanti.Close();//VERİTABANI BAĞLANTISI KAPATILIR
                MessageBox.Show(plaka_no_tb.Text + " PLAKAYA AİT ARAÇ SİSTEMDEN ÇIKARILDI.", "ARAÇ ÇIKARMA İŞLEMİ", MessageBoxButtons.OK, MessageBoxIcon.Information);//ARAÇ SİLİNDİĞİNDE HAKKINDA BİLGİ VERİR.
                tabloyu_getir();//TABLOYU YENİLEME
            }
            catch (Exception HATA)//HATA VARSA;
            {
                baglanti.Close();//VERİTABANI BAĞLANTISI KAPATILIR
                MessageBox.Show("HATA OLUŞTU" + HATA, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);//HATA HAKKINDA BİLGİ VERİRLİR.
            }
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
            if (konu_combo.Text == "PLAKA NO")//ARAMA KONUSU KONTROLU
            {
                Komutlar = new SqlDataAdapter("select * from Arac_Tablosu where plaka like '%" + arama_tb.Text + "%'", baglanti);//ARAMA KONUSUNA GÖRE ARAMA KOMUTU OLUŞTURUR
            }
            else if (konu_combo.Text == "MARKA")//ARAMA KONUSU KONTROLU
            {
                Komutlar = new SqlDataAdapter("select * from Arac_Tablosu where marka like '%" + arama_tb.Text + "%'", baglanti);//ARAMA KONUSUNA GÖRE ARAMA KOMUTU OLUŞTURUR
            }
            else if (konu_combo.Text == "MODEL")//ARAMA KONUSU KONTROLU
            {
                Komutlar = new SqlDataAdapter("select * from Arac_Tablosu where model like '%" + arama_tb.Text + "%'", baglanti);//ARAMA KONUSUNA GÖRE ARAMA KOMUTU OLUŞTURUR
            }
            else if (konu_combo.Text == "RENK")//ARAMA KONUSU KONTROLU
            {
                Komutlar = new SqlDataAdapter("select * from Arac_Tablosu where renk like '%" + arama_tb.Text + "%'", baglanti);//ARAMA KONUSUNA GÖRE ARAMA KOMUTU OLUŞTURUR
            }
            Komutlar.Fill(veriseti, "Arac_Tablosu");//TABLOYU YÜKLER
            baglanti.Close();//BAĞLANTIYI KAPATIR
            tablolari_listele_dgv.DataSource = veriseti.Tables["Arac_Tablosu"];//TABLOYU PENCEREDE GÖSTERİR
        }

        private void arama_tb_TextChanged(object sender, EventArgs e)
        {
            if (otomatik_arama_cb.Checked == true)//OTOMATİK ARAMA İŞARETLİ İSE;
            {
                arama_yap();//ARAMA YAPAR
            }
        }

        private void pecereyi_kapat_buton_Click(object sender, EventArgs e)
        {
            this.Close();//PENCEREYİ KAPATMA KOMUTU
        }

        private void Arsiv_button_Click(object sender, EventArgs e)
        {
            AracArsivListesi ARAC_ARSİVİ = new AracArsivListesi();
            ARAC_ARSİVİ.ShowDialog();
        }

        private void tumunu_goster_buton_Click(object sender, EventArgs e)
        {
            tabloyu_getir();
        }
    }
}
