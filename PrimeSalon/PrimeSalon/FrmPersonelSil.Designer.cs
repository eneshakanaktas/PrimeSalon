
namespace PrimeSalon
{
    partial class FrmPersonelSil
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
            this.panelPersonelSil = new System.Windows.Forms.Panel();
            this.btnSil = new System.Windows.Forms.Button();
            this.chkAktif = new System.Windows.Forms.CheckBox();
            this.rtbAdres = new System.Windows.Forms.RichTextBox();
            this.dtIseGiris = new System.Windows.Forms.DateTimePicker();
            this.txtMaas = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.grpCinsiyet = new System.Windows.Forms.GroupBox();
            this.radK = new System.Windows.Forms.RadioButton();
            this.radE = new System.Windows.Forms.RadioButton();
            this.cmbPozisyon = new System.Windows.Forms.ComboBox();
            this.txtTelefon = new System.Windows.Forms.MaskedTextBox();
            this.mskTcNo = new System.Windows.Forms.MaskedTextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtPersonelID = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblBaslik = new System.Windows.Forms.Label();
            this.panelPersonelSil.SuspendLayout();
            this.grpCinsiyet.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelPersonelSil
            // 
            this.panelPersonelSil.BackColor = System.Drawing.Color.Lavender;
            this.panelPersonelSil.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPersonelSil.Controls.Add(this.btnSil);
            this.panelPersonelSil.Controls.Add(this.chkAktif);
            this.panelPersonelSil.Controls.Add(this.rtbAdres);
            this.panelPersonelSil.Controls.Add(this.dtIseGiris);
            this.panelPersonelSil.Controls.Add(this.txtMaas);
            this.panelPersonelSil.Controls.Add(this.txtEmail);
            this.panelPersonelSil.Controls.Add(this.grpCinsiyet);
            this.panelPersonelSil.Controls.Add(this.cmbPozisyon);
            this.panelPersonelSil.Controls.Add(this.txtTelefon);
            this.panelPersonelSil.Controls.Add(this.mskTcNo);
            this.panelPersonelSil.Controls.Add(this.txtSoyad);
            this.panelPersonelSil.Controls.Add(this.txtAd);
            this.panelPersonelSil.Controls.Add(this.txtPersonelID);
            this.panelPersonelSil.Controls.Add(this.label10);
            this.panelPersonelSil.Controls.Add(this.label9);
            this.panelPersonelSil.Controls.Add(this.label8);
            this.panelPersonelSil.Controls.Add(this.label7);
            this.panelPersonelSil.Controls.Add(this.label6);
            this.panelPersonelSil.Controls.Add(this.label5);
            this.panelPersonelSil.Controls.Add(this.label4);
            this.panelPersonelSil.Controls.Add(this.label3);
            this.panelPersonelSil.Controls.Add(this.label2);
            this.panelPersonelSil.Controls.Add(this.label1);
            this.panelPersonelSil.Controls.Add(this.lblBaslik);
            this.panelPersonelSil.Location = new System.Drawing.Point(20, 12);
            this.panelPersonelSil.Name = "panelPersonelSil";
            this.panelPersonelSil.Size = new System.Drawing.Size(720, 489);
            this.panelPersonelSil.TabIndex = 0;
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(234, 414);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(295, 50);
            this.btnSil.TabIndex = 10;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // chkAktif
            // 
            this.chkAktif.AutoSize = true;
            this.chkAktif.Enabled = false;
            this.chkAktif.Location = new System.Drawing.Point(42, 269);
            this.chkAktif.Name = "chkAktif";
            this.chkAktif.Size = new System.Drawing.Size(47, 17);
            this.chkAktif.TabIndex = 9;
            this.chkAktif.Text = "Aktif";
            this.chkAktif.UseVisualStyleBackColor = true;
            // 
            // rtbAdres
            // 
            this.rtbAdres.Enabled = false;
            this.rtbAdres.Location = new System.Drawing.Point(149, 312);
            this.rtbAdres.Name = "rtbAdres";
            this.rtbAdres.Size = new System.Drawing.Size(520, 80);
            this.rtbAdres.TabIndex = 8;
            this.rtbAdres.Text = "";
            // 
            // dtIseGiris
            // 
            this.dtIseGiris.Enabled = false;
            this.dtIseGiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtIseGiris.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtIseGiris.Location = new System.Drawing.Point(499, 262);
            this.dtIseGiris.Name = "dtIseGiris";
            this.dtIseGiris.Size = new System.Drawing.Size(170, 23);
            this.dtIseGiris.TabIndex = 7;
            // 
            // txtMaas
            // 
            this.txtMaas.Enabled = false;
            this.txtMaas.Location = new System.Drawing.Point(499, 219);
            this.txtMaas.Multiline = true;
            this.txtMaas.Name = "txtMaas";
            this.txtMaas.Size = new System.Drawing.Size(170, 25);
            this.txtMaas.TabIndex = 6;
            // 
            // txtEmail
            // 
            this.txtEmail.Enabled = false;
            this.txtEmail.Location = new System.Drawing.Point(499, 179);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(170, 25);
            this.txtEmail.TabIndex = 6;
            // 
            // grpCinsiyet
            // 
            this.grpCinsiyet.Controls.Add(this.radK);
            this.grpCinsiyet.Controls.Add(this.radE);
            this.grpCinsiyet.Location = new System.Drawing.Point(392, 102);
            this.grpCinsiyet.Name = "grpCinsiyet";
            this.grpCinsiyet.Size = new System.Drawing.Size(280, 55);
            this.grpCinsiyet.TabIndex = 5;
            this.grpCinsiyet.TabStop = false;
            this.grpCinsiyet.Text = "Cinsiyet";
            // 
            // radK
            // 
            this.radK.AutoSize = true;
            this.radK.Enabled = false;
            this.radK.Location = new System.Drawing.Point(120, 22);
            this.radK.Name = "radK";
            this.radK.Size = new System.Drawing.Size(52, 17);
            this.radK.TabIndex = 0;
            this.radK.TabStop = true;
            this.radK.Text = "Kadın";
            this.radK.UseVisualStyleBackColor = true;
            // 
            // radE
            // 
            this.radE.AutoSize = true;
            this.radE.Enabled = false;
            this.radE.Location = new System.Drawing.Point(20, 22);
            this.radE.Name = "radE";
            this.radE.Size = new System.Drawing.Size(53, 17);
            this.radE.TabIndex = 0;
            this.radE.TabStop = true;
            this.radE.Text = "Erkek";
            this.radE.UseVisualStyleBackColor = true;
            // 
            // cmbPozisyon
            // 
            this.cmbPozisyon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPozisyon.Enabled = false;
            this.cmbPozisyon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbPozisyon.FormattingEnabled = true;
            this.cmbPozisyon.Items.AddRange(new object[] {
            "Seçiniz",
            "Usta",
            "Kalfa",
            "Çırak"});
            this.cmbPozisyon.Location = new System.Drawing.Point(499, 59);
            this.cmbPozisyon.Name = "cmbPozisyon";
            this.cmbPozisyon.Size = new System.Drawing.Size(170, 25);
            this.cmbPozisyon.TabIndex = 4;
            // 
            // txtTelefon
            // 
            this.txtTelefon.Enabled = false;
            this.txtTelefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTelefon.Location = new System.Drawing.Point(149, 219);
            this.txtTelefon.Mask = "(9999) 000-0000";
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(170, 23);
            this.txtTelefon.TabIndex = 3;
            // 
            // mskTcNo
            // 
            this.mskTcNo.Enabled = false;
            this.mskTcNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mskTcNo.Location = new System.Drawing.Point(149, 179);
            this.mskTcNo.Mask = "00000000000";
            this.mskTcNo.Name = "mskTcNo";
            this.mskTcNo.Size = new System.Drawing.Size(170, 23);
            this.mskTcNo.TabIndex = 3;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Enabled = false;
            this.txtSoyad.Location = new System.Drawing.Point(149, 139);
            this.txtSoyad.Multiline = true;
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(170, 25);
            this.txtSoyad.TabIndex = 2;
            // 
            // txtAd
            // 
            this.txtAd.Enabled = false;
            this.txtAd.Location = new System.Drawing.Point(149, 99);
            this.txtAd.Multiline = true;
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(170, 25);
            this.txtAd.TabIndex = 2;
            // 
            // txtPersonelID
            // 
            this.txtPersonelID.Enabled = false;
            this.txtPersonelID.Location = new System.Drawing.Point(149, 59);
            this.txtPersonelID.Multiline = true;
            this.txtPersonelID.Name = "txtPersonelID";
            this.txtPersonelID.Size = new System.Drawing.Size(170, 25);
            this.txtPersonelID.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(39, 315);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Adres";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(389, 268);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "İşe Giriş";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(389, 225);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Maaş";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(389, 182);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "E-Posta";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(389, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Pozisyon";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Telefon";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "TC No";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Soyad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Personel ID";
            // 
            // lblBaslik
            // 
            this.lblBaslik.AutoSize = true;
            this.lblBaslik.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBaslik.Location = new System.Drawing.Point(251, 17);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(219, 20);
            this.lblBaslik.TabIndex = 0;
            this.lblBaslik.Text = "Silinecek Personel Bilgileri";
            // 
            // FrmPersonelSil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 521);
            this.Controls.Add(this.panelPersonelSil);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.Name = "FrmPersonelSil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personel Kayıt Sil";
            this.panelPersonelSil.ResumeLayout(false);
            this.panelPersonelSil.PerformLayout();
            this.grpCinsiyet.ResumeLayout(false);
            this.grpCinsiyet.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelPersonelSil;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblBaslik;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.GroupBox grpCinsiyet;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox txtPersonelID;
        public System.Windows.Forms.MaskedTextBox txtTelefon;
        public System.Windows.Forms.MaskedTextBox mskTcNo;
        public System.Windows.Forms.TextBox txtSoyad;
        public System.Windows.Forms.TextBox txtAd;
        public System.Windows.Forms.ComboBox cmbPozisyon;
        public System.Windows.Forms.CheckBox chkAktif;
        public System.Windows.Forms.RichTextBox rtbAdres;
        public System.Windows.Forms.DateTimePicker dtIseGiris;
        public System.Windows.Forms.TextBox txtMaas;
        public System.Windows.Forms.TextBox txtEmail;
        public System.Windows.Forms.RadioButton radK;
        public System.Windows.Forms.RadioButton radE;
    }
}