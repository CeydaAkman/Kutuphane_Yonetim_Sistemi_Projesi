using GRUP6;
using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace GRUP6
{
    public partial class frmKullaniciYonetimi : Form
    {
        public frmKullaniciYonetimi()
        {
            InitializeComponent();
            RolleriYukle();
            KullanicilariListele();

            this.cmbRolFiltre.SelectedIndexChanged += new System.EventHandler(this.cmbRolFiltre_SelectedIndexChanged);
            this.dgvKullanicilar.CellContentClick += new DataGridViewCellEventHandler(this.dgvKullanicilar_CellContentClick);
        }

        private void RolleriYukle()
        {
            string[] roller = { "Tümü", "Öğrenci", "Personel", "Yönetici" };
            cmbRolFiltre.Items.Clear();
            cmbRolFiltre.Items.AddRange(roller);
            cmbRolFiltre.SelectedIndex = 0;
        }

        private void KullanicilariListele(string rolFiltresi = "")
        {
            string whereClause = "";
            if (!string.IsNullOrEmpty(rolFiltresi) && rolFiltresi != "Tümü")
            {
                whereClause = $" WHERE rol = '{rolFiltresi}'";
            }

            string sorgu = "SELECT kullanici_id, ad AS 'Ad', soyad AS 'Soyad', eposta AS 'Eposta', rol AS 'Mevcut Rol' " +
                           "FROM Kullanicilar " + whereClause + " ORDER BY rol, soyad";

            DataTable dt = GRUP6.DbHelper.GetData(sorgu);

            dgvKullanicilar.DataSource = null;
            dgvKullanicilar.Columns.Clear();
            dgvKullanicilar.AutoGenerateColumns = true;
            dgvKullanicilar.DataSource = dt;

            if (dgvKullanicilar.Columns.Contains("kullanici_id")) dgvKullanicilar.Columns["kullanici_id"].Visible = false;
            if (dgvKullanicilar.Columns.Contains("Mevcut Rol")) dgvKullanicilar.Columns["Mevcut Rol"].Visible = false;

            if (!dgvKullanicilar.Columns.Contains("cmbRol"))
            {
                DataGridViewComboBoxColumn cmbSutun = new DataGridViewComboBoxColumn();
                cmbSutun.HeaderText = "Yeni Rol Seçimi";
                cmbSutun.Name = "cmbRol";
                cmbSutun.DataPropertyName = "Mevcut Rol";
                cmbSutun.Items.AddRange(new string[] { "Öğrenci", "Personel", "Yönetici" });
                dgvKullanicilar.Columns.Add(cmbSutun);
            }

            if (!dgvKullanicilar.Columns.Contains("btnRolDegistirDGV"))
            {
                DataGridViewButtonColumn btnSutun = new DataGridViewButtonColumn();
                btnSutun.HeaderText = "İşlem";
                btnSutun.Text = "Rol Değiştir";
                btnSutun.Name = "btnRolDegistirDGV";
                btnSutun.UseColumnTextForButtonValue = true;
                dgvKullanicilar.Columns.Add(btnSutun);
            }

            int toplamSutunSayisi = dgvKullanicilar.Columns.Count;
            if (toplamSutunSayisi >= 2)
            {
                if (dgvKullanicilar.Columns.Contains("btnRolDegistirDGV"))
                    dgvKullanicilar.Columns["btnRolDegistirDGV"].DisplayIndex = toplamSutunSayisi - 1;

                if (dgvKullanicilar.Columns.Contains("cmbRol"))
                    dgvKullanicilar.Columns["cmbRol"].DisplayIndex = toplamSutunSayisi - 2;
            }
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

        private void AlanlariTemizle()
        {
            txtAd.Clear();
            txtSoyisim.Clear();
            txtEposta.Clear();
            txtNumara.Clear();
            txtSifre.Clear();
        }
        private bool SifreUygunMu(string sifre)
        {
            return sifre.Length >= 8 &&
                   sifre.Any(char.IsUpper) &&
                   sifre.Any(char.IsLower) &&
                   sifre.Any(char.IsDigit) &&
                   sifre.Any(ch => !char.IsLetterOrDigit(ch));
        }

        private bool EpostaGecerliMi(string eposta)
        {
            var regex = new Regex(@"^[^@\s]+@[^@\s]+\.[^@\s]+$");
            return regex.IsMatch(eposta);
        }

        private void RolDegistir(int id, string yeniRol)
        {
            string sorgu = "UPDATE Kullanicilar SET rol = @rol WHERE kullanici_id = @id";
            SqlParameter[] parametreler = {
                new SqlParameter("@rol", yeniRol),
                new SqlParameter("@id", id)
            };

            try
            {
                GRUP6.DbHelper.ExecuteCommand(sorgu, parametreler);
                MessageBox.Show($"Kullanıcının rolü başarıyla '{yeniRol}' olarak güncellendi.", "Başarılı");
                KullanicilariListele(cmbRolFiltre.SelectedItem.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Rol güncelleme hatası: " + ex.Message);
            }
        }

        private void cmbRolFiltre_SelectedIndexChanged(object sender, EventArgs e)
        {
            KullanicilariListele(cmbRolFiltre.SelectedItem.ToString());
        }

        private void dgvKullanicilar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvKullanicilar.Columns["btnRolDegistirDGV"].Index && e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvKullanicilar.Rows[e.RowIndex];
                string yeniRol = row.Cells["cmbRol"].Value?.ToString();

                if (row.Cells["kullanici_id"].Value == null) return;
                int id = Convert.ToInt32(row.Cells["kullanici_id"].Value);

                if (string.IsNullOrEmpty(yeniRol))
                {
                    MessageBox.Show("Lütfen bir rol seçin.", "Uyarı");
                    return;
                }
                RolDegistir(id, yeniRol);
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dgvKullanicilar.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen silinecek bir kullanıcı seçin.", "Uyarı");
                return;
            }

            DataGridViewRow selectedRow = dgvKullanicilar.SelectedRows[0];
            if (selectedRow.Cells["kullanici_id"].Value == null) return;
            int id = Convert.ToInt32(selectedRow.Cells["kullanici_id"].Value);

            string silinecekRol = selectedRow.Cells["Mevcut Rol"].Value?.ToString() ?? "";
            if (silinecekRol == "Yönetici" || silinecekRol == "Öğrenci")
            {
                MessageBox.Show("Yönetici ve öğrenci rolleri bu panelden silinemez.", "Hata");
                return;
            }

            if (MessageBox.Show("Silmek istediğinize emin misiniz?", "Onay", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    string sql = "DELETE FROM Odunc_Islemleri WHERE ogrenci_id = @id OR personel_id = @id; " +
                                 "DELETE FROM Kullanicilar WHERE kullanici_id = @id";
                    GRUP6.DbHelper.ExecuteCommand(sql, new SqlParameter[] { new SqlParameter("@id", id) });
                    MessageBox.Show("Kullanıcı silindi.");
                    KullanicilariListele(cmbRolFiltre.SelectedItem.ToString());
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Silme hatası: " + ex.Message);
                }
            }
        }

        private void btnPersonelEkle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAd.Text) || string.IsNullOrWhiteSpace(txtSoyisim.Text) ||
                string.IsNullOrWhiteSpace(txtEposta.Text) || string.IsNullOrWhiteSpace(txtSifre.Text) ||
                string.IsNullOrWhiteSpace(txtNumara.Text))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.", "Uyarı");
                return;
            }

            if (!EpostaGecerliMi(txtEposta.Text.Trim()))
            {
                MessageBox.Show("Geçerli bir e-posta adresi giriniz.", "Uyarı");
                return;
            }

            if (!SifreUygunMu(txtSifre.Text))
            {
                MessageBox.Show("Şifre en az 8 karakter olmalı; büyük-küçük harf, rakam ve özel karakter içermelidir.", "Zayıf Şifre");
                return;
            }

            if (txtNumara.Text.Trim().Length != 10 || !txtNumara.Text.Trim().All(char.IsDigit))
            {
                MessageBox.Show("Telefon numarası 10 haneli ve sadece rakamlardan oluşmalıdır.", "Uyarı");
                return;
            }

            string sorgu = @"INSERT INTO Kullanicilar (ad, soyad, eposta, sifre_hashed, telefon, rol)
                             VALUES (@ad, @soyad, @eposta, @sifre, @tel, @rol)";

            SqlParameter[] parametreler =
            {
                new SqlParameter("@ad", txtAd.Text.Trim()),
                new SqlParameter("@soyad", txtSoyisim.Text.Trim()),
                new SqlParameter("@eposta", txtEposta.Text.Trim()),
                new SqlParameter("@tel", txtNumara.Text.Trim()),
                new SqlParameter("@sifre", SifreHashle(txtSifre.Text.Trim())),
                new SqlParameter("@rol", "Personel")
            };

            try
            {
                GRUP6.DbHelper.ExecuteCommand(sorgu, parametreler);
                MessageBox.Show("Personel başarıyla eklendi.", "Başarılı");
                AlanlariTemizle();
                KullanicilariListele(cmbRolFiltre.SelectedItem.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Personel eklenirken hata oluştu: " + ex.Message, "Hata");
            }
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}