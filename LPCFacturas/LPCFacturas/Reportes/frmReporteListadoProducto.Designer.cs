﻿namespace LPCFacturas.Reportes
{
    partial class frmReporteListadoProducto
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
            this.bugsExtendidoDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bugsExtendidoDataSet = new LPCFacturas.BugsExtendidoDataSet();
            this.rvwProductos = new Microsoft.Reporting.WinForms.ReportViewer();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblFechaDesde = new System.Windows.Forms.Label();
            this.lblFechaHasta = new System.Windows.Forms.Label();
            this.dtpFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaHasta = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.bugsExtendidoDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bugsExtendidoDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // bugsExtendidoDataSetBindingSource
            // 
            this.bugsExtendidoDataSetBindingSource.DataSource = this.bugsExtendidoDataSet;
            this.bugsExtendidoDataSetBindingSource.Position = 0;
            // 
            // bugsExtendidoDataSet
            // 
            this.bugsExtendidoDataSet.DataSetName = "BugsExtendidoDataSet";
            this.bugsExtendidoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rvwProductos
            // 
            reportDataSource1.Name = "ListadoProductos";
            reportDataSource1.Value = this.bugsExtendidoDataSetBindingSource;
            this.rvwProductos.LocalReport.DataSources.Add(reportDataSource1);
            this.rvwProductos.LocalReport.ReportEmbeddedResource = "LPCFacturas.Reportes.ReporteListadoProducto.rdlc";
            this.rvwProductos.Location = new System.Drawing.Point(2, 66);
            this.rvwProductos.Name = "rvwProductos";
            this.rvwProductos.ServerReport.BearerToken = null;
            this.rvwProductos.Size = new System.Drawing.Size(1084, 451);
            this.rvwProductos.TabIndex = 0;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblNombre.Location = new System.Drawing.Point(625, 16);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(80, 23);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtNombre.Location = new System.Drawing.Point(725, 12);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 31);
            this.txtNombre.TabIndex = 4;
            this.txtNombre.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Image = global::LPCFacturas.Properties.Resources.Search;
            this.btnBuscar.Location = new System.Drawing.Point(959, 6);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(60, 47);
            this.btnBuscar.TabIndex = 5;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click_1);
            // 
            // lblFechaDesde
            // 
            this.lblFechaDesde.AutoSize = true;
            this.lblFechaDesde.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblFechaDesde.Location = new System.Drawing.Point(12, 16);
            this.lblFechaDesde.Name = "lblFechaDesde";
            this.lblFechaDesde.Size = new System.Drawing.Size(115, 23);
            this.lblFechaDesde.TabIndex = 1;
            this.lblFechaDesde.Text = "FechaDesde: ";
            // 
            // lblFechaHasta
            // 
            this.lblFechaHasta.AutoSize = true;
            this.lblFechaHasta.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblFechaHasta.Location = new System.Drawing.Point(306, 16);
            this.lblFechaHasta.Name = "lblFechaHasta";
            this.lblFechaHasta.Size = new System.Drawing.Size(106, 23);
            this.lblFechaHasta.TabIndex = 2;
            this.lblFechaHasta.Text = "FechaHasta:";
            // 
            // dtpFechaDesde
            // 
            this.dtpFechaDesde.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.dtpFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaDesde.Location = new System.Drawing.Point(133, 12);
            this.dtpFechaDesde.Name = "dtpFechaDesde";
            this.dtpFechaDesde.Size = new System.Drawing.Size(137, 31);
            this.dtpFechaDesde.TabIndex = 6;
            // 
            // dtpFechaHasta
            // 
            this.dtpFechaHasta.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.dtpFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaHasta.Location = new System.Drawing.Point(432, 12);
            this.dtpFechaHasta.Name = "dtpFechaHasta";
            this.dtpFechaHasta.Size = new System.Drawing.Size(142, 31);
            this.dtpFechaHasta.TabIndex = 7;
            // 
            // frmReporteListadoProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(131)))), ((int)(((byte)(156)))));
            this.ClientSize = new System.Drawing.Size(1088, 529);
            this.Controls.Add(this.dtpFechaHasta);
            this.Controls.Add(this.dtpFechaDesde);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblFechaHasta);
            this.Controls.Add(this.lblFechaDesde);
            this.Controls.Add(this.rvwProductos);
            this.Name = "frmReporteListadoProducto";
            this.Text = "Listado de Productos";
            this.Load += new System.EventHandler(this.frmReporteListadoProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bugsExtendidoDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bugsExtendidoDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rvwProductos;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.BindingSource bugsExtendidoDataSetBindingSource;
        private BugsExtendidoDataSet bugsExtendidoDataSet;
        private System.Windows.Forms.Label lblFechaDesde;
        private System.Windows.Forms.Label lblFechaHasta;
        private System.Windows.Forms.DateTimePicker dtpFechaDesde;
        private System.Windows.Forms.DateTimePicker dtpFechaHasta;
    }
}