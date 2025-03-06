using BAL;
using System;
using System.Windows.Forms;
using Entities;
namespace UrunYonetimiStokTakip
{
    public partial class KullaniciYonetimi : Form
    {
        

        public KullaniciYonetimi()
        {
            InitializeComponent();
        }
        KullaniciManager manager = new KullaniciManager();
        public void yukle()
        {
            dgvKullanicilar.DataSource = manager.GetAll();
        }

        public void Temizle()
        {
            txtKullaniciAdi.Text = string.Empty;
            txtSifre.Text = string.Empty;
            lblId.Text = "0";
            txtEmail.Text = string.Empty;
            txtadi.Text = string.Empty;
            txtSoyad.Text = string.Empty;
            cbDurum.Checked = false;
            
        }
        private void KullaniciYonetimi_Load(object sender, EventArgs e)
        {
            yukle();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                var sonuc = manager.Add(
                    new Kullanici
                    {
                        
                        KullaniciAdi = txtEmail.Text,
                        Sifre = txtSifre.Text,
                        Email = txtEmail.Text,
                        Adi = txtadi.Text,
                        Soyadi = txtSoyad.Text,
                        Aktif = cbDurum.Checked,
                        
                        

                    }
                    );
                if(sonuc > 0 )
                {
                    yukle();
                    Temizle();
                    MessageBox.Show("Kayıt Eklendi!");
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
                var sonuc = manager.Update(
                    new Kullanici
                    {
                        Id = Convert.ToInt32(lblId.Text),
                        KullaniciAdi = txtEmail.Text,
                        Sifre = txtSifre.Text,
                        Email = txtEmail.Text,
                        Adi = txtadi.Text,
                        Soyadi = txtSoyad.Text,
                        Aktif = cbDurum.Checked,



                    }
                    );
                if (sonuc > 0)
                {
                    yukle();
                    Temizle();
                    MessageBox.Show("Kayıt Güncellendi!");
                }



            }
            catch (Exception)
            {

                MessageBox.Show("Hata Oluştu Kayıt Eklenemedi!");
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                if(lblId.Text == "0")
                {
                    MessageBox.Show("Listeden seçilecek kaydı seçiniz");
                }
                else
                {
                    var sonuc = manager.Delete(Convert.ToInt32(lblId.Text));
                    if(sonuc > 0)
                    {
                        Temizle();
                        yukle();
                        MessageBox.Show("Kayıt Silindi!");
                    }

                }
            }
            catch (Exception)
            {

                MessageBox.Show("Hata Oluştu Kayıt Silinemedi!\\n Kayıt Seçiniz.");
            }
        }

        private void kategoriYönetimiToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void markaYonetimiToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ürünYönetimiToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dgvKullanicilar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                lblId.Text = dgvKullanicilar.CurrentRow.Cells[0].Value.ToString();
                txtKullaniciAdi.Text = dgvKullanicilar.CurrentRow.Cells[1].Value.ToString();
                txtSifre.Text = dgvKullanicilar.CurrentRow.Cells[2].Value.ToString();
                txtEmail.Text = dgvKullanicilar.CurrentRow.Cells[3].Value.ToString();
                txtadi.Text = dgvKullanicilar.CurrentRow.Cells[4].Value.ToString();
                txtSoyad.Text = dgvKullanicilar.CurrentRow.Cells[5].Value.ToString();
                cbDurum.Checked = Convert.ToBoolean(dgvKullanicilar.CurrentRow.Cells[6].Value);

                
                
            }
            catch (Exception)
            {

                MessageBox.Show("Kayıtlarda Hata Oluştu \\nBoş Alan Bırakmayınız.");
            }
          



        }

        private void lblId_Click(object sender, EventArgs e)
        {

        }
    }
}
