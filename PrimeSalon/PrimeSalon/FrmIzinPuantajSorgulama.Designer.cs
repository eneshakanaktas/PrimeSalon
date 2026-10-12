
namespace PrimeSalon
{
    partial class FrmIzinPuantajSorgulama
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
            this.grpIzinSorgulama = new System.Windows.Forms.GroupBox();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnAra = new System.Windows.Forms.Button();
            this.cmbOnayDurumu = new System.Windows.Forms.ComboBox();
            this.chkOnayDurumu = new System.Windows.Forms.CheckBox();
            this.cmbIslemTipi = new System.Windows.Forms.ComboBox();
            this.chkIslemTipi = new System.Windows.Forms.CheckBox();
            this.dgvIzinPuantajSorgulama = new System.Windows.Forms.DataGridView();
            this.grpHizliSorgulama = new System.Windows.Forms.GroupBox();
            this.txtHizliAra = new System.Windows.Forms.TextBox();
            this.cmbAramaTuru = new System.Windows.Forms.ComboBox();
            this.lblHizliBilgi = new System.Windows.Forms.Label();
            this.lblArananAlan = new System.Windows.Forms.Label();
            this.lblAramaTuru = new System.Windows.Forms.Label();
            this.radOnayDurumu = new System.Windows.Forms.RadioButton();
            this.radIslemTipi = new System.Windows.Forms.RadioButton();
            this.radOnaylayan = new System.Windows.Forms.RadioButton();
            this.radIzinTuru = new System.Windows.Forms.RadioButton();
            this.grpIzinSorgulama.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIzinPuantajSorgulama)).BeginInit();
            this.grpHizliSorgulama.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpIzinSorgulama
            // 
            this.grpIzinSorgulama.Controls.Add(this.btnTemizle);
            this.grpIzinSorgulama.Controls.Add(this.btnAra);
            this.grpIzinSorgulama.Controls.Add(this.cmbOnayDurumu);
            this.grpIzinSorgulama.Controls.Add(this.chkOnayDurumu);
            this.grpIzinSorgulama.Controls.Add(this.cmbIslemTipi);
            this.grpIzinSorgulama.Controls.Add(this.chkIslemTipi);
            this.grpIzinSorgulama.Location = new System.Drawing.Point(20, 20);
            this.grpIzinSorgulama.Name = "grpIzinSorgulama";
            this.grpIzinSorgulama.Size = new System.Drawing.Size(840, 110);
            this.grpIzinSorgulama.TabIndex = 4;
            this.grpIzinSorgulama.TabStop = false;
            this.grpIzinSorgulama.Text = "İşlem Tipi / Onay Durumu ile Birebir Sorgulama";
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
            // cmbOnayDurumu
            // 
            this.cmbOnayDurumu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOnayDurumu.Enabled = false;
            this.cmbOnayDurumu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbOnayDurumu.FormattingEnabled = true;
            this.cmbOnayDurumu.Items.AddRange(new object[] {
            "Seçiniz",
            "Bekliyor",
            "Onaylandı",
            "Reddedildi"});
            this.cmbOnayDurumu.Location = new System.Drawing.Point(487, 33);
            this.cmbOnayDurumu.Name = "cmbOnayDurumu";
            this.cmbOnayDurumu.Size = new System.Drawing.Size(148, 25);
            this.cmbOnayDurumu.TabIndex = 1;
            // 
            // chkOnayDurumu
            // 
            this.chkOnayDurumu.AutoSize = true;
            this.chkOnayDurumu.Location = new System.Drawing.Point(332, 35);
            this.chkOnayDurumu.Name = "chkOnayDurumu";
            this.chkOnayDurumu.Size = new System.Drawing.Size(129, 17);
            this.chkOnayDurumu.TabIndex = 0;
            this.chkOnayDurumu.Text = "Onay Durumuna Göre";
            this.chkOnayDurumu.UseVisualStyleBackColor = true;
            this.chkOnayDurumu.CheckedChanged += new System.EventHandler(this.chkOnayDurumu_CheckedChanged);
            // 
            // cmbIslemTipi
            // 
            this.cmbIslemTipi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIslemTipi.Enabled = false;
            this.cmbIslemTipi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbIslemTipi.FormattingEnabled = true;
            this.cmbIslemTipi.Items.AddRange(new object[] {
            "Seçiniz",
            "Mesai",
            "İzin",
            "Rapor",
            "Tatil"});
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
            // dgvIzinPuantajSorgulama
            // 
            this.dgvIzinPuantajSorgulama.AllowUserToAddRows = false;
            this.dgvIzinPuantajSorgulama.AllowUserToDeleteRows = false;
            this.dgvIzinPuantajSorgulama.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIzinPuantajSorgulama.Location = new System.Drawing.Point(20, 285);
            this.dgvIzinPuantajSorgulama.MultiSelect = false;
            this.dgvIzinPuantajSorgulama.Name = "dgvIzinPuantajSorgulama";
            this.dgvIzinPuantajSorgulama.ReadOnly = true;
            this.dgvIzinPuantajSorgulama.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvIzinPuantajSorgulama.Size = new System.Drawing.Size(840, 300);
            this.dgvIzinPuantajSorgulama.TabIndex = 5;
            // 
            // grpHizliSorgulama
            // 
            this.grpHizliSorgulama.Controls.Add(this.txtHizliAra);
            this.grpHizliSorgulama.Controls.Add(this.cmbAramaTuru);
            this.grpHizliSorgulama.Controls.Add(this.lblHizliBilgi);
            this.grpHizliSorgulama.Controls.Add(this.lblArananAlan);
            this.grpHizliSorgulama.Controls.Add(this.lblAramaTuru);
            this.grpHizliSorgulama.Controls.Add(this.radIzinTuru);
            this.grpHizliSorgulama.Controls.Add(this.radOnayDurumu);
            this.grpHizliSorgulama.Controls.Add(this.radIslemTipi);
            this.grpHizliSorgulama.Controls.Add(this.radOnaylayan);
            this.grpHizliSorgulama.Location = new System.Drawing.Point(20, 145);
            this.grpHizliSorgulama.Name = "grpHizliSorgulama";
            this.grpHizliSorgulama.Size = new System.Drawing.Size(840, 125);
            this.grpHizliSorgulama.TabIndex = 10;
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
            this.cmbAramaTuru.Location = new System.Drawing.Point(570, 33);
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
            this.lblAramaTuru.Location = new System.Drawing.Point(480, 36);
            this.lblAramaTuru.Name = "lblAramaTuru";
            this.lblAramaTuru.Size = new System.Drawing.Size(65, 13);
            this.lblAramaTuru.TabIndex = 1;
            this.lblAramaTuru.Text = "Arama Türü:";
            // 
            // radOnayDurumu
            // 
            this.radOnayDurumu.AutoSize = true;
            this.radOnayDurumu.Location = new System.Drawing.Point(235, 35);
            this.radOnayDurumu.Name = "radOnayDurumu";
            this.radOnayDurumu.Size = new System.Drawing.Size(90, 17);
            this.radOnayDurumu.TabIndex = 0;
            this.radOnayDurumu.TabStop = true;
            this.radOnayDurumu.Text = "Onay Durumu";
            this.radOnayDurumu.UseVisualStyleBackColor = true;
            this.radOnayDurumu.CheckedChanged += new System.EventHandler(this.radOnayDurumu_CheckedChanged);
            // 
            // radIslemTipi
            // 
            this.radIslemTipi.AutoSize = true;
            this.radIslemTipi.Location = new System.Drawing.Point(130, 35);
            this.radIslemTipi.Name = "radIslemTipi";
            this.radIslemTipi.Size = new System.Drawing.Size(69, 17);
            this.radIslemTipi.TabIndex = 0;
            this.radIslemTipi.TabStop = true;
            this.radIslemTipi.Text = "İşlem Tipi";
            this.radIslemTipi.UseVisualStyleBackColor = true;
            this.radIslemTipi.CheckedChanged += new System.EventHandler(this.radIslemTipi_CheckedChanged);
            // 
            // radOnaylayan
            // 
            this.radOnaylayan.AutoSize = true;
            this.radOnaylayan.Location = new System.Drawing.Point(25, 35);
            this.radOnaylayan.Name = "radOnaylayan";
            this.radOnaylayan.Size = new System.Drawing.Size(75, 17);
            this.radOnaylayan.TabIndex = 0;
            this.radOnaylayan.TabStop = true;
            this.radOnaylayan.Text = "Onaylayan";
            this.radOnaylayan.UseVisualStyleBackColor = true;
            this.radOnaylayan.CheckedChanged += new System.EventHandler(this.radOnaylayan_CheckedChanged);
            // 
            // radIzinTuru
            // 
            this.radIzinTuru.AutoSize = true;
            this.radIzinTuru.Location = new System.Drawing.Point(365, 35);
            this.radIzinTuru.Name = "radIzinTuru";
            this.radIzinTuru.Size = new System.Drawing.Size(66, 17);
            this.radIzinTuru.TabIndex = 0;
            this.radIzinTuru.TabStop = true;
            this.radIzinTuru.Text = "İzin Türü";
            this.radIzinTuru.UseVisualStyleBackColor = true;
            this.radIzinTuru.CheckedChanged += new System.EventHandler(this.radIzinTuru_CheckedChanged);
            // 
            // FrmIzinPuantajSorgulama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 611);
            this.Controls.Add(this.grpHizliSorgulama);
            this.Controls.Add(this.dgvIzinPuantajSorgulama);
            this.Controls.Add(this.grpIzinSorgulama);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmIzinPuantajSorgulama";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "İzin Puantaj Sorgulama";
            this.Load += new System.EventHandler(this.FrmIzinPuantajSorgulama_Load);
            this.grpIzinSorgulama.ResumeLayout(false);
            this.grpIzinSorgulama.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIzinPuantajSorgulama)).EndInit();
            this.grpHizliSorgulama.ResumeLayout(false);
            this.grpHizliSorgulama.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpIzinSorgulama;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.ComboBox cmbOnayDurumu;
        private System.Windows.Forms.CheckBox chkOnayDurumu;
        private System.Windows.Forms.ComboBox cmbIslemTipi;
        private System.Windows.Forms.CheckBox chkIslemTipi;
        private System.Windows.Forms.DataGridView dgvIzinPuantajSorgulama;
        private System.Windows.Forms.GroupBox grpHizliSorgulama;
        private System.Windows.Forms.TextBox txtHizliAra;
        private System.Windows.Forms.ComboBox cmbAramaTuru;
        private System.Windows.Forms.Label lblHizliBilgi;
        private System.Windows.Forms.Label lblArananAlan;
        private System.Windows.Forms.Label lblAramaTuru;
        private System.Windows.Forms.RadioButton radOnayDurumu;
        private System.Windows.Forms.RadioButton radIslemTipi;
        private System.Windows.Forms.RadioButton radOnaylayan;
        private System.Windows.Forms.RadioButton radIzinTuru;
    }
}