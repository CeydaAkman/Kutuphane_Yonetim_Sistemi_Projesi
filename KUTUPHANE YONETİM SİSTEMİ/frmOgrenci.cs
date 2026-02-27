using System;
using System.Data;
using System.Windows.Forms;
using GRUP6;

namespace GRUP6
{
    public partial class frmOgrenci : Form
    {
        private int _mevcutKullaniciId;

        public frmOgrenci(int id)
        {
            InitializeComponent();
            _mevcutKullaniciId = id;

            KategoriYukle();
            KitaplariYukle();

            this.cmbFiltreleme.SelectedIndexChanged += new System.EventHandler(this.cmbFiltreleme_SelectedIndexChanged);
           
            this.txtArama.TextChanged += new System.EventHandler(this.AramaFiltrele);
        }

        private void KategoriYukle()
        {
            string sorgu = "SELECT kategori_id, kategori_adi FROM Kategoriler ORDER BY kategori_adi";
            DataTable dt = GRUP6.DbHelper.GetData(sorgu);

            DataRow tumuRow = dt.NewRow();
            tumuRow["kategori_id"] = DBNull.Value;
            tumuRow["kategori_adi"] = "Tümü";
            dt.Rows.InsertAt(tumuRow, 0);

            cmbFiltreleme.DataSource = dt;
            cmbFiltreleme.DisplayMember = "kategori_adi";
            cmbFiltreleme.ValueMember = "kategori_id";
        }

        private void KitaplariYukle(string filtre = "")
        {
            string sorgu = "SELECT K.kitap_id, K.ad AS 'Kitap Adı', Y.yazar_ad AS 'Yazar', Ka.kategori_adi AS 'Kategori', K.stok, K.yayin_yili " +
                           "FROM Kitaplar K " +
                           "LEFT JOIN Kitap_Yazar KY ON K.kitap_id = KY.kitap_id " +
                           "LEFT JOIN Yazarlar Y ON KY.yazar_id = Y.yazar_id " +
                           "LEFT JOIN Kitap_Kategori KK ON K.kitap_id = KK.kitap_id " +
                           "LEFT JOIN Kategoriler Ka ON KK.kategori_id = Ka.kategori_id " +
                           "WHERE K.stok > 0 " + filtre;

            DataTable dt = GRUP6.DbHelper.GetData(sorgu);
            dgvKitaplar.DataSource = dt;
            
            if (!dgvKitaplar.Columns.Contains("DetayBtn"))
            {
                DataGridViewButtonColumn detaySutunu = new DataGridViewButtonColumn();
                detaySutunu.HeaderText = "İncele";
                detaySutunu.Text = "Detay Gör";
                detaySutunu.Name = "DetayBtn";
                detaySutunu.UseColumnTextForButtonValue = true;

                dgvKitaplar.Columns.Add(detaySutunu);
            }

            if (dgvKitaplar.Columns.Contains("kitap_id")) dgvKitaplar.Columns["kitap_id"].Visible = false;
        }
        private void AramaFiltrele(object sender, EventArgs e)
        {
            string kategoriFiltre = "";
            string aramaFiltre = "";

            if (cmbFiltreleme.SelectedValue != DBNull.Value && cmbFiltreleme.SelectedValue != null)
            {
                kategoriFiltre = $" AND K.kitap_id IN (SELECT kitap_id FROM Kitap_Kategori WHERE kategori_id = {cmbFiltreleme.SelectedValue}) ";
            }
            if (this.Controls.Find("txtArama", true).Length > 0 && !string.IsNullOrEmpty(txtArama.Text))
            {
                string arama = txtArama.Text.Trim();
                aramaFiltre = $" AND (K.ad LIKE '%{arama}%' OR Y.yazar_ad LIKE '%{arama}%') ";
            }

            KitaplariYukle(kategoriFiltre + aramaFiltre);
        }

        private void cmbFiltreleme_SelectedIndexChanged(object sender, EventArgs e)
        {
            AramaFiltrele(sender, e);
        }

        private void dgvKitaplar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvKitaplar.Columns["DetayBtn"].Index && e.RowIndex >= 0)
            {
                int kitapId = Convert.ToInt32(dgvKitaplar.Rows[e.RowIndex].Cells["kitap_id"].Value);

                new frmKitapDetay(kitapId).Show();
            }
        }

        private void btnOduncTalep_Click(object sender, EventArgs e)
        {
            if (dgvKitaplar.SelectedRows.Count == 1)
            {
                int kitapId = Convert.ToInt32(dgvKitaplar.SelectedRows[0].Cells["kitap_id"].Value);

                new frmOduncTalep(kitapId, _mevcutKullaniciId).ShowDialog();

                KitaplariYukle();
            }
            else
            {
                MessageBox.Show("Lütfen bir kitap seçiniz.");
            }
        }

        private void btnOduncTakip_Click(object sender, EventArgs e)
        {
            new frmOduncTakip(_mevcutKullaniciId).Show();
        }
        private void btnCikisYap_Click(object sender, EventArgs e)
        {
            frmGirisEkrani girişEkrani = new frmGirisEkrani();
            girişEkrani.Show();
            this.Close();
        }
    }
}