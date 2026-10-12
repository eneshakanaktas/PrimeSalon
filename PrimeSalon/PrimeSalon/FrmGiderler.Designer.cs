
namespace PrimeSalon
{
    partial class FrmGiderler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGiderler));
            this.grpGider = new System.Windows.Forms.GroupBox();
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
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.tabGider = new System.Windows.Forms.TabControl();
            this.tabGenel = new System.Windows.Forms.TabPage();
            this.lblYildizGiderTuru = new System.Windows.Forms.Label();
            this.chkTekrarlayanMi = new System.Windows.Forms.CheckBox();
            this.chkAktif = new System.Windows.Forms.CheckBox();
            this.txtTutar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbGiderTuru = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtTarih = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.tabOdeme = new System.Windows.Forms.TabPage();
            this.lblYildizOdemeTipi = new System.Windows.Forms.Label();
            this.dtKayitTarihi = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.txtKdvTutar = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtFirma = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbOdemeTipi = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabNot = new System.Windows.Forms.TabPage();
            this.rtbAciklama = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dgvGiderler = new System.Windows.Forms.DataGridView();
            this.grpGider.SuspendLayout();
            this.toolStripPersonel.SuspendLayout();
            this.tabGider.SuspendLayout();
            this.tabGenel.SuspendLayout();
            this.tabOdeme.SuspendLayout();
            this.tabNot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGiderler)).BeginInit();
            this.SuspendLayout();
            // 
            // grpGider
            // 
            this.grpGider.Controls.Add(this.toolStripPersonel);
            this.grpGider.Controls.Add(this.tabGider);
            this.grpGider.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpGider.Location = new System.Drawing.Point(0, 0);
            this.grpGider.Name = "grpGider";
            this.grpGider.Size = new System.Drawing.Size(1084, 260);
            this.grpGider.TabIndex = 0;
            this.grpGider.TabStop = false;
            this.grpGider.Text = "Gider Bilgileri";
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
            this.tsbtnTanimlamalar,
            this.toolStripSeparator6});
            this.toolStripPersonel.Location = new System.Drawing.Point(3, 16);
            this.toolStripPersonel.Name = "toolStripPersonel";
            this.toolStripPersonel.Size = new System.Drawing.Size(1078, 36);
            this.toolStripPersonel.TabIndex = 16;
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
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 36);
            // 
            // tabGider
            // 
            this.tabGider.Controls.Add(this.tabGenel);
            this.tabGider.Controls.Add(this.tabOdeme);
            this.tabGider.Controls.Add(this.tabNot);
            this.tabGider.Location = new System.Drawing.Point(20, 60);
            this.tabGider.Name = "tabGider";
            this.tabGider.SelectedIndex = 0;
            this.tabGider.Size = new System.Drawing.Size(1040, 180);
            this.tabGider.TabIndex = 0;
            this.tabGider.TabStop = false;
            // 
            // tabGenel
            // 
            this.tabGenel.Controls.Add(this.lblYildizGiderTuru);
            this.tabGenel.Controls.Add(this.chkTekrarlayanMi);
            this.tabGenel.Controls.Add(this.chkAktif);
            this.tabGenel.Controls.Add(this.txtTutar);
            this.tabGenel.Controls.Add(this.label3);
            this.tabGenel.Controls.Add(this.cmbGiderTuru);
            this.tabGenel.Controls.Add(this.label2);
            this.tabGenel.Controls.Add(this.dtTarih);
            this.tabGenel.Controls.Add(this.label1);
            this.tabGenel.Location = new System.Drawing.Point(4, 22);
            this.tabGenel.Name = "tabGenel";
            this.tabGenel.Padding = new System.Windows.Forms.Padding(3);
            this.tabGenel.Size = new System.Drawing.Size(1032, 154);
            this.tabGenel.TabIndex = 0;
            this.tabGenel.Text = "Genel";
            this.tabGenel.UseVisualStyleBackColor = true;
            // 
            // lblYildizGiderTuru
            // 
            this.lblYildizGiderTuru.AutoSize = true;
            this.lblYildizGiderTuru.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYildizGiderTuru.ForeColor = System.Drawing.Color.Red;
            this.lblYildizGiderTuru.Location = new System.Drawing.Point(326, 65);
            this.lblYildizGiderTuru.Name = "lblYildizGiderTuru";
            this.lblYildizGiderTuru.Size = new System.Drawing.Size(14, 17);
            this.lblYildizGiderTuru.TabIndex = 8;
            this.lblYildizGiderTuru.Text = "*";
            this.lblYildizGiderTuru.Visible = false;
            // 
            // chkTekrarlayanMi
            // 
            this.chkTekrarlayanMi.Location = new System.Drawing.Point(760, 65);
            this.chkTekrarlayanMi.Name = "chkTekrarlayanMi";
            this.chkTekrarlayanMi.Size = new System.Drawing.Size(100, 25);
            this.chkTekrarlayanMi.TabIndex = 5;
            this.chkTekrarlayanMi.Text = "Tekrarlayan";
            this.chkTekrarlayanMi.UseVisualStyleBackColor = true;
            // 
            // chkAktif
            // 
            this.chkAktif.Location = new System.Drawing.Point(760, 25);
            this.chkAktif.Name = "chkAktif";
            this.chkAktif.Size = new System.Drawing.Size(80, 25);
            this.chkAktif.TabIndex = 3;
            this.chkAktif.Text = "Aktif";
            this.chkAktif.UseVisualStyleBackColor = true;
            // 
            // txtTutar
            // 
            this.txtTutar.Location = new System.Drawing.Point(510, 22);
            this.txtTutar.Multiline = true;
            this.txtTutar.Name = "txtTutar";
            this.txtTutar.Size = new System.Drawing.Size(180, 25);
            this.txtTutar.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(420, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tutar";
            // 
            // cmbGiderTuru
            // 
            this.cmbGiderTuru.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGiderTuru.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbGiderTuru.FormattingEnabled = true;
            this.cmbGiderTuru.Items.AddRange(new object[] {
            "Seçiniz",
            "Kira",
            "Elektrik",
            "Su",
            "İnternet",
            "Sarf Malzeme",
            "Personel Maaşı",
            "Temizlik",
            "Vergi",
            "Diğer"});
            this.cmbGiderTuru.Location = new System.Drawing.Point(120, 67);
            this.cmbGiderTuru.Name = "cmbGiderTuru";
            this.cmbGiderTuru.Size = new System.Drawing.Size(200, 25);
            this.cmbGiderTuru.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(30, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Gider Türü";
            // 
            // dtTarih
            // 
            this.dtTarih.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtTarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtTarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtTarih.Location = new System.Drawing.Point(120, 22);
            this.dtTarih.Name = "dtTarih";
            this.dtTarih.Size = new System.Drawing.Size(200, 23);
            this.dtTarih.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(30, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tarih";
            // 
            // tabOdeme
            // 
            this.tabOdeme.Controls.Add(this.lblYildizOdemeTipi);
            this.tabOdeme.Controls.Add(this.dtKayitTarihi);
            this.tabOdeme.Controls.Add(this.label7);
            this.tabOdeme.Controls.Add(this.txtKdvTutar);
            this.tabOdeme.Controls.Add(this.label6);
            this.tabOdeme.Controls.Add(this.txtFirma);
            this.tabOdeme.Controls.Add(this.label5);
            this.tabOdeme.Controls.Add(this.cmbOdemeTipi);
            this.tabOdeme.Controls.Add(this.label4);
            this.tabOdeme.Location = new System.Drawing.Point(4, 22);
            this.tabOdeme.Name = "tabOdeme";
            this.tabOdeme.Padding = new System.Windows.Forms.Padding(3);
            this.tabOdeme.Size = new System.Drawing.Size(1032, 154);
            this.tabOdeme.TabIndex = 1;
            this.tabOdeme.Text = "Ödeme";
            this.tabOdeme.UseVisualStyleBackColor = true;
            // 
            // lblYildizOdemeTipi
            // 
            this.lblYildizOdemeTipi.AutoSize = true;
            this.lblYildizOdemeTipi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYildizOdemeTipi.ForeColor = System.Drawing.Color.Red;
            this.lblYildizOdemeTipi.Location = new System.Drawing.Point(306, 22);
            this.lblYildizOdemeTipi.Name = "lblYildizOdemeTipi";
            this.lblYildizOdemeTipi.Size = new System.Drawing.Size(14, 17);
            this.lblYildizOdemeTipi.TabIndex = 9;
            this.lblYildizOdemeTipi.Text = "*";
            this.lblYildizOdemeTipi.Visible = false;
            // 
            // dtKayitTarihi
            // 
            this.dtKayitTarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtKayitTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtKayitTarihi.Location = new System.Drawing.Point(510, 67);
            this.dtKayitTarihi.Name = "dtKayitTarihi";
            this.dtKayitTarihi.Size = new System.Drawing.Size(180, 23);
            this.dtKayitTarihi.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(420, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Kayıt Tarihi";
            // 
            // txtKdvTutar
            // 
            this.txtKdvTutar.Location = new System.Drawing.Point(510, 22);
            this.txtKdvTutar.Multiline = true;
            this.txtKdvTutar.Name = "txtKdvTutar";
            this.txtKdvTutar.Size = new System.Drawing.Size(180, 25);
            this.txtKdvTutar.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(420, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "KDV Tutar";
            // 
            // txtFirma
            // 
            this.txtFirma.Location = new System.Drawing.Point(120, 67);
            this.txtFirma.Multiline = true;
            this.txtFirma.Name = "txtFirma";
            this.txtFirma.Size = new System.Drawing.Size(220, 25);
            this.txtFirma.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(30, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 23);
            this.label5.TabIndex = 2;
            this.label5.Text = "Firma";
            // 
            // cmbOdemeTipi
            // 
            this.cmbOdemeTipi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOdemeTipi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbOdemeTipi.FormattingEnabled = true;
            this.cmbOdemeTipi.Items.AddRange(new object[] {
            "Seçiniz",
            "Nakit",
            "Kart",
            "Havale"});
            this.cmbOdemeTipi.Location = new System.Drawing.Point(120, 22);
            this.cmbOdemeTipi.Name = "cmbOdemeTipi";
            this.cmbOdemeTipi.Size = new System.Drawing.Size(180, 25);
            this.cmbOdemeTipi.TabIndex = 1;
            this.cmbOdemeTipi.SelectedIndexChanged += new System.EventHandler(this.cmbOdemeTipi_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(30, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 23);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ödeme Tipi";
            // 
            // tabNot
            // 
            this.tabNot.Controls.Add(this.rtbAciklama);
            this.tabNot.Controls.Add(this.label8);
            this.tabNot.Location = new System.Drawing.Point(4, 22);
            this.tabNot.Name = "tabNot";
            this.tabNot.Padding = new System.Windows.Forms.Padding(3);
            this.tabNot.Size = new System.Drawing.Size(1032, 154);
            this.tabNot.TabIndex = 2;
            this.tabNot.Text = "Açıklama";
            this.tabNot.UseVisualStyleBackColor = true;
            // 
            // rtbAciklama
            // 
            this.rtbAciklama.Location = new System.Drawing.Point(120, 25);
            this.rtbAciklama.Name = "rtbAciklama";
            this.rtbAciklama.Size = new System.Drawing.Size(720, 90);
            this.rtbAciklama.TabIndex = 1;
            this.rtbAciklama.Text = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(30, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Açıklama";
            // 
            // dgvGiderler
            // 
            this.dgvGiderler.AllowUserToAddRows = false;
            this.dgvGiderler.AllowUserToDeleteRows = false;
            this.dgvGiderler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGiderler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGiderler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvGiderler.Location = new System.Drawing.Point(0, 260);
            this.dgvGiderler.MultiSelect = false;
            this.dgvGiderler.Name = "dgvGiderler";
            this.dgvGiderler.ReadOnly = true;
            this.dgvGiderler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGiderler.Size = new System.Drawing.Size(1084, 351);
            this.dgvGiderler.TabIndex = 1;
            this.dgvGiderler.TabStop = false;
            // 
            // FrmGiderler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 611);
            this.Controls.Add(this.dgvGiderler);
            this.Controls.Add(this.grpGider);
            this.Name = "FrmGiderler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gider Yönetimi";
            this.Load += new System.EventHandler(this.FrmGiderler_Load);
            this.grpGider.ResumeLayout(false);
            this.toolStripPersonel.ResumeLayout(false);
            this.toolStripPersonel.PerformLayout();
            this.tabGider.ResumeLayout(false);
            this.tabGenel.ResumeLayout(false);
            this.tabGenel.PerformLayout();
            this.tabOdeme.ResumeLayout(false);
            this.tabOdeme.PerformLayout();
            this.tabNot.ResumeLayout(false);
            this.tabNot.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGiderler)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpGider;
        private System.Windows.Forms.TabControl tabGider;
        private System.Windows.Forms.TabPage tabGenel;
        private System.Windows.Forms.ComboBox cmbGiderTuru;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtTarih;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabOdeme;
        private System.Windows.Forms.TabPage tabNot;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView dgvGiderler;
        private System.Windows.Forms.CheckBox chkTekrarlayanMi;
        private System.Windows.Forms.CheckBox chkAktif;
        private System.Windows.Forms.TextBox txtTutar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbOdemeTipi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtKayitTarihi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtKdvTutar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtFirma;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox rtbAciklama;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblYildizGiderTuru;
        private System.Windows.Forms.Label lblYildizOdemeTipi;
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
        private System.Windows.Forms.ToolStripButton tsbtnTanimlamalar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
    }
}