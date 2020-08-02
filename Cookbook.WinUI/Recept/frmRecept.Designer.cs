namespace Cookbook.WinUI.Recept
{
    partial class frmRecept
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
            this.btnSlika = new System.Windows.Forms.Button();
            this.txtInputSlike = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.dtObjave = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.richTextBtxtTekstox1 = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.txtVrijemePripreme = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtVrijemeKuhanja = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtBrojLjudi = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbKategorija = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cmbSlozenost = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.chBoxAktivan = new System.Windows.Forms.CheckBox();
            this.cmbGrupaJela = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSlika
            // 
            this.btnSlika.Location = new System.Drawing.Point(804, 310);
            this.btnSlika.Margin = new System.Windows.Forms.Padding(4);
            this.btnSlika.Name = "btnSlika";
            this.btnSlika.Size = new System.Drawing.Size(100, 28);
            this.btnSlika.TabIndex = 37;
            this.btnSlika.Text = "Dodaj sliku";
            this.btnSlika.UseVisualStyleBackColor = true;
            this.btnSlika.Click += new System.EventHandler(this.btnSlika_Click);
            // 
            // txtInputSlike
            // 
            this.txtInputSlike.Location = new System.Drawing.Point(728, 259);
            this.txtInputSlike.Margin = new System.Windows.Forms.Padding(4);
            this.txtInputSlike.Name = "txtInputSlike";
            this.txtInputSlike.Size = new System.Drawing.Size(265, 22);
            this.txtInputSlike.TabIndex = 36;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(673, 262);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 17);
            this.label5.TabIndex = 35;
            this.label5.Text = "Slika";
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.Location = new System.Drawing.Point(828, 619);
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
            this.dtObjave.Location = new System.Drawing.Point(204, 604);
            this.dtObjave.Margin = new System.Windows.Forms.Padding(4);
            this.dtObjave.Name = "dtObjave";
            this.dtObjave.Size = new System.Drawing.Size(265, 22);
            this.dtObjave.TabIndex = 33;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(117, 121);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 17);
            this.label4.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 609);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 17);
            this.label3.TabIndex = 31;
            this.label3.Text = "Datum/vrijeme objave";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(96, 479);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 30;
            this.label2.Text = "Priprema";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 29;
            this.label1.Text = "Naziv";
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(204, 32);
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
            this.richTextBtxtTekstox1.Location = new System.Drawing.Point(204, 444);
            this.richTextBtxtTekstox1.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBtxtTekstox1.Name = "richTextBtxtTekstox1";
            this.richTextBtxtTekstox1.Size = new System.Drawing.Size(603, 136);
            this.richTextBtxtTekstox1.TabIndex = 39;
            this.richTextBtxtTekstox1.Text = "";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(728, 28);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(253, 174);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 38;
            this.pictureBox1.TabStop = false;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 92);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(192, 17);
            this.label6.TabIndex = 41;
            this.label6.Text = "Vrijeme pripreme u minutama";
            // 
            // txtVrijemePripreme
            // 
            this.txtVrijemePripreme.Location = new System.Drawing.Point(204, 89);
            this.txtVrijemePripreme.Margin = new System.Windows.Forms.Padding(4);
            this.txtVrijemePripreme.Name = "txtVrijemePripreme";
            this.txtVrijemePripreme.Size = new System.Drawing.Size(265, 22);
            this.txtVrijemePripreme.TabIndex = 40;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 141);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(186, 17);
            this.label7.TabIndex = 44;
            this.label7.Text = "Vrijeme kuhanja u minutama";
            // 
            // txtVrijemeKuhanja
            // 
            this.txtVrijemeKuhanja.Location = new System.Drawing.Point(204, 141);
            this.txtVrijemeKuhanja.Margin = new System.Windows.Forms.Padding(4);
            this.txtVrijemeKuhanja.Name = "txtVrijemeKuhanja";
            this.txtVrijemeKuhanja.Size = new System.Drawing.Size(265, 22);
            this.txtVrijemeKuhanja.TabIndex = 43;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(117, 173);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 17);
            this.label8.TabIndex = 42;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(99, 198);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 17);
            this.label9.TabIndex = 47;
            this.label9.Text = "Broj ljudi";
            // 
            // txtBrojLjudi
            // 
            this.txtBrojLjudi.Location = new System.Drawing.Point(204, 198);
            this.txtBrojLjudi.Margin = new System.Windows.Forms.Padding(4);
            this.txtBrojLjudi.Name = "txtBrojLjudi";
            this.txtBrojLjudi.Size = new System.Drawing.Size(265, 22);
            this.txtBrojLjudi.TabIndex = 46;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(117, 230);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 17);
            this.label10.TabIndex = 45;
            // 
            // cmbKategorija
            // 
            this.cmbKategorija.FormattingEnabled = true;
            this.cmbKategorija.Location = new System.Drawing.Point(204, 271);
            this.cmbKategorija.Margin = new System.Windows.Forms.Padding(4);
            this.cmbKategorija.Name = "cmbKategorija";
            this.cmbKategorija.Size = new System.Drawing.Size(265, 24);
            this.cmbKategorija.TabIndex = 48;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(96, 274);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 17);
            this.label11.TabIndex = 49;
            this.label11.Text = "Kategorija";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(96, 337);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(70, 17);
            this.label12.TabIndex = 51;
            this.label12.Text = "Složenost";
            // 
            // cmbSlozenost
            // 
            this.cmbSlozenost.FormattingEnabled = true;
            this.cmbSlozenost.Location = new System.Drawing.Point(204, 334);
            this.cmbSlozenost.Margin = new System.Windows.Forms.Padding(4);
            this.cmbSlozenost.Name = "cmbSlozenost";
            this.cmbSlozenost.Size = new System.Drawing.Size(265, 24);
            this.cmbSlozenost.TabIndex = 50;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(96, 396);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(74, 17);
            this.label13.TabIndex = 53;
            this.label13.Text = "Grupa jela";
            // 
            // chBoxAktivan
            // 
            this.chBoxAktivan.AutoSize = true;
            this.chBoxAktivan.Location = new System.Drawing.Point(192, 660);
            this.chBoxAktivan.Margin = new System.Windows.Forms.Padding(4);
            this.chBoxAktivan.Name = "chBoxAktivan";
            this.chBoxAktivan.Size = new System.Drawing.Size(76, 21);
            this.chBoxAktivan.TabIndex = 55;
            this.chBoxAktivan.Text = "Aktivan";
            this.chBoxAktivan.UseVisualStyleBackColor = true;
            // 
            // cmbGrupaJela
            // 
            this.cmbGrupaJela.FormattingEnabled = true;
            this.cmbGrupaJela.Location = new System.Drawing.Point(204, 396);
            this.cmbGrupaJela.Margin = new System.Windows.Forms.Padding(4);
            this.cmbGrupaJela.Name = "cmbGrupaJela";
            this.cmbGrupaJela.Size = new System.Drawing.Size(265, 24);
            this.cmbGrupaJela.TabIndex = 56;
            // 
            // frmRecept
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 694);
            this.Controls.Add(this.cmbGrupaJela);
            this.Controls.Add(this.chBoxAktivan);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cmbSlozenost);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cmbKategorija);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtBrojLjudi);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtVrijemeKuhanja);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtVrijemePripreme);
            this.Controls.Add(this.btnSlika);
            this.Controls.Add(this.txtInputSlike);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnSacuvaj);
            this.Controls.Add(this.dtObjave);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.richTextBtxtTekstox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmRecept";
            this.Text = "frmRecept";
            this.Load += new System.EventHandler(this.frmRecept_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSlika;
        private System.Windows.Forms.TextBox txtInputSlike;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.DateTimePicker dtObjave;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.RichTextBox richTextBtxtTekstox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.CheckBox chBoxAktivan;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmbKategorija;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmbSlozenost;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtBrojLjudi;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtVrijemeKuhanja;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtVrijemePripreme;
        private System.Windows.Forms.ComboBox cmbGrupaJela;
    }
}