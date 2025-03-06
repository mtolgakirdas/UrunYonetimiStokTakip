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
        public void yukle()
        {
            dgvUrunler.DataSource = manager.GetAll();

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
        }

        private void Urunyonetimi_Load(object sender, EventArgs e)
        {
            yukle();

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            var sonuc = manager.Add(
                new Urun
                {
                    
                }

                );
        }
    }
}
