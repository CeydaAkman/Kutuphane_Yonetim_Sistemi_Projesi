using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace GRUP6
{
    public partial class frmRaporlarVeAnalizler : Form
    {
        public frmRaporlarVeAnalizler()
        {
            InitializeComponent();

            DonemFiltreleriniYukle();

            this.cmbDonemFiltre.SelectedIndexChanged += cmbDonemFiltre_SelectedIndexChanged;
            this.Load += frmRaporlarVeAnalizler_Load;
        }

        private void DonemFiltreleriniYukle()
        {
            cmbDonemFiltre.Items.Clear();
            cmbDonemFiltre.Items.AddRange(new string[] { "Tümü", "Aylık", "Haftalık", "Günlük" });
            if (cmbDonemFiltre.Items.Count > 0)
                cmbDonemFiltre.SelectedIndex = 0;
        }

        private void RaporlariYukle(string donem)
        {
            if (string.IsNullOrWhiteSpace(donem))
                donem = "Tümü";

            string where = "WHERE O.durum IN ('Teslim Edildi', 'Ödünç Verildi')";

            if (donem == "Tümü")
            {
                where = "";
            }
            else if (donem == "Aylık")
            {
                where += $" AND O.talep_tarihi >= DATEADD(month, -1, CAST(GETDATE() AS DATE))";
            }
            else if (donem == "Haftalık")
            {
                where += $" AND O.talep_tarihi >= DATEADD(day, -7, CAST(GETDATE() AS DATE))";
            }
            else if (donem == "Günlük")
            {
                where += $" AND CAST(O.talep_tarihi AS DATE) = CAST(GETDATE() AS DATE)";
            }

            try
            {
                string sorguToplam = $"SELECT COUNT(*) AS Toplam FROM Odunc_Islemleri O {where}";
                DataTable dtToplam = DbHelper.GetData(sorguToplam);
                lblToplamOduncSayisi.Text = (dtToplam.Rows.Count > 0) ? dtToplam.Rows[0]["Toplam"].ToString() : "0";

                string sorguEnCok = $@"
                    SELECT TOP 10 K.ad AS [Kitap Adı], COUNT(*) AS [Ödünç Sayısı]
                    FROM Odunc_Islemleri O
                    INNER JOIN Kitaplar K ON O.kitap_id = K.kitap_id
                    {where}
                    GROUP BY K.ad
                    ORDER BY [Ödünç Sayısı] DESC";

                dgvEnCokOdunc.DataSource = DbHelper.GetData(sorguEnCok);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Rapor yüklenirken hata oluştu:\n" + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmRaporlarVeAnalizler_Load(object sender, EventArgs e)
        {
            string secim = cmbDonemFiltre.SelectedItem?.ToString() ?? "Tümü";
            RaporlariYukle(secim);
        }

        private void cmbDonemFiltre_SelectedIndexChanged(object sender, EventArgs e)
        {
            string secim = cmbDonemFiltre.SelectedItem?.ToString() ?? "Tümü";
            RaporlariYukle(secim);
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}