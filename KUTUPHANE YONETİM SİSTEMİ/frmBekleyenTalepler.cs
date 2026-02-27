using System;
using System.Data;
using System.Windows.Forms;
using GRUP6;
using Microsoft.Data.SqlClient;

namespace GRUP6
{
    public partial class frmBekleyenTalepler : Form
    {
        private int _personelId;

        public frmBekleyenTalepler(int personelId)
        {
            InitializeComponent();
            _personelId = personelId;
            TalepleriListele();

            this.dgvBekleyenTalepler.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBekleyenTalepler_CellContentClick);
        }

        private void TalepleriListele()
        {
            string filtre = "O.durum = 'Beklemede'";
            string sorgu = "SELECT O.odunc_id, K.ad AS 'Kitap Adı', U.ad + ' ' + U.soyad AS 'Öğrenci', O.talep_tarihi AS 'Talep Tarihi', O.son_teslim_tarihi AS 'Son Teslim Tarihi', O.durum AS 'Durum', K.kitap_id " +
                           "FROM Odunc_Islemleri O " +
                           "INNER JOIN Kitaplar K ON O.kitap_id = K.kitap_id " +
                           "INNER JOIN Kullanicilar U ON O.ogrenci_id = U.kullanici_id " +
                           $"WHERE {filtre} ORDER BY O.talep_tarihi DESC";

            DataTable dt = GRUP6.DbHelper.GetData(sorgu);
            dgvBekleyenTalepler.DataSource = dt;

            if (dgvBekleyenTalepler.Columns.Contains("kitap_id")) dgvBekleyenTalepler.Columns["kitap_id"].Visible = false;
            if (dgvBekleyenTalepler.Columns.Contains("odunc_id")) dgvBekleyenTalepler.Columns["odunc_id"].Visible = false;

            if (!dgvBekleyenTalepler.Columns.Contains("OnaylaBtn"))
            {
                DataGridViewButtonColumn onaySutunu = new DataGridViewButtonColumn();
                onaySutunu.HeaderText = "Onayla";
                onaySutunu.Text = "Onayla";
                onaySutunu.Name = "OnaylaBtn";
                onaySutunu.UseColumnTextForButtonValue = true;
                dgvBekleyenTalepler.Columns.Add(onaySutunu);
            }
        }

        private void dgvBekleyenTalepler_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvBekleyenTalepler.Columns["OnaylaBtn"].Index && e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvBekleyenTalepler.Rows[e.RowIndex];

                if (row.Cells["Durum"].Value.ToString() == "Beklemede")
                {
                    DurumGuncelle("Onaylandı", row);
                }
            }
        }

        private void DurumGuncelle(string yeniDurum, DataGridViewRow secilenSatir)
        {
            int oduncId = Convert.ToInt32(secilenSatir.Cells["odunc_id"].Value);

            string sorgu = "UPDATE Odunc_Islemleri SET durum = @yeniDurum, onay_tarihi = GETDATE(), personel_id = @pId WHERE odunc_id = @id";

            SqlParameter[] parametreler = {
                new SqlParameter("@yeniDurum", yeniDurum),
                new SqlParameter("@pId", _personelId),
                new SqlParameter("@id", oduncId)
            };

            try
            {
                GRUP6.DbHelper.ExecuteCommand(sorgu, parametreler);
                MessageBox.Show("Talep onaylandı.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TalepleriListele();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message, "Hata");
            }
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}