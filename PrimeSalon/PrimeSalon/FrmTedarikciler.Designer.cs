
namespace PrimeSalon
{
    partial class FrmTedarikciler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTedarikciler));
            this.grpTedarikci = new System.Windows.Forms.GroupBox();
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
            this.tabTedarikci = new System.Windows.Forms.TabControl();
            this.tabGenel = new System.Windows.Forms.TabPage();
            this.lblYildizSehir = new System.Windows.Forms.Label();
            this.cmbSehir = new System.Windows.Forms.ComboBox();
            this.chkAktif = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtYetkiliAdSoyad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFirmaAdi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabIletisim = new System.Windows.Forms.TabPage();
            this.rtbAdres = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.mskTelefon = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabFinans = new System.Windows.Forms.TabPage();
            this.rtbNotlar = new System.Windows.Forms.RichTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dtKayitTarihi = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.txtBanka = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtIBAN = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvTedarikciler = new System.Windows.Forms.DataGridView();
            this.grpTedarikci.SuspendLayout();
            this.toolStripPersonel.SuspendLayout();
            this.tabTedarikci.SuspendLayout();
            this.tabGenel.SuspendLayout();
            this.tabIletisim.SuspendLayout();
            this.tabFinans.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTedarikciler)).BeginInit();
            this.SuspendLayout();
            // 
            // grpTedarikci
            // 
            this.grpTedarikci.Controls.Add(this.toolStripPersonel);
            this.grpTedarikci.Controls.Add(this.tabTedarikci);
            this.grpTedarikci.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpTedarikci.Location = new System.Drawing.Point(0, 0);
            this.grpTedarikci.Name = "grpTedarikci";
            this.grpTedarikci.Size = new System.Drawing.Size(1084, 260);
            this.grpTedarikci.TabIndex = 1;
            this.grpTedarikci.TabStop = false;
            this.grpTedarikci.Text = "Tedarikçi Bilgileri";
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
            this.toolStripPersonel.TabIndex = 14;
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
            // tabTedarikci
            // 
            this.tabTedarikci.Controls.Add(this.tabGenel);
            this.tabTedarikci.Controls.Add(this.tabIletisim);
            this.tabTedarikci.Controls.Add(this.tabFinans);
            this.tabTedarikci.Location = new System.Drawing.Point(20, 60);
            this.tabTedarikci.Name = "tabTedarikci";
            this.tabTedarikci.SelectedIndex = 0;
            this.tabTedarikci.Size = new System.Drawing.Size(1040, 180);
            this.tabTedarikci.TabIndex = 0;
            this.tabTedarikci.TabStop = false;
            // 
            // tabGenel
            // 
            this.tabGenel.Controls.Add(this.lblYildizSehir);
            this.tabGenel.Controls.Add(this.cmbSehir);
            this.tabGenel.Controls.Add(this.chkAktif);
            this.tabGenel.Controls.Add(this.label3);
            this.tabGenel.Controls.Add(this.txtYetkiliAdSoyad);
            this.tabGenel.Controls.Add(this.label2);
            this.tabGenel.Controls.Add(this.txtFirmaAdi);
            this.tabGenel.Controls.Add(this.label1);
            this.tabGenel.Location = new System.Drawing.Point(4, 22);
            this.tabGenel.Name = "tabGenel";
            this.tabGenel.Padding = new System.Windows.Forms.Padding(3);
            this.tabGenel.Size = new System.Drawing.Size(1032, 154);
            this.tabGenel.TabIndex = 0;
            this.tabGenel.Text = "Genel";
            this.tabGenel.UseVisualStyleBackColor = true;
            // 
            // lblYildizSehir
            // 
            this.lblYildizSehir.AutoSize = true;
            this.lblYildizSehir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYildizSehir.ForeColor = System.Drawing.Color.Red;
            this.lblYildizSehir.Location = new System.Drawing.Point(676, 22);
            this.lblYildizSehir.Name = "lblYildizSehir";
            this.lblYildizSehir.Size = new System.Drawing.Size(14, 17);
            this.lblYildizSehir.TabIndex = 8;
            this.lblYildizSehir.Text = "*";
            this.lblYildizSehir.Visible = false;
            // 
            // cmbSehir
            // 
            this.cmbSehir.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSehir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbSehir.FormattingEnabled = true;
            this.cmbSehir.Items.AddRange(new object[] {
            "Seçiniz",
            "İstanbul",
            "Ankara",
            "İzmir",
            "Bursa"});
            this.cmbSehir.Location = new System.Drawing.Point(490, 22);
            this.cmbSehir.Name = "cmbSehir";
            this.cmbSehir.Size = new System.Drawing.Size(180, 24);
            this.cmbSehir.TabIndex = 1;
            this.cmbSehir.SelectedIndexChanged += new System.EventHandler(this.cmbSehir_SelectedIndexChanged);
            // 
            // chkAktif
            // 
            this.chkAktif.Location = new System.Drawing.Point(720, 25);
            this.chkAktif.Name = "chkAktif";
            this.chkAktif.Size = new System.Drawing.Size(80, 25);
            this.chkAktif.TabIndex = 2;
            this.chkAktif.Text = "Aktif";
            this.chkAktif.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(400, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Şehir";
            // 
            // txtYetkiliAdSoyad
            // 
            this.txtYetkiliAdSoyad.Location = new System.Drawing.Point(120, 67);
            this.txtYetkiliAdSoyad.Multiline = true;
            this.txtYetkiliAdSoyad.Name = "txtYetkiliAdSoyad";
            this.txtYetkiliAdSoyad.Size = new System.Drawing.Size(220, 25);
            this.txtYetkiliAdSoyad.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(30, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Yetkili";
            // 
            // txtFirmaAdi
            // 
            this.txtFirmaAdi.Location = new System.Drawing.Point(120, 22);
            this.txtFirmaAdi.Multiline = true;
            this.txtFirmaAdi.Name = "txtFirmaAdi";
            this.txtFirmaAdi.Size = new System.Drawing.Size(220, 25);
            this.txtFirmaAdi.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(30, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Firma Adı";
            // 
            // tabIletisim
            // 
            this.tabIletisim.Controls.Add(this.rtbAdres);
            this.tabIletisim.Controls.Add(this.label6);
            this.tabIletisim.Controls.Add(this.txtEmail);
            this.tabIletisim.Controls.Add(this.label5);
            this.tabIletisim.Controls.Add(this.mskTelefon);
            this.tabIletisim.Controls.Add(this.label4);
            this.tabIletisim.Location = new System.Drawing.Point(4, 22);
            this.tabIletisim.Name = "tabIletisim";
            this.tabIletisim.Padding = new System.Windows.Forms.Padding(3);
            this.tabIletisim.Size = new System.Drawing.Size(1032, 154);
            this.tabIletisim.TabIndex = 1;
            this.tabIletisim.Text = "İletişim";
            this.tabIletisim.UseVisualStyleBackColor = true;
            // 
            // rtbAdres
            // 
            this.rtbAdres.Location = new System.Drawing.Point(120, 70);
            this.rtbAdres.Name = "rtbAdres";
            this.rtbAdres.Size = new System.Drawing.Size(620, 70);
            this.rtbAdres.TabIndex = 2;
            this.rtbAdres.Text = "";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(30, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 23);
            this.label6.TabIndex = 4;
            this.label6.Text = "Adres";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(490, 22);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(250, 25);
            this.txtEmail.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(400, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 23);
            this.label5.TabIndex = 2;
            this.label5.Text = "E-Posta";
            // 
            // mskTelefon
            // 
            this.mskTelefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mskTelefon.Location = new System.Drawing.Point(120, 22);
            this.mskTelefon.Mask = "(9999) 000-0000";
            this.mskTelefon.Name = "mskTelefon";
            this.mskTelefon.Size = new System.Drawing.Size(220, 23);
            this.mskTelefon.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(30, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 23);
            this.label4.TabIndex = 0;
            this.label4.Text = "Telefon";
            // 
            // tabFinans
            // 
            this.tabFinans.Controls.Add(this.rtbNotlar);
            this.tabFinans.Controls.Add(this.label10);
            this.tabFinans.Controls.Add(this.dtKayitTarihi);
            this.tabFinans.Controls.Add(this.label9);
            this.tabFinans.Controls.Add(this.txtBanka);
            this.tabFinans.Controls.Add(this.label8);
            this.tabFinans.Controls.Add(this.txtIBAN);
            this.tabFinans.Controls.Add(this.label7);
            this.tabFinans.Location = new System.Drawing.Point(4, 22);
            this.tabFinans.Name = "tabFinans";
            this.tabFinans.Padding = new System.Windows.Forms.Padding(3);
            this.tabFinans.Size = new System.Drawing.Size(1032, 154);
            this.tabFinans.TabIndex = 2;
            this.tabFinans.Text = "Finans/Not";
            this.tabFinans.UseVisualStyleBackColor = true;
            // 
            // rtbNotlar
            // 
            this.rtbNotlar.Location = new System.Drawing.Point(490, 70);
            this.rtbNotlar.Name = "rtbNotlar";
            this.rtbNotlar.Size = new System.Drawing.Size(350, 70);
            this.rtbNotlar.TabIndex = 4;
            this.rtbNotlar.Text = "";
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(400, 70);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 23);
            this.label10.TabIndex = 6;
            this.label10.Text = "Notlar";
            // 
            // dtKayitTarihi
            // 
            this.dtKayitTarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtKayitTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtKayitTarihi.Location = new System.Drawing.Point(120, 67);
            this.dtKayitTarihi.Name = "dtKayitTarihi";
            this.dtKayitTarihi.Size = new System.Drawing.Size(220, 23);
            this.dtKayitTarihi.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(30, 70);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 23);
            this.label9.TabIndex = 4;
            this.label9.Text = "Kayıt Tarihi";
            // 
            // txtBanka
            // 
            this.txtBanka.Location = new System.Drawing.Point(490, 25);
            this.txtBanka.Multiline = true;
            this.txtBanka.Name = "txtBanka";
            this.txtBanka.Size = new System.Drawing.Size(220, 25);
            this.txtBanka.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(400, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 23);
            this.label8.TabIndex = 2;
            this.label8.Text = "Banka";
            // 
            // txtIBAN
            // 
            this.txtIBAN.Location = new System.Drawing.Point(120, 22);
            this.txtIBAN.Multiline = true;
            this.txtIBAN.Name = "txtIBAN";
            this.txtIBAN.Size = new System.Drawing.Size(250, 25);
            this.txtIBAN.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(30, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 23);
            this.label7.TabIndex = 0;
            this.label7.Text = "IBAN";
            // 
            // dgvTedarikciler
            // 
            this.dgvTedarikciler.AllowUserToAddRows = false;
            this.dgvTedarikciler.AllowUserToDeleteRows = false;
            this.dgvTedarikciler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTedarikciler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTedarikciler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTedarikciler.Location = new System.Drawing.Point(0, 260);
            this.dgvTedarikciler.Name = "dgvTedarikciler";
            this.dgvTedarikciler.ReadOnly = true;
            this.dgvTedarikciler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTedarikciler.Size = new System.Drawing.Size(1084, 351);
            this.dgvTedarikciler.TabIndex = 0;
            this.dgvTedarikciler.TabStop = false;
            // 
            // FrmTedarikciler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 611);
            this.Controls.Add(this.dgvTedarikciler);
            this.Controls.Add(this.grpTedarikci);
            this.Name = "FrmTedarikciler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tedarikçi Yönetimi";
            this.Load += new System.EventHandler(this.FrmTedarikciler_Load);
            this.grpTedarikci.ResumeLayout(false);
            this.toolStripPersonel.ResumeLayout(false);
            this.toolStripPersonel.PerformLayout();
            this.tabTedarikci.ResumeLayout(false);
            this.tabGenel.ResumeLayout(false);
            this.tabGenel.PerformLayout();
            this.tabIletisim.ResumeLayout(false);
            this.tabIletisim.PerformLayout();
            this.tabFinans.ResumeLayout(false);
            this.tabFinans.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTedarikciler)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpTedarikci;
        private System.Windows.Forms.DataGridView dgvTedarikciler;
        private System.Windows.Forms.TabControl tabTedarikci;
        private System.Windows.Forms.TabPage tabGenel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabIletisim;
        private System.Windows.Forms.TabPage tabFinans;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtYetkiliAdSoyad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFirmaAdi;
        private System.Windows.Forms.CheckBox chkAktif;
        private System.Windows.Forms.RichTextBox rtbAdres;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox mskTelefon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBanka;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtIBAN;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox rtbNotlar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtKayitTarihi;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbSehir;
        private System.Windows.Forms.Label lblYildizSehir;
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