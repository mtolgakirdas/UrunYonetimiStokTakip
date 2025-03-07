namespace UrunYonetimiStokTakip
{
    partial class Menu
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
            this.btnKategori = new System.Windows.Forms.Button();
            this.btnKullanıcı = new System.Windows.Forms.Button();
            this.btnMarka = new System.Windows.Forms.Button();
            this.btnUrun = new System.Windows.Forms.Button();
            this.btnmusteri = new System.Windows.Forms.Button();
            this.btnSiparis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnKategori
            // 
            this.btnKategori.Location = new System.Drawing.Point(149, 107);
            this.btnKategori.Name = "btnKategori";
            this.btnKategori.Size = new System.Drawing.Size(89, 52);
            this.btnKategori.TabIndex = 0;
            this.btnKategori.Text = "Kategori Yönetimi";
            this.btnKategori.UseVisualStyleBackColor = true;
            this.btnKategori.Click += new System.EventHandler(this.btnKategori_Click);
            // 
            // btnKullanıcı
            // 
            this.btnKullanıcı.Location = new System.Drawing.Point(268, 108);
            this.btnKullanıcı.Name = "btnKullanıcı";
            this.btnKullanıcı.Size = new System.Drawing.Size(89, 52);
            this.btnKullanıcı.TabIndex = 1;
            this.btnKullanıcı.Text = "Kullanıcı Yönetimi";
            this.btnKullanıcı.UseVisualStyleBackColor = true;
            this.btnKullanıcı.Click += new System.EventHandler(this.btnKullanıcı_Click);
            // 
            // btnMarka
            // 
            this.btnMarka.Location = new System.Drawing.Point(368, 108);
            this.btnMarka.Name = "btnMarka";
            this.btnMarka.Size = new System.Drawing.Size(89, 52);
            this.btnMarka.TabIndex = 2;
            this.btnMarka.Text = "Marka Yönetimi";
            this.btnMarka.UseVisualStyleBackColor = true;
            this.btnMarka.Click += new System.EventHandler(this.btnMarka_Click);
            // 
            // btnUrun
            // 
            this.btnUrun.Location = new System.Drawing.Point(382, 218);
            this.btnUrun.Name = "btnUrun";
            this.btnUrun.Size = new System.Drawing.Size(75, 52);
            this.btnUrun.TabIndex = 3;
            this.btnUrun.Text = "Ürün Yönetimi";
            this.btnUrun.UseVisualStyleBackColor = true;
            this.btnUrun.Click += new System.EventHandler(this.btnUrun_Click);
            // 
            // btnmusteri
            // 
            this.btnmusteri.Location = new System.Drawing.Point(149, 218);
            this.btnmusteri.Name = "btnmusteri";
            this.btnmusteri.Size = new System.Drawing.Size(89, 52);
            this.btnmusteri.TabIndex = 4;
            this.btnmusteri.Text = "Müşteri Yönetimi";
            this.btnmusteri.UseVisualStyleBackColor = true;
            this.btnmusteri.Click += new System.EventHandler(this.btnmusteri_Click);
            // 
            // btnSiparis
            // 
            this.btnSiparis.Location = new System.Drawing.Point(268, 218);
            this.btnSiparis.Name = "btnSiparis";
            this.btnSiparis.Size = new System.Drawing.Size(89, 52);
            this.btnSiparis.TabIndex = 5;
            this.btnSiparis.Text = "Sipariş Yönetimi";
            this.btnSiparis.UseVisualStyleBackColor = true;
            this.btnSiparis.Click += new System.EventHandler(this.btnSiparis_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSiparis);
            this.Controls.Add(this.btnmusteri);
            this.Controls.Add(this.btnUrun);
            this.Controls.Add(this.btnMarka);
            this.Controls.Add(this.btnKullanıcı);
            this.Controls.Add(this.btnKategori);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Menu_FormClosed);
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnKategori;
        private System.Windows.Forms.Button btnKullanıcı;
        private System.Windows.Forms.Button btnMarka;
        private System.Windows.Forms.Button btnUrun;
        private System.Windows.Forms.Button btnmusteri;
        private System.Windows.Forms.Button btnSiparis;
    }
}