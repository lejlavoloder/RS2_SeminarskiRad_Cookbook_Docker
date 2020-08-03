namespace Cookbook.WinUI.Recept
{
    partial class frmDetaljiRecepta
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
            this.dgvRecept = new System.Windows.Forms.DataGridView();
            this.ReceptId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Recept = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SastojakId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sastojak = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MjernaJedinicaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MjernaJedinica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MjernaKolicinaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MjernaKolicina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecept)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRecept
            // 
            this.dgvRecept.AllowUserToAddRows = false;
            this.dgvRecept.AllowUserToDeleteRows = false;
            this.dgvRecept.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecept.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ReceptId,
            this.Recept,
            this.SastojakId,
            this.Sastojak,
            this.MjernaJedinicaId,
            this.MjernaJedinica,
            this.MjernaKolicinaId,
            this.MjernaKolicina});
            this.dgvRecept.Location = new System.Drawing.Point(43, 62);
            this.dgvRecept.Margin = new System.Windows.Forms.Padding(4);
            this.dgvRecept.Name = "dgvRecept";
            this.dgvRecept.ReadOnly = true;
            this.dgvRecept.RowHeadersWidth = 51;
            this.dgvRecept.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRecept.Size = new System.Drawing.Size(552, 271);
            this.dgvRecept.TabIndex = 1;
            // 
            // ReceptId
            // 
            this.ReceptId.DataPropertyName = "ReceptId";
            this.ReceptId.HeaderText = "ReceptId";
            this.ReceptId.MinimumWidth = 6;
            this.ReceptId.Name = "ReceptId";
            this.ReceptId.ReadOnly = true;
            this.ReceptId.Visible = false;
            this.ReceptId.Width = 125;
            // 
            // Recept
            // 
            this.Recept.DataPropertyName = "Recept";
            this.Recept.HeaderText = "Recept";
            this.Recept.MinimumWidth = 6;
            this.Recept.Name = "Recept";
            this.Recept.ReadOnly = true;
            this.Recept.Width = 125;
            // 
            // SastojakId
            // 
            this.SastojakId.DataPropertyName = "SastojakId";
            this.SastojakId.HeaderText = "SastojakId";
            this.SastojakId.MinimumWidth = 6;
            this.SastojakId.Name = "SastojakId";
            this.SastojakId.ReadOnly = true;
            this.SastojakId.Visible = false;
            this.SastojakId.Width = 125;
            // 
            // Sastojak
            // 
            this.Sastojak.DataPropertyName = "Sastojak";
            this.Sastojak.HeaderText = "Sastojak";
            this.Sastojak.MinimumWidth = 6;
            this.Sastojak.Name = "Sastojak";
            this.Sastojak.ReadOnly = true;
            this.Sastojak.Width = 125;
            // 
            // MjernaJedinicaId
            // 
            this.MjernaJedinicaId.DataPropertyName = "MjernaJedinicaId";
            this.MjernaJedinicaId.HeaderText = "MjernaJedinicaId";
            this.MjernaJedinicaId.MinimumWidth = 6;
            this.MjernaJedinicaId.Name = "MjernaJedinicaId";
            this.MjernaJedinicaId.ReadOnly = true;
            this.MjernaJedinicaId.Visible = false;
            this.MjernaJedinicaId.Width = 125;
            // 
            // MjernaJedinica
            // 
            this.MjernaJedinica.DataPropertyName = "MjernaJedinica";
            this.MjernaJedinica.HeaderText = "Mjerna jedinica";
            this.MjernaJedinica.MinimumWidth = 6;
            this.MjernaJedinica.Name = "MjernaJedinica";
            this.MjernaJedinica.ReadOnly = true;
            this.MjernaJedinica.Width = 125;
            // 
            // MjernaKolicinaId
            // 
            this.MjernaKolicinaId.DataPropertyName = "MjernaKolicinaId";
            this.MjernaKolicinaId.HeaderText = "MjernaKolicinaId";
            this.MjernaKolicinaId.MinimumWidth = 6;
            this.MjernaKolicinaId.Name = "MjernaKolicinaId";
            this.MjernaKolicinaId.ReadOnly = true;
            this.MjernaKolicinaId.Visible = false;
            this.MjernaKolicinaId.Width = 125;
            // 
            // MjernaKolicina
            // 
            this.MjernaKolicina.DataPropertyName = "MjernaKolicina";
            this.MjernaKolicina.HeaderText = "Mjerna kolicina";
            this.MjernaKolicina.MinimumWidth = 6;
            this.MjernaKolicina.Name = "MjernaKolicina";
            this.MjernaKolicina.ReadOnly = true;
            this.MjernaKolicina.Width = 125;
            // 
            // frmDetaljiRecepta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 401);
            this.Controls.Add(this.dgvRecept);
            this.Name = "frmDetaljiRecepta";
            this.Text = "frmDetaljiRecepta";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecept)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRecept;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReceptId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Recept;
        private System.Windows.Forms.DataGridViewTextBoxColumn SastojakId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sastojak;
        private System.Windows.Forms.DataGridViewTextBoxColumn MjernaJedinicaId;
        private System.Windows.Forms.DataGridViewTextBoxColumn MjernaJedinica;
        private System.Windows.Forms.DataGridViewTextBoxColumn MjernaKolicinaId;
        private System.Windows.Forms.DataGridViewTextBoxColumn MjernaKolicina;
    }
}