
namespace PrimeSalon
{
    partial class FrmStokHareketleriSil
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
            this.panelStokSil = new System.Windows.Forms.Panel();
            this.btnSil = new System.Windows.Forms.Button();
            this.rtbAciklama = new System.Windows.Forms.RichTextBox();
            this.chkAktifMi = new System.Windows.Forms.CheckBox();
            this.cmbDepo = new System.Windows.Forms.ComboBox();
            this.cmbIslemTipi = new System.Windows.Forms.ComboBox();
            this.dtTarih = new System.Windows.Forms.DateTimePicker();
            this.txtKullanici = new System.Windows.Forms.TextBox();
            this.txtUrunID = new System.Windows.Forms.TextBox();
            this.txtMiktar = new System.Windows.Forms.TextBox();
            this.txtSonrakiStok = new System.Windows.Forms.TextBox();
            this.txtOncekiStok = new System.Windows.Forms.TextBox();
            this.txtToplamTutar = new System.Windows.Forms.TextBox();
            this.txtBirimFiyat = new System.Windows.Forms.TextBox();
            this.txtHareketID = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelStokSil.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelStokSil
            // 
            this.panelStokSil.BackColor = System.Drawing.Color.Lavender;
            this.panelStokSil.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelStokSil.Controls.Add(this.btnSil);
            this.panelStokSil.Controls.Add(this.rtbAciklama);
            this.panelStokSil.Controls.Add(this.chkAktifMi);
            this.panelStokSil.Controls.Add(this.cmbDepo);
            this.panelStokSil.Controls.Add(this.cmbIslemTipi);
            this.panelStokSil.Controls.Add(this.dtTarih);
            this.panelStokSil.Controls.Add(this.txtKullanici);
            this.panelStokSil.Controls.Add(this.txtUrunID);
            this.panelStokSil.Controls.Add(this.txtMiktar);
            this.panelStokSil.Controls.Add(this.txtSonrakiStok);
            this.panelStokSil.Controls.Add(this.txtOncekiStok);
            this.panelStokSil.Controls.Add(this.txtToplamTutar);
            this.panelStokSil.Controls.Add(this.txtBirimFiyat);
            this.panelStokSil.Controls.Add(this.txtHareketID);
            this.panelStokSil.Controls.Add(this.label13);
            this.panelStokSil.Controls.Add(this.label9);
            this.panelStokSil.Controls.Add(this.label8);
            this.panelStokSil.Controls.Add(this.label7);
            this.panelStokSil.Controls.Add(this.label6);
            this.panelStokSil.Controls.Add(this.label10);
            this.panelStokSil.Controls.Add(this.label5);
            this.panelStokSil.Controls.Add(this.label4);
            this.panelStokSil.Controls.Add(this.label12);
            this.panelStokSil.Controls.Add(this.label11);
            this.panelStokSil.Controls.Add(this.label3);
            this.panelStokSil.Controls.Add(this.label2);
            this.panelStokSil.Controls.Add(this.label1);
            this.panelStokSil.Location = new System.Drawing.Point(20, 20);
            this.panelStokSil.Name = "panelStokSil";
            this.panelStokSil.Size = new System.Drawing.Size(800, 520);
            this.panelStokSil.TabIndex = 0;
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(272, 436);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(280, 52);
            this.btnSil.TabIndex = 7;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // rtbAciklama
            // 
            this.rtbAciklama.Enabled = false;
            this.rtbAciklama.Location = new System.Drawing.Point(180, 330);
            this.rtbAciklama.Name = "rtbAciklama";
            this.rtbAciklama.Size = new System.Drawing.Size(560, 90);
            this.rtbAciklama.TabIndex = 6;
            this.rtbAciklama.Text = "";
            // 
            // chkAktifMi
            // 
            this.chkAktifMi.AutoSize = true;
            this.chkAktifMi.Enabled = false;
            this.chkAktifMi.Location = new System.Drawing.Point(430, 277);
            this.chkAktifMi.Name = "chkAktifMi";
            this.chkAktifMi.Size = new System.Drawing.Size(47, 17);
            this.chkAktifMi.TabIndex = 5;
            this.chkAktifMi.Text = "Aktif";
            this.chkAktifMi.UseVisualStyleBackColor = true;
            // 
            // cmbDepo
            // 
            this.cmbDepo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDepo.Enabled = false;
            this.cmbDepo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbDepo.FormattingEnabled = true;
            this.cmbDepo.Items.AddRange(new object[] {
            "Seçiniz",
            "Ana Depo",
            "Raf 1",
            "Raf 2",
            "Arka Oda"});
            this.cmbDepo.Location = new System.Drawing.Point(570, 227);
            this.cmbDepo.Name = "cmbDepo";
            this.cmbDepo.Size = new System.Drawing.Size(170, 25);
            this.cmbDepo.TabIndex = 4;
            // 
            // cmbIslemTipi
            // 
            this.cmbIslemTipi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIslemTipi.Enabled = false;
            this.cmbIslemTipi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbIslemTipi.FormattingEnabled = true;
            this.cmbIslemTipi.Items.AddRange(new object[] {
            "Seçiniz",
            "Giriş",
            "Çıkış",
            "Düzeltme"});
            this.cmbIslemTipi.Location = new System.Drawing.Point(180, 187);
            this.cmbIslemTipi.Name = "cmbIslemTipi";
            this.cmbIslemTipi.Size = new System.Drawing.Size(170, 25);
            this.cmbIslemTipi.TabIndex = 4;
            // 
            // dtTarih
            // 
            this.dtTarih.Enabled = false;
            this.dtTarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtTarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtTarih.Location = new System.Drawing.Point(180, 147);
            this.dtTarih.Name = "dtTarih";
            this.dtTarih.Size = new System.Drawing.Size(170, 23);
            this.dtTarih.TabIndex = 3;
            // 
            // txtKullanici
            // 
            this.txtKullanici.Enabled = false;
            this.txtKullanici.Location = new System.Drawing.Point(180, 277);
            this.txtKullanici.Multiline = true;
            this.txtKullanici.Name = "txtKullanici";
            this.txtKullanici.Size = new System.Drawing.Size(170, 25);
            this.txtKullanici.TabIndex = 2;
            // 
            // txtUrunID
            // 
            this.txtUrunID.Enabled = false;
            this.txtUrunID.Location = new System.Drawing.Point(180, 107);
            this.txtUrunID.Multiline = true;
            this.txtUrunID.Name = "txtUrunID";
            this.txtUrunID.Size = new System.Drawing.Size(170, 25);
            this.txtUrunID.TabIndex = 2;
            // 
            // txtMiktar
            // 
            this.txtMiktar.Enabled = false;
            this.txtMiktar.Location = new System.Drawing.Point(180, 230);
            this.txtMiktar.Multiline = true;
            this.txtMiktar.Name = "txtMiktar";
            this.txtMiktar.Size = new System.Drawing.Size(170, 25);
            this.txtMiktar.TabIndex = 2;
            // 
            // txtSonrakiStok
            // 
            this.txtSonrakiStok.Enabled = false;
            this.txtSonrakiStok.Location = new System.Drawing.Point(570, 187);
            this.txtSonrakiStok.Multiline = true;
            this.txtSonrakiStok.Name = "txtSonrakiStok";
            this.txtSonrakiStok.Size = new System.Drawing.Size(170, 25);
            this.txtSonrakiStok.TabIndex = 2;
            // 
            // txtOncekiStok
            // 
            this.txtOncekiStok.Enabled = false;
            this.txtOncekiStok.Location = new System.Drawing.Point(570, 147);
            this.txtOncekiStok.Multiline = true;
            this.txtOncekiStok.Name = "txtOncekiStok";
            this.txtOncekiStok.Size = new System.Drawing.Size(170, 25);
            this.txtOncekiStok.TabIndex = 2;
            // 
            // txtToplamTutar
            // 
            this.txtToplamTutar.Enabled = false;
            this.txtToplamTutar.Location = new System.Drawing.Point(570, 107);
            this.txtToplamTutar.Multiline = true;
            this.txtToplamTutar.Name = "txtToplamTutar";
            this.txtToplamTutar.Size = new System.Drawing.Size(170, 25);
            this.txtToplamTutar.TabIndex = 2;
            // 
            // txtBirimFiyat
            // 
            this.txtBirimFiyat.Enabled = false;
            this.txtBirimFiyat.Location = new System.Drawing.Point(570, 67);
            this.txtBirimFiyat.Multiline = true;
            this.txtBirimFiyat.Name = "txtBirimFiyat";
            this.txtBirimFiyat.Size = new System.Drawing.Size(170, 25);
            this.txtBirimFiyat.TabIndex = 2;
            // 
            // txtHareketID
            // 
            this.txtHareketID.Enabled = false;
            this.txtHareketID.Location = new System.Drawing.Point(180, 67);
            this.txtHareketID.Multiline = true;
            this.txtHareketID.Name = "txtHareketID";
            this.txtHareketID.Size = new System.Drawing.Size(170, 25);
            this.txtHareketID.TabIndex = 2;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(40, 233);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(36, 13);
            this.label13.TabIndex = 1;
            this.label13.Text = "Miktar";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(430, 190);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Sonraki Stok";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(430, 150);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Önceki Stok";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(430, 110);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Toplam Tutar";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(430, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Birim Fiyat";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(430, 230);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(33, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Depo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "İşlem Tipi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Tarih";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(40, 332);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(50, 13);
            this.label12.TabIndex = 1;
            this.label12.Text = "Açıklama";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(40, 280);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "Ürün ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Ürün ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hareket ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(256, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Silinecek Stok Hareketleri Bilgileri";
            // 
            // FrmStokHareketleriSil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 561);
            this.Controls.Add(this.panelStokSil);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmStokHareketleriSil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stok Hareketleri Kayıt Sil";
            this.panelStokSil.ResumeLayout(false);
            this.panelStokSil.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelStokSil;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Label label12;
        public System.Windows.Forms.ComboBox cmbDepo;
        public System.Windows.Forms.ComboBox cmbIslemTipi;
        public System.Windows.Forms.DateTimePicker dtTarih;
        public System.Windows.Forms.TextBox txtUrunID;
        public System.Windows.Forms.TextBox txtSonrakiStok;
        public System.Windows.Forms.TextBox txtOncekiStok;
        public System.Windows.Forms.TextBox txtToplamTutar;
        public System.Windows.Forms.TextBox txtBirimFiyat;
        public System.Windows.Forms.TextBox txtHareketID;
        public System.Windows.Forms.CheckBox chkAktifMi;
        public System.Windows.Forms.TextBox txtKullanici;
        public System.Windows.Forms.RichTextBox rtbAciklama;
        private System.Windows.Forms.Label label13;
        public System.Windows.Forms.TextBox txtMiktar;
    }
}