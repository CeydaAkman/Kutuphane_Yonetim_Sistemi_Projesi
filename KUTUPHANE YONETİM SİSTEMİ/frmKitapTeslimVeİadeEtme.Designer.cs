namespace GRUP6
{
    partial class frmKitapTeslimVeİadeEtme
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
            this.dgvKitapTeslimEtme = new System.Windows.Forms.DataGridView();
            this.btnGeri = new System.Windows.Forms.Button();
            this.lblKitapTeslimEtme = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKitapTeslimEtme)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvKitapTeslimEtme
            // 
            this.dgvKitapTeslimEtme.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKitapTeslimEtme.Location = new System.Drawing.Point(48, 80);
            this.dgvKitapTeslimEtme.Name = "dgvKitapTeslimEtme";
            this.dgvKitapTeslimEtme.RowHeadersWidth = 51;
            this.dgvKitapTeslimEtme.RowTemplate.Height = 24;
            this.dgvKitapTeslimEtme.Size = new System.Drawing.Size(739, 320);
            this.dgvKitapTeslimEtme.TabIndex = 0;
            // 
            // btnGeri
            // 
            this.btnGeri.Location = new System.Drawing.Point(48, 25);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(75, 23);
            this.btnGeri.TabIndex = 1;
            this.btnGeri.Text = "Geri";
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // lblKitapTeslimEtme
            // 
            this.lblKitapTeslimEtme.AutoSize = true;
            this.lblKitapTeslimEtme.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKitapTeslimEtme.Location = new System.Drawing.Point(295, 25);
            this.lblKitapTeslimEtme.Name = "lblKitapTeslimEtme";
            this.lblKitapTeslimEtme.Size = new System.Drawing.Size(243, 25);
            this.lblKitapTeslimEtme.TabIndex = 2;
            this.lblKitapTeslimEtme.Text = "Kitap Teslim Ve İade Etme";
            // 
            // frmKitapTeslimVeİadeEtme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 450);
            this.Controls.Add(this.lblKitapTeslimEtme);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.dgvKitapTeslimEtme);
            this.Name = "frmKitapTeslimVeİadeEtme";
            this.Text = "Kitap Teslim Ve İade Etme";
            ((System.ComponentModel.ISupportInitialize)(this.dgvKitapTeslimEtme)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvKitapTeslimEtme;
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.Label lblKitapTeslimEtme;
    }
}