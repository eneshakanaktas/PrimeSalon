
namespace PrimeSalon
{
    partial class FrmSatislarSil
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSil = new System.Windows.Forms.Button();
            this.rtbIadeNedeni = new System.Windows.Forms.RichTextBox();
            this.rtbAciklama = new System.Windows.Forms.RichTextBox();
            this.chkIadeMi = new System.Windows.Forms.CheckBox();
            this.cmbOdemeDurumu = new System.Windows.Forms.ComboBox();
            this.cmbOdemeTipi = new System.Windows.Forms.ComboBox();
            this.cmbSatisTipi = new System.Windows.Forms.ComboBox();
            this.dtTarih = new System.Windows.Forms.DateTimePicker();
            this.txtGenelToplam = new System.Windows.Forms.TextBox();
            this.txtKdvTutar = new System.Windows.Forms.TextBox();
            this.txtIndirimTutar = new System.Windows.Forms.TextBox();
            this.txtAraToplam = new System.Windows.Forms.TextBox();
            this.txtPersonelID = new System.Windows.Forms.TextBox();
            this.txtMusteriID = new System.Windows.Forms.TextBox();
            this.txtSatisID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Lavender;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnSil);
            this.panel1.Controls.Add(this.rtbIadeNedeni);
            this.panel1.Controls.Add(this.rtbAciklama);
            this.panel1.Controls.Add(this.chkIadeMi);
            this.panel1.Controls.Add(this.cmbOdemeDurumu);
            this.panel1.Controls.Add(this.cmbOdemeTipi);
            this.panel1.Controls.Add(this.cmbSatisTipi);
            this.panel1.Controls.Add(this.dtTarih);
            this.panel1.Controls.Add(this.txtGenelToplam);
            this.panel1.Controls.Add(this.txtKdvTutar);
            this.panel1.Controls.Add(this.txtIndirimTutar);
            this.panel1.Controls.Add(this.txtAraToplam);
            this.panel1.Controls.Add(this.txtPersonelID);
            this.panel1.Controls.Add(this.txtMusteriID);
            this.panel1.Controls.Add(this.txtSatisID);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(20, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(840, 540);
            this.panel1.TabIndex = 0;
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(319, 477);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(240, 48);
            this.btnSil.TabIndex = 7;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // rtbIadeNedeni
            // 
            this.rtbIadeNedeni.Enabled = false;
            this.rtbIadeNedeni.Location = new System.Drawing.Point(182, 401);
            this.rtbIadeNedeni.Name = "rtbIadeNedeni";
            this.rtbIadeNedeni.Size = new System.Drawing.Size(580, 60);
            this.rtbIadeNedeni.TabIndex = 6;
            this.rtbIadeNedeni.Text = "";
            // 
            // rtbAciklama
            // 
            this.rtbAciklama.Enabled = false;
            this.rtbAciklama.Location = new System.Drawing.Point(182, 316);
            this.rtbAciklama.Name = "rtbAciklama";
            this.rtbAciklama.Size = new System.Drawing.Size(580, 70);
            this.rtbAciklama.TabIndex = 6;
            this.rtbAciklama.Text = "";
            // 
            // chkIadeMi
            // 
            this.chkIadeMi.AutoSize = true;
            this.chkIadeMi.Enabled = false;
            this.chkIadeMi.Location = new System.Drawing.Point(592, 253);
            this.chkIadeMi.Name = "chkIadeMi";
            this.chkIadeMi.Size = new System.Drawing.Size(66, 17);
            this.chkIadeMi.TabIndex = 5;
            this.chkIadeMi.Text = "İade Var";
            this.chkIadeMi.UseVisualStyleBackColor = true;
            // 
            // cmbOdemeDurumu
            // 
            this.cmbOdemeDurumu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOdemeDurumu.Enabled = false;
            this.cmbOdemeDurumu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbOdemeDurumu.FormattingEnabled = true;
            this.cmbOdemeDurumu.Items.AddRange(new object[] {
            "Seçiniz",
            "Ödendi",
            "Bekliyor",
            "Kısmi"});
            this.cmbOdemeDurumu.Location = new System.Drawing.Point(592, 213);
            this.cmbOdemeDurumu.Name = "cmbOdemeDurumu";
            this.cmbOdemeDurumu.Size = new System.Drawing.Size(170, 25);
            this.cmbOdemeDurumu.TabIndex = 4;
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
            this.cmbOdemeTipi.Location = new System.Drawing.Point(592, 173);
            this.cmbOdemeTipi.Name = "cmbOdemeTipi";
            this.cmbOdemeTipi.Size = new System.Drawing.Size(170, 25);
            this.cmbOdemeTipi.TabIndex = 4;
            // 
            // cmbSatisTipi
            // 
            this.cmbSatisTipi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSatisTipi.Enabled = false;
            this.cmbSatisTipi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbSatisTipi.FormattingEnabled = true;
            this.cmbSatisTipi.Items.AddRange(new object[] {
            "Seçiniz",
            "Hizmet",
            "Ürün",
            "Karma"});
            this.cmbSatisTipi.Location = new System.Drawing.Point(182, 213);
            this.cmbSatisTipi.Name = "cmbSatisTipi";
            this.cmbSatisTipi.Size = new System.Drawing.Size(170, 25);
            this.cmbSatisTipi.TabIndex = 4;
            // 
            // dtTarih
            // 
            this.dtTarih.Enabled = false;
            this.dtTarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtTarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtTarih.Location = new System.Drawing.Point(182, 93);
            this.dtTarih.Name = "dtTarih";
            this.dtTarih.Size = new System.Drawing.Size(170, 23);
            this.dtTarih.TabIndex = 3;
            // 
            // txtGenelToplam
            // 
            this.txtGenelToplam.Enabled = false;
            this.txtGenelToplam.Location = new System.Drawing.Point(592, 133);
            this.txtGenelToplam.Multiline = true;
            this.txtGenelToplam.Name = "txtGenelToplam";
            this.txtGenelToplam.Size = new System.Drawing.Size(170, 25);
            this.txtGenelToplam.TabIndex = 2;
            // 
            // txtKdvTutar
            // 
            this.txtKdvTutar.Enabled = false;
            this.txtKdvTutar.Location = new System.Drawing.Point(592, 93);
            this.txtKdvTutar.Multiline = true;
            this.txtKdvTutar.Name = "txtKdvTutar";
            this.txtKdvTutar.Size = new System.Drawing.Size(170, 25);
            this.txtKdvTutar.TabIndex = 2;
            // 
            // txtIndirimTutar
            // 
            this.txtIndirimTutar.Enabled = false;
            this.txtIndirimTutar.Location = new System.Drawing.Point(592, 53);
            this.txtIndirimTutar.Multiline = true;
            this.txtIndirimTutar.Name = "txtIndirimTutar";
            this.txtIndirimTutar.Size = new System.Drawing.Size(170, 25);
            this.txtIndirimTutar.TabIndex = 2;
            // 
            // txtAraToplam
            // 
            this.txtAraToplam.Enabled = false;
            this.txtAraToplam.Location = new System.Drawing.Point(182, 253);
            this.txtAraToplam.Multiline = true;
            this.txtAraToplam.Name = "txtAraToplam";
            this.txtAraToplam.Size = new System.Drawing.Size(170, 25);
            this.txtAraToplam.TabIndex = 2;
            // 
            // txtPersonelID
            // 
            this.txtPersonelID.Enabled = false;
            this.txtPersonelID.Location = new System.Drawing.Point(182, 173);
            this.txtPersonelID.Multiline = true;
            this.txtPersonelID.Name = "txtPersonelID";
            this.txtPersonelID.Size = new System.Drawing.Size(170, 25);
            this.txtPersonelID.TabIndex = 2;
            // 
            // txtMusteriID
            // 
            this.txtMusteriID.Enabled = false;
            this.txtMusteriID.Location = new System.Drawing.Point(182, 133);
            this.txtMusteriID.Multiline = true;
            this.txtMusteriID.Name = "txtMusteriID";
            this.txtMusteriID.Size = new System.Drawing.Size(170, 25);
            this.txtMusteriID.TabIndex = 2;
            // 
            // txtSatisID
            // 
            this.txtSatisID.Enabled = false;
            this.txtSatisID.Location = new System.Drawing.Point(182, 53);
            this.txtSatisID.Multiline = true;
            this.txtSatisID.Name = "txtSatisID";
            this.txtSatisID.Size = new System.Drawing.Size(170, 25);
            this.txtSatisID.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tarih";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(452, 216);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(81, 13);
            this.label12.TabIndex = 1;
            this.label12.Text = "Ödeme Durumu";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(452, 176);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "Ödeme Tipi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 216);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Satış Tipi";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(452, 136);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Genel Toplam";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(452, 96);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "KDV Tutar";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(452, 56);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "İndirim Tutar";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(42, 404);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(65, 13);
            this.label14.TabIndex = 1;
            this.label14.Text = "İade Nedeni";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(42, 316);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(50, 13);
            this.label13.TabIndex = 1;
            this.label13.Text = "Açıklama";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(42, 256);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Ara Toplam";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Personel ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Müşteri ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Satış ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(324, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Silinecek Satış Bilgileri";
            // 
            // FrmSatislarSil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 581);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmSatislarSil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Satış Kayıt Sil";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        public System.Windows.Forms.DateTimePicker dtTarih;
        public System.Windows.Forms.TextBox txtSatisID;
        public System.Windows.Forms.ComboBox cmbOdemeTipi;
        public System.Windows.Forms.ComboBox cmbSatisTipi;
        public System.Windows.Forms.TextBox txtGenelToplam;
        public System.Windows.Forms.TextBox txtKdvTutar;
        public System.Windows.Forms.TextBox txtIndirimTutar;
        public System.Windows.Forms.TextBox txtAraToplam;
        public System.Windows.Forms.TextBox txtPersonelID;
        public System.Windows.Forms.TextBox txtMusteriID;
        public System.Windows.Forms.RichTextBox rtbIadeNedeni;
        public System.Windows.Forms.RichTextBox rtbAciklama;
        public System.Windows.Forms.CheckBox chkIadeMi;
        public System.Windows.Forms.ComboBox cmbOdemeDurumu;
    }
}