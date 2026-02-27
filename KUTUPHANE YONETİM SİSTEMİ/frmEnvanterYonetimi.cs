using System;
using System.Data;
using System.Windows.Forms;
using GRUP6;
using Microsoft.Data.SqlClient;

namespace GRUP6
{
    public partial class frmEnvanterYonetimi : Form
    {
        private int _seciliKitapId = 0;

        public frmEnvanterYonetimi()
        {
            InitializeComponent();
            EnvanteriListele();
            this.dgvMevcutKitaplar.SelectionChanged += new System.EventHandler(this.dgvMevcutKitaplar_SelectionChanged);
        }

        private int KategoriIdGetir(string kategoriAdi)
        {
            if (string.IsNullOrWhiteSpace(kategoriAdi))
            {
                throw new Exception("Kategori adı boş olamaz.");
            }

            string selectSorgu = "SELECT kategori_id FROM Kategoriler WHERE kategori_adi = @ad";
            SqlParameter[] selectParam = { new SqlParameter("@ad", kategoriAdi.Trim()) };
            DataTable dt = GRUP6.DbHelper.GetData(selectSorgu, selectParam);

            if (dt.Rows.Count > 0)
            {
                return Convert.ToInt32(dt.Rows[0]["kategori_id"]);
            }
            else
            {
                string insertSorgu = "INSERT INTO Kategoriler (kategori_adi) VALUES (@ad); SELECT SCOPE_IDENTITY();";
                SqlParameter[] insertParam = { new SqlParameter("@ad", kategoriAdi.Trim()) };
                DataTable dtNew = GRUP6.DbHelper.GetData(insertSorgu, insertParam);

                if (dtNew.Rows.Count > 0 && dtNew.Rows[0][0] != DBNull.Value)
                {
                    return Convert.ToInt32(dtNew.Rows[0][0]);
                }
                else
                {
                    throw new Exception("Yeni kategori oluşturulamadı.");
                }
            }
        }

        private int YazarIdGetir(string yazarAdi)
        {
            if (string.IsNullOrWhiteSpace(yazarAdi))
            {
                throw new Exception("Yazar adı boş olamaz.");
            }

            string selectSorgu = "SELECT yazar_id FROM Yazarlar WHERE yazar_ad = @ad";
            SqlParameter[] selectParam = { new SqlParameter("@ad", yazarAdi.Trim()) };
            DataTable dt = GRUP6.DbHelper.GetData(selectSorgu, selectParam);

            if (dt.Rows.Count > 0)
            {
                return Convert.ToInt32(dt.Rows[0]["yazar_id"]);
            }
            else
            {
                string insertSorgu = "INSERT INTO Yazarlar (yazar_ad) VALUES (@ad); SELECT SCOPE_IDENTITY();";
                SqlParameter[] insertParam = { new SqlParameter("@ad", yazarAdi.Trim()) };
                DataTable dtNew = GRUP6.DbHelper.GetData(insertSorgu, insertParam);

                if (dtNew.Rows.Count > 0 && dtNew.Rows[0][0] != DBNull.Value)
                {
                    return Convert.ToInt32(dtNew.Rows[0][0]);
                }
                else
                {
                    throw new Exception("Yeni yazar oluşturulamadı.");
                }
            }
        }

        private void EnvanteriListele()
        {
            string sorgu = "SELECT K.kitap_id, K.ad AS 'Kitap Adı', K.stok AS 'Stok', K.isbn AS 'ISBN', K.yayin_yili AS 'Yayın Yılı', K.raf_bilgisi AS 'Raf Bilgisi', K.ozet AS 'Özet', " +
                           "Y.yazar_ad AS 'Yazar Adı', " +
                           "C.kategori_adi AS 'Kategori' " +
                           "FROM Kitaplar K " +
                           "LEFT JOIN Kitap_Yazar KY ON K.kitap_id = KY.kitap_id " +
                           "LEFT JOIN Yazarlar Y ON KY.yazar_id = Y.yazar_id " +
                           "LEFT JOIN Kitap_Kategori KC ON K.kitap_id = KC.kitap_id " +
                           "LEFT JOIN Kategoriler C ON KC.kategori_id = C.kategori_id " +
                           "ORDER BY K.kitap_id DESC";

            DataTable dt = GRUP6.DbHelper.GetData(sorgu);
            dgvMevcutKitaplar.DataSource = dt;

            if (dgvMevcutKitaplar.Columns.Contains("kitap_id")) dgvMevcutKitaplar.Columns["kitap_id"].Visible = false;

            AlanlariTemizle();
        }

