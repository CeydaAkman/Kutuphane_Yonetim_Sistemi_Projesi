using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace GRUP6
{
    public partial class frmKitapTeslimVeİadeEtme : Form
    {
        public frmKitapTeslimVeİadeEtme()
        {
            InitializeComponent();
            this.dgvKitapTeslimEtme.CellContentClick += new DataGridViewCellEventHandler(dgvKitapTeslimEtme_CellContentClick);
            this.dgvKitapTeslimEtme.DataBindingComplete += new DataGridViewBindingCompleteEventHandler(dgvKitapTeslimEtme_DataBindingComplete);

            TalepleriListele();
        }

        private void TalepleriListele()
        {
            string sorgu = @"SELECT O.odunc_id, K.ad AS 'Kitap Adı', U.ad + ' ' + U.soyad AS 'Öğrenci', 
                            O.son_teslim_tarihi AS 'Son Teslim Tarihi', O.durum AS 'Durum', K.kitap_id 
                            FROM Odunc_Islemleri O 
                            INNER JOIN Kitaplar K ON O.kitap_id = K.kitap_id 
                            INNER JOIN Kullanicilar U ON O.ogrenci_id = U.kullanici_id 
                            WHERE O.durum IN ('Onaylandı', 'Teslim Edildi') 
                            ORDER BY O.durum DESC, O.son_teslim_tarihi ASC";

            DataTable dt = GRUP6.DbHelper.GetData(sorgu);

            dgvKitapTeslimEtme.DataSource = null;
            ButonSutunuOlustur();
            dgvKitapTeslimEtme.DataSource = dt;

            if (dgvKitapTeslimEtme.Columns.Contains("kitap_id")) dgvKitapTeslimEtme.Columns["kitap_id"].Visible = false;
            if (dgvKitapTeslimEtme.Columns.Contains("odunc_id")) dgvKitapTeslimEtme.Columns["odunc_id"].Visible = false;

            if (dgvKitapTeslimEtme.Columns.Contains("IslemBtn"))
            {
                dgvKitapTeslimEtme.Columns["IslemBtn"].DisplayIndex = dgvKitapTeslimEtme.Columns.Count - 1;
            }
        }

        private void ButonSutunuOlustur()
        {
            if (!dgvKitapTeslimEtme.Columns.Contains("IslemBtn"))
            {
                DataGridViewButtonColumn islemSutunu = new DataGridViewButtonColumn();
                islemSutunu.HeaderText = "İşlem";
                islemSutunu.Name = "IslemBtn";
                islemSutunu.FlatStyle = FlatStyle.Standard;
                dgvKitapTeslimEtme.Columns.Add(islemSutunu);
            }
        }

        private void dgvKitapTeslimEtme_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            for (int i = 0; i < dgvKitapTeslimEtme.Rows.Count; i++)
            {
                if (dgvKitapTeslimEtme.Rows[i].Cells["durum"].Value != null)
                {
                    string durum = dgvKitapTeslimEtme.Rows[i].Cells["durum"].Value.ToString();
                    if (durum == "Onaylandı")
                        dgvKitapTeslimEtme.Rows[i].Cells["IslemBtn"].Value = "Teslim Et";
                    else if (durum == "Teslim Edildi")
                        dgvKitapTeslimEtme.Rows[i].Cells["IslemBtn"].Value = "İade Al";
                }
            }
        }

        private void dgvKitapTeslimEtme_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvKitapTeslimEtme.Columns["IslemBtn"].Index && e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvKitapTeslimEtme.Rows[e.RowIndex];
                string mevcutDurum = row.Cells["durum"].Value.ToString();

                if (mevcutDurum == "Onaylandı")
                {
                    TeslimEt(row);
                }
                else if (mevcutDurum == "Teslim Edildi")
                {
                    IadeAl(row);
                }
            }
        }

        private void TeslimEt(DataGridViewRow secilenSatir)
        {
            int oduncId = Convert.ToInt32(secilenSatir.Cells["odunc_id"].Value);
            int kitapId = Convert.ToInt32(secilenSatir.Cells["kitap_id"].Value);

            string sorgu = "UPDATE Odunc_Islemleri SET durum = 'Teslim Edildi', teslim_tarihi = GETDATE() WHERE odunc_id = @id";
            SqlParameter[] parametreler = { new SqlParameter("@id", oduncId) };

            try
            {
                GRUP6.DbHelper.ExecuteCommand(sorgu, parametreler);
                StokGuncelle(kitapId, -1);
                MessageBox.Show("Kitap öğrenciye teslim edildi.", "Başarılı");
                TalepleriListele();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Teslim hatası: " + ex.Message);
            }
        }

        private void IadeAl(DataGridViewRow secilenSatir)
        {
            int oduncId = Convert.ToInt32(secilenSatir.Cells["odunc_id"].Value);
            int kitapId = Convert.ToInt32(secilenSatir.Cells["kitap_id"].Value);

            string sorgu = "UPDATE Odunc_Islemleri SET durum = 'İade edildi', iade_tarihi = GETDATE() WHERE odunc_id = @id";
            SqlParameter[] parametreler = { new SqlParameter("@id", oduncId) };

            try
            {
                GRUP6.DbHelper.ExecuteCommand(sorgu, parametreler);
                StokGuncelle(kitapId, 1);
                MessageBox.Show("Kitap iadesi başarıyla alındı.", "Başarılı");
                TalepleriListele();
            }
            catch (Exception ex)
            {
                MessageBox.Show("İade hatası: " + ex.Message);
            }
        }

        private void StokGuncelle(int kitapId, int miktar)
        {
            string sorgu = "UPDATE Kitaplar SET stok = stok + @miktar WHERE kitap_id = @id";
            SqlParameter[] parametreler = {
                new SqlParameter("@miktar", miktar),
                new SqlParameter("@id", kitapId)
            };
            GRUP6.DbHelper.ExecuteCommand(sorgu, parametreler);
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}