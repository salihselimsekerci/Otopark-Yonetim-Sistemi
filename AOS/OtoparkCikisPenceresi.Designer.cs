namespace AOS
{
    partial class OtoparkCikisPenceresi
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
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.iptal_et_btn = new System.Windows.Forms.Button();
            this.Cikar_buton = new System.Windows.Forms.Button();
            this.bilgi = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ucret_tb = new System.Windows.Forms.TextBox();
            this.sure_tb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cikarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pencereyiKapatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Otoparka Çıkış Saati:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker1.Location = new System.Drawing.Point(179, 147);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(140, 22);
            this.dateTimePicker1.TabIndex = 9;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // iptal_et_btn
            // 
            this.iptal_et_btn.BackColor = System.Drawing.Color.White;
            this.iptal_et_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iptal_et_btn.Location = new System.Drawing.Point(11, 231);
            this.iptal_et_btn.Name = "iptal_et_btn";
            this.iptal_et_btn.Size = new System.Drawing.Size(151, 38);
            this.iptal_et_btn.TabIndex = 12;
            this.iptal_et_btn.Text = "İptal Et";
            this.iptal_et_btn.UseVisualStyleBackColor = false;
            this.iptal_et_btn.Click += new System.EventHandler(this.iptal_et_btn_Click);
            // 
            // Cikar_buton
            // 
            this.Cikar_buton.BackColor = System.Drawing.Color.White;
            this.Cikar_buton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Cikar_buton.Location = new System.Drawing.Point(168, 231);
            this.Cikar_buton.Name = "Cikar_buton";
            this.Cikar_buton.Size = new System.Drawing.Size(151, 38);
            this.Cikar_buton.TabIndex = 11;
            this.Cikar_buton.Text = "Çıkar";
            this.Cikar_buton.UseVisualStyleBackColor = false;
            this.Cikar_buton.Click += new System.EventHandler(this.Cikar_buton_Click);
            // 
            // bilgi
            // 
            this.bilgi.AutoSize = true;
            this.bilgi.Location = new System.Drawing.Point(12, 33);
            this.bilgi.Name = "bilgi";
            this.bilgi.Size = new System.Drawing.Size(32, 16);
            this.bilgi.TabIndex = 13;
            this.bilgi.Text = "XXX";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 206);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "Ücret:";
            // 
            // ucret_tb
            // 
            this.ucret_tb.Location = new System.Drawing.Point(179, 203);
            this.ucret_tb.Name = "ucret_tb";
            this.ucret_tb.Size = new System.Drawing.Size(140, 22);
            this.ucret_tb.TabIndex = 15;
            // 
            // sure_tb
            // 
            this.sure_tb.Location = new System.Drawing.Point(179, 175);
            this.sure_tb.Name = "sure_tb";
            this.sure_tb.Size = new System.Drawing.Size(140, 22);
            this.sure_tb.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "Otoparkta Kalma Süresi:\r\n";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.RoyalBlue;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cikarToolStripMenuItem,
            this.pencereyiKapatToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(331, 24);
            this.menuStrip1.TabIndex = 98;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cikarToolStripMenuItem
            // 
            this.cikarToolStripMenuItem.Name = "cikarToolStripMenuItem";
            this.cikarToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.cikarToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.cikarToolStripMenuItem.Text = "Çıkar";
            this.cikarToolStripMenuItem.Click += new System.EventHandler(this.Cikar_buton_Click);
            // 
            // pencereyiKapatToolStripMenuItem
            // 
            this.pencereyiKapatToolStripMenuItem.Name = "pencereyiKapatToolStripMenuItem";
            this.pencereyiKapatToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F4)));
            this.pencereyiKapatToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.pencereyiKapatToolStripMenuItem.Text = "İptal Et";
            this.pencereyiKapatToolStripMenuItem.Click += new System.EventHandler(this.iptal_et_btn_Click);
            // 
            // OtoparkCikisPenceresi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(331, 279);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.sure_tb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ucret_tb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bilgi);
            this.Controls.Add(this.iptal_et_btn);
            this.Controls.Add(this.Cikar_buton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateTimePicker1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "OtoparkCikisPenceresi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OTOPARK ÇIKIŞ İŞLEMLERİ PENCERESİ";
            this.Load += new System.EventHandler(this.OtoparkCikisPenceresi_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button iptal_et_btn;
        private System.Windows.Forms.Button Cikar_buton;
        private System.Windows.Forms.Label bilgi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ucret_tb;
        private System.Windows.Forms.TextBox sure_tb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cikarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pencereyiKapatToolStripMenuItem;
    }
}