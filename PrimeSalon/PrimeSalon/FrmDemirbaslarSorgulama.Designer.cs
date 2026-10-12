
namespace PrimeSalon
{
    partial class FrmDemirbaslarSorgulama
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
            this.grpDemirbasSorgulama = new System.Windows.Forms.GroupBox();
            this.cmbKategori = new System.Windows.Forms.ComboBox();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnAra = new System.Windows.Forms.Button();
            this.txtDemirbasAdi = new System.Windows.Forms.TextBox();
            this.chkKategori = new System.Windows.Forms.CheckBox();
            this.chkDemirbasAdi = new System.Windows.Forms.CheckBox();
            this.dgvDemirbaslarSorgulama = new System.Windows.Forms.DataGridView();
            this.grpHizliSorgulama = new System.Windows.Forms.GroupBox();
            this.txtHizliAra = new System.Windows.Forms.TextBox();
            this.cmbAramaTuru = new System.Windows.Forms.ComboBox();
            this.lblHizliBilgi = new System.Windows.Forms.Label();
            this.lblArananAlan = new System.Windows.Forms.Label();
            this.lblAramaTuru = new System.Windows.Forms.Label();
            this.radSorumlu = new System.Windows.Forms.RadioButton();
            this.radModel = new System.Windows.Forms.RadioButton();
            this.radMarka = new System.Windows.Forms.RadioButton();
            this.radDemirbasAdi = new System.Windows.Forms.RadioButton();
            this.grpDemirbasSorgulama.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDemirbaslarSorgulama)).BeginInit();
            this.grpHizliSorgulama.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpDemirbasSorgulama
            // 
            this.grpDemirbasSorgulama.Controls.Add(this.cmbKategori);
            this.grpDemirbasSorgulama.Controls.Add(this.btnTemizle);
            this.grpDemirbasSorgulama.Controls.Add(this.btnAra);
            this.grpDemirbasSorgulama.Controls.Add(this.txtDemirbasAdi);
            this.grpDemirbasSorgulama.Controls.Add(this.chkKategori);
            this.grpDemirbasSorgulama.Controls.Add(this.chkDemirbasAdi);
            this.grpDemirbasSorgulama.Location = new System.Drawing.Point(20, 20);
            this.grpDemirbasSorgulama.Name = "grpDemirbasSorgulama";
            this.grpDemirbasSorgulama.Size = new System.Drawing.Size(840, 110);
            this.grpDemirbasSorgulama.TabIndex = 3;
            this.grpDemirbasSorgulama.TabStop = false;
            this.grpDemirbasSorgulama.Text = "Demirbaş Adı / Kategori ile Birebir Sorgulama";
            // 
            // cmbKategori
            // 
            this.cmbKategori.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKategori.Enabled = false;
            this.cmbKategori.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbKategori.FormattingEnabled = true;
            this.cmbKategori.Items.AddRange(new object[] {
            "Seçiniz",
            "Makine",
            "Mobilya",
            "Elektronik",
            "Diğer"});
            this.cmbKategori.Location = new System.Drawing.Point(475, 33);
            this.cmbKategori.Name = "cmbKategori";
            this.cmbKategori.Size = new System.Drawing.Size(173, 25);
            this.cmbKategori.TabIndex = 3;
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(749, 31);
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
            // txtDemirbasAdi
            // 
            this.txtDemirbasAdi.Enabled = false;
            this.txtDemirbasAdi.Location = new System.Drawing.Point(165, 33);
            this.txtDemirbasAdi.Multiline = true;
            this.txtDemirbasAdi.Name = "txtDemirbasAdi";
            this.txtDemirbasAdi.Size = new System.Drawing.Size(170, 24);
            this.txtDemirbasAdi.TabIndex = 1;
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
            // chkDemirbasAdi
            // 
            this.chkDemirbasAdi.AutoSize = true;
            this.chkDemirbasAdi.Location = new System.Drawing.Point(25, 35);
            this.chkDemirbasAdi.Name = "chkDemirbasAdi";
            this.chkDemirbasAdi.Size = new System.Drawing.Size(126, 17);
            this.chkDemirbasAdi.TabIndex = 0;
            this.chkDemirbasAdi.Text = "Demirbaş Adına Göre";
            this.chkDemirbasAdi.UseVisualStyleBackColor = true;
            this.chkDemirbasAdi.CheckedChanged += new System.EventHandler(this.chkDemirbasAdi_CheckedChanged);
            // 
            // dgvDemirbaslarSorgulama
            // 
            this.dgvDemirbaslarSorgulama.AllowUserToAddRows = false;
            this.dgvDemirbaslarSorgulama.AllowUserToDeleteRows = false;
            this.dgvDemirbaslarSorgulama.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDemirbaslarSorgulama.Location = new System.Drawing.Point(20, 285);
            this.dgvDemirbaslarSorgulama.MultiSelect = false;
            this.dgvDemirbaslarSorgulama.Name = "dgvDemirbaslarSorgulama";
            this.dgvDemirbaslarSorgulama.ReadOnly = true;
            this.dgvDemirbaslarSorgulama.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDemirbaslarSorgulama.Size = new System.Drawing.Size(840, 300);
            this.dgvDemirbaslarSorgulama.TabIndex = 4;
            // 
            // grpHizliSorgulama
            // 
            this.grpHizliSorgulama.Controls.Add(this.txtHizliAra);
            this.grpHizliSorgulama.Controls.Add(this.cmbAramaTuru);
            this.grpHizliSorgulama.Controls.Add(this.lblHizliBilgi);
            this.grpHizliSorgulama.Controls.Add(this.lblArananAlan);
            this.grpHizliSorgulama.Controls.Add(this.lblAramaTuru);
            this.grpHizliSorgulama.Controls.Add(this.radSorumlu);
            this.grpHizliSorgulama.Controls.Add(this.radModel);
            this.grpHizliSorgulama.Controls.Add(this.radMarka);
            this.grpHizliSorgulama.Controls.Add(this.radDemirbasAdi);
            this.grpHizliSorgulama.Location = new System.Drawing.Point(20, 145);
            this.grpHizliSorgulama.Name = "grpHizliSorgulama";
            this.grpHizliSorgulama.Size = new System.Drawing.Size(840, 125);
            this.grpHizliSorgulama.TabIndex = 5;
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
            this.cmbAramaTuru.Location = new System.Drawing.Point(515, 33);
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
            this.lblAramaTuru.Location = new System.Drawing.Point(425, 36);
            this.lblAramaTuru.Name = "lblAramaTuru";
            this.lblAramaTuru.Size = new System.Drawing.Size(65, 13);
            this.lblAramaTuru.TabIndex = 1;
            this.lblAramaTuru.Text = "Arama Türü:";
            // 
            // radSorumlu
            // 
            this.radSorumlu.AutoSize = true;
            this.radSorumlu.Location = new System.Drawing.Point(315, 35);
            this.radSorumlu.Name = "radSorumlu";
            this.radSorumlu.Size = new System.Drawing.Size(63, 17);
            this.radSorumlu.TabIndex = 0;
            this.radSorumlu.TabStop = true;
            this.radSorumlu.Text = "Sorumlu";
            this.radSorumlu.UseVisualStyleBackColor = true;
            this.radSorumlu.CheckedChanged += new System.EventHandler(this.radSorumlu_CheckedChanged);
            // 
            // radModel
            // 
            this.radModel.AutoSize = true;
            this.radModel.Location = new System.Drawing.Point(230, 35);
            this.radModel.Name = "radModel";
            this.radModel.Size = new System.Drawing.Size(54, 17);
            this.radModel.TabIndex = 0;
            this.radModel.TabStop = true;
            this.radModel.Text = "Model";
            this.radModel.UseVisualStyleBackColor = true;
            this.radModel.CheckedChanged += new System.EventHandler(this.radModel_CheckedChanged);
            // 
            // radMarka
            // 
            this.radMarka.AutoSize = true;
            this.radMarka.Location = new System.Drawing.Point(145, 35);
            this.radMarka.Name = "radMarka";
            this.radMarka.Size = new System.Drawing.Size(55, 17);
            this.radMarka.TabIndex = 0;
            this.radMarka.TabStop = true;
            this.radMarka.Text = "Marka";
            this.radMarka.UseVisualStyleBackColor = true;
            this.radMarka.CheckedChanged += new System.EventHandler(this.radMarka_CheckedChanged);
            // 
            // radDemirbasAdi
            // 
            this.radDemirbasAdi.AutoSize = true;
            this.radDemirbasAdi.Location = new System.Drawing.Point(25, 35);
            this.radDemirbasAdi.Name = "radDemirbasAdi";
            this.radDemirbasAdi.Size = new System.Drawing.Size(87, 17);
            this.radDemirbasAdi.TabIndex = 0;
            this.radDemirbasAdi.TabStop = true;
            this.radDemirbasAdi.Text = "Demirbaş Adı";
            this.radDemirbasAdi.UseVisualStyleBackColor = true;
            this.radDemirbasAdi.CheckedChanged += new System.EventHandler(this.radDemirbasAdi_CheckedChanged);
            // 
            // FrmDemirbaslarSorgulama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 611);
            this.Controls.Add(this.grpHizliSorgulama);
            this.Controls.Add(this.dgvDemirbaslarSorgulama);
            this.Controls.Add(this.grpDemirbasSorgulama);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmDemirbaslarSorgulama";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Demirbaşlar Sorgulama";
            this.Load += new System.EventHandler(this.FrmDemirbaslarSorgulama_Load);
            this.grpDemirbasSorgulama.ResumeLayout(false);
            this.grpDemirbasSorgulama.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDemirbaslarSorgulama)).EndInit();
            this.grpHizliSorgulama.ResumeLayout(false);
            this.grpHizliSorgulama.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpDemirbasSorgulama;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.TextBox txtDemirbasAdi;
        private System.Windows.Forms.CheckBox chkKategori;
        private System.Windows.Forms.CheckBox chkDemirbasAdi;
        private System.Windows.Forms.DataGridView dgvDemirbaslarSorgulama;
        private System.Windows.Forms.ComboBox cmbKategori;
        private System.Windows.Forms.GroupBox grpHizliSorgulama;
        private System.Windows.Forms.TextBox txtHizliAra;
        private System.Windows.Forms.ComboBox cmbAramaTuru;
        private System.Windows.Forms.Label lblHizliBilgi;
        private System.Windows.Forms.Label lblArananAlan;
        private System.Windows.Forms.Label lblAramaTuru;
        private System.Windows.Forms.RadioButton radSorumlu;
        private System.Windows.Forms.RadioButton radModel;
        private System.Windows.Forms.RadioButton radMarka;
        private System.Windows.Forms.RadioButton radDemirbasAdi;
    }
}