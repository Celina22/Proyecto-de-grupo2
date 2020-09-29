namespace LPCFacturas.GUILayer
{
    partial class frmFactura
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
            this.lblFecha = new System.Windows.Forms.Label();
            this.dtpFechaFactura = new System.Windows.Forms.DateTimePicker();
            this.lblNumeroFactura = new System.Windows.Forms.Label();
            this.txtNumeroFactura = new System.Windows.Forms.TextBox();
            this.lblClientes = new System.Windows.Forms.Label();
            this.txtIdCliente = new System.Windows.Forms.TextBox();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.gbxDetalles = new System.Windows.Forms.GroupBox();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.rdbProyecto = new System.Windows.Forms.RadioButton();
            this.rdbProducto = new System.Windows.Forms.RadioButton();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.dgvDetalles = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.esProducto = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.txtDetalle = new System.Windows.Forms.TextBox();
            this.txtIdDetalle = new System.Windows.Forms.TextBox();
            this.lblDetalle = new System.Windows.Forms.Label();
            this.txtProporcion = new System.Windows.Forms.TextBox();
            this.lblProporcion = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.lblValor = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.gbxDetalles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalles)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblFecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(28)))), ((int)(((byte)(46)))));
            this.lblFecha.Location = new System.Drawing.Point(116, 27);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(61, 23);
            this.lblFecha.TabIndex = 0;
            this.lblFecha.Text = "Fecha:";
            // 
            // dtpFechaFactura
            // 
            this.dtpFechaFactura.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.dtpFechaFactura.Location = new System.Drawing.Point(183, 21);
            this.dtpFechaFactura.Name = "dtpFechaFactura";
            this.dtpFechaFactura.Size = new System.Drawing.Size(317, 31);
            this.dtpFechaFactura.TabIndex = 1;
            // 
            // lblNumeroFactura
            // 
            this.lblNumeroFactura.AutoSize = true;
            this.lblNumeroFactura.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblNumeroFactura.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(28)))), ((int)(((byte)(46)))));
            this.lblNumeroFactura.Location = new System.Drawing.Point(35, 61);
            this.lblNumeroFactura.Name = "lblNumeroFactura";
            this.lblNumeroFactura.Size = new System.Drawing.Size(142, 23);
            this.lblNumeroFactura.TabIndex = 2;
            this.lblNumeroFactura.Text = "Número Factura:";
            // 
            // txtNumeroFactura
            // 
            this.txtNumeroFactura.Enabled = false;
            this.txtNumeroFactura.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtNumeroFactura.Location = new System.Drawing.Point(183, 58);
            this.txtNumeroFactura.Name = "txtNumeroFactura";
            this.txtNumeroFactura.ReadOnly = true;
            this.txtNumeroFactura.Size = new System.Drawing.Size(70, 31);
            this.txtNumeroFactura.TabIndex = 3;
            // 
            // lblClientes
            // 
            this.lblClientes.AutoSize = true;
            this.lblClientes.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblClientes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(28)))), ((int)(((byte)(46)))));
            this.lblClientes.Location = new System.Drawing.Point(105, 98);
            this.lblClientes.Name = "lblClientes";
            this.lblClientes.Size = new System.Drawing.Size(72, 23);
            this.lblClientes.TabIndex = 4;
            this.lblClientes.Text = "Cliente:";
            // 
            // txtIdCliente
            // 
            this.txtIdCliente.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtIdCliente.Location = new System.Drawing.Point(183, 95);
            this.txtIdCliente.Name = "txtIdCliente";
            this.txtIdCliente.Size = new System.Drawing.Size(70, 31);
            this.txtIdCliente.TabIndex = 5;
            this.txtIdCliente.Leave += new System.EventHandler(this.txtIdCliente_TextChanged);
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtNombreCliente.Location = new System.Drawing.Point(259, 95);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.ReadOnly = true;
            this.txtNombreCliente.Size = new System.Drawing.Size(241, 31);
            this.txtNombreCliente.TabIndex = 6;
            // 
            // gbxDetalles
            // 
            this.gbxDetalles.Controls.Add(this.btnQuitar);
            this.gbxDetalles.Controls.Add(this.btnAgregar);
            this.gbxDetalles.Controls.Add(this.rdbProyecto);
            this.gbxDetalles.Controls.Add(this.rdbProducto);
            this.gbxDetalles.Controls.Add(this.txtSubtotal);
            this.gbxDetalles.Controls.Add(this.lblSubtotal);
            this.gbxDetalles.Controls.Add(this.dgvDetalles);
            this.gbxDetalles.Controls.Add(this.txtDetalle);
            this.gbxDetalles.Controls.Add(this.txtIdDetalle);
            this.gbxDetalles.Controls.Add(this.lblDetalle);
            this.gbxDetalles.Controls.Add(this.txtProporcion);
            this.gbxDetalles.Controls.Add(this.lblProporcion);
            this.gbxDetalles.Controls.Add(this.txtValor);
            this.gbxDetalles.Controls.Add(this.lblValor);
            this.gbxDetalles.Location = new System.Drawing.Point(12, 132);
            this.gbxDetalles.Name = "gbxDetalles";
            this.gbxDetalles.Size = new System.Drawing.Size(653, 347);
            this.gbxDetalles.TabIndex = 7;
            this.gbxDetalles.TabStop = false;
            this.gbxDetalles.Text = "Detalle de Factura";
            // 
            // btnQuitar
            // 
            this.btnQuitar.BackColor = System.Drawing.Color.Transparent;
            this.btnQuitar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuitar.FlatAppearance.BorderSize = 0;
            this.btnQuitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitar.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.btnQuitar.Image = global::LPCFacturas.Properties.Resources.Error_X2;
            this.btnQuitar.Location = new System.Drawing.Point(601, 73);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(35, 35);
            this.btnQuitar.TabIndex = 12;
            this.btnQuitar.UseVisualStyleBackColor = false;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.btnAgregar.Image = global::LPCFacturas.Properties.Resources.AddPrueba2;
            this.btnAgregar.Location = new System.Drawing.Point(550, 73);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(35, 35);
            this.btnAgregar.TabIndex = 11;
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // rdbProyecto
            // 
            this.rdbProyecto.AutoSize = true;
            this.rdbProyecto.Location = new System.Drawing.Point(195, 19);
            this.rdbProyecto.Name = "rdbProyecto";
            this.rdbProyecto.Size = new System.Drawing.Size(67, 17);
            this.rdbProyecto.TabIndex = 1;
            this.rdbProyecto.TabStop = true;
            this.rdbProyecto.Text = "Proyecto";
            this.rdbProyecto.UseVisualStyleBackColor = true;
            this.rdbProyecto.CheckedChanged += new System.EventHandler(this.rdbProyecto_CheckedChanged);
            // 
            // rdbProducto
            // 
            this.rdbProducto.AutoSize = true;
            this.rdbProducto.Location = new System.Drawing.Point(128, 19);
            this.rdbProducto.Name = "rdbProducto";
            this.rdbProducto.Size = new System.Drawing.Size(68, 17);
            this.rdbProducto.TabIndex = 0;
            this.rdbProducto.TabStop = true;
            this.rdbProducto.Text = "Producto";
            this.rdbProducto.UseVisualStyleBackColor = true;
            this.rdbProducto.CheckedChanged += new System.EventHandler(this.rdbProducto_CheckedChanged);
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Enabled = false;
            this.txtSubtotal.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtSubtotal.Location = new System.Drawing.Point(469, 78);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.ReadOnly = true;
            this.txtSubtotal.Size = new System.Drawing.Size(75, 31);
            this.txtSubtotal.TabIndex = 10;
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblSubtotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(28)))), ((int)(((byte)(46)))));
            this.lblSubtotal.Location = new System.Drawing.Point(381, 81);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(82, 23);
            this.lblSubtotal.TabIndex = 9;
            this.lblSubtotal.Text = "Subtotal:";
            // 
            // dgvDetalles
            // 
            this.dgvDetalles.AllowUserToAddRows = false;
            this.dgvDetalles.AllowUserToDeleteRows = false;
            this.dgvDetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.descripcion,
            this.cantidad,
            this.precio,
            this.subtotal,
            this.esProducto});
            this.dgvDetalles.Location = new System.Drawing.Point(6, 118);
            this.dgvDetalles.MultiSelect = false;
            this.dgvDetalles.Name = "dgvDetalles";
            this.dgvDetalles.ReadOnly = true;
            this.dgvDetalles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetalles.Size = new System.Drawing.Size(641, 223);
            this.dgvDetalles.TabIndex = 19;
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // descripcion
            // 
            this.descripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descripcion.HeaderText = "Descripción";
            this.descripcion.Name = "descripcion";
            this.descripcion.ReadOnly = true;
            // 
            // cantidad
            // 
            this.cantidad.HeaderText = "Cantidad";
            this.cantidad.Name = "cantidad";
            this.cantidad.ReadOnly = true;
            // 
            // precio
            // 
            this.precio.HeaderText = "Precio";
            this.precio.Name = "precio";
            this.precio.ReadOnly = true;
            // 
            // subtotal
            // 
            this.subtotal.HeaderText = "Subtotal";
            this.subtotal.Name = "subtotal";
            this.subtotal.ReadOnly = true;
            // 
            // esProducto
            // 
            this.esProducto.FalseValue = "false";
            this.esProducto.HeaderText = "EsProducto";
            this.esProducto.Name = "esProducto";
            this.esProducto.ReadOnly = true;
            this.esProducto.TrueValue = "true";
            this.esProducto.Visible = false;
            // 
            // txtDetalle
            // 
            this.txtDetalle.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtDetalle.Location = new System.Drawing.Point(195, 41);
            this.txtDetalle.Name = "txtDetalle";
            this.txtDetalle.ReadOnly = true;
            this.txtDetalle.Size = new System.Drawing.Size(349, 31);
            this.txtDetalle.TabIndex = 4;
            // 
            // txtIdDetalle
            // 
            this.txtIdDetalle.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtIdDetalle.Location = new System.Drawing.Point(128, 41);
            this.txtIdDetalle.Name = "txtIdDetalle";
            this.txtIdDetalle.Size = new System.Drawing.Size(61, 31);
            this.txtIdDetalle.TabIndex = 3;
            this.txtIdDetalle.Leave += new System.EventHandler(this.txtIdDetalle_Leave);
            // 
            // lblDetalle
            // 
            this.lblDetalle.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblDetalle.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblDetalle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(28)))), ((int)(((byte)(46)))));
            this.lblDetalle.Location = new System.Drawing.Point(20, 44);
            this.lblDetalle.Name = "lblDetalle";
            this.lblDetalle.Size = new System.Drawing.Size(102, 23);
            this.lblDetalle.TabIndex = 2;
            this.lblDetalle.Text = "Proyecto:";
            this.lblDetalle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtProporcion
            // 
            this.txtProporcion.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtProporcion.Location = new System.Drawing.Point(307, 78);
            this.txtProporcion.Name = "txtProporcion";
            this.txtProporcion.Size = new System.Drawing.Size(68, 31);
            this.txtProporcion.TabIndex = 8;
            this.txtProporcion.Leave += new System.EventHandler(this.txtProporcion_Leave);
            // 
            // lblProporcion
            // 
            this.lblProporcion.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblProporcion.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblProporcion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(28)))), ((int)(((byte)(46)))));
            this.lblProporcion.Location = new System.Drawing.Point(195, 81);
            this.lblProporcion.Name = "lblProporcion";
            this.lblProporcion.Size = new System.Drawing.Size(106, 23);
            this.lblProporcion.TabIndex = 7;
            this.lblProporcion.Text = "Horas:";
            this.lblProporcion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtValor
            // 
            this.txtValor.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtValor.Location = new System.Drawing.Point(128, 78);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(61, 31);
            this.txtValor.TabIndex = 6;
            this.txtValor.Leave += new System.EventHandler(this.txtValor_Leave);
            // 
            // lblValor
            // 
            this.lblValor.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblValor.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblValor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(28)))), ((int)(((byte)(46)))));
            this.lblValor.Location = new System.Drawing.Point(16, 81);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(106, 23);
            this.lblValor.TabIndex = 5;
            this.lblValor.Text = "Costo/Hora:";
            this.lblValor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtTotal.Location = new System.Drawing.Point(515, 513);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 31);
            this.txtTotal.TabIndex = 8;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblTotal.Location = new System.Drawing.Point(456, 517);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(53, 23);
            this.lblTotal.TabIndex = 9;
            this.lblTotal.Text = "Total:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnEditar);
            this.groupBox1.Controls.Add(this.btnGuardar);
            this.groupBox1.Controls.Add(this.btnNuevo);
            this.groupBox1.Controls.Add(this.btnSalir);
            this.groupBox1.Location = new System.Drawing.Point(12, 485);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(422, 86);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.Transparent;
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.btnEditar.Image = global::LPCFacturas.Properties.Resources.Mono_Pen2;
            this.btnEditar.Location = new System.Drawing.Point(108, 19);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(50, 50);
            this.btnEditar.TabIndex = 1;
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Transparent;
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.btnGuardar.Image = global::LPCFacturas.Properties.Resources.firewallcheck2;
            this.btnGuardar.Location = new System.Drawing.Point(191, 19);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(50, 50);
            this.btnGuardar.TabIndex = 2;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.Transparent;
            this.btnNuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevo.FlatAppearance.BorderSize = 0;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.btnNuevo.Image = global::LPCFacturas.Properties.Resources.AddPrueba2;
            this.btnNuevo.Location = new System.Drawing.Point(27, 19);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(50, 50);
            this.btnNuevo.TabIndex = 0;
            this.btnNuevo.UseVisualStyleBackColor = false;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Transparent;
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.btnSalir.Image = global::LPCFacturas.Properties.Resources.Salir;
            this.btnSalir.Location = new System.Drawing.Point(340, 19);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(50, 50);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(131)))), ((int)(((byte)(156)))));
            this.ClientSize = new System.Drawing.Size(677, 580);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.gbxDetalles);
            this.Controls.Add(this.txtNombreCliente);
            this.Controls.Add(this.txtIdCliente);
            this.Controls.Add(this.lblClientes);
            this.Controls.Add(this.txtNumeroFactura);
            this.Controls.Add(this.lblNumeroFactura);
            this.Controls.Add(this.dtpFechaFactura);
            this.Controls.Add(this.lblFecha);
            this.MaximumSize = new System.Drawing.Size(693, 619);
            this.MinimumSize = new System.Drawing.Size(693, 619);
            this.Name = "frmFactura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.frmFactura_Load);
            this.gbxDetalles.ResumeLayout(false);
            this.gbxDetalles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalles)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.DateTimePicker dtpFechaFactura;
        private System.Windows.Forms.Label lblNumeroFactura;
        private System.Windows.Forms.TextBox txtNumeroFactura;
        private System.Windows.Forms.Label lblClientes;
        private System.Windows.Forms.TextBox txtIdCliente;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.GroupBox gbxDetalles;
        private System.Windows.Forms.TextBox txtProporcion;
        private System.Windows.Forms.Label lblProporcion;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.DataGridView dgvDetalles;
        private System.Windows.Forms.TextBox txtDetalle;
        private System.Windows.Forms.TextBox txtIdDetalle;
        private System.Windows.Forms.Label lblDetalle;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.RadioButton rdbProyecto;
        private System.Windows.Forms.RadioButton rdbProducto;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn subtotal;
        private System.Windows.Forms.DataGridViewCheckBoxColumn esProducto;
    }
}