        private void AlanlariTemizle()
        {
            txtAd.Clear();
            txtYazar.Clear();
            txtStok.Clear();
            txtOzet.Clear();
            txtISBN.Clear();
            txtKategori.Clear();
            txtYayinYili.Clear();
            txtRafBilgisi.Clear();

            _seciliKitapId = 0;
            btnGuncelle.Enabled = false;
            btnSil.Enabled = false;
            btnEkle.Enabled = true;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAd.Text) || string.IsNullOrWhiteSpace(txtStok.Text) ||
                string.IsNullOrWhiteSpace(txtISBN.Text) || string.IsNullOrWhiteSpace(txtYayinYili.Text) ||
                string.IsNullOrWhiteSpace(txtRafBilgisi.Text) || string.IsNullOrWhiteSpace(txtKategori.Text) ||
                string.IsNullOrWhiteSpace(txtYazar.Text))
            {
                MessageBox.Show("Tüm alanlar zorunludur.", "Uyarı");
                return;
            }

            try
            {
                int stokMiktari = Convert.ToInt32(txtStok.Text);
                int yayinYili = Convert.ToInt32(txtYayinYili.Text);
                int kategoriId = KategoriIdGetir(txtKategori.Text);
                int yazarId = YazarIdGetir(txtYazar.Text);

                string kitapInsertSorgu = "INSERT INTO Kitaplar (ad, stok, ozet, isbn, yayin_yili, raf_bilgisi) " +
                                          "VALUES (@ad, @stok, @ozet, @isbn, @yayin_yili, @raf_bilgisi); SELECT SCOPE_IDENTITY();";

                SqlParameter[] kitapParametreler = {
                    new SqlParameter("@ad", txtAd.Text.Trim()),
                    new SqlParameter("@stok", stokMiktari),
                    new SqlParameter("@ozet", txtOzet.Text.Trim()),
                    new SqlParameter("@isbn", txtISBN.Text.Trim()),
                    new SqlParameter("@yayin_yili", yayinYili),
                    new SqlParameter("@raf_bilgisi", txtRafBilgisi.Text.Trim())
                };

                DataTable dtKitapId = GRUP6.DbHelper.GetData(kitapInsertSorgu, kitapParametreler);
                int yeniKitapId = Convert.ToInt32(dtKitapId.Rows[0][0]);

                string kategoriIliskiSorgu = "INSERT INTO Kitap_Kategori (kitap_id, kategori_id) VALUES (@kitapId, @kategoriId)";
                SqlParameter[] kategoriIliskiParametreler = {
                    new SqlParameter("@kitapId", yeniKitapId),
                    new SqlParameter("@kategoriId", kategoriId)
                };
                GRUP6.DbHelper.ExecuteCommand(kategoriIliskiSorgu, kategoriIliskiParametreler);

                string yazarIliskiSorgu = "INSERT INTO Kitap_Yazar (kitap_id, yazar_id) VALUES (@kitapId, @yazarId)";
                SqlParameter[] yazarIliskiParametreler = {
                    new SqlParameter("@kitapId", yeniKitapId),
                    new SqlParameter("@yazarId", yazarId)
                };
                GRUP6.DbHelper.ExecuteCommand(yazarIliskiSorgu, yazarIliskiParametreler);

                MessageBox.Show("Yeni kitap başarıyla eklendi.", "Başarılı");
                EnvanteriListele();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ekleme hatası: " + ex.Message);
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (_seciliKitapId == 0 || string.IsNullOrWhiteSpace(txtAd.Text))
            {
                MessageBox.Show("Lütfen güncellenecek bir kitap seçin.", "Uyarı");
                return;
            }

            try
            {
                int stokMiktari = Convert.ToInt32(txtStok.Text);
                int yayinYili = Convert.ToInt32(txtYayinYili.Text);
                int kategoriId = KategoriIdGetir(txtKategori.Text);
                int yazarId = YazarIdGetir(txtYazar.Text);

                string kitapUpdateSorgu = "UPDATE Kitaplar SET ad = @ad, stok = @stok, ozet = @ozet, isbn = @isbn, yayin_yili = @yayin_yili, raf_bilgisi = @raf_bilgisi WHERE kitap_id = @id";

                SqlParameter[] kitapParametreler = {
                    new SqlParameter("@id", _seciliKitapId),
                    new SqlParameter("@ad", txtAd.Text.Trim()),
                    new SqlParameter("@stok", stokMiktari),
                    new SqlParameter("@ozet", txtOzet.Text.Trim()),
                    new SqlParameter("@isbn", txtISBN.Text.Trim()),
                    new SqlParameter("@yayin_yili", yayinYili),
                    new SqlParameter("@raf_bilgisi", txtRafBilgisi.Text.Trim())
                };

                GRUP6.DbHelper.ExecuteCommand(kitapUpdateSorgu, kitapParametreler);

                string kategoriIliskiSorgu = "DELETE FROM Kitap_Kategori WHERE kitap_id = @kitapId; " +
                                             "INSERT INTO Kitap_Kategori (kitap_id, kategori_id) VALUES (@kitapId, @kategoriId)";
                SqlParameter[] kategoriIliskiParametreler = {
                    new SqlParameter("@kitapId", _seciliKitapId),
                    new SqlParameter("@kategoriId", kategoriId)
                };
                GRUP6.DbHelper.ExecuteCommand(kategoriIliskiSorgu, kategoriIliskiParametreler);

                string yazarIliskiSorgu = "DELETE FROM Kitap_Yazar WHERE kitap_id = @kitapId; " +
                                           "INSERT INTO Kitap_Yazar (kitap_id, yazar_id) VALUES (@kitapId, @yazarId)";
                SqlParameter[] yazarIliskiParametreler = {
                    new SqlParameter("@kitapId", _seciliKitapId),
                    new SqlParameter("@yazarId", yazarId)
                };
                GRUP6.DbHelper.ExecuteCommand(yazarIliskiSorgu, yazarIliskiParametreler);

                MessageBox.Show("Kitap bilgileri güncellendi.", "Başarılı");
                EnvanteriListele();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Güncelleme hatası: " + ex.Message);
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (_seciliKitapId == 0)
            {
                MessageBox.Show("Lütfen silinecek bir kitap seçin.", "Uyarı");
                return;
            }

            DialogResult dialogResult = MessageBox.Show("Bu kitabı silmek istediğinizden emin misiniz?", "Onay", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    string tumIliskiSilSorgu = "DELETE FROM Kitap_Kategori WHERE kitap_id = @id; " +
                                                "DELETE FROM Kitap_Yazar WHERE kitap_id = @id; " +
                                                "DELETE FROM Odunc_Islemleri WHERE kitap_id = @id;";
                    string kitapSilSorgu = "DELETE FROM Kitaplar WHERE kitap_id = @id";

                    SqlParameter[] parametreler = { new SqlParameter("@id", _seciliKitapId) };

                    GRUP6.DbHelper.ExecuteCommand(tumIliskiSilSorgu + kitapSilSorgu, parametreler);

                    MessageBox.Show("Kitap başarıyla silindi.", "Başarılı");
                    EnvanteriListele();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Silme hatası: " + ex.Message);
                }
            }
        }

