
namespace PrimeSalon
{
    partial class FrmKasaHareketleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmKasaHareketleri));
            this.grpKasa = new System.Windows.Forms.GroupBox();
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
            this.tabKasa = new System.Windows.Forms.TabControl();
            this.tabGenel = new System.Windows.Forms.TabPage();
            this.lblYildizOdemeTipi = new System.Windows.Forms.Label();
            this.lblYildizIslemKategorisi = new System.Windows.Forms.Label();
            this.lblYildizIslemTipi = new System.Windows.Forms.Label();
            this.cmbOdemeTipi = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTutar = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbIslemKategorisi = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbIslemTipi = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtTarih = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.tabBaglanti = new System.Windows.Forms.TabPage();
            this.txtIslemiYapan = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtKasaAdi = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPersonelID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTedarikciID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMusteriID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tabBakiye = new System.Windows.Forms.TabPage();
            this.rtbAciklama = new System.Windows.Forms.RichTextBox();
            this.txtBakiyeSonra = new System.Windows.Forms.TextBox();
            this.txtBakiyeOnce = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dgvKasaHareketleri = new System.Windows.Forms.DataGridView();
            this.grpKasa.SuspendLayout();
            this.toolStripPersonel.SuspendLayout();
            this.tabKasa.SuspendLayout();
            this.tabGenel.SuspendLayout();
            this.tabBaglanti.SuspendLayout();
            this.tabBakiye.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKasaHareketleri)).BeginInit();
            this.SuspendLayout();
            // 
            // grpKasa
            // 
            this.grpKasa.Controls.Add(this.toolStripPersonel);
            this.grpKasa.Controls.Add(this.tabKasa);
            this.grpKasa.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpKasa.Location = new System.Drawing.Point(0, 0);
            this.grpKasa.Name = "grpKasa";
            this.grpKasa.Size = new System.Drawing.Size(1134, 280);
            this.grpKasa.TabIndex = 0;
            this.grpKasa.TabStop = false;
            this.grpKasa.Text = "Kasa Hareket Bilgileri";
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
            this.toolStripPersonel.TabIndex = 20;
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
            // tabKasa
            // 
            this.tabKasa.Controls.Add(this.tabGenel);
            this.tabKasa.Controls.Add(this.tabBaglanti);
            this.tabKasa.Controls.Add(this.tabBakiye);
            this.tabKasa.Location = new System.Drawing.Point(20, 60);
            this.tabKasa.Name = "tabKasa";
            this.tabKasa.SelectedIndex = 0;
            this.tabKasa.Size = new System.Drawing.Size(1080, 190);
            this.tabKasa.TabIndex = 0;
            this.tabKasa.TabStop = false;
            // 
            // tabGenel
            // 
            this.tabGenel.Controls.Add(this.lblYildizOdemeTipi);
            this.tabGenel.Controls.Add(this.lblYildizIslemKategorisi);
            this.tabGenel.Controls.Add(this.lblYildizIslemTipi);
            this.tabGenel.Controls.Add(this.cmbOdemeTipi);
            this.tabGenel.Controls.Add(this.label5);
            this.tabGenel.Controls.Add(this.txtTutar);
            this.tabGenel.Controls.Add(this.label4);
            this.tabGenel.Controls.Add(this.cmbIslemKategorisi);
            this.tabGenel.Controls.Add(this.label3);
            this.tabGenel.Controls.Add(this.cmbIslemTipi);
            this.tabGenel.Controls.Add(this.label2);
            this.tabGenel.Controls.Add(this.dtTarih);
            this.tabGenel.Controls.Add(this.label1);
            this.tabGenel.Location = new System.Drawing.Point(4, 22);
            this.tabGenel.Name = "tabGenel";
            this.tabGenel.Padding = new System.Windows.Forms.Padding(3);
            this.tabGenel.Size = new System.Drawing.Size(1072, 164);
            this.tabGenel.TabIndex = 0;
            this.tabGenel.Text = "Genel";
            this.tabGenel.UseVisualStyleBackColor = true;
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
            // lblYildizIslemKategorisi
            // 
            this.lblYildizIslemKategorisi.AutoSize = true;
            this.lblYildizIslemKategorisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYildizIslemKategorisi.ForeColor = System.Drawing.Color.Red;
            this.lblYildizIslemKategorisi.Location = new System.Drawing.Point(656, 22);
            this.lblYildizIslemKategorisi.Name = "lblYildizIslemKategorisi";
            this.lblYildizIslemKategorisi.Size = new System.Drawing.Size(14, 17);
            this.lblYildizIslemKategorisi.TabIndex = 17;
            this.lblYildizIslemKategorisi.Text = "*";
            this.lblYildizIslemKategorisi.Visible = false;
            // 
            // lblYildizIslemTipi
            // 
            this.lblYildizIslemTipi.AutoSize = true;
            this.lblYildizIslemTipi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYildizIslemTipi.ForeColor = System.Drawing.Color.Red;
            this.lblYildizIslemTipi.Location = new System.Drawing.Point(306, 66);
            this.lblYildizIslemTipi.Name = "lblYildizIslemTipi";
            this.lblYildizIslemTipi.Size = new System.Drawing.Size(14, 17);
            this.lblYildizIslemTipi.TabIndex = 17;
            this.lblYildizIslemTipi.Text = "*";
            this.lblYildizIslemTipi.Visible = false;
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(730, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Ödeme Tipi";
            // 
            // txtTutar
            // 
            this.txtTutar.Location = new System.Drawing.Point(470, 67);
            this.txtTutar.Multiline = true;
            this.txtTutar.Name = "txtTutar";
            this.txtTutar.Size = new System.Drawing.Size(180, 25);
            this.txtTutar.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(380, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tutar";
            // 
            // cmbIslemKategorisi
            // 
            this.cmbIslemKategorisi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIslemKategorisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbIslemKategorisi.FormattingEnabled = true;
            this.cmbIslemKategorisi.Items.AddRange(new object[] {
            "Seçiniz",
            "Satış",
            "Gider",
            "Maaş",
            "Diğer"});
            this.cmbIslemKategorisi.Location = new System.Drawing.Point(470, 22);
            this.cmbIslemKategorisi.Name = "cmbIslemKategorisi";
            this.cmbIslemKategorisi.Size = new System.Drawing.Size(180, 25);
            this.cmbIslemKategorisi.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(380, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "İşlem Kategorisi";
            // 
            // cmbIslemTipi
            // 
            this.cmbIslemTipi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIslemTipi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbIslemTipi.FormattingEnabled = true;
            this.cmbIslemTipi.Items.AddRange(new object[] {
            "Seçiniz",
            "Tahsilat",
            "Ödeme"});
            this.cmbIslemTipi.Location = new System.Drawing.Point(120, 67);
            this.cmbIslemTipi.Name = "cmbIslemTipi";
            this.cmbIslemTipi.Size = new System.Drawing.Size(180, 25);
            this.cmbIslemTipi.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "İşlem Tipi";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tarih";
            // 
            // tabBaglanti
            // 
            this.tabBaglanti.Controls.Add(this.txtIslemiYapan);
            this.tabBaglanti.Controls.Add(this.label10);
            this.tabBaglanti.Controls.Add(this.txtKasaAdi);
            this.tabBaglanti.Controls.Add(this.label9);
            this.tabBaglanti.Controls.Add(this.txtPersonelID);
            this.tabBaglanti.Controls.Add(this.label8);
            this.tabBaglanti.Controls.Add(this.txtTedarikciID);
            this.tabBaglanti.Controls.Add(this.label7);
            this.tabBaglanti.Controls.Add(this.txtMusteriID);
            this.tabBaglanti.Controls.Add(this.label6);
            this.tabBaglanti.Location = new System.Drawing.Point(4, 22);
            this.tabBaglanti.Name = "tabBaglanti";
            this.tabBaglanti.Padding = new System.Windows.Forms.Padding(3);
            this.tabBaglanti.Size = new System.Drawing.Size(1072, 164);
            this.tabBaglanti.TabIndex = 1;
            this.tabBaglanti.Text = "Bağlantılar";
            this.tabBaglanti.UseVisualStyleBackColor = true;
            // 
            // txtIslemiYapan
            // 
            this.txtIslemiYapan.Location = new System.Drawing.Point(820, 22);
            this.txtIslemiYapan.Multiline = true;
            this.txtIslemiYapan.Name = "txtIslemiYapan";
            this.txtIslemiYapan.Size = new System.Drawing.Size(180, 25);
            this.txtIslemiYapan.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(730, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "İşlemi Yapan";
            // 
            // txtKasaAdi
            // 
            this.txtKasaAdi.Location = new System.Drawing.Point(470, 67);
            this.txtKasaAdi.Multiline = true;
            this.txtKasaAdi.Name = "txtKasaAdi";
            this.txtKasaAdi.Size = new System.Drawing.Size(180, 25);
            this.txtKasaAdi.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(380, 70);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "Kasa Adı";
            // 
            // txtPersonelID
            // 
            this.txtPersonelID.Location = new System.Drawing.Point(470, 22);
            this.txtPersonelID.Multiline = true;
            this.txtPersonelID.Name = "txtPersonelID";
            this.txtPersonelID.Size = new System.Drawing.Size(180, 25);
            this.txtPersonelID.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(380, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Personel ID";
            // 
            // txtTedarikciID
            // 
            this.txtTedarikciID.Location = new System.Drawing.Point(120, 67);
            this.txtTedarikciID.Multiline = true;
            this.txtTedarikciID.Name = "txtTedarikciID";
            this.txtTedarikciID.Size = new System.Drawing.Size(180, 25);
            this.txtTedarikciID.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Tedarikçi ID";
            // 
            // txtMusteriID
            // 
            this.txtMusteriID.Location = new System.Drawing.Point(120, 22);
            this.txtMusteriID.Multiline = true;
            this.txtMusteriID.Name = "txtMusteriID";
            this.txtMusteriID.Size = new System.Drawing.Size(180, 25);
            this.txtMusteriID.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Müşteri ID";
            // 
            // tabBakiye
            // 
            this.tabBakiye.Controls.Add(this.rtbAciklama);
            this.tabBakiye.Controls.Add(this.txtBakiyeSonra);
            this.tabBakiye.Controls.Add(this.txtBakiyeOnce);
            this.tabBakiye.Controls.Add(this.label13);
            this.tabBakiye.Controls.Add(this.label12);
            this.tabBakiye.Controls.Add(this.label11);
            this.tabBakiye.Location = new System.Drawing.Point(4, 22);
            this.tabBakiye.Name = "tabBakiye";
            this.tabBakiye.Padding = new System.Windows.Forms.Padding(3);
            this.tabBakiye.Size = new System.Drawing.Size(1072, 164);
            this.tabBakiye.TabIndex = 2;
            this.tabBakiye.Text = "Bakiye / Açıklama";
            this.tabBakiye.UseVisualStyleBackColor = true;
            // 
            // rtbAciklama
            // 
            this.rtbAciklama.Location = new System.Drawing.Point(120, 70);
            this.rtbAciklama.Name = "rtbAciklama";
            this.rtbAciklama.Size = new System.Drawing.Size(700, 80);
            this.rtbAciklama.TabIndex = 3;
            this.rtbAciklama.Text = "";
            // 
            // txtBakiyeSonra
            // 
            this.txtBakiyeSonra.Location = new System.Drawing.Point(470, 22);
            this.txtBakiyeSonra.Multiline = true;
            this.txtBakiyeSonra.Name = "txtBakiyeSonra";
            this.txtBakiyeSonra.Size = new System.Drawing.Size(180, 25);
            this.txtBakiyeSonra.TabIndex = 2;
            // 
            // txtBakiyeOnce
            // 
            this.txtBakiyeOnce.Location = new System.Drawing.Point(120, 22);
            this.txtBakiyeOnce.Multiline = true;
            this.txtBakiyeOnce.Name = "txtBakiyeOnce";
            this.txtBakiyeOnce.Size = new System.Drawing.Size(180, 25);
            this.txtBakiyeOnce.TabIndex = 1;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(30, 70);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(50, 13);
            this.label13.TabIndex = 0;
            this.label13.Text = "Açıklama";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(380, 25);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(70, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "Bakiye Sonra";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(30, 25);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Bakiye Önce";
            // 
            // dgvKasaHareketleri
            // 
            this.dgvKasaHareketleri.AllowUserToAddRows = false;
            this.dgvKasaHareketleri.AllowUserToDeleteRows = false;
            this.dgvKasaHareketleri.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKasaHareketleri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKasaHareketleri.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvKasaHareketleri.Location = new System.Drawing.Point(0, 280);
            this.dgvKasaHareketleri.MultiSelect = false;
            this.dgvKasaHareketleri.Name = "dgvKasaHareketleri";
            this.dgvKasaHareketleri.ReadOnly = true;
            this.dgvKasaHareketleri.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKasaHareketleri.Size = new System.Drawing.Size(1134, 361);
            this.dgvKasaHareketleri.TabIndex = 0;
            this.dgvKasaHareketleri.TabStop = false;
            // 
            // FrmKasaHareketleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 641);
            this.Controls.Add(this.dgvKasaHareketleri);
            this.Controls.Add(this.grpKasa);
            this.Name = "FrmKasaHareketleri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kasa Hareketleri";
            this.Load += new System.EventHandler(this.FrmKasaHareketleri_Load);
            this.grpKasa.ResumeLayout(false);
            this.toolStripPersonel.ResumeLayout(false);
            this.toolStripPersonel.PerformLayout();
            this.tabKasa.ResumeLayout(false);
            this.tabGenel.ResumeLayout(false);
            this.tabGenel.PerformLayout();
            this.tabBaglanti.ResumeLayout(false);
            this.tabBaglanti.PerformLayout();
            this.tabBakiye.ResumeLayout(false);
            this.tabBakiye.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKasaHareketleri)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpKasa;
        private System.Windows.Forms.DataGridView dgvKasaHareketleri;
        private System.Windows.Forms.TabControl tabKasa;
        private System.Windows.Forms.TabPage tabGenel;
        private System.Windows.Forms.ComboBox cmbIslemTipi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtTarih;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabBaglanti;
        private System.Windows.Forms.TabPage tabBakiye;
        private System.Windows.Forms.ComboBox cmbIslemKategorisi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTutar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbOdemeTipi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtIslemiYapan;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtKasaAdi;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtPersonelID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTedarikciID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMusteriID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox rtbAciklama;
        private System.Windows.Forms.TextBox txtBakiyeSonra;
        private System.Windows.Forms.TextBox txtBakiyeOnce;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblYildizIslemTipi;
        private System.Windows.Forms.Label lblYildizOdemeTipi;
        private System.Windows.Forms.Label lblYildizIslemKategorisi;
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