using BAL;
using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UrunYonetimiStokTakip
{
    public partial class SiparisYonetimi : Form
    {
        public SiparisYonetimi()
        {
            InitializeComponent();
        }
        SiparisManager manager = new SiparisManager();
        MusteriManager musteri = new MusteriManager();
        UrunManager urun = new UrunManager();   

        void yukle()
        {
            dgvSiparis.DataSource = manager.GetAll();
            cmbMusteri.DataSource = musteri.GetAll();
            cmbUrunler.DataSource = urun.GetAll();
            cmbMusteri.DisplayMember = "Adi";
            cmbMusteri.ValueMember = "Id";
            cmbUrunler.DisplayMember = "UrunAdi";
            cmbUrunler.ValueMember = "Id";
            dgvSiparis.Columns.Remove("Urun");
            dgvSiparis.Columns.Remove("Musteri");
        }
        void temizle()
        {
            txtsiparisNo.Text= string.Empty;
            lblId.Text = "0";

        }
        private void SiparisYonetimi_Load(object sender, EventArgs e)
        {
            yukle();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                var sonuc = manager.Add(
                new Siparis
                {
                    MusteriId = Convert.ToInt32(cmbMusteri.SelectedValue),
                    siparisNo = txtsiparisNo.Text,
                    SiparisTarihi = dtpSiparisTarihi.Value,
                    UrunId = Convert.ToInt32(cmbUrunler.SelectedValue)
                }
                );
                if (sonuc > 0)
                {
                    yukle();
                    temizle();
                    MessageBox.Show("Kayıt eklendi!");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Hata Oluştu! Kayıt Eklenemedi.");
            }
            

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                if (lblId.Text !="0")
                {
                var sonuc = manager.Update(
                new Siparis
                {
                    Id = Convert.ToInt32(lblId.Text),
                    MusteriId = Convert.ToInt32(cmbMusteri.SelectedValue),
                    siparisNo = txtsiparisNo.Text,
                    SiparisTarihi = dtpSiparisTarihi.Value,
                    UrunId = Convert.ToInt32(cmbUrunler.SelectedValue)
                }
                );
                    if (sonuc > 0)
                    {
                        yukle();
                        temizle();
                        MessageBox.Show("Kayıt Güncellendi!");
                    }
                }
                else MessageBox.Show("Listeden Güncellenecek Kaydı Seçiniz.");
            }
            catch (Exception)
            {

                MessageBox.Show("Hata Oluştu! Kayıt Güncellenemedi.");
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
                        temizle();
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

        private void dgvSiparis_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
               var siparis = manager.Get(Convert.ToInt32(dgvSiparis.CurrentRow.Cells[0].Value));
                txtsiparisNo.Text = siparis.siparisNo;
                cmbMusteri.SelectedValue = siparis.MusteriId;
                cmbUrunler.SelectedValue = siparis.UrunId;
                dtpSiparisTarihi.Value = siparis.SiparisTarihi;
                lblId.Text = dgvSiparis.CurrentRow.Cells[0].Value.ToString();
            }
            catch (Exception)
            {

                MessageBox.Show("Hata Oluştu!");
            }
        }
    }
}
