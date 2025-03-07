namespace UrunYonetimiStokTakip
{
    partial class SiparisYonetimi
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
            this.dgvSiparis = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpSiparisTarihi = new System.Windows.Forms.DateTimePicker();
            this.cmbUrunler = new System.Windows.Forms.ComboBox();
            this.cmbMusteri = new System.Windows.Forms.ComboBox();
            this.lbltel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.txtsiparisNo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Ad = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSiparis)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvSiparis
            // 
            this.dgvSiparis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSiparis.Location = new System.Drawing.Point(12, 12);
            this.dgvSiparis.Name = "dgvSiparis";
            this.dgvSiparis.Size = new System.Drawing.Size(483, 518);
            this.dgvSiparis.TabIndex = 1;
            this.dgvSiparis.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSiparis_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpSiparisTarihi);
            this.groupBox1.Controls.Add(this.cmbUrunler);
            this.groupBox1.Controls.Add(this.cmbMusteri);
            this.groupBox1.Controls.Add(this.lbltel);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblId);
            this.groupBox1.Controls.Add(this.txtsiparisNo);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.Ad);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnSil);
            this.groupBox1.Controls.Add(this.btnGuncelle);
            this.groupBox1.Controls.Add(this.btnEkle);
            this.groupBox1.Location = new System.Drawing.Point(547, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(441, 351);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sipariş Bilgileri";
            // 
            // dtpSiparisTarihi
            // 
            this.dtpSiparisTarihi.Location = new System.Drawing.Point(147, 172);
            this.dtpSiparisTarihi.Name = "dtpSiparisTarihi";
            this.dtpSiparisTarihi.Size = new System.Drawing.Size(200, 20);
            this.dtpSiparisTarihi.TabIndex = 37;
            // 
            // cmbUrunler
            // 
            this.cmbUrunler.FormattingEnabled = true;
            this.cmbUrunler.Location = new System.Drawing.Point(147, 132);
            this.cmbUrunler.Name = "cmbUrunler";
            this.cmbUrunler.Size = new System.Drawing.Size(200, 21);
            this.cmbUrunler.TabIndex = 36;
            // 
            // cmbMusteri
            // 
            this.cmbMusteri.DisplayMember = "Id";
            this.cmbMusteri.FormattingEnabled = true;
            this.cmbMusteri.Location = new System.Drawing.Point(147, 94);
            this.cmbMusteri.Name = "cmbMusteri";
            this.cmbMusteri.Size = new System.Drawing.Size(200, 21);
            this.cmbMusteri.TabIndex = 35;
            // 
            // lbltel
            // 
            this.lbltel.AutoSize = true;
            this.lbltel.Location = new System.Drawing.Point(35, 178);
            this.lbltel.Name = "lbltel";
            this.lbltel.Size = new System.Drawing.Size(67, 13);
            this.lbltel.TabIndex = 31;
            this.lbltel.Text = "Sipariş Tarihi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Agency FB", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(282, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 14);
            this.label3.TabIndex = 30;
            this.label3.Text = "*ZORUNLU ALANLARDIR HEPSİNİ DOLDURUNUZ.";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(388, 291);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(13, 13);
            this.lblId.TabIndex = 29;
            this.lblId.Text = "0";
            // 
            // txtsiparisNo
            // 
            this.txtsiparisNo.Location = new System.Drawing.Point(147, 56);
            this.txtsiparisNo.Multiline = true;
            this.txtsiparisNo.Name = "txtsiparisNo";
            this.txtsiparisNo.Size = new System.Drawing.Size(200, 20);
            this.txtsiparisNo.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Musteri *";
            // 
            // Ad
            // 
            this.Ad.AutoSize = true;
            this.Ad.Location = new System.Drawing.Point(35, 56);
            this.Ad.Name = "Ad";
            this.Ad.Size = new System.Drawing.Size(55, 13);
            this.Ad.TabIndex = 24;
            this.Ad.Text = "Sipariş No";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Ürün *";
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(287, 301);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 13;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(191, 301);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(75, 23);
            this.btnGuncelle.TabIndex = 12;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(87, 301);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 11;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // SiparisYonetimi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 521);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvSiparis);
            this.Name = "SiparisYonetimi";
            this.Text = "SiparisYonetimi";
            this.Load += new System.EventHandler(this.SiparisYonetimi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSiparis)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSiparis;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtsiparisNo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label Ad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.DateTimePicker dtpSiparisTarihi;
        private System.Windows.Forms.ComboBox cmbUrunler;
        private System.Windows.Forms.ComboBox cmbMusteri;
        private System.Windows.Forms.Label lbltel;
    }
}