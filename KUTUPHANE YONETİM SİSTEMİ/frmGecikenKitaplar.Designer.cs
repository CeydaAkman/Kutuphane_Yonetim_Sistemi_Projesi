namespace GRUP6
{
    partial class frmGecikenKitaplar
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
            this.dgvGecikenKitaplar = new System.Windows.Forms.DataGridView();
            this.btnGeri = new System.Windows.Forms.Button();
            this.lblGecikenKitaplar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGecikenKitaplar)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvGecikenKitaplar
            // 
            this.dgvGecikenKitaplar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGecikenKitaplar.Location = new System.Drawing.Point(51, 82);
            this.dgvGecikenKitaplar.Name = "dgvGecikenKitaplar";
            this.dgvGecikenKitaplar.RowHeadersWidth = 51;
            this.dgvGecikenKitaplar.RowTemplate.Height = 24;
            this.dgvGecikenKitaplar.Size = new System.Drawing.Size(606, 330);
            this.dgvGecikenKitaplar.TabIndex = 0;
            // 
            // btnGeri
            // 
            this.btnGeri.Location = new System.Drawing.Point(51, 21);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(75, 23);
            this.btnGeri.TabIndex = 1;
            this.btnGeri.Text = "Geri";
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // lblGecikenKitaplar
            // 
            this.lblGecikenKitaplar.AutoSize = true;
            this.lblGecikenKitaplar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGecikenKitaplar.Location = new System.Drawing.Point(268, 21);
            this.lblGecikenKitaplar.Name = "lblGecikenKitaplar";
            this.lblGecikenKitaplar.Size = new System.Drawing.Size(155, 25);
            this.lblGecikenKitaplar.TabIndex = 2;
            this.lblGecikenKitaplar.Text = "Geciken Kitaplar";
            // 
            // frmGecikenKitaplar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 450);
            this.Controls.Add(this.lblGecikenKitaplar);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.dgvGecikenKitaplar);
            this.Name = "frmGecikenKitaplar";
            this.Text = "Geciken Kitaplar";
            ((System.ComponentModel.ISupportInitialize)(this.dgvGecikenKitaplar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvGecikenKitaplar;
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.Label lblGecikenKitaplar;
    }
}