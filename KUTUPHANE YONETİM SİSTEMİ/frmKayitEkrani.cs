using GRUP6;
using System;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using System.Text.RegularExpressions;

namespace GRUP6
{
    public partial class frmKayitEkrani : Form
    {
        public frmKayitEkrani()
        {
            InitializeComponent();
        }

        private string SifreHashle(string sifre)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(sifre));
                StringBuilder builder = new StringBuilder();
                foreach (var b in bytes) builder.Append(b.ToString("x2"));
                return builder.ToString();
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAd.Text) || string.IsNullOrWhiteSpace(txtSoyad.Text) ||
                string.IsNullOrWhiteSpace(txtEposta.Text) || string.IsNullOrWhiteSpace(txtSifre.Text) ||
                string.IsNullOrWhiteSpace(txtOkulNo.Text) || string.IsNullOrWhiteSpace(txtTelefonNumarası.Text))
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz.", "Uyarı");
                return;
            }

            if (!EpostaGecerliMi(txtEposta.Text.Trim()))
            {
                MessageBox.Show("Lütfen geçerli bir e-posta adresi giriniz.", "Hatalı Giriş");
                return;
            }

            if (!SifreUygunMu(txtSifre.Text))
            {
                MessageBox.Show("Şifre en az 8 karakter uzunluğunda olmalı; büyük harf, küçük harf, rakam ve en az bir özel karakter içermelidir.", "Zayıf Şifre");
                return;
            }

            if (txtOkulNo.Text.Length != 10 || !txtOkulNo.Text.All(char.IsDigit))
            {
                MessageBox.Show("Okul numarası tam olarak 10 haneli olmalı ve sadece rakamlardan oluşmalıdır.", "Hatalı Giriş");
                return;
            }

            if (txtTelefonNumarası.Text.Length != 10 || !txtTelefonNumarası.Text.All(char.IsDigit))
            {
                MessageBox.Show("Telefon numarası tam olarak 10 haneli olmalı ve sadece rakamlardan oluşmalıdır.", "Hatalı Giriş");
                return;
            }

            string sorgu = "INSERT INTO Kullanicilar (ad, soyad, eposta, sifre_hashed, okul_numarasi, telefon, rol) VALUES (@ad, @soyad, @eposta, @sifre, @okul, @tel, 'Öğrenci')";

            SqlParameter[] parametreler = {
                new SqlParameter("@ad", txtAd.Text.Trim()),
                new SqlParameter("@soyad", txtSoyad.Text.Trim()),
                new SqlParameter("@eposta", txtEposta.Text.Trim()),
                new SqlParameter("@sifre", SifreHashle(txtSifre.Text)),
                new SqlParameter("@okul", txtOkulNo.Text.Trim()),
                new SqlParameter("@tel", txtTelefonNumarası.Text.Trim())
            };

            try
            {
                DbHelper.ExecuteCommand(sorgu, parametreler);
                MessageBox.Show("Kaydınız başarıyla oluşturuldu.", "Başarılı");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kayıt sırasında bir hata oluştu: " + ex.Message, "Hata");
            }
        }

        private bool EpostaGecerliMi(string eposta)
        {
            try
            {
                var regex = new Regex(@"^[^@\s]+@[^@\s]+\.[^@\s]+$");
                return regex.IsMatch(eposta);
            }
            catch
            {
                return false;
            }
        }

        private bool SifreUygunMu(string sifre)
        {
            return sifre.Length >= 8 &&
                   sifre.Any(char.IsUpper) &&
                   sifre.Any(char.IsLower) &&
                   sifre.Any(char.IsDigit) &&
                   sifre.Any(ch => !char.IsLetterOrDigit(ch));
        }
    }
}