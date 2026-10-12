
namespace PrimeSalon
{
    partial class FrmTedarikcilerGuncelle
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
            this.panelTedarikciSil = new System.Windows.Forms.Panel();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.rtbNotlar = new System.Windows.Forms.RichTextBox();
            this.rtbAdres = new System.Windows.Forms.RichTextBox();
            this.chkAktif = new System.Windows.Forms.CheckBox();
            this.dtKayitTarihi = new System.Windows.Forms.DateTimePicker();
            this.cmbSehir = new System.Windows.Forms.ComboBox();
            this.mskTelefon = new System.Windows.Forms.MaskedTextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtYetkiliAdSoyad = new System.Windows.Forms.TextBox();
            this.txtFirmaAdi = new System.Windows.Forms.TextBox();
            this.txtBanka = new System.Windows.Forms.TextBox();
            this.txtIBAN = new System.Windows.Forms.TextBox();
            this.txtTedarikciID = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblYildizSehir = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblBaslik = new System.Windows.Forms.Label();
            this.panelTedarikciSil.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTedarikciSil
            // 
            this.panelTedarikciSil.BackColor = System.Drawing.Color.LemonChiffon;
            this.panelTedarikciSil.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTedarikciSil.Controls.Add(this.btnGuncelle);
            this.panelTedarikciSil.Controls.Add(this.rtbNotlar);
            this.panelTedarikciSil.Controls.Add(this.rtbAdres);
            this.panelTedarikciSil.Controls.Add(this.chkAktif);
            this.panelTedarikciSil.Controls.Add(this.dtKayitTarihi);
            this.panelTedarikciSil.Controls.Add(this.cmbSehir);
            this.panelTedarikciSil.Controls.Add(this.mskTelefon);
            this.panelTedarikciSil.Controls.Add(this.txtEmail);
            this.panelTedarikciSil.Controls.Add(this.txtYetkiliAdSoyad);
            this.panelTedarikciSil.Controls.Add(this.txtFirmaAdi);
            this.panelTedarikciSil.Controls.Add(this.txtBanka);
            this.panelTedarikciSil.Controls.Add(this.txtIBAN);
            this.panelTedarikciSil.Controls.Add(this.txtTedarikciID);
            this.panelTedarikciSil.Controls.Add(this.label9);
            this.panelTedarikciSil.Controls.Add(this.label11);
            this.panelTedarikciSil.Controls.Add(this.label10);
            this.panelTedarikciSil.Controls.Add(this.label8);
            this.panelTedarikciSil.Controls.Add(this.label7);
            this.panelTedarikciSil.Controls.Add(this.lblYildizSehir);
            this.panelTedarikciSil.Controls.Add(this.label6);
            this.panelTedarikciSil.Controls.Add(this.label5);
            this.panelTedarikciSil.Controls.Add(this.label4);
            this.panelTedarikciSil.Controls.Add(this.label3);
            this.panelTedarikciSil.Controls.Add(this.label1);
            this.panelTedarikciSil.Controls.Add(this.label2);
            this.panelTedarikciSil.Controls.Add(this.lblBaslik);
            this.panelTedarikciSil.Location = new System.Drawing.Point(20, 12);
            this.panelTedarikciSil.Name = "panelTedarikciSil";
            this.panelTedarikciSil.Size = new System.Drawing.Size(755, 513);
            this.panelTedarikciSil.TabIndex = 1;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(269, 447);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(247, 48);
            this.btnGuncelle.TabIndex = 12;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // rtbNotlar
            // 
            this.rtbNotlar.Location = new System.Drawing.Point(165, 371);
            this.rtbNotlar.Name = "rtbNotlar";
            this.rtbNotlar.Size = new System.Drawing.Size(540, 60);
            this.rtbNotlar.TabIndex = 11;
            this.rtbNotlar.Text = "";
            // 
            // rtbAdres
            // 
            this.rtbAdres.Location = new System.Drawing.Point(165, 280);
            this.rtbAdres.Name = "rtbAdres";
            this.rtbAdres.Size = new System.Drawing.Size(540, 70);
            this.rtbAdres.TabIndex = 10;
            this.rtbAdres.Text = "";
            // 
            // chkAktif
            // 
            this.chkAktif.Location = new System.Drawing.Point(536, 217);
            this.chkAktif.Name = "chkAktif";
            this.chkAktif.Size = new System.Drawing.Size(80, 25);
            this.chkAktif.TabIndex = 9;
            this.chkAktif.Text = "Aktif";
            this.chkAktif.UseVisualStyleBackColor = true;
            // 
            // dtKayitTarihi
            // 
            this.dtKayitTarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtKayitTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtKayitTarihi.Location = new System.Drawing.Point(535, 177);
            this.dtKayitTarihi.Name = "dtKayitTarihi";
            this.dtKayitTarihi.Size = new System.Drawing.Size(170, 23);
            this.dtKayitTarihi.TabIndex = 8;
            // 
            // cmbSehir
            // 
            this.cmbSehir.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSehir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbSehir.FormattingEnabled = true;
            this.cmbSehir.Items.AddRange(new object[] {
            "Seçiniz",
            "İstanbul",
            "Ankara",
            "İzmir",
            "Bursa"});
            this.cmbSehir.Location = new System.Drawing.Point(535, 57);
            this.cmbSehir.Name = "cmbSehir";
            this.cmbSehir.Size = new System.Drawing.Size(170, 25);
            this.cmbSehir.TabIndex = 5;
            this.cmbSehir.SelectedIndexChanged += new System.EventHandler(this.cmbSehir_SelectedIndexChanged);
            // 
            // mskTelefon
            // 
            this.mskTelefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mskTelefon.Location = new System.Drawing.Point(165, 177);
            this.mskTelefon.Mask = "(9999) 000-0000";
            this.mskTelefon.Name = "mskTelefon";
            this.mskTelefon.Size = new System.Drawing.Size(170, 23);
            this.mskTelefon.TabIndex = 3;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(165, 217);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(170, 25);
            this.txtEmail.TabIndex = 4;
            // 
            // txtYetkiliAdSoyad
            // 
            this.txtYetkiliAdSoyad.Location = new System.Drawing.Point(165, 137);
            this.txtYetkiliAdSoyad.Multiline = true;
            this.txtYetkiliAdSoyad.Name = "txtYetkiliAdSoyad";
            this.txtYetkiliAdSoyad.Size = new System.Drawing.Size(170, 25);
            this.txtYetkiliAdSoyad.TabIndex = 2;
            // 
            // txtFirmaAdi
            // 
            this.txtFirmaAdi.Location = new System.Drawing.Point(165, 97);
            this.txtFirmaAdi.Multiline = true;
            this.txtFirmaAdi.Name = "txtFirmaAdi";
            this.txtFirmaAdi.Size = new System.Drawing.Size(170, 25);
            this.txtFirmaAdi.TabIndex = 1;
            // 
            // txtBanka
            // 
            this.txtBanka.Location = new System.Drawing.Point(535, 137);
            this.txtBanka.Multiline = true;
            this.txtBanka.Name = "txtBanka";
            this.txtBanka.Size = new System.Drawing.Size(170, 25);
            this.txtBanka.TabIndex = 7;
            // 
            // txtIBAN
            // 
            this.txtIBAN.Location = new System.Drawing.Point(535, 97);
            this.txtIBAN.Multiline = true;
            this.txtIBAN.Name = "txtIBAN";
            this.txtIBAN.Size = new System.Drawing.Size(170, 25);
            this.txtIBAN.TabIndex = 6;
            // 
            // txtTedarikciID
            // 
            this.txtTedarikciID.Enabled = false;
            this.txtTedarikciID.Location = new System.Drawing.Point(165, 57);
            this.txtTedarikciID.Multiline = true;
            this.txtTedarikciID.Name = "txtTedarikciID";
            this.txtTedarikciID.Size = new System.Drawing.Size(170, 25);
            this.txtTedarikciID.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(406, 180);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Kayıt Tarihi";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(35, 371);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "Notlar";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(35, 280);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Adres";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(406, 140);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Banka";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(405, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "IBAN";
            // 
            // lblYildizSehir
            // 
            this.lblYildizSehir.AutoSize = true;
            this.lblYildizSehir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYildizSehir.ForeColor = System.Drawing.Color.Red;
            this.lblYildizSehir.Location = new System.Drawing.Point(711, 56);
            this.lblYildizSehir.Name = "lblYildizSehir";
            this.lblYildizSehir.Size = new System.Drawing.Size(14, 17);
            this.lblYildizSehir.TabIndex = 1;
            this.lblYildizSehir.Text = "*";
            this.lblYildizSehir.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(405, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Şehir";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "E-Posta";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Telefon";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Yetkili";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Firma Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tedarikçi ID";
            // 
            // lblBaslik
            // 
            this.lblBaslik.AutoSize = true;
            this.lblBaslik.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBaslik.Location = new System.Drawing.Point(248, 9);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(268, 20);
            this.lblBaslik.TabIndex = 0;
            this.lblBaslik.Text = "Güncellenecek Tedarikçi Bilgileri";
            // 
            // FrmTedarikcilerGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 543);
            this.Controls.Add(this.panelTedarikciSil);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.Name = "FrmTedarikcilerGuncelle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tedarikçi Güncelle";
            this.panelTedarikciSil.ResumeLayout(false);
            this.panelTedarikciSil.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTedarikciSil;
        private System.Windows.Forms.Button btnGuncelle;
        public System.Windows.Forms.RichTextBox rtbNotlar;
        public System.Windows.Forms.RichTextBox rtbAdres;
        public System.Windows.Forms.CheckBox chkAktif;
        public System.Windows.Forms.DateTimePicker dtKayitTarihi;
        public System.Windows.Forms.ComboBox cmbSehir;
        public System.Windows.Forms.MaskedTextBox mskTelefon;
        public System.Windows.Forms.TextBox txtEmail;
        public System.Windows.Forms.TextBox txtYetkiliAdSoyad;
        public System.Windows.Forms.TextBox txtFirmaAdi;
        public System.Windows.Forms.TextBox txtBanka;
        public System.Windows.Forms.TextBox txtIBAN;
        public System.Windows.Forms.TextBox txtTedarikciID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblBaslik;
        private System.Windows.Forms.Label lblYildizSehir;
    }
}