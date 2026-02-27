namespace GRUP6
{
    partial class frmPersonel
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
            this.lblPersonel = new System.Windows.Forms.Label();
            this.btnBekleyenTalepler = new System.Windows.Forms.Button();
            this.btnKitapTeslimEtme = new System.Windows.Forms.Button();
            this.btnGecikenKitaplar = new System.Windows.Forms.Button();
            this.btnİstatistikler = new System.Windows.Forms.Button();
            this.btnCikisYap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPersonel
            // 
            this.lblPersonel.AutoSize = true;
            this.lblPersonel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPersonel.Location = new System.Drawing.Point(161, 44);
            this.lblPersonel.Name = "lblPersonel";
            this.lblPersonel.Size = new System.Drawing.Size(234, 25);
            this.lblPersonel.TabIndex = 0;
            this.lblPersonel.Text = "Personel Yönetim Sistemi";
            // 
            // btnBekleyenTalepler
            // 
            this.btnBekleyenTalepler.Location = new System.Drawing.Point(185, 111);
            this.btnBekleyenTalepler.Name = "btnBekleyenTalepler";
            this.btnBekleyenTalepler.Size = new System.Drawing.Size(197, 51);
            this.btnBekleyenTalepler.TabIndex = 2;
            this.btnBekleyenTalepler.Text = "Bekleyen Talepler";
            this.btnBekleyenTalepler.UseVisualStyleBackColor = true;
            this.btnBekleyenTalepler.Click += new System.EventHandler(this.btnBekleyenTalepler_Click);
            // 
            // btnKitapTeslimEtme
            // 
            this.btnKitapTeslimEtme.Location = new System.Drawing.Point(185, 187);
            this.btnKitapTeslimEtme.Name = "btnKitapTeslimEtme";
            this.btnKitapTeslimEtme.Size = new System.Drawing.Size(197, 51);
            this.btnKitapTeslimEtme.TabIndex = 3;
            this.btnKitapTeslimEtme.Text = "Kitap Teslim Ve İade Etme";
            this.btnKitapTeslimEtme.UseVisualStyleBackColor = true;
            this.btnKitapTeslimEtme.Click += new System.EventHandler(this.btnKitapTeslimEtme_Click);
            // 
            // btnGecikenKitaplar
            // 
            this.btnGecikenKitaplar.Location = new System.Drawing.Point(185, 260);
            this.btnGecikenKitaplar.Name = "btnGecikenKitaplar";
            this.btnGecikenKitaplar.Size = new System.Drawing.Size(197, 51);
            this.btnGecikenKitaplar.TabIndex = 4;
            this.btnGecikenKitaplar.Text = "Geciken Kitaplar";
            this.btnGecikenKitaplar.UseVisualStyleBackColor = true;
            this.btnGecikenKitaplar.Click += new System.EventHandler(this.btnGecikenKitaplar_Click);
            // 
            // btnİstatistikler
            // 
            this.btnİstatistikler.Location = new System.Drawing.Point(185, 334);
            this.btnİstatistikler.Name = "btnİstatistikler";
            this.btnİstatistikler.Size = new System.Drawing.Size(197, 51);
            this.btnİstatistikler.TabIndex = 5;
            this.btnİstatistikler.Text = "İstatistikler";
            this.btnİstatistikler.UseVisualStyleBackColor = true;
            this.btnİstatistikler.Click += new System.EventHandler(this.btnIstatistikler_Click);
            // 
            // btnCikisYap
            // 
            this.btnCikisYap.Location = new System.Drawing.Point(440, 399);
            this.btnCikisYap.Name = "btnCikisYap";
            this.btnCikisYap.Size = new System.Drawing.Size(87, 27);
            this.btnCikisYap.TabIndex = 8;
            this.btnCikisYap.Text = "Çıkış Yap";
            this.btnCikisYap.UseVisualStyleBackColor = true;
            this.btnCikisYap.Click += new System.EventHandler(this.btnCikisYap_Click);
            // 
            // frmPersonel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 450);
            this.Controls.Add(this.btnCikisYap);
            this.Controls.Add(this.btnİstatistikler);
            this.Controls.Add(this.btnGecikenKitaplar);
            this.Controls.Add(this.btnKitapTeslimEtme);
            this.Controls.Add(this.btnBekleyenTalepler);
            this.Controls.Add(this.lblPersonel);
            this.Name = "frmPersonel";
            this.Text = "Personel Yönetim Sistemi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPersonel;
        private System.Windows.Forms.Button btnBekleyenTalepler;
        private System.Windows.Forms.Button btnKitapTeslimEtme;
        private System.Windows.Forms.Button btnGecikenKitaplar;
        private System.Windows.Forms.Button btnİstatistikler;
        private System.Windows.Forms.Button btnCikisYap;
    }
}