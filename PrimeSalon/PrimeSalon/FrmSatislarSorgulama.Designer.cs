
namespace PrimeSalon
{
    partial class FrmSatislarSorgulama
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
            this.grpSatisSorgulama = new System.Windows.Forms.GroupBox();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnAra = new System.Windows.Forms.Button();
            this.cmbOdemeDurumu = new System.Windows.Forms.ComboBox();
            this.chkOdemeDurumu = new System.Windows.Forms.CheckBox();
            this.cmbSatisTipi = new System.Windows.Forms.ComboBox();
            this.chkSatisTipi = new System.Windows.Forms.CheckBox();
            this.dgvSatislarSorgulama = new System.Windows.Forms.DataGridView();
            this.grpHizliSorgulama = new System.Windows.Forms.GroupBox();
            this.txtHizliAra = new System.Windows.Forms.TextBox();
            this.cmbAramaTuru = new System.Windows.Forms.ComboBox();
            this.lblHizliBilgi = new System.Windows.Forms.Label();
            this.lblArananAlan = new System.Windows.Forms.Label();
            this.lblAramaTuru = new System.Windows.Forms.Label();
            this.radOdemeDurumu = new System.Windows.Forms.RadioButton();
            this.radOdemeTipi = new System.Windows.Forms.RadioButton();
            this.radSatisTipi = new System.Windows.Forms.RadioButton();
            this.grpSatisSorgulama.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSatislarSorgulama)).BeginInit();
            this.grpHizliSorgulama.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpSatisSorgulama
            // 
            this.grpSatisSorgulama.Controls.Add(this.btnTemizle);
            this.grpSatisSorgulama.Controls.Add(this.btnAra);
            this.grpSatisSorgulama.Controls.Add(this.cmbOdemeDurumu);
            this.grpSatisSorgulama.Controls.Add(this.chkOdemeDurumu);
            this.grpSatisSorgulama.Controls.Add(this.cmbSatisTipi);
            this.grpSatisSorgulama.Controls.Add(this.chkSatisTipi);
            this.grpSatisSorgulama.Location = new System.Drawing.Point(20, 20);
            this.grpSatisSorgulama.Name = "grpSatisSorgulama";
            this.grpSatisSorgulama.Size = new System.Drawing.Size(840, 110);
            this.grpSatisSorgulama.TabIndex = 2;
            this.grpSatisSorgulama.TabStop = false;
            this.grpSatisSorgulama.Text = "Satış Tipi / Ödeme Durumu ile Birebir Sorgulama";
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
            this.cmbOdemeDurumu.Location = new System.Drawing.Point(487, 33);
            this.cmbOdemeDurumu.Name = "cmbOdemeDurumu";
            this.cmbOdemeDurumu.Size = new System.Drawing.Size(148, 25);
            this.cmbOdemeDurumu.TabIndex = 1;
            // 
            // chkOdemeDurumu
            // 
            this.chkOdemeDurumu.AutoSize = true;
            this.chkOdemeDurumu.Location = new System.Drawing.Point(328, 35);
            this.chkOdemeDurumu.Name = "chkOdemeDurumu";
            this.chkOdemeDurumu.Size = new System.Drawing.Size(138, 17);
            this.chkOdemeDurumu.TabIndex = 0;
            this.chkOdemeDurumu.Text = "Ödeme Durumuna Göre";
            this.chkOdemeDurumu.UseVisualStyleBackColor = true;
            this.chkOdemeDurumu.CheckedChanged += new System.EventHandler(this.chkOdemeDurumu_CheckedChanged);
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
            this.cmbSatisTipi.Location = new System.Drawing.Point(148, 33);
            this.cmbSatisTipi.Name = "cmbSatisTipi";
            this.cmbSatisTipi.Size = new System.Drawing.Size(159, 25);
            this.cmbSatisTipi.TabIndex = 1;
            // 
            // chkSatisTipi
            // 
            this.chkSatisTipi.AutoSize = true;
            this.chkSatisTipi.Location = new System.Drawing.Point(25, 35);
            this.chkSatisTipi.Name = "chkSatisTipi";
            this.chkSatisTipi.Size = new System.Drawing.Size(107, 17);
            this.chkSatisTipi.TabIndex = 0;
            this.chkSatisTipi.Text = "Satış Tipine Göre";
            this.chkSatisTipi.UseVisualStyleBackColor = true;
            this.chkSatisTipi.CheckedChanged += new System.EventHandler(this.chkSatisTipi_CheckedChanged);
            // 
            // dgvSatislarSorgulama
            // 
            this.dgvSatislarSorgulama.AllowUserToAddRows = false;
            this.dgvSatislarSorgulama.AllowUserToDeleteRows = false;
            this.dgvSatislarSorgulama.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSatislarSorgulama.Location = new System.Drawing.Point(20, 285);
            this.dgvSatislarSorgulama.MultiSelect = false;
            this.dgvSatislarSorgulama.Name = "dgvSatislarSorgulama";
            this.dgvSatislarSorgulama.ReadOnly = true;
            this.dgvSatislarSorgulama.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSatislarSorgulama.Size = new System.Drawing.Size(840, 300);
            this.dgvSatislarSorgulama.TabIndex = 3;
            // 
            // grpHizliSorgulama
            // 
            this.grpHizliSorgulama.Controls.Add(this.txtHizliAra);
            this.grpHizliSorgulama.Controls.Add(this.cmbAramaTuru);
            this.grpHizliSorgulama.Controls.Add(this.lblHizliBilgi);
            this.grpHizliSorgulama.Controls.Add(this.lblArananAlan);
            this.grpHizliSorgulama.Controls.Add(this.lblAramaTuru);
            this.grpHizliSorgulama.Controls.Add(this.radOdemeDurumu);
            this.grpHizliSorgulama.Controls.Add(this.radOdemeTipi);
            this.grpHizliSorgulama.Controls.Add(this.radSatisTipi);
            this.grpHizliSorgulama.Location = new System.Drawing.Point(20, 145);
            this.grpHizliSorgulama.Name = "grpHizliSorgulama";
            this.grpHizliSorgulama.Size = new System.Drawing.Size(840, 125);
            this.grpHizliSorgulama.TabIndex = 8;
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
            this.cmbAramaTuru.Location = new System.Drawing.Point(475, 33);
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
            this.lblAramaTuru.Location = new System.Drawing.Point(385, 36);
            this.lblAramaTuru.Name = "lblAramaTuru";
            this.lblAramaTuru.Size = new System.Drawing.Size(65, 13);
            this.lblAramaTuru.TabIndex = 1;
            this.lblAramaTuru.Text = "Arama Türü:";
            // 
            // radOdemeDurumu
            // 
            this.radOdemeDurumu.AutoSize = true;
            this.radOdemeDurumu.Location = new System.Drawing.Point(230, 35);
            this.radOdemeDurumu.Name = "radOdemeDurumu";
            this.radOdemeDurumu.Size = new System.Drawing.Size(99, 17);
            this.radOdemeDurumu.TabIndex = 0;
            this.radOdemeDurumu.TabStop = true;
            this.radOdemeDurumu.Text = "Ödeme Durumu";
            this.radOdemeDurumu.UseVisualStyleBackColor = true;
            this.radOdemeDurumu.CheckedChanged += new System.EventHandler(this.radOdemeDurumu_CheckedChanged);
            // 
            // radOdemeTipi
            // 
            this.radOdemeTipi.AutoSize = true;
            this.radOdemeTipi.Location = new System.Drawing.Point(125, 35);
            this.radOdemeTipi.Name = "radOdemeTipi";
            this.radOdemeTipi.Size = new System.Drawing.Size(79, 17);
            this.radOdemeTipi.TabIndex = 0;
            this.radOdemeTipi.TabStop = true;
            this.radOdemeTipi.Text = "Ödeme Tipi";
            this.radOdemeTipi.UseVisualStyleBackColor = true;
            this.radOdemeTipi.CheckedChanged += new System.EventHandler(this.radOdemeTipi_CheckedChanged);
            // 
            // radSatisTipi
            // 
            this.radSatisTipi.AutoSize = true;
            this.radSatisTipi.Location = new System.Drawing.Point(25, 35);
            this.radSatisTipi.Name = "radSatisTipi";
            this.radSatisTipi.Size = new System.Drawing.Size(68, 17);
            this.radSatisTipi.TabIndex = 0;
            this.radSatisTipi.TabStop = true;
            this.radSatisTipi.Text = "Satış Tipi";
            this.radSatisTipi.UseVisualStyleBackColor = true;
            this.radSatisTipi.CheckedChanged += new System.EventHandler(this.radSatisTipi_CheckedChanged);
            // 
            // FrmSatislarSorgulama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 611);
            this.Controls.Add(this.grpHizliSorgulama);
            this.Controls.Add(this.dgvSatislarSorgulama);
            this.Controls.Add(this.grpSatisSorgulama);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmSatislarSorgulama";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Satışlar Sorgulama";
            this.Load += new System.EventHandler(this.FrmSatislarSorgulama_Load);
            this.grpSatisSorgulama.ResumeLayout(false);
            this.grpSatisSorgulama.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSatislarSorgulama)).EndInit();
            this.grpHizliSorgulama.ResumeLayout(false);
            this.grpHizliSorgulama.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpSatisSorgulama;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.ComboBox cmbSatisTipi;
        private System.Windows.Forms.CheckBox chkSatisTipi;
        private System.Windows.Forms.DataGridView dgvSatislarSorgulama;
        private System.Windows.Forms.ComboBox cmbOdemeDurumu;
        private System.Windows.Forms.CheckBox chkOdemeDurumu;
        private System.Windows.Forms.GroupBox grpHizliSorgulama;
        private System.Windows.Forms.TextBox txtHizliAra;
        private System.Windows.Forms.ComboBox cmbAramaTuru;
        private System.Windows.Forms.Label lblHizliBilgi;
        private System.Windows.Forms.Label lblArananAlan;
        private System.Windows.Forms.Label lblAramaTuru;
        private System.Windows.Forms.RadioButton radOdemeDurumu;
        private System.Windows.Forms.RadioButton radOdemeTipi;
        private System.Windows.Forms.RadioButton radSatisTipi;
    }
}