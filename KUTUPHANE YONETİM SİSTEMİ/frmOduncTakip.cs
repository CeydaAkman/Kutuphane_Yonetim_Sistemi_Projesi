using System;
using System.Data;
using System.Windows.Forms;
using GRUP6;
using Microsoft.Data.SqlClient;

namespace GRUP6
{
    public partial class frmOduncTakip : Form
    {
        private int _ogrenciId;

        public frmOduncTakip(int ogrenciId)
        {
            InitializeComponent();
            this._ogrenciId = ogrenciId;
            TakipListesiniYukle();
        }

        private void TakipListesiniYukle()
        {
            string sorgu = "SELECT O.odunc_id, K.ad AS 'Kitap Adı', O.talep_tarihi AS 'Talep Tarihi', O.son_teslim_tarihi AS 'Son Teslim Tarihi', O.durum " +
                           "FROM Odunc_Islemleri O " +
                           "INNER JOIN Kitaplar K ON O.kitap_id = K.kitap_id " +
                           "WHERE O.ogrenci_id = @ogrenciId ORDER BY O.talep_tarihi DESC";

            SqlParameter[] parametreler = { new SqlParameter("@ogrenciId", _ogrenciId) };

            DataTable dt = GRUP6.DbHelper.GetData(sorgu, parametreler);
            dgvTakipListesi.DataSource = dt;

            if (dgvTakipListesi.Columns.Contains("odunc_id"))
            {
                dgvTakipListesi.Columns["odunc_id"].Visible = false;
            }
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}