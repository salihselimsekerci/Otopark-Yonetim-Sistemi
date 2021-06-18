namespace AOS
{
    partial class Yer_Ekle_Penceresi
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.bilgi1_musteri = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.musteri_comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.bilgi2_arac = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.arac_comboBox2 = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.otopark_yeri_comboBox3 = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.ekle_buton = new System.Windows.Forms.Button();
            this.iptal_et_btn = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ekleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pencereyiKapatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.bilgi1_musteri);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.musteri_comboBox1);
            this.groupBox1.Location = new System.Drawing.Point(13, 37);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(278, 174);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Müşteri Seçimi";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(246, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 25);
            this.button1.TabIndex = 4;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bilgi1_musteri
            // 
            this.bilgi1_musteri.AutoSize = true;
            this.bilgi1_musteri.Location = new System.Drawing.Point(10, 60);
            this.bilgi1_musteri.Name = "bilgi1_musteri";
            this.bilgi1_musteri.Size = new System.Drawing.Size(144, 16);
            this.bilgi1_musteri.TabIndex = 3;
            this.bilgi1_musteri.Text = "Müşteri Hakkında Bilgi;";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Müşteri:";
            // 
            // musteri_comboBox1
            // 
            this.musteri_comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.musteri_comboBox1.FormattingEnabled = true;
            this.musteri_comboBox1.Location = new System.Drawing.Point(71, 23);
            this.musteri_comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.musteri_comboBox1.Name = "musteri_comboBox1";
            this.musteri_comboBox1.Size = new System.Drawing.Size(168, 24);
            this.musteri_comboBox1.TabIndex = 1;
            this.musteri_comboBox1.SelectedIndexChanged += new System.EventHandler(this.musteri_comboBox1_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.bilgi2_arac);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.arac_comboBox2);
            this.groupBox2.Location = new System.Drawing.Point(299, 37);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(278, 174);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Araç Seçimi";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(246, 22);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(25, 25);
            this.button2.TabIndex = 4;
            this.button2.Text = "+";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // bilgi2_arac
            // 
            this.bilgi2_arac.AutoSize = true;
            this.bilgi2_arac.Location = new System.Drawing.Point(10, 60);
            this.bilgi2_arac.Name = "bilgi2_arac";
            this.bilgi2_arac.Size = new System.Drawing.Size(129, 16);
            this.bilgi2_arac.TabIndex = 3;
            this.bilgi2_arac.Text = "Araç Hakkında Bilgi;";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Araç:";
            // 
            // arac_comboBox2
            // 
            this.arac_comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.arac_comboBox2.FormattingEnabled = true;
            this.arac_comboBox2.Location = new System.Drawing.Point(71, 23);
            this.arac_comboBox2.Margin = new System.Windows.Forms.Padding(4);
            this.arac_comboBox2.Name = "arac_comboBox2";
            this.arac_comboBox2.Size = new System.Drawing.Size(168, 24);
            this.arac_comboBox2.TabIndex = 1;
            this.arac_comboBox2.SelectedIndexChanged += new System.EventHandler(this.arac_comboBox2_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.otopark_yeri_comboBox3);
            this.groupBox3.Controls.Add(this.dateTimePicker1);
            this.groupBox3.Location = new System.Drawing.Point(13, 218);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(564, 58);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Giriş Yeri ve zamani";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Yer:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(296, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Otoparka Giriş Saati:";
            // 
            // otopark_yeri_comboBox3
            // 
            this.otopark_yeri_comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.otopark_yeri_comboBox3.FormattingEnabled = true;
            this.otopark_yeri_comboBox3.Location = new System.Drawing.Point(52, 19);
            this.otopark_yeri_comboBox3.Margin = new System.Windows.Forms.Padding(4);
            this.otopark_yeri_comboBox3.Name = "otopark_yeri_comboBox3";
            this.otopark_yeri_comboBox3.Size = new System.Drawing.Size(102, 24);
            this.otopark_yeri_comboBox3.TabIndex = 5;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker1.Location = new System.Drawing.Point(437, 19);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(111, 22);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // ekle_buton
            // 
            this.ekle_buton.BackColor = System.Drawing.Color.White;
            this.ekle_buton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ekle_buton.Location = new System.Drawing.Point(426, 282);
            this.ekle_buton.Name = "ekle_buton";
            this.ekle_buton.Size = new System.Drawing.Size(151, 38);
            this.ekle_buton.TabIndex = 7;
            this.ekle_buton.Text = "Ekle";
            this.ekle_buton.UseVisualStyleBackColor = false;
            this.ekle_buton.Click += new System.EventHandler(this.ekle_buton_Click);
            // 
            // iptal_et_btn
            // 
            this.iptal_et_btn.BackColor = System.Drawing.Color.White;
            this.iptal_et_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iptal_et_btn.Location = new System.Drawing.Point(269, 282);
            this.iptal_et_btn.Name = "iptal_et_btn";
            this.iptal_et_btn.Size = new System.Drawing.Size(151, 38);
            this.iptal_et_btn.TabIndex = 8;
            this.iptal_et_btn.Text = "İptal Et";
            this.iptal_et_btn.UseVisualStyleBackColor = false;
            this.iptal_et_btn.Click += new System.EventHandler(this.iptal_et_btn_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.RoyalBlue;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ekleToolStripMenuItem,
            this.pencereyiKapatToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(586, 24);
            this.menuStrip1.TabIndex = 97;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ekleToolStripMenuItem
            // 
            this.ekleToolStripMenuItem.Name = "ekleToolStripMenuItem";
            this.ekleToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.ekleToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.ekleToolStripMenuItem.Text = "Ekle";
            this.ekleToolStripMenuItem.Click += new System.EventHandler(this.ekle_buton_Click);
            // 
            // pencereyiKapatToolStripMenuItem
            // 
            this.pencereyiKapatToolStripMenuItem.Name = "pencereyiKapatToolStripMenuItem";
            this.pencereyiKapatToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F4)));
            this.pencereyiKapatToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.pencereyiKapatToolStripMenuItem.Text = "İptal Et";
            this.pencereyiKapatToolStripMenuItem.Click += new System.EventHandler(this.iptal_et_btn_Click);
            // 
            // Yer_Ekle_Penceresi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(586, 328);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.iptal_et_btn);
            this.Controls.Add(this.ekle_buton);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Yer_Ekle_Penceresi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Otopark Giriş İşlemleri Penceresi";
            this.Load += new System.EventHandler(this.Yer_Ekle_Penceresi_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label bilgi1_musteri;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox musteri_comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label bilgi2_arac;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox arac_comboBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox otopark_yeri_comboBox3;
        private System.Windows.Forms.Button ekle_buton;
        private System.Windows.Forms.Button iptal_et_btn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ekleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pencereyiKapatToolStripMenuItem;
    }
}