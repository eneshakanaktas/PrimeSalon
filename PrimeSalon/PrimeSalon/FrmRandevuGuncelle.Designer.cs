
namespace PrimeSalon
{
    partial class FrmRandevuGuncelle
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
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.rtbNotlar = new System.Windows.Forms.RichTextBox();
            this.cmbDurum = new System.Windows.Forms.ComboBox();
            this.cmbOdemeDurumu = new System.Windows.Forms.ComboBox();
            this.dtRandevuSaat = new System.Windows.Forms.DateTimePicker();
            this.dtOlusturmaTarihi = new System.Windows.Forms.DateTimePicker();
            this.dtRandevuTarih = new System.Windows.Forms.DateTimePicker();
            this.txtToplamTutar = new System.Windows.Forms.TextBox();
            this.txtIndirimMiktar = new System.Windows.Forms.TextBox();
            this.txtSureDakika = new System.Windows.Forms.TextBox();
            this.txtPersonelID = new System.Windows.Forms.TextBox();
            this.txtMusteriID = new System.Windows.Forms.TextBox();
            this.txtRandevuID = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblYildizDurum = new System.Windows.Forms.Label();
            this.lblYildizOdemeDurumu = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblBaslik = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LemonChiffon;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnGuncelle);
            this.panel1.Controls.Add(this.rtbNotlar);
            this.panel1.Controls.Add(this.cmbDurum);
            this.panel1.Controls.Add(this.cmbOdemeDurumu);
            this.panel1.Controls.Add(this.dtRandevuSaat);
            this.panel1.Controls.Add(this.dtOlusturmaTarihi);
            this.panel1.Controls.Add(this.dtRandevuTarih);
            this.panel1.Controls.Add(this.txtToplamTutar);
            this.panel1.Controls.Add(this.txtIndirimMiktar);
            this.panel1.Controls.Add(this.txtSureDakika);
            this.panel1.Controls.Add(this.txtPersonelID);
            this.panel1.Controls.Add(this.txtMusteriID);
            this.panel1.Controls.Add(this.txtRandevuID);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.lblYildizDurum);
            this.panel1.Controls.Add(this.lblYildizOdemeDurumu);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblBaslik);
            this.panel1.Location = new System.Drawing.Point(20, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(840, 540);
            this.panel1.TabIndex = 1;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(301, 465);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(282, 49);
            this.btnGuncelle.TabIndex = 12;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // rtbNotlar
            // 
            this.rtbNotlar.Location = new System.Drawing.Point(180, 350);
            this.rtbNotlar.Name = "rtbNotlar";
            this.rtbNotlar.Size = new System.Drawing.Size(580, 90);
            this.rtbNotlar.TabIndex = 11;
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
            this.cmbDurum.Location = new System.Drawing.Point(590, 227);
            this.cmbDurum.Name = "cmbDurum";
            this.cmbDurum.Size = new System.Drawing.Size(170, 25);
            this.cmbDurum.TabIndex = 10;
            this.cmbDurum.SelectedIndexChanged += new System.EventHandler(this.cmbDurum_SelectedIndexChanged);
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
            this.cmbOdemeDurumu.Location = new System.Drawing.Point(590, 147);
            this.cmbOdemeDurumu.Name = "cmbOdemeDurumu";
            this.cmbOdemeDurumu.Size = new System.Drawing.Size(170, 25);
            this.cmbOdemeDurumu.TabIndex = 8;
            this.cmbOdemeDurumu.SelectedIndexChanged += new System.EventHandler(this.cmbOdemeDurumu_SelectedIndexChanged);
            // 
            // dtRandevuSaat
            // 
            this.dtRandevuSaat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtRandevuSaat.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtRandevuSaat.Location = new System.Drawing.Point(180, 227);
            this.dtRandevuSaat.Name = "dtRandevuSaat";
            this.dtRandevuSaat.ShowUpDown = true;
            this.dtRandevuSaat.Size = new System.Drawing.Size(170, 23);
            this.dtRandevuSaat.TabIndex = 4;
            // 
            // dtOlusturmaTarihi
            // 
            this.dtOlusturmaTarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtOlusturmaTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtOlusturmaTarihi.Location = new System.Drawing.Point(590, 187);
            this.dtOlusturmaTarihi.Name = "dtOlusturmaTarihi";
            this.dtOlusturmaTarihi.Size = new System.Drawing.Size(170, 23);
            this.dtOlusturmaTarihi.TabIndex = 9;
            // 
            // dtRandevuTarih
            // 
            this.dtRandevuTarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtRandevuTarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtRandevuTarih.Location = new System.Drawing.Point(180, 187);
            this.dtRandevuTarih.Name = "dtRandevuTarih";
            this.dtRandevuTarih.Size = new System.Drawing.Size(170, 23);
            this.dtRandevuTarih.TabIndex = 3;
            // 
            // txtToplamTutar
            // 
            this.txtToplamTutar.Location = new System.Drawing.Point(590, 107);
            this.txtToplamTutar.Multiline = true;
            this.txtToplamTutar.Name = "txtToplamTutar";
            this.txtToplamTutar.Size = new System.Drawing.Size(170, 25);
            this.txtToplamTutar.TabIndex = 7;
            // 
            // txtIndirimMiktar
            // 
            this.txtIndirimMiktar.Location = new System.Drawing.Point(590, 67);
            this.txtIndirimMiktar.Multiline = true;
            this.txtIndirimMiktar.Name = "txtIndirimMiktar";
            this.txtIndirimMiktar.Size = new System.Drawing.Size(170, 25);
            this.txtIndirimMiktar.TabIndex = 6;
            // 
            // txtSureDakika
            // 
            this.txtSureDakika.Location = new System.Drawing.Point(180, 267);
            this.txtSureDakika.Multiline = true;
            this.txtSureDakika.Name = "txtSureDakika";
            this.txtSureDakika.Size = new System.Drawing.Size(170, 25);
            this.txtSureDakika.TabIndex = 5;
            // 
            // txtPersonelID
            // 
            this.txtPersonelID.Location = new System.Drawing.Point(180, 147);
            this.txtPersonelID.Multiline = true;
            this.txtPersonelID.Name = "txtPersonelID";
            this.txtPersonelID.Size = new System.Drawing.Size(170, 25);
            this.txtPersonelID.TabIndex = 2;
            // 
            // txtMusteriID
            // 
            this.txtMusteriID.Location = new System.Drawing.Point(180, 107);
            this.txtMusteriID.Multiline = true;
            this.txtMusteriID.Name = "txtMusteriID";
            this.txtMusteriID.Size = new System.Drawing.Size(170, 25);
            this.txtMusteriID.TabIndex = 1;
            // 
            // txtRandevuID
            // 
            this.txtRandevuID.Enabled = false;
            this.txtRandevuID.Location = new System.Drawing.Point(180, 67);
            this.txtRandevuID.Multiline = true;
            this.txtRandevuID.Name = "txtRandevuID";
            this.txtRandevuID.Size = new System.Drawing.Size(170, 25);
            this.txtRandevuID.TabIndex = 2;
            this.txtRandevuID.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(450, 230);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "Durum";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(450, 150);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Ödeme Durumu";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(450, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Toplam Tutar";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(450, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "İndirim";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(40, 230);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Randevu Saati";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(450, 190);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Oluşturulma Tarihi";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(40, 190);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Randevu Tarihi";
            // 
            // lblYildizDurum
            // 
            this.lblYildizDurum.AutoSize = true;
            this.lblYildizDurum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYildizDurum.ForeColor = System.Drawing.Color.Red;
            this.lblYildizDurum.Location = new System.Drawing.Point(766, 227);
            this.lblYildizDurum.Name = "lblYildizDurum";
            this.lblYildizDurum.Size = new System.Drawing.Size(14, 17);
            this.lblYildizDurum.TabIndex = 1;
            this.lblYildizDurum.Text = "*";
            this.lblYildizDurum.Visible = false;
            // 
            // lblYildizOdemeDurumu
            // 
            this.lblYildizOdemeDurumu.AutoSize = true;
            this.lblYildizOdemeDurumu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYildizOdemeDurumu.ForeColor = System.Drawing.Color.Red;
            this.lblYildizOdemeDurumu.Location = new System.Drawing.Point(766, 147);
            this.lblYildizOdemeDurumu.Name = "lblYildizOdemeDurumu";
            this.lblYildizOdemeDurumu.Size = new System.Drawing.Size(14, 17);
            this.lblYildizOdemeDurumu.TabIndex = 1;
            this.lblYildizOdemeDurumu.Text = "*";
            this.lblYildizOdemeDurumu.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(40, 350);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 13);
            this.label12.TabIndex = 1;
            this.label12.Text = "Notlar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 270);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Süre (dk)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Personel ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Müşteri ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Randevu ID";
            // 
            // lblBaslik
            // 
            this.lblBaslik.AutoSize = true;
            this.lblBaslik.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBaslik.Location = new System.Drawing.Point(286, 9);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(267, 20);
            this.lblBaslik.TabIndex = 0;
            this.lblBaslik.Text = "Güncellenecek Randevu Bilgileri";
            // 
            // FrmRandevuGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 581);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmRandevuGuncelle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Randevu Güncelle";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnGuncelle;
        public System.Windows.Forms.RichTextBox rtbNotlar;
        public System.Windows.Forms.ComboBox cmbDurum;
        public System.Windows.Forms.ComboBox cmbOdemeDurumu;
        public System.Windows.Forms.DateTimePicker dtRandevuSaat;
        public System.Windows.Forms.DateTimePicker dtOlusturmaTarihi;
        public System.Windows.Forms.DateTimePicker dtRandevuTarih;
        public System.Windows.Forms.TextBox txtToplamTutar;
        public System.Windows.Forms.TextBox txtIndirimMiktar;
        public System.Windows.Forms.TextBox txtSureDakika;
        public System.Windows.Forms.TextBox txtPersonelID;
        public System.Windows.Forms.TextBox txtMusteriID;
        public System.Windows.Forms.TextBox txtRandevuID;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblBaslik;
        private System.Windows.Forms.Label lblYildizDurum;
        private System.Windows.Forms.Label lblYildizOdemeDurumu;
    }
}