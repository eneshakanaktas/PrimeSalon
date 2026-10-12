
namespace PrimeSalon
{
    partial class PersonelRaporu
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
            this.PersonelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PersonelTableAdapter = new PrimeSalon.PrimeSalonDB_PrimaryDataSetTableAdapters.PersonelTableAdapter();
            this.primeSalonDBPrimaryDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.primeSalonDBPrimaryDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PrimeSalonDB_PrimaryDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PersonelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.primeSalonDBPrimaryDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.primeSalonDBPrimaryDataSetBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.AutoSize = true;
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "Personel";
            reportDataSource2.Value = this.PersonelBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PrimeSalon.PersonelRapor.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(825, 745);
            this.reportViewer1.TabIndex = 0;
            // 
            // PrimeSalonDB_PrimaryDataSet
            // 
            this.PrimeSalonDB_PrimaryDataSet.DataSetName = "PrimeSalonDB_PrimaryDataSet";
            this.PrimeSalonDB_PrimaryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // PersonelBindingSource
            // 
            this.PersonelBindingSource.DataMember = "Personel";
            this.PersonelBindingSource.DataSource = this.PrimeSalonDB_PrimaryDataSet;
            // 
            // PersonelTableAdapter
            // 
            this.PersonelTableAdapter.ClearBeforeFill = true;
            // 
            // primeSalonDBPrimaryDataSetBindingSource
            // 
            this.primeSalonDBPrimaryDataSetBindingSource.DataSource = this.PrimeSalonDB_PrimaryDataSet;
            this.primeSalonDBPrimaryDataSetBindingSource.Position = 0;
            // 
            // primeSalonDBPrimaryDataSetBindingSource1
            // 
            this.primeSalonDBPrimaryDataSetBindingSource1.DataSource = this.PrimeSalonDB_PrimaryDataSet;
            this.primeSalonDBPrimaryDataSetBindingSource1.Position = 0;
            // 
            // PersonelRaporu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 745);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "PersonelRaporu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personel Raporu";
            this.Load += new System.EventHandler(this.PersonelRaporu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PrimeSalonDB_PrimaryDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PersonelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.primeSalonDBPrimaryDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.primeSalonDBPrimaryDataSetBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource PersonelBindingSource;
        private PrimeSalonDB_PrimaryDataSet PrimeSalonDB_PrimaryDataSet;
        private PrimeSalonDB_PrimaryDataSetTableAdapters.PersonelTableAdapter PersonelTableAdapter;
        private System.Windows.Forms.BindingSource primeSalonDBPrimaryDataSetBindingSource;
        private System.Windows.Forms.BindingSource primeSalonDBPrimaryDataSetBindingSource1;
    }
}