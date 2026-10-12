
namespace PrimeSalon
{
    partial class FrmStokHareketleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmStokHareketleri));
            this.grpStok = new System.Windows.Forms.GroupBox();
            this.TabStok = new System.Windows.Forms.TabControl();
            this.tabGenel = new System.Windows.Forms.TabPage();
            this.lblYildizDepo = new System.Windows.Forms.Label();
            this.lblYildizIslemTipi = new System.Windows.Forms.Label();
            this.cmbDepo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMiktar = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbIslemTipi = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtTarih = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUrunID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabTutar = new System.Windows.Forms.TabPage();
            this.chkAktifMi = new System.Windows.Forms.CheckBox();
            this.txtSonrakiStok = new System.Windows.Forms.TextBox();
            this.txtOncekiStok = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtToplamTutar = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBirimFiyat = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tabEk = new System.Windows.Forms.TabPage();
            this.rtbAciklama = new System.Windows.Forms.RichTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtKullanici = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dgvStokHareketleri = new System.Windows.Forms.DataGridView();
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
            this.grpStok.SuspendLayout();
            this.TabStok.SuspendLayout();
            this.tabGenel.SuspendLayout();
            this.tabTutar.SuspendLayout();
            this.tabEk.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStokHareketleri)).BeginInit();
            this.toolStripPersonel.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpStok
            // 
            this.grpStok.Controls.Add(this.toolStripPersonel);
            this.grpStok.Controls.Add(this.TabStok);
            this.grpStok.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpStok.Location = new System.Drawing.Point(0, 0);
            this.grpStok.Name = "grpStok";
            this.grpStok.Size = new System.Drawing.Size(1134, 280);
            this.grpStok.TabIndex = 0;
            this.grpStok.TabStop = false;
            this.grpStok.Text = "Stok Hareket Bilgileri";
            // 
            // TabStok
            // 
            this.TabStok.Controls.Add(this.tabGenel);
            this.TabStok.Controls.Add(this.tabTutar);
            this.TabStok.Controls.Add(this.tabEk);
            this.TabStok.Location = new System.Drawing.Point(20, 60);
            this.TabStok.Name = "TabStok";
            this.TabStok.SelectedIndex = 0;
            this.TabStok.Size = new System.Drawing.Size(1080, 190);
            this.TabStok.TabIndex = 0;
            this.TabStok.TabStop = false;
            // 
            // tabGenel
            // 
            this.tabGenel.Controls.Add(this.lblYildizDepo);
            this.tabGenel.Controls.Add(this.lblYildizIslemTipi);
            this.tabGenel.Controls.Add(this.cmbDepo);
            this.tabGenel.Controls.Add(this.label5);
            this.tabGenel.Controls.Add(this.txtMiktar);
            this.tabGenel.Controls.Add(this.label4);
            this.tabGenel.Controls.Add(this.cmbIslemTipi);
            this.tabGenel.Controls.Add(this.label3);
            this.tabGenel.Controls.Add(this.dtTarih);
            this.tabGenel.Controls.Add(this.label2);
            this.tabGenel.Controls.Add(this.txtUrunID);
            this.tabGenel.Controls.Add(this.label1);
            this.tabGenel.Location = new System.Drawing.Point(4, 22);
            this.tabGenel.Name = "tabGenel";
            this.tabGenel.Padding = new System.Windows.Forms.Padding(3);
            this.tabGenel.Size = new System.Drawing.Size(1072, 164);
            this.tabGenel.TabIndex = 0;
            this.tabGenel.Text = "Genel";
            this.tabGenel.UseVisualStyleBackColor = true;
            // 
            // lblYildizDepo
            // 
            this.lblYildizDepo.AutoSize = true;
            this.lblYildizDepo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYildizDepo.ForeColor = System.Drawing.Color.Red;
            this.lblYildizDepo.Location = new System.Drawing.Point(1006, 21);
            this.lblYildizDepo.Name = "lblYildizDepo";
            this.lblYildizDepo.Size = new System.Drawing.Size(14, 17);
            this.lblYildizDepo.TabIndex = 10;
            this.lblYildizDepo.Text = "*";
            this.lblYildizDepo.Visible = false;
            // 
            // lblYildizIslemTipi
            // 
            this.lblYildizIslemTipi.AutoSize = true;
            this.lblYildizIslemTipi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYildizIslemTipi.ForeColor = System.Drawing.Color.Red;
            this.lblYildizIslemTipi.Location = new System.Drawing.Point(656, 21);
            this.lblYildizIslemTipi.Name = "lblYildizIslemTipi";
            this.lblYildizIslemTipi.Size = new System.Drawing.Size(14, 17);
            this.lblYildizIslemTipi.TabIndex = 10;
            this.lblYildizIslemTipi.Text = "*";
            this.lblYildizIslemTipi.Visible = false;
            // 
            // cmbDepo
            // 
            this.cmbDepo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDepo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbDepo.FormattingEnabled = true;
            this.cmbDepo.Items.AddRange(new object[] {
            "Seçiniz",
            "Ana Depo",
            "Raf 1",
            "Raf 2",
            "Arka Oda"});
            this.cmbDepo.Location = new System.Drawing.Point(820, 22);
            this.cmbDepo.Name = "cmbDepo";
            this.cmbDepo.Size = new System.Drawing.Size(180, 25);
            this.cmbDepo.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(730, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Depo";
            // 
            // txtMiktar
            // 
            this.txtMiktar.Location = new System.Drawing.Point(470, 67);
            this.txtMiktar.Multiline = true;
            this.txtMiktar.Name = "txtMiktar";
            this.txtMiktar.Size = new System.Drawing.Size(180, 25);
            this.txtMiktar.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(380, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Miktar";
            // 
            // cmbIslemTipi
            // 
            this.cmbIslemTipi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIslemTipi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbIslemTipi.FormattingEnabled = true;
            this.cmbIslemTipi.Items.AddRange(new object[] {
            "Seçiniz",
            "Giriş",
            "Çıkış",
            "Düzeltme"});
            this.cmbIslemTipi.Location = new System.Drawing.Point(470, 22);
            this.cmbIslemTipi.Name = "cmbIslemTipi";
            this.cmbIslemTipi.Size = new System.Drawing.Size(180, 25);
            this.cmbIslemTipi.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(380, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "İşlem Tipi";
            // 
            // dtTarih
            // 
            this.dtTarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtTarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtTarih.Location = new System.Drawing.Point(120, 67);
            this.dtTarih.Name = "dtTarih";
            this.dtTarih.Size = new System.Drawing.Size(180, 23);
            this.dtTarih.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tarih";
            // 
            // txtUrunID
            // 
            this.txtUrunID.Location = new System.Drawing.Point(120, 22);
            this.txtUrunID.Multiline = true;
            this.txtUrunID.Name = "txtUrunID";
            this.txtUrunID.Size = new System.Drawing.Size(180, 25);
            this.txtUrunID.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ürün ID";
            // 
            // tabTutar
            // 
            this.tabTutar.Controls.Add(this.chkAktifMi);
            this.tabTutar.Controls.Add(this.txtSonrakiStok);
            this.tabTutar.Controls.Add(this.txtOncekiStok);
            this.tabTutar.Controls.Add(this.label9);
            this.tabTutar.Controls.Add(this.label8);
            this.tabTutar.Controls.Add(this.txtToplamTutar);
            this.tabTutar.Controls.Add(this.label7);
            this.tabTutar.Controls.Add(this.txtBirimFiyat);
            this.tabTutar.Controls.Add(this.label6);
            this.tabTutar.Location = new System.Drawing.Point(4, 22);
            this.tabTutar.Name = "tabTutar";
            this.tabTutar.Padding = new System.Windows.Forms.Padding(3);
            this.tabTutar.Size = new System.Drawing.Size(1072, 164);
            this.tabTutar.TabIndex = 1;
            this.tabTutar.Text = "Tutar / Stok";
            this.tabTutar.UseVisualStyleBackColor = true;
            // 
            // chkAktifMi
            // 
            this.chkAktifMi.Location = new System.Drawing.Point(730, 25);
            this.chkAktifMi.Name = "chkAktifMi";
            this.chkAktifMi.Size = new System.Drawing.Size(80, 25);
            this.chkAktifMi.TabIndex = 3;
            this.chkAktifMi.Text = "Aktif";
            this.chkAktifMi.UseVisualStyleBackColor = true;
            // 
            // txtSonrakiStok
            // 
            this.txtSonrakiStok.Location = new System.Drawing.Point(470, 67);
            this.txtSonrakiStok.Multiline = true;
            this.txtSonrakiStok.Name = "txtSonrakiStok";
            this.txtSonrakiStok.Size = new System.Drawing.Size(180, 25);
            this.txtSonrakiStok.TabIndex = 5;
            // 
            // txtOncekiStok
            // 
            this.txtOncekiStok.Location = new System.Drawing.Point(470, 22);
            this.txtOncekiStok.Multiline = true;
            this.txtOncekiStok.Name = "txtOncekiStok";
            this.txtOncekiStok.Size = new System.Drawing.Size(180, 25);
            this.txtOncekiStok.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(380, 70);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "Sonraki Stok";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(380, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Önceki Stok";
            // 
            // txtToplamTutar
            // 
            this.txtToplamTutar.Location = new System.Drawing.Point(120, 67);
            this.txtToplamTutar.Multiline = true;
            this.txtToplamTutar.Name = "txtToplamTutar";
            this.txtToplamTutar.Size = new System.Drawing.Size(180, 25);
            this.txtToplamTutar.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Toplam Tutar";
            // 
            // txtBirimFiyat
            // 
            this.txtBirimFiyat.Location = new System.Drawing.Point(120, 22);
            this.txtBirimFiyat.Multiline = true;
            this.txtBirimFiyat.Name = "txtBirimFiyat";
            this.txtBirimFiyat.Size = new System.Drawing.Size(180, 25);
            this.txtBirimFiyat.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Birim Fiyat";
            // 
            // tabEk
            // 
            this.tabEk.Controls.Add(this.rtbAciklama);
            this.tabEk.Controls.Add(this.label11);
            this.tabEk.Controls.Add(this.txtKullanici);
            this.tabEk.Controls.Add(this.label10);
            this.tabEk.Location = new System.Drawing.Point(4, 22);
            this.tabEk.Name = "tabEk";
            this.tabEk.Padding = new System.Windows.Forms.Padding(3);
            this.tabEk.Size = new System.Drawing.Size(1072, 164);
            this.tabEk.TabIndex = 2;
            this.tabEk.Text = "Açıklama / Ek";
            this.tabEk.UseVisualStyleBackColor = true;
            // 
            // rtbAciklama
            // 
            this.rtbAciklama.Location = new System.Drawing.Point(120, 70);
            this.rtbAciklama.Name = "rtbAciklama";
            this.rtbAciklama.Size = new System.Drawing.Size(700, 80);
            this.rtbAciklama.TabIndex = 2;
            this.rtbAciklama.Text = "";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(30, 70);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "Açıklama";
            // 
            // txtKullanici
            // 
            this.txtKullanici.Location = new System.Drawing.Point(120, 22);
            this.txtKullanici.Multiline = true;
            this.txtKullanici.Name = "txtKullanici";
            this.txtKullanici.Size = new System.Drawing.Size(220, 25);
            this.txtKullanici.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(30, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Kullanıcı";
            // 
            // dgvStokHareketleri
            // 
            this.dgvStokHareketleri.AllowUserToAddRows = false;
            this.dgvStokHareketleri.AllowUserToDeleteRows = false;
            this.dgvStokHareketleri.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStokHareketleri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStokHareketleri.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStokHareketleri.Location = new System.Drawing.Point(0, 280);
            this.dgvStokHareketleri.MultiSelect = false;
            this.dgvStokHareketleri.Name = "dgvStokHareketleri";
            this.dgvStokHareketleri.ReadOnly = true;
            this.dgvStokHareketleri.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStokHareketleri.Size = new System.Drawing.Size(1134, 361);
            this.dgvStokHareketleri.TabIndex = 1;
            this.dgvStokHareketleri.TabStop = false;
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
            this.toolStripSeparator5});
            this.toolStripPersonel.Location = new System.Drawing.Point(3, 16);
            this.toolStripPersonel.Name = "toolStripPersonel";
            this.toolStripPersonel.Size = new System.Drawing.Size(1128, 36);
            this.toolStripPersonel.TabIndex = 18;
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
            // FrmStokHareketleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 641);
            this.Controls.Add(this.dgvStokHareketleri);
            this.Controls.Add(this.grpStok);
            this.Name = "FrmStokHareketleri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stok Hareketleri";
            this.Load += new System.EventHandler(this.FrmStokHareketleri_Load);
            this.grpStok.ResumeLayout(false);
            this.TabStok.ResumeLayout(false);
            this.tabGenel.ResumeLayout(false);
            this.tabGenel.PerformLayout();
            this.tabTutar.ResumeLayout(false);
            this.tabTutar.PerformLayout();
            this.tabEk.ResumeLayout(false);
            this.tabEk.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStokHareketleri)).EndInit();
            this.toolStripPersonel.ResumeLayout(false);
            this.toolStripPersonel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpStok;
        private System.Windows.Forms.TabControl TabStok;
        private System.Windows.Forms.TabPage tabGenel;
        private System.Windows.Forms.ComboBox cmbIslemTipi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtTarih;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUrunID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabTutar;
        private System.Windows.Forms.TabPage tabEk;
        private System.Windows.Forms.DataGridView dgvStokHareketleri;
        private System.Windows.Forms.ComboBox cmbDepo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMiktar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkAktifMi;
        private System.Windows.Forms.TextBox txtSonrakiStok;
        private System.Windows.Forms.TextBox txtOncekiStok;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtToplamTutar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBirimFiyat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtKullanici;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RichTextBox rtbAciklama;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblYildizDepo;
        private System.Windows.Forms.Label lblYildizIslemTipi;
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
    }
}