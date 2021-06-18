namespace AOS
{
    partial class istatistik_penceresi
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
            this.label1 = new System.Windows.Forms.Label();
            this.sorgu_buton = new System.Windows.Forms.Button();
            this.konu_cb = new System.Windows.Forms.ComboBox();
            this.sonuc_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "İstatistik Konusu:";
            // 
            // sorgu_buton
            // 
            this.sorgu_buton.Location = new System.Drawing.Point(559, 6);
            this.sorgu_buton.Name = "sorgu_buton";
            this.sorgu_buton.Size = new System.Drawing.Size(95, 24);
            this.sorgu_buton.TabIndex = 1;
            this.sorgu_buton.Text = "Sorgula";
            this.sorgu_buton.UseVisualStyleBackColor = true;
            this.sorgu_buton.Click += new System.EventHandler(this.sorgu_buton_Click);
            // 
            // konu_cb
            // 
            this.konu_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.konu_cb.FormattingEnabled = true;
            this.konu_cb.Location = new System.Drawing.Point(123, 6);
            this.konu_cb.Name = "konu_cb";
            this.konu_cb.Size = new System.Drawing.Size(430, 24);
            this.konu_cb.TabIndex = 2;
            // 
            // sonuc_label
            // 
            this.sonuc_label.AutoSize = true;
            this.sonuc_label.Location = new System.Drawing.Point(12, 40);
            this.sonuc_label.Name = "sonuc_label";
            this.sonuc_label.Size = new System.Drawing.Size(49, 16);
            this.sonuc_label.TabIndex = 3;
            this.sonuc_label.Text = "Sonuç:";
            // 
            // istatistik_penceresi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(663, 68);
            this.Controls.Add(this.sonuc_label);
            this.Controls.Add(this.konu_cb);
            this.Controls.Add(this.sorgu_buton);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "istatistik_penceresi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "İstatistik Penceresi";
            this.Load += new System.EventHandler(this.istatistik_penceresi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button sorgu_buton;
        private System.Windows.Forms.ComboBox konu_cb;
        private System.Windows.Forms.Label sonuc_label;
    }
}