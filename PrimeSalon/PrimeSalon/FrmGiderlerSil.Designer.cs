
namespace PrimeSalon
{
    partial class FrmGiderlerSil
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
            this.panelBaslik = new System.Windows.Forms.Panel();
            this.lblBaslik = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFirma = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtTarih = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbGiderTuru = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTutar = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbOdemeTipi = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtGiderID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtKdvTutar = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dtKayitTarihi = new System.Windows.Forms.DateTimePicker();
            this.chkAktif = new System.Windows.Forms.CheckBox();
            this.chkTekrarlayanMi = new System.Windows.Forms.CheckBox();
            this.rtbAciklama = new System.Windows.Forms.RichTextBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.panelBaslik.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBaslik
            // 
            this.panelBaslik.BackColor = System.Drawing.Color.Lavender;
            this.panelBaslik.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBaslik.Controls.Add(this.btnSil);
            this.panelBaslik.Controls.Add(this.rtbAciklama);
            this.panelBaslik.Controls.Add(this.chkTekrarlayanMi);
            this.panelBaslik.Controls.Add(this.chkAktif);
            this.panelBaslik.Controls.Add(this.cmbOdemeTipi);
            this.panelBaslik.Controls.Add(this.cmbGiderTuru);
            this.panelBaslik.Controls.Add(this.dtKayitTarihi);
            this.panelBaslik.Controls.Add(this.dtTarih);
            this.panelBaslik.Controls.Add(this.txtTutar);
            this.panelBaslik.Controls.Add(this.txtGiderID);
            this.panelBaslik.Controls.Add(this.txtKdvTutar);
            this.panelBaslik.Controls.Add(this.txtFirma);
            this.panelBaslik.Controls.Add(this.label8);
            this.panelBaslik.Controls.Add(this.label7);
            this.panelBaslik.Controls.Add(this.label6);
            this.panelBaslik.Controls.Add(this.label5);
            this.panelBaslik.Controls.Add(this.label4);
            this.panelBaslik.Controls.Add(this.label3);
            this.panelBaslik.Controls.Add(this.label2);
            this.panelBaslik.Controls.Add(this.label1);
            this.panelBaslik.Controls.Add(this.lblBaslik);
            this.panelBaslik.Location = new System.Drawing.Point(20, 20);
            this.panelBaslik.Name = "panelBaslik";
            this.panelBaslik.Size = new System.Drawing.Size(760, 480);
            this.panelBaslik.TabIndex = 0;
            // 
            // lblBaslik
            // 
            this.lblBaslik.AutoSize = true;
            this.lblBaslik.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBaslik.Location = new System.Drawing.Point(285, 13);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(193, 20);
            this.lblBaslik.TabIndex = 0;
            this.lblBaslik.Text = "Silinecek Gider Bilgileri";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Gider ID";
            // 
            // txtFirma
            // 
            this.txtFirma.Enabled = false;
            this.txtFirma.Location = new System.Drawing.Point(540, 67);
            this.txtFirma.Multiline = true;
            this.txtFirma.Name = "txtFirma";
            this.txtFirma.Size = new System.Drawing.Size(170, 25);
            this.txtFirma.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tarih";
            // 
            // dtTarih
            // 
            this.dtTarih.Enabled = false;
            this.dtTarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtTarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtTarih.Location = new System.Drawing.Point(170, 107);
            this.dtTarih.Name = "dtTarih";
            this.dtTarih.Size = new System.Drawing.Size(170, 23);
            this.dtTarih.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Gider Türü";
            // 
            // cmbGiderTuru
            // 
            this.cmbGiderTuru.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGiderTuru.Enabled = false;
            this.cmbGiderTuru.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbGiderTuru.FormattingEnabled = true;
            this.cmbGiderTuru.Items.AddRange(new object[] {
            "Seçiniz",
            "Kira",
            "Elektrik",
            "Su",
            "Internet",
            "Sarf Malzeme",
            "Personel Maaşı",
            "Temizlik",
            "Vergi",
            "Diğer"});
            this.cmbGiderTuru.Location = new System.Drawing.Point(170, 147);
            this.cmbGiderTuru.Name = "cmbGiderTuru";
            this.cmbGiderTuru.Size = new System.Drawing.Size(170, 25);
            this.cmbGiderTuru.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Tutar";
            // 
            // txtTutar
            // 
            this.txtTutar.Enabled = false;
            this.txtTutar.Location = new System.Drawing.Point(170, 187);
            this.txtTutar.Multiline = true;
            this.txtTutar.Name = "txtTutar";
            this.txtTutar.Size = new System.Drawing.Size(170, 25);
            this.txtTutar.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Ödeme Tipi";
            // 
            // cmbOdemeTipi
            // 
            this.cmbOdemeTipi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOdemeTipi.Enabled = false;
            this.cmbOdemeTipi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbOdemeTipi.FormattingEnabled = true;
            this.cmbOdemeTipi.Items.AddRange(new object[] {
            "Seçiniz",
            "Nakit",
            "Kart",
            "Havale"});
            this.cmbOdemeTipi.Location = new System.Drawing.Point(170, 224);
            this.cmbOdemeTipi.Name = "cmbOdemeTipi";
            this.cmbOdemeTipi.Size = new System.Drawing.Size(170, 25);
            this.cmbOdemeTipi.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(410, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Firma";
            // 
            // txtGiderID
            // 
            this.txtGiderID.Enabled = false;
            this.txtGiderID.Location = new System.Drawing.Point(170, 67);
            this.txtGiderID.Multiline = true;
            this.txtGiderID.Name = "txtGiderID";
            this.txtGiderID.Size = new System.Drawing.Size(170, 25);
            this.txtGiderID.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(410, 110);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "KDV Tutar";
            // 
            // txtKdvTutar
            // 
            this.txtKdvTutar.Enabled = false;
            this.txtKdvTutar.Location = new System.Drawing.Point(540, 107);
            this.txtKdvTutar.Multiline = true;
            this.txtKdvTutar.Name = "txtKdvTutar";
            this.txtKdvTutar.Size = new System.Drawing.Size(170, 25);
            this.txtKdvTutar.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(40, 294);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Açıklama";
            // 
            // dtKayitTarihi
            // 
            this.dtKayitTarihi.Enabled = false;
            this.dtKayitTarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtKayitTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtKayitTarihi.Location = new System.Drawing.Point(540, 147);
            this.dtKayitTarihi.Name = "dtKayitTarihi";
            this.dtKayitTarihi.Size = new System.Drawing.Size(170, 23);
            this.dtKayitTarihi.TabIndex = 3;
            // 
            // chkAktif
            // 
            this.chkAktif.AutoSize = true;
            this.chkAktif.Enabled = false;
            this.chkAktif.Location = new System.Drawing.Point(540, 187);
            this.chkAktif.Name = "chkAktif";
            this.chkAktif.Size = new System.Drawing.Size(47, 17);
            this.chkAktif.TabIndex = 5;
            this.chkAktif.Text = "Aktif";
            this.chkAktif.UseVisualStyleBackColor = true;
            // 
            // chkTekrarlayanMi
            // 
            this.chkTekrarlayanMi.AutoSize = true;
            this.chkTekrarlayanMi.Enabled = false;
            this.chkTekrarlayanMi.Location = new System.Drawing.Point(540, 227);
            this.chkTekrarlayanMi.Name = "chkTekrarlayanMi";
            this.chkTekrarlayanMi.Size = new System.Drawing.Size(82, 17);
            this.chkTekrarlayanMi.TabIndex = 5;
            this.chkTekrarlayanMi.Text = "Tekrarlayan";
            this.chkTekrarlayanMi.UseVisualStyleBackColor = true;
            // 
            // rtbAciklama
            // 
            this.rtbAciklama.Enabled = false;
            this.rtbAciklama.Location = new System.Drawing.Point(170, 294);
            this.rtbAciklama.Name = "rtbAciklama";
            this.rtbAciklama.Size = new System.Drawing.Size(540, 90);
            this.rtbAciklama.TabIndex = 6;
            this.rtbAciklama.Text = "";
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(279, 406);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(243, 49);
            this.btnSil.TabIndex = 7;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // FrmGiderlerSil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 521);
            this.Controls.Add(this.panelBaslik);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmGiderlerSil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gider Kayıt Sil";
            this.panelBaslik.ResumeLayout(false);
            this.panelBaslik.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBaslik;
        private System.Windows.Forms.Label lblBaslik;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.ComboBox cmbOdemeTipi;
        public System.Windows.Forms.ComboBox cmbGiderTuru;
        public System.Windows.Forms.DateTimePicker dtTarih;
        public System.Windows.Forms.TextBox txtTutar;
        public System.Windows.Forms.TextBox txtFirma;
        private System.Windows.Forms.Button btnSil;
        public System.Windows.Forms.RichTextBox rtbAciklama;
        public System.Windows.Forms.CheckBox chkTekrarlayanMi;
        public System.Windows.Forms.CheckBox chkAktif;
        public System.Windows.Forms.DateTimePicker dtKayitTarihi;
        public System.Windows.Forms.TextBox txtGiderID;
        public System.Windows.Forms.TextBox txtKdvTutar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
    }
}