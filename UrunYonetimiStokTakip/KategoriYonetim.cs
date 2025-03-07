using System;
using System.Windows.Forms;
using BAL;
using Entities;

namespace UrunYonetimiStokTakip
{
    public partial class KategoriYonetim : Form
    {
        public KategoriYonetim()
        {
            InitializeComponent();
        }
        KategoriManager manager = new KategoriManager();
        void yukle()
        {
            dgvKategoriler.DataSource = manager.GetAll();
        }
        void Temizle()
        {
            txtKategoriAdi.Text = string.Empty;
            txtKategoriAciklama.Text = string.Empty;
            lblId.Text = "0";
            LblEklenmeTarihi.Text = string.Empty;
            cbDurum.Checked= false;
        }
        private void KategoriYonetim_Load(object sender, EventArgs e)
        {
            yukle();
            
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {

            try
            {
                var sonuc = manager.Add(
               new Kategori
               {
                   KategoriAdi = txtKategoriAdi.Text,
                   KategoriAciklama = txtKategoriAciklama.Text,
                   Aktif = cbDurum.Checked,
                   EklenmeTarihi = DateTime.Now,
               }
               );
                if (sonuc > 0)
                {
                    Temizle();
                    yukle();
                    MessageBox.Show("Kayıt Eklendi!");



                }
            }
            catch (Exception hata)//Buradaki hata nesensinden hata detaylarına ulaşabiliriz.
            {

                MessageBox.Show("Hata Oluştu Kayıt Eklenemedi!n\\Boş Alan Bırakmadan Tekrar Deneyin");
            }
           
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {

                var sonuc = manager.Update(
               new Kategori
               {
                   Id = int.Parse(lblId.Text),
                   KategoriAdi = txtKategoriAdi.Text,
                   KategoriAciklama = txtKategoriAciklama.Text,
                   Aktif = cbDurum.Checked,
                   EklenmeTarihi = Convert.ToDateTime(LblEklenmeTarihi.Text)
               }
               );
                if (sonuc > 0)
                {
                    Temizle();
                    yukle();
                    MessageBox.Show("Kayıt Güncellendi!");



                }
            }
            catch (Exception hata)//Buradaki hata nesensinden hata detaylarına ulaşabiliriz.
            {

                MessageBox.Show("Hata Oluştu Kayıt Güncellenemedi!n\\Boş Alan Bırakmadan Tekrar Deneyin");
            }


        }

        private void dgvKategoriler_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                lblId.Text = dgvKategoriler.CurrentRow.Cells[0].Value.ToString();
                txtKategoriAdi.Text = dgvKategoriler.CurrentRow.Cells[1].Value.ToString();
                txtKategoriAciklama.Text = dgvKategoriler.CurrentRow.Cells[2].Value.ToString();
                LblEklenmeTarihi.Text = dgvKategoriler.CurrentRow.Cells[3].Value.ToString();
                cbDurum.Checked = Convert.ToBoolean(dgvKategoriler.CurrentRow.Cells[4].Value);
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
                if(lblId.Text == "0")
                {
                    MessageBox.Show("Listeden seçilecek kaydı seçiniz");
                }
                else
                {
                    var sonuc = manager.Delete(int.Parse(lblId.Text));
                    if (sonuc > 0)
                    {
                        Temizle();
                        yukle();

                        DialogResult result = MessageBox.Show("Kayıt silinsin mi?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            MessageBox.Show("Kayıt silindi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Silme işlemi iptal edildi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                
            }
            catch (Exception)
            {
                MessageBox.Show("Hata Oluştu Kayıt Silinemedi.");
               
            }
        }

        private void markaYönetimiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MarkaYonetimi markaYonetimi = new MarkaYonetimi();
            this.Close();
            markaYonetimi.ShowDialog();
        }

        private void ürünYönetimiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Urunyonetimi urunyonetimi = new Urunyonetimi();
            this.Close();
            urunyonetimi.ShowDialog();
        }

        private void kullanıcıYönetimiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KullaniciYonetimi kullaniciYonetimi = new KullaniciYonetimi();
            this.Close();
            kullaniciYonetimi.ShowDialog();
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
