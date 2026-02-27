namespace GRUP6
{
    partial class frmBekleyenTalepler
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
            this.dgvBekleyenTalepler = new System.Windows.Forms.DataGridView();
            this.btnGeri = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBekleyenTalepler)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBekleyenTalepler
            // 
            this.dgvBekleyenTalepler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBekleyenTalepler.Location = new System.Drawing.Point(54, 85);
            this.dgvBekleyenTalepler.Name = "dgvBekleyenTalepler";
            this.dgvBekleyenTalepler.RowHeadersWidth = 51;
            this.dgvBekleyenTalepler.RowTemplate.Height = 24;
            this.dgvBekleyenTalepler.Size = new System.Drawing.Size(876, 313);
            this.dgvBekleyenTalepler.TabIndex = 0;
            // 
            // btnGeri
            // 
            this.btnGeri.Location = new System.Drawing.Point(54, 29);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(75, 23);
            this.btnGeri.TabIndex = 1;
            this.btnGeri.Text = "Geri";
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(404, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Bekleyen Talepler";
            // 
            // frmBekleyenTalepler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.dgvBekleyenTalepler);
            this.Name = "frmBekleyenTalepler";
            this.Text = "Bekleyen Talepler";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBekleyenTalepler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBekleyenTalepler;
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.Label label1;
    }
}