
namespace PrimeSalon
{
    partial class IzinRaporu
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.PrimeSalonDB_PrimaryDataSet = new PrimeSalon.PrimeSalonDB_PrimaryDataSet();
            this.IzinPuantajBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.IzinPuantajTableAdapter = new PrimeSalon.PrimeSalonDB_PrimaryDataSetTableAdapters.IzinPuantajTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.PrimeSalonDB_PrimaryDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IzinPuantajBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "IzınRaporu";
            reportDataSource1.Value = this.IzinPuantajBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PrimeSalon.IzınRaporu.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1109, 840);
            this.reportViewer1.TabIndex = 0;
            // 
            // PrimeSalonDB_PrimaryDataSet
            // 
            this.PrimeSalonDB_PrimaryDataSet.DataSetName = "PrimeSalonDB_PrimaryDataSet";
            this.PrimeSalonDB_PrimaryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // IzinPuantajBindingSource
            // 
            this.IzinPuantajBindingSource.DataMember = "IzinPuantaj";
            this.IzinPuantajBindingSource.DataSource = this.PrimeSalonDB_PrimaryDataSet;
            // 
            // IzinPuantajTableAdapter
            // 
            this.IzinPuantajTableAdapter.ClearBeforeFill = true;
            // 
            // IzinRaporu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1109, 840);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "IzinRaporu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "İzin Raporu";
            this.Load += new System.EventHandler(this.IzinRaporu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PrimeSalonDB_PrimaryDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IzinPuantajBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource IzinPuantajBindingSource;
        private PrimeSalonDB_PrimaryDataSet PrimeSalonDB_PrimaryDataSet;
        private PrimeSalonDB_PrimaryDataSetTableAdapters.IzinPuantajTableAdapter IzinPuantajTableAdapter;
    }
}