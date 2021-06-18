namespace AOS
{
    partial class musteri_penceresi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.telefon_maskedtextbox = new System.Windows.Forms.MaskedTextBox();
            this.tcno_masked = new System.Windows.Forms.MaskedTextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.getir_buton = new System.Windows.Forms.Button();
            this.cinsiyet_combobox = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.adi_textbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.soyadi_textbox = new System.Windows.Forms.TextBox();
            this.Arsiv_button = new System.Windows.Forms.Button();
            this.musteri_cikar_buton = new System.Windows.Forms.Button();
            this.musteri_bilgileri_guncelle_buton = new System.Windows.Forms.Button();
            this.musteri_ekle_buton = new System.Windows.Forms.Button();
            this.tumunu_goster_buton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tablolari_listele_dgv = new System.Windows.Forms.DataGridView();
            this.arama_yap_buton = new System.Windows.Forms.Button();
            this.konu_combo = new System.Windows.Forms.ComboBox();
            this.otomatik_arama_cb = new System.Windows.Forms.CheckBox();
            this.arama_tb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pecereyi_kapat_buton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.otoparkArşiviToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.müşteriİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.musteriguncellemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otoparkGirişİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otoparkÇıkışİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pencereyiKapatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablolari_listele_dgv)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.telefon_maskedtextbox);
            this.groupBox1.Controls.Add(this.tcno_masked);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.getir_buton);
            this.groupBox1.Controls.Add(this.cinsiyet_combobox);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.adi_textbox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.soyadi_textbox);
            this.groupBox1.Location = new System.Drawing.Point(12, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(333, 170);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Müşteri Bilgileri";
            // 
            // telefon_maskedtextbox
            // 
            this.telefon_maskedtextbox.Location = new System.Drawing.Point(149, 133);
            this.telefon_maskedtextbox.Mask = "(999) 000-0000";
            this.telefon_maskedtextbox.Name = "telefon_maskedtextbox";
            this.telefon_maskedtextbox.Size = new System.Drawing.Size(168, 22);
            this.telefon_maskedtextbox.TabIndex = 37;
            // 
            // tcno_masked
            // 
            this.tcno_masked.Location = new System.Drawing.Point(149, 17);
            this.tcno_masked.Mask = "00000000000";
            this.tcno_masked.Name = "tcno_masked";
            this.tcno_masked.Size = new System.Drawing.Size(115, 22);
            this.tcno_masked.TabIndex = 36;
            this.tcno_masked.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.tcno_masked_MaskInputRejected);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 136);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(110, 16);
            this.label15.TabIndex = 35;
            this.label15.Text = "Müşteri Telefonu:";
            // 
            // getir_buton
            // 
            this.getir_buton.Location = new System.Drawing.Point(270, 16);
            this.getir_buton.Name = "getir_buton";
            this.getir_buton.Size = new System.Drawing.Size(47, 25);
            this.getir_buton.TabIndex = 32;
            this.getir_buton.Text = "Getir";
            this.getir_buton.UseVisualStyleBackColor = true;
            this.getir_buton.Click += new System.EventHandler(this.getir_buton_Click);
            // 
            // cinsiyet_combobox
            // 
            this.cinsiyet_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cinsiyet_combobox.FormattingEnabled = true;
            this.cinsiyet_combobox.Location = new System.Drawing.Point(149, 101);
            this.cinsiyet_combobox.Name = "cinsiyet_combobox";
            this.cinsiyet_combobox.Size = new System.Drawing.Size(168, 24);
            this.cinsiyet_combobox.TabIndex = 31;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 104);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 16);
            this.label9.TabIndex = 30;
            this.label9.Text = "Cinsiyet:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 16);
            this.label7.TabIndex = 10;
            this.label7.Text = "Müşteri Adı:";
            // 
            // adi_textbox
            // 
            this.adi_textbox.Location = new System.Drawing.Point(149, 45);
            this.adi_textbox.Name = "adi_textbox";
            this.adi_textbox.Size = new System.Drawing.Size(168, 22);
            this.adi_textbox.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Müşteri T.C Kimlik No:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Müşteri Soyadı:";
            // 
            // soyadi_textbox
            // 
            this.soyadi_textbox.Location = new System.Drawing.Point(149, 73);
            this.soyadi_textbox.Name = "soyadi_textbox";
            this.soyadi_textbox.Size = new System.Drawing.Size(168, 22);
            this.soyadi_textbox.TabIndex = 3;
            // 
            // Arsiv_button
            // 
            this.Arsiv_button.Location = new System.Drawing.Point(12, 322);
            this.Arsiv_button.Name = "Arsiv_button";
            this.Arsiv_button.Size = new System.Drawing.Size(333, 30);
            this.Arsiv_button.TabIndex = 40;
            this.Arsiv_button.Text = "Müşteri Arşiv Listesi";
            this.Arsiv_button.UseVisualStyleBackColor = true;
            this.Arsiv_button.Click += new System.EventHandler(this.Arsiv_button_Click);
            // 
            // musteri_cikar_buton
            // 
            this.musteri_cikar_buton.Location = new System.Drawing.Point(12, 286);
            this.musteri_cikar_buton.Name = "musteri_cikar_buton";
            this.musteri_cikar_buton.Size = new System.Drawing.Size(333, 30);
            this.musteri_cikar_buton.TabIndex = 39;
            this.musteri_cikar_buton.Text = "Müşteri  Çıkar";
            this.musteri_cikar_buton.UseVisualStyleBackColor = true;
            this.musteri_cikar_buton.Click += new System.EventHandler(this.musteri_cikar_buton_Click);
            // 
            // musteri_bilgileri_guncelle_buton
            // 
            this.musteri_bilgileri_guncelle_buton.Location = new System.Drawing.Point(12, 250);
            this.musteri_bilgileri_guncelle_buton.Name = "musteri_bilgileri_guncelle_buton";
            this.musteri_bilgileri_guncelle_buton.Size = new System.Drawing.Size(333, 30);
            this.musteri_bilgileri_guncelle_buton.TabIndex = 38;
            this.musteri_bilgileri_guncelle_buton.Text = "Müşteri  Bilgileri Güncelle";
            this.musteri_bilgileri_guncelle_buton.UseVisualStyleBackColor = true;
            this.musteri_bilgileri_guncelle_buton.Click += new System.EventHandler(this.musteri_bilgileri_guncelle_buton_Click);
            // 
            // musteri_ekle_buton
            // 
            this.musteri_ekle_buton.Location = new System.Drawing.Point(12, 214);
            this.musteri_ekle_buton.Name = "musteri_ekle_buton";
            this.musteri_ekle_buton.Size = new System.Drawing.Size(333, 30);
            this.musteri_ekle_buton.TabIndex = 37;
            this.musteri_ekle_buton.Text = "Müşteri  Ekle";
            this.musteri_ekle_buton.UseVisualStyleBackColor = true;
            this.musteri_ekle_buton.Click += new System.EventHandler(this.musteri_ekle_buton_Click);
            // 
            // tumunu_goster_buton
            // 
            this.tumunu_goster_buton.Location = new System.Drawing.Point(1052, 38);
            this.tumunu_goster_buton.Margin = new System.Windows.Forms.Padding(4);
            this.tumunu_goster_buton.Name = "tumunu_goster_buton";
            this.tumunu_goster_buton.Size = new System.Drawing.Size(127, 26);
            this.tumunu_goster_buton.TabIndex = 78;
            this.tumunu_goster_buton.Text = "Tümünü Göster";
            this.tumunu_goster_buton.UseVisualStyleBackColor = true;
            this.tumunu_goster_buton.Click += new System.EventHandler(this.tumunu_goster_buton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(507, 43);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 16);
            this.label3.TabIndex = 72;
            this.label3.Text = "Göre";
            // 
            // tablolari_listele_dgv
            // 
            this.tablolari_listele_dgv.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablolari_listele_dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tablolari_listele_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablolari_listele_dgv.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tablolari_listele_dgv.DefaultCellStyle = dataGridViewCellStyle2;
            this.tablolari_listele_dgv.Location = new System.Drawing.Point(352, 72);
            this.tablolari_listele_dgv.Margin = new System.Windows.Forms.Padding(4);
            this.tablolari_listele_dgv.Name = "tablolari_listele_dgv";
            this.tablolari_listele_dgv.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablolari_listele_dgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.tablolari_listele_dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablolari_listele_dgv.Size = new System.Drawing.Size(827, 280);
            this.tablolari_listele_dgv.TabIndex = 73;
            // 
            // arama_yap_buton
            // 
            this.arama_yap_buton.Location = new System.Drawing.Point(772, 38);
            this.arama_yap_buton.Margin = new System.Windows.Forms.Padding(4);
            this.arama_yap_buton.Name = "arama_yap_buton";
            this.arama_yap_buton.Size = new System.Drawing.Size(127, 26);
            this.arama_yap_buton.TabIndex = 77;
            this.arama_yap_buton.Text = "Arama Yap";
            this.arama_yap_buton.UseVisualStyleBackColor = true;
            this.arama_yap_buton.Click += new System.EventHandler(this.arama_yap_buton_Click);
            // 
            // konu_combo
            // 
            this.konu_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.konu_combo.FormattingEnabled = true;
            this.konu_combo.Location = new System.Drawing.Point(352, 38);
            this.konu_combo.Margin = new System.Windows.Forms.Padding(4);
            this.konu_combo.Name = "konu_combo";
            this.konu_combo.Size = new System.Drawing.Size(147, 24);
            this.konu_combo.TabIndex = 76;
            // 
            // otomatik_arama_cb
            // 
            this.otomatik_arama_cb.AutoSize = true;
            this.otomatik_arama_cb.Location = new System.Drawing.Point(907, 42);
            this.otomatik_arama_cb.Margin = new System.Windows.Forms.Padding(4);
            this.otomatik_arama_cb.Name = "otomatik_arama_cb";
            this.otomatik_arama_cb.Size = new System.Drawing.Size(123, 20);
            this.otomatik_arama_cb.TabIndex = 74;
            this.otomatik_arama_cb.Text = "Otomatik Arama";
            this.otomatik_arama_cb.UseVisualStyleBackColor = true;
            // 
            // arama_tb
            // 
            this.arama_tb.Location = new System.Drawing.Point(552, 40);
            this.arama_tb.Margin = new System.Windows.Forms.Padding(4);
            this.arama_tb.Name = "arama_tb";
            this.arama_tb.Size = new System.Drawing.Size(212, 22);
            this.arama_tb.TabIndex = 75;
            this.arama_tb.TextChanged += new System.EventHandler(this.arama_tb_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(351, 369);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(474, 16);
            this.label4.TabIndex = 79;
            this.label4.Text = "Bilgi: \"Müşteri Çıkar\" butonundan yapılan işlemler arşive kayıt edilir.";
            // 
            // pecereyi_kapat_buton
            // 
            this.pecereyi_kapat_buton.Location = new System.Drawing.Point(12, 362);
            this.pecereyi_kapat_buton.Name = "pecereyi_kapat_buton";
            this.pecereyi_kapat_buton.Size = new System.Drawing.Size(333, 30);
            this.pecereyi_kapat_buton.TabIndex = 80;
            this.pecereyi_kapat_buton.Text = "Pencereyi Kapat";
            this.pecereyi_kapat_buton.UseVisualStyleBackColor = true;
            this.pecereyi_kapat_buton.Click += new System.EventHandler(this.pecereyi_kapat_buton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.RoyalBlue;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.otoparkArşiviToolStripMenuItem,
            this.müşteriİşlemleriToolStripMenuItem,
            this.musteriguncellemeToolStripMenuItem,
            this.otoparkGirişİşlemleriToolStripMenuItem,
            this.otoparkÇıkışİşlemleriToolStripMenuItem,
            this.pencereyiKapatToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1192, 24);
            this.menuStrip1.TabIndex = 85;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // otoparkArşiviToolStripMenuItem
            // 
            this.otoparkArşiviToolStripMenuItem.Name = "otoparkArşiviToolStripMenuItem";
            this.otoparkArşiviToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.otoparkArşiviToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.otoparkArşiviToolStripMenuItem.Text = "Arama Yap";
            this.otoparkArşiviToolStripMenuItem.Click += new System.EventHandler(this.arama_yap_buton_Click);
            // 
            // müşteriİşlemleriToolStripMenuItem
            // 
            this.müşteriİşlemleriToolStripMenuItem.Name = "müşteriİşlemleriToolStripMenuItem";
            this.müşteriİşlemleriToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.müşteriİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.müşteriİşlemleriToolStripMenuItem.Text = "Müşteri Ekle";
            this.müşteriİşlemleriToolStripMenuItem.Click += new System.EventHandler(this.musteri_ekle_buton_Click);
            // 
            // musteriguncellemeToolStripMenuItem
            // 
            this.musteriguncellemeToolStripMenuItem.Name = "musteriguncellemeToolStripMenuItem";
            this.musteriguncellemeToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.musteriguncellemeToolStripMenuItem.Size = new System.Drawing.Size(160, 20);
            this.musteriguncellemeToolStripMenuItem.Text = "Müşteri Bilgilerini Güncelle";
            this.musteriguncellemeToolStripMenuItem.Click += new System.EventHandler(this.musteri_bilgileri_guncelle_buton_Click);
            // 
            // otoparkGirişİşlemleriToolStripMenuItem
            // 
            this.otoparkGirişİşlemleriToolStripMenuItem.Name = "otoparkGirişİşlemleriToolStripMenuItem";
            this.otoparkGirişİşlemleriToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F4;
            this.otoparkGirişİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.otoparkGirişİşlemleriToolStripMenuItem.Text = "Müşteri Çıkar";
            this.otoparkGirişİşlemleriToolStripMenuItem.Click += new System.EventHandler(this.musteri_cikar_buton_Click);
            // 
            // otoparkÇıkışİşlemleriToolStripMenuItem
            // 
            this.otoparkÇıkışİşlemleriToolStripMenuItem.Name = "otoparkÇıkışİşlemleriToolStripMenuItem";
            this.otoparkÇıkışİşlemleriToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.otoparkÇıkışİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.otoparkÇıkışİşlemleriToolStripMenuItem.Text = "Müşteri Arşivi";
            this.otoparkÇıkışİşlemleriToolStripMenuItem.Click += new System.EventHandler(this.Arsiv_button_Click);
            // 
            // pencereyiKapatToolStripMenuItem
            // 
            this.pencereyiKapatToolStripMenuItem.Name = "pencereyiKapatToolStripMenuItem";
            this.pencereyiKapatToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F4)));
            this.pencereyiKapatToolStripMenuItem.Size = new System.Drawing.Size(103, 20);
            this.pencereyiKapatToolStripMenuItem.Text = "Pencereyi Kapat";
            this.pencereyiKapatToolStripMenuItem.Click += new System.EventHandler(this.pecereyi_kapat_buton_Click);
            // 
            // musteri_penceresi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1192, 399);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pecereyi_kapat_buton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tumunu_goster_buton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tablolari_listele_dgv);
            this.Controls.Add(this.arama_yap_buton);
            this.Controls.Add(this.konu_combo);
            this.Controls.Add(this.otomatik_arama_cb);
            this.Controls.Add(this.arama_tb);
            this.Controls.Add(this.Arsiv_button);
            this.Controls.Add(this.musteri_cikar_buton);
            this.Controls.Add(this.musteri_bilgileri_guncelle_buton);
            this.Controls.Add(this.musteri_ekle_buton);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "musteri_penceresi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Müşteri İşlemleri";
            this.Load += new System.EventHandler(this._musteri_penceresi_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablolari_listele_dgv)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox telefon_maskedtextbox;
        private System.Windows.Forms.MaskedTextBox tcno_masked;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button getir_buton;
        private System.Windows.Forms.ComboBox cinsiyet_combobox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox adi_textbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox soyadi_textbox;
        private System.Windows.Forms.Button Arsiv_button;
        private System.Windows.Forms.Button musteri_cikar_buton;
        private System.Windows.Forms.Button musteri_bilgileri_guncelle_buton;
        private System.Windows.Forms.Button musteri_ekle_buton;
        private System.Windows.Forms.Button tumunu_goster_buton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView tablolari_listele_dgv;
        private System.Windows.Forms.Button arama_yap_buton;
        private System.Windows.Forms.ComboBox konu_combo;
        private System.Windows.Forms.CheckBox otomatik_arama_cb;
        private System.Windows.Forms.TextBox arama_tb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button pecereyi_kapat_buton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem müşteriİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem musteriguncellemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem otoparkGirişİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem otoparkÇıkışİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem otoparkArşiviToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pencereyiKapatToolStripMenuItem;
    }
}