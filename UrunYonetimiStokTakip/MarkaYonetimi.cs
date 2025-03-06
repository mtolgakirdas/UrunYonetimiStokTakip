using BAL;
using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UrunYonetimiStokTakip
{
    public partial class MarkaYonetimi : Form
    {
        public MarkaYonetimi()
        {
            InitializeComponent();
        }
        MarkaManager manager = new MarkaManager();
        void yukle()
        {
            dgvMarkalar.DataSource = manager.GetAll();
        }
        private void MarkaYonetimi_Load(object sender, EventArgs e)
        {
            yukle();
        }

        void temizle()//textboxları ve cb yi ekledikten sonra temizler
        {
            txtMarkaAciklama.Text = string.Empty;
            txtMarkaAdi.Text = string.Empty;
            lblTarih.Text = string.Empty;
            cbDurum.Checked = false;
            lblİd.Text = "0";
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            int islemSonucu = manager.Add(
                new Marka
                {
                    MarkaAdi = txtMarkaAdi.Text,
                    Aciklama = txtMarkaAciklama.Text,
                    Aktif = cbDurum.Checked,
                    EklenmeTarihi = DateTime.Now,
                }



                );
            if (islemSonucu > 0)
            {
                temizle();
                yukle();
                MessageBox.Show("Kayıt Eklendi!!");
            }
            else
            {
                MessageBox.Show("Kayıt Eklenemedi");
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(lblİd.Text);
            if (id > 0)
            {
                int islemSonucu = manager.Update(
                    new Marka
                    {
                        Id = id,
                        MarkaAdi = txtMarkaAdi.Text,
                        Aciklama = txtMarkaAciklama.Text,
                        Aktif = cbDurum.Checked,
                        EklenmeTarihi = Convert.ToDateTime(lblTarih.Text),
                    }

                    );
                if (islemSonucu > 0)
                {
                    temizle();
                    yukle();
                    MessageBox.Show("Kayıt Güncellendi!!");
                }
                else
                {
                    MessageBox.Show("Kayıt Güncellenemedi.");
                }

            }
            else MessageBox.Show("Lütfen Güncellenecek Kaydı seçiniz");
        }

        private void dgvMarkalar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblİd.Text = dgvMarkalar.CurrentRow.Cells[0].Value.ToString();
            lblTarih.Text = dgvMarkalar.CurrentRow.Cells[3].Value.ToString();
            txtMarkaAdi.Text = dgvMarkalar.CurrentRow.Cells[1].Value.ToString();
            cbDurum.Checked = Convert.ToBoolean(dgvMarkalar.CurrentRow.Cells[4].Value.ToString());
            txtMarkaAciklama.Text = dgvMarkalar.CurrentRow.Cells[2].Value.ToString();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {

            int id = Convert.ToInt32(lblİd.Text);
            if (id > 0)
            {
                
                if (MessageBox.Show("Silmek İstediğinize Emin misiniz?", "Uyarı", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    int islemSonucu = manager.Delete(id);
                    if (islemSonucu > 0)
                    {
                        temizle();
                        yukle();
                        MessageBox.Show("Kayıt Silindi!!");
                    }
                    else MessageBox.Show("Kayıt Silinemedi");

                }
                
            }
            else MessageBox.Show("Lütfen Silinecek Kaydı seçiniz");


        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }

}
