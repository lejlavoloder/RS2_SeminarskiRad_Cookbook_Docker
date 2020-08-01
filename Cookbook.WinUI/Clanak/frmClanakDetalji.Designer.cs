namespace Cookbook.WinUI.Clanak
{
    partial class frmClanakDetalji
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
            this.components = new System.ComponentModel.Container();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.dtObjave = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.richTextBtxtTekstox1 = new System.Windows.Forms.RichTextBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.cmbVrstaClanka = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.Location = new System.Drawing.Point(708, 425);
            this.btnSacuvaj.Margin = new System.Windows.Forms.Padding(4);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(100, 28);
            this.btnSacuvaj.TabIndex = 34;
            this.btnSacuvaj.Text = "Sačuvaj";
            this.btnSacuvaj.UseVisualStyleBackColor = true;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);
            // 
            // dtObjave
            // 
            this.dtObjave.Location = new System.Drawing.Point(232, 90);
            this.dtObjave.Margin = new System.Windows.Forms.Padding(4);
            this.dtObjave.Name = "dtObjave";
            this.dtObjave.Size = new System.Drawing.Size(265, 22);
            this.dtObjave.TabIndex = 33;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(164, 154);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 17);
            this.label4.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 90);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 17);
            this.label3.TabIndex = 31;
            this.label3.Text = "Datum/vrijeme objave";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(132, 228);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 17);
            this.label2.TabIndex = 30;
            this.label2.Text = "Tekst";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(161, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 29;
            this.label1.Text = "Naziv";
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(232, 41);
            this.txtNaziv.Margin = new System.Windows.Forms.Padding(4);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(265, 22);
            this.txtNaziv.TabIndex = 28;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // richTextBtxtTekstox1
            // 
            this.richTextBtxtTekstox1.Location = new System.Drawing.Point(232, 240);
            this.richTextBtxtTekstox1.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBtxtTekstox1.Name = "richTextBtxtTekstox1";
            this.richTextBtxtTekstox1.Size = new System.Drawing.Size(604, 117);
            this.richTextBtxtTekstox1.TabIndex = 39;
            this.richTextBtxtTekstox1.Text = "";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // cmbVrstaClanka
            // 
            this.cmbVrstaClanka.FormattingEnabled = true;
            this.cmbVrstaClanka.Location = new System.Drawing.Point(232, 154);
            this.cmbVrstaClanka.Margin = new System.Windows.Forms.Padding(4);
            this.cmbVrstaClanka.Name = "cmbVrstaClanka";
            this.cmbVrstaClanka.Size = new System.Drawing.Size(265, 24);
            this.cmbVrstaClanka.TabIndex = 40;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(118, 157);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 17);
            this.label6.TabIndex = 41;
            this.label6.Text = "VrstaClanka";
            // 
            // frmClanakDetalji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 477);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbVrstaClanka);
            this.Controls.Add(this.btnSacuvaj);
            this.Controls.Add(this.dtObjave);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.richTextBtxtTekstox1);
            this.Name = "frmClanakDetalji";
            this.Text = "frmClanakDetalji";
            this.Load += new System.EventHandler(this.frmClanakDetalji_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.DateTimePicker dtObjave;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.RichTextBox richTextBtxtTekstox1;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbVrstaClanka;
    }
}