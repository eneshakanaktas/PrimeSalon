
namespace PrimeSalon
{
    partial class FrmStokHareketleriSorgulama
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
            this.grpStokSorgulama = new System.Windows.Forms.GroupBox();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnAra = new System.Windows.Forms.Button();
            this.cmbDepo = new System.Windows.Forms.ComboBox();
            this.chkDepo = new System.Windows.Forms.CheckBox();
            this.dgvStokHareketleriSorgulama = new System.Windows.Forms.DataGridView();
            this.grpHizliSorgulama = new System.Windows.Forms.GroupBox();
            this.txtHizliAra = new System.Windows.Forms.TextBox();
            this.cmbAramaTuru = new System.Windows.Forms.ComboBox();
            this.lblHizliBilgi = new System.Windows.Forms.Label();
            this.lblArananAlan = new System.Windows.Forms.Label();
            this.lblAramaTuru = new System.Windows.Forms.Label();
            this.radDepo = new System.Windows.Forms.RadioButton();
            this.radIslemTipi = new System.Windows.Forms.RadioButton();
            this.radKullanici = new System.Windows.Forms.RadioButton();
            this.grpStokSorgulama.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStokHareketleriSorgulama)).BeginInit();
            this.grpHizliSorgulama.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpStokSorgulama
            // 
            this.grpStokSorgulama.Controls.Add(this.btnTemizle);
            this.grpStokSorgulama.Controls.Add(this.btnAra);
            this.grpStokSorgulama.Controls.Add(this.cmbDepo);
            this.grpStokSorgulama.Controls.Add(this.chkDepo);
            this.grpStokSorgulama.Location = new System.Drawing.Point(20, 20);
            this.grpStokSorgulama.Name = "grpStokSorgulama";
            this.grpStokSorgulama.Size = new System.Drawing.Size(840, 110);
            this.grpStokSorgulama.TabIndex = 1;
            this.grpStokSorgulama.TabStop = false;
            this.grpStokSorgulama.Text = "Depoya Göre Sorgulama";
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(500, 31);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(85, 28);
            this.btnTemizle.TabIndex = 2;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnAra
            // 
            this.btnAra.Location = new System.Drawing.Point(400, 31);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(85, 28);
            this.btnAra.TabIndex = 2;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // cmbDepo
            // 
            this.cmbDepo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDepo.Enabled = false;
            this.cmbDepo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbDepo.FormattingEnabled = true;
            this.cmbDepo.Items.AddRange(new object[] {
            "Seçiniz",
            "Ana Depo",
            "Raf 1",
            "Raf 2",
            "Arka Oda"});
            this.cmbDepo.Location = new System.Drawing.Point(150, 33);
            this.cmbDepo.Name = "cmbDepo";
            this.cmbDepo.Size = new System.Drawing.Size(220, 25);
            this.cmbDepo.TabIndex = 1;
            // 
            // chkDepo
            // 
            this.chkDepo.AutoSize = true;
            this.chkDepo.Location = new System.Drawing.Point(25, 35);
            this.chkDepo.Name = "chkDepo";
            this.chkDepo.Size = new System.Drawing.Size(89, 17);
            this.chkDepo.TabIndex = 0;
            this.chkDepo.Text = "Depoya Göre";
            this.chkDepo.UseVisualStyleBackColor = true;
            this.chkDepo.CheckedChanged += new System.EventHandler(this.chkDepo_CheckedChanged);
            // 
            // dgvStokHareketleriSorgulama
            // 
            this.dgvStokHareketleriSorgulama.AllowUserToAddRows = false;
            this.dgvStokHareketleriSorgulama.AllowUserToDeleteRows = false;
            this.dgvStokHareketleriSorgulama.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStokHareketleriSorgulama.Location = new System.Drawing.Point(20, 285);
            this.dgvStokHareketleriSorgulama.MultiSelect = false;
            this.dgvStokHareketleriSorgulama.Name = "dgvStokHareketleriSorgulama";
            this.dgvStokHareketleriSorgulama.ReadOnly = true;
            this.dgvStokHareketleriSorgulama.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStokHareketleriSorgulama.Size = new System.Drawing.Size(840, 300);
            this.dgvStokHareketleriSorgulama.TabIndex = 2;
            // 
            // grpHizliSorgulama
            // 
            this.grpHizliSorgulama.Controls.Add(this.txtHizliAra);
            this.grpHizliSorgulama.Controls.Add(this.cmbAramaTuru);
            this.grpHizliSorgulama.Controls.Add(this.lblHizliBilgi);
            this.grpHizliSorgulama.Controls.Add(this.lblArananAlan);
            this.grpHizliSorgulama.Controls.Add(this.lblAramaTuru);
            this.grpHizliSorgulama.Controls.Add(this.radDepo);
            this.grpHizliSorgulama.Controls.Add(this.radIslemTipi);
            this.grpHizliSorgulama.Controls.Add(this.radKullanici);
            this.grpHizliSorgulama.Location = new System.Drawing.Point(20, 145);
            this.grpHizliSorgulama.Name = "grpHizliSorgulama";
            this.grpHizliSorgulama.Size = new System.Drawing.Size(840, 125);
            this.grpHizliSorgulama.TabIndex = 7;
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
            this.cmbAramaTuru.Location = new System.Drawing.Point(420, 33);
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
            this.lblAramaTuru.Location = new System.Drawing.Point(330, 36);
            this.lblAramaTuru.Name = "lblAramaTuru";
            this.lblAramaTuru.Size = new System.Drawing.Size(65, 13);
            this.lblAramaTuru.TabIndex = 1;
            this.lblAramaTuru.Text = "Arama Türü:";
            // 
            // radDepo
            // 
            this.radDepo.AutoSize = true;
            this.radDepo.Location = new System.Drawing.Point(230, 35);
            this.radDepo.Name = "radDepo";
            this.radDepo.Size = new System.Drawing.Size(51, 17);
            this.radDepo.TabIndex = 0;
            this.radDepo.TabStop = true;
            this.radDepo.Text = "Depo";
            this.radDepo.UseVisualStyleBackColor = true;
            this.radDepo.CheckedChanged += new System.EventHandler(this.radDepo_CheckedChanged);
            // 
            // radIslemTipi
            // 
            this.radIslemTipi.AutoSize = true;
            this.radIslemTipi.Location = new System.Drawing.Point(125, 35);
            this.radIslemTipi.Name = "radIslemTipi";
            this.radIslemTipi.Size = new System.Drawing.Size(69, 17);
            this.radIslemTipi.TabIndex = 0;
            this.radIslemTipi.TabStop = true;
            this.radIslemTipi.Text = "İşlem Tipi";
            this.radIslemTipi.UseVisualStyleBackColor = true;
            this.radIslemTipi.CheckedChanged += new System.EventHandler(this.radIslemTipi_CheckedChanged);
            // 
            // radKullanici
            // 
            this.radKullanici.AutoSize = true;
            this.radKullanici.Location = new System.Drawing.Point(25, 35);
            this.radKullanici.Name = "radKullanici";
            this.radKullanici.Size = new System.Drawing.Size(64, 17);
            this.radKullanici.TabIndex = 0;
            this.radKullanici.TabStop = true;
            this.radKullanici.Text = "Kullanıcı";
            this.radKullanici.UseVisualStyleBackColor = true;
            this.radKullanici.CheckedChanged += new System.EventHandler(this.radKullanici_CheckedChanged);
            // 
            // FrmStokHareketleriSorgulama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 611);
            this.Controls.Add(this.grpHizliSorgulama);
            this.Controls.Add(this.dgvStokHareketleriSorgulama);
            this.Controls.Add(this.grpStokSorgulama);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmStokHareketleriSorgulama";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stok Hareketleri Sorgulama";
            this.Load += new System.EventHandler(this.FrmStokHareketleriSorgulama_Load);
            this.grpStokSorgulama.ResumeLayout(false);
            this.grpStokSorgulama.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStokHareketleriSorgulama)).EndInit();
            this.grpHizliSorgulama.ResumeLayout(false);
            this.grpHizliSorgulama.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpStokSorgulama;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.ComboBox cmbDepo;
        private System.Windows.Forms.CheckBox chkDepo;
        private System.Windows.Forms.DataGridView dgvStokHareketleriSorgulama;
        private System.Windows.Forms.GroupBox grpHizliSorgulama;
        private System.Windows.Forms.TextBox txtHizliAra;
        private System.Windows.Forms.ComboBox cmbAramaTuru;
        private System.Windows.Forms.Label lblHizliBilgi;
        private System.Windows.Forms.Label lblArananAlan;
        private System.Windows.Forms.Label lblAramaTuru;
        private System.Windows.Forms.RadioButton radDepo;
        private System.Windows.Forms.RadioButton radIslemTipi;
        private System.Windows.Forms.RadioButton radKullanici;
    }
}