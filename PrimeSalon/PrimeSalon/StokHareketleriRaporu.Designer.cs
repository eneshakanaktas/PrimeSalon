
namespace PrimeSalon
{
    partial class StokHareketleriRaporu
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.PrimeSalonDB_PrimaryDataSet = new PrimeSalon.PrimeSalonDB_PrimaryDataSet();
            this.StokHareketleriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.StokHareketleriTableAdapter = new PrimeSalon.PrimeSalonDB_PrimaryDataSetTableAdapters.StokHareketleriTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.PrimeSalonDB_PrimaryDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StokHareketleriBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.DocumentMapWidth = 30;
            reportDataSource2.Name = "StokHareketleri";
            reportDataSource2.Value = this.StokHareketleriBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PrimeSalon.StokHareketleriRaporu.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1103, 669);
            this.reportViewer1.TabIndex = 0;
            // 
            // PrimeSalonDB_PrimaryDataSet
            // 
            this.PrimeSalonDB_PrimaryDataSet.DataSetName = "PrimeSalonDB_PrimaryDataSet";
            this.PrimeSalonDB_PrimaryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // StokHareketleriBindingSource
            // 
            this.StokHareketleriBindingSource.DataMember = "StokHareketleri";
            this.StokHareketleriBindingSource.DataSource = this.PrimeSalonDB_PrimaryDataSet;
            // 
            // StokHareketleriTableAdapter
            // 
            this.StokHareketleriTableAdapter.ClearBeforeFill = true;
            // 
            // StokHareketleriRaporu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1103, 669);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "StokHareketleriRaporu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stok Hareketleri Raporu";
            this.Load += new System.EventHandler(this.StokHareketleriRaporu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PrimeSalonDB_PrimaryDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StokHareketleriBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource StokHareketleriBindingSource;
        private PrimeSalonDB_PrimaryDataSet PrimeSalonDB_PrimaryDataSet;
        private PrimeSalonDB_PrimaryDataSetTableAdapters.StokHareketleriTableAdapter StokHareketleriTableAdapter;
    }
}