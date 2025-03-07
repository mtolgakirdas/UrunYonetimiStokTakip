using BAL;
using System;
using System.Windows.Forms;
using Entities;

namespace UrunYonetimiStokTakip
{
    public partial class Urunyonetimi : Form
    {
        public Urunyonetimi()
        {
            InitializeComponent();
        }
        UrunManager manager = new UrunManager();
        KategoriManager kategoriManager = new KategoriManager();
        MarkaManager markaManager = new MarkaManager();
        public void yukle()
        {
            dgvUrunler.DataSource = manager.GetAll();
            cmbUrunkategorisi.DataSource = kategoriManager.GetAll();
            cmbUrunMarkasi.DataSource = markaManager.GetAll();

        }
        public void Temizle()
        {
            txtUrunAdi.Text =string.Empty;
            txtKDV.Text = string.Empty;
            txtStokMiktari.Text = string.Empty;
            txtUrunFiyati.Text = string.Empty;
            rtbUrunAciklamasi.Text = string.Empty;
            cbDurum.Checked = false;
            cmbUrunkategorisi.SelectedIndex = 0;
            cmbUrunMarkasi.SelectedIndex = 0;
            txtIskonto.Text = string.Empty;
            LblEklenmeTarihi.Text = string.Empty;
        }

        private void Urunyonetimi_Load(object sender, EventArgs e)
        {
            yukle();

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtUrunFiyati.Text))
            {
                try
                {
                    var sonuc = manager.Add(
                       new Urun
                       {
                           UrunAdi = txtUrunAdi.Text,
                           UrunFiyati = Convert.ToDecimal(txtUrunFiyati.Text),
                           UrunAciklama = rtbUrunAciklamasi.Text,
                           Aktif = cbDurum.Checked,
                           EklenmeTarihi = DateTime.Now,
                           Iskonto = Convert.ToInt32(txtIskonto.Text),
                           KDV = Convert.ToInt32(txtKDV.Text),
                           StokMiktari = Convert.ToInt32(txtStokMiktari.Text),
                           ToptanFiyat = Convert.ToDecimal(txtUrunFiyati.Text),
                           KategoriId = int.Parse(cmbUrunkategorisi.SelectedValue.ToString()),
                           MarkaId = int.Parse(cmbUrunMarkasi.SelectedValue.ToString()),


                       }

                     );
                    if (sonuc > 0)
                    {
                        Temizle();
                        yukle();
                        MessageBox.Show("Kayıt Eklendi!");
                    }
                }
                catch (Exception)
                {

                    MessageBox.Show("Hata Oluştu Kayıt Eklenemedi!");
                }
            }
            else MessageBox.Show("Ürün Fiyatı Alanı Boş Geçilemez.");
            
           
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtUrunFiyati.Text))
            {
                try
                {   int urunId = Convert.ToInt32(lblId.Text);
                    if (urunId > 0)
                    {
                        var sonuc = manager.Update(
                       new Urun
                       {
                           Id = urunId,
                           UrunAdi = txtUrunAdi.Text,
                           UrunFiyati = Convert.ToDecimal(txtUrunFiyati.Text),
                           UrunAciklama = rtbUrunAciklamasi.Text,
                           Aktif = cbDurum.Checked,
                           EklenmeTarihi = DateTime.Now,
                           Iskonto = Convert.ToInt32(txtIskonto.Text),
                           KDV = Convert.ToInt32(txtKDV.Text),
                           StokMiktari = Convert.ToInt32(txtStokMiktari.Text),
                           ToptanFiyat = Convert.ToDecimal(txtUrunFiyati.Text),
                           KategoriId = int.Parse(cmbUrunkategorisi.SelectedValue.ToString()),
                           MarkaId = int.Parse(cmbUrunMarkasi.SelectedValue.ToString()),


                       }

                     );
                        if (sonuc > 0)
                        {
                            Temizle();
                            yukle();
                            MessageBox.Show("Kayıt Güncellendi!");
                        }
                    }
                    else MessageBox.Show("Listeden Kayıt Seçiniz!");
                  
                }
                catch (Exception)
                {

                    MessageBox.Show("Hata Oluştu Kayıt Güncellenemedi!");
                }
            }
            else MessageBox.Show("Ürün Fiyatı Alanı Boş Geçilemez.");

        }

        private void dgvUrunler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            { 
                lblId.Text = dgvUrunler.CurrentRow.Cells[0].Value.ToString();
                int urunId = Convert.ToInt32(lblId.Text);
                if (urunId > 0) {
                    var urun = manager.Get(urunId);
                    if (urun != null)
                    {
                        txtIskonto.Text = urun.Iskonto.ToString();
                        txtKDV.Text = urun.KDV.ToString();
                        txtStokMiktari.Text = urun.StokMiktari.ToString();
                        txtUrunAdi.Text = urun.UrunAdi;
                        txtUrunFiyati.Text = urun.UrunFiyati.ToString();
                        rtbUrunAciklamasi.Text = urun.UrunAciklama;
                        cbDurum.Checked = urun.Aktif;
                        LblEklenmeTarihi.Text = urun.EklenmeTarihi.ToString();
                        cmbUrunkategorisi.SelectedValue = urun.KategoriId;
                        cmbUrunMarkasi.SelectedValue = urun.MarkaId;
                    }
                    else MessageBox.Show("Ürün Kaydı Silinmiş. Güncellenemez!");
                }
                
                
                
            }
            catch (Exception)
            {

                MessageBox.Show("Kayıt değerlerine tekrar Bakınız\\n null alan girmeyiniz");
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                if (lblId.Text == "0")
                {
                    MessageBox.Show("Lütfen Silinecek Kaydı Seçiniz.");
                }
                else
                {
                    var sonuc = manager.Delete(Convert.ToInt32(lblId.Text));
                    if (sonuc > 0)
                    {
                        Temizle();
                        yukle();
                        MessageBox.Show("Kayıt Silinmiştir!");
                    }



                }
            }
            catch (Exception)
            {

                MessageBox.Show("Hata Oluştu Kayıt Silinemedi!");
            }
           
        }

        private void markaYonetimiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MarkaYonetimi markaYonetimi = new MarkaYonetimi();
            this.Close();
            markaYonetimi.ShowDialog();
        }

        private void kategoriYönetimiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KategoriYonetim kategoriYonetim = new KategoriYonetim();
            this.Close();
            kategoriYonetim.ShowDialog();
        }

        private void kullanıcıYöneyimiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KullaniciYonetimi kullaniciYonetimi =new KullaniciYonetimi();
            this.Close();
            kullaniciYonetimi.ShowDialog();
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
