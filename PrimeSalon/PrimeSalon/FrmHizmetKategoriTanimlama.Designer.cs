
namespace PrimeSalon
{
    partial class FrmHizmetKategoriTanimlama
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.grpVeriGirisi = new System.Windows.Forms.GroupBox();
            this.lblKategori = new System.Windows.Forms.Label();
            this.txtKategori = new System.Windows.Forms.TextBox();
            this.grpIslemler = new System.Windows.Forms.GroupBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.grpVeriGirisi.SuspendLayout();
            this.grpIslemler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();

            this.grpVeriGirisi.Controls.Add(this.lblKategori);
            this.grpVeriGirisi.Controls.Add(this.txtKategori);
            this.grpVeriGirisi.Location = new System.Drawing.Point(30, 25);
            this.grpVeriGirisi.Name = "grpVeriGirisi";
            this.grpVeriGirisi.Size = new System.Drawing.Size(260, 120);
            this.grpVeriGirisi.TabIndex = 0;
            this.grpVeriGirisi.TabStop = false;
            this.grpVeriGirisi.Text = "Veri Girişi";

            this.lblKategori.AutoSize = true;
            this.lblKategori.Location = new System.Drawing.Point(35, 55);
            this.lblKategori.Name = "lblKategori";
            this.lblKategori.Size = new System.Drawing.Size(46, 13);
            this.lblKategori.TabIndex = 0;
            this.lblKategori.Text = "Kategori";

            this.txtKategori.Location = new System.Drawing.Point(105, 52);
            this.txtKategori.Name = "txtKategori";
            this.txtKategori.Size = new System.Drawing.Size(120, 20);
            this.txtKategori.TabIndex = 1;

            this.grpIslemler.Controls.Add(this.btnEkle);
            this.grpIslemler.Controls.Add(this.btnSil);
            this.grpIslemler.Controls.Add(this.btnGuncelle);
            this.grpIslemler.Controls.Add(this.btnTemizle);
            this.grpIslemler.Location = new System.Drawing.Point(320, 25);
            this.grpIslemler.Name = "grpIslemler";
            this.grpIslemler.Size = new System.Drawing.Size(260, 120);
            this.grpIslemler.TabIndex = 1;
            this.grpIslemler.TabStop = false;
            this.grpIslemler.Text = "İşlemler";

            this.btnEkle.Location = new System.Drawing.Point(35, 30);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(85, 32);
            this.btnEkle.TabIndex = 0;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);

            this.btnSil.Location = new System.Drawing.Point(140, 30);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(85, 32);
            this.btnSil.TabIndex = 1;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);

            this.btnGuncelle.Location = new System.Drawing.Point(35, 75);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(85, 32);
            this.btnGuncelle.TabIndex = 2;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);

            this.btnTemizle.Location = new System.Drawing.Point(140, 75);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(85, 32);
            this.btnTemizle.TabIndex = 3;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);

            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(30, 170);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 35;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(550, 180);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);

            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(610, 375);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.grpIslemler);
            this.Controls.Add(this.grpVeriGirisi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmHizmetKategoriTanimlama";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hizmet Kategori Tanımlama";
            this.Activated += new System.EventHandler(this.FrmHizmetKategoriTanimlama_Activated);
            this.Load += new System.EventHandler(this.FrmHizmetKategoriTanimlama_Load);

            this.grpVeriGirisi.ResumeLayout(false);
            this.grpVeriGirisi.PerformLayout();
            this.grpIslemler.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox grpVeriGirisi;
        private System.Windows.Forms.Label lblKategori;
        private System.Windows.Forms.TextBox txtKategori;
        private System.Windows.Forms.GroupBox grpIslemler;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}