using BAL;
using Entities;
using System;
using System.Windows.Forms;

namespace UrunYonetimiStokTakip
{
    public partial class MusteriYonetimi : Form
    {
        public MusteriYonetimi()
        {
            InitializeComponent();
        }
        MusteriManager manager = new MusteriManager();
        void yukle()
        {
            dgvMusteri.DataSource = manager.GetAll();
        }
        void Temizle()
        {
            txtadi.Text = string.Empty;
            txtSoyad.Text = string.Empty;
            lblId.Text = "0";
            txtTelefon.Text = string.Empty;
            txtAdres.Text = string.Empty;
            txtEmail.Text = string.Empty;
           
        }

        private void MusteriYonetimi_Load(object sender, EventArgs e)
        {
            yukle();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtadi.Text) || string.IsNullOrWhiteSpace(txtSoyad.Text) || string.IsNullOrWhiteSpace(txtEmail.Text))
                {
                    MessageBox.Show("Lütfen zorunlu alanları doldurunuz");
                }
                else
                {
                    var sonuc = manager.Add(
                    new Musteri
                    {

                        Adres = txtAdres.Text,
                        Telefon = txtTelefon.Text,
                        Email = txtEmail.Text,
                        Adi = txtadi.Text,
                        Soyadi = txtSoyad.Text,



                    }
                    );
                    if (sonuc > 0)
                    {
                        yukle();
                        Temizle();
                        MessageBox.Show("Kayıt Eklendi!");
                    }

                }              
            }
            catch (Exception)
            {

                MessageBox.Show("Hata Oluştu Kayıt Eklenemedi!");
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {

                if (string.IsNullOrWhiteSpace(txtadi.Text) || string.IsNullOrWhiteSpace(txtSoyad.Text) || string.IsNullOrWhiteSpace(txtEmail.Text))
                {
                    MessageBox.Show("Lütfen zorunlu alanları doldurunuz");
                }
                else
                {
                    if (lblId.Text == "0")
                    {
                        MessageBox.Show("Listeden Güncellenecek Kaydı Seçiniz!");
                    }
                    else
                    {
                        var sonuc = manager.Update(
                           new Musteri
                           {
                               Id = Convert.ToInt32(lblId.Text),
                               Adres = txtAdres.Text,
                               Telefon = txtTelefon.Text,
                               Email = txtEmail.Text,
                               Adi = txtadi.Text,
                               Soyadi = txtSoyad.Text,



                           }
                           );
                            if (sonuc > 0)
                            {
                                yukle();
                                Temizle();
                                MessageBox.Show("Kayıt Güncellendi!");
                            }
                    }

                }
            }
            catch (Exception)
            {

                MessageBox.Show("Hata Oluştu Kayıt Güncellenemedi!");
            }
        }

        private void dgvMusteri_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                lblId.Text = dgvMusteri.CurrentRow.Cells[0].Value.ToString();
                txtadi.Text = dgvMusteri.CurrentRow.Cells[1].Value.ToString();
                txtSoyad.Text = dgvMusteri.CurrentRow.Cells[2].Value.ToString();
                txtEmail.Text = dgvMusteri.CurrentRow.Cells[3].Value.ToString();
                txtTelefon.Text = dgvMusteri.CurrentRow.Cells[4].Value.ToString();
                txtAdres.Text = dgvMusteri.CurrentRow.Cells[5].Value.ToString();
                
            }
            catch (Exception)
            {

                MessageBox.Show("Hata Oluştu!");
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                if (lblId.Text == "0")
                {
                    MessageBox.Show("Listeden Silinecek Kaydı Seçiniz!");
                }
                else
                {
                    var sonuc = manager.Delete(Convert.ToInt32(lblId.Text));
                    if (sonuc > 0)
                    {
                        yukle();
                        Temizle();
                        MessageBox.Show("Kayıt Silindi!");
                    }
                    else MessageBox.Show("Kayıt Silinemedi");

                }
            }
            catch (Exception)
            {

                MessageBox.Show("Hata Oluştu!");
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
            KullaniciYonetimi kullaniciYonetimi = new KullaniciYonetimi();
            this.Close();
            kullaniciYonetimi.ShowDialog();
        }

        private void ürünYönetimiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Urunyonetimi urunyonetimi = new Urunyonetimi();
            this.Close();
            urunyonetimi.ShowDialog();
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
