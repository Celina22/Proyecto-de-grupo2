﻿namespace LPCFacturas.Reportes
{
    partial class frmReporteGraficoFactura
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
            this.bugsExtendidoDataSet = new LPCFacturas.BugsExtendidoDataSet();
            this.bugsExtendidoDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bugsExtendidoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bugsExtendidoDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "GraficoFacturas";
            reportDataSource1.Value = this.bugsExtendidoDataSetBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "LPCFacturas.Reportes.ReporteGraficoFactura.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(900, 426);
            this.reportViewer1.TabIndex = 0;
            // 
            // bugsExtendidoDataSet
            // 
            this.bugsExtendidoDataSet.DataSetName = "BugsExtendidoDataSet";
            this.bugsExtendidoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bugsExtendidoDataSetBindingSource
            // 
            this.bugsExtendidoDataSetBindingSource.DataSource = this.bugsExtendidoDataSet;
            this.bugsExtendidoDataSetBindingSource.Position = 0;
            // 
            // frmReporteGraficoFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmReporteGraficoFactura";
            this.Text = "frmReporteGraficoFactura";
            this.Load += new System.EventHandler(this.frmReporteGraficoFactura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bugsExtendidoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bugsExtendidoDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource bugsExtendidoDataSetBindingSource;
        private BugsExtendidoDataSet bugsExtendidoDataSet;
    }
}