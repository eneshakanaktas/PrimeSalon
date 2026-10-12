
namespace PrimeSalon
{
    partial class FrmHizmetSil
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
            this.panelHizmetSil = new System.Windows.Forms.Panel();
            this.btnSil = new System.Windows.Forms.Button();
            this.rtbAciklama = new System.Windows.Forms.RichTextBox();
            this.chkAktif = new System.Windows.Forms.CheckBox();
            this.cmbKategori = new System.Windows.Forms.ComboBox();
            this.txtHizmetAdi = new System.Windows.Forms.TextBox();
            this.txtSureDakika = new System.Windows.Forms.TextBox();
            this.txtUcret = new System.Windows.Forms.TextBox();
            this.txtHizmetID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelHizmetSil.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHizmetSil
            // 
            this.panelHizmetSil.BackColor = System.Drawing.Color.Lavender;
            this.panelHizmetSil.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelHizmetSil.Controls.Add(this.btnSil);
            this.panelHizmetSil.Controls.Add(this.rtbAciklama);
            this.panelHizmetSil.Controls.Add(this.chkAktif);
            this.panelHizmetSil.Controls.Add(this.cmbKategori);
            this.panelHizmetSil.Controls.Add(this.txtHizmetAdi);
            this.panelHizmetSil.Controls.Add(this.txtSureDakika);
            this.panelHizmetSil.Controls.Add(this.txtUcret);
            this.panelHizmetSil.Controls.Add(this.txtHizmetID);
            this.panelHizmetSil.Controls.Add(this.label7);
            this.panelHizmetSil.Controls.Add(this.label6);
            this.panelHizmetSil.Controls.Add(this.label5);
            this.panelHizmetSil.Controls.Add(this.label4);
            this.panelHizmetSil.Controls.Add(this.label3);
            this.panelHizmetSil.Controls.Add(this.label2);
            this.panelHizmetSil.Controls.Add(this.label1);
            this.panelHizmetSil.Location = new System.Drawing.Point(20, 20);
            this.panelHizmetSil.Name = "panelHizmetSil";
            this.panelHizmetSil.Size = new System.Drawing.Size(640, 400);
            this.panelHizmetSil.TabIndex = 0;
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(222, 319);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(233, 56);
            this.btnSil.TabIndex = 6;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // rtbAciklama
            // 
            this.rtbAciklama.Enabled = false;
            this.rtbAciklama.Location = new System.Drawing.Point(150, 210);
            this.rtbAciklama.Name = "rtbAciklama";
            this.rtbAciklama.Size = new System.Drawing.Size(450, 90);
            this.rtbAciklama.TabIndex = 5;
            this.rtbAciklama.Text = "";
            // 
            // chkAktif
            // 
            this.chkAktif.Enabled = false;
            this.chkAktif.Location = new System.Drawing.Point(450, 147);
            this.chkAktif.Name = "chkAktif";
            this.chkAktif.Size = new System.Drawing.Size(80, 25);
            this.chkAktif.TabIndex = 4;
            this.chkAktif.Text = "Aktif";
            this.chkAktif.UseVisualStyleBackColor = true;
            // 
            // cmbKategori
            // 
            this.cmbKategori.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKategori.Enabled = false;
            this.cmbKategori.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbKategori.FormattingEnabled = true;
            this.cmbKategori.Items.AddRange(new object[] {
            "Seçiniz",
            "Saç Kesim",
            "Sakal Tıraşı",
            "Yıkama",
            "Bakım",
            "Diğer"});
            this.cmbKategori.Location = new System.Drawing.Point(150, 147);
            this.cmbKategori.Name = "cmbKategori";
            this.cmbKategori.Size = new System.Drawing.Size(150, 25);
            this.cmbKategori.TabIndex = 3;
            // 
            // txtHizmetAdi
            // 
            this.txtHizmetAdi.Enabled = false;
            this.txtHizmetAdi.Location = new System.Drawing.Point(150, 107);
            this.txtHizmetAdi.Multiline = true;
            this.txtHizmetAdi.Name = "txtHizmetAdi";
            this.txtHizmetAdi.Size = new System.Drawing.Size(150, 25);
            this.txtHizmetAdi.TabIndex = 2;
            // 
            // txtSureDakika
            // 
            this.txtSureDakika.Enabled = false;
            this.txtSureDakika.Location = new System.Drawing.Point(450, 107);
            this.txtSureDakika.Multiline = true;
            this.txtSureDakika.Name = "txtSureDakika";
            this.txtSureDakika.Size = new System.Drawing.Size(150, 25);
            this.txtSureDakika.TabIndex = 2;
            // 
            // txtUcret
            // 
            this.txtUcret.Enabled = false;
            this.txtUcret.Location = new System.Drawing.Point(450, 67);
            this.txtUcret.Multiline = true;
            this.txtUcret.Name = "txtUcret";
            this.txtUcret.Size = new System.Drawing.Size(150, 25);
            this.txtUcret.TabIndex = 2;
            // 
            // txtHizmetID
            // 
            this.txtHizmetID.Enabled = false;
            this.txtHizmetID.Location = new System.Drawing.Point(150, 67);
            this.txtHizmetID.Multiline = true;
            this.txtHizmetID.Name = "txtHizmetID";
            this.txtHizmetID.Size = new System.Drawing.Size(150, 25);
            this.txtHizmetID.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(40, 210);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Açıklama";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(340, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Süre(dk)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(340, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Ücret";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Kategori";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Hizmet Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hizmet ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(218, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Silinecek Hizmet Bilgileri";
            // 
            // FrmHizmetSil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.panelHizmetSil);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmHizmetSil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hizmet Kayıt Sil";
            this.panelHizmetSil.ResumeLayout(false);
            this.panelHizmetSil.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHizmetSil;
        private System.Windows.Forms.Button btnSil;
        public System.Windows.Forms.RichTextBox rtbAciklama;
        public System.Windows.Forms.CheckBox chkAktif;
        public System.Windows.Forms.ComboBox cmbKategori;
        public System.Windows.Forms.TextBox txtHizmetAdi;
        public System.Windows.Forms.TextBox txtSureDakika;
        public System.Windows.Forms.TextBox txtUcret;
        public System.Windows.Forms.TextBox txtHizmetID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}