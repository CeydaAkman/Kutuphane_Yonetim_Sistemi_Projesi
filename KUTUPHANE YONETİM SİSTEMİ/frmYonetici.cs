using System;
using System.Windows.Forms;
using GRUP6;

namespace GRUP6
{
    public partial class frmYonetici : Form
    {
        private int _mevcutYoneticiId;

        public frmYonetici(int id)
        {
            InitializeComponent();
            _mevcutYoneticiId = id;
        }
        private void btnEnvanterYonetimi_Click(object sender, EventArgs e)
        {
            try { new frmEnvanterYonetimi().Show(); }
            catch (Exception ex) { MessageBox.Show("Envanter yönetimi sayfası yüklenemedi. " + ex.Message, "Form Hatası"); }
        }

        private void btnKullaniciYonetimi_Click(object sender, EventArgs e)
        {
            try { new frmKullaniciYonetimi().Show(); }
            catch (Exception ex) { MessageBox.Show("Kullanıcı yönetimi sayfası yüklenemedi. " + ex.Message, "Form Hatası"); }
        }

        private void btnRaporlarVeAnalizler_Click(object sender, EventArgs e)
        {
            try { new frmRaporlarVeAnalizler().Show(); } 
            catch (Exception ex) { MessageBox.Show("Raporlar ve analizler sayfası yüklenemedi. " + ex.Message, "Form Hatası"); }
        }
        private void btnCikisYap_Click(object sender, EventArgs e)
        {
            frmGirisEkrani girişEkrani = new frmGirisEkrani();
            girişEkrani.Show();
            this.Close();
        }
    }
}