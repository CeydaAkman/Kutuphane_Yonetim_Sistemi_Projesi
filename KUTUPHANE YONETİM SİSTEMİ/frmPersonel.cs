using System;
using System.Windows.Forms;
using GRUP6;

namespace GRUP6
{
    public partial class frmPersonel : Form
    {
        private int _mevcutKullaniciId;

        public frmPersonel(int id)
        {
            InitializeComponent();
            _mevcutKullaniciId = id;
        }

        private void btnBekleyenTalepler_Click(object sender, EventArgs e)
        {
            try
            {
                frmBekleyenTalepler talepler = new frmBekleyenTalepler(_mevcutKullaniciId);
                talepler.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bekleyen talepler sayfası yüklenemedi. " + ex.Message, "Form Hatası");
            }
        }

        private void btnKitapTeslimEtme_Click(object sender, EventArgs e)
        {
            try
            {
                new frmKitapTeslimVeİadeEtme().Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kitap teslim ve iade etme sayfası yüklenemedi. " + ex.Message, "Form Hatası");
            }
        }

        private void btnGecikenKitaplar_Click(object sender, EventArgs e)
        {
            try { new frmGecikenKitaplar().Show(); }
            catch (Exception ex) { MessageBox.Show("Geciken kitaplar sayfası yüklenemedi. " + ex.Message, "Form Hatası"); }
        }

        private void btnIstatistikler_Click(object sender, EventArgs e)
        {
            try { new frmIstatistikler().Show(); }
            catch (Exception ex) { MessageBox.Show("İstatistikler sayfası yüklenemedi. " + ex.Message, "Form Hatası"); }
        }

        private void btnCikisYap_Click(object sender, EventArgs e)
        {
            frmGirisEkrani girişEkrani = new frmGirisEkrani();
            girişEkrani.Show();
            this.Close();
        }
    }
}