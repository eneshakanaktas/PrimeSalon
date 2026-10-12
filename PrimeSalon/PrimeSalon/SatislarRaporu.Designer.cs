
namespace PrimeSalon
{
    partial class SatislarRaporu
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
            this.SatislarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SatislarTableAdapter = new PrimeSalon.PrimeSalonDB_PrimaryDataSetTableAdapters.SatislarTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.PrimeSalonDB_PrimaryDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SatislarBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.SatislarBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PrimeSalon.SatislarRaporu.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1120, 752);
            this.reportViewer1.TabIndex = 0;
            // 
            // PrimeSalonDB_PrimaryDataSet
            // 
            this.PrimeSalonDB_PrimaryDataSet.DataSetName = "PrimeSalonDB_PrimaryDataSet";
            this.PrimeSalonDB_PrimaryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // SatislarBindingSource
            // 
            this.SatislarBindingSource.DataMember = "Satislar";
            this.SatislarBindingSource.DataSource = this.PrimeSalonDB_PrimaryDataSet;
            // 
            // SatislarTableAdapter
            // 
            this.SatislarTableAdapter.ClearBeforeFill = true;
            // 
            // SatislarRaporu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 752);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "SatislarRaporu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Satışlar Raporu";
            this.Load += new System.EventHandler(this.SatislarRaporu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PrimeSalonDB_PrimaryDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SatislarBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource SatislarBindingSource;
        private PrimeSalonDB_PrimaryDataSet PrimeSalonDB_PrimaryDataSet;
        private PrimeSalonDB_PrimaryDataSetTableAdapters.SatislarTableAdapter SatislarTableAdapter;
    }
}