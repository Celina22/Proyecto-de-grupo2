namespace LPCFacturas.Reportes
{
    partial class frmReporteListadoProyectos
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
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtVersion = new System.Windows.Forms.TextBox();
            this.lblVersion = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.cboProducto = new System.Windows.Forms.ComboBox();
            this.lblProducto = new System.Windows.Forms.Label();
            this.cboResponsable = new System.Windows.Forms.ComboBox();
            this.lblResponsable = new System.Windows.Forms.Label();
            this.txtAlcance = new System.Windows.Forms.TextBox();
            this.lblAlcance = new System.Windows.Forms.Label();
            this.rvwProyectos = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // btnBuscar
            // 
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Image = global::LPCFacturas.Properties.Resources.Search;
            this.btnBuscar.Location = new System.Drawing.Point(975, 31);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(40, 34);
            this.btnBuscar.TabIndex = 36;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtVersion
            // 
            this.txtVersion.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtVersion.Location = new System.Drawing.Point(805, 12);
            this.txtVersion.Name = "txtVersion";
            this.txtVersion.Size = new System.Drawing.Size(105, 31);
            this.txtVersion.TabIndex = 38;
            this.txtVersion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblVersion.Location = new System.Drawing.Point(724, 15);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(75, 23);
            this.lblVersion.TabIndex = 37;
            this.lblVersion.Text = "Versión:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtDescripcion.Location = new System.Drawing.Point(126, 12);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(232, 31);
            this.txtDescripcion.TabIndex = 40;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblDescripcion.Location = new System.Drawing.Point(12, 15);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(108, 23);
            this.lblDescripcion.TabIndex = 39;
            this.lblDescripcion.Text = "Descripción:";
            // 
            // cboProducto
            // 
            this.cboProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(235)))), ((int)(((byte)(237)))));
            this.cboProducto.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.cboProducto.FormattingEnabled = true;
            this.cboProducto.Location = new System.Drawing.Point(126, 49);
            this.cboProducto.Name = "cboProducto";
            this.cboProducto.Size = new System.Drawing.Size(232, 31);
            this.cboProducto.TabIndex = 42;
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblProducto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(28)))), ((int)(((byte)(46)))));
            this.lblProducto.Location = new System.Drawing.Point(33, 52);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(87, 23);
            this.lblProducto.TabIndex = 41;
            this.lblProducto.Text = "Producto:";
            // 
            // cboResponsable
            // 
            this.cboResponsable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(235)))), ((int)(((byte)(237)))));
            this.cboResponsable.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.cboResponsable.FormattingEnabled = true;
            this.cboResponsable.Location = new System.Drawing.Point(486, 12);
            this.cboResponsable.Name = "cboResponsable";
            this.cboResponsable.Size = new System.Drawing.Size(232, 31);
            this.cboResponsable.TabIndex = 44;
            // 
            // lblResponsable
            // 
            this.lblResponsable.AutoSize = true;
            this.lblResponsable.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblResponsable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(28)))), ((int)(((byte)(46)))));
            this.lblResponsable.Location = new System.Drawing.Point(364, 15);
            this.lblResponsable.Name = "lblResponsable";
            this.lblResponsable.Size = new System.Drawing.Size(116, 23);
            this.lblResponsable.TabIndex = 43;
            this.lblResponsable.Text = "Responsable:";
            // 
            // txtAlcance
            // 
            this.txtAlcance.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtAlcance.Location = new System.Drawing.Point(486, 49);
            this.txtAlcance.Name = "txtAlcance";
            this.txtAlcance.Size = new System.Drawing.Size(232, 31);
            this.txtAlcance.TabIndex = 46;
            this.txtAlcance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblAlcance
            // 
            this.lblAlcance.AutoSize = true;
            this.lblAlcance.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblAlcance.Location = new System.Drawing.Point(403, 52);
            this.lblAlcance.Name = "lblAlcance";
            this.lblAlcance.Size = new System.Drawing.Size(77, 23);
            this.lblAlcance.TabIndex = 45;
            this.lblAlcance.Text = "Alcance:";
            // 
            // rvwProyectos
            // 
            this.rvwProyectos.LocalReport.ReportEmbeddedResource = "LPCFacturas.Reportes.ReporteListadoProyectos.rdlc";
            this.rvwProyectos.Location = new System.Drawing.Point(11, 106);
            this.rvwProyectos.Margin = new System.Windows.Forms.Padding(2);
            this.rvwProyectos.Name = "rvwProyectos";
            this.rvwProyectos.Size = new System.Drawing.Size(1030, 532);
            this.rvwProyectos.TabIndex = 47;
            this.rvwProyectos.Load += new System.EventHandler(this.rvwProyectos_Load);
            // 
            // frmReporteListadoProyectos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(131)))), ((int)(((byte)(156)))));
            this.ClientSize = new System.Drawing.Size(1052, 649);
            this.Controls.Add(this.rvwProyectos);
            this.Controls.Add(this.txtAlcance);
            this.Controls.Add(this.lblAlcance);
            this.Controls.Add(this.cboResponsable);
            this.Controls.Add(this.lblResponsable);
            this.Controls.Add(this.cboProducto);
            this.Controls.Add(this.lblProducto);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.txtVersion);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.btnBuscar);
            this.Name = "frmReporteListadoProyectos";
            this.Text = "Listado de Proyectos";
            this.Load += new System.EventHandler(this.frmReporteListadoProyectos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtVersion;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.ComboBox cboProducto;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.ComboBox cboResponsable;
        private System.Windows.Forms.Label lblResponsable;
        private System.Windows.Forms.TextBox txtAlcance;
        private System.Windows.Forms.Label lblAlcance;
        private Microsoft.Reporting.WinForms.ReportViewer rvwProyectos;
    }
}