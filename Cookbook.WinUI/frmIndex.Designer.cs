namespace Cookbook.WinUI
{
    partial class frmIndex
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.sastojciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pretragaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kategorijaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pretragaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.novaKategorijaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mjernaJedinicaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pretragaToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.novaMjernaJedinicaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grupaJelaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pretragaToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.novaGrupaJelaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.slozenostToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pretragaToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.novaSloženostToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mjernaKoličinaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pretragaToolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajNovuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vrstaČlankaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pretragaToolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajNovuToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.clanakToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pretragaToolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajNoviToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.receptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajNoviToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajSastojakToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.pretragaRecepataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sastojciToolStripMenuItem,
            this.kategorijaToolStripMenuItem,
            this.mjernaJedinicaToolStripMenuItem,
            this.grupaJelaToolStripMenuItem,
            this.toolStripMenuItem1,
            this.slozenostToolStripMenuItem,
            this.mjernaKoličinaToolStripMenuItem,
            this.vrstaČlankaToolStripMenuItem,
            this.clanakToolStripMenuItem,
            this.receptToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1015, 28);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // sastojciToolStripMenuItem
            // 
            this.sastojciToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pretragaToolStripMenuItem,
            this.dToolStripMenuItem});
            this.sastojciToolStripMenuItem.Name = "sastojciToolStripMenuItem";
            this.sastojciToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.sastojciToolStripMenuItem.Text = "Sastojci";
            // 
            // pretragaToolStripMenuItem
            // 
            this.pretragaToolStripMenuItem.Name = "pretragaToolStripMenuItem";
            this.pretragaToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.pretragaToolStripMenuItem.Text = "Pretraga";
            this.pretragaToolStripMenuItem.Click += new System.EventHandler(this.pretragaToolStripMenuItem_Click);
            // 
            // dToolStripMenuItem
            // 
            this.dToolStripMenuItem.Name = "dToolStripMenuItem";
            this.dToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.dToolStripMenuItem.Text = "Novi sastojak";
            this.dToolStripMenuItem.Click += new System.EventHandler(this.dToolStripMenuItem_Click);
            // 
            // kategorijaToolStripMenuItem
            // 
            this.kategorijaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pretragaToolStripMenuItem1,
            this.novaKategorijaToolStripMenuItem});
            this.kategorijaToolStripMenuItem.Name = "kategorijaToolStripMenuItem";
            this.kategorijaToolStripMenuItem.Size = new System.Drawing.Size(92, 24);
            this.kategorijaToolStripMenuItem.Text = "Kategorija";
            // 
            // pretragaToolStripMenuItem1
            // 
            this.pretragaToolStripMenuItem1.Name = "pretragaToolStripMenuItem1";
            this.pretragaToolStripMenuItem1.Size = new System.Drawing.Size(198, 26);
            this.pretragaToolStripMenuItem1.Text = "Pretraga";
            this.pretragaToolStripMenuItem1.Click += new System.EventHandler(this.pretragaToolStripMenuItem1_Click);
            // 
            // novaKategorijaToolStripMenuItem
            // 
            this.novaKategorijaToolStripMenuItem.Name = "novaKategorijaToolStripMenuItem";
            this.novaKategorijaToolStripMenuItem.Size = new System.Drawing.Size(198, 26);
            this.novaKategorijaToolStripMenuItem.Text = "Nova kategorija";
            this.novaKategorijaToolStripMenuItem.Click += new System.EventHandler(this.novaKategorijaToolStripMenuItem_Click);
            // 
            // mjernaJedinicaToolStripMenuItem
            // 
            this.mjernaJedinicaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pretragaToolStripMenuItem2,
            this.novaMjernaJedinicaToolStripMenuItem});
            this.mjernaJedinicaToolStripMenuItem.Name = "mjernaJedinicaToolStripMenuItem";
            this.mjernaJedinicaToolStripMenuItem.Size = new System.Drawing.Size(125, 24);
            this.mjernaJedinicaToolStripMenuItem.Text = "Mjerna jedinica";
            // 
            // pretragaToolStripMenuItem2
            // 
            this.pretragaToolStripMenuItem2.Name = "pretragaToolStripMenuItem2";
            this.pretragaToolStripMenuItem2.Size = new System.Drawing.Size(233, 26);
            this.pretragaToolStripMenuItem2.Text = "Pretraga";
            this.pretragaToolStripMenuItem2.Click += new System.EventHandler(this.pretragaToolStripMenuItem2_Click);
            // 
            // novaMjernaJedinicaToolStripMenuItem
            // 
            this.novaMjernaJedinicaToolStripMenuItem.Name = "novaMjernaJedinicaToolStripMenuItem";
            this.novaMjernaJedinicaToolStripMenuItem.Size = new System.Drawing.Size(233, 26);
            this.novaMjernaJedinicaToolStripMenuItem.Text = "Nova mjerna jedinica";
            this.novaMjernaJedinicaToolStripMenuItem.Click += new System.EventHandler(this.novaMjernaJedinicaToolStripMenuItem_Click);
            // 
            // grupaJelaToolStripMenuItem
            // 
            this.grupaJelaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pretragaToolStripMenuItem3,
            this.novaGrupaJelaToolStripMenuItem});
            this.grupaJelaToolStripMenuItem.Name = "grupaJelaToolStripMenuItem";
            this.grupaJelaToolStripMenuItem.Size = new System.Drawing.Size(91, 24);
            this.grupaJelaToolStripMenuItem.Text = "Grupa jela";
            // 
            // pretragaToolStripMenuItem3
            // 
            this.pretragaToolStripMenuItem3.Name = "pretragaToolStripMenuItem3";
            this.pretragaToolStripMenuItem3.Size = new System.Drawing.Size(198, 26);
            this.pretragaToolStripMenuItem3.Text = "Pretraga";
            this.pretragaToolStripMenuItem3.Click += new System.EventHandler(this.pretragaToolStripMenuItem3_Click);
            // 
            // novaGrupaJelaToolStripMenuItem
            // 
            this.novaGrupaJelaToolStripMenuItem.Name = "novaGrupaJelaToolStripMenuItem";
            this.novaGrupaJelaToolStripMenuItem.Size = new System.Drawing.Size(198, 26);
            this.novaGrupaJelaToolStripMenuItem.Text = "Nova grupa jela";
            this.novaGrupaJelaToolStripMenuItem.Click += new System.EventHandler(this.novaGrupaJelaToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(14, 24);
            // 
            // slozenostToolStripMenuItem
            // 
            this.slozenostToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pretragaToolStripMenuItem4,
            this.novaSloženostToolStripMenuItem});
            this.slozenostToolStripMenuItem.Name = "slozenostToolStripMenuItem";
            this.slozenostToolStripMenuItem.Size = new System.Drawing.Size(87, 24);
            this.slozenostToolStripMenuItem.Text = "Složenost";
            // 
            // pretragaToolStripMenuItem4
            // 
            this.pretragaToolStripMenuItem4.Name = "pretragaToolStripMenuItem4";
            this.pretragaToolStripMenuItem4.Size = new System.Drawing.Size(193, 26);
            this.pretragaToolStripMenuItem4.Text = "Pretraga";
            this.pretragaToolStripMenuItem4.Click += new System.EventHandler(this.pretragaToolStripMenuItem4_Click);
            // 
            // novaSloženostToolStripMenuItem
            // 
            this.novaSloženostToolStripMenuItem.Name = "novaSloženostToolStripMenuItem";
            this.novaSloženostToolStripMenuItem.Size = new System.Drawing.Size(193, 26);
            this.novaSloženostToolStripMenuItem.Text = "Nova složenost";
            this.novaSloženostToolStripMenuItem.Click += new System.EventHandler(this.novaSloženostToolStripMenuItem_Click);
            // 
            // mjernaKoličinaToolStripMenuItem
            // 
            this.mjernaKoličinaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pretragaToolStripMenuItem5,
            this.dodajNovuToolStripMenuItem});
            this.mjernaKoličinaToolStripMenuItem.Name = "mjernaKoličinaToolStripMenuItem";
            this.mjernaKoličinaToolStripMenuItem.Size = new System.Drawing.Size(124, 24);
            this.mjernaKoličinaToolStripMenuItem.Text = "Mjerna količina";
            // 
            // pretragaToolStripMenuItem5
            // 
            this.pretragaToolStripMenuItem5.Name = "pretragaToolStripMenuItem5";
            this.pretragaToolStripMenuItem5.Size = new System.Drawing.Size(169, 26);
            this.pretragaToolStripMenuItem5.Text = "Pretraga";
            this.pretragaToolStripMenuItem5.Click += new System.EventHandler(this.pretragaToolStripMenuItem5_Click);
            // 
            // dodajNovuToolStripMenuItem
            // 
            this.dodajNovuToolStripMenuItem.Name = "dodajNovuToolStripMenuItem";
            this.dodajNovuToolStripMenuItem.Size = new System.Drawing.Size(169, 26);
            this.dodajNovuToolStripMenuItem.Text = "Dodaj novu";
            this.dodajNovuToolStripMenuItem.Click += new System.EventHandler(this.dodajNovuToolStripMenuItem_Click);
            // 
            // vrstaČlankaToolStripMenuItem
            // 
            this.vrstaČlankaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pretragaToolStripMenuItem6,
            this.dodajNovuToolStripMenuItem1});
            this.vrstaČlankaToolStripMenuItem.Name = "vrstaČlankaToolStripMenuItem";
            this.vrstaČlankaToolStripMenuItem.Size = new System.Drawing.Size(101, 24);
            this.vrstaČlankaToolStripMenuItem.Text = "Vrsta članka";
            // 
            // pretragaToolStripMenuItem6
            // 
            this.pretragaToolStripMenuItem6.Name = "pretragaToolStripMenuItem6";
            this.pretragaToolStripMenuItem6.Size = new System.Drawing.Size(169, 26);
            this.pretragaToolStripMenuItem6.Text = "Pretraga";
            this.pretragaToolStripMenuItem6.Click += new System.EventHandler(this.pretragaToolStripMenuItem6_Click);
            // 
            // dodajNovuToolStripMenuItem1
            // 
            this.dodajNovuToolStripMenuItem1.Name = "dodajNovuToolStripMenuItem1";
            this.dodajNovuToolStripMenuItem1.Size = new System.Drawing.Size(169, 26);
            this.dodajNovuToolStripMenuItem1.Text = "Dodaj novu";
            this.dodajNovuToolStripMenuItem1.Click += new System.EventHandler(this.dodajNovuToolStripMenuItem1_Click);
            // 
            // clanakToolStripMenuItem
            // 
            this.clanakToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pretragaToolStripMenuItem7,
            this.dodajNoviToolStripMenuItem});
            this.clanakToolStripMenuItem.Name = "clanakToolStripMenuItem";
            this.clanakToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.clanakToolStripMenuItem.Text = "Članak";
            // 
            // pretragaToolStripMenuItem7
            // 
            this.pretragaToolStripMenuItem7.Name = "pretragaToolStripMenuItem7";
            this.pretragaToolStripMenuItem7.Size = new System.Drawing.Size(165, 26);
            this.pretragaToolStripMenuItem7.Text = "Pretraga";
            this.pretragaToolStripMenuItem7.Click += new System.EventHandler(this.pretragaToolStripMenuItem7_Click);
            // 
            // dodajNoviToolStripMenuItem
            // 
            this.dodajNoviToolStripMenuItem.Name = "dodajNoviToolStripMenuItem";
            this.dodajNoviToolStripMenuItem.Size = new System.Drawing.Size(165, 26);
            this.dodajNoviToolStripMenuItem.Text = "Dodaj novi";
            this.dodajNoviToolStripMenuItem.Click += new System.EventHandler(this.dodajNoviToolStripMenuItem_Click);
            // 
            // receptToolStripMenuItem
            // 
            this.receptToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodajNoviToolStripMenuItem1,
            this.dodajSastojakToolStripMenuItem,
            this.pretragaRecepataToolStripMenuItem});
            this.receptToolStripMenuItem.Name = "receptToolStripMenuItem";
            this.receptToolStripMenuItem.Size = new System.Drawing.Size(69, 24);
            this.receptToolStripMenuItem.Text = "Recept";
            // 
            // dodajNoviToolStripMenuItem1
            // 
            this.dodajNoviToolStripMenuItem1.Name = "dodajNoviToolStripMenuItem1";
            this.dodajNoviToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.dodajNoviToolStripMenuItem1.Text = "Dodaj novi";
            this.dodajNoviToolStripMenuItem1.Click += new System.EventHandler(this.dodajNoviToolStripMenuItem1_Click);
            // 
            // dodajSastojakToolStripMenuItem
            // 
            this.dodajSastojakToolStripMenuItem.Name = "dodajSastojakToolStripMenuItem";
            this.dodajSastojakToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.dodajSastojakToolStripMenuItem.Text = "Dodaj sastojak";
            this.dodajSastojakToolStripMenuItem.Click += new System.EventHandler(this.dodajSastojakToolStripMenuItem_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 532);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip.Size = new System.Drawing.Size(1015, 26);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(49, 20);
            this.toolStripStatusLabel.Text = "Status";
            // 
            // pretragaRecepataToolStripMenuItem
            // 
            this.pretragaRecepataToolStripMenuItem.Name = "pretragaRecepataToolStripMenuItem";
            this.pretragaRecepataToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.pretragaRecepataToolStripMenuItem.Text = "Pretraga recepata";
            this.pretragaRecepataToolStripMenuItem.Click += new System.EventHandler(this.pretragaRecepataToolStripMenuItem_Click);
            // 
            // frmIndex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 558);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmIndex";
            this.Text = "frmIndex";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem sastojciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pretragaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kategorijaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pretragaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem novaKategorijaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mjernaJedinicaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pretragaToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem novaMjernaJedinicaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grupaJelaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pretragaToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem novaGrupaJelaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem slozenostToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pretragaToolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem novaSloženostToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mjernaKoličinaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pretragaToolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem dodajNovuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vrstaČlankaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pretragaToolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem dodajNovuToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem clanakToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pretragaToolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem dodajNoviToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem receptToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajNoviToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem dodajSastojakToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pretragaRecepataToolStripMenuItem;
    }
}