        private void dgvMevcutKitaplar_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;

            if (dgv.SelectedRows.Count == 1 && dgv.CurrentRow != null)
            {
                try
                {
                    DataGridViewRow row = dgv.SelectedRows[0];

                    _seciliKitapId = Convert.ToInt32(row.Cells["kitap_id"].Value ?? 0);
                    txtAd.Text = row.Cells["Kitap Adı"].Value?.ToString() ?? "";
                    txtYazar.Text = row.Cells["Yazar Adı"].Value?.ToString() ?? "";
                    txtKategori.Text = row.Cells["Kategori"].Value?.ToString() ?? "";
                    txtStok.Text = row.Cells["Stok"].Value?.ToString() ?? "0";
                    txtISBN.Text = row.Cells["ISBN"].Value?.ToString() ?? "";
                    txtYayinYili.Text = row.Cells["Yayın Yılı"].Value?.ToString() ?? "";
                    txtRafBilgisi.Text = row.Cells["Raf Bilgisi"].Value?.ToString() ?? "";
                    txtOzet.Text = row.Cells["Özet"].Value?.ToString() ?? "";

                    btnGuncelle.Enabled = true;
                    btnSil.Enabled = true;
                    btnEkle.Enabled = false;
                }
                catch { }
            }
            else
            {
                AlanlariTemizle();
            }
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}