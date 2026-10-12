
namespace PrimeSalon
{
    partial class FrmRandevu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRandevu));
            this.grpRandevu = new System.Windows.Forms.GroupBox();
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
            this.tabRandevu = new System.Windows.Forms.TabControl();
            this.tabGenel = new System.Windows.Forms.TabPage();
            this.dtRandevuSaat = new System.Windows.Forms.DateTimePicker();
            this.dtRandevuTarih = new System.Windows.Forms.DateTimePicker();
            this.txtPersonelID = new System.Windows.Forms.TextBox();
            this.txtSureDakika = new System.Windows.Forms.TextBox();
            this.txtMusteriID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabTutar = new System.Windows.Forms.TabPage();
            this.lblYildizOdemeDurumu = new System.Windows.Forms.Label();
            this.dtOlusturmaTarihi = new System.Windows.Forms.DateTimePicker();
            this.cmbOdemeDurumu = new System.Windows.Forms.ComboBox();
            this.txtToplamTutar = new System.Windows.Forms.TextBox();
            this.txtIndirimMiktar = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tabNot = new System.Windows.Forms.TabPage();
            this.lblYildizDurum = new System.Windows.Forms.Label();
            this.rtbNotlar = new System.Windows.Forms.RichTextBox();
            this.cmbDurum = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dgvRandevu = new System.Windows.Forms.DataGridView();
            this.grpRandevu.SuspendLayout();
            this.toolStripPersonel.SuspendLayout();
            this.tabRandevu.SuspendLayout();
            this.tabGenel.SuspendLayout();
            this.tabTutar.SuspendLayout();
            this.tabNot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRandevu)).BeginInit();
            this.SuspendLayout();
            // 
            // grpRandevu
            // 
            this.grpRandevu.Controls.Add(this.toolStripPersonel);
            this.grpRandevu.Controls.Add(this.tabRandevu);
            this.grpRandevu.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpRandevu.Location = new System.Drawing.Point(0, 0);
            this.grpRandevu.Name = "grpRandevu";
            this.grpRandevu.Size = new System.Drawing.Size(1134, 280);
            this.grpRandevu.TabIndex = 0;
            this.grpRandevu.TabStop = false;
            this.grpRandevu.Text = "Randevu Bilgileri";
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
            this.toolStripPersonel.TabIndex = 22;
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
            // tabRandevu
            // 
            this.tabRandevu.Controls.Add(this.tabGenel);
            this.tabRandevu.Controls.Add(this.tabTutar);
            this.tabRandevu.Controls.Add(this.tabNot);
            this.tabRandevu.Location = new System.Drawing.Point(20, 60);
            this.tabRandevu.Name = "tabRandevu";
            this.tabRandevu.SelectedIndex = 0;
            this.tabRandevu.Size = new System.Drawing.Size(1080, 190);
            this.tabRandevu.TabIndex = 0;
            this.tabRandevu.TabStop = false;
            // 
            // tabGenel
            // 
            this.tabGenel.Controls.Add(this.dtRandevuSaat);
            this.tabGenel.Controls.Add(this.dtRandevuTarih);
            this.tabGenel.Controls.Add(this.txtPersonelID);
            this.tabGenel.Controls.Add(this.txtSureDakika);
            this.tabGenel.Controls.Add(this.txtMusteriID);
            this.tabGenel.Controls.Add(this.label5);
            this.tabGenel.Controls.Add(this.label4);
            this.tabGenel.Controls.Add(this.label3);
            this.tabGenel.Controls.Add(this.label2);
            this.tabGenel.Controls.Add(this.label1);
            this.tabGenel.Location = new System.Drawing.Point(4, 22);
            this.tabGenel.Name = "tabGenel";
            this.tabGenel.Padding = new System.Windows.Forms.Padding(3);
            this.tabGenel.Size = new System.Drawing.Size(1072, 164);
            this.tabGenel.TabIndex = 0;
            this.tabGenel.Text = "Genel";
            this.tabGenel.UseVisualStyleBackColor = true;
            // 
            // dtRandevuSaat
            // 
            this.dtRandevuSaat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtRandevuSaat.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtRandevuSaat.Location = new System.Drawing.Point(470, 67);
            this.dtRandevuSaat.Name = "dtRandevuSaat";
            this.dtRandevuSaat.ShowUpDown = true;
            this.dtRandevuSaat.Size = new System.Drawing.Size(180, 23);
            this.dtRandevuSaat.TabIndex = 5;
            // 
            // dtRandevuTarih
            // 
            this.dtRandevuTarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtRandevuTarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtRandevuTarih.Location = new System.Drawing.Point(470, 22);
            this.dtRandevuTarih.Name = "dtRandevuTarih";
            this.dtRandevuTarih.Size = new System.Drawing.Size(180, 23);
            this.dtRandevuTarih.TabIndex = 2;
            // 
            // txtPersonelID
            // 
            this.txtPersonelID.Location = new System.Drawing.Point(120, 67);
            this.txtPersonelID.Multiline = true;
            this.txtPersonelID.Name = "txtPersonelID";
            this.txtPersonelID.Size = new System.Drawing.Size(180, 25);
            this.txtPersonelID.TabIndex = 4;
            // 
            // txtSureDakika
            // 
            this.txtSureDakika.Location = new System.Drawing.Point(820, 22);
            this.txtSureDakika.Multiline = true;
            this.txtSureDakika.Name = "txtSureDakika";
            this.txtSureDakika.Size = new System.Drawing.Size(180, 25);
            this.txtSureDakika.TabIndex = 3;
            // 
            // txtMusteriID
            // 
            this.txtMusteriID.Location = new System.Drawing.Point(120, 22);
            this.txtMusteriID.Multiline = true;
            this.txtMusteriID.Name = "txtMusteriID";
            this.txtMusteriID.Size = new System.Drawing.Size(180, 25);
            this.txtMusteriID.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(730, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Süre (dk)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(380, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Saat";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(380, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tarih";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Personel ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Müşteri ID";
            // 
            // tabTutar
            // 
            this.tabTutar.Controls.Add(this.lblYildizOdemeDurumu);
            this.tabTutar.Controls.Add(this.dtOlusturmaTarihi);
            this.tabTutar.Controls.Add(this.cmbOdemeDurumu);
            this.tabTutar.Controls.Add(this.txtToplamTutar);
            this.tabTutar.Controls.Add(this.txtIndirimMiktar);
            this.tabTutar.Controls.Add(this.label9);
            this.tabTutar.Controls.Add(this.label8);
            this.tabTutar.Controls.Add(this.label7);
            this.tabTutar.Controls.Add(this.label6);
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
            this.lblYildizOdemeDurumu.Location = new System.Drawing.Point(666, 22);
            this.lblYildizOdemeDurumu.Name = "lblYildizOdemeDurumu";
            this.lblYildizOdemeDurumu.Size = new System.Drawing.Size(14, 17);
            this.lblYildizOdemeDurumu.TabIndex = 20;
            this.lblYildizOdemeDurumu.Text = "*";
            this.lblYildizOdemeDurumu.Visible = false;
            // 
            // dtOlusturmaTarihi
            // 
            this.dtOlusturmaTarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtOlusturmaTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtOlusturmaTarihi.Location = new System.Drawing.Point(480, 67);
            this.dtOlusturmaTarihi.Name = "dtOlusturmaTarihi";
            this.dtOlusturmaTarihi.Size = new System.Drawing.Size(180, 23);
            this.dtOlusturmaTarihi.TabIndex = 4;
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
            "Kısmi Ödeme"});
            this.cmbOdemeDurumu.Location = new System.Drawing.Point(480, 22);
            this.cmbOdemeDurumu.Name = "cmbOdemeDurumu";
            this.cmbOdemeDurumu.Size = new System.Drawing.Size(180, 25);
            this.cmbOdemeDurumu.TabIndex = 2;
            // 
            // txtToplamTutar
            // 
            this.txtToplamTutar.Location = new System.Drawing.Point(120, 67);
            this.txtToplamTutar.Multiline = true;
            this.txtToplamTutar.Name = "txtToplamTutar";
            this.txtToplamTutar.Size = new System.Drawing.Size(180, 25);
            this.txtToplamTutar.TabIndex = 3;
            // 
            // txtIndirimMiktar
            // 
            this.txtIndirimMiktar.Location = new System.Drawing.Point(120, 22);
            this.txtIndirimMiktar.Multiline = true;
            this.txtIndirimMiktar.Name = "txtIndirimMiktar";
            this.txtIndirimMiktar.Size = new System.Drawing.Size(180, 25);
            this.txtIndirimMiktar.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(380, 70);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Oluşturma Tarihi";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(380, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Ödeme Durumu";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Toplam Tutar";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "İndirim";
            // 
            // tabNot
            // 
            this.tabNot.Controls.Add(this.lblYildizDurum);
            this.tabNot.Controls.Add(this.rtbNotlar);
            this.tabNot.Controls.Add(this.cmbDurum);
            this.tabNot.Controls.Add(this.label11);
            this.tabNot.Controls.Add(this.label10);
            this.tabNot.Location = new System.Drawing.Point(4, 22);
            this.tabNot.Name = "tabNot";
            this.tabNot.Padding = new System.Windows.Forms.Padding(3);
            this.tabNot.Size = new System.Drawing.Size(1072, 164);
            this.tabNot.TabIndex = 2;
            this.tabNot.Text = "Durum / Not";
            this.tabNot.UseVisualStyleBackColor = true;
            // 
            // lblYildizDurum
            // 
            this.lblYildizDurum.AutoSize = true;
            this.lblYildizDurum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYildizDurum.ForeColor = System.Drawing.Color.Red;
            this.lblYildizDurum.Location = new System.Drawing.Point(306, 21);
            this.lblYildizDurum.Name = "lblYildizDurum";
            this.lblYildizDurum.Size = new System.Drawing.Size(14, 17);
            this.lblYildizDurum.TabIndex = 21;
            this.lblYildizDurum.Text = "*";
            this.lblYildizDurum.Visible = false;
            // 
            // rtbNotlar
            // 
            this.rtbNotlar.Location = new System.Drawing.Point(120, 70);
            this.rtbNotlar.Name = "rtbNotlar";
            this.rtbNotlar.Size = new System.Drawing.Size(700, 80);
            this.rtbNotlar.TabIndex = 2;
            this.rtbNotlar.Text = "";
            // 
            // cmbDurum
            // 
            this.cmbDurum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDurum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbDurum.FormattingEnabled = true;
            this.cmbDurum.Items.AddRange(new object[] {
            "Seçiniz",
            "Bekliyor",
            "Tamamlandı",
            "İptal",
            "Gelmedi"});
            this.cmbDurum.Location = new System.Drawing.Point(120, 22);
            this.cmbDurum.Name = "cmbDurum";
            this.cmbDurum.Size = new System.Drawing.Size(180, 25);
            this.cmbDurum.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(30, 70);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Notlar";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(30, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Durum";
            // 
            // dgvRandevu
            // 
            this.dgvRandevu.AllowUserToAddRows = false;
            this.dgvRandevu.AllowUserToDeleteRows = false;
            this.dgvRandevu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRandevu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRandevu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRandevu.Location = new System.Drawing.Point(0, 280);
            this.dgvRandevu.MultiSelect = false;
            this.dgvRandevu.Name = "dgvRandevu";
            this.dgvRandevu.ReadOnly = true;
            this.dgvRandevu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRandevu.Size = new System.Drawing.Size(1134, 361);
            this.dgvRandevu.TabIndex = 1;
            this.dgvRandevu.TabStop = false;
            // 
            // FrmRandevu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 641);
            this.Controls.Add(this.dgvRandevu);
            this.Controls.Add(this.grpRandevu);
            this.Name = "FrmRandevu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Randevu Yönetimi";
            this.Load += new System.EventHandler(this.FrmRandevu_Load);
            this.grpRandevu.ResumeLayout(false);
            this.toolStripPersonel.ResumeLayout(false);
            this.toolStripPersonel.PerformLayout();
            this.tabRandevu.ResumeLayout(false);
            this.tabGenel.ResumeLayout(false);
            this.tabGenel.PerformLayout();
            this.tabTutar.ResumeLayout(false);
            this.tabTutar.PerformLayout();
            this.tabNot.ResumeLayout(false);
            this.tabNot.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRandevu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpRandevu;
        private System.Windows.Forms.DataGridView dgvRandevu;
        private System.Windows.Forms.TabControl tabRandevu;
        private System.Windows.Forms.TabPage tabGenel;
        private System.Windows.Forms.DateTimePicker dtRandevuSaat;
        private System.Windows.Forms.DateTimePicker dtRandevuTarih;
        private System.Windows.Forms.TextBox txtPersonelID;
        private System.Windows.Forms.TextBox txtSureDakika;
        private System.Windows.Forms.TextBox txtMusteriID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabTutar;
        private System.Windows.Forms.TextBox txtToplamTutar;
        private System.Windows.Forms.TextBox txtIndirimMiktar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabPage tabNot;
        private System.Windows.Forms.ComboBox cmbOdemeDurumu;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtOlusturmaTarihi;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbDurum;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RichTextBox rtbNotlar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblYildizOdemeDurumu;
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
    }
}