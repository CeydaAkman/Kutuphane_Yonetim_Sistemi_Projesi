namespace GRUP6
{
    partial class frmIstatistikler
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblVerilenKitapSayisi = new System.Windows.Forms.Label();
            this.btnGeri = new System.Windows.Forms.Button();
            this.lblIstatistikler = new System.Windows.Forms.Label();
            this.dgvIadeEdilenler = new System.Windows.Forms.DataGridView();
            this.dgvGecikenler = new System.Windows.Forms.DataGridView();
            this.lblIadeEdilenler = new System.Windows.Forms.Label();
            this.lblGecikenler = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIadeEdilenler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGecikenler)).BeginInit();
            this.SuspendLayout();
            // 
            // lblVerilenKitapSayisi
            // 
            this.lblVerilenKitapSayisi.AutoSize = true;
            this.lblVerilenKitapSayisi.Location = new System.Drawing.Point(305, 97);
            this.lblVerilenKitapSayisi.Name = "lblVerilenKitapSayisi";
            this.lblVerilenKitapSayisi.Size = new System.Drawing.Size(188, 16);
            this.lblVerilenKitapSayisi.TabIndex = 1;
            this.lblVerilenKitapSayisi.Text = "Gün İçinde Verilen Kitap Sayısı";
            // 
            // btnGeri
            // 
            this.btnGeri.Location = new System.Drawing.Point(55, 32);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(75, 23);
            this.btnGeri.TabIndex = 2;
            this.btnGeri.Text = "Geri";
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // lblIstatistikler
            // 
            this.lblIstatistikler.AutoSize = true;
            this.lblIstatistikler.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblIstatistikler.Location = new System.Drawing.Point(378, 28);
            this.lblIstatistikler.Name = "lblIstatistikler";
            this.lblIstatistikler.Size = new System.Drawing.Size(102, 25);
            this.lblIstatistikler.TabIndex = 3;
            this.lblIstatistikler.Text = "İstatistikler";
            // 
            // dgvIadeEdilenler
            // 
            this.dgvIadeEdilenler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIadeEdilenler.Location = new System.Drawing.Point(308, 170);
            this.dgvIadeEdilenler.Name = "dgvIadeEdilenler";
            this.dgvIadeEdilenler.RowHeadersWidth = 51;
            this.dgvIadeEdilenler.RowTemplate.Height = 24;
            this.dgvIadeEdilenler.Size = new System.Drawing.Size(361, 190);
            this.dgvIadeEdilenler.TabIndex = 4;
            // 
            // dgvGecikenler
            // 
            this.dgvGecikenler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGecikenler.Location = new System.Drawing.Point(308, 404);
            this.dgvGecikenler.Name = "dgvGecikenler";
            this.dgvGecikenler.RowHeadersWidth = 51;
            this.dgvGecikenler.RowTemplate.Height = 24;
            this.dgvGecikenler.Size = new System.Drawing.Size(472, 190);
            this.dgvGecikenler.TabIndex = 5;
            // 
            // lblIadeEdilenler
            // 
            this.lblIadeEdilenler.AutoSize = true;
            this.lblIadeEdilenler.Location = new System.Drawing.Point(52, 170);
            this.lblIadeEdilenler.Name = "lblIadeEdilenler";
            this.lblIadeEdilenler.Size = new System.Drawing.Size(123, 16);
            this.lblIadeEdilenler.TabIndex = 6;
            this.lblIadeEdilenler.Text = "İade Edilen Kitaplar";
            // 
            // lblGecikenler
            // 
            this.lblGecikenler.AutoSize = true;
            this.lblGecikenler.Location = new System.Drawing.Point(52, 404);
            this.lblGecikenler.Name = "lblGecikenler";
            this.lblGecikenler.Size = new System.Drawing.Size(105, 16);
            this.lblGecikenler.TabIndex = 7;
            this.lblGecikenler.Text = "Geciken Kitaplar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Gün İçinde Verilen Kitap Sayısı";
            // 
            // frmIstatistikler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 649);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblGecikenler);
            this.Controls.Add(this.lblIadeEdilenler);
            this.Controls.Add(this.dgvGecikenler);
            this.Controls.Add(this.dgvIadeEdilenler);
            this.Controls.Add(this.lblIstatistikler);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.lblVerilenKitapSayisi);
            this.Name = "frmIstatistikler";
            this.Text = "İstatistikler";
            this.Load += new System.EventHandler(this.frmIstatistikler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIadeEdilenler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGecikenler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblVerilenKitapSayisi;
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.Label lblIstatistikler;
        private System.Windows.Forms.DataGridView dgvIadeEdilenler;
        private System.Windows.Forms.DataGridView dgvGecikenler;
        private System.Windows.Forms.Label lblIadeEdilenler;
        private System.Windows.Forms.Label lblGecikenler;
        private System.Windows.Forms.Label label1;
    }
}