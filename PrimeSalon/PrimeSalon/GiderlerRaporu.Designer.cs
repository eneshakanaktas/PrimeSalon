
namespace PrimeSalon
{
    partial class GiderlerRaporu
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
            this.GiderlerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PrimeSalonDB_PrimaryDataSet = new PrimeSalon.PrimeSalonDB_PrimaryDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.GiderlerTableAdapter = new PrimeSalon.PrimeSalonDB_PrimaryDataSetTableAdapters.GiderlerTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.GiderlerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrimeSalonDB_PrimaryDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // GiderlerBindingSource
            // 
            this.GiderlerBindingSource.DataMember = "Giderler";
            this.GiderlerBindingSource.DataSource = this.PrimeSalonDB_PrimaryDataSet;
            // 
            // PrimeSalonDB_PrimaryDataSet
            // 
            this.PrimeSalonDB_PrimaryDataSet.DataSetName = "PrimeSalonDB_PrimaryDataSet";
            this.PrimeSalonDB_PrimaryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.AutoSize = true;
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "Giderler";
            reportDataSource1.Value = this.GiderlerBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PrimeSalon.GiderlerRaporu.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(941, 639);
            this.reportViewer1.TabIndex = 0;
            // 
            // GiderlerTableAdapter
            // 
            this.GiderlerTableAdapter.ClearBeforeFill = true;
            // 
            // GiderlerRaporu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 639);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "GiderlerRaporu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giderler Raporu";
            this.Load += new System.EventHandler(this.GiderlerRaporu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GiderlerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrimeSalonDB_PrimaryDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource GiderlerBindingSource;
        private PrimeSalonDB_PrimaryDataSet PrimeSalonDB_PrimaryDataSet;
        private PrimeSalonDB_PrimaryDataSetTableAdapters.GiderlerTableAdapter GiderlerTableAdapter;
    }
}