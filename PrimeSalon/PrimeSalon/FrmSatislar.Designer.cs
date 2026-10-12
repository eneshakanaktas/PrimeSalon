
namespace PrimeSalon
{
    partial class FrmSatislar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSatislar));
            this.grpSatis = new System.Windows.Forms.GroupBox();
            this.tabSatis = new System.Windows.Forms.TabControl();
            this.tabGenel = new System.Windows.Forms.TabPage();
            this.lblYildizSatisTipi = new System.Windows.Forms.Label();
            this.cmbSatisTipi = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtPersonelID = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtMusteriID = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.dtTarih = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.tabTutar = new System.Windows.Forms.TabPage();
            this.lblYildizOdemeDurumu = new System.Windows.Forms.Label();
            this.lblYildizOdemeTipi = new System.Windows.Forms.Label();
            this.cmbOdemeDurumu = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbOdemeTipi = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtGenelToplam = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtKdvTutar = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtIndirimTutar = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAraToplam = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tabEk = new System.Windows.Forms.TabPage();
            this.rtbIadeNedeni = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chkIadeMi = new System.Windows.Forms.CheckBox();
            this.rtbAciklama = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvSatislar = new System.Windows.Forms.DataGridView();
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
            this.grpSatis.SuspendLayout();
            this.tabSatis.SuspendLayout();
            this.tabGenel.SuspendLayout();
            this.tabTutar.SuspendLayout();
            this.tabEk.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSatislar)).BeginInit();
            this.toolStripPersonel.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpSatis
            // 
            this.grpSatis.Controls.Add(this.toolStripPersonel);
            this.grpSatis.Controls.Add(this.tabSatis);
            this.grpSatis.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpSatis.Location = new System.Drawing.Point(0, 0);
            this.grpSatis.Name = "grpSatis";
            this.grpSatis.Size = new System.Drawing.Size(1134, 280);
            this.grpSatis.TabIndex = 0;
            this.grpSatis.TabStop = false;
            this.grpSatis.Text = "Satış Bilgileri";
            // 
            // tabSatis
            // 
            this.tabSatis.Controls.Add(this.tabGenel);
            this.tabSatis.Controls.Add(this.tabTutar);
            this.tabSatis.Controls.Add(this.tabEk);
            this.tabSatis.Location = new System.Drawing.Point(20, 60);
            this.tabSatis.Name = "tabSatis";
            this.tabSatis.SelectedIndex = 0;
            this.tabSatis.Size = new System.Drawing.Size(1080, 190);
            this.tabSatis.TabIndex = 0;
            this.tabSatis.TabStop = false;
            // 
            // tabGenel
            // 
            this.tabGenel.Controls.Add(this.lblYildizSatisTipi);
            this.tabGenel.Controls.Add(this.cmbSatisTipi);
            this.tabGenel.Controls.Add(this.label11);
            this.tabGenel.Controls.Add(this.txtPersonelID);
            this.tabGenel.Controls.Add(this.label12);
            this.tabGenel.Controls.Add(this.txtMusteriID);
            this.tabGenel.Controls.Add(this.label13);
            this.tabGenel.Controls.Add(this.dtTarih);
            this.tabGenel.Controls.Add(this.label14);
            this.tabGenel.Location = new System.Drawing.Point(4, 22);
            this.tabGenel.Name = "tabGenel";
            this.tabGenel.Padding = new System.Windows.Forms.Padding(3);
            this.tabGenel.Size = new System.Drawing.Size(1072, 164);
            this.tabGenel.TabIndex = 0;
            this.tabGenel.Text = "Genel";
            this.tabGenel.UseVisualStyleBackColor = true;
            // 
            // lblYildizSatisTipi
            // 
            this.lblYildizSatisTipi.AutoSize = true;
            this.lblYildizSatisTipi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYildizSatisTipi.ForeColor = System.Drawing.Color.Red;
            this.lblYildizSatisTipi.Location = new System.Drawing.Point(656, 66);
            this.lblYildizSatisTipi.Name = "lblYildizSatisTipi";
            this.lblYildizSatisTipi.Size = new System.Drawing.Size(14, 17);
            this.lblYildizSatisTipi.TabIndex = 16;
            this.lblYildizSatisTipi.Text = "*";
            this.lblYildizSatisTipi.Visible = false;
            // 
            // cmbSatisTipi
            // 
            this.cmbSatisTipi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSatisTipi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbSatisTipi.FormattingEnabled = true;
            this.cmbSatisTipi.Items.AddRange(new object[] {
            "Seçiniz",
            "Hizmet",
            "Ürün",
            "Karma"});
            this.cmbSatisTipi.Location = new System.Drawing.Point(470, 67);
            this.cmbSatisTipi.Name = "cmbSatisTipi";
            this.cmbSatisTipi.Size = new System.Drawing.Size(180, 25);
            this.cmbSatisTipi.TabIndex = 4;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(380, 70);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 13);
            this.label11.TabIndex = 14;
            this.label11.Text = "Satış Tipi";
            // 
            // txtPersonelID
            // 
            this.txtPersonelID.Location = new System.Drawing.Point(470, 22);
            this.txtPersonelID.Multiline = true;
            this.txtPersonelID.Name = "txtPersonelID";
            this.txtPersonelID.Size = new System.Drawing.Size(180, 25);
            this.txtPersonelID.TabIndex = 2;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(380, 25);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 13);
            this.label12.TabIndex = 12;
            this.label12.Text = "Personel ID";
            // 
            // txtMusteriID
            // 
            this.txtMusteriID.Location = new System.Drawing.Point(120, 67);
            this.txtMusteriID.Multiline = true;
            this.txtMusteriID.Name = "txtMusteriID";
            this.txtMusteriID.Size = new System.Drawing.Size(180, 25);
            this.txtMusteriID.TabIndex = 3;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(30, 70);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(55, 13);
            this.label13.TabIndex = 10;
            this.label13.Text = "Müşteri ID";
            // 
            // dtTarih
            // 
            this.dtTarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtTarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtTarih.Location = new System.Drawing.Point(120, 22);
            this.dtTarih.Name = "dtTarih";
            this.dtTarih.Size = new System.Drawing.Size(180, 23);
            this.dtTarih.TabIndex = 1;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(30, 25);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(31, 13);
            this.label14.TabIndex = 8;
            this.label14.Text = "Tarih";
            // 
            // tabTutar
            // 
            this.tabTutar.Controls.Add(this.lblYildizOdemeDurumu);
            this.tabTutar.Controls.Add(this.lblYildizOdemeTipi);
            this.tabTutar.Controls.Add(this.cmbOdemeDurumu);
            this.tabTutar.Controls.Add(this.label10);
            this.tabTutar.Controls.Add(this.cmbOdemeTipi);
            this.tabTutar.Controls.Add(this.label9);
            this.tabTutar.Controls.Add(this.txtGenelToplam);
            this.tabTutar.Controls.Add(this.label8);
            this.tabTutar.Controls.Add(this.txtKdvTutar);
            this.tabTutar.Controls.Add(this.label7);
            this.tabTutar.Controls.Add(this.txtIndirimTutar);
            this.tabTutar.Controls.Add(this.label6);
            this.tabTutar.Controls.Add(this.txtAraToplam);
            this.tabTutar.Controls.Add(this.label5);
            this.tabTutar.Location = new System.Drawing.Point(4, 22);
            this.tabTutar.Name = "tabTutar";
            this.tabTutar.Padding = new System.Windows.Forms.Padding(3);
            this.tabTutar.Size = new System.Drawing.Size(1072, 164);
            this.tabTutar.TabIndex = 1;
            this.tabTutar.Text = "Tutar / Ödeme";
            this.tabTutar.UseVisualStyleBackColor = true;
            // 
            // lblYildizOdemeDurumu
            // 
            this.lblYildizOdemeDurumu.AutoSize = true;
            this.lblYildizOdemeDurumu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYildizOdemeDurumu.ForeColor = System.Drawing.Color.Red;
            this.lblYildizOdemeDurumu.Location = new System.Drawing.Point(1006, 66);
            this.lblYildizOdemeDurumu.Name = "lblYildizOdemeDurumu";
            this.lblYildizOdemeDurumu.Size = new System.Drawing.Size(14, 17);
            this.lblYildizOdemeDurumu.TabIndex = 17;
            this.lblYildizOdemeDurumu.Text = "*";
            this.lblYildizOdemeDurumu.Visible = false;
            // 
            // lblYildizOdemeTipi
            // 
            this.lblYildizOdemeTipi.AutoSize = true;
            this.lblYildizOdemeTipi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYildizOdemeTipi.ForeColor = System.Drawing.Color.Red;
            this.lblYildizOdemeTipi.Location = new System.Drawing.Point(1006, 21);
            this.lblYildizOdemeTipi.Name = "lblYildizOdemeTipi";
            this.lblYildizOdemeTipi.Size = new System.Drawing.Size(14, 17);
            this.lblYildizOdemeTipi.TabIndex = 17;
            this.lblYildizOdemeTipi.Text = "*";
            this.lblYildizOdemeTipi.Visible = false;
            // 
            // cmbOdemeDurumu
            // 
            this.cmbOdemeDurumu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOdemeDurumu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbOdemeDurumu.FormattingEnabled = true;
            this.cmbOdemeDurumu.Items.AddRange(new object[] {
            "Seçiniz",
            "Ödendi",
            "Bekliyor",
            "Kısmi"});
            this.cmbOdemeDurumu.Location = new System.Drawing.Point(820, 67);
            this.cmbOdemeDurumu.Name = "cmbOdemeDurumu";
            this.cmbOdemeDurumu.Size = new System.Drawing.Size(180, 25);
            this.cmbOdemeDurumu.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(730, 70);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "Ödeme Durumu";
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
            this.cmbOdemeTipi.Location = new System.Drawing.Point(820, 22);
            this.cmbOdemeTipi.Name = "cmbOdemeTipi";
            this.cmbOdemeTipi.Size = new System.Drawing.Size(180, 25);
            this.cmbOdemeTipi.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(730, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Ödeme Tipi";
            // 
            // txtGenelToplam
            // 
            this.txtGenelToplam.Location = new System.Drawing.Point(470, 67);
            this.txtGenelToplam.Multiline = true;
            this.txtGenelToplam.Name = "txtGenelToplam";
            this.txtGenelToplam.Size = new System.Drawing.Size(180, 25);
            this.txtGenelToplam.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(380, 70);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Genel Toplam";
            // 
            // txtKdvTutar
            // 
            this.txtKdvTutar.Location = new System.Drawing.Point(470, 22);
            this.txtKdvTutar.Multiline = true;
            this.txtKdvTutar.Name = "txtKdvTutar";
            this.txtKdvTutar.Size = new System.Drawing.Size(180, 25);
            this.txtKdvTutar.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(380, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "KDV";
            // 
            // txtIndirimTutar
            // 
            this.txtIndirimTutar.Location = new System.Drawing.Point(120, 67);
            this.txtIndirimTutar.Multiline = true;
            this.txtIndirimTutar.Name = "txtIndirimTutar";
            this.txtIndirimTutar.Size = new System.Drawing.Size(180, 25);
            this.txtIndirimTutar.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "İndirim";
            // 
            // txtAraToplam
            // 
            this.txtAraToplam.Location = new System.Drawing.Point(120, 22);
            this.txtAraToplam.Multiline = true;
            this.txtAraToplam.Name = "txtAraToplam";
            this.txtAraToplam.Size = new System.Drawing.Size(180, 25);
            this.txtAraToplam.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Ara Toplam";
            // 
            // tabEk
            // 
            this.tabEk.Controls.Add(this.rtbIadeNedeni);
            this.tabEk.Controls.Add(this.label2);
            this.tabEk.Controls.Add(this.chkIadeMi);
            this.tabEk.Controls.Add(this.rtbAciklama);
            this.tabEk.Controls.Add(this.label1);
            this.tabEk.Location = new System.Drawing.Point(4, 22);
            this.tabEk.Name = "tabEk";
            this.tabEk.Padding = new System.Windows.Forms.Padding(3);
            this.tabEk.Size = new System.Drawing.Size(1072, 164);
            this.tabEk.TabIndex = 2;
            this.tabEk.Text = "Açıklama / İade";
            this.tabEk.UseVisualStyleBackColor = true;
            // 
            // rtbIadeNedeni
            // 
            this.rtbIadeNedeni.Location = new System.Drawing.Point(740, 60);
            this.rtbIadeNedeni.Name = "rtbIadeNedeni";
            this.rtbIadeNedeni.Size = new System.Drawing.Size(260, 60);
            this.rtbIadeNedeni.TabIndex = 3;
            this.rtbIadeNedeni.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(650, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "İade Nedeni";
            // 
            // chkIadeMi
            // 
            this.chkIadeMi.Location = new System.Drawing.Point(650, 25);
            this.chkIadeMi.Name = "chkIadeMi";
            this.chkIadeMi.Size = new System.Drawing.Size(100, 25);
            this.chkIadeMi.TabIndex = 2;
            this.chkIadeMi.Text = "İade Var";
            this.chkIadeMi.UseVisualStyleBackColor = true;
            // 
            // rtbAciklama
            // 
            this.rtbAciklama.Location = new System.Drawing.Point(120, 22);
            this.rtbAciklama.Name = "rtbAciklama";
            this.rtbAciklama.Size = new System.Drawing.Size(450, 80);
            this.rtbAciklama.TabIndex = 1;
            this.rtbAciklama.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Açıklama";
            // 
            // dgvSatislar
            // 
            this.dgvSatislar.AllowUserToAddRows = false;
            this.dgvSatislar.AllowUserToDeleteRows = false;
            this.dgvSatislar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSatislar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSatislar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSatislar.Location = new System.Drawing.Point(0, 280);
            this.dgvSatislar.MultiSelect = false;
            this.dgvSatislar.Name = "dgvSatislar";
            this.dgvSatislar.ReadOnly = true;
            this.dgvSatislar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSatislar.Size = new System.Drawing.Size(1134, 361);
            this.dgvSatislar.TabIndex = 1;
            this.dgvSatislar.TabStop = false;
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
            this.toolStripPersonel.TabIndex = 19;
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
            // FrmSatislar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 641);
            this.Controls.Add(this.dgvSatislar);
            this.Controls.Add(this.grpSatis);
            this.Name = "FrmSatislar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Satış Yönetimi";
            this.Load += new System.EventHandler(this.FrmSatislar_Load);
            this.grpSatis.ResumeLayout(false);
            this.tabSatis.ResumeLayout(false);
            this.tabGenel.ResumeLayout(false);
            this.tabGenel.PerformLayout();
            this.tabTutar.ResumeLayout(false);
            this.tabTutar.PerformLayout();
            this.tabEk.ResumeLayout(false);
            this.tabEk.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSatislar)).EndInit();
            this.toolStripPersonel.ResumeLayout(false);
            this.toolStripPersonel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpSatis;
        private System.Windows.Forms.DataGridView dgvSatislar;
        private System.Windows.Forms.TabControl tabSatis;
        private System.Windows.Forms.TabPage tabGenel;
        private System.Windows.Forms.TabPage tabTutar;
        private System.Windows.Forms.TabPage tabEk;
        private System.Windows.Forms.ComboBox cmbOdemeTipi;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtGenelToplam;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtKdvTutar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtIndirimTutar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAraToplam;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbOdemeDurumu;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbSatisTipi;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtPersonelID;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtMusteriID;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker dtTarih;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.RichTextBox rtbIadeNedeni;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkIadeMi;
        private System.Windows.Forms.RichTextBox rtbAciklama;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblYildizSatisTipi;
        private System.Windows.Forms.Label lblYildizOdemeDurumu;
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
    }
}