namespace GRUP6
{
    partial class frmKullaniciYonetimi
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
            this.btnGeri = new System.Windows.Forms.Button();
            this.btnPersonelEkle = new System.Windows.Forms.Button();
            this.dgvKullanicilar = new System.Windows.Forms.DataGridView();
            this.cmbRolFiltre = new System.Windows.Forms.ComboBox();
            this.btsSil = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtSoyisim = new System.Windows.Forms.TextBox();
            this.txtEposta = new System.Windows.Forms.TextBox();
            this.txtNumara = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSifre = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKullanicilar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(516, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kullanıcı Yönetimi";
            // 
            // btnGeri
            // 
            this.btnGeri.Location = new System.Drawing.Point(38, 26);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(75, 23);
            this.btnGeri.TabIndex = 2;
            this.btnGeri.Text = "Geri";
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // btnPersonelEkle
            // 
            this.btnPersonelEkle.Location = new System.Drawing.Point(52, 399);
            this.btnPersonelEkle.Name = "btnPersonelEkle";
            this.btnPersonelEkle.Size = new System.Drawing.Size(123, 38);
            this.btnPersonelEkle.TabIndex = 7;
            this.btnPersonelEkle.Text = "Personel Ekle";
            this.btnPersonelEkle.UseVisualStyleBackColor = true;
            this.btnPersonelEkle.Click += new System.EventHandler(this.btnPersonelEkle_Click);
            // 
            // dgvKullanicilar
            // 
            this.dgvKullanicilar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKullanicilar.Location = new System.Drawing.Point(401, 119);
            this.dgvKullanicilar.Name = "dgvKullanicilar";
            this.dgvKullanicilar.RowHeadersWidth = 51;
            this.dgvKullanicilar.RowTemplate.Height = 24;
            this.dgvKullanicilar.Size = new System.Drawing.Size(760, 318);
            this.dgvKullanicilar.TabIndex = 0;
            // 
            // cmbRolFiltre
            // 
            this.cmbRolFiltre.FormattingEnabled = true;
            this.cmbRolFiltre.Location = new System.Drawing.Point(401, 79);
            this.cmbRolFiltre.Name = "cmbRolFiltre";
            this.cmbRolFiltre.Size = new System.Drawing.Size(121, 24);
            this.cmbRolFiltre.TabIndex = 3;
            // 
            // btsSil
            // 
            this.btsSil.Location = new System.Drawing.Point(204, 399);
            this.btsSil.Name = "btsSil";
            this.btsSil.Size = new System.Drawing.Size(123, 38);
            this.btsSil.TabIndex = 10;
            this.btsSil.Text = "Personel Sil";
            this.btsSil.UseVisualStyleBackColor = true;
            this.btsSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Adı: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Soyadı:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(80, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Eposta:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(80, 269);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "Numara:";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(180, 119);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(100, 22);
            this.txtAd.TabIndex = 15;
            // 
            // txtSoyisim
            // 
            this.txtSoyisim.Location = new System.Drawing.Point(180, 164);
            this.txtSoyisim.Name = "txtSoyisim";
            this.txtSoyisim.Size = new System.Drawing.Size(100, 22);
            this.txtSoyisim.TabIndex = 16;
            // 
            // txtEposta
            // 
            this.txtEposta.Location = new System.Drawing.Point(180, 217);
            this.txtEposta.Name = "txtEposta";
            this.txtEposta.Size = new System.Drawing.Size(100, 22);
            this.txtEposta.TabIndex = 17;
            // 
            // txtNumara
            // 
            this.txtNumara.Location = new System.Drawing.Point(180, 269);
            this.txtNumara.Name = "txtNumara";
            this.txtNumara.Size = new System.Drawing.Size(100, 22);
            this.txtNumara.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(80, 323);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 16);
            this.label6.TabIndex = 21;
            this.label6.Text = "Şifre:";
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(180, 323);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(100, 22);
            this.txtSifre.TabIndex = 22;
            this.txtSifre.UseSystemPasswordChar = true;
            // 
            // frmKullaniciYonetimi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1229, 481);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtNumara);
            this.Controls.Add(this.txtEposta);
            this.Controls.Add(this.txtSoyisim);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btsSil);
            this.Controls.Add(this.btnPersonelEkle);
            this.Controls.Add(this.cmbRolFiltre);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvKullanicilar);
            this.Name = "frmKullaniciYonetimi";
            this.Text = "Kullanıcı Yönetimi";
            ((System.ComponentModel.ISupportInitialize)(this.dgvKullanicilar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.Button btnPersonelEkle;
        private System.Windows.Forms.DataGridView dgvKullanicilar;
        private System.Windows.Forms.ComboBox cmbRolFiltre;
        private System.Windows.Forms.Button btsSil;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtSoyisim;
        private System.Windows.Forms.TextBox txtEposta;
        private System.Windows.Forms.TextBox txtNumara;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSifre;
    }
}