using GRUP6;
using System;
using System.Data;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace GRUP6
{
    public partial class frmGirisEkrani : Form
    {
        public frmGirisEkrani()
        {
            InitializeComponent();
        }

        private string SifreHashle(string sifre)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(sifre));
                StringBuilder builder = new StringBuilder();
                foreach (byte b in bytes)
                {
                    builder.Append(b.ToString("x2"));
                }
                return builder.ToString();
            }
        }

        private void btnGirisYapma_Click(object sender, EventArgs e)
        {
            string sorgu = "SELECT rol, kullanici_id FROM Kullanicilar WHERE eposta = @ep AND sifre_hashed = @sifre";

            SqlParameter[] parametreler = {
                new SqlParameter("@ep", txtEpostaGiris.Text.Trim()),
                new SqlParameter("@sifre", SifreHashle(txtSifreGiris.Text.Trim()))
            };

            DataTable dt = DbHelper.GetData(sorgu, parametreler);

            if (dt.Rows.Count > 0)
            {
                string rol = dt.Rows[0]["rol"].ToString();
                int kullaniciId = Convert.ToInt32(dt.Rows[0]["kullanici_id"]);

                if (rol == "Öğrenci")
                {
                    new frmOgrenci(kullaniciId).Show();
                }
                else if (rol == "Personel")
                {
                    new frmPersonel(kullaniciId).Show();
                }
                else if (rol == "Yönetici")
                {
                    new frmYonetici(kullaniciId).Show();
                }

                this.Hide();
            }
            else
            {
                MessageBox.Show("E-posta veya şifre hatalı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            frmKayitEkrani kayitFormu = new frmKayitEkrani();
            kayitFormu.Show();
        }
    }
}