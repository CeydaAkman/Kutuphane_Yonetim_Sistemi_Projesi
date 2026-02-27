using System;
using System.Data;
using System.Windows.Forms;
using GRUP6;

namespace GRUP6
{
    public partial class frmGecikenKitaplar : Form
    {
        public frmGecikenKitaplar()
        {
            InitializeComponent();
            GecikenleriListele();
        }

        private void GecikenleriListele()
        {
            string filtre = "O.durum = 'Teslim Edildi' AND O.son_teslim_tarihi < GETDATE()";

            string sorgu = "SELECT O.odunc_id, K.ad AS 'Kitap Adı', U.ad + ' ' + U.soyad AS 'Öğrenci', O.son_teslim_tarihi AS 'Son Teslim Tarihi', O.durum AS 'Durum' " +
                           "FROM Odunc_Islemleri O " +
                           "INNER JOIN Kitaplar K ON O.kitap_id = K.kitap_id " +
                           "INNER JOIN Kullanicilar U ON O.ogrenci_id = U.kullanici_id " +
                           $"WHERE {filtre} ORDER BY O.son_teslim_tarihi ASC";

            DataTable dt = GRUP6.DbHelper.GetData(sorgu);
            dgvGecikenKitaplar.DataSource = dt;

            if (dgvGecikenKitaplar.Columns.Contains("odunc_id"))
            {
                dgvGecikenKitaplar.Columns["odunc_id"].Visible = false;
            }

            foreach (DataGridViewRow row in dgvGecikenKitaplar.Rows)
            {
                row.DefaultCellStyle.BackColor = System.Drawing.Color.LightCoral;
            }
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}