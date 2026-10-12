
namespace PrimeSalon
{
    partial class FrmIzınPuantaj
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
            this.grpIzinPuantaj = new System.Windows.Forms.GroupBox();
            this.tabIzinPuantaj = new System.Windows.Forms.TabControl();
            this.tabGenel = new System.Windows.Forms.TabPage();
            this.chkUcretliMi = new System.Windows.Forms.CheckBox();
            this.cmbOnayDurumu = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbIslemTipi = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtTarih = new System.Windows.Forms.DateTimePicker();
            this.txtPersonelID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabSaatIzin = new System.Windows.Forms.TabPage();
            this.dtBaslangicSaat = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tabOnayNot = new System.Windows.Forms.TabPage();
            this.dgvIzinPuantaj = new System.Windows.Forms.DataGridView();
            this.dtBitisSaat = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.txtToplamSaat = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbIzinTuru = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtKesintiTutar = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtOnaylayan = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dtKayitTarihi = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.rtbAciklama = new System.Windows.Forms.RichTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.rtbNotlar = new System.Windows.Forms.RichTextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnListele = new System.Windows.Forms.Button();
            this.grpIzinPuantaj.SuspendLayout();
            this.tabIzinPuantaj.SuspendLayout();
            this.tabGenel.SuspendLayout();
            this.tabSaatIzin.SuspendLayout();
            this.tabOnayNot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIzinPuantaj)).BeginInit();
            this.SuspendLayout();
            // 
            // grpIzinPuantaj
            // 
            this.grpIzinPuantaj.Controls.Add(this.btnListele);
            this.grpIzinPuantaj.Controls.Add(this.btnSil);
            this.grpIzinPuantaj.Controls.Add(this.btnGuncelle);
            this.grpIzinPuantaj.Controls.Add(this.btnEkle);
            this.grpIzinPuantaj.Controls.Add(this.tabIzinPuantaj);
            this.grpIzinPuantaj.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpIzinPuantaj.Location = new System.Drawing.Point(0, 0);
            this.grpIzinPuantaj.Name = "grpIzinPuantaj";
            this.grpIzinPuantaj.Size = new System.Drawing.Size(1134, 280);
            this.grpIzinPuantaj.TabIndex = 0;
            this.grpIzinPuantaj.TabStop = false;
            this.grpIzinPuantaj.Text = "İzin / Puantaj Yönetimi";
            // 
            // tabIzinPuantaj
            // 
            this.tabIzinPuantaj.Controls.Add(this.tabGenel);
            this.tabIzinPuantaj.Controls.Add(this.tabSaatIzin);
            this.tabIzinPuantaj.Controls.Add(this.tabOnayNot);
            this.tabIzinPuantaj.Location = new System.Drawing.Point(20, 25);
            this.tabIzinPuantaj.Name = "tabIzinPuantaj";
            this.tabIzinPuantaj.SelectedIndex = 0;
            this.tabIzinPuantaj.Size = new System.Drawing.Size(1080, 190);
            this.tabIzinPuantaj.TabIndex = 0;
            // 
            // tabGenel
            // 
            this.tabGenel.Controls.Add(this.chkUcretliMi);
            this.tabGenel.Controls.Add(this.cmbOnayDurumu);
            this.tabGenel.Controls.Add(this.label4);
            this.tabGenel.Controls.Add(this.cmbIslemTipi);
            this.tabGenel.Controls.Add(this.label3);
            this.tabGenel.Controls.Add(this.label2);
            this.tabGenel.Controls.Add(this.dtTarih);
            this.tabGenel.Controls.Add(this.txtPersonelID);
            this.tabGenel.Controls.Add(this.label1);
            this.tabGenel.Location = new System.Drawing.Point(4, 22);
            this.tabGenel.Name = "tabGenel";
            this.tabGenel.Padding = new System.Windows.Forms.Padding(3);
            this.tabGenel.Size = new System.Drawing.Size(1072, 164);
            this.tabGenel.TabIndex = 0;
            this.tabGenel.Text = "Genel";
            this.tabGenel.UseVisualStyleBackColor = true;
            // 
            // chkUcretliMi
            // 
            this.chkUcretliMi.Location = new System.Drawing.Point(730, 25);
            this.chkUcretliMi.Name = "chkUcretliMi";
            this.chkUcretliMi.Size = new System.Drawing.Size(80, 25);
            this.chkUcretliMi.TabIndex = 9;
            this.chkUcretliMi.Text = "Ücretli";
            this.chkUcretliMi.UseVisualStyleBackColor = true;
            // 
            // cmbOnayDurumu
            // 
            this.cmbOnayDurumu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOnayDurumu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbOnayDurumu.FormattingEnabled = true;
            this.cmbOnayDurumu.Items.AddRange(new object[] {
            "Seçiniz",
            "Bekliyor",
            "Onaylandı",
            "Reddedildi"});
            this.cmbOnayDurumu.Location = new System.Drawing.Point(470, 67);
            this.cmbOnayDurumu.Name = "cmbOnayDurumu";
            this.cmbOnayDurumu.Size = new System.Drawing.Size(180, 25);
            this.cmbOnayDurumu.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(380, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Onay Durumu";
            // 
            // cmbIslemTipi
            // 
            this.cmbIslemTipi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIslemTipi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbIslemTipi.FormattingEnabled = true;
            this.cmbIslemTipi.Items.AddRange(new object[] {
            "Seçiniz",
            "Mesai",
            "İzin",
            "Rapor",
            "Tatil"});
            this.cmbIslemTipi.Location = new System.Drawing.Point(470, 22);
            this.cmbIslemTipi.Name = "cmbIslemTipi";
            this.cmbIslemTipi.Size = new System.Drawing.Size(180, 25);
            this.cmbIslemTipi.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(380, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "İşlem Tipi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tarih";
            // 
            // dtTarih
            // 
            this.dtTarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtTarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtTarih.Location = new System.Drawing.Point(120, 67);
            this.dtTarih.Name = "dtTarih";
            this.dtTarih.Size = new System.Drawing.Size(180, 23);
            this.dtTarih.TabIndex = 3;
            // 
            // txtPersonelID
            // 
            this.txtPersonelID.Location = new System.Drawing.Point(120, 22);
            this.txtPersonelID.Multiline = true;
            this.txtPersonelID.Name = "txtPersonelID";
            this.txtPersonelID.Size = new System.Drawing.Size(180, 25);
            this.txtPersonelID.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Personel ID";
            // 
            // tabSaatIzin
            // 
            this.tabSaatIzin.Controls.Add(this.txtKesintiTutar);
            this.tabSaatIzin.Controls.Add(this.label9);
            this.tabSaatIzin.Controls.Add(this.cmbIzinTuru);
            this.tabSaatIzin.Controls.Add(this.label8);
            this.tabSaatIzin.Controls.Add(this.txtToplamSaat);
            this.tabSaatIzin.Controls.Add(this.label7);
            this.tabSaatIzin.Controls.Add(this.dtBitisSaat);
            this.tabSaatIzin.Controls.Add(this.dtBaslangicSaat);
            this.tabSaatIzin.Controls.Add(this.label6);
            this.tabSaatIzin.Controls.Add(this.label5);
            this.tabSaatIzin.Location = new System.Drawing.Point(4, 22);
            this.tabSaatIzin.Name = "tabSaatIzin";
            this.tabSaatIzin.Padding = new System.Windows.Forms.Padding(3);
            this.tabSaatIzin.Size = new System.Drawing.Size(1072, 164);
            this.tabSaatIzin.TabIndex = 1;
            this.tabSaatIzin.Text = "Saat / İzin";
            this.tabSaatIzin.UseVisualStyleBackColor = true;
            // 
            // dtBaslangicSaat
            // 
            this.dtBaslangicSaat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtBaslangicSaat.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtBaslangicSaat.Location = new System.Drawing.Point(120, 22);
            this.dtBaslangicSaat.Name = "dtBaslangicSaat";
            this.dtBaslangicSaat.ShowUpDown = true;
            this.dtBaslangicSaat.Size = new System.Drawing.Size(180, 23);
            this.dtBaslangicSaat.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Bitiş";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Başlangıç";
            // 
            // tabOnayNot
            // 
            this.tabOnayNot.Controls.Add(this.rtbNotlar);
            this.tabOnayNot.Controls.Add(this.label13);
            this.tabOnayNot.Controls.Add(this.rtbAciklama);
            this.tabOnayNot.Controls.Add(this.label12);
            this.tabOnayNot.Controls.Add(this.dtKayitTarihi);
            this.tabOnayNot.Controls.Add(this.label11);
            this.tabOnayNot.Controls.Add(this.txtOnaylayan);
            this.tabOnayNot.Controls.Add(this.label10);
            this.tabOnayNot.Location = new System.Drawing.Point(4, 22);
            this.tabOnayNot.Name = "tabOnayNot";
            this.tabOnayNot.Padding = new System.Windows.Forms.Padding(3);
            this.tabOnayNot.Size = new System.Drawing.Size(1072, 164);
            this.tabOnayNot.TabIndex = 2;
            this.tabOnayNot.Text = "Onay / Not";
            this.tabOnayNot.UseVisualStyleBackColor = true;
            // 
            // dgvIzinPuantaj
            // 
            this.dgvIzinPuantaj.AllowUserToAddRows = false;
            this.dgvIzinPuantaj.AllowUserToDeleteRows = false;
            this.dgvIzinPuantaj.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvIzinPuantaj.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIzinPuantaj.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvIzinPuantaj.Location = new System.Drawing.Point(0, 280);
            this.dgvIzinPuantaj.MultiSelect = false;
            this.dgvIzinPuantaj.Name = "dgvIzinPuantaj";
            this.dgvIzinPuantaj.ReadOnly = true;
            this.dgvIzinPuantaj.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvIzinPuantaj.Size = new System.Drawing.Size(1134, 361);
            this.dgvIzinPuantaj.TabIndex = 1;
            // 
            // dtBitisSaat
            // 
            this.dtBitisSaat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtBitisSaat.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtBitisSaat.Location = new System.Drawing.Point(120, 67);
            this.dtBitisSaat.Name = "dtBitisSaat";
            this.dtBitisSaat.ShowUpDown = true;
            this.dtBitisSaat.Size = new System.Drawing.Size(180, 23);
            this.dtBitisSaat.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(380, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Toplam Saat";
            // 
            // txtToplamSaat
            // 
            this.txtToplamSaat.Location = new System.Drawing.Point(470, 22);
            this.txtToplamSaat.Multiline = true;
            this.txtToplamSaat.Name = "txtToplamSaat";
            this.txtToplamSaat.Size = new System.Drawing.Size(180, 25);
            this.txtToplamSaat.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(380, 70);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "İzin Türü";
            // 
            // cmbIzinTuru
            // 
            this.cmbIzinTuru.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIzinTuru.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbIzinTuru.FormattingEnabled = true;
            this.cmbIzinTuru.Items.AddRange(new object[] {
            "Seçiniz",
            "Yıllık İzin",
            "Mazeret İzni",
            "Hastalık İzni",
            "Ücretsiz İzin"});
            this.cmbIzinTuru.Location = new System.Drawing.Point(470, 67);
            this.cmbIzinTuru.Name = "cmbIzinTuru";
            this.cmbIzinTuru.Size = new System.Drawing.Size(180, 25);
            this.cmbIzinTuru.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(730, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "Kesinti";
            // 
            // txtKesintiTutar
            // 
            this.txtKesintiTutar.Location = new System.Drawing.Point(820, 22);
            this.txtKesintiTutar.Multiline = true;
            this.txtKesintiTutar.Name = "txtKesintiTutar";
            this.txtKesintiTutar.Size = new System.Drawing.Size(180, 25);
            this.txtKesintiTutar.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(30, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Onaylayan";
            // 
            // txtOnaylayan
            // 
            this.txtOnaylayan.Location = new System.Drawing.Point(120, 22);
            this.txtOnaylayan.Multiline = true;
            this.txtOnaylayan.Name = "txtOnaylayan";
            this.txtOnaylayan.Size = new System.Drawing.Size(220, 22);
            this.txtOnaylayan.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(380, 25);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "Kayıt Tarihi";
            // 
            // dtKayitTarihi
            // 
            this.dtKayitTarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtKayitTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtKayitTarihi.Location = new System.Drawing.Point(470, 22);
            this.dtKayitTarihi.Name = "dtKayitTarihi";
            this.dtKayitTarihi.Size = new System.Drawing.Size(180, 23);
            this.dtKayitTarihi.TabIndex = 3;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(30, 70);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(50, 13);
            this.label12.TabIndex = 4;
            this.label12.Text = "Açıklama";
            // 
            // rtbAciklama
            // 
            this.rtbAciklama.Location = new System.Drawing.Point(120, 70);
            this.rtbAciklama.Name = "rtbAciklama";
            this.rtbAciklama.Size = new System.Drawing.Size(420, 70);
            this.rtbAciklama.TabIndex = 5;
            this.rtbAciklama.Text = "";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(592, 73);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(35, 13);
            this.label13.TabIndex = 6;
            this.label13.Text = "Notlar";
            // 
            // rtbNotlar
            // 
            this.rtbNotlar.Location = new System.Drawing.Point(670, 70);
            this.rtbNotlar.Name = "rtbNotlar";
            this.rtbNotlar.Size = new System.Drawing.Size(330, 70);
            this.rtbNotlar.TabIndex = 7;
            this.rtbNotlar.Text = "";
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(380, 225);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(110, 35);
            this.btnEkle.TabIndex = 1;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(500, 225);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(110, 35);
            this.btnGuncelle.TabIndex = 1;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(620, 225);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(110, 35);
            this.btnSil.TabIndex = 1;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            // 
            // btnListele
            // 
            this.btnListele.Location = new System.Drawing.Point(740, 225);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(110, 35);
            this.btnListele.TabIndex = 1;
            this.btnListele.Text = "Listele";
            this.btnListele.UseVisualStyleBackColor = true;
            // 
            // FrmIzınPuantaj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 641);
            this.Controls.Add(this.dgvIzinPuantaj);
            this.Controls.Add(this.grpIzinPuantaj);
            this.Name = "FrmIzınPuantaj";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "İzin / Puantaj Yönetimi";
            this.Load += new System.EventHandler(this.FrmIzınPuantaj_Load);
            this.grpIzinPuantaj.ResumeLayout(false);
            this.tabIzinPuantaj.ResumeLayout(false);
            this.tabGenel.ResumeLayout(false);
            this.tabGenel.PerformLayout();
            this.tabSaatIzin.ResumeLayout(false);
            this.tabSaatIzin.PerformLayout();
            this.tabOnayNot.ResumeLayout(false);
            this.tabOnayNot.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIzinPuantaj)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpIzinPuantaj;
        private System.Windows.Forms.DataGridView dgvIzinPuantaj;
        private System.Windows.Forms.TabControl tabIzinPuantaj;
        private System.Windows.Forms.TabPage tabGenel;
        private System.Windows.Forms.DateTimePicker dtTarih;
        private System.Windows.Forms.TextBox txtPersonelID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabSaatIzin;
        private System.Windows.Forms.TabPage tabOnayNot;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbIslemTipi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbOnayDurumu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkUcretliMi;
        private System.Windows.Forms.DateTimePicker dtBaslangicSaat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbIzinTuru;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtToplamSaat;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtBitisSaat;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.TextBox txtKesintiTutar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RichTextBox rtbNotlar;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.RichTextBox rtbAciklama;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dtKayitTarihi;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtOnaylayan;
        private System.Windows.Forms.Label label10;
    }
}