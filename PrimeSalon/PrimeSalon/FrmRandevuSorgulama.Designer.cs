
namespace PrimeSalon
{
    partial class FrmRandevuSorgulama
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
            this.grpRandevuSorgulama = new System.Windows.Forms.GroupBox();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnAra = new System.Windows.Forms.Button();
            this.cmbDurum = new System.Windows.Forms.ComboBox();
            this.chkDurum = new System.Windows.Forms.CheckBox();
            this.dgvRandevuSorgulama = new System.Windows.Forms.DataGridView();
            this.grpHizliSorgulama = new System.Windows.Forms.GroupBox();
            this.txtHizliAra = new System.Windows.Forms.TextBox();
            this.cmbAramaTuru = new System.Windows.Forms.ComboBox();
            this.lblHizliBilgi = new System.Windows.Forms.Label();
            this.lblArananAlan = new System.Windows.Forms.Label();
            this.lblAramaTuru = new System.Windows.Forms.Label();
            this.radOdemeDurumu = new System.Windows.Forms.RadioButton();
            this.radDurum = new System.Windows.Forms.RadioButton();
            this.grpRandevuSorgulama.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRandevuSorgulama)).BeginInit();
            this.grpHizliSorgulama.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpRandevuSorgulama
            // 
            this.grpRandevuSorgulama.Controls.Add(this.btnTemizle);
            this.grpRandevuSorgulama.Controls.Add(this.btnAra);
            this.grpRandevuSorgulama.Controls.Add(this.cmbDurum);
            this.grpRandevuSorgulama.Controls.Add(this.chkDurum);
            this.grpRandevuSorgulama.Location = new System.Drawing.Point(20, 20);
            this.grpRandevuSorgulama.Name = "grpRandevuSorgulama";
            this.grpRandevuSorgulama.Size = new System.Drawing.Size(840, 110);
            this.grpRandevuSorgulama.TabIndex = 1;
            this.grpRandevuSorgulama.TabStop = false;
            this.grpRandevuSorgulama.Text = "Randevu Durumuna Göre Sorgulama";
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(520, 31);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(85, 28);
            this.btnTemizle.TabIndex = 2;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnAra
            // 
            this.btnAra.Location = new System.Drawing.Point(420, 31);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(85, 28);
            this.btnAra.TabIndex = 2;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // cmbDurum
            // 
            this.cmbDurum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDurum.Enabled = false;
            this.cmbDurum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbDurum.FormattingEnabled = true;
            this.cmbDurum.Items.AddRange(new object[] {
            "Seçiniz",
            "Bekliyor",
            "Tamamlandı",
            "İptal",
            "Gelmedi"});
            this.cmbDurum.Location = new System.Drawing.Point(180, 33);
            this.cmbDurum.Name = "cmbDurum";
            this.cmbDurum.Size = new System.Drawing.Size(200, 25);
            this.cmbDurum.TabIndex = 1;
            // 
            // chkDurum
            // 
            this.chkDurum.AutoSize = true;
            this.chkDurum.Location = new System.Drawing.Point(25, 35);
            this.chkDurum.Name = "chkDurum";
            this.chkDurum.Size = new System.Drawing.Size(89, 17);
            this.chkDurum.TabIndex = 0;
            this.chkDurum.Text = "Duruma Göre";
            this.chkDurum.UseVisualStyleBackColor = true;
            this.chkDurum.CheckedChanged += new System.EventHandler(this.chkDurum_CheckedChanged);
            // 
            // dgvRandevuSorgulama
            // 
            this.dgvRandevuSorgulama.AllowUserToAddRows = false;
            this.dgvRandevuSorgulama.AllowUserToDeleteRows = false;
            this.dgvRandevuSorgulama.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRandevuSorgulama.Location = new System.Drawing.Point(20, 285);
            this.dgvRandevuSorgulama.MultiSelect = false;
            this.dgvRandevuSorgulama.Name = "dgvRandevuSorgulama";
            this.dgvRandevuSorgulama.ReadOnly = true;
            this.dgvRandevuSorgulama.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRandevuSorgulama.Size = new System.Drawing.Size(840, 300);
            this.dgvRandevuSorgulama.TabIndex = 2;
            // 
            // grpHizliSorgulama
            // 
            this.grpHizliSorgulama.Controls.Add(this.txtHizliAra);
            this.grpHizliSorgulama.Controls.Add(this.cmbAramaTuru);
            this.grpHizliSorgulama.Controls.Add(this.lblHizliBilgi);
            this.grpHizliSorgulama.Controls.Add(this.lblArananAlan);
            this.grpHizliSorgulama.Controls.Add(this.lblAramaTuru);
            this.grpHizliSorgulama.Controls.Add(this.radOdemeDurumu);
            this.grpHizliSorgulama.Controls.Add(this.radDurum);
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
            this.cmbAramaTuru.Location = new System.Drawing.Point(335, 33);
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
            this.lblAramaTuru.Location = new System.Drawing.Point(245, 36);
            this.lblAramaTuru.Name = "lblAramaTuru";
            this.lblAramaTuru.Size = new System.Drawing.Size(65, 13);
            this.lblAramaTuru.TabIndex = 1;
            this.lblAramaTuru.Text = "Arama Türü:";
            // 
            // radOdemeDurumu
            // 
            this.radOdemeDurumu.AutoSize = true;
            this.radOdemeDurumu.Location = new System.Drawing.Point(115, 35);
            this.radOdemeDurumu.Name = "radOdemeDurumu";
            this.radOdemeDurumu.Size = new System.Drawing.Size(99, 17);
            this.radOdemeDurumu.TabIndex = 0;
            this.radOdemeDurumu.TabStop = true;
            this.radOdemeDurumu.Text = "Ödeme Durumu";
            this.radOdemeDurumu.UseVisualStyleBackColor = true;
            this.radOdemeDurumu.CheckedChanged += new System.EventHandler(this.radOdemeDurumu_CheckedChanged);
            // 
            // radDurum
            // 
            this.radDurum.AutoSize = true;
            this.radDurum.Location = new System.Drawing.Point(25, 35);
            this.radDurum.Name = "radDurum";
            this.radDurum.Size = new System.Drawing.Size(56, 17);
            this.radDurum.TabIndex = 0;
            this.radDurum.TabStop = true;
            this.radDurum.Text = "Durum";
            this.radDurum.UseVisualStyleBackColor = true;
            this.radDurum.CheckedChanged += new System.EventHandler(this.radDurum_CheckedChanged);
            // 
            // FrmRandevuSorgulama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 611);
            this.Controls.Add(this.grpHizliSorgulama);
            this.Controls.Add(this.dgvRandevuSorgulama);
            this.Controls.Add(this.grpRandevuSorgulama);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmRandevuSorgulama";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Randevu Sorgulama";
            this.Load += new System.EventHandler(this.FrmRandevuSorgulama_Load);
            this.grpRandevuSorgulama.ResumeLayout(false);
            this.grpRandevuSorgulama.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRandevuSorgulama)).EndInit();
            this.grpHizliSorgulama.ResumeLayout(false);
            this.grpHizliSorgulama.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpRandevuSorgulama;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.ComboBox cmbDurum;
        private System.Windows.Forms.CheckBox chkDurum;
        private System.Windows.Forms.DataGridView dgvRandevuSorgulama;
        private System.Windows.Forms.GroupBox grpHizliSorgulama;
        private System.Windows.Forms.TextBox txtHizliAra;
        private System.Windows.Forms.ComboBox cmbAramaTuru;
        private System.Windows.Forms.Label lblHizliBilgi;
        private System.Windows.Forms.Label lblArananAlan;
        private System.Windows.Forms.Label lblAramaTuru;
        private System.Windows.Forms.RadioButton radOdemeDurumu;
        private System.Windows.Forms.RadioButton radDurum;
    }
}