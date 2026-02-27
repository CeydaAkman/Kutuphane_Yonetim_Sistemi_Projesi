namespace GRUP6
{
    partial class frmYonetici
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
            this.lblYonetici = new System.Windows.Forms.Label();
            this.btnEnvanterYonetimi = new System.Windows.Forms.Button();
            this.btnKullaniciYonetimi = new System.Windows.Forms.Button();
            this.btnRaporlarVeAnalizler = new System.Windows.Forms.Button();
            this.btnCikisYap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblYonetici
            // 
            this.lblYonetici.AutoSize = true;
            this.lblYonetici.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYonetici.Location = new System.Drawing.Point(152, 70);
            this.lblYonetici.Name = "lblYonetici";
            this.lblYonetici.Size = new System.Drawing.Size(226, 25);
            this.lblYonetici.TabIndex = 3;
            this.lblYonetici.Text = "Yönetici Yönetim Sistemi";
            // 
            // btnEnvanterYonetimi
            // 
            this.btnEnvanterYonetimi.Location = new System.Drawing.Point(186, 139);
            this.btnEnvanterYonetimi.Name = "btnEnvanterYonetimi";
            this.btnEnvanterYonetimi.Size = new System.Drawing.Size(166, 51);
            this.btnEnvanterYonetimi.TabIndex = 4;
            this.btnEnvanterYonetimi.Text = "Envanter Yönetimi";
            this.btnEnvanterYonetimi.UseVisualStyleBackColor = true;
            this.btnEnvanterYonetimi.Click += new System.EventHandler(this.btnEnvanterYonetimi_Click);
            // 
            // btnKullaniciYonetimi
            // 
            this.btnKullaniciYonetimi.Location = new System.Drawing.Point(186, 218);
            this.btnKullaniciYonetimi.Name = "btnKullaniciYonetimi";
            this.btnKullaniciYonetimi.Size = new System.Drawing.Size(166, 51);
            this.btnKullaniciYonetimi.TabIndex = 5;
            this.btnKullaniciYonetimi.Text = "Kullanıcı Yönetimi";
            this.btnKullaniciYonetimi.UseVisualStyleBackColor = true;
            this.btnKullaniciYonetimi.Click += new System.EventHandler(this.btnKullaniciYonetimi_Click);
            // 
            // btnRaporlarVeAnalizler
            // 
            this.btnRaporlarVeAnalizler.Location = new System.Drawing.Point(186, 296);
            this.btnRaporlarVeAnalizler.Name = "btnRaporlarVeAnalizler";
            this.btnRaporlarVeAnalizler.Size = new System.Drawing.Size(166, 51);
            this.btnRaporlarVeAnalizler.TabIndex = 6;
            this.btnRaporlarVeAnalizler.Text = "Raporlar ve Analizler";
            this.btnRaporlarVeAnalizler.UseVisualStyleBackColor = true;
            this.btnRaporlarVeAnalizler.Click += new System.EventHandler(this.btnRaporlarVeAnalizler_Click);
            // 
            // btnCikisYap
            // 
            this.btnCikisYap.Location = new System.Drawing.Point(440, 399);
            this.btnCikisYap.Name = "btnCikisYap";
            this.btnCikisYap.Size = new System.Drawing.Size(87, 27);
            this.btnCikisYap.TabIndex = 7;
            this.btnCikisYap.Text = "Çıkış Yap";
            this.btnCikisYap.UseVisualStyleBackColor = true;
            this.btnCikisYap.Click += new System.EventHandler(this.btnCikisYap_Click);
            // 
            // frmYonetici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 450);
            this.Controls.Add(this.btnCikisYap);
            this.Controls.Add(this.btnRaporlarVeAnalizler);
            this.Controls.Add(this.btnKullaniciYonetimi);
            this.Controls.Add(this.btnEnvanterYonetimi);
            this.Controls.Add(this.lblYonetici);
            this.Name = "frmYonetici";
            this.Text = "Yönetici Yönetim Sistemi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblYonetici;
        private System.Windows.Forms.Button btnEnvanterYonetimi;
        private System.Windows.Forms.Button btnKullaniciYonetimi;
        private System.Windows.Forms.Button btnRaporlarVeAnalizler;
        private System.Windows.Forms.Button btnCikisYap;
    }
}