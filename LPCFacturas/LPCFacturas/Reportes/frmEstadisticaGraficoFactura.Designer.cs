namespace LPCFacturas.Reportes
{
    partial class frmEstadisticaGraficoFactura
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.bugsExtendidoDataSetBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.bugsExtendidoDataSet = new LPCFacturas.BugsExtendidoDataSet();
            this.bugsExtendidoDataSetBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.bugsExtendidoDataSetBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.bugsExtendidoDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rpvGraficoFacturas = new Microsoft.Reporting.WinForms.ReportViewer();
            this.bugsExtendidoDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bugsExtendidoDataSetBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bugsExtendidoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bugsExtendidoDataSetBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bugsExtendidoDataSetBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bugsExtendidoDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bugsExtendidoDataSetBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // bugsExtendidoDataSetBindingSource2
            // 
            this.bugsExtendidoDataSetBindingSource2.DataSource = this.bugsExtendidoDataSet;
            this.bugsExtendidoDataSetBindingSource2.Position = 0;
            // 
            // bugsExtendidoDataSet
            // 
            this.bugsExtendidoDataSet.DataSetName = "BugsExtendidoDataSet";
            this.bugsExtendidoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bugsExtendidoDataSetBindingSource3
            // 
            this.bugsExtendidoDataSetBindingSource3.DataSource = this.bugsExtendidoDataSet;
            this.bugsExtendidoDataSetBindingSource3.Position = 0;
            // 
            // bugsExtendidoDataSetBindingSource4
            // 
            this.bugsExtendidoDataSetBindingSource4.DataSource = this.bugsExtendidoDataSet;
            this.bugsExtendidoDataSetBindingSource4.Position = 0;
            // 
            // bugsExtendidoDataSetBindingSource
            // 
            this.bugsExtendidoDataSetBindingSource.DataSource = this.bugsExtendidoDataSet;
            this.bugsExtendidoDataSetBindingSource.Position = 0;
            // 
            // rpvGraficoFacturas
            // 
            this.rpvGraficoFacturas.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "GraficoFacturas";
            reportDataSource1.Value = this.bugsExtendidoDataSetBindingSource2;
            reportDataSource2.Name = "GraficoFacturasPorMes";
            reportDataSource2.Value = this.bugsExtendidoDataSetBindingSource3;
            reportDataSource3.Name = "GraficoFacturasTotal";
            reportDataSource3.Value = this.bugsExtendidoDataSetBindingSource4;
            this.rpvGraficoFacturas.LocalReport.DataSources.Add(reportDataSource1);
            this.rpvGraficoFacturas.LocalReport.DataSources.Add(reportDataSource2);
            this.rpvGraficoFacturas.LocalReport.DataSources.Add(reportDataSource3);
            this.rpvGraficoFacturas.LocalReport.ReportEmbeddedResource = "LPCFacturas.Reportes.ReporteGraficoFactura.rdlc";
            this.rpvGraficoFacturas.Location = new System.Drawing.Point(0, 0);
            this.rpvGraficoFacturas.Name = "rpvGraficoFacturas";
            this.rpvGraficoFacturas.ServerReport.BearerToken = null;
            this.rpvGraficoFacturas.Size = new System.Drawing.Size(1096, 749);
            this.rpvGraficoFacturas.TabIndex = 0;
            // 
            // bugsExtendidoDataSetBindingSource1
            // 
            this.bugsExtendidoDataSetBindingSource1.DataSource = this.bugsExtendidoDataSet;
            this.bugsExtendidoDataSetBindingSource1.Position = 0;
            // 
            // frmEstadisticaGraficoFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 749);
            this.Controls.Add(this.rpvGraficoFacturas);
            this.MaximumSize = new System.Drawing.Size(1112, 788);
            this.MinimumSize = new System.Drawing.Size(1112, 726);
            this.Name = "frmEstadisticaGraficoFactura";
            this.Text = "frmEstadisticaGraficoFactura";
            this.Load += new System.EventHandler(this.frmEstadisticaGraficoFactura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bugsExtendidoDataSetBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bugsExtendidoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bugsExtendidoDataSetBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bugsExtendidoDataSetBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bugsExtendidoDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bugsExtendidoDataSetBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpvGraficoFacturas;
        private System.Windows.Forms.BindingSource bugsExtendidoDataSetBindingSource;
        private BugsExtendidoDataSet bugsExtendidoDataSet;
        private System.Windows.Forms.BindingSource bugsExtendidoDataSetBindingSource2;
        private System.Windows.Forms.BindingSource bugsExtendidoDataSetBindingSource1;
        private System.Windows.Forms.BindingSource bugsExtendidoDataSetBindingSource3;
        private System.Windows.Forms.BindingSource bugsExtendidoDataSetBindingSource4;
    }
}