
namespace PrimeSalon
{
    partial class FrmHizmetSorgulama
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
            this.grpHizmetSorgulama = new System.Windows.Forms.GroupBox();
            this.cmbKategori = new System.Windows.Forms.ComboBox();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnAra = new System.Windows.Forms.Button();
            this.txtHizmetAdi = new System.Windows.Forms.TextBox();
            this.chkKategori = new System.Windows.Forms.CheckBox();
            this.chkHizmetAdi = new System.Windows.Forms.CheckBox();
            this.dgvHizmetSorgulama = new System.Windows.Forms.DataGridView();
            this.grpHizliSorgulama = new System.Windows.Forms.GroupBox();
            this.txtHizliAra = new System.Windows.Forms.TextBox();
            this.cmbAramaTuru = new System.Windows.Forms.ComboBox();
            this.lblHizliBilgi = new System.Windows.Forms.Label();
            this.lblArananAlan = new System.Windows.Forms.Label();
            this.radKategori = new System.Windows.Forms.RadioButton();
            this.radHizmetAdi = new System.Windows.Forms.RadioButton();
            this.lblAramaTuru = new System.Windows.Forms.Label();
            this.grpHizmetSorgulama.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHizmetSorgulama)).BeginInit();
            this.grpHizliSorgulama.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpHizmetSorgulama
            // 
            this.grpHizmetSorgulama.Controls.Add(this.cmbKategori);
            this.grpHizmetSorgulama.Controls.Add(this.btnTemizle);
            this.grpHizmetSorgulama.Controls.Add(this.btnAra);
            this.grpHizmetSorgulama.Controls.Add(this.txtHizmetAdi);
            this.grpHizmetSorgulama.Controls.Add(this.chkKategori);
            this.grpHizmetSorgulama.Controls.Add(this.chkHizmetAdi);
            this.grpHizmetSorgulama.Location = new System.Drawing.Point(20, 20);
            this.grpHizmetSorgulama.Name = "grpHizmetSorgulama";
            this.grpHizmetSorgulama.Size = new System.Drawing.Size(840, 110);
            this.grpHizmetSorgulama.TabIndex = 1;
            this.grpHizmetSorgulama.TabStop = false;
            this.grpHizmetSorgulama.Text = "Hizmet Adı / Kategori ile Birebir Sorgulama";
            // 
            // cmbKategori
            // 
            this.cmbKategori.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKategori.Enabled = false;
            this.cmbKategori.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbKategori.FormattingEnabled = true;
            this.cmbKategori.Items.AddRange(new object[] {
            "Seçiniz",
            "Saç Kesim ve Şekillendirme",
            "Sakal ve Bıyık İşlemleri",
            "Yıkama ve Fön İşlemleri",
            "Cilt ve Yüz Bakımı",
            "Saç ve Sakal Boyama",
            "Özel Saç Bakımları",
            "Ağda ve Epilasyon İşlemleri",
            "Çocuk Tıraşı",
            "Damat Tıraşı",
            "Masaj ve Rahatlama"});
            this.cmbKategori.Location = new System.Drawing.Point(467, 30);
            this.cmbKategori.Name = "cmbKategori";
            this.cmbKategori.Size = new System.Drawing.Size(169, 25);
            this.cmbKategori.TabIndex = 3;
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(750, 31);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(85, 28);
            this.btnTemizle.TabIndex = 2;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnAra
            // 
            this.btnAra.Location = new System.Drawing.Point(659, 31);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(85, 28);
            this.btnAra.TabIndex = 2;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // txtHizmetAdi
            // 
            this.txtHizmetAdi.Enabled = false;
            this.txtHizmetAdi.Location = new System.Drawing.Point(145, 31);
            this.txtHizmetAdi.Multiline = true;
            this.txtHizmetAdi.Name = "txtHizmetAdi";
            this.txtHizmetAdi.Size = new System.Drawing.Size(170, 24);
            this.txtHizmetAdi.TabIndex = 1;
            // 
            // chkKategori
            // 
            this.chkKategori.AutoSize = true;
            this.chkKategori.Location = new System.Drawing.Point(350, 35);
            this.chkKategori.Name = "chkKategori";
            this.chkKategori.Size = new System.Drawing.Size(102, 17);
            this.chkKategori.TabIndex = 0;
            this.chkKategori.Text = "Kategoriye Göre";
            this.chkKategori.UseVisualStyleBackColor = true;
            this.chkKategori.CheckedChanged += new System.EventHandler(this.chkKategori_CheckedChanged);
            // 
            // chkHizmetAdi
            // 
            this.chkHizmetAdi.AutoSize = true;
            this.chkHizmetAdi.Location = new System.Drawing.Point(25, 35);
            this.chkHizmetAdi.Name = "chkHizmetAdi";
            this.chkHizmetAdi.Size = new System.Drawing.Size(114, 17);
            this.chkHizmetAdi.TabIndex = 0;
            this.chkHizmetAdi.Text = "Hizmet Adına Göre";
            this.chkHizmetAdi.UseVisualStyleBackColor = true;
            this.chkHizmetAdi.CheckedChanged += new System.EventHandler(this.chkHizmetAdi_CheckedChanged);
            // 
            // dgvHizmetSorgulama
            // 
            this.dgvHizmetSorgulama.AllowUserToAddRows = false;
            this.dgvHizmetSorgulama.AllowUserToDeleteRows = false;
            this.dgvHizmetSorgulama.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHizmetSorgulama.Location = new System.Drawing.Point(20, 285);
            this.dgvHizmetSorgulama.MultiSelect = false;
            this.dgvHizmetSorgulama.Name = "dgvHizmetSorgulama";
            this.dgvHizmetSorgulama.ReadOnly = true;
            this.dgvHizmetSorgulama.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHizmetSorgulama.Size = new System.Drawing.Size(840, 300);
            this.dgvHizmetSorgulama.TabIndex = 2;
            // 
            // grpHizliSorgulama
            // 
            this.grpHizliSorgulama.Controls.Add(this.txtHizliAra);
            this.grpHizliSorgulama.Controls.Add(this.cmbAramaTuru);
            this.grpHizliSorgulama.Controls.Add(this.lblHizliBilgi);
            this.grpHizliSorgulama.Controls.Add(this.lblArananAlan);
            this.grpHizliSorgulama.Controls.Add(this.lblAramaTuru);
            this.grpHizliSorgulama.Controls.Add(this.radKategori);
            this.grpHizliSorgulama.Controls.Add(this.radHizmetAdi);
            this.grpHizliSorgulama.Location = new System.Drawing.Point(20, 145);
            this.grpHizliSorgulama.Name = "grpHizliSorgulama";
            this.grpHizliSorgulama.Size = new System.Drawing.Size(840, 125);
            this.grpHizliSorgulama.TabIndex = 4;
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
            this.cmbAramaTuru.Location = new System.Drawing.Point(340, 33);
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
            // radKategori
            // 
            this.radKategori.AutoSize = true;
            this.radKategori.Location = new System.Drawing.Point(135, 35);
            this.radKategori.Name = "radKategori";
            this.radKategori.Size = new System.Drawing.Size(64, 17);
            this.radKategori.TabIndex = 0;
            this.radKategori.TabStop = true;
            this.radKategori.Text = "Kategori";
            this.radKategori.UseVisualStyleBackColor = true;
            this.radKategori.CheckedChanged += new System.EventHandler(this.radKategori_CheckedChanged);
            // 
            // radHizmetAdi
            // 
            this.radHizmetAdi.AutoSize = true;
            this.radHizmetAdi.Location = new System.Drawing.Point(25, 35);
            this.radHizmetAdi.Name = "radHizmetAdi";
            this.radHizmetAdi.Size = new System.Drawing.Size(75, 17);
            this.radHizmetAdi.TabIndex = 0;
            this.radHizmetAdi.TabStop = true;
            this.radHizmetAdi.Text = "Hizmet Adı";
            this.radHizmetAdi.UseVisualStyleBackColor = true;
            this.radHizmetAdi.CheckedChanged += new System.EventHandler(this.radHizmetAdi_CheckedChanged);
            // 
            // lblAramaTuru
            // 
            this.lblAramaTuru.AutoSize = true;
            this.lblAramaTuru.Location = new System.Drawing.Point(250, 36);
            this.lblAramaTuru.Name = "lblAramaTuru";
            this.lblAramaTuru.Size = new System.Drawing.Size(65, 13);
            this.lblAramaTuru.TabIndex = 1;
            this.lblAramaTuru.Text = "Arama Türü:";
            // 
            // FrmHizmetSorgulama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 611);
            this.Controls.Add(this.grpHizliSorgulama);
            this.Controls.Add(this.dgvHizmetSorgulama);
            this.Controls.Add(this.grpHizmetSorgulama);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmHizmetSorgulama";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hizmet Sorgulama";
            this.Load += new System.EventHandler(this.FrmHizmetSorgulama_Load);
            this.grpHizmetSorgulama.ResumeLayout(false);
            this.grpHizmetSorgulama.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHizmetSorgulama)).EndInit();
            this.grpHizliSorgulama.ResumeLayout(false);
            this.grpHizliSorgulama.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpHizmetSorgulama;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.TextBox txtHizmetAdi;
        private System.Windows.Forms.CheckBox chkKategori;
        private System.Windows.Forms.CheckBox chkHizmetAdi;
        private System.Windows.Forms.DataGridView dgvHizmetSorgulama;
        private System.Windows.Forms.ComboBox cmbKategori;
        private System.Windows.Forms.GroupBox grpHizliSorgulama;
        private System.Windows.Forms.TextBox txtHizliAra;
        private System.Windows.Forms.ComboBox cmbAramaTuru;
        private System.Windows.Forms.Label lblHizliBilgi;
        private System.Windows.Forms.Label lblArananAlan;
        private System.Windows.Forms.Label lblAramaTuru;
        private System.Windows.Forms.RadioButton radKategori;
        private System.Windows.Forms.RadioButton radHizmetAdi;
    }
}