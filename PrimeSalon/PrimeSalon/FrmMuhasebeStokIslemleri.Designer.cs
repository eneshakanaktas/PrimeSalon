namespace PrimeSalon
{
    partial class FrmMuhasebeStokIslemleri
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.grpUst = new System.Windows.Forms.GroupBox();
            this.pnlOzet = new System.Windows.Forms.Panel();
            this.lblSonGuncelleme = new System.Windows.Forms.Label();
            this.lblStokHareket = new System.Windows.Forms.Label();
            this.lblOdeme = new System.Windows.Forms.Label();
            this.lblTahsilat = new System.Windows.Forms.Label();
            this.lblKasaBakiye = new System.Windows.Forms.Label();
            this.toolStripIslemler = new System.Windows.Forms.ToolStrip();
            this.tsbYenile = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbKasaHareketleri = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbStokHareketleri = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbGiderler = new System.Windows.Forms.ToolStripButton();
            this.tabHareketler = new System.Windows.Forms.TabControl();
            this.tabTumHareketler = new System.Windows.Forms.TabPage();
            this.dgvTumHareketler = new System.Windows.Forms.DataGridView();
            this.tabKasa = new System.Windows.Forms.TabPage();
            this.dgvKasaHareketleri = new System.Windows.Forms.DataGridView();
            this.tabStok = new System.Windows.Forms.TabPage();
            this.dgvStokHareketleri = new System.Windows.Forms.DataGridView();
            this.tabFinansalKaynaklar = new System.Windows.Forms.TabPage();
            this.dgvFinansalKaynaklar = new System.Windows.Forms.DataGridView();
            this.grpUst.SuspendLayout();
            this.pnlOzet.SuspendLayout();
            this.toolStripIslemler.SuspendLayout();
            this.tabHareketler.SuspendLayout();
            this.tabTumHareketler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTumHareketler)).BeginInit();
            this.tabKasa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKasaHareketleri)).BeginInit();
            this.tabStok.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStokHareketleri)).BeginInit();
            this.tabFinansalKaynaklar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFinansalKaynaklar)).BeginInit();
            this.SuspendLayout();
            // 
            // grpUst
            // 
            this.grpUst.Controls.Add(this.pnlOzet);
            this.grpUst.Controls.Add(this.toolStripIslemler);
            this.grpUst.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpUst.Location = new System.Drawing.Point(0, 0);
            this.grpUst.Name = "grpUst";
            this.grpUst.Size = new System.Drawing.Size(1134, 135);
            this.grpUst.TabIndex = 0;
            this.grpUst.TabStop = false;
            this.grpUst.Text = "Muhasebe ve Stok Hareket Bilgileri";
            // 
            // pnlOzet
            // 
            this.pnlOzet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlOzet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlOzet.Controls.Add(this.lblSonGuncelleme);
            this.pnlOzet.Controls.Add(this.lblStokHareket);
            this.pnlOzet.Controls.Add(this.lblOdeme);
            this.pnlOzet.Controls.Add(this.lblTahsilat);
            this.pnlOzet.Controls.Add(this.lblKasaBakiye);
            this.pnlOzet.Location = new System.Drawing.Point(20, 62);
            this.pnlOzet.Name = "pnlOzet";
            this.pnlOzet.Size = new System.Drawing.Size(1094, 64);
            this.pnlOzet.TabIndex = 1;
            // 
            // lblSonGuncelleme
            // 
            this.lblSonGuncelleme.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSonGuncelleme.Location = new System.Drawing.Point(870, 12);
            this.lblSonGuncelleme.Name = "lblSonGuncelleme";
            this.lblSonGuncelleme.Size = new System.Drawing.Size(200, 38);
            this.lblSonGuncelleme.TabIndex = 4;
            this.lblSonGuncelleme.Text = "Son Guncelleme: -";
            this.lblSonGuncelleme.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStokHareket
            // 
            this.lblStokHareket.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblStokHareket.Location = new System.Drawing.Point(655, 12);
            this.lblStokHareket.Name = "lblStokHareket";
            this.lblStokHareket.Size = new System.Drawing.Size(190, 38);
            this.lblStokHareket.TabIndex = 3;
            this.lblStokHareket.Text = "Stok Hareket: 0";
            this.lblStokHareket.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOdeme
            // 
            this.lblOdeme.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOdeme.Location = new System.Drawing.Point(440, 12);
            this.lblOdeme.Name = "lblOdeme";
            this.lblOdeme.Size = new System.Drawing.Size(190, 38);
            this.lblOdeme.TabIndex = 2;
            this.lblOdeme.Text = "Odeme: 0,00";
            this.lblOdeme.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTahsilat
            // 
            this.lblTahsilat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTahsilat.Location = new System.Drawing.Point(225, 12);
            this.lblTahsilat.Name = "lblTahsilat";
            this.lblTahsilat.Size = new System.Drawing.Size(190, 38);
            this.lblTahsilat.TabIndex = 1;
            this.lblTahsilat.Text = "Tahsilat: 0,00";
            this.lblTahsilat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblKasaBakiye
            // 
            this.lblKasaBakiye.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblKasaBakiye.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKasaBakiye.Location = new System.Drawing.Point(10, 12);
            this.lblKasaBakiye.Name = "lblKasaBakiye";
            this.lblKasaBakiye.Size = new System.Drawing.Size(190, 38);
            this.lblKasaBakiye.TabIndex = 0;
            this.lblKasaBakiye.Text = "Kasa Bakiye: 0,00";
            this.lblKasaBakiye.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // toolStripIslemler
            // 
            this.toolStripIslemler.AutoSize = false;
            this.toolStripIslemler.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbYenile,
            this.toolStripSeparator1,
            this.tsbKasaHareketleri,
            this.toolStripSeparator2,
            this.tsbStokHareketleri,
            this.toolStripSeparator3,
            this.tsbGiderler});
            this.toolStripIslemler.Location = new System.Drawing.Point(3, 16);
            this.toolStripIslemler.Name = "toolStripIslemler";
            this.toolStripIslemler.Size = new System.Drawing.Size(1128, 36);
            this.toolStripIslemler.TabIndex = 0;
            this.toolStripIslemler.Text = "toolStrip1";
            // 
            // tsbYenile
            // 
            this.tsbYenile.AutoSize = false;
            this.tsbYenile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbYenile.Name = "tsbYenile";
            this.tsbYenile.Size = new System.Drawing.Size(90, 25);
            this.tsbYenile.Text = "Yenile";
            this.tsbYenile.Click += new System.EventHandler(this.tsbYenile_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 36);
            // 
            // tsbKasaHareketleri
            // 
            this.tsbKasaHareketleri.AutoSize = false;
            this.tsbKasaHareketleri.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbKasaHareketleri.Name = "tsbKasaHareketleri";
            this.tsbKasaHareketleri.Size = new System.Drawing.Size(140, 25);
            this.tsbKasaHareketleri.Text = "Kasa Hareketleri";
            this.tsbKasaHareketleri.Click += new System.EventHandler(this.tsbKasaHareketleri_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 36);
            // 
            // tsbStokHareketleri
            // 
            this.tsbStokHareketleri.AutoSize = false;
            this.tsbStokHareketleri.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbStokHareketleri.Name = "tsbStokHareketleri";
            this.tsbStokHareketleri.Size = new System.Drawing.Size(140, 25);
            this.tsbStokHareketleri.Text = "Stok Hareketleri";
            this.tsbStokHareketleri.Click += new System.EventHandler(this.tsbStokHareketleri_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 36);
            // 
            // tsbGiderler
            // 
            this.tsbGiderler.AutoSize = false;
            this.tsbGiderler.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbGiderler.Name = "tsbGiderler";
            this.tsbGiderler.Size = new System.Drawing.Size(100, 25);
            this.tsbGiderler.Text = "Giderler";
            this.tsbGiderler.Click += new System.EventHandler(this.tsbGiderler_Click);
            // 
            // tabHareketler
            // 
            this.tabHareketler.Controls.Add(this.tabTumHareketler);
            this.tabHareketler.Controls.Add(this.tabKasa);
            this.tabHareketler.Controls.Add(this.tabStok);
            this.tabHareketler.Controls.Add(this.tabFinansalKaynaklar);
            this.tabHareketler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabHareketler.Location = new System.Drawing.Point(0, 135);
            this.tabHareketler.Name = "tabHareketler";
            this.tabHareketler.SelectedIndex = 0;
            this.tabHareketler.Size = new System.Drawing.Size(1134, 516);
            this.tabHareketler.TabIndex = 1;
            // 
            // tabTumHareketler
            // 
            this.tabTumHareketler.Controls.Add(this.dgvTumHareketler);
            this.tabTumHareketler.Location = new System.Drawing.Point(4, 22);
            this.tabTumHareketler.Name = "tabTumHareketler";
            this.tabTumHareketler.Padding = new System.Windows.Forms.Padding(3);
            this.tabTumHareketler.Size = new System.Drawing.Size(1126, 490);
            this.tabTumHareketler.TabIndex = 0;
            this.tabTumHareketler.Text = "Tum Hareketler";
            this.tabTumHareketler.UseVisualStyleBackColor = true;
            // 
            // dgvTumHareketler
            // 
            this.dgvTumHareketler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTumHareketler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTumHareketler.Location = new System.Drawing.Point(3, 3);
            this.dgvTumHareketler.Name = "dgvTumHareketler";
            this.dgvTumHareketler.Size = new System.Drawing.Size(1120, 484);
            this.dgvTumHareketler.TabIndex = 0;
            // 
            // tabKasa
            // 
            this.tabKasa.Controls.Add(this.dgvKasaHareketleri);
            this.tabKasa.Location = new System.Drawing.Point(4, 22);
            this.tabKasa.Name = "tabKasa";
            this.tabKasa.Padding = new System.Windows.Forms.Padding(3);
            this.tabKasa.Size = new System.Drawing.Size(1126, 490);
            this.tabKasa.TabIndex = 1;
            this.tabKasa.Text = "Kasa Hareketleri";
            this.tabKasa.UseVisualStyleBackColor = true;
            // 
            // dgvKasaHareketleri
            // 
            this.dgvKasaHareketleri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKasaHareketleri.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvKasaHareketleri.Location = new System.Drawing.Point(3, 3);
            this.dgvKasaHareketleri.Name = "dgvKasaHareketleri";
            this.dgvKasaHareketleri.Size = new System.Drawing.Size(1120, 484);
            this.dgvKasaHareketleri.TabIndex = 0;
            // 
            // tabStok
            // 
            this.tabStok.Controls.Add(this.dgvStokHareketleri);
            this.tabStok.Location = new System.Drawing.Point(4, 22);
            this.tabStok.Name = "tabStok";
            this.tabStok.Padding = new System.Windows.Forms.Padding(3);
            this.tabStok.Size = new System.Drawing.Size(1126, 490);
            this.tabStok.TabIndex = 2;
            this.tabStok.Text = "Stok Hareketleri";
            this.tabStok.UseVisualStyleBackColor = true;
            // 
            // dgvStokHareketleri
            // 
            this.dgvStokHareketleri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStokHareketleri.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStokHareketleri.Location = new System.Drawing.Point(3, 3);
            this.dgvStokHareketleri.Name = "dgvStokHareketleri";
            this.dgvStokHareketleri.Size = new System.Drawing.Size(1120, 484);
            this.dgvStokHareketleri.TabIndex = 0;
            // 
            // tabFinansalKaynaklar
            // 
            this.tabFinansalKaynaklar.Controls.Add(this.dgvFinansalKaynaklar);
            this.tabFinansalKaynaklar.Location = new System.Drawing.Point(4, 22);
            this.tabFinansalKaynaklar.Name = "tabFinansalKaynaklar";
            this.tabFinansalKaynaklar.Padding = new System.Windows.Forms.Padding(3);
            this.tabFinansalKaynaklar.Size = new System.Drawing.Size(1126, 490);
            this.tabFinansalKaynaklar.TabIndex = 3;
            this.tabFinansalKaynaklar.Text = "Finansal Kaynaklar";
            this.tabFinansalKaynaklar.UseVisualStyleBackColor = true;
            // 
            // dgvFinansalKaynaklar
            // 
            this.dgvFinansalKaynaklar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFinansalKaynaklar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvFinansalKaynaklar.Location = new System.Drawing.Point(3, 3);
            this.dgvFinansalKaynaklar.Name = "dgvFinansalKaynaklar";
            this.dgvFinansalKaynaklar.Size = new System.Drawing.Size(1120, 484);
            this.dgvFinansalKaynaklar.TabIndex = 0;
            // 
            // FrmMuhasebeStokIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1134, 651);
            this.Controls.Add(this.tabHareketler);
            this.Controls.Add(this.grpUst);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmMuhasebeStokIslemleri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Muhasebe ve Stok İşlemleri";
            this.Activated += new System.EventHandler(this.FrmMuhasebeStokIslemleri_Activated);
            this.Load += new System.EventHandler(this.FrmMuhasebeStokIslemleri_Load);
            this.grpUst.ResumeLayout(false);
            this.pnlOzet.ResumeLayout(false);
            this.toolStripIslemler.ResumeLayout(false);
            this.toolStripIslemler.PerformLayout();
            this.tabHareketler.ResumeLayout(false);
            this.tabTumHareketler.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTumHareketler)).EndInit();
            this.tabKasa.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKasaHareketleri)).EndInit();
            this.tabStok.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStokHareketleri)).EndInit();
            this.tabFinansalKaynaklar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFinansalKaynaklar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpUst;
        private System.Windows.Forms.Panel pnlOzet;
        private System.Windows.Forms.Label lblSonGuncelleme;
        private System.Windows.Forms.Label lblStokHareket;
        private System.Windows.Forms.Label lblOdeme;
        private System.Windows.Forms.Label lblTahsilat;
        private System.Windows.Forms.Label lblKasaBakiye;
        private System.Windows.Forms.ToolStrip toolStripIslemler;
        private System.Windows.Forms.ToolStripButton tsbYenile;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbKasaHareketleri;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsbStokHareketleri;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tsbGiderler;
        private System.Windows.Forms.TabControl tabHareketler;
        private System.Windows.Forms.TabPage tabTumHareketler;
        private System.Windows.Forms.DataGridView dgvTumHareketler;
        private System.Windows.Forms.TabPage tabKasa;
        private System.Windows.Forms.DataGridView dgvKasaHareketleri;
        private System.Windows.Forms.TabPage tabStok;
        private System.Windows.Forms.DataGridView dgvStokHareketleri;
        private System.Windows.Forms.TabPage tabFinansalKaynaklar;
        private System.Windows.Forms.DataGridView dgvFinansalKaynaklar;
    }
}
