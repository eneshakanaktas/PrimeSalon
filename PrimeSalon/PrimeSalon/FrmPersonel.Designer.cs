
namespace PrimeSalon
{
    partial class FrmPersonel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPersonel));
            this.grpPersonel = new System.Windows.Forms.GroupBox();
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
            this.tabPersonel = new System.Windows.Forms.TabControl();
            this.tabGenel = new System.Windows.Forms.TabPage();
            this.lblYildizPozisyon = new System.Windows.Forms.Label();
            this.lblYildiz1 = new System.Windows.Forms.Label();
            this.chkAktif = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radK = new System.Windows.Forms.RadioButton();
            this.radE = new System.Windows.Forms.RadioButton();
            this.cmbPozisyon = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabIletisim = new System.Windows.Forms.TabPage();
            this.mskTcNo = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.rtbAdres = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTelefon = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabIs = new System.Windows.Forms.TabPage();
            this.lblYildiz2 = new System.Windows.Forms.Label();
            this.dtIseGiris = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMaas = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvPersonel = new System.Windows.Forms.DataGridView();
            this.grpPersonel.SuspendLayout();
            this.toolStripPersonel.SuspendLayout();
            this.tabPersonel.SuspendLayout();
            this.tabGenel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabIletisim.SuspendLayout();
            this.tabIs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonel)).BeginInit();
            this.SuspendLayout();
            // 
            // grpPersonel
            // 
            this.grpPersonel.Controls.Add(this.toolStripPersonel);
            this.grpPersonel.Controls.Add(this.tabPersonel);
            this.grpPersonel.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpPersonel.Location = new System.Drawing.Point(0, 0);
            this.grpPersonel.Name = "grpPersonel";
            this.grpPersonel.Size = new System.Drawing.Size(984, 254);
            this.grpPersonel.TabIndex = 0;
            this.grpPersonel.TabStop = false;
            this.grpPersonel.Text = "Personel Bilgileri";
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
            this.toolStripPersonel.Size = new System.Drawing.Size(978, 36);
            this.toolStripPersonel.TabIndex = 5;
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
            // tabPersonel
            // 
            this.tabPersonel.Controls.Add(this.tabGenel);
            this.tabPersonel.Controls.Add(this.tabIletisim);
            this.tabPersonel.Controls.Add(this.tabIs);
            this.tabPersonel.Location = new System.Drawing.Point(20, 60);
            this.tabPersonel.Name = "tabPersonel";
            this.tabPersonel.SelectedIndex = 0;
            this.tabPersonel.Size = new System.Drawing.Size(940, 165);
            this.tabPersonel.TabIndex = 0;
            this.tabPersonel.TabStop = false;
            this.tabPersonel.Tag = "";
            // 
            // tabGenel
            // 
            this.tabGenel.Controls.Add(this.lblYildizPozisyon);
            this.tabGenel.Controls.Add(this.lblYildiz1);
            this.tabGenel.Controls.Add(this.chkAktif);
            this.tabGenel.Controls.Add(this.groupBox1);
            this.tabGenel.Controls.Add(this.cmbPozisyon);
            this.tabGenel.Controls.Add(this.label3);
            this.tabGenel.Controls.Add(this.txtSoyad);
            this.tabGenel.Controls.Add(this.label2);
            this.tabGenel.Controls.Add(this.txtAd);
            this.tabGenel.Controls.Add(this.label1);
            this.tabGenel.Location = new System.Drawing.Point(4, 22);
            this.tabGenel.Name = "tabGenel";
            this.tabGenel.Padding = new System.Windows.Forms.Padding(3);
            this.tabGenel.Size = new System.Drawing.Size(932, 139);
            this.tabGenel.TabIndex = 0;
            this.tabGenel.Text = "Genel";
            this.tabGenel.UseVisualStyleBackColor = true;
            // 
            // lblYildizPozisyon
            // 
            this.lblYildizPozisyon.AutoSize = true;
            this.lblYildizPozisyon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYildizPozisyon.ForeColor = System.Drawing.Color.Red;
            this.lblYildizPozisyon.Location = new System.Drawing.Point(656, 20);
            this.lblYildizPozisyon.Name = "lblYildizPozisyon";
            this.lblYildizPozisyon.Size = new System.Drawing.Size(12, 13);
            this.lblYildizPozisyon.TabIndex = 8;
            this.lblYildizPozisyon.Text = "*";
            this.lblYildizPozisyon.Visible = false;
            // 
            // lblYildiz1
            // 
            this.lblYildiz1.AutoSize = true;
            this.lblYildiz1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYildiz1.ForeColor = System.Drawing.Color.Red;
            this.lblYildiz1.Location = new System.Drawing.Point(656, 70);
            this.lblYildiz1.Name = "lblYildiz1";
            this.lblYildiz1.Size = new System.Drawing.Size(12, 13);
            this.lblYildiz1.TabIndex = 2;
            this.lblYildiz1.Text = "*";
            this.lblYildiz1.Visible = false;
            // 
            // chkAktif
            // 
            this.chkAktif.Location = new System.Drawing.Point(700, 25);
            this.chkAktif.Name = "chkAktif";
            this.chkAktif.Size = new System.Drawing.Size(80, 25);
            this.chkAktif.TabIndex = 2;
            this.chkAktif.Text = "Aktif";
            this.chkAktif.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radK);
            this.groupBox1.Controls.Add(this.radE);
            this.groupBox1.Location = new System.Drawing.Point(360, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(290, 60);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cinsiyet";
            // 
            // radK
            // 
            this.radK.AutoSize = true;
            this.radK.Location = new System.Drawing.Point(120, 25);
            this.radK.Name = "radK";
            this.radK.Size = new System.Drawing.Size(52, 17);
            this.radK.TabIndex = 4;
            this.radK.TabStop = true;
            this.radK.Text = "Kadın";
            this.radK.UseVisualStyleBackColor = true;
            // 
            // radE
            // 
            this.radE.AutoSize = true;
            this.radE.Location = new System.Drawing.Point(15, 25);
            this.radE.Name = "radE";
            this.radE.Size = new System.Drawing.Size(53, 17);
            this.radE.TabIndex = 1;
            this.radE.TabStop = true;
            this.radE.Text = "Erkek";
            this.radE.UseVisualStyleBackColor = true;
            // 
            // cmbPozisyon
            // 
            this.cmbPozisyon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPozisyon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbPozisyon.FormattingEnabled = true;
            this.cmbPozisyon.Items.AddRange(new object[] {
            "Usta",
            "Kalfa",
            "Çırak"});
            this.cmbPozisyon.Location = new System.Drawing.Point(446, 20);
            this.cmbPozisyon.Name = "cmbPozisyon";
            this.cmbPozisyon.Size = new System.Drawing.Size(200, 24);
            this.cmbPozisyon.TabIndex = 1;
            this.cmbPozisyon.SelectedIndexChanged += new System.EventHandler(this.cmbPozisyon_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(360, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Pozisyon";
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(116, 67);
            this.txtSoyad.Multiline = true;
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(200, 25);
            this.txtSoyad.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(30, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Soyad";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(116, 22);
            this.txtAd.Multiline = true;
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(200, 25);
            this.txtAd.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(30, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad";
            // 
            // tabIletisim
            // 
            this.tabIletisim.Controls.Add(this.mskTcNo);
            this.tabIletisim.Controls.Add(this.label9);
            this.tabIletisim.Controls.Add(this.rtbAdres);
            this.tabIletisim.Controls.Add(this.label6);
            this.tabIletisim.Controls.Add(this.txtEmail);
            this.tabIletisim.Controls.Add(this.label5);
            this.tabIletisim.Controls.Add(this.txtTelefon);
            this.tabIletisim.Controls.Add(this.label4);
            this.tabIletisim.Location = new System.Drawing.Point(4, 22);
            this.tabIletisim.Name = "tabIletisim";
            this.tabIletisim.Padding = new System.Windows.Forms.Padding(3);
            this.tabIletisim.Size = new System.Drawing.Size(932, 139);
            this.tabIletisim.TabIndex = 1;
            this.tabIletisim.Text = "İletişim";
            this.tabIletisim.UseVisualStyleBackColor = true;
            // 
            // mskTcNo
            // 
            this.mskTcNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mskTcNo.Location = new System.Drawing.Point(101, 74);
            this.mskTcNo.Mask = "00000000000";
            this.mskTcNo.Name = "mskTcNo";
            this.mskTcNo.Size = new System.Drawing.Size(180, 23);
            this.mskTcNo.TabIndex = 3;
            this.mskTcNo.ValidatingType = typeof(int);
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(6, 74);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 23);
            this.label9.TabIndex = 6;
            this.label9.Text = "TC Kimlik No";
            // 
            // rtbAdres
            // 
            this.rtbAdres.Location = new System.Drawing.Point(414, 67);
            this.rtbAdres.Name = "rtbAdres";
            this.rtbAdres.Size = new System.Drawing.Size(427, 63);
            this.rtbAdres.TabIndex = 4;
            this.rtbAdres.Text = "";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(324, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 23);
            this.label6.TabIndex = 4;
            this.label6.Text = "Adres";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(414, 15);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(190, 25);
            this.txtEmail.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(324, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 23);
            this.label5.TabIndex = 2;
            this.label5.Text = "E-Posta";
            // 
            // txtTelefon
            // 
            this.txtTelefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTelefon.Location = new System.Drawing.Point(101, 15);
            this.txtTelefon.Mask = "(9999) 000-0000";
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(180, 23);
            this.txtTelefon.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(11, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 23);
            this.label4.TabIndex = 0;
            this.label4.Text = "Telefon";
            // 
            // tabIs
            // 
            this.tabIs.Controls.Add(this.lblYildiz2);
            this.tabIs.Controls.Add(this.dtIseGiris);
            this.tabIs.Controls.Add(this.label8);
            this.tabIs.Controls.Add(this.txtMaas);
            this.tabIs.Controls.Add(this.label7);
            this.tabIs.Location = new System.Drawing.Point(4, 22);
            this.tabIs.Name = "tabIs";
            this.tabIs.Padding = new System.Windows.Forms.Padding(3);
            this.tabIs.Size = new System.Drawing.Size(932, 139);
            this.tabIs.TabIndex = 2;
            this.tabIs.Text = "İş";
            this.tabIs.UseVisualStyleBackColor = true;
            // 
            // lblYildiz2
            // 
            this.lblYildiz2.AutoSize = true;
            this.lblYildiz2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYildiz2.ForeColor = System.Drawing.Color.Red;
            this.lblYildiz2.Location = new System.Drawing.Point(652, 22);
            this.lblYildiz2.Name = "lblYildiz2";
            this.lblYildiz2.Size = new System.Drawing.Size(12, 13);
            this.lblYildiz2.TabIndex = 2;
            this.lblYildiz2.Text = "*";
            this.lblYildiz2.Visible = false;
            // 
            // dtIseGiris
            // 
            this.dtIseGiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtIseGiris.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtIseGiris.Location = new System.Drawing.Point(446, 22);
            this.dtIseGiris.Name = "dtIseGiris";
            this.dtIseGiris.Size = new System.Drawing.Size(200, 23);
            this.dtIseGiris.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(360, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 23);
            this.label8.TabIndex = 2;
            this.label8.Text = "İşe Giriş Tarihi";
            // 
            // txtMaas
            // 
            this.txtMaas.Location = new System.Drawing.Point(120, 22);
            this.txtMaas.Multiline = true;
            this.txtMaas.Name = "txtMaas";
            this.txtMaas.Size = new System.Drawing.Size(200, 25);
            this.txtMaas.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(30, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 23);
            this.label7.TabIndex = 0;
            this.label7.Text = "Maaş";
            // 
            // dgvPersonel
            // 
            this.dgvPersonel.AllowUserToAddRows = false;
            this.dgvPersonel.AllowUserToDeleteRows = false;
            this.dgvPersonel.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPersonel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersonel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPersonel.Location = new System.Drawing.Point(0, 254);
            this.dgvPersonel.MultiSelect = false;
            this.dgvPersonel.Name = "dgvPersonel";
            this.dgvPersonel.ReadOnly = true;
            this.dgvPersonel.RowHeadersWidth = 25;
            this.dgvPersonel.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPersonel.Size = new System.Drawing.Size(984, 307);
            this.dgvPersonel.TabIndex = 1;
            this.dgvPersonel.TabStop = false;
            this.dgvPersonel.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPersonel_CellContentClick);
            // 
            // FrmPersonel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.dgvPersonel);
            this.Controls.Add(this.grpPersonel);
            this.Name = "FrmPersonel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personel Yönetimi";
            this.Load += new System.EventHandler(this.FrmPersonel_Load);
            this.grpPersonel.ResumeLayout(false);
            this.toolStripPersonel.ResumeLayout(false);
            this.toolStripPersonel.PerformLayout();
            this.tabPersonel.ResumeLayout(false);
            this.tabGenel.ResumeLayout(false);
            this.tabGenel.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabIletisim.ResumeLayout(false);
            this.tabIletisim.PerformLayout();
            this.tabIs.ResumeLayout(false);
            this.tabIs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpPersonel;
        private System.Windows.Forms.TabControl tabPersonel;
        private System.Windows.Forms.TabPage tabGenel;
        private System.Windows.Forms.CheckBox chkAktif;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radK;
        private System.Windows.Forms.RadioButton radE;
        private System.Windows.Forms.ComboBox cmbPozisyon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabIletisim;
        private System.Windows.Forms.RichTextBox rtbAdres;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox txtTelefon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage tabIs;
        private System.Windows.Forms.DateTimePicker dtIseGiris;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtMaas;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvPersonel;
        private System.Windows.Forms.MaskedTextBox mskTcNo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblYildiz1;
        private System.Windows.Forms.Label lblYildiz2;
        private System.Windows.Forms.Label lblYildizPozisyon;
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
    }
}