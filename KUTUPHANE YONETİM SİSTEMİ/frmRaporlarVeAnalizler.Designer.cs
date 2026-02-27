namespace GRUP6
{
    partial class frmRaporlarVeAnalizler
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
            this.lblRaporlarVeAnalizler = new System.Windows.Forms.Label();
            this.btnGeri = new System.Windows.Forms.Button();
            this.dgvEnCokOdunc = new System.Windows.Forms.DataGridView();
            this.lblToplamOduncSayisi = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbDonemFiltre = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEnCokOdunc)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRaporlarVeAnalizler
            // 
            this.lblRaporlarVeAnalizler.AutoSize = true;
            this.lblRaporlarVeAnalizler.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblRaporlarVeAnalizler.Location = new System.Drawing.Point(214, 27);
            this.lblRaporlarVeAnalizler.Name = "lblRaporlarVeAnalizler";
            this.lblRaporlarVeAnalizler.Size = new System.Drawing.Size(191, 25);
            this.lblRaporlarVeAnalizler.TabIndex = 0;
            this.lblRaporlarVeAnalizler.Text = "Raporlar ve Analizler";
            // 
            // btnGeri
            // 
            this.btnGeri.Location = new System.Drawing.Point(38, 27);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(75, 23);
            this.btnGeri.TabIndex = 1;
            this.btnGeri.Text = "Geri";
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // dgvEnCokOdunc
            // 
            this.dgvEnCokOdunc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEnCokOdunc.Location = new System.Drawing.Point(152, 119);
            this.dgvEnCokOdunc.Name = "dgvEnCokOdunc";
            this.dgvEnCokOdunc.RowHeadersWidth = 51;
            this.dgvEnCokOdunc.RowTemplate.Height = 24;
            this.dgvEnCokOdunc.Size = new System.Drawing.Size(338, 262);
            this.dgvEnCokOdunc.TabIndex = 3;
            // 
            // lblToplamOduncSayisi
            // 
            this.lblToplamOduncSayisi.AutoSize = true;
            this.lblToplamOduncSayisi.Location = new System.Drawing.Point(337, 406);
            this.lblToplamOduncSayisi.Name = "lblToplamOduncSayisi";
            this.lblToplamOduncSayisi.Size = new System.Drawing.Size(84, 16);
            this.lblToplamOduncSayisi.TabIndex = 4;
            this.lblToplamOduncSayisi.Text = "Ödünç sayısı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(149, 406);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Toplam Ödünç Sayısı:";
            // 
            // cmbDonemFiltre
            // 
            this.cmbDonemFiltre.FormattingEnabled = true;
            this.cmbDonemFiltre.Location = new System.Drawing.Point(152, 89);
            this.cmbDonemFiltre.Name = "cmbDonemFiltre";
            this.cmbDonemFiltre.Size = new System.Drawing.Size(121, 24);
            this.cmbDonemFiltre.TabIndex = 6;
            // 
            // frmRaporlarVeAnalizler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 450);
            this.Controls.Add(this.cmbDonemFiltre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblToplamOduncSayisi);
            this.Controls.Add(this.dgvEnCokOdunc);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.lblRaporlarVeAnalizler);
            this.Name = "frmRaporlarVeAnalizler";
            this.Text = "Raporlar Ve Analizler";
            this.Load += new System.EventHandler(this.frmRaporlarVeAnalizler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEnCokOdunc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRaporlarVeAnalizler;
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.DataGridView dgvEnCokOdunc;
        private System.Windows.Forms.Label lblToplamOduncSayisi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbDonemFiltre;
    }
}