
namespace PrimeSalon
{
    partial class FrmMusteriSorgulama
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
            this.grpAdSoyadSorgulama = new System.Windows.Forms.GroupBox();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnAra = new System.Windows.Forms.Button();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.chkSoyad = new System.Windows.Forms.CheckBox();
            this.chkAd = new System.Windows.Forms.CheckBox();
            this.dgvMusteriSorgulama = new System.Windows.Forms.DataGridView();
            this.grpHizliSorgulama = new System.Windows.Forms.GroupBox();
            this.txtHizliAra = new System.Windows.Forms.TextBox();
            this.cmbAramaTuru = new System.Windows.Forms.ComboBox();
            this.lblHizliBilgi = new System.Windows.Forms.Label();
            this.lblArananAlan = new System.Windows.Forms.Label();
            this.lblAramaTuru = new System.Windows.Forms.Label();
            this.radTcNo = new System.Windows.Forms.RadioButton();
            this.radTelefon = new System.Windows.Forms.RadioButton();
            this.radSoyad = new System.Windows.Forms.RadioButton();
            this.radAd = new System.Windows.Forms.RadioButton();
            this.grpAdSoyadSorgulama.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMusteriSorgulama)).BeginInit();
            this.grpHizliSorgulama.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpAdSoyadSorgulama
            // 
            this.grpAdSoyadSorgulama.Controls.Add(this.btnTemizle);
            this.grpAdSoyadSorgulama.Controls.Add(this.btnAra);
            this.grpAdSoyadSorgulama.Controls.Add(this.txtSoyad);
            this.grpAdSoyadSorgulama.Controls.Add(this.txtAd);
            this.grpAdSoyadSorgulama.Controls.Add(this.chkSoyad);
            this.grpAdSoyadSorgulama.Controls.Add(this.chkAd);
            this.grpAdSoyadSorgulama.Location = new System.Drawing.Point(20, 20);
            this.grpAdSoyadSorgulama.Name = "grpAdSoyadSorgulama";
            this.grpAdSoyadSorgulama.Size = new System.Drawing.Size(840, 110);
            this.grpAdSoyadSorgulama.TabIndex = 1;
            this.grpAdSoyadSorgulama.TabStop = false;
            this.grpAdSoyadSorgulama.Text = "Ad / Soyad ile Birebir Sorgulama";
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(735, 31);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(85, 28);
            this.btnTemizle.TabIndex = 2;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnAra
            // 
            this.btnAra.Location = new System.Drawing.Point(640, 31);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(85, 28);
            this.btnAra.TabIndex = 2;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // txtSoyad
            // 
            this.txtSoyad.Enabled = false;
            this.txtSoyad.Location = new System.Drawing.Point(435, 33);
            this.txtSoyad.Multiline = true;
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(170, 24);
            this.txtSoyad.TabIndex = 1;
            // 
            // txtAd
            // 
            this.txtAd.Enabled = false;
            this.txtAd.Location = new System.Drawing.Point(120, 33);
            this.txtAd.Multiline = true;
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(170, 24);
            this.txtAd.TabIndex = 1;
            // 
            // chkSoyad
            // 
            this.chkSoyad.AutoSize = true;
            this.chkSoyad.Location = new System.Drawing.Point(320, 35);
            this.chkSoyad.Name = "chkSoyad";
            this.chkSoyad.Size = new System.Drawing.Size(88, 17);
            this.chkSoyad.TabIndex = 0;
            this.chkSoyad.Text = "Soyada Göre";
            this.chkSoyad.UseVisualStyleBackColor = true;
            this.chkSoyad.CheckedChanged += new System.EventHandler(this.chkSoyad_CheckedChanged);
            // 
            // chkAd
            // 
            this.chkAd.AutoSize = true;
            this.chkAd.Location = new System.Drawing.Point(25, 35);
            this.chkAd.Name = "chkAd";
            this.chkAd.Size = new System.Drawing.Size(71, 17);
            this.chkAd.TabIndex = 0;
            this.chkAd.Text = "Ada Göre";
            this.chkAd.UseVisualStyleBackColor = true;
            this.chkAd.CheckedChanged += new System.EventHandler(this.chkAd_CheckedChanged);
            // 
            // dgvMusteriSorgulama
            // 
            this.dgvMusteriSorgulama.AllowUserToAddRows = false;
            this.dgvMusteriSorgulama.AllowUserToDeleteRows = false;
            this.dgvMusteriSorgulama.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMusteriSorgulama.Location = new System.Drawing.Point(20, 285);
            this.dgvMusteriSorgulama.MultiSelect = false;
            this.dgvMusteriSorgulama.Name = "dgvMusteriSorgulama";
            this.dgvMusteriSorgulama.ReadOnly = true;
            this.dgvMusteriSorgulama.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMusteriSorgulama.Size = new System.Drawing.Size(840, 300);
            this.dgvMusteriSorgulama.TabIndex = 2;
            // 
            // grpHizliSorgulama
            // 
            this.grpHizliSorgulama.Controls.Add(this.txtHizliAra);
            this.grpHizliSorgulama.Controls.Add(this.cmbAramaTuru);
            this.grpHizliSorgulama.Controls.Add(this.lblHizliBilgi);
            this.grpHizliSorgulama.Controls.Add(this.lblArananAlan);
            this.grpHizliSorgulama.Controls.Add(this.lblAramaTuru);
            this.grpHizliSorgulama.Controls.Add(this.radTcNo);
            this.grpHizliSorgulama.Controls.Add(this.radTelefon);
            this.grpHizliSorgulama.Controls.Add(this.radSoyad);
            this.grpHizliSorgulama.Controls.Add(this.radAd);
            this.grpHizliSorgulama.Location = new System.Drawing.Point(20, 145);
            this.grpHizliSorgulama.Name = "grpHizliSorgulama";
            this.grpHizliSorgulama.Size = new System.Drawing.Size(840, 125);
            this.grpHizliSorgulama.TabIndex = 3;
            this.grpHizliSorgulama.TabStop = false;
            this.grpHizliSorgulama.Text = "Hızlı / Benzer Sorgulama";
            // 
            // txtHizliAra
            // 
            this.txtHizliAra.Location = new System.Drawing.Point(120, 78);
            this.txtHizliAra.Multiline = true;
            this.txtHizliAra.Name = "txtHizliAra";
            this.txtHizliAra.Size = new System.Drawing.Size(250, 24);
            this.txtHizliAra.TabIndex = 3;
            this.txtHizliAra.TextChanged += new System.EventHandler(this.txtHizliAra_TextChanged);
            // 
            // cmbAramaTuru
            // 
            this.cmbAramaTuru.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAramaTuru.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbAramaTuru.FormattingEnabled = true;
            this.cmbAramaTuru.Items.AddRange(new object[] {
            "Seçiniz",
            "İle Başlayan",
            "İle Biten",
            "İçeren"});
            this.cmbAramaTuru.Location = new System.Drawing.Point(460, 33);
            this.cmbAramaTuru.Name = "cmbAramaTuru";
            this.cmbAramaTuru.Size = new System.Drawing.Size(150, 25);
            this.cmbAramaTuru.TabIndex = 2;
            this.cmbAramaTuru.SelectedIndexChanged += new System.EventHandler(this.cmbAramaTuru_SelectedIndexChanged);
            // 
            // lblHizliBilgi
            // 
            this.lblHizliBilgi.AutoSize = true;
            this.lblHizliBilgi.Location = new System.Drawing.Point(457, 81);
            this.lblHizliBilgi.Name = "lblHizliBilgi";
            this.lblHizliBilgi.Size = new System.Drawing.Size(233, 13);
            this.lblHizliBilgi.TabIndex = 1;
            this.lblHizliBilgi.Text = "Arama yapılacak alanı seçip yazmaya başlayınız.";
            // 
            // lblArananAlan
            // 
            this.lblArananAlan.AutoSize = true;
            this.lblArananAlan.Location = new System.Drawing.Point(25, 82);
            this.lblArananAlan.Name = "lblArananAlan";
            this.lblArananAlan.Size = new System.Drawing.Size(65, 13);
            this.lblArananAlan.TabIndex = 1;
            this.lblArananAlan.Text = "Aranan Alan";
            // 
            // lblAramaTuru
            // 
            this.lblAramaTuru.AutoSize = true;
            this.lblAramaTuru.Location = new System.Drawing.Point(370, 36);
            this.lblAramaTuru.Name = "lblAramaTuru";
            this.lblAramaTuru.Size = new System.Drawing.Size(65, 13);
            this.lblAramaTuru.TabIndex = 1;
            this.lblAramaTuru.Text = "Arama Türü:";
            // 
            // radTcNo
            // 
            this.radTcNo.AutoSize = true;
            this.radTcNo.Location = new System.Drawing.Point(280, 35);
            this.radTcNo.Name = "radTcNo";
            this.radTcNo.Size = new System.Drawing.Size(56, 17);
            this.radTcNo.TabIndex = 0;
            this.radTcNo.TabStop = true;
            this.radTcNo.Text = "TC No";
            this.radTcNo.UseVisualStyleBackColor = true;
            this.radTcNo.CheckedChanged += new System.EventHandler(this.radTcNo_CheckedChanged);
            // 
            // radTelefon
            // 
            this.radTelefon.AutoSize = true;
            this.radTelefon.Location = new System.Drawing.Point(185, 35);
            this.radTelefon.Name = "radTelefon";
            this.radTelefon.Size = new System.Drawing.Size(61, 17);
            this.radTelefon.TabIndex = 0;
            this.radTelefon.TabStop = true;
            this.radTelefon.Text = "Telefon";
            this.radTelefon.UseVisualStyleBackColor = true;
            this.radTelefon.CheckedChanged += new System.EventHandler(this.radTelefon_CheckedChanged);
            // 
            // radSoyad
            // 
            this.radSoyad.AutoSize = true;
            this.radSoyad.Location = new System.Drawing.Point(95, 35);
            this.radSoyad.Name = "radSoyad";
            this.radSoyad.Size = new System.Drawing.Size(55, 17);
            this.radSoyad.TabIndex = 0;
            this.radSoyad.TabStop = true;
            this.radSoyad.Text = "Soyad";
            this.radSoyad.UseVisualStyleBackColor = true;
            this.radSoyad.CheckedChanged += new System.EventHandler(this.radSoyad_CheckedChanged);
            // 
            // radAd
            // 
            this.radAd.AutoSize = true;
            this.radAd.Location = new System.Drawing.Point(25, 35);
            this.radAd.Name = "radAd";
            this.radAd.Size = new System.Drawing.Size(38, 17);
            this.radAd.TabIndex = 0;
            this.radAd.TabStop = true;
            this.radAd.Text = "Ad";
            this.radAd.UseVisualStyleBackColor = true;
            this.radAd.CheckedChanged += new System.EventHandler(this.radAd_CheckedChanged);
            // 
            // FrmMusteriSorgulama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 611);
            this.Controls.Add(this.grpHizliSorgulama);
            this.Controls.Add(this.dgvMusteriSorgulama);
            this.Controls.Add(this.grpAdSoyadSorgulama);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmMusteriSorgulama";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Müşteri Sorgulama";
            this.Load += new System.EventHandler(this.FrmMusteriSorgulama_Load);
            this.grpAdSoyadSorgulama.ResumeLayout(false);
            this.grpAdSoyadSorgulama.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMusteriSorgulama)).EndInit();
            this.grpHizliSorgulama.ResumeLayout(false);
            this.grpHizliSorgulama.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpAdSoyadSorgulama;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.CheckBox chkSoyad;
        private System.Windows.Forms.CheckBox chkAd;
        private System.Windows.Forms.DataGridView dgvMusteriSorgulama;
        private System.Windows.Forms.GroupBox grpHizliSorgulama;
        private System.Windows.Forms.TextBox txtHizliAra;
        private System.Windows.Forms.ComboBox cmbAramaTuru;
        private System.Windows.Forms.Label lblHizliBilgi;
        private System.Windows.Forms.Label lblArananAlan;
        private System.Windows.Forms.Label lblAramaTuru;
        private System.Windows.Forms.RadioButton radTcNo;
        private System.Windows.Forms.RadioButton radTelefon;
        private System.Windows.Forms.RadioButton radSoyad;
        private System.Windows.Forms.RadioButton radAd;
    }
}