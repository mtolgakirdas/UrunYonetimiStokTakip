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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnKategori_Click(object sender, EventArgs e)
        {
            KategoriYonetim kategoriYonetimi = new KategoriYonetim();
            kategoriYonetimi.ShowDialog();
        }

        private void btnKullanıcı_Click(object sender, EventArgs e)
        {
          KullaniciYonetimi kullaniciYonetimi = new KullaniciYonetimi();
            kullaniciYonetimi.ShowDialog();  
        }

        private void btnMarka_Click(object sender, EventArgs e)
        {
            MarkaYonetimi markaYonetimi = new MarkaYonetimi();
            markaYonetimi.ShowDialog();
        }

        private void btnmusteri_Click(object sender, EventArgs e)
        {
            MusteriYonetimi musteriYonetimi = new MusteriYonetimi();
            musteriYonetimi.ShowDialog();
        }

        private void btnSiparis_Click(object sender, EventArgs e)
        {
            SiparisYonetimi siparisYonetimi = new SiparisYonetimi();
            siparisYonetimi.ShowDialog();
        }

        private void btnUrun_Click(object sender, EventArgs e)
        {
            Urunyonetimi urunyonetimi = new Urunyonetimi();
            urunyonetimi.ShowDialog();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
