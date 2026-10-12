
namespace PrimeSalon
{
    partial class FrmUrunler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUrunler));
            this.grpUrun = new System.Windows.Forms.GroupBox();
            this.toolStripPersonel = new System.Windows.Forms.ToolStrip();
            this.tsbEkle = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbGuncelle = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbSil = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbListele = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbSorgulama = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnTanimlamalar = new System.Windows.Forms.ToolStripButton();
            this.tabUrun = new System.Windows.Forms.TabControl();
            this.tabGenel = new System.Windows.Forms.TabPage();
            this.lblYildizBirim = new System.Windows.Forms.Label();
            this.lblYildizKategori = new System.Windows.Forms.Label();
            this.chkAktif = new System.Windows.Forms.CheckBox();
            this.cmbBirim = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbKategori = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMarka = new System.Windows.Forms.TextBox();
            this.txtUrunAdi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabFiyat = new System.Windows.Forms.TabPage();
            this.dtEklenmeTarihi = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.chkStokTakip = new System.Windows.Forms.CheckBox();
            this.txtMinimumStok = new System.Windows.Forms.TextBox();
            this.txtSatisFiyat = new System.Windows.Forms.TextBox();
            this.txtAlisFiyat = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tabAciklama = new System.Windows.Forms.TabPage();
            this.rtbAciklama = new System.Windows.Forms.RichTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dgvUrunler = new System.Windows.Forms.DataGridView();
            this.grpUrun.SuspendLayout();
            this.toolStripPersonel.SuspendLayout();
            this.tabUrun.SuspendLayout();
            this.tabGenel.SuspendLayout();
            this.tabFiyat.SuspendLayout();
            this.tabAciklama.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUrunler)).BeginInit();
            this.SuspendLayout();
            // 
            // grpUrun
            // 
            this.grpUrun.Controls.Add(this.toolStripPersonel);
            this.grpUrun.Controls.Add(this.tabUrun);
            this.grpUrun.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpUrun.Location = new System.Drawing.Point(0, 0);
            this.grpUrun.Name = "grpUrun";
            this.grpUrun.Size = new System.Drawing.Size(1084, 260);
            this.grpUrun.TabIndex = 0;
            this.grpUrun.TabStop = false;
            this.grpUrun.Text = "Ürün Bilgileri";
            // 
            // toolStripPersonel
            // 
            this.toolStripPersonel.AutoSize = false;
            this.toolStripPersonel.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbEkle,
            this.toolStripSeparator1,
            this.tsbGuncelle,
            this.toolStripSeparator2,
            this.tsbSil,
            this.toolStripSeparator3,
            this.tsbListele,
            this.toolStripSeparator4,
            this.tsbSorgulama,
            this.toolStripSeparator5,
            this.tsbtnTanimlamalar});
            this.toolStripPersonel.Location = new System.Drawing.Point(3, 16);
            this.toolStripPersonel.Name = "toolStripPersonel";
            this.toolStripPersonel.Size = new System.Drawing.Size(1078, 36);
            this.toolStripPersonel.TabIndex = 17;
            this.toolStripPersonel.Text = "toolStrip1";
            // 
            // tsbEkle
            // 
            this.tsbEkle.AutoSize = false;
            this.tsbEkle.Image = ((System.Drawing.Image)(resources.GetObject("tsbEkle.Image")));
            this.tsbEkle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEkle.Name = "tsbEkle";
            this.tsbEkle.Size = new System.Drawing.Size(100, 25);
            this.tsbEkle.Text = "Ekle";
            this.tsbEkle.Click += new System.EventHandler(this.tsbEkle_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 36);
            // 
            // tsbGuncelle
            // 
            this.tsbGuncelle.AutoSize = false;
            this.tsbGuncelle.Image = ((System.Drawing.Image)(resources.GetObject("tsbGuncelle.Image")));
            this.tsbGuncelle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbGuncelle.Name = "tsbGuncelle";
            this.tsbGuncelle.Size = new System.Drawing.Size(110, 25);
            this.tsbGuncelle.Text = "Güncelle";
            this.tsbGuncelle.Click += new System.EventHandler(this.tsbGuncelle_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 36);
            // 
            // tsbSil
            // 
            this.tsbSil.AutoSize = false;
            this.tsbSil.Image = ((System.Drawing.Image)(resources.GetObject("tsbSil.Image")));
            this.tsbSil.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSil.Name = "tsbSil";
            this.tsbSil.Size = new System.Drawing.Size(90, 25);
            this.tsbSil.Text = "Sil";
            this.tsbSil.Click += new System.EventHandler(this.tsbSil_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 36);
            // 
            // tsbListele
            // 
            this.tsbListele.AutoSize = false;
            this.tsbListele.Image = ((System.Drawing.Image)(resources.GetObject("tsbListele.Image")));
            this.tsbListele.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbListele.Name = "tsbListele";
            this.tsbListele.Size = new System.Drawing.Size(80, 25);
            this.tsbListele.Text = "Listele";
            this.tsbListele.Click += new System.EventHandler(this.tsbListele_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 36);
            // 
            // tsbSorgulama
            // 
            this.tsbSorgulama.AutoSize = false;
            this.tsbSorgulama.Image = ((System.Drawing.Image)(resources.GetObject("tsbSorgulama.Image")));
            this.tsbSorgulama.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSorgulama.Name = "tsbSorgulama";
            this.tsbSorgulama.Size = new System.Drawing.Size(110, 25);
            this.tsbSorgulama.Text = "Sorgulama";
            this.tsbSorgulama.Click += new System.EventHandler(this.tsbSorgulama_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 36);
            // 
            // tsbtnTanimlamalar
            // 
            this.tsbtnTanimlamalar.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnTanimlamalar.Image")));
            this.tsbtnTanimlamalar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnTanimlamalar.Name = "tsbtnTanimlamalar";
            this.tsbtnTanimlamalar.Size = new System.Drawing.Size(98, 33);
            this.tsbtnTanimlamalar.Text = "Tanımlamalar";
            this.tsbtnTanimlamalar.Click += new System.EventHandler(this.tsbtnTanimlamalar_Click);
            // 
            // tabUrun
            // 
            this.tabUrun.Controls.Add(this.tabGenel);
            this.tabUrun.Controls.Add(this.tabFiyat);
            this.tabUrun.Controls.Add(this.tabAciklama);
            this.tabUrun.Location = new System.Drawing.Point(20, 60);
            this.tabUrun.Name = "tabUrun";
            this.tabUrun.SelectedIndex = 0;
            this.tabUrun.Size = new System.Drawing.Size(1040, 180);
            this.tabUrun.TabIndex = 0;
            this.tabUrun.TabStop = false;
            // 
            // tabGenel
            // 
            this.tabGenel.Controls.Add(this.lblYildizBirim);
            this.tabGenel.Controls.Add(this.lblYildizKategori);
            this.tabGenel.Controls.Add(this.chkAktif);
            this.tabGenel.Controls.Add(this.cmbBirim);
            this.tabGenel.Controls.Add(this.label5);
            this.tabGenel.Controls.Add(this.cmbKategori);
            this.tabGenel.Controls.Add(this.label3);
            this.tabGenel.Controls.Add(this.txtMarka);
            this.tabGenel.Controls.Add(this.txtUrunAdi);
            this.tabGenel.Controls.Add(this.label2);
            this.tabGenel.Controls.Add(this.label1);
            this.tabGenel.Location = new System.Drawing.Point(4, 22);
            this.tabGenel.Name = "tabGenel";
            this.tabGenel.Padding = new System.Windows.Forms.Padding(3);
            this.tabGenel.Size = new System.Drawing.Size(1032, 154);
            this.tabGenel.TabIndex = 0;
            this.tabGenel.Text = "Genel";
            this.tabGenel.UseVisualStyleBackColor = true;
            // 
            // lblYildizBirim
            // 
            this.lblYildizBirim.AutoSize = true;
            this.lblYildizBirim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYildizBirim.ForeColor = System.Drawing.Color.Red;
            this.lblYildizBirim.Location = new System.Drawing.Point(676, 66);
            this.lblYildizBirim.Name = "lblYildizBirim";
            this.lblYildizBirim.Size = new System.Drawing.Size(14, 17);
            this.lblYildizBirim.TabIndex = 9;
            this.lblYildizBirim.Text = "*";
            this.lblYildizBirim.Visible = false;
            // 
            // lblYildizKategori
            // 
            this.lblYildizKategori.AutoSize = true;
            this.lblYildizKategori.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYildizKategori.ForeColor = System.Drawing.Color.Red;
            this.lblYildizKategori.Location = new System.Drawing.Point(676, 22);
            this.lblYildizKategori.Name = "lblYildizKategori";
            this.lblYildizKategori.Size = new System.Drawing.Size(14, 17);
            this.lblYildizKategori.TabIndex = 9;
            this.lblYildizKategori.Text = "*";
            this.lblYildizKategori.Visible = false;
            // 
            // chkAktif
            // 
            this.chkAktif.Location = new System.Drawing.Point(740, 25);
            this.chkAktif.Name = "chkAktif";
            this.chkAktif.Size = new System.Drawing.Size(80, 25);
            this.chkAktif.TabIndex = 3;
            this.chkAktif.Text = "Aktif";
            this.chkAktif.UseVisualStyleBackColor = true;
            // 
            // cmbBirim
            // 
            this.cmbBirim.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBirim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbBirim.FormattingEnabled = true;
            this.cmbBirim.Items.AddRange(new object[] {
            "Seçiniz",
            "Adet",
            "ml",
            "gr",
            "Paket"});
            this.cmbBirim.Location = new System.Drawing.Point(490, 67);
            this.cmbBirim.Name = "cmbBirim";
            this.cmbBirim.Size = new System.Drawing.Size(180, 25);
            this.cmbBirim.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(400, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Birim";
            // 
            // cmbKategori
            // 
            this.cmbKategori.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKategori.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbKategori.FormattingEnabled = true;
            this.cmbKategori.Items.AddRange(new object[] {
            "Seçiniz",
            "Şampuan",
            "Jöle",
            "Wax",
            "Köpük",
            "Kolonya",
            "Bakım Ürünü",
            "Diğer"});
            this.cmbKategori.Location = new System.Drawing.Point(490, 22);
            this.cmbKategori.Name = "cmbKategori";
            this.cmbKategori.Size = new System.Drawing.Size(180, 25);
            this.cmbKategori.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(400, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Kategori";
            // 
            // txtMarka
            // 
            this.txtMarka.Location = new System.Drawing.Point(120, 67);
            this.txtMarka.Multiline = true;
            this.txtMarka.Name = "txtMarka";
            this.txtMarka.Size = new System.Drawing.Size(220, 25);
            this.txtMarka.TabIndex = 4;
            // 
            // txtUrunAdi
            // 
            this.txtUrunAdi.Location = new System.Drawing.Point(120, 22);
            this.txtUrunAdi.Multiline = true;
            this.txtUrunAdi.Name = "txtUrunAdi";
            this.txtUrunAdi.Size = new System.Drawing.Size(220, 25);
            this.txtUrunAdi.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Marka";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ürün Adı";
            // 
            // tabFiyat
            // 
            this.tabFiyat.Controls.Add(this.dtEklenmeTarihi);
            this.tabFiyat.Controls.Add(this.label9);
            this.tabFiyat.Controls.Add(this.chkStokTakip);
            this.tabFiyat.Controls.Add(this.txtMinimumStok);
            this.tabFiyat.Controls.Add(this.txtSatisFiyat);
            this.tabFiyat.Controls.Add(this.txtAlisFiyat);
            this.tabFiyat.Controls.Add(this.label8);
            this.tabFiyat.Controls.Add(this.label7);
            this.tabFiyat.Controls.Add(this.label6);
            this.tabFiyat.Location = new System.Drawing.Point(4, 22);
            this.tabFiyat.Name = "tabFiyat";
            this.tabFiyat.Padding = new System.Windows.Forms.Padding(3);
            this.tabFiyat.Size = new System.Drawing.Size(1032, 154);
            this.tabFiyat.TabIndex = 1;
            this.tabFiyat.Text = "Fiyat / Stok";
            this.tabFiyat.UseVisualStyleBackColor = true;
            // 
            // dtEklenmeTarihi
            // 
            this.dtEklenmeTarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtEklenmeTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtEklenmeTarihi.Location = new System.Drawing.Point(820, 22);
            this.dtEklenmeTarihi.Name = "dtEklenmeTarihi";
            this.dtEklenmeTarihi.Size = new System.Drawing.Size(160, 23);
            this.dtEklenmeTarihi.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(720, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "Eklenme Tarihi";
            // 
            // chkStokTakip
            // 
            this.chkStokTakip.Location = new System.Drawing.Point(403, 70);
            this.chkStokTakip.Name = "chkStokTakip";
            this.chkStokTakip.Size = new System.Drawing.Size(100, 25);
            this.chkStokTakip.TabIndex = 5;
            this.chkStokTakip.Text = "Stok Takip";
            this.chkStokTakip.UseVisualStyleBackColor = true;
            // 
            // txtMinimumStok
            // 
            this.txtMinimumStok.Location = new System.Drawing.Point(490, 22);
            this.txtMinimumStok.Multiline = true;
            this.txtMinimumStok.Name = "txtMinimumStok";
            this.txtMinimumStok.Size = new System.Drawing.Size(180, 25);
            this.txtMinimumStok.TabIndex = 2;
            // 
            // txtSatisFiyat
            // 
            this.txtSatisFiyat.Location = new System.Drawing.Point(120, 67);
            this.txtSatisFiyat.Multiline = true;
            this.txtSatisFiyat.Name = "txtSatisFiyat";
            this.txtSatisFiyat.Size = new System.Drawing.Size(180, 25);
            this.txtSatisFiyat.TabIndex = 4;
            // 
            // txtAlisFiyat
            // 
            this.txtAlisFiyat.Location = new System.Drawing.Point(120, 22);
            this.txtAlisFiyat.Multiline = true;
            this.txtAlisFiyat.Name = "txtAlisFiyat";
            this.txtAlisFiyat.Size = new System.Drawing.Size(180, 25);
            this.txtAlisFiyat.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(400, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Minimum Stok";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Satış Fiyat";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Alış Fiyat";
            // 
            // tabAciklama
            // 
            this.tabAciklama.Controls.Add(this.rtbAciklama);
            this.tabAciklama.Controls.Add(this.label10);
            this.tabAciklama.Location = new System.Drawing.Point(4, 22);
            this.tabAciklama.Name = "tabAciklama";
            this.tabAciklama.Padding = new System.Windows.Forms.Padding(3);
            this.tabAciklama.Size = new System.Drawing.Size(1032, 154);
            this.tabAciklama.TabIndex = 2;
            this.tabAciklama.Text = "Açıklama";
            this.tabAciklama.UseVisualStyleBackColor = true;
            // 
            // rtbAciklama
            // 
            this.rtbAciklama.Location = new System.Drawing.Point(120, 25);
            this.rtbAciklama.Name = "rtbAciklama";
            this.rtbAciklama.Size = new System.Drawing.Size(720, 90);
            this.rtbAciklama.TabIndex = 1;
            this.rtbAciklama.Text = "";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(30, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Açıklama";
            // 
            // dgvUrunler
            // 
            this.dgvUrunler.AllowUserToAddRows = false;
            this.dgvUrunler.AllowUserToDeleteRows = false;
            this.dgvUrunler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUrunler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUrunler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUrunler.Location = new System.Drawing.Point(0, 260);
            this.dgvUrunler.MultiSelect = false;
            this.dgvUrunler.Name = "dgvUrunler";
            this.dgvUrunler.ReadOnly = true;
            this.dgvUrunler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUrunler.Size = new System.Drawing.Size(1084, 351);
            this.dgvUrunler.TabIndex = 1;
            this.dgvUrunler.TabStop = false;
            // 
            // FrmUrunler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 611);
            this.Controls.Add(this.dgvUrunler);
            this.Controls.Add(this.grpUrun);
            this.Name = "FrmUrunler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ürün Yönetimi";
            this.Load += new System.EventHandler(this.FrmUrunler_Load);
            this.grpUrun.ResumeLayout(false);
            this.toolStripPersonel.ResumeLayout(false);
            this.toolStripPersonel.PerformLayout();
            this.tabUrun.ResumeLayout(false);
            this.tabGenel.ResumeLayout(false);
            this.tabGenel.PerformLayout();
            this.tabFiyat.ResumeLayout(false);
            this.tabFiyat.PerformLayout();
            this.tabAciklama.ResumeLayout(false);
            this.tabAciklama.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUrunler)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpUrun;
        private System.Windows.Forms.DataGridView dgvUrunler;
        private System.Windows.Forms.ToolStrip toolStripPersonel;
        private System.Windows.Forms.ToolStripButton tsbEkle;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbGuncelle;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsbSil;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tsbListele;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton tsbSorgulama;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.TabControl tabUrun;
        private System.Windows.Forms.TabPage tabGenel;
        private System.Windows.Forms.Label lblYildizBirim;
        private System.Windows.Forms.Label lblYildizKategori;
        private System.Windows.Forms.CheckBox chkAktif;
        private System.Windows.Forms.ComboBox cmbBirim;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbKategori;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMarka;
        private System.Windows.Forms.TextBox txtUrunAdi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabFiyat;
        private System.Windows.Forms.DateTimePicker dtEklenmeTarihi;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox chkStokTakip;
        private System.Windows.Forms.TextBox txtMinimumStok;
        private System.Windows.Forms.TextBox txtSatisFiyat;
        private System.Windows.Forms.TextBox txtAlisFiyat;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabPage tabAciklama;
        private System.Windows.Forms.RichTextBox rtbAciklama;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ToolStripButton tsbtnTanimlamalar;
    }
}