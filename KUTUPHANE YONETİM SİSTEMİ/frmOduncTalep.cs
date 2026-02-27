using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace GRUP6
{
    public partial class frmOduncTalep : Form
    {
        private int _kitapId;
        private int _ogrenciId;

        public frmOduncTalep(int kitapId, int ogrenciId)
        {
            InitializeComponent();

            _kitapId = kitapId;
            _ogrenciId = ogrenciId;

            dtpTeslimTarihi.Value = DateTime.Today;

            dtpTeslimTarihi.ValueChanged += dtpTeslimTarihi_ValueChanged;
            dtpTeslimTarihi.CloseUp += dtpTeslimTarihi_CloseUp;

            KitapBilgisiniYukle();
        }


        private void KitapBilgisiniYukle()
        {
            string sorgu = "SELECT ad, stok FROM Kitaplar WHERE kitap_id = @kitapId";
            SqlParameter[] parametreler =
            {
                new SqlParameter("@kitapId", _kitapId)
            };

            DataTable dt = DbHelper.GetData(sorgu, parametreler);

            if (dt.Rows.Count > 0)
            {
                lblSeciliKitapAdi.Text = "Seçili Kitap: " + dt.Rows[0]["ad"].ToString();

                int stok = Convert.ToInt32(dt.Rows[0]["stok"]);
                if (stok <= 0)
                {
                    MessageBox.Show(
                        "Bu kitap şu anda stokta yok.",
                        "Bilgi",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    btnTalepGonder.Enabled = false;
                }
            }
            else
            {
                lblSeciliKitapAdi.Text = "Kitap bulunamadı";
                btnTalepGonder.Enabled = false;
            }
        }

        private void btnTalepGonder_Click(object sender, EventArgs e)
        {
            try
            {
                string kontrolSorgu = @"
                    SELECT COUNT(*) 
                    FROM Odunc_Islemleri
                    WHERE ogrenci_id = @ogrenciId 
                      AND kitap_id = @kitapId
                      AND durum IN ('Beklemede', 'Onaylandı', 'Teslim Edildi')";

                SqlParameter[] kontrolParametreleri =
                {
                    new SqlParameter("@ogrenciId", _ogrenciId),
                    new SqlParameter("@kitapId", _kitapId)
                };

                DataTable dtKontrol = DbHelper.GetData(kontrolSorgu, kontrolParametreleri);
                int kayitSayisi = Convert.ToInt32(dtKontrol.Rows[0][0]);

                if (kayitSayisi > 0)
                {
                    MessageBox.Show(
                        "Bu kitap için zaten aktif bir talebiniz veya ödünç kaydınız var.",
                        "Uyarı",
                        MessageBoxButtons.OK);
                    return;
                }

                string stokSorgu = "SELECT stok FROM Kitaplar WHERE kitap_id = @kitapId";
                DataTable dtStok = DbHelper.GetData(
                    stokSorgu,
                    new SqlParameter[] { new SqlParameter("@kitapId", _kitapId) });

                if (dtStok.Rows.Count == 0 || Convert.ToInt32(dtStok.Rows[0]["stok"]) <= 0)
                {
                    MessageBox.Show(
                        "Bu kitap stokta yok. Talep oluşturulamaz.",
                        "Bilgi",
                        MessageBoxButtons.OK);
                    return;
                }

                string insertSorgu = @"
                    INSERT INTO Odunc_Islemleri
                    (kitap_id, ogrenci_id, talep_tarihi, son_teslim_tarihi, durum)
                    VALUES
                    (@kitapId, @ogrenciId, GETDATE(), @sonTeslimTarihi, 'Beklemede')";

                SqlParameter[] insertParametreleri =
                {
                    new SqlParameter("@kitapId", _kitapId),
                    new SqlParameter("@ogrenciId", _ogrenciId),
                    new SqlParameter("@sonTeslimTarihi", dtpTeslimTarihi.Value.Date)
                };

                DbHelper.ExecuteCommand(insertSorgu, insertParametreleri);

                MessageBox.Show(
                    "Ödünç talebiniz başarıyla gönderildi.",
                    "Başarılı",
                    MessageBoxButtons.OK);

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Talep gönderilirken hata oluştu:\n" + ex.Message,
                    "Hata",
                    MessageBoxButtons.OK);
            }
        }
        private void dtpTeslimTarihi_ValueChanged(object sender, EventArgs e)
        {
            if (dtpTeslimTarihi.Value.Date < DateTime.Today)
            {
                MessageBox.Show(
                    "Geçmiş bir tarih seçemezsiniz.",
                    "Uyarı",
                    MessageBoxButtons.OK);

                dtpTeslimTarihi.Value = DateTime.Today.AddDays(14);
            }
        }
        private void dtpTeslimTarihi_CloseUp(object sender, EventArgs e)
        {
            if (dtpTeslimTarihi.Value.Date < DateTime.Today)
            {
                dtpTeslimTarihi.Value = DateTime.Today.AddDays(14);
            }
        }


        private void btnGeri_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmOduncTalep_Load(object sender, EventArgs e)
        {

        }
    }
}
