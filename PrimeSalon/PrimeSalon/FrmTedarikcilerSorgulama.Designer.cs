
namespace PrimeSalon
{
    partial class FrmTedarikcilerSorgulama
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
            this.grpTedarikciSorgulama = new System.Windows.Forms.GroupBox();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnAra = new System.Windows.Forms.Button();
            this.txtYetkili = new System.Windows.Forms.TextBox();
            this.txtFirmaAdi = new System.Windows.Forms.TextBox();
            this.chkYetkili = new System.Windows.Forms.CheckBox();
            this.chkFirmaAdi = new System.Windows.Forms.CheckBox();
            this.dgvTedarikcilerSorgulama = new System.Windows.Forms.DataGridView();
            this.grpHizliSorgulama = new System.Windows.Forms.GroupBox();
            this.txtHizliAra = new System.Windows.Forms.TextBox();
            this.cmbAramaTuru = new System.Windows.Forms.ComboBox();
            this.lblHizliBilgi = new System.Windows.Forms.Label();
            this.lblArananAlan = new System.Windows.Forms.Label();
            this.lblAramaTuru = new System.Windows.Forms.Label();
            this.radBanka = new System.Windows.Forms.RadioButton();
            this.radTelefon = new System.Windows.Forms.RadioButton();
            this.radYetkili = new System.Windows.Forms.RadioButton();
            this.radFirmaAdi = new System.Windows.Forms.RadioButton();
            this.grpTedarikciSorgulama.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTedarikcilerSorgulama)).BeginInit();
            this.grpHizliSorgulama.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpTedarikciSorgulama
            // 
            this.grpTedarikciSorgulama.Controls.Add(this.btnTemizle);
            this.grpTedarikciSorgulama.Controls.Add(this.btnAra);
            this.grpTedarikciSorgulama.Controls.Add(this.txtYetkili);
            this.grpTedarikciSorgulama.Controls.Add(this.txtFirmaAdi);
            this.grpTedarikciSorgulama.Controls.Add(this.chkYetkili);
            this.grpTedarikciSorgulama.Controls.Add(this.chkFirmaAdi);
            this.grpTedarikciSorgulama.Location = new System.Drawing.Point(20, 20);
            this.grpTedarikciSorgulama.Name = "grpTedarikciSorgulama";
            this.grpTedarikciSorgulama.Size = new System.Drawing.Size(840, 110);
            this.grpTedarikciSorgulama.TabIndex = 2;
            this.grpTedarikciSorgulama.TabStop = false;
            this.grpTedarikciSorgulama.Text = "Firma Adı / Yetkili ile Birebir Sorgulama";
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(746, 31);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(85, 28);
            this.btnTemizle.TabIndex = 2;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnAra
            // 
            this.btnAra.Location = new System.Drawing.Point(655, 31);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(85, 28);
            this.btnAra.TabIndex = 2;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // txtYetkili
            // 
            this.txtYetkili.Enabled = false;
            this.txtYetkili.Location = new System.Drawing.Point(460, 33);
            this.txtYetkili.Multiline = true;
            this.txtYetkili.Name = "txtYetkili";
            this.txtYetkili.Size = new System.Drawing.Size(170, 24);
            this.txtYetkili.TabIndex = 1;
            // 
            // txtFirmaAdi
            // 
            this.txtFirmaAdi.Enabled = false;
            this.txtFirmaAdi.Location = new System.Drawing.Point(150, 33);
            this.txtFirmaAdi.Multiline = true;
            this.txtFirmaAdi.Name = "txtFirmaAdi";
            this.txtFirmaAdi.Size = new System.Drawing.Size(170, 24);
            this.txtFirmaAdi.TabIndex = 1;
            // 
            // chkYetkili
            // 
            this.chkYetkili.AutoSize = true;
            this.chkYetkili.Location = new System.Drawing.Point(350, 35);
            this.chkYetkili.Name = "chkYetkili";
            this.chkYetkili.Size = new System.Drawing.Size(91, 17);
            this.chkYetkili.TabIndex = 0;
            this.chkYetkili.Text = "Yetkiliye Göre";
            this.chkYetkili.UseVisualStyleBackColor = true;
            this.chkYetkili.CheckedChanged += new System.EventHandler(this.chkYetkili_CheckedChanged);
            // 
            // chkFirmaAdi
            // 
            this.chkFirmaAdi.AutoSize = true;
            this.chkFirmaAdi.Location = new System.Drawing.Point(25, 35);
            this.chkFirmaAdi.Name = "chkFirmaAdi";
            this.chkFirmaAdi.Size = new System.Drawing.Size(107, 17);
            this.chkFirmaAdi.TabIndex = 0;
            this.chkFirmaAdi.Text = "Firma Adına Göre";
            this.chkFirmaAdi.UseVisualStyleBackColor = true;
            this.chkFirmaAdi.CheckedChanged += new System.EventHandler(this.chkFirmaAdi_CheckedChanged);
            // 
            // dgvTedarikcilerSorgulama
            // 
            this.dgvTedarikcilerSorgulama.AllowUserToAddRows = false;
            this.dgvTedarikcilerSorgulama.AllowUserToDeleteRows = false;
            this.dgvTedarikcilerSorgulama.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTedarikcilerSorgulama.Location = new System.Drawing.Point(20, 285);
            this.dgvTedarikcilerSorgulama.MultiSelect = false;
            this.dgvTedarikcilerSorgulama.Name = "dgvTedarikcilerSorgulama";
            this.dgvTedarikcilerSorgulama.ReadOnly = true;
            this.dgvTedarikcilerSorgulama.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTedarikcilerSorgulama.Size = new System.Drawing.Size(840, 300);
            this.dgvTedarikcilerSorgulama.TabIndex = 3;
            // 
            // grpHizliSorgulama
            // 
            this.grpHizliSorgulama.Controls.Add(this.txtHizliAra);
            this.grpHizliSorgulama.Controls.Add(this.cmbAramaTuru);
            this.grpHizliSorgulama.Controls.Add(this.lblHizliBilgi);
            this.grpHizliSorgulama.Controls.Add(this.lblArananAlan);
            this.grpHizliSorgulama.Controls.Add(this.lblAramaTuru);
            this.grpHizliSorgulama.Controls.Add(this.radBanka);
            this.grpHizliSorgulama.Controls.Add(this.radTelefon);
            this.grpHizliSorgulama.Controls.Add(this.radYetkili);
            this.grpHizliSorgulama.Controls.Add(this.radFirmaAdi);
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
            this.cmbAramaTuru.Location = new System.Drawing.Point(485, 33);
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
            this.lblAramaTuru.Location = new System.Drawing.Point(395, 36);
            this.lblAramaTuru.Name = "lblAramaTuru";
            this.lblAramaTuru.Size = new System.Drawing.Size(65, 13);
            this.lblAramaTuru.TabIndex = 1;
            this.lblAramaTuru.Text = "Arama Türü:";
            // 
            // radBanka
            // 
            this.radBanka.AutoSize = true;
            this.radBanka.Location = new System.Drawing.Point(300, 35);
            this.radBanka.Name = "radBanka";
            this.radBanka.Size = new System.Drawing.Size(56, 17);
            this.radBanka.TabIndex = 0;
            this.radBanka.TabStop = true;
            this.radBanka.Text = "Banka";
            this.radBanka.UseVisualStyleBackColor = true;
            this.radBanka.CheckedChanged += new System.EventHandler(this.radBanka_CheckedChanged);
            // 
            // radTelefon
            // 
            this.radTelefon.AutoSize = true;
            this.radTelefon.Location = new System.Drawing.Point(210, 35);
            this.radTelefon.Name = "radTelefon";
            this.radTelefon.Size = new System.Drawing.Size(61, 17);
            this.radTelefon.TabIndex = 0;
            this.radTelefon.TabStop = true;
            this.radTelefon.Text = "Telefon";
            this.radTelefon.UseVisualStyleBackColor = true;
            this.radTelefon.CheckedChanged += new System.EventHandler(this.radTelefon_CheckedChanged);
            // 
            // radYetkili
            // 
            this.radYetkili.AutoSize = true;
            this.radYetkili.Location = new System.Drawing.Point(125, 35);
            this.radYetkili.Name = "radYetkili";
            this.radYetkili.Size = new System.Drawing.Size(53, 17);
            this.radYetkili.TabIndex = 0;
            this.radYetkili.TabStop = true;
            this.radYetkili.Text = "Yetkili";
            this.radYetkili.UseVisualStyleBackColor = true;
            this.radYetkili.CheckedChanged += new System.EventHandler(this.radYetkili_CheckedChanged);
            // 
            // radFirmaAdi
            // 
            this.radFirmaAdi.AutoSize = true;
            this.radFirmaAdi.Location = new System.Drawing.Point(25, 35);
            this.radFirmaAdi.Name = "radFirmaAdi";
            this.radFirmaAdi.Size = new System.Drawing.Size(68, 17);
            this.radFirmaAdi.TabIndex = 0;
            this.radFirmaAdi.TabStop = true;
            this.radFirmaAdi.Text = "Firma Adı";
            this.radFirmaAdi.UseVisualStyleBackColor = true;
            this.radFirmaAdi.CheckedChanged += new System.EventHandler(this.radFirmaAdi_CheckedChanged);
            // 
            // FrmTedarikcilerSorgulama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 611);
            this.Controls.Add(this.grpHizliSorgulama);
            this.Controls.Add(this.dgvTedarikcilerSorgulama);
            this.Controls.Add(this.grpTedarikciSorgulama);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmTedarikcilerSorgulama";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tedarikçiler Sorgulama";
            this.Load += new System.EventHandler(this.FrmTedarikcilerSorgulama_Load);
            this.grpTedarikciSorgulama.ResumeLayout(false);
            this.grpTedarikciSorgulama.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTedarikcilerSorgulama)).EndInit();
            this.grpHizliSorgulama.ResumeLayout(false);
            this.grpHizliSorgulama.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpTedarikciSorgulama;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.TextBox txtFirmaAdi;
        private System.Windows.Forms.CheckBox chkYetkili;
        private System.Windows.Forms.CheckBox chkFirmaAdi;
        private System.Windows.Forms.TextBox txtYetkili;
        private System.Windows.Forms.DataGridView dgvTedarikcilerSorgulama;
        private System.Windows.Forms.GroupBox grpHizliSorgulama;
        private System.Windows.Forms.TextBox txtHizliAra;
        private System.Windows.Forms.ComboBox cmbAramaTuru;
        private System.Windows.Forms.Label lblHizliBilgi;
        private System.Windows.Forms.Label lblArananAlan;
        private System.Windows.Forms.Label lblAramaTuru;
        private System.Windows.Forms.RadioButton radBanka;
        private System.Windows.Forms.RadioButton radTelefon;
        private System.Windows.Forms.RadioButton radYetkili;
        private System.Windows.Forms.RadioButton radFirmaAdi;
    }
}