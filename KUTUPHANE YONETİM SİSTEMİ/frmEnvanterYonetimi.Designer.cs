namespace GRUP6
{
    partial class frmEnvanterYonetimi
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
            this.dgvMevcutKitaplar = new System.Windows.Forms.DataGridView();
            this.lblEnvanterYonetimi = new System.Windows.Forms.Label();
            this.btnGeri = new System.Windows.Forms.Button();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtYazar = new System.Windows.Forms.TextBox();
            this.txtStok = new System.Windows.Forms.TextBox();
            this.txtOzet = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.txtKategori = new System.Windows.Forms.TextBox();
            this.txtYayinYili = new System.Windows.Forms.TextBox();
            this.txtRafBilgisi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMevcutKitaplar)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMevcutKitaplar
            // 
            this.dgvMevcutKitaplar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMevcutKitaplar.Location = new System.Drawing.Point(329, 68);
            this.dgvMevcutKitaplar.Name = "dgvMevcutKitaplar";
            this.dgvMevcutKitaplar.RowHeadersWidth = 51;
            this.dgvMevcutKitaplar.RowTemplate.Height = 24;
            this.dgvMevcutKitaplar.Size = new System.Drawing.Size(1138, 350);
            this.dgvMevcutKitaplar.TabIndex = 0;
            // 
            // lblEnvanterYonetimi
            // 
            this.lblEnvanterYonetimi.AutoSize = true;
            this.lblEnvanterYonetimi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEnvanterYonetimi.Location = new System.Drawing.Point(651, 21);
            this.lblEnvanterYonetimi.Name = "lblEnvanterYonetimi";
            this.lblEnvanterYonetimi.Size = new System.Drawing.Size(170, 25);
            this.lblEnvanterYonetimi.TabIndex = 1;
            this.lblEnvanterYonetimi.Text = "Envanter Yönetimi";
            // 
            // btnGeri
            // 
            this.btnGeri.Location = new System.Drawing.Point(35, 25);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(75, 23);
            this.btnGeri.TabIndex = 2;
            this.btnGeri.Text = "Geri";
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(175, 68);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(100, 22);
            this.txtAd.TabIndex = 3;
            // 
            // txtYazar
            // 
            this.txtYazar.Location = new System.Drawing.Point(175, 101);
            this.txtYazar.Name = "txtYazar";
            this.txtYazar.Size = new System.Drawing.Size(100, 22);
            this.txtYazar.TabIndex = 4;
            // 
            // txtStok
            // 
            this.txtStok.Location = new System.Drawing.Point(175, 143);
            this.txtStok.Name = "txtStok";
            this.txtStok.Size = new System.Drawing.Size(100, 22);
            this.txtStok.TabIndex = 5;
            // 
            // txtOzet
            // 
            this.txtOzet.Location = new System.Drawing.Point(175, 179);
            this.txtOzet.Name = "txtOzet";
            this.txtOzet.Size = new System.Drawing.Size(100, 22);
            this.txtOzet.TabIndex = 6;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(8, 395);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(98, 23);
            this.btnEkle.TabIndex = 7;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(112, 395);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(98, 23);
            this.btnGuncelle.TabIndex = 8;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(216, 395);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(98, 23);
            this.btnSil.TabIndex = 9;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(68, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "İsim:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(68, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Yazar: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(68, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "Stok: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(68, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "Özet:";
            // 
            // txtISBN
            // 
            this.txtISBN.Location = new System.Drawing.Point(173, 218);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(100, 22);
            this.txtISBN.TabIndex = 17;
            // 
            // txtKategori
            // 
            this.txtKategori.Location = new System.Drawing.Point(175, 256);
            this.txtKategori.Name = "txtKategori";
            this.txtKategori.Size = new System.Drawing.Size(100, 22);
            this.txtKategori.TabIndex = 18;
            // 
            // txtYayinYili
            // 
            this.txtYayinYili.Location = new System.Drawing.Point(175, 293);
            this.txtYayinYili.Name = "txtYayinYili";
            this.txtYayinYili.Size = new System.Drawing.Size(100, 22);
            this.txtYayinYili.TabIndex = 19;
            // 
            // txtRafBilgisi
            // 
            this.txtRafBilgisi.Location = new System.Drawing.Point(173, 334);
            this.txtRafBilgisi.Name = "txtRafBilgisi";
            this.txtRafBilgisi.Size = new System.Drawing.Size(100, 22);
            this.txtRafBilgisi.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(68, 224);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 16);
            this.label6.TabIndex = 21;
            this.label6.Text = "İSBN";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(68, 262);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 16);
            this.label7.TabIndex = 22;
            this.label7.Text = "Kategori";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(68, 299);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 16);
            this.label8.TabIndex = 23;
            this.label8.Text = "Yayın Yılı";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(68, 340);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 16);
            this.label9.TabIndex = 24;
            this.label9.Text = "Raf Bilgisi";
            // 
            // frmEnvanterYonetimi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1518, 450);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtRafBilgisi);
            this.Controls.Add(this.txtYayinYili);
            this.Controls.Add(this.txtKategori);
            this.Controls.Add(this.txtISBN);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.txtOzet);
            this.Controls.Add(this.txtStok);
            this.Controls.Add(this.txtYazar);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.lblEnvanterYonetimi);
            this.Controls.Add(this.dgvMevcutKitaplar);
            this.Name = "frmEnvanterYonetimi";
            this.Text = "Envanter Yönetimi";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMevcutKitaplar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMevcutKitaplar;
        private System.Windows.Forms.Label lblEnvanterYonetimi;
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtYazar;
        private System.Windows.Forms.TextBox txtStok;
        private System.Windows.Forms.TextBox txtOzet;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.TextBox txtKategori;
        private System.Windows.Forms.TextBox txtYayinYili;
        private System.Windows.Forms.TextBox txtRafBilgisi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}