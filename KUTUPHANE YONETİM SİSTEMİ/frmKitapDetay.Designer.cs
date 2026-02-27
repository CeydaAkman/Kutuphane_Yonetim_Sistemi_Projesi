namespace GRUP6
{
    partial class frmKitapDetay
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
            this.lblKitapAdi = new System.Windows.Forms.Label();
            this.lblYazar = new System.Windows.Forms.Label();
            this.lblStokDurumu = new System.Windows.Forms.Label();
            this.txtOzet = new System.Windows.Forms.TextBox();
            this.btnGeri = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblRafBilgisi = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblKitapAdi
            // 
            this.lblKitapAdi.AutoSize = true;
            this.lblKitapAdi.Location = new System.Drawing.Point(152, 109);
            this.lblKitapAdi.Name = "lblKitapAdi";
            this.lblKitapAdi.Size = new System.Drawing.Size(60, 16);
            this.lblKitapAdi.TabIndex = 0;
            this.lblKitapAdi.Text = "Kitap Adı";
            // 
            // lblYazar
            // 
            this.lblYazar.AutoSize = true;
            this.lblYazar.Location = new System.Drawing.Point(152, 150);
            this.lblYazar.Name = "lblYazar";
            this.lblYazar.Size = new System.Drawing.Size(42, 16);
            this.lblYazar.TabIndex = 1;
            this.lblYazar.Text = "Yazar";
            // 
            // lblStokDurumu
            // 
            this.lblStokDurumu.AutoSize = true;
            this.lblStokDurumu.Location = new System.Drawing.Point(152, 221);
            this.lblStokDurumu.Name = "lblStokDurumu";
            this.lblStokDurumu.Size = new System.Drawing.Size(83, 16);
            this.lblStokDurumu.TabIndex = 2;
            this.lblStokDurumu.Text = "Stok Durumu";
            // 
            // txtOzet
            // 
            this.txtOzet.Location = new System.Drawing.Point(155, 261);
            this.txtOzet.Multiline = true;
            this.txtOzet.Name = "txtOzet";
            this.txtOzet.Size = new System.Drawing.Size(343, 76);
            this.txtOzet.TabIndex = 4;
            // 
            // btnGeri
            // 
            this.btnGeri.Location = new System.Drawing.Point(35, 27);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(75, 23);
            this.btnGeri.TabIndex = 5;
            this.btnGeri.Text = "Geri";
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(227, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Kitap Detay Sayfası";
            // 
            // lblRafBilgisi
            // 
            this.lblRafBilgisi.AutoSize = true;
            this.lblRafBilgisi.Location = new System.Drawing.Point(152, 186);
            this.lblRafBilgisi.Name = "lblRafBilgisi";
            this.lblRafBilgisi.Size = new System.Drawing.Size(67, 16);
            this.lblRafBilgisi.TabIndex = 7;
            this.lblRafBilgisi.Text = "Raf Bilgisi";
            // 
            // frmKitapDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 419);
            this.Controls.Add(this.lblRafBilgisi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.txtOzet);
            this.Controls.Add(this.lblStokDurumu);
            this.Controls.Add(this.lblYazar);
            this.Controls.Add(this.lblKitapAdi);
            this.Name = "frmKitapDetay";
            this.Text = "Kitap Detay Sayfası";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKitapAdi;
        private System.Windows.Forms.Label lblYazar;
        private System.Windows.Forms.Label lblStokDurumu;
        private System.Windows.Forms.TextBox txtOzet;
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblRafBilgisi;
    }
}