namespace GRUP6
{
    partial class frmGirisEkrani
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblEposta = new System.Windows.Forms.Label();
            this.lblSifre = new System.Windows.Forms.Label();
            this.lblKayıtOlma = new System.Windows.Forms.Label();
            this.txtEpostaGiris = new System.Windows.Forms.TextBox();
            this.txtSifreGiris = new System.Windows.Forms.TextBox();
            this.btnGirisYapma = new System.Windows.Forms.Button();
            this.btnKayıtOlma = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblEposta
            // 
            this.lblEposta.AutoSize = true;
            this.lblEposta.Location = new System.Drawing.Point(218, 124);
            this.lblEposta.Name = "lblEposta";
            this.lblEposta.Size = new System.Drawing.Size(50, 16);
            this.lblEposta.TabIndex = 0;
            this.lblEposta.Text = "Eposta";
            // 
            // lblSifre
            // 
            this.lblSifre.AutoSize = true;
            this.lblSifre.Location = new System.Drawing.Point(234, 167);
            this.lblSifre.Name = "lblSifre";
            this.lblSifre.Size = new System.Drawing.Size(34, 16);
            this.lblSifre.TabIndex = 1;
            this.lblSifre.Text = "Şifre";
            // 
            // lblKayıtOlma
            // 
            this.lblKayıtOlma.AutoSize = true;
            this.lblKayıtOlma.Location = new System.Drawing.Point(89, 291);
            this.lblKayıtOlma.Name = "lblKayıtOlma";
            this.lblKayıtOlma.Size = new System.Drawing.Size(179, 16);
            this.lblKayıtOlma.TabIndex = 2;
            this.lblKayıtOlma.Text = "Hesabınız yoksa kayıt olunuz";
            // 
            // txtEpostaGiris
            // 
            this.txtEpostaGiris.Location = new System.Drawing.Point(330, 124);
            this.txtEpostaGiris.Name = "txtEpostaGiris";
            this.txtEpostaGiris.Size = new System.Drawing.Size(202, 22);
            this.txtEpostaGiris.TabIndex = 3;
            // 
            // txtSifreGiris
            // 
            this.txtSifreGiris.Location = new System.Drawing.Point(330, 167);
            this.txtSifreGiris.Name = "txtSifreGiris";
            this.txtSifreGiris.Size = new System.Drawing.Size(202, 22);
            this.txtSifreGiris.TabIndex = 4;
            this.txtSifreGiris.UseSystemPasswordChar = true;
            // 
            // btnGirisYapma
            // 
            this.btnGirisYapma.Location = new System.Drawing.Point(330, 229);
            this.btnGirisYapma.Name = "btnGirisYapma";
            this.btnGirisYapma.Size = new System.Drawing.Size(202, 27);
            this.btnGirisYapma.TabIndex = 5;
            this.btnGirisYapma.Text = "Giriş Yap";
            this.btnGirisYapma.UseVisualStyleBackColor = true;
            this.btnGirisYapma.Click += new System.EventHandler(this.btnGirisYapma_Click);
            // 
            // btnKayıtOlma
            // 
            this.btnKayıtOlma.Location = new System.Drawing.Point(330, 291);
            this.btnKayıtOlma.Name = "btnKayıtOlma";
            this.btnKayıtOlma.Size = new System.Drawing.Size(202, 26);
            this.btnKayıtOlma.TabIndex = 6;
            this.btnKayıtOlma.Text = "Kayıt Ol";
            this.btnKayıtOlma.UseVisualStyleBackColor = true;
            this.btnKayıtOlma.Click += new System.EventHandler(this.btnKayitOl_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(268, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Giriş Ekranı";
            // 
            // frmGirisEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 405);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnKayıtOlma);
            this.Controls.Add(this.btnGirisYapma);
            this.Controls.Add(this.txtSifreGiris);
            this.Controls.Add(this.txtEpostaGiris);
            this.Controls.Add(this.lblKayıtOlma);
            this.Controls.Add(this.lblSifre);
            this.Controls.Add(this.lblEposta);
            this.Name = "frmGirisEkrani";
            this.Text = "Giriş Ekranı";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEposta;
        private System.Windows.Forms.Label lblSifre;
        private System.Windows.Forms.Label lblKayıtOlma;
        private System.Windows.Forms.TextBox txtEpostaGiris;
        private System.Windows.Forms.TextBox txtSifreGiris;
        private System.Windows.Forms.Button btnGirisYapma;
        private System.Windows.Forms.Button btnKayıtOlma;
        private System.Windows.Forms.Label label1;
    }
}

