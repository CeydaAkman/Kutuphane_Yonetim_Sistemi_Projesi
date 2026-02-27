namespace GRUP6
{
    partial class frmOgrenci
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
            this.dgvKitaplar = new System.Windows.Forms.DataGridView();
            this.lblOgrenci = new System.Windows.Forms.Label();
            this.txtArama = new System.Windows.Forms.TextBox();
            this.cmbFiltreleme = new System.Windows.Forms.ComboBox();
            this.btnOduncTalep = new System.Windows.Forms.Button();
            this.btnOduncTakip = new System.Windows.Forms.Button();
            this.btnCikisYap = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKitaplar)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvKitaplar
            // 
            this.dgvKitaplar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKitaplar.Location = new System.Drawing.Point(130, 123);
            this.dgvKitaplar.Name = "dgvKitaplar";
            this.dgvKitaplar.RowHeadersWidth = 51;
            this.dgvKitaplar.RowTemplate.Height = 24;
            this.dgvKitaplar.Size = new System.Drawing.Size(874, 283);
            this.dgvKitaplar.TabIndex = 0;
            this.dgvKitaplar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKitaplar_CellContentClick);
            // 
            // lblOgrenci
            // 
            this.lblOgrenci.AutoSize = true;
            this.lblOgrenci.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOgrenci.Location = new System.Drawing.Point(426, 25);
            this.lblOgrenci.Name = "lblOgrenci";
            this.lblOgrenci.Size = new System.Drawing.Size(242, 25);
            this.lblOgrenci.TabIndex = 1;
            this.lblOgrenci.Text = "Öğrenci Kütüphane Ekranı";
            // 
            // txtArama
            // 
            this.txtArama.Location = new System.Drawing.Point(288, 74);
            this.txtArama.Name = "txtArama";
            this.txtArama.Size = new System.Drawing.Size(206, 22);
            this.txtArama.TabIndex = 2;
            // 
            // cmbFiltreleme
            // 
            this.cmbFiltreleme.FormattingEnabled = true;
            this.cmbFiltreleme.Location = new System.Drawing.Point(612, 74);
            this.cmbFiltreleme.Name = "cmbFiltreleme";
            this.cmbFiltreleme.Size = new System.Drawing.Size(210, 24);
            this.cmbFiltreleme.TabIndex = 3;
            // 
            // btnOduncTalep
            // 
            this.btnOduncTalep.Location = new System.Drawing.Point(357, 436);
            this.btnOduncTalep.Name = "btnOduncTalep";
            this.btnOduncTalep.Size = new System.Drawing.Size(137, 47);
            this.btnOduncTalep.TabIndex = 5;
            this.btnOduncTalep.Text = "Ödünç Talep Ekranı";
            this.btnOduncTalep.UseVisualStyleBackColor = true;
            this.btnOduncTalep.Click += new System.EventHandler(this.btnOduncTalep_Click);
            // 
            // btnOduncTakip
            // 
            this.btnOduncTakip.Location = new System.Drawing.Point(612, 436);
            this.btnOduncTakip.Name = "btnOduncTakip";
            this.btnOduncTakip.Size = new System.Drawing.Size(137, 47);
            this.btnOduncTakip.TabIndex = 8;
            this.btnOduncTakip.Text = "Ödünç Takip Ekranı";
            this.btnOduncTakip.UseVisualStyleBackColor = true;
            this.btnOduncTakip.Click += new System.EventHandler(this.btnOduncTakip_Click);
            // 
            // btnCikisYap
            // 
            this.btnCikisYap.Location = new System.Drawing.Point(993, 497);
            this.btnCikisYap.Name = "btnCikisYap";
            this.btnCikisYap.Size = new System.Drawing.Size(87, 27);
            this.btnCikisYap.TabIndex = 9;
            this.btnCikisYap.Text = "Çıkış Yap";
            this.btnCikisYap.UseVisualStyleBackColor = true;
            this.btnCikisYap.Click += new System.EventHandler(this.btnCikisYap_Click);
            // 
            // frmOgrenci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 547);
            this.Controls.Add(this.btnCikisYap);
            this.Controls.Add(this.btnOduncTakip);
            this.Controls.Add(this.btnOduncTalep);
            this.Controls.Add(this.cmbFiltreleme);
            this.Controls.Add(this.txtArama);
            this.Controls.Add(this.lblOgrenci);
            this.Controls.Add(this.dgvKitaplar);
            this.Name = "frmOgrenci";
            this.Text = "Öğrenci Kütüphane Ekranı";
            ((System.ComponentModel.ISupportInitialize)(this.dgvKitaplar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvKitaplar;
        private System.Windows.Forms.Label lblOgrenci;
        private System.Windows.Forms.TextBox txtArama;
        private System.Windows.Forms.ComboBox cmbFiltreleme;
        private System.Windows.Forms.Button btnOduncTalep;
        private System.Windows.Forms.Button btnOduncTakip;
        private System.Windows.Forms.Button btnCikisYap;
    }
}