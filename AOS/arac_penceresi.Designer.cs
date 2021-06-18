namespace AOS
{
    partial class arac_penceresi
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pecereyi_kapat_buton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tumunu_goster_buton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tablolari_listele_dgv = new System.Windows.Forms.DataGridView();
            this.arama_yap_buton = new System.Windows.Forms.Button();
            this.arama_tb = new System.Windows.Forms.TextBox();
            this.Arsiv_button = new System.Windows.Forms.Button();
            this.arac_cikar_buton = new System.Windows.Forms.Button();
            this.arac_bilgileri_guncelle_buton = new System.Windows.Forms.Button();
            this.arac_ekle_buton = new System.Windows.Forms.Button();
            this.arac_ekle_gb = new System.Windows.Forms.GroupBox();
            this.getir_buton = new System.Windows.Forms.Button();
            this.kategori_label = new System.Windows.Forms.Label();
            this.kategori_combo = new System.Windows.Forms.ComboBox();
            this.plaka_no_tb = new System.Windows.Forms.TextBox();
            this.renk_label = new System.Windows.Forms.Label();
            this.renk_combo = new System.Windows.Forms.ComboBox();
            this.marka_label = new System.Windows.Forms.Label();
            this.model_combo = new System.Windows.Forms.ComboBox();
            this.marka_combo = new System.Windows.Forms.ComboBox();
            this.plaka_no_label = new System.Windows.Forms.Label();
            this.otomatik_arama_cb = new System.Windows.Forms.CheckBox();
            this.konu_combo = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aramayapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arac_ekleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arac_guncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aracÇıkışİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aracArşiviToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pencereyiKapatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.tablolari_listele_dgv)).BeginInit();
            this.arac_ekle_gb.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pecereyi_kapat_buton
            // 
            this.pecereyi_kapat_buton.Location = new System.Drawing.Point(12, 343);
            this.pecereyi_kapat_buton.Name = "pecereyi_kapat_buton";
            this.pecereyi_kapat_buton.Size = new System.Drawing.Size(283, 30);
            this.pecereyi_kapat_buton.TabIndex = 94;
            this.pecereyi_kapat_buton.Text = "Pencereyi Kapat";
            this.pecereyi_kapat_buton.UseVisualStyleBackColor = true;
            this.pecereyi_kapat_buton.Click += new System.EventHandler(this.pecereyi_kapat_buton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(305, 350);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(456, 16);
            this.label4.TabIndex = 93;
            this.label4.Text = "Bilgi: \"Araç Çıkar\" butonundan yapılan işlemler arşive kayıt edilir.";
            // 
            // tumunu_goster_buton
            // 
            this.tumunu_goster_buton.Location = new System.Drawing.Point(1002, 36);
            this.tumunu_goster_buton.Margin = new System.Windows.Forms.Padding(4);
            this.tumunu_goster_buton.Name = "tumunu_goster_buton";
            this.tumunu_goster_buton.Size = new System.Drawing.Size(127, 26);
            this.tumunu_goster_buton.TabIndex = 92;
            this.tumunu_goster_buton.Text = "Tümünü Göster";
            this.tumunu_goster_buton.UseVisualStyleBackColor = true;
            this.tumunu_goster_buton.Click += new System.EventHandler(this.tumunu_goster_buton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(457, 41);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 16);
            this.label3.TabIndex = 86;
            this.label3.Text = "Göre";
            // 
            // tablolari_listele_dgv
            // 
            this.tablolari_listele_dgv.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablolari_listele_dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.tablolari_listele_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablolari_listele_dgv.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tablolari_listele_dgv.DefaultCellStyle = dataGridViewCellStyle5;
            this.tablolari_listele_dgv.Location = new System.Drawing.Point(302, 70);
            this.tablolari_listele_dgv.Margin = new System.Windows.Forms.Padding(4);
            this.tablolari_listele_dgv.Name = "tablolari_listele_dgv";
            this.tablolari_listele_dgv.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablolari_listele_dgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.tablolari_listele_dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablolari_listele_dgv.Size = new System.Drawing.Size(827, 263);
            this.tablolari_listele_dgv.TabIndex = 87;
            // 
            // arama_yap_buton
            // 
            this.arama_yap_buton.Location = new System.Drawing.Point(722, 36);
            this.arama_yap_buton.Margin = new System.Windows.Forms.Padding(4);
            this.arama_yap_buton.Name = "arama_yap_buton";
            this.arama_yap_buton.Size = new System.Drawing.Size(127, 26);
            this.arama_yap_buton.TabIndex = 91;
            this.arama_yap_buton.Text = "Arama Yap";
            this.arama_yap_buton.UseVisualStyleBackColor = true;
            this.arama_yap_buton.Click += new System.EventHandler(this.arama_yap_buton_Click);
            // 
            // arama_tb
            // 
            this.arama_tb.Location = new System.Drawing.Point(502, 38);
            this.arama_tb.Margin = new System.Windows.Forms.Padding(4);
            this.arama_tb.Name = "arama_tb";
            this.arama_tb.Size = new System.Drawing.Size(212, 22);
            this.arama_tb.TabIndex = 89;
            this.arama_tb.TextChanged += new System.EventHandler(this.arama_tb_TextChanged);
            // 
            // Arsiv_button
            // 
            this.Arsiv_button.Location = new System.Drawing.Point(12, 303);
            this.Arsiv_button.Name = "Arsiv_button";
            this.Arsiv_button.Size = new System.Drawing.Size(283, 30);
            this.Arsiv_button.TabIndex = 85;
            this.Arsiv_button.Text = "Araç Arşiv Listesi";
            this.Arsiv_button.UseVisualStyleBackColor = true;
            this.Arsiv_button.Click += new System.EventHandler(this.Arsiv_button_Click);
            // 
            // arac_cikar_buton
            // 
            this.arac_cikar_buton.Location = new System.Drawing.Point(12, 267);
            this.arac_cikar_buton.Name = "arac_cikar_buton";
            this.arac_cikar_buton.Size = new System.Drawing.Size(283, 30);
            this.arac_cikar_buton.TabIndex = 84;
            this.arac_cikar_buton.Text = "Araç Çıkar";
            this.arac_cikar_buton.UseVisualStyleBackColor = true;
            this.arac_cikar_buton.Click += new System.EventHandler(this.arac_cikar_buton_Click);
            // 
            // arac_bilgileri_guncelle_buton
            // 
            this.arac_bilgileri_guncelle_buton.Location = new System.Drawing.Point(12, 231);
            this.arac_bilgileri_guncelle_buton.Name = "arac_bilgileri_guncelle_buton";
            this.arac_bilgileri_guncelle_buton.Size = new System.Drawing.Size(283, 30);
            this.arac_bilgileri_guncelle_buton.TabIndex = 83;
            this.arac_bilgileri_guncelle_buton.Text = "Araç Bilgilerini Güncelle";
            this.arac_bilgileri_guncelle_buton.UseVisualStyleBackColor = true;
            this.arac_bilgileri_guncelle_buton.Click += new System.EventHandler(this.arac_bilgileri_guncelle_buton_Click);
            // 
            // arac_ekle_buton
            // 
            this.arac_ekle_buton.Location = new System.Drawing.Point(12, 195);
            this.arac_ekle_buton.Name = "arac_ekle_buton";
            this.arac_ekle_buton.Size = new System.Drawing.Size(283, 30);
            this.arac_ekle_buton.TabIndex = 82;
            this.arac_ekle_buton.Text = "Araç Ekle";
            this.arac_ekle_buton.UseVisualStyleBackColor = true;
            this.arac_ekle_buton.Click += new System.EventHandler(this.arac_ekle_buton_Click);
            // 
            // arac_ekle_gb
            // 
            this.arac_ekle_gb.Controls.Add(this.getir_buton);
            this.arac_ekle_gb.Controls.Add(this.kategori_label);
            this.arac_ekle_gb.Controls.Add(this.kategori_combo);
            this.arac_ekle_gb.Controls.Add(this.plaka_no_tb);
            this.arac_ekle_gb.Controls.Add(this.renk_label);
            this.arac_ekle_gb.Controls.Add(this.renk_combo);
            this.arac_ekle_gb.Controls.Add(this.marka_label);
            this.arac_ekle_gb.Controls.Add(this.model_combo);
            this.arac_ekle_gb.Controls.Add(this.marka_combo);
            this.arac_ekle_gb.Controls.Add(this.plaka_no_label);
            this.arac_ekle_gb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.arac_ekle_gb.Location = new System.Drawing.Point(12, 36);
            this.arac_ekle_gb.Name = "arac_ekle_gb";
            this.arac_ekle_gb.Size = new System.Drawing.Size(283, 153);
            this.arac_ekle_gb.TabIndex = 95;
            this.arac_ekle_gb.TabStop = false;
            this.arac_ekle_gb.Text = "Araç Bilgileri";
            // 
            // getir_buton
            // 
            this.getir_buton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.getir_buton.Location = new System.Drawing.Point(213, 20);
            this.getir_buton.Name = "getir_buton";
            this.getir_buton.Size = new System.Drawing.Size(59, 25);
            this.getir_buton.TabIndex = 79;
            this.getir_buton.Text = "Getir";
            this.getir_buton.UseVisualStyleBackColor = true;
            this.getir_buton.Click += new System.EventHandler(this.getir_buton_Click);
            // 
            // kategori_label
            // 
            this.kategori_label.AutoSize = true;
            this.kategori_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.kategori_label.Location = new System.Drawing.Point(6, 86);
            this.kategori_label.Name = "kategori_label";
            this.kategori_label.Size = new System.Drawing.Size(61, 16);
            this.kategori_label.TabIndex = 62;
            this.kategori_label.Text = "Kategori:";
            // 
            // kategori_combo
            // 
            this.kategori_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.kategori_combo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.kategori_combo.FormattingEnabled = true;
            this.kategori_combo.Location = new System.Drawing.Point(105, 84);
            this.kategori_combo.Name = "kategori_combo";
            this.kategori_combo.Size = new System.Drawing.Size(167, 24);
            this.kategori_combo.TabIndex = 63;
            // 
            // plaka_no_tb
            // 
            this.plaka_no_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.plaka_no_tb.Location = new System.Drawing.Point(105, 22);
            this.plaka_no_tb.Name = "plaka_no_tb";
            this.plaka_no_tb.Size = new System.Drawing.Size(101, 22);
            this.plaka_no_tb.TabIndex = 78;
            this.plaka_no_tb.Text = " ";
            this.plaka_no_tb.TextChanged += new System.EventHandler(this.plaka_no_tb_TextChanged);
            // 
            // renk_label
            // 
            this.renk_label.AutoSize = true;
            this.renk_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.renk_label.Location = new System.Drawing.Point(6, 118);
            this.renk_label.Name = "renk_label";
            this.renk_label.Size = new System.Drawing.Size(43, 16);
            this.renk_label.TabIndex = 56;
            this.renk_label.Text = "Renk:";
            // 
            // renk_combo
            // 
            this.renk_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.renk_combo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.renk_combo.FormattingEnabled = true;
            this.renk_combo.Location = new System.Drawing.Point(105, 116);
            this.renk_combo.Name = "renk_combo";
            this.renk_combo.Size = new System.Drawing.Size(167, 24);
            this.renk_combo.TabIndex = 57;
            // 
            // marka_label
            // 
            this.marka_label.AutoSize = true;
            this.marka_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.marka_label.Location = new System.Drawing.Point(6, 56);
            this.marka_label.Name = "marka_label";
            this.marka_label.Size = new System.Drawing.Size(91, 16);
            this.marka_label.TabIndex = 21;
            this.marka_label.Text = "Marka/Model:";
            // 
            // model_combo
            // 
            this.model_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.model_combo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.model_combo.FormattingEnabled = true;
            this.model_combo.Location = new System.Drawing.Point(212, 54);
            this.model_combo.Name = "model_combo";
            this.model_combo.Size = new System.Drawing.Size(60, 24);
            this.model_combo.TabIndex = 48;
            // 
            // marka_combo
            // 
            this.marka_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.marka_combo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.marka_combo.FormattingEnabled = true;
            this.marka_combo.Location = new System.Drawing.Point(105, 54);
            this.marka_combo.Name = "marka_combo";
            this.marka_combo.Size = new System.Drawing.Size(101, 24);
            this.marka_combo.TabIndex = 47;
            this.marka_combo.SelectedIndexChanged += new System.EventHandler(this.marka_combo_SelectedIndexChanged);
            // 
            // plaka_no_label
            // 
            this.plaka_no_label.AutoSize = true;
            this.plaka_no_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.plaka_no_label.Location = new System.Drawing.Point(6, 22);
            this.plaka_no_label.Name = "plaka_no_label";
            this.plaka_no_label.Size = new System.Drawing.Size(67, 16);
            this.plaka_no_label.TabIndex = 9;
            this.plaka_no_label.Text = "Plaka No:";
            // 
            // otomatik_arama_cb
            // 
            this.otomatik_arama_cb.AutoSize = true;
            this.otomatik_arama_cb.Location = new System.Drawing.Point(857, 40);
            this.otomatik_arama_cb.Margin = new System.Windows.Forms.Padding(4);
            this.otomatik_arama_cb.Name = "otomatik_arama_cb";
            this.otomatik_arama_cb.Size = new System.Drawing.Size(123, 20);
            this.otomatik_arama_cb.TabIndex = 88;
            this.otomatik_arama_cb.Text = "Otomatik Arama";
            this.otomatik_arama_cb.UseVisualStyleBackColor = true;
            // 
            // konu_combo
            // 
            this.konu_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.konu_combo.FormattingEnabled = true;
            this.konu_combo.Location = new System.Drawing.Point(302, 36);
            this.konu_combo.Margin = new System.Windows.Forms.Padding(4);
            this.konu_combo.Name = "konu_combo";
            this.konu_combo.Size = new System.Drawing.Size(147, 24);
            this.konu_combo.TabIndex = 90;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.RoyalBlue;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aramayapToolStripMenuItem,
            this.arac_ekleToolStripMenuItem,
            this.arac_guncelleToolStripMenuItem,
            this.aracÇıkışİşlemleriToolStripMenuItem,
            this.aracArşiviToolStripMenuItem,
            this.pencereyiKapatToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1137, 24);
            this.menuStrip1.TabIndex = 96;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aramayapToolStripMenuItem
            // 
            this.aramayapToolStripMenuItem.Name = "aramayapToolStripMenuItem";
            this.aramayapToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.aramayapToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.aramayapToolStripMenuItem.Text = "Arama Yap";
            this.aramayapToolStripMenuItem.Click += new System.EventHandler(this.arama_yap_buton_Click);
            // 
            // arac_ekleToolStripMenuItem
            // 
            this.arac_ekleToolStripMenuItem.Name = "arac_ekleToolStripMenuItem";
            this.arac_ekleToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.arac_ekleToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.arac_ekleToolStripMenuItem.Text = "Araç Ekle";
            this.arac_ekleToolStripMenuItem.Click += new System.EventHandler(this.arac_ekle_buton_Click);
            // 
            // arac_guncelleToolStripMenuItem
            // 
            this.arac_guncelleToolStripMenuItem.Name = "arac_guncelleToolStripMenuItem";
            this.arac_guncelleToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.arac_guncelleToolStripMenuItem.Size = new System.Drawing.Size(144, 20);
            this.arac_guncelleToolStripMenuItem.Text = "Araç Bilgilerini Güncelle";
            this.arac_guncelleToolStripMenuItem.Click += new System.EventHandler(this.arac_bilgileri_guncelle_buton_Click);
            // 
            // aracÇıkışİşlemleriToolStripMenuItem
            // 
            this.aracÇıkışİşlemleriToolStripMenuItem.Name = "aracÇıkışİşlemleriToolStripMenuItem";
            this.aracÇıkışİşlemleriToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F4;
            this.aracÇıkışİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.aracÇıkışİşlemleriToolStripMenuItem.Text = "Araç Çıkar";
            this.aracÇıkışİşlemleriToolStripMenuItem.Click += new System.EventHandler(this.arac_cikar_buton_Click);
            // 
            // aracArşiviToolStripMenuItem
            // 
            this.aracArşiviToolStripMenuItem.Name = "aracArşiviToolStripMenuItem";
            this.aracArşiviToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.aracArşiviToolStripMenuItem.Size = new System.Drawing.Size(107, 20);
            this.aracArşiviToolStripMenuItem.Text = "Araç Arşiv Listesi";
            this.aracArşiviToolStripMenuItem.Click += new System.EventHandler(this.Arsiv_button_Click);
            // 
            // pencereyiKapatToolStripMenuItem
            // 
            this.pencereyiKapatToolStripMenuItem.Name = "pencereyiKapatToolStripMenuItem";
            this.pencereyiKapatToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F4)));
            this.pencereyiKapatToolStripMenuItem.Size = new System.Drawing.Size(103, 20);
            this.pencereyiKapatToolStripMenuItem.Text = "Pencereyi Kapat";
            this.pencereyiKapatToolStripMenuItem.Click += new System.EventHandler(this.pecereyi_kapat_buton_Click);
            // 
            // arac_penceresi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1137, 384);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.arac_ekle_gb);
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
            this.Controls.Add(this.arac_cikar_buton);
            this.Controls.Add(this.arac_bilgileri_guncelle_buton);
            this.Controls.Add(this.arac_ekle_buton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "arac_penceresi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Araç İşlemleri";
            this.Load += new System.EventHandler(this.aracpenceresi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablolari_listele_dgv)).EndInit();
            this.arac_ekle_gb.ResumeLayout(false);
            this.arac_ekle_gb.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button pecereyi_kapat_buton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button tumunu_goster_buton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView tablolari_listele_dgv;
        private System.Windows.Forms.Button arama_yap_buton;
        private System.Windows.Forms.TextBox arama_tb;
        private System.Windows.Forms.Button Arsiv_button;
        private System.Windows.Forms.Button arac_cikar_buton;
        private System.Windows.Forms.Button arac_bilgileri_guncelle_buton;
        private System.Windows.Forms.Button arac_ekle_buton;
        private System.Windows.Forms.GroupBox arac_ekle_gb;
        private System.Windows.Forms.Label kategori_label;
        private System.Windows.Forms.ComboBox kategori_combo;
        private System.Windows.Forms.TextBox plaka_no_tb;
        private System.Windows.Forms.Label renk_label;
        private System.Windows.Forms.ComboBox renk_combo;
        private System.Windows.Forms.Label marka_label;
        private System.Windows.Forms.ComboBox model_combo;
        private System.Windows.Forms.ComboBox marka_combo;
        private System.Windows.Forms.Label plaka_no_label;
        private System.Windows.Forms.Button getir_buton;
        private System.Windows.Forms.CheckBox otomatik_arama_cb;
        private System.Windows.Forms.ComboBox konu_combo;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aramayapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arac_ekleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arac_guncelleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aracÇıkışİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aracArşiviToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pencereyiKapatToolStripMenuItem;

    }
}