
namespace PrimeSalon
{
    partial class FrmDemirbaslar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDemirbaslar));
            this.grpDemirbaslar = new System.Windows.Forms.GroupBox();
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
            this.tabDemirbas = new System.Windows.Forms.TabControl();
            this.tabGenel = new System.Windows.Forms.TabPage();
            this.lblYildizKategori = new System.Windows.Forms.Label();
            this.chkAktif = new System.Windows.Forms.CheckBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMarka = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbKategori = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDemirbasAdi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabAlim = new System.Windows.Forms.TabPage();
            this.dtGarantiBitis = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAlimFiyati = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtAlimTarihi = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.tabNot = new System.Windows.Forms.TabPage();
            this.lblYildizDurum = new System.Windows.Forms.Label();
            this.rtbNotlar = new System.Windows.Forms.RichTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtSorumluPersonel = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbDurum = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dgvDemirbaslar = new System.Windows.Forms.DataGridView();
            this.grpDemirbaslar.SuspendLayout();
            this.toolStripPersonel.SuspendLayout();
            this.tabDemirbas.SuspendLayout();
            this.tabGenel.SuspendLayout();
            this.tabAlim.SuspendLayout();
            this.tabNot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDemirbaslar)).BeginInit();
            this.SuspendLayout();
            // 
            // grpDemirbaslar
            // 
            this.grpDemirbaslar.Controls.Add(this.toolStripPersonel);
            this.grpDemirbaslar.Controls.Add(this.tabDemirbas);
            this.grpDemirbaslar.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpDemirbaslar.Location = new System.Drawing.Point(0, 0);
            this.grpDemirbaslar.Name = "grpDemirbaslar";
            this.grpDemirbaslar.Size = new System.Drawing.Size(1084, 260);
            this.grpDemirbaslar.TabIndex = 0;
            this.grpDemirbaslar.TabStop = false;
            this.grpDemirbaslar.Text = "Demirbaş Bilgileri";
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
            this.toolStripPersonel.TabIndex = 15;
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
            // tabDemirbas
            // 
            this.tabDemirbas.Controls.Add(this.tabGenel);
            this.tabDemirbas.Controls.Add(this.tabAlim);
            this.tabDemirbas.Controls.Add(this.tabNot);
            this.tabDemirbas.Location = new System.Drawing.Point(20, 60);
            this.tabDemirbas.Name = "tabDemirbas";
            this.tabDemirbas.SelectedIndex = 0;
            this.tabDemirbas.Size = new System.Drawing.Size(1040, 180);
            this.tabDemirbas.TabIndex = 0;
            this.tabDemirbas.TabStop = false;
            // 
            // tabGenel
            // 
            this.tabGenel.Controls.Add(this.lblYildizKategori);
            this.tabGenel.Controls.Add(this.chkAktif);
            this.tabGenel.Controls.Add(this.txtModel);
            this.tabGenel.Controls.Add(this.label4);
            this.tabGenel.Controls.Add(this.txtMarka);
            this.tabGenel.Controls.Add(this.label3);
            this.tabGenel.Controls.Add(this.cmbKategori);
            this.tabGenel.Controls.Add(this.label2);
            this.tabGenel.Controls.Add(this.txtDemirbasAdi);
            this.tabGenel.Controls.Add(this.label1);
            this.tabGenel.Location = new System.Drawing.Point(4, 22);
            this.tabGenel.Name = "tabGenel";
            this.tabGenel.Padding = new System.Windows.Forms.Padding(3);
            this.tabGenel.Size = new System.Drawing.Size(1032, 154);
            this.tabGenel.TabIndex = 0;
            this.tabGenel.Text = "Genel";
            this.tabGenel.UseVisualStyleBackColor = true;
            // 
            // lblYildizKategori
            // 
            this.lblYildizKategori.AutoSize = true;
            this.lblYildizKategori.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYildizKategori.ForeColor = System.Drawing.Color.Red;
            this.lblYildizKategori.Location = new System.Drawing.Point(306, 67);
            this.lblYildizKategori.Name = "lblYildizKategori";
            this.lblYildizKategori.Size = new System.Drawing.Size(14, 17);
            this.lblYildizKategori.TabIndex = 9;
            this.lblYildizKategori.Text = "*";
            this.lblYildizKategori.Visible = false;
            // 
            // chkAktif
            // 
            this.chkAktif.AutoSize = true;
            this.chkAktif.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chkAktif.Location = new System.Drawing.Point(740, 25);
            this.chkAktif.Name = "chkAktif";
            this.chkAktif.Size = new System.Drawing.Size(54, 21);
            this.chkAktif.TabIndex = 3;
            this.chkAktif.Text = "Aktif";
            this.chkAktif.UseVisualStyleBackColor = true;
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(490, 67);
            this.txtModel.Multiline = true;
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(180, 25);
            this.txtModel.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(400, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "Model";
            // 
            // txtMarka
            // 
            this.txtMarka.Location = new System.Drawing.Point(490, 22);
            this.txtMarka.Multiline = true;
            this.txtMarka.Name = "txtMarka";
            this.txtMarka.Size = new System.Drawing.Size(180, 25);
            this.txtMarka.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(400, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Marka";
            // 
            // cmbKategori
            // 
            this.cmbKategori.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKategori.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbKategori.FormattingEnabled = true;
            this.cmbKategori.Items.AddRange(new object[] {
            "Seçiniz",
            "Makine",
            "Mobilya",
            "Elektronik",
            "Diğer"});
            this.cmbKategori.Location = new System.Drawing.Point(120, 67);
            this.cmbKategori.Name = "cmbKategori";
            this.cmbKategori.Size = new System.Drawing.Size(180, 25);
            this.cmbKategori.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(30, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kategori";
            // 
            // txtDemirbasAdi
            // 
            this.txtDemirbasAdi.Location = new System.Drawing.Point(120, 22);
            this.txtDemirbasAdi.Multiline = true;
            this.txtDemirbasAdi.Name = "txtDemirbasAdi";
            this.txtDemirbasAdi.Size = new System.Drawing.Size(220, 25);
            this.txtDemirbasAdi.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(30, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Demirbaş Adı";
            // 
            // tabAlim
            // 
            this.tabAlim.Controls.Add(this.dtGarantiBitis);
            this.tabAlim.Controls.Add(this.label7);
            this.tabAlim.Controls.Add(this.txtAlimFiyati);
            this.tabAlim.Controls.Add(this.label6);
            this.tabAlim.Controls.Add(this.dtAlimTarihi);
            this.tabAlim.Controls.Add(this.label5);
            this.tabAlim.Location = new System.Drawing.Point(4, 22);
            this.tabAlim.Name = "tabAlim";
            this.tabAlim.Padding = new System.Windows.Forms.Padding(3);
            this.tabAlim.Size = new System.Drawing.Size(1032, 154);
            this.tabAlim.TabIndex = 1;
            this.tabAlim.Text = "Alım/Garanti";
            this.tabAlim.UseVisualStyleBackColor = true;
            // 
            // dtGarantiBitis
            // 
            this.dtGarantiBitis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtGarantiBitis.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtGarantiBitis.Location = new System.Drawing.Point(120, 67);
            this.dtGarantiBitis.Name = "dtGarantiBitis";
            this.dtGarantiBitis.Size = new System.Drawing.Size(200, 23);
            this.dtGarantiBitis.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(30, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 23);
            this.label7.TabIndex = 4;
            this.label7.Text = "Garanti Bitiş";
            // 
            // txtAlimFiyati
            // 
            this.txtAlimFiyati.Location = new System.Drawing.Point(490, 22);
            this.txtAlimFiyati.Multiline = true;
            this.txtAlimFiyati.Name = "txtAlimFiyati";
            this.txtAlimFiyati.Size = new System.Drawing.Size(180, 25);
            this.txtAlimFiyati.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(400, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 23);
            this.label6.TabIndex = 2;
            this.label6.Text = "Alım Fiyatı";
            // 
            // dtAlimTarihi
            // 
            this.dtAlimTarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtAlimTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtAlimTarihi.Location = new System.Drawing.Point(120, 22);
            this.dtAlimTarihi.Name = "dtAlimTarihi";
            this.dtAlimTarihi.Size = new System.Drawing.Size(200, 23);
            this.dtAlimTarihi.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(30, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 23);
            this.label5.TabIndex = 0;
            this.label5.Text = "Alım Tarihi";
            // 
            // tabNot
            // 
            this.tabNot.Controls.Add(this.lblYildizDurum);
            this.tabNot.Controls.Add(this.rtbNotlar);
            this.tabNot.Controls.Add(this.label10);
            this.tabNot.Controls.Add(this.txtSorumluPersonel);
            this.tabNot.Controls.Add(this.label9);
            this.tabNot.Controls.Add(this.cmbDurum);
            this.tabNot.Controls.Add(this.label8);
            this.tabNot.Location = new System.Drawing.Point(4, 22);
            this.tabNot.Name = "tabNot";
            this.tabNot.Padding = new System.Windows.Forms.Padding(3);
            this.tabNot.Size = new System.Drawing.Size(1032, 154);
            this.tabNot.TabIndex = 2;
            this.tabNot.Text = "Durum/Not";
            this.tabNot.UseVisualStyleBackColor = true;
            // 
            // lblYildizDurum
            // 
            this.lblYildizDurum.AutoSize = true;
            this.lblYildizDurum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYildizDurum.ForeColor = System.Drawing.Color.Red;
            this.lblYildizDurum.Location = new System.Drawing.Point(302, 19);
            this.lblYildizDurum.Name = "lblYildizDurum";
            this.lblYildizDurum.Size = new System.Drawing.Size(14, 17);
            this.lblYildizDurum.TabIndex = 6;
            this.lblYildizDurum.Text = "*";
            this.lblYildizDurum.Visible = false;
            // 
            // rtbNotlar
            // 
            this.rtbNotlar.Location = new System.Drawing.Point(120, 70);
            this.rtbNotlar.Name = "rtbNotlar";
            this.rtbNotlar.Size = new System.Drawing.Size(590, 70);
            this.rtbNotlar.TabIndex = 3;
            this.rtbNotlar.Text = "";
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(30, 70);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 23);
            this.label10.TabIndex = 4;
            this.label10.Text = "Notlar";
            // 
            // txtSorumluPersonel
            // 
            this.txtSorumluPersonel.Location = new System.Drawing.Point(490, 22);
            this.txtSorumluPersonel.Multiline = true;
            this.txtSorumluPersonel.Name = "txtSorumluPersonel";
            this.txtSorumluPersonel.Size = new System.Drawing.Size(220, 25);
            this.txtSorumluPersonel.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(400, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 23);
            this.label9.TabIndex = 2;
            this.label9.Text = "Sorumlu";
            // 
            // cmbDurum
            // 
            this.cmbDurum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDurum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbDurum.FormattingEnabled = true;
            this.cmbDurum.Items.AddRange(new object[] {
            "Seçiniz",
            "Aktif",
            "Arızalı",
            "Hurda",
            "Bakımda"});
            this.cmbDurum.Location = new System.Drawing.Point(116, 19);
            this.cmbDurum.Name = "cmbDurum";
            this.cmbDurum.Size = new System.Drawing.Size(180, 25);
            this.cmbDurum.TabIndex = 1;
            this.cmbDurum.SelectedIndexChanged += new System.EventHandler(this.cmbDurum_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(30, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 23);
            this.label8.TabIndex = 0;
            this.label8.Text = "Durum";
            // 
            // dgvDemirbaslar
            // 
            this.dgvDemirbaslar.AllowUserToAddRows = false;
            this.dgvDemirbaslar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDemirbaslar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDemirbaslar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDemirbaslar.Location = new System.Drawing.Point(0, 260);
            this.dgvDemirbaslar.MultiSelect = false;
            this.dgvDemirbaslar.Name = "dgvDemirbaslar";
            this.dgvDemirbaslar.ReadOnly = true;
            this.dgvDemirbaslar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDemirbaslar.Size = new System.Drawing.Size(1084, 351);
            this.dgvDemirbaslar.TabIndex = 0;
            this.dgvDemirbaslar.TabStop = false;
            // 
            // FrmDemirbaslar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 611);
            this.Controls.Add(this.dgvDemirbaslar);
            this.Controls.Add(this.grpDemirbaslar);
            this.Name = "FrmDemirbaslar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Demirbaş Yönetimi";
            this.Load += new System.EventHandler(this.FrmDemirbaslar_Load);
            this.grpDemirbaslar.ResumeLayout(false);
            this.toolStripPersonel.ResumeLayout(false);
            this.toolStripPersonel.PerformLayout();
            this.tabDemirbas.ResumeLayout(false);
            this.tabGenel.ResumeLayout(false);
            this.tabGenel.PerformLayout();
            this.tabAlim.ResumeLayout(false);
            this.tabAlim.PerformLayout();
            this.tabNot.ResumeLayout(false);
            this.tabNot.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDemirbaslar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpDemirbaslar;
        private System.Windows.Forms.DataGridView dgvDemirbaslar;
        private System.Windows.Forms.TabControl tabDemirbas;
        private System.Windows.Forms.TabPage tabGenel;
        private System.Windows.Forms.TabPage tabAlim;
        private System.Windows.Forms.TabPage tabNot;
        private System.Windows.Forms.TextBox txtDemirbasAdi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbKategori;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkAktif;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMarka;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtGarantiBitis;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAlimFiyati;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtAlimTarihi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbDurum;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSorumluPersonel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RichTextBox rtbNotlar;
        private System.Windows.Forms.Label lblYildizKategori;
        private System.Windows.Forms.Label lblYildizDurum;
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