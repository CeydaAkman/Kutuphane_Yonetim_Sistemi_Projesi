namespace GRUP6
{
    partial class frmOduncTalep
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblSeciliKitapAdi = new System.Windows.Forms.Label();
            this.btnGeri = new System.Windows.Forms.Button();
            this.btnTalepGonder = new System.Windows.Forms.Button();
            this.dtpTeslimTarihi = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(195, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ödünç Talep Ekranı";
            // 
            // lblSeciliKitapAdi
            // 
            this.lblSeciliKitapAdi.AutoSize = true;
            this.lblSeciliKitapAdi.Location = new System.Drawing.Point(182, 123);
            this.lblSeciliKitapAdi.Name = "lblSeciliKitapAdi";
            this.lblSeciliKitapAdi.Size = new System.Drawing.Size(96, 16);
            this.lblSeciliKitapAdi.TabIndex = 1;
            this.lblSeciliKitapAdi.Text = "Seçili Kitap Adi";
            // 
            // btnGeri
            // 
            this.btnGeri.Location = new System.Drawing.Point(40, 37);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(75, 23);
            this.btnGeri.TabIndex = 3;
            this.btnGeri.Text = "Geri";
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // btnTalepGonder
            // 
            this.btnTalepGonder.Location = new System.Drawing.Point(185, 221);
            this.btnTalepGonder.Name = "btnTalepGonder";
            this.btnTalepGonder.Size = new System.Drawing.Size(137, 40);
            this.btnTalepGonder.TabIndex = 4;
            this.btnTalepGonder.Text = "Talep Gönder";
            this.btnTalepGonder.UseVisualStyleBackColor = true;
            this.btnTalepGonder.Click += new System.EventHandler(this.btnTalepGonder_Click);
            // 
            // dtpTeslimTarihi
            // 
            this.dtpTeslimTarihi.Location = new System.Drawing.Point(185, 165);
            this.dtpTeslimTarihi.Name = "dtpTeslimTarihi";
            this.dtpTeslimTarihi.Size = new System.Drawing.Size(200, 22);
            this.dtpTeslimTarihi.TabIndex = 5;
            // 
            // frmOduncTalep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 358);
            this.Controls.Add(this.dtpTeslimTarihi);
            this.Controls.Add(this.btnTalepGonder);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.lblSeciliKitapAdi);
            this.Controls.Add(this.label1);
            this.Name = "frmOduncTalep";
            this.Text = "Ödünç Talep Ekranı";
            this.Load += new System.EventHandler(this.frmOduncTalep_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSeciliKitapAdi;
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.Button btnTalepGonder;
        private System.Windows.Forms.DateTimePicker dtpTeslimTarihi;
    }
}