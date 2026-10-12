
namespace PrimeSalon
{
    partial class FrmKasaHareketleriSorgulama
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
            this.grpKasaSorgulama = new System.Windows.Forms.GroupBox();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnAra = new System.Windows.Forms.Button();
            this.cmbIslemKategorisi = new System.Windows.Forms.ComboBox();
            this.chkIslemKategorisi = new System.Windows.Forms.CheckBox();
            this.cmbIslemTipi = new System.Windows.Forms.ComboBox();
            this.chkIslemTipi = new System.Windows.Forms.CheckBox();
            this.dgvKasaHareketleriSorgulama = new System.Windows.Forms.DataGridView();
            this.grpHizliSorgulama = new System.Windows.Forms.GroupBox();
            this.txtHizliAra = new System.Windows.Forms.TextBox();
            this.cmbAramaTuru = new System.Windows.Forms.ComboBox();
            this.lblHizliBilgi = new System.Windows.Forms.Label();
            this.lblArananAlan = new System.Windows.Forms.Label();
            this.lblAramaTuru = new System.Windows.Forms.Label();
            this.radIslemKategorisi = new System.Windows.Forms.RadioButton();
            this.radIslemTipi = new System.Windows.Forms.RadioButton();
            this.radIslemiYapan = new System.Windows.Forms.RadioButton();
            this.grpKasaSorgulama.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKasaHareketleriSorgulama)).BeginInit();
            this.grpHizliSorgulama.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpKasaSorgulama
            // 
            this.grpKasaSorgulama.Controls.Add(this.btnTemizle);
            this.grpKasaSorgulama.Controls.Add(this.btnAra);
            this.grpKasaSorgulama.Controls.Add(this.cmbIslemKategorisi);
            this.grpKasaSorgulama.Controls.Add(this.chkIslemKategorisi);
            this.grpKasaSorgulama.Controls.Add(this.cmbIslemTipi);
            this.grpKasaSorgulama.Controls.Add(this.chkIslemTipi);
            this.grpKasaSorgulama.Location = new System.Drawing.Point(20, 20);
            this.grpKasaSorgulama.Name = "grpKasaSorgulama";
            this.grpKasaSorgulama.Size = new System.Drawing.Size(840, 110);
            this.grpKasaSorgulama.TabIndex = 3;
            this.grpKasaSorgulama.TabStop = false;
            this.grpKasaSorgulama.Text = "İşlem Tipi / İşlem Kategorisi ile Birebir Sorgulama";
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(740, 31);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(85, 28);
            this.btnTemizle.TabIndex = 2;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnAra
            // 
            this.btnAra.Location = new System.Drawing.Point(649, 31);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(85, 28);
            this.btnAra.TabIndex = 2;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // cmbIslemKategorisi
            // 
            this.cmbIslemKategorisi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIslemKategorisi.Enabled = false;
            this.cmbIslemKategorisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbIslemKategorisi.FormattingEnabled = true;
            this.cmbIslemKategorisi.Items.AddRange(new object[] {
            "Seçiniz",
            "Satış",
            "Gider",
            "Maaş",
            "Diğer"});
            this.cmbIslemKategorisi.Location = new System.Drawing.Point(487, 33);
            this.cmbIslemKategorisi.Name = "cmbIslemKategorisi";
            this.cmbIslemKategorisi.Size = new System.Drawing.Size(148, 25);
            this.cmbIslemKategorisi.TabIndex = 1;
            // 
            // chkIslemKategorisi
            // 
            this.chkIslemKategorisi.AutoSize = true;
            this.chkIslemKategorisi.Location = new System.Drawing.Point(328, 35);
            this.chkIslemKategorisi.Name = "chkIslemKategorisi";
            this.chkIslemKategorisi.Size = new System.Drawing.Size(137, 17);
            this.chkIslemKategorisi.TabIndex = 0;
            this.chkIslemKategorisi.Text = "İşlem Kategorisine Göre";
            this.chkIslemKategorisi.UseVisualStyleBackColor = true;
            this.chkIslemKategorisi.CheckedChanged += new System.EventHandler(this.chkIslemKategorisi_CheckedChanged);
            // 
            // cmbIslemTipi
            // 
            this.cmbIslemTipi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIslemTipi.Enabled = false;
            this.cmbIslemTipi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbIslemTipi.FormattingEnabled = true;
            this.cmbIslemTipi.Items.AddRange(new object[] {
            "Seçiniz",
            "Tahsilat",
            "Ödeme"});
            this.cmbIslemTipi.Location = new System.Drawing.Point(148, 33);
            this.cmbIslemTipi.Name = "cmbIslemTipi";
            this.cmbIslemTipi.Size = new System.Drawing.Size(159, 25);
            this.cmbIslemTipi.TabIndex = 1;
            // 
            // chkIslemTipi
            // 
            this.chkIslemTipi.AutoSize = true;
            this.chkIslemTipi.Location = new System.Drawing.Point(25, 35);
            this.chkIslemTipi.Name = "chkIslemTipi";
            this.chkIslemTipi.Size = new System.Drawing.Size(108, 17);
            this.chkIslemTipi.TabIndex = 0;
            this.chkIslemTipi.Text = "İşlem Tipine Göre";
            this.chkIslemTipi.UseVisualStyleBackColor = true;
            this.chkIslemTipi.CheckedChanged += new System.EventHandler(this.chkIslemTipi_CheckedChanged);
            // 
            // dgvKasaHareketleriSorgulama
            // 
            this.dgvKasaHareketleriSorgulama.AllowUserToAddRows = false;
            this.dgvKasaHareketleriSorgulama.AllowUserToDeleteRows = false;
            this.dgvKasaHareketleriSorgulama.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKasaHareketleriSorgulama.Location = new System.Drawing.Point(20, 285);
            this.dgvKasaHareketleriSorgulama.MultiSelect = false;
            this.dgvKasaHareketleriSorgulama.Name = "dgvKasaHareketleriSorgulama";
            this.dgvKasaHareketleriSorgulama.ReadOnly = true;
            this.dgvKasaHareketleriSorgulama.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKasaHareketleriSorgulama.Size = new System.Drawing.Size(840, 300);
            this.dgvKasaHareketleriSorgulama.TabIndex = 4;
            // 
            // grpHizliSorgulama
            // 
            this.grpHizliSorgulama.Controls.Add(this.txtHizliAra);
            this.grpHizliSorgulama.Controls.Add(this.cmbAramaTuru);
            this.grpHizliSorgulama.Controls.Add(this.lblHizliBilgi);
            this.grpHizliSorgulama.Controls.Add(this.lblArananAlan);
            this.grpHizliSorgulama.Controls.Add(this.lblAramaTuru);
            this.grpHizliSorgulama.Controls.Add(this.radIslemKategorisi);
            this.grpHizliSorgulama.Controls.Add(this.radIslemTipi);
            this.grpHizliSorgulama.Controls.Add(this.radIslemiYapan);
            this.grpHizliSorgulama.Location = new System.Drawing.Point(20, 145);
            this.grpHizliSorgulama.Name = "grpHizliSorgulama";
            this.grpHizliSorgulama.Size = new System.Drawing.Size(840, 125);
            this.grpHizliSorgulama.TabIndex = 9;
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
            this.cmbAramaTuru.Location = new System.Drawing.Point(500, 33);
            this.cmbAramaTuru.Name = "cmbAramaTuru";
            this.cmbAramaTuru.Size = new System.Drawing.Size(150, 25);
            this.cmbAramaTuru.TabIndex = 2;
            this.cmbAramaTuru.SelectedIndexChanged += new System.EventHandler(this.cmbAramaTuru_SelectedIndexChanged);
            // 
            // lblHizliBilgi
            // 
            this.lblHizliBilgi.AutoSize = true;
            this.lblHizliBilgi.Location = new System.Drawing.Point(390, 82);
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
            this.lblAramaTuru.Location = new System.Drawing.Point(410, 36);
            this.lblAramaTuru.Name = "lblAramaTuru";
            this.lblAramaTuru.Size = new System.Drawing.Size(65, 13);
            this.lblAramaTuru.TabIndex = 1;
            this.lblAramaTuru.Text = "Arama Türü:";
            // 
            // radIslemKategorisi
            // 
            this.radIslemKategorisi.AutoSize = true;
            this.radIslemKategorisi.Location = new System.Drawing.Point(255, 35);
            this.radIslemKategorisi.Name = "radIslemKategorisi";
            this.radIslemKategorisi.Size = new System.Drawing.Size(98, 17);
            this.radIslemKategorisi.TabIndex = 0;
            this.radIslemKategorisi.TabStop = true;
            this.radIslemKategorisi.Text = "İşlem Kategorisi";
            this.radIslemKategorisi.UseVisualStyleBackColor = true;
            this.radIslemKategorisi.CheckedChanged += new System.EventHandler(this.radIslemKategorisi_CheckedChanged);
            // 
            // radIslemTipi
            // 
            this.radIslemTipi.AutoSize = true;
            this.radIslemTipi.Location = new System.Drawing.Point(150, 35);
            this.radIslemTipi.Name = "radIslemTipi";
            this.radIslemTipi.Size = new System.Drawing.Size(69, 17);
            this.radIslemTipi.TabIndex = 0;
            this.radIslemTipi.TabStop = true;
            this.radIslemTipi.Text = "İşlem Tipi";
            this.radIslemTipi.UseVisualStyleBackColor = true;
            this.radIslemTipi.CheckedChanged += new System.EventHandler(this.radIslemTipi_CheckedChanged);
            // 
            // radIslemiYapan
            // 
            this.radIslemiYapan.AutoSize = true;
            this.radIslemiYapan.Location = new System.Drawing.Point(25, 35);
            this.radIslemiYapan.Name = "radIslemiYapan";
            this.radIslemiYapan.Size = new System.Drawing.Size(85, 17);
            this.radIslemiYapan.TabIndex = 0;
            this.radIslemiYapan.TabStop = true;
            this.radIslemiYapan.Text = "İşlemi Yapan";
            this.radIslemiYapan.UseVisualStyleBackColor = true;
            this.radIslemiYapan.CheckedChanged += new System.EventHandler(this.radIslemiYapan_CheckedChanged);
            // 
            // FrmKasaHareketleriSorgulama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 611);
            this.Controls.Add(this.grpHizliSorgulama);
            this.Controls.Add(this.dgvKasaHareketleriSorgulama);
            this.Controls.Add(this.grpKasaSorgulama);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmKasaHareketleriSorgulama";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kasa Hareketleri Sorgulama";
            this.Load += new System.EventHandler(this.FrmKasaHareketleriSorgulama_Load);
            this.grpKasaSorgulama.ResumeLayout(false);
            this.grpKasaSorgulama.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKasaHareketleriSorgulama)).EndInit();
            this.grpHizliSorgulama.ResumeLayout(false);
            this.grpHizliSorgulama.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpKasaSorgulama;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.ComboBox cmbIslemKategorisi;
        private System.Windows.Forms.CheckBox chkIslemKategorisi;
        private System.Windows.Forms.ComboBox cmbIslemTipi;
        private System.Windows.Forms.CheckBox chkIslemTipi;
        private System.Windows.Forms.DataGridView dgvKasaHareketleriSorgulama;
        private System.Windows.Forms.GroupBox grpHizliSorgulama;
        private System.Windows.Forms.TextBox txtHizliAra;
        private System.Windows.Forms.ComboBox cmbAramaTuru;
        private System.Windows.Forms.Label lblHizliBilgi;
        private System.Windows.Forms.Label lblArananAlan;
        private System.Windows.Forms.Label lblAramaTuru;
        private System.Windows.Forms.RadioButton radIslemKategorisi;
        private System.Windows.Forms.RadioButton radIslemTipi;
        private System.Windows.Forms.RadioButton radIslemiYapan;
    }
}