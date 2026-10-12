
namespace PrimeSalon
{
    partial class FrmMusteri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMusteri));
            this.grpMusteri = new System.Windows.Forms.GroupBox();
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
            this.tabMusteri = new System.Windows.Forms.TabControl();
            this.tabGenel = new System.Windows.Forms.TabPage();
            this.dtSonGelisTarihi = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dtKayitTarihi = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.chkAktif = new System.Windows.Forms.CheckBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabIletisim = new System.Windows.Forms.TabPage();
            this.rtbAdres = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.mskTcNo = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTelefon = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tabFinans = new System.Windows.Forms.TabPage();
            this.rtbNotlar = new System.Windows.Forms.RichTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtToplamHarcama = new System.Windows.Forms.TextBox();
            this.txtBorc = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dgvMusteri = new System.Windows.Forms.DataGridView();
            this.grpMusteri.SuspendLayout();
            this.toolStripPersonel.SuspendLayout();
            this.tabMusteri.SuspendLayout();
            this.tabGenel.SuspendLayout();
            this.tabIletisim.SuspendLayout();
            this.tabFinans.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMusteri)).BeginInit();
            this.SuspendLayout();
            // 
            // grpMusteri
            // 
            this.grpMusteri.Controls.Add(this.toolStripPersonel);
            this.grpMusteri.Controls.Add(this.tabMusteri);
            this.grpMusteri.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpMusteri.Location = new System.Drawing.Point(0, 0);
            this.grpMusteri.Name = "grpMusteri";
            this.grpMusteri.Size = new System.Drawing.Size(984, 260);
            this.grpMusteri.TabIndex = 0;
            this.grpMusteri.TabStop = false;
            this.grpMusteri.Text = "Müşteri Bilgileri";
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
            this.toolStripPersonel.Size = new System.Drawing.Size(978, 36);
            this.toolStripPersonel.TabIndex = 6;
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
            // tabMusteri
            // 
            this.tabMusteri.Controls.Add(this.tabGenel);
            this.tabMusteri.Controls.Add(this.tabIletisim);
            this.tabMusteri.Controls.Add(this.tabFinans);
            this.tabMusteri.Location = new System.Drawing.Point(20, 60);
            this.tabMusteri.Name = "tabMusteri";
            this.tabMusteri.SelectedIndex = 0;
            this.tabMusteri.Size = new System.Drawing.Size(940, 165);
            this.tabMusteri.TabIndex = 1;
            this.tabMusteri.TabStop = false;
            // 
            // tabGenel
            // 
            this.tabGenel.Controls.Add(this.dtSonGelisTarihi);
            this.tabGenel.Controls.Add(this.label4);
            this.tabGenel.Controls.Add(this.dtKayitTarihi);
            this.tabGenel.Controls.Add(this.label3);
            this.tabGenel.Controls.Add(this.chkAktif);
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
            // dtSonGelisTarihi
            // 
            this.dtSonGelisTarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtSonGelisTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtSonGelisTarihi.Location = new System.Drawing.Point(763, 67);
            this.dtSonGelisTarihi.Name = "dtSonGelisTarihi";
            this.dtSonGelisTarihi.Size = new System.Drawing.Size(140, 23);
            this.dtSonGelisTarihi.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(689, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 23);
            this.label4.TabIndex = 7;
            this.label4.Text = "Son Geliş";
            // 
            // dtKayitTarihi
            // 
            this.dtKayitTarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtKayitTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtKayitTarihi.Location = new System.Drawing.Point(450, 67);
            this.dtKayitTarihi.Name = "dtKayitTarihi";
            this.dtKayitTarihi.Size = new System.Drawing.Size(200, 23);
            this.dtKayitTarihi.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(360, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Kayıt Tarihi";
            // 
            // chkAktif
            // 
            this.chkAktif.Location = new System.Drawing.Point(360, 20);
            this.chkAktif.Name = "chkAktif";
            this.chkAktif.Size = new System.Drawing.Size(80, 25);
            this.chkAktif.TabIndex = 2;
            this.chkAktif.Text = "Aktif";
            this.chkAktif.UseVisualStyleBackColor = true;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(120, 67);
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
            this.txtAd.Location = new System.Drawing.Point(120, 22);
            this.txtAd.Multiline = true;
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(200, 25);
            this.txtAd.TabIndex = 1;
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
            this.tabIletisim.Controls.Add(this.rtbAdres);
            this.tabIletisim.Controls.Add(this.label8);
            this.tabIletisim.Controls.Add(this.txtEmail);
            this.tabIletisim.Controls.Add(this.label7);
            this.tabIletisim.Controls.Add(this.mskTcNo);
            this.tabIletisim.Controls.Add(this.label6);
            this.tabIletisim.Controls.Add(this.txtTelefon);
            this.tabIletisim.Controls.Add(this.label5);
            this.tabIletisim.Location = new System.Drawing.Point(4, 22);
            this.tabIletisim.Name = "tabIletisim";
            this.tabIletisim.Padding = new System.Windows.Forms.Padding(3);
            this.tabIletisim.Size = new System.Drawing.Size(932, 139);
            this.tabIletisim.TabIndex = 1;
            this.tabIletisim.Text = "İletişim";
            this.tabIletisim.UseVisualStyleBackColor = true;
            // 
            // rtbAdres
            // 
            this.rtbAdres.Location = new System.Drawing.Point(450, 67);
            this.rtbAdres.Name = "rtbAdres";
            this.rtbAdres.Size = new System.Drawing.Size(436, 63);
            this.rtbAdres.TabIndex = 4;
            this.rtbAdres.Text = "";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(360, 70);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 23);
            this.label8.TabIndex = 6;
            this.label8.Text = "Adres";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(450, 22);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(250, 25);
            this.txtEmail.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(360, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 23);
            this.label7.TabIndex = 4;
            this.label7.Text = "E-Posta";
            // 
            // mskTcNo
            // 
            this.mskTcNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mskTcNo.Location = new System.Drawing.Point(120, 67);
            this.mskTcNo.Mask = "00000000000";
            this.mskTcNo.Name = "mskTcNo";
            this.mskTcNo.Size = new System.Drawing.Size(200, 23);
            this.mskTcNo.TabIndex = 3;
            this.mskTcNo.ValidatingType = typeof(int);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(30, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 23);
            this.label6.TabIndex = 2;
            this.label6.Text = "TC Kimlik No";
            // 
            // txtTelefon
            // 
            this.txtTelefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTelefon.Location = new System.Drawing.Point(120, 22);
            this.txtTelefon.Mask = "(9999) 000-0000";
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(200, 23);
            this.txtTelefon.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(30, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 23);
            this.label5.TabIndex = 0;
            this.label5.Text = "Telefon";
            // 
            // tabFinans
            // 
            this.tabFinans.Controls.Add(this.rtbNotlar);
            this.tabFinans.Controls.Add(this.label11);
            this.tabFinans.Controls.Add(this.txtToplamHarcama);
            this.tabFinans.Controls.Add(this.txtBorc);
            this.tabFinans.Controls.Add(this.label10);
            this.tabFinans.Controls.Add(this.label9);
            this.tabFinans.Location = new System.Drawing.Point(4, 22);
            this.tabFinans.Name = "tabFinans";
            this.tabFinans.Padding = new System.Windows.Forms.Padding(3);
            this.tabFinans.Size = new System.Drawing.Size(932, 139);
            this.tabFinans.TabIndex = 2;
            this.tabFinans.Text = "Finans/Not";
            this.tabFinans.UseVisualStyleBackColor = true;
            // 
            // rtbNotlar
            // 
            this.rtbNotlar.Location = new System.Drawing.Point(120, 67);
            this.rtbNotlar.Name = "rtbNotlar";
            this.rtbNotlar.Size = new System.Drawing.Size(498, 66);
            this.rtbNotlar.TabIndex = 3;
            this.rtbNotlar.Text = "";
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(30, 70);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 23);
            this.label11.TabIndex = 4;
            this.label11.Text = "Notlar";
            // 
            // txtToplamHarcama
            // 
            this.txtToplamHarcama.Location = new System.Drawing.Point(466, 22);
            this.txtToplamHarcama.Multiline = true;
            this.txtToplamHarcama.Name = "txtToplamHarcama";
            this.txtToplamHarcama.Size = new System.Drawing.Size(200, 25);
            this.txtToplamHarcama.TabIndex = 2;
            // 
            // txtBorc
            // 
            this.txtBorc.Location = new System.Drawing.Point(120, 22);
            this.txtBorc.Multiline = true;
            this.txtBorc.Name = "txtBorc";
            this.txtBorc.Size = new System.Drawing.Size(200, 25);
            this.txtBorc.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(360, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 23);
            this.label10.TabIndex = 2;
            this.label10.Text = "Toplam Harcama";
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(30, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 23);
            this.label9.TabIndex = 0;
            this.label9.Text = "Borç";
            // 
            // dgvMusteri
            // 
            this.dgvMusteri.AllowUserToAddRows = false;
            this.dgvMusteri.AllowUserToDeleteRows = false;
            this.dgvMusteri.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMusteri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMusteri.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMusteri.Location = new System.Drawing.Point(0, 260);
            this.dgvMusteri.Name = "dgvMusteri";
            this.dgvMusteri.ReadOnly = true;
            this.dgvMusteri.RowHeadersWidth = 18;
            this.dgvMusteri.Size = new System.Drawing.Size(984, 301);
            this.dgvMusteri.TabIndex = 1;
            this.dgvMusteri.TabStop = false;
            // 
            // FrmMusteri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.dgvMusteri);
            this.Controls.Add(this.grpMusteri);
            this.Name = "FrmMusteri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Müşteri Yönetimi";
            this.Load += new System.EventHandler(this.FrmMusteri_Load);
            this.grpMusteri.ResumeLayout(false);
            this.toolStripPersonel.ResumeLayout(false);
            this.toolStripPersonel.PerformLayout();
            this.tabMusteri.ResumeLayout(false);
            this.tabGenel.ResumeLayout(false);
            this.tabGenel.PerformLayout();
            this.tabIletisim.ResumeLayout(false);
            this.tabIletisim.PerformLayout();
            this.tabFinans.ResumeLayout(false);
            this.tabFinans.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMusteri)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpMusteri;
        private System.Windows.Forms.DataGridView dgvMusteri;
        private System.Windows.Forms.TabControl tabMusteri;
        private System.Windows.Forms.TabPage tabGenel;
        private System.Windows.Forms.TabPage tabIletisim;
        private System.Windows.Forms.TabPage tabFinans;
        private System.Windows.Forms.DateTimePicker dtSonGelisTarihi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtKayitTarihi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkAktif;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox txtTelefon;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox mskTcNo;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.RichTextBox rtbAdres;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox rtbNotlar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtToplamHarcama;
        private System.Windows.Forms.TextBox txtBorc;
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