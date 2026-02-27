namespace GRUP6
{
    partial class frmOduncTakip
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
            this.dgvTakipListesi = new System.Windows.Forms.DataGridView();
            this.lblOduncTakipEkrani = new System.Windows.Forms.Label();
            this.btnGeri = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTakipListesi)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTakipListesi
            // 
            this.dgvTakipListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTakipListesi.Location = new System.Drawing.Point(85, 102);
            this.dgvTakipListesi.Name = "dgvTakipListesi";
            this.dgvTakipListesi.RowHeadersWidth = 51;
            this.dgvTakipListesi.RowTemplate.Height = 24;
            this.dgvTakipListesi.Size = new System.Drawing.Size(604, 282);
            this.dgvTakipListesi.TabIndex = 0;
            // 
            // lblOduncTakipEkrani
            // 
            this.lblOduncTakipEkrani.AutoSize = true;
            this.lblOduncTakipEkrani.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOduncTakipEkrani.Location = new System.Drawing.Point(303, 29);
            this.lblOduncTakipEkrani.Name = "lblOduncTakipEkrani";
            this.lblOduncTakipEkrani.Size = new System.Drawing.Size(185, 25);
            this.lblOduncTakipEkrani.TabIndex = 1;
            this.lblOduncTakipEkrani.Text = "Ödünç Takip Ekranı";
            // 
            // btnGeri
            // 
            this.btnGeri.Location = new System.Drawing.Point(47, 29);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(75, 23);
            this.btnGeri.TabIndex = 2;
            this.btnGeri.Text = "Geri";
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // frmOduncTakip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 450);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.lblOduncTakipEkrani);
            this.Controls.Add(this.dgvTakipListesi);
            this.Name = "frmOduncTakip";
            this.Text = "Ödünç Takip Ekranı";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTakipListesi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTakipListesi;
        private System.Windows.Forms.Label lblOduncTakipEkrani;
        private System.Windows.Forms.Button btnGeri;
    }
}