
namespace PrimeSalon
{
    partial class FrmHizmet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHizmet));
            this.grpHizmet = new System.Windows.Forms.GroupBox();
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
            this.lblYildizKategori = new System.Windows.Forms.Label();
            this.rtbAciklama = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbKategori = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chkAktif = new System.Windows.Forms.CheckBox();
            this.txtUcret = new System.Windows.Forms.TextBox();
            this.lblUcret = new System.Windows.Forms.Label();
            this.txtSureDakika = new System.Windows.Forms.TextBox();
            this.lblSüre = new System.Windows.Forms.Label();
            this.txtHizmetAdi = new System.Windows.Forms.TextBox();
            this.lblHizmetAdi = new System.Windows.Forms.Label();
            this.dgvHizmet = new System.Windows.Forms.DataGridView();
            this.tsbtnTanimlamalar = new System.Windows.Forms.ToolStripButton();
            this.grpHizmet.SuspendLayout();
            this.toolStripPersonel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHizmet)).BeginInit();
            this.SuspendLayout();
            // 
            // grpHizmet
            // 
            this.grpHizmet.Controls.Add(this.toolStripPersonel);
            this.grpHizmet.Controls.Add(this.lblYildizKategori);
            this.grpHizmet.Controls.Add(this.rtbAciklama);
            this.grpHizmet.Controls.Add(this.label2);
            this.grpHizmet.Controls.Add(this.cmbKategori);
            this.grpHizmet.Controls.Add(this.label1);
            this.grpHizmet.Controls.Add(this.chkAktif);
            this.grpHizmet.Controls.Add(this.txtUcret);
            this.grpHizmet.Controls.Add(this.lblUcret);
            this.grpHizmet.Controls.Add(this.txtSureDakika);
            this.grpHizmet.Controls.Add(this.lblSüre);
            this.grpHizmet.Controls.Add(this.txtHizmetAdi);
            this.grpHizmet.Controls.Add(this.lblHizmetAdi);
            this.grpHizmet.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpHizmet.Location = new System.Drawing.Point(0, 0);
            this.grpHizmet.Name = "grpHizmet";
            this.grpHizmet.Size = new System.Drawing.Size(984, 200);
            this.grpHizmet.TabIndex = 1;
            this.grpHizmet.TabStop = false;
            this.grpHizmet.Text = "Hizmet Bilgileri";
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
            this.toolStripPersonel.TabIndex = 13;
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
            // lblYildizKategori
            // 
            this.lblYildizKategori.AutoSize = true;
            this.lblYildizKategori.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYildizKategori.ForeColor = System.Drawing.Color.Red;
            this.lblYildizKategori.Location = new System.Drawing.Point(625, 116);
            this.lblYildizKategori.Name = "lblYildizKategori";
            this.lblYildizKategori.Size = new System.Drawing.Size(14, 17);
            this.lblYildizKategori.TabIndex = 12;
            this.lblYildizKategori.Text = "*";
            this.lblYildizKategori.Visible = false;
            // 
            // rtbAciklama
            // 
            this.rtbAciklama.Location = new System.Drawing.Point(739, 71);
            this.rtbAciklama.Name = "rtbAciklama";
            this.rtbAciklama.Size = new System.Drawing.Size(220, 70);
            this.rtbAciklama.TabIndex = 3;
            this.rtbAciklama.Text = "";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(680, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 23);
            this.label2.TabIndex = 10;
            this.label2.Text = "Açıklama";
            // 
            // cmbKategori
            // 
            this.cmbKategori.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKategori.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbKategori.FormattingEnabled = true;
            this.cmbKategori.Items.AddRange(new object[] {
            "Seçiniz",
            "Saç Kesim ve Şekillendirme",
            "Sakal ve Bıyık İşlemleri",
            "Yıkama ve Fön İşlemleri",
            "Cilt ve Yüz Bakımı",
            "Saç ve Sakal Boyama",
            "Özel Saç Bakımları",
            "Ağda ve Epilasyon İşlemleri",
            "Çocuk Tıraşı",
            "Damat Tıraşı",
            "Masaj ve Rahatlama"});
            this.cmbKategori.Location = new System.Drawing.Point(439, 116);
            this.cmbKategori.Name = "cmbKategori";
            this.cmbKategori.Size = new System.Drawing.Size(180, 24);
            this.cmbKategori.TabIndex = 5;
            this.cmbKategori.SelectedIndexChanged += new System.EventHandler(this.cmbKategori_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(349, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 23);
            this.label1.TabIndex = 8;
            this.label1.Text = "Kategori";
            // 
            // chkAktif
            // 
            this.chkAktif.Location = new System.Drawing.Point(853, 147);
            this.chkAktif.Name = "chkAktif";
            this.chkAktif.Size = new System.Drawing.Size(80, 25);
            this.chkAktif.TabIndex = 6;
            this.chkAktif.Text = "Aktif";
            this.chkAktif.UseVisualStyleBackColor = true;
            // 
            // txtUcret
            // 
            this.txtUcret.Location = new System.Drawing.Point(493, 68);
            this.txtUcret.Multiline = true;
            this.txtUcret.Name = "txtUcret";
            this.txtUcret.Size = new System.Drawing.Size(120, 25);
            this.txtUcret.TabIndex = 2;
            // 
            // lblUcret
            // 
            this.lblUcret.Location = new System.Drawing.Point(439, 71);
            this.lblUcret.Name = "lblUcret";
            this.lblUcret.Size = new System.Drawing.Size(80, 23);
            this.lblUcret.TabIndex = 4;
            this.lblUcret.Text = "Ücret";
            // 
            // txtSureDakika
            // 
            this.txtSureDakika.Location = new System.Drawing.Point(129, 116);
            this.txtSureDakika.Multiline = true;
            this.txtSureDakika.Name = "txtSureDakika";
            this.txtSureDakika.Size = new System.Drawing.Size(120, 25);
            this.txtSureDakika.TabIndex = 4;
            // 
            // lblSüre
            // 
            this.lblSüre.Location = new System.Drawing.Point(39, 118);
            this.lblSüre.Name = "lblSüre";
            this.lblSüre.Size = new System.Drawing.Size(80, 23);
            this.lblSüre.TabIndex = 2;
            this.lblSüre.Text = "Süre(dk)";
            // 
            // txtHizmetAdi
            // 
            this.txtHizmetAdi.Location = new System.Drawing.Point(129, 71);
            this.txtHizmetAdi.Multiline = true;
            this.txtHizmetAdi.Name = "txtHizmetAdi";
            this.txtHizmetAdi.Size = new System.Drawing.Size(250, 25);
            this.txtHizmetAdi.TabIndex = 1;
            // 
            // lblHizmetAdi
            // 
            this.lblHizmetAdi.Location = new System.Drawing.Point(39, 73);
            this.lblHizmetAdi.Name = "lblHizmetAdi";
            this.lblHizmetAdi.Size = new System.Drawing.Size(80, 23);
            this.lblHizmetAdi.TabIndex = 0;
            this.lblHizmetAdi.Text = "Hizmet Adı";
            // 
            // dgvHizmet
            // 
            this.dgvHizmet.AllowUserToAddRows = false;
            this.dgvHizmet.AllowUserToDeleteRows = false;
            this.dgvHizmet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHizmet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHizmet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHizmet.Location = new System.Drawing.Point(0, 200);
            this.dgvHizmet.MultiSelect = false;
            this.dgvHizmet.Name = "dgvHizmet";
            this.dgvHizmet.ReadOnly = true;
            this.dgvHizmet.RowHeadersWidth = 25;
            this.dgvHizmet.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHizmet.Size = new System.Drawing.Size(984, 361);
            this.dgvHizmet.TabIndex = 0;
            this.dgvHizmet.TabStop = false;
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
            // FrmHizmet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.dgvHizmet);
            this.Controls.Add(this.grpHizmet);
            this.Name = "FrmHizmet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hizmet Yönetimi";
            this.Load += new System.EventHandler(this.FrmHizmet_Load);
            this.grpHizmet.ResumeLayout(false);
            this.grpHizmet.PerformLayout();
            this.toolStripPersonel.ResumeLayout(false);
            this.toolStripPersonel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHizmet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpHizmet;
        private System.Windows.Forms.DataGridView dgvHizmet;
        private System.Windows.Forms.TextBox txtUcret;
        private System.Windows.Forms.Label lblUcret;
        private System.Windows.Forms.TextBox txtSureDakika;
        private System.Windows.Forms.Label lblSüre;
        private System.Windows.Forms.TextBox txtHizmetAdi;
        private System.Windows.Forms.Label lblHizmetAdi;
        private System.Windows.Forms.CheckBox chkAktif;
        private System.Windows.Forms.ComboBox cmbKategori;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox rtbAciklama;
        private System.Windows.Forms.Label lblYildizKategori;
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