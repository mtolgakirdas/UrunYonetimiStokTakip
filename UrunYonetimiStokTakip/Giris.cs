using BAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UrunYonetimiStokTakip
{
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent(); 
        }
        KullaniciManager manager = new KullaniciManager();
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtKullaniciAdi.Text) || string.IsNullOrWhiteSpace(txtSifre.Text))
            {
                MessageBox.Show("Kullanıcı Adı veya Şifre Yanlış.");
            }
            else
            {
                var kullanici = manager.Find(k => k.KullaniciAdi == txtKullaniciAdi.Text && k.Sifre == txtSifre.Text && k.Aktif == true);
                if (kullanici != null)
                {
                    Menu menu = new Menu();
                    this.Hide();
                    menu.Show();

                }
                else MessageBox.Show("Kullanıcı Veya Şifre Hatalıdır");
            }
        }

        private void Giris_Load(object sender, EventArgs e)
        {

        }
    }
}
