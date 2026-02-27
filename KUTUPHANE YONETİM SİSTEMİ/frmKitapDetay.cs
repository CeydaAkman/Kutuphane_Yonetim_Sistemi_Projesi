using System;
using System.Data;
using System.Windows.Forms;
using GRUP6;

namespace GRUP6
{
    public partial class frmKitapDetay : Form
    {
        private int _kitapId;

        public frmKitapDetay(int kitapId)
        {
            InitializeComponent();
            _kitapId = kitapId;
            KitapDetaylariniYukle();
        }

        private void KitapDetaylariniYukle()
        {
            string sorgu = "SELECT K.ad, K.ozet, K.raf_bilgisi, K.stok, Y.yazar_ad " +
                           "FROM Kitaplar K " +
                           "INNER JOIN Kitap_Yazar KY ON K.kitap_id = KY.kitap_id " +
                           "INNER JOIN Yazarlar Y ON KY.yazar_id = Y.yazar_id " +
                           "WHERE K.kitap_id = @id";

            Microsoft.Data.SqlClient.SqlParameter[] parametreler = {
                new Microsoft.Data.SqlClient.SqlParameter("@id", _kitapId)
            };

            DataTable dt = GRUP6.DbHelper.GetData(sorgu, parametreler);

            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                lblKitapAdi.Text = row["ad"].ToString();
                lblYazar.Text = "Yazar: " + row["yazar_ad"].ToString();
                txtOzet.Text = row["ozet"].ToString();
                lblRafBilgisi.Text = "Raf: " + row["raf_bilgisi"].ToString();

                int stok = Convert.ToInt32(row["stok"]);
                lblStokDurumu.Text = "Stok: " + stok.ToString();

                if (stok == 0)
                {
                    MessageBox.Show("Bu kitap şu anda ödünç verilemez. Stokta bulunmamaktadır.", "Stok Hatası");
                    lblStokDurumu.Text += " (Ödünç Verilemez!)";
                    lblStokDurumu.ForeColor = System.Drawing.Color.Red;
                }
            }
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}