namespace MiPrimerProyecto.Formularios
{
    partial class frmDetalleBug
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
            this.txtNumBug = new System.Windows.Forms.TextBox();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.txtFechaCreacion = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtPrioridad = new System.Windows.Forms.TextBox();
            this.txtCriticidad = new System.Windows.Forms.TextBox();
            this.lblNumBug = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblProducto = new System.Windows.Forms.Label();
            this.lblFechaCreacion = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblPrioridad = new System.Windows.Forms.Label();
            this.lblCriticidad = new System.Windows.Forms.Label();
            this.grdHistorial = new System.Windows.Forms.DataGridView();
            this.gboHistorialBug = new System.Windows.Forms.GroupBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.responsable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.asignadoA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdHistorial)).BeginInit();
            this.gboHistorialBug.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNumBug
            // 
            this.txtNumBug.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumBug.Location = new System.Drawing.Point(108, 10);
            this.txtNumBug.Name = "txtNumBug";
            this.txtNumBug.ReadOnly = true;
            this.txtNumBug.Size = new System.Drawing.Size(199, 20);
            this.txtNumBug.TabIndex = 0;
            // 
            // txtTitulo
            // 
            this.txtTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitulo.Location = new System.Drawing.Point(108, 36);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.ReadOnly = true;
            this.txtTitulo.Size = new System.Drawing.Size(199, 20);
            this.txtTitulo.TabIndex = 1;
            // 
            // txtProducto
            // 
            this.txtProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProducto.Location = new System.Drawing.Point(108, 62);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.ReadOnly = true;
            this.txtProducto.Size = new System.Drawing.Size(199, 20);
            this.txtProducto.TabIndex = 2;
            // 
            // txtFechaCreacion
            // 
            this.txtFechaCreacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFechaCreacion.Location = new System.Drawing.Point(108, 88);
            this.txtFechaCreacion.Name = "txtFechaCreacion";
            this.txtFechaCreacion.ReadOnly = true;
            this.txtFechaCreacion.Size = new System.Drawing.Size(198, 20);
            this.txtFechaCreacion.TabIndex = 3;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(108, 114);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.ReadOnly = true;
            this.txtDescripcion.Size = new System.Drawing.Size(299, 129);
            this.txtDescripcion.TabIndex = 4;
            // 
            // txtPrioridad
            // 
            this.txtPrioridad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrioridad.Location = new System.Drawing.Point(108, 249);
            this.txtPrioridad.Name = "txtPrioridad";
            this.txtPrioridad.ReadOnly = true;
            this.txtPrioridad.Size = new System.Drawing.Size(199, 20);
            this.txtPrioridad.TabIndex = 5;
            // 
            // txtCriticidad
            // 
            this.txtCriticidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCriticidad.Location = new System.Drawing.Point(108, 275);
            this.txtCriticidad.Name = "txtCriticidad";
            this.txtCriticidad.ReadOnly = true;
            this.txtCriticidad.Size = new System.Drawing.Size(199, 20);
            this.txtCriticidad.TabIndex = 6;
            // 
            // lblNumBug
            // 
            this.lblNumBug.AutoSize = true;
            this.lblNumBug.Location = new System.Drawing.Point(63, 13);
            this.lblNumBug.Name = "lblNumBug";
            this.lblNumBug.Size = new System.Drawing.Size(39, 13);
            this.lblNumBug.TabIndex = 7;
            this.lblNumBug.Text = "# Bug:";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(64, 39);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(38, 13);
            this.lblTitulo.TabIndex = 8;
            this.lblTitulo.Text = "Título:";
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Location = new System.Drawing.Point(49, 65);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(53, 13);
            this.lblProducto.TabIndex = 9;
            this.lblProducto.Text = "Producto:";
            // 
            // lblFechaCreacion
            // 
            this.lblFechaCreacion.AutoSize = true;
            this.lblFechaCreacion.Location = new System.Drawing.Point(18, 91);
            this.lblFechaCreacion.Name = "lblFechaCreacion";
            this.lblFechaCreacion.Size = new System.Drawing.Size(84, 13);
            this.lblFechaCreacion.TabIndex = 10;
            this.lblFechaCreacion.Text = "Fecha creación:";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(36, 117);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(66, 13);
            this.lblDescripcion.TabIndex = 11;
            this.lblDescripcion.Text = "Descripción:";
            // 
            // lblPrioridad
            // 
            this.lblPrioridad.AutoSize = true;
            this.lblPrioridad.Location = new System.Drawing.Point(51, 252);
            this.lblPrioridad.Name = "lblPrioridad";
            this.lblPrioridad.Size = new System.Drawing.Size(51, 13);
            this.lblPrioridad.TabIndex = 12;
            this.lblPrioridad.Text = "Prioridad:";
            // 
            // lblCriticidad
            // 
            this.lblCriticidad.AutoSize = true;
            this.lblCriticidad.Location = new System.Drawing.Point(49, 278);
            this.lblCriticidad.Name = "lblCriticidad";
            this.lblCriticidad.Size = new System.Drawing.Size(53, 13);
            this.lblCriticidad.TabIndex = 13;
            this.lblCriticidad.Text = "Criticidad:";
            // 
            // grdHistorial
            // 
            this.grdHistorial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdHistorial.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fecha,
            this.responsable,
            this.estado,
            this.asignadoA});
            this.grdHistorial.Location = new System.Drawing.Point(6, 19);
            this.grdHistorial.Name = "grdHistorial";
            this.grdHistorial.Size = new System.Drawing.Size(501, 186);
            this.grdHistorial.TabIndex = 14;
            // 
            // gboHistorialBug
            // 
            this.gboHistorialBug.Controls.Add(this.grdHistorial);
            this.gboHistorialBug.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboHistorialBug.Location = new System.Drawing.Point(12, 301);
            this.gboHistorialBug.Name = "gboHistorialBug";
            this.gboHistorialBug.Size = new System.Drawing.Size(513, 211);
            this.gboHistorialBug.TabIndex = 15;
            this.gboHistorialBug.TabStop = false;
            this.gboHistorialBug.Text = "Historial Bug";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(231, 518);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 16;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // fecha
            // 
            this.fecha.HeaderText = "Fecha";
            this.fecha.Name = "fecha";
            this.fecha.Width = 80;
            // 
            // responsable
            // 
            this.responsable.HeaderText = "Responsable";
            this.responsable.Name = "responsable";
            // 
            // estado
            // 
            this.estado.HeaderText = "Estado";
            this.estado.Name = "estado";
            // 
            // asignadoA
            // 
            this.asignadoA.HeaderText = "Asignado a";
            this.asignadoA.Name = "asignadoA";
            // 
            // frmDetalleBug
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 550);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.gboHistorialBug);
            this.Controls.Add(this.lblCriticidad);
            this.Controls.Add(this.lblPrioridad);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblFechaCreacion);
            this.Controls.Add(this.lblProducto);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblNumBug);
            this.Controls.Add(this.txtCriticidad);
            this.Controls.Add(this.txtPrioridad);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtFechaCreacion);
            this.Controls.Add(this.txtProducto);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.txtNumBug);
            this.Name = "frmDetalleBug";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Detalle de Bug";
            this.Load += new System.EventHandler(this.frmDetalleBug_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdHistorial)).EndInit();
            this.gboHistorialBug.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumBug;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.TextBox txtFechaCreacion;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtPrioridad;
        private System.Windows.Forms.TextBox txtCriticidad;
        private System.Windows.Forms.Label lblNumBug;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.Label lblFechaCreacion;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblPrioridad;
        private System.Windows.Forms.Label lblCriticidad;
        private System.Windows.Forms.DataGridView grdHistorial;
        private System.Windows.Forms.GroupBox gboHistorialBug;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn responsable;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn asignadoA;
    }
}