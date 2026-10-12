
namespace PrimeSalon
{
    partial class FrmGiderlerSorgulama
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
            this.grpGiderlerSorgulama = new System.Windows.Forms.GroupBox();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnAra = new System.Windows.Forms.Button();
            this.cmbGiderTuru = new System.Windows.Forms.ComboBox();
            this.chkGiderTuru = new System.Windows.Forms.CheckBox();
            this.dgvGiderlerSorgulama = new System.Windows.Forms.DataGridView();
            this.grpHizliSorgulama = new System.Windows.Forms.GroupBox();
            this.txtHizliAra = new System.Windows.Forms.TextBox();
            this.cmbAramaTuru = new System.Windows.Forms.ComboBox();
            this.lblHizliBilgi = new System.Windows.Forms.Label();
            this.lblArananAlan = new System.Windows.Forms.Label();
            this.lblAramaTuru = new System.Windows.Forms.Label();
            this.radGiderTuru = new System.Windows.Forms.RadioButton();
            this.radFirma = new System.Windows.Forms.RadioButton();
            this.grpGiderlerSorgulama.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGiderlerSorgulama)).BeginInit();
            this.grpHizliSorgulama.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpGiderlerSorgulama
            // 
            this.grpGiderlerSorgulama.Controls.Add(this.btnTemizle);
            this.grpGiderlerSorgulama.Controls.Add(this.btnAra);
            this.grpGiderlerSorgulama.Controls.Add(this.cmbGiderTuru);
            this.grpGiderlerSorgulama.Controls.Add(this.chkGiderTuru);
            this.grpGiderlerSorgulama.Location = new System.Drawing.Point(20, 20);
            this.grpGiderlerSorgulama.Name = "grpGiderlerSorgulama";
            this.grpGiderlerSorgulama.Size = new System.Drawing.Size(840, 110);
            this.grpGiderlerSorgulama.TabIndex = 0;
            this.grpGiderlerSorgulama.TabStop = false;
            this.grpGiderlerSorgulama.Text = "Gider Türüne Göre Sorgulama";
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
            // cmbGiderTuru
            // 
            this.cmbGiderTuru.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGiderTuru.Enabled = false;
            this.cmbGiderTuru.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbGiderTuru.FormattingEnabled = true;
            this.cmbGiderTuru.Items.AddRange(new object[] {
            "Seçiniz",
            "Kira",
            "Elektrik",
            "Su",
            "İnternet",
            "Sarf Malzeme",
            "Personel Maaşı",
            "Temizlik",
            "Vergi",
            "Diğer"});
            this.cmbGiderTuru.Location = new System.Drawing.Point(180, 33);
            this.cmbGiderTuru.Name = "cmbGiderTuru";
            this.cmbGiderTuru.Size = new System.Drawing.Size(200, 25);
            this.cmbGiderTuru.TabIndex = 1;
            // 
            // chkGiderTuru
            // 
            this.chkGiderTuru.AutoSize = true;
            this.chkGiderTuru.Location = new System.Drawing.Point(25, 35);
            this.chkGiderTuru.Name = "chkGiderTuru";
            this.chkGiderTuru.Size = new System.Drawing.Size(114, 17);
            this.chkGiderTuru.TabIndex = 0;
            this.chkGiderTuru.Text = "Gider Türüne Göre";
            this.chkGiderTuru.UseVisualStyleBackColor = true;
            this.chkGiderTuru.CheckedChanged += new System.EventHandler(this.chkGiderTuru_CheckedChanged);
            // 
            // dgvGiderlerSorgulama
            // 
            this.dgvGiderlerSorgulama.AllowUserToAddRows = false;
            this.dgvGiderlerSorgulama.AllowUserToDeleteRows = false;
            this.dgvGiderlerSorgulama.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGiderlerSorgulama.Location = new System.Drawing.Point(20, 285);
            this.dgvGiderlerSorgulama.MultiSelect = false;
            this.dgvGiderlerSorgulama.Name = "dgvGiderlerSorgulama";
            this.dgvGiderlerSorgulama.ReadOnly = true;
            this.dgvGiderlerSorgulama.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGiderlerSorgulama.Size = new System.Drawing.Size(840, 300);
            this.dgvGiderlerSorgulama.TabIndex = 1;
            // 
            // grpHizliSorgulama
            // 
            this.grpHizliSorgulama.Controls.Add(this.txtHizliAra);
            this.grpHizliSorgulama.Controls.Add(this.cmbAramaTuru);
            this.grpHizliSorgulama.Controls.Add(this.lblHizliBilgi);
            this.grpHizliSorgulama.Controls.Add(this.lblArananAlan);
            this.grpHizliSorgulama.Controls.Add(this.lblAramaTuru);
            this.grpHizliSorgulama.Controls.Add(this.radGiderTuru);
            this.grpHizliSorgulama.Controls.Add(this.radFirma);
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
            this.cmbAramaTuru.Location = new System.Drawing.Point(330, 33);
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
            this.lblAramaTuru.Location = new System.Drawing.Point(240, 36);
            this.lblAramaTuru.Name = "lblAramaTuru";
            this.lblAramaTuru.Size = new System.Drawing.Size(65, 13);
            this.lblAramaTuru.TabIndex = 1;
            this.lblAramaTuru.Text = "Arama Türü:";
            // 
            // radGiderTuru
            // 
            this.radGiderTuru.AutoSize = true;
            this.radGiderTuru.Location = new System.Drawing.Point(110, 35);
            this.radGiderTuru.Name = "radGiderTuru";
            this.radGiderTuru.Size = new System.Drawing.Size(75, 17);
            this.radGiderTuru.TabIndex = 0;
            this.radGiderTuru.TabStop = true;
            this.radGiderTuru.Text = "Gider Türü";
            this.radGiderTuru.UseVisualStyleBackColor = true;
            this.radGiderTuru.CheckedChanged += new System.EventHandler(this.radGiderTuru_CheckedChanged);
            // 
            // radFirma
            // 
            this.radFirma.AutoSize = true;
            this.radFirma.Location = new System.Drawing.Point(25, 35);
            this.radFirma.Name = "radFirma";
            this.radFirma.Size = new System.Drawing.Size(50, 17);
            this.radFirma.TabIndex = 0;
            this.radFirma.TabStop = true;
            this.radFirma.Text = "Firma";
            this.radFirma.UseVisualStyleBackColor = true;
            this.radFirma.CheckedChanged += new System.EventHandler(this.radFirma_CheckedChanged);
            // 
            // FrmGiderlerSorgulama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 611);
            this.Controls.Add(this.grpHizliSorgulama);
            this.Controls.Add(this.dgvGiderlerSorgulama);
            this.Controls.Add(this.grpGiderlerSorgulama);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmGiderlerSorgulama";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giderler Sorgulama";
            this.Load += new System.EventHandler(this.FrmGiderlerSorgulama_Load);
            this.grpGiderlerSorgulama.ResumeLayout(false);
            this.grpGiderlerSorgulama.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGiderlerSorgulama)).EndInit();
            this.grpHizliSorgulama.ResumeLayout(false);
            this.grpHizliSorgulama.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpGiderlerSorgulama;
        private System.Windows.Forms.ComboBox cmbGiderTuru;
        private System.Windows.Forms.CheckBox chkGiderTuru;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.DataGridView dgvGiderlerSorgulama;
        private System.Windows.Forms.GroupBox grpHizliSorgulama;
        private System.Windows.Forms.TextBox txtHizliAra;
        private System.Windows.Forms.ComboBox cmbAramaTuru;
        private System.Windows.Forms.Label lblHizliBilgi;
        private System.Windows.Forms.Label lblArananAlan;
        private System.Windows.Forms.Label lblAramaTuru;
        private System.Windows.Forms.RadioButton radGiderTuru;
        private System.Windows.Forms.RadioButton radFirma;
    }
}