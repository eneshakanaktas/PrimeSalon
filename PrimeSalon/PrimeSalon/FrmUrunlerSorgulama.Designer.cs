
namespace PrimeSalon
{
    partial class FrmUrunlerSorgulama
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
            this.grpUrunSorgulama = new System.Windows.Forms.GroupBox();
            this.cmbKategori = new System.Windows.Forms.ComboBox();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnAra = new System.Windows.Forms.Button();
            this.txtMarka = new System.Windows.Forms.TextBox();
            this.chkKategori = new System.Windows.Forms.CheckBox();
            this.chkMarka = new System.Windows.Forms.CheckBox();
            this.dgvUrunlerSorgulama = new System.Windows.Forms.DataGridView();
            this.grpHizliSorgulama = new System.Windows.Forms.GroupBox();
            this.txtHizliAra = new System.Windows.Forms.TextBox();
            this.cmbAramaTuru = new System.Windows.Forms.ComboBox();
            this.lblHizliBilgi = new System.Windows.Forms.Label();
            this.lblArananAlan = new System.Windows.Forms.Label();
            this.lblAramaTuru = new System.Windows.Forms.Label();
            this.radKategori = new System.Windows.Forms.RadioButton();
            this.radMarka = new System.Windows.Forms.RadioButton();
            this.radUrunAdi = new System.Windows.Forms.RadioButton();
            this.grpUrunSorgulama.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUrunlerSorgulama)).BeginInit();
            this.grpHizliSorgulama.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpUrunSorgulama
            // 
            this.grpUrunSorgulama.Controls.Add(this.cmbKategori);
            this.grpUrunSorgulama.Controls.Add(this.btnTemizle);
            this.grpUrunSorgulama.Controls.Add(this.btnAra);
            this.grpUrunSorgulama.Controls.Add(this.txtMarka);
            this.grpUrunSorgulama.Controls.Add(this.chkKategori);
            this.grpUrunSorgulama.Controls.Add(this.chkMarka);
            this.grpUrunSorgulama.Location = new System.Drawing.Point(20, 20);
            this.grpUrunSorgulama.Name = "grpUrunSorgulama";
            this.grpUrunSorgulama.Size = new System.Drawing.Size(840, 110);
            this.grpUrunSorgulama.TabIndex = 4;
            this.grpUrunSorgulama.TabStop = false;
            this.grpUrunSorgulama.Text = "Marka / Kategori ile Birebir Sorgulama";
            // 
            // cmbKategori
            // 
            this.cmbKategori.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKategori.Enabled = false;
            this.cmbKategori.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbKategori.FormattingEnabled = true;
            this.cmbKategori.Items.AddRange(new object[] {
            "Seçiniz",
            "Şampuan",
            "Jöle",
            "Wax",
            "Köpük",
            "Kolonya",
            "Bakım Ürünü",
            "Diğer"});
            this.cmbKategori.Location = new System.Drawing.Point(460, 33);
            this.cmbKategori.Name = "cmbKategori";
            this.cmbKategori.Size = new System.Drawing.Size(173, 25);
            this.cmbKategori.TabIndex = 3;
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(741, 31);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(85, 28);
            this.btnTemizle.TabIndex = 2;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnAra
            // 
            this.btnAra.Location = new System.Drawing.Point(651, 31);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(85, 28);
            this.btnAra.TabIndex = 2;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // txtMarka
            // 
            this.txtMarka.Enabled = false;
            this.txtMarka.Location = new System.Drawing.Point(140, 33);
            this.txtMarka.Multiline = true;
            this.txtMarka.Name = "txtMarka";
            this.txtMarka.Size = new System.Drawing.Size(170, 24);
            this.txtMarka.TabIndex = 1;
            // 
            // chkKategori
            // 
            this.chkKategori.AutoSize = true;
            this.chkKategori.Location = new System.Drawing.Point(340, 35);
            this.chkKategori.Name = "chkKategori";
            this.chkKategori.Size = new System.Drawing.Size(102, 17);
            this.chkKategori.TabIndex = 0;
            this.chkKategori.Text = "Kategoriye Göre";
            this.chkKategori.UseVisualStyleBackColor = true;
            this.chkKategori.CheckedChanged += new System.EventHandler(this.chkKategori_CheckedChanged);
            // 
            // chkMarka
            // 
            this.chkMarka.AutoSize = true;
            this.chkMarka.Location = new System.Drawing.Point(25, 35);
            this.chkMarka.Name = "chkMarka";
            this.chkMarka.Size = new System.Drawing.Size(93, 17);
            this.chkMarka.TabIndex = 0;
            this.chkMarka.Text = "Markaya Göre";
            this.chkMarka.UseVisualStyleBackColor = true;
            this.chkMarka.CheckedChanged += new System.EventHandler(this.chkMarka_CheckedChanged);
            // 
            // dgvUrunlerSorgulama
            // 
            this.dgvUrunlerSorgulama.AllowUserToAddRows = false;
            this.dgvUrunlerSorgulama.AllowUserToDeleteRows = false;
            this.dgvUrunlerSorgulama.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUrunlerSorgulama.Location = new System.Drawing.Point(20, 285);
            this.dgvUrunlerSorgulama.MultiSelect = false;
            this.dgvUrunlerSorgulama.Name = "dgvUrunlerSorgulama";
            this.dgvUrunlerSorgulama.ReadOnly = true;
            this.dgvUrunlerSorgulama.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUrunlerSorgulama.Size = new System.Drawing.Size(840, 300);
            this.dgvUrunlerSorgulama.TabIndex = 5;
            // 
            // grpHizliSorgulama
            // 
            this.grpHizliSorgulama.Controls.Add(this.txtHizliAra);
            this.grpHizliSorgulama.Controls.Add(this.cmbAramaTuru);
            this.grpHizliSorgulama.Controls.Add(this.lblHizliBilgi);
            this.grpHizliSorgulama.Controls.Add(this.lblArananAlan);
            this.grpHizliSorgulama.Controls.Add(this.lblAramaTuru);
            this.grpHizliSorgulama.Controls.Add(this.radKategori);
            this.grpHizliSorgulama.Controls.Add(this.radMarka);
            this.grpHizliSorgulama.Controls.Add(this.radUrunAdi);
            this.grpHizliSorgulama.Location = new System.Drawing.Point(20, 145);
            this.grpHizliSorgulama.Name = "grpHizliSorgulama";
            this.grpHizliSorgulama.Size = new System.Drawing.Size(840, 125);
            this.grpHizliSorgulama.TabIndex = 6;
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
            this.cmbAramaTuru.Location = new System.Drawing.Point(415, 33);
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
            this.lblAramaTuru.Location = new System.Drawing.Point(325, 36);
            this.lblAramaTuru.Name = "lblAramaTuru";
            this.lblAramaTuru.Size = new System.Drawing.Size(65, 13);
            this.lblAramaTuru.TabIndex = 1;
            this.lblAramaTuru.Text = "Arama Türü:";
            // 
            // radKategori
            // 
            this.radKategori.AutoSize = true;
            this.radKategori.Location = new System.Drawing.Point(210, 35);
            this.radKategori.Name = "radKategori";
            this.radKategori.Size = new System.Drawing.Size(64, 17);
            this.radKategori.TabIndex = 0;
            this.radKategori.TabStop = true;
            this.radKategori.Text = "Kategori";
            this.radKategori.UseVisualStyleBackColor = true;
            this.radKategori.CheckedChanged += new System.EventHandler(this.radKategori_CheckedChanged);
            // 
            // radMarka
            // 
            this.radMarka.AutoSize = true;
            this.radMarka.Location = new System.Drawing.Point(125, 35);
            this.radMarka.Name = "radMarka";
            this.radMarka.Size = new System.Drawing.Size(55, 17);
            this.radMarka.TabIndex = 0;
            this.radMarka.TabStop = true;
            this.radMarka.Text = "Marka";
            this.radMarka.UseVisualStyleBackColor = true;
            this.radMarka.CheckedChanged += new System.EventHandler(this.radMarka_CheckedChanged);
            // 
            // radUrunAdi
            // 
            this.radUrunAdi.AutoSize = true;
            this.radUrunAdi.Location = new System.Drawing.Point(25, 35);
            this.radUrunAdi.Name = "radUrunAdi";
            this.radUrunAdi.Size = new System.Drawing.Size(66, 17);
            this.radUrunAdi.TabIndex = 0;
            this.radUrunAdi.TabStop = true;
            this.radUrunAdi.Text = "Ürün Adı";
            this.radUrunAdi.UseVisualStyleBackColor = true;
            this.radUrunAdi.CheckedChanged += new System.EventHandler(this.radUrunAdi_CheckedChanged);
            // 
            // FrmUrunlerSorgulama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 611);
            this.Controls.Add(this.grpHizliSorgulama);
            this.Controls.Add(this.dgvUrunlerSorgulama);
            this.Controls.Add(this.grpUrunSorgulama);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmUrunlerSorgulama";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ürünler Sorgulama";
            this.Load += new System.EventHandler(this.FrmUrunlerSorgulama_Load);
            this.grpUrunSorgulama.ResumeLayout(false);
            this.grpUrunSorgulama.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUrunlerSorgulama)).EndInit();
            this.grpHizliSorgulama.ResumeLayout(false);
            this.grpHizliSorgulama.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpUrunSorgulama;
        private System.Windows.Forms.ComboBox cmbKategori;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.TextBox txtMarka;
        private System.Windows.Forms.CheckBox chkKategori;
        private System.Windows.Forms.CheckBox chkMarka;
        private System.Windows.Forms.DataGridView dgvUrunlerSorgulama;
        private System.Windows.Forms.GroupBox grpHizliSorgulama;
        private System.Windows.Forms.TextBox txtHizliAra;
        private System.Windows.Forms.ComboBox cmbAramaTuru;
        private System.Windows.Forms.Label lblHizliBilgi;
        private System.Windows.Forms.Label lblArananAlan;
        private System.Windows.Forms.Label lblAramaTuru;
        private System.Windows.Forms.RadioButton radKategori;
        private System.Windows.Forms.RadioButton radMarka;
        private System.Windows.Forms.RadioButton radUrunAdi;
    }
}