using System;
using System.Data;
using System.Windows.Forms;
using GRUP6;

namespace GRUP6
{
    public partial class frmIstatistikler : Form
    {
        public frmIstatistikler()
        {
            InitializeComponent();
            IstatistikleriYukle();
        }

        private void IstatistikleriYukle()
        {
            string bugun = DateTime.Now.ToString("yyyy-MM-dd");

            string sorguVerilenSayisi = $"SELECT COUNT(*) FROM Odunc_Islemleri WHERE durum = 'Teslim Edildi' AND CONVERT(date, teslim_tarihi) = '{bugun}'";
            int verilenSayisi = Convert.ToInt32(GRUP6.DbHelper.GetData(sorguVerilenSayisi).Rows[0][0]);

            string sorguIadeListesi = "SELECT K.ad AS 'İade Edilen Kitap Adı', U.ad + ' ' + U.soyad AS 'Öğrenci' " +
                                      "FROM Odunc_Islemleri O " +
                                      "INNER JOIN Kitaplar K ON O.kitap_id = K.kitap_id " +
                                      "INNER JOIN Kullanicilar U ON O.ogrenci_id = U.kullanici_id " +
                                      $"WHERE O.durum = 'İade Edildi'";

            DataTable dtIade = GRUP6.DbHelper.GetData(sorguIadeListesi);

            string sorguGecikenListesi = "SELECT K.ad AS 'Geciken Kitap Adı', U.ad + ' ' + U.soyad AS 'Öğrenci', O.son_teslim_tarihi AS 'Planlanan Teslim' " +
                                         "FROM Odunc_Islemleri O " +
                                         "INNER JOIN Kitaplar K ON O.kitap_id = K.kitap_id " +
                                         "INNER JOIN Kullanicilar U ON O.ogrenci_id = U.kullanici_id " +
                                         "WHERE O.durum = 'Teslim Edildi' AND O.son_teslim_tarihi < GETDATE() " +
                                         "ORDER BY O.son_teslim_tarihi ASC";

            DataTable dtGecikenler = GRUP6.DbHelper.GetData(sorguGecikenListesi);

            lblVerilenKitapSayisi.Text = verilenSayisi.ToString();

            lblIadeEdilenler.Text = $"İade Alınan Kitaplar ({dtIade.Rows.Count} Adet):";
            dgvIadeEdilenler.DataSource = dtIade;

            lblGecikenler.Text = $"Geciken Kitaplar ({dtGecikenler.Rows.Count} Adet):";
            dgvGecikenler.DataSource = dtGecikenler;

            foreach (DataGridViewRow row in dgvGecikenler.Rows)
            {
                row.DefaultCellStyle.BackColor = System.Drawing.Color.LightCoral;
            }
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmIstatistikler_Load(object sender, EventArgs e)
        {

        }
    }
}