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
            this.lblCostoHora = new System.Windows.Forms.Label();
            this.lblCantidadHoras = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtHora = new System.Windows.Forms.TextBox();
            this.lblProyecto = new System.Windows.Forms.Label();
            this.txtIdProyecto = new System.Windows.Forms.TextBox();
            this.txtNombreProyecto = new System.Windows.Forms.TextBox();
            this.gbxDetalles.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblFecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(28)))), ((int)(((byte)(46)))));
            this.lblFecha.Location = new System.Drawing.Point(125, 29);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(61, 23);
            this.lblFecha.TabIndex = 0;
            this.lblFecha.Text = "Fecha:";
            // 
            // dtpFechaFactura
            // 
            this.dtpFechaFactura.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.dtpFechaFactura.Location = new System.Drawing.Point(233, 21);
            this.dtpFechaFactura.Name = "dtpFechaFactura";
            this.dtpFechaFactura.Size = new System.Drawing.Size(318, 31);
            this.dtpFechaFactura.TabIndex = 1;
            // 
            // lblNumeroFactura
            // 
            this.lblNumeroFactura.AutoSize = true;
            this.lblNumeroFactura.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblNumeroFactura.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(28)))), ((int)(((byte)(46)))));
            this.lblNumeroFactura.Location = new System.Drawing.Point(44, 72);
            this.lblNumeroFactura.Name = "lblNumeroFactura";
            this.lblNumeroFactura.Size = new System.Drawing.Size(142, 23);
            this.lblNumeroFactura.TabIndex = 2;
            this.lblNumeroFactura.Text = "Numero Factura:";
            // 
            // txtNumeroFactura
            // 
            this.txtNumeroFactura.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtNumeroFactura.Location = new System.Drawing.Point(233, 64);
            this.txtNumeroFactura.Name = "txtNumeroFactura";
            this.txtNumeroFactura.Size = new System.Drawing.Size(70, 31);
            this.txtNumeroFactura.TabIndex = 3;
            // 
            // lblClientes
            // 
            this.lblClientes.AutoSize = true;
            this.lblClientes.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblClientes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(28)))), ((int)(((byte)(46)))));
            this.lblClientes.Location = new System.Drawing.Point(114, 113);
            this.lblClientes.Name = "lblClientes";
            this.lblClientes.Size = new System.Drawing.Size(72, 23);
            this.lblClientes.TabIndex = 4;
            this.lblClientes.Text = "Cliente:";
            // 
            // txtIdCliente
            // 
            this.txtIdCliente.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtIdCliente.Location = new System.Drawing.Point(233, 110);
            this.txtIdCliente.Name = "txtIdCliente";
            this.txtIdCliente.Size = new System.Drawing.Size(70, 31);
            this.txtIdCliente.TabIndex = 5;
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtNombreCliente.Location = new System.Drawing.Point(331, 110);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(220, 31);
            this.txtNombreCliente.TabIndex = 6;
            // 
            // gbxDetalles
            // 
            this.gbxDetalles.Controls.Add(this.txtHora);
            this.gbxDetalles.Controls.Add(this.lblCantidadHoras);
            this.gbxDetalles.Controls.Add(this.textBox1);
            this.gbxDetalles.Controls.Add(this.lblCostoHora);
            this.gbxDetalles.Controls.Add(this.txtNombreProyecto);
            this.gbxDetalles.Controls.Add(this.txtIdProyecto);
            this.gbxDetalles.Controls.Add(this.lblProyecto);
            this.gbxDetalles.Location = new System.Drawing.Point(21, 159);
            this.gbxDetalles.Name = "gbxDetalles";
            this.gbxDetalles.Size = new System.Drawing.Size(769, 401);
            this.gbxDetalles.TabIndex = 7;
            this.gbxDetalles.TabStop = false;
            // 
            // lblCostoHora
            // 
            this.lblCostoHora.AutoSize = true;
            this.lblCostoHora.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblCostoHora.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(28)))), ((int)(((byte)(46)))));
            this.lblCostoHora.Location = new System.Drawing.Point(57, 64);
            this.lblCostoHora.Name = "lblCostoHora";
            this.lblCostoHora.Size = new System.Drawing.Size(106, 23);
            this.lblCostoHora.TabIndex = 12;
            this.lblCostoHora.Text = "Costo/Hora:";
            // 
            // lblCantidadHoras
            // 
            this.lblCantidadHoras.AutoSize = true;
            this.lblCantidadHoras.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblCantidadHoras.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(28)))), ((int)(((byte)(46)))));
            this.lblCantidadHoras.Location = new System.Drawing.Point(306, 64);
            this.lblCantidadHoras.Name = "lblCantidadHoras";
            this.lblCantidadHoras.Size = new System.Drawing.Size(61, 23);
            this.lblCantidadHoras.TabIndex = 14;
            this.lblCantidadHoras.Text = "Horas:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.textBox1.Location = new System.Drawing.Point(212, 61);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(70, 31);
            this.textBox1.TabIndex = 13;
            // 
            // txtHora
            // 
            this.txtHora.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtHora.Location = new System.Drawing.Point(388, 61);
            this.txtHora.Name = "txtHora";
            this.txtHora.Size = new System.Drawing.Size(142, 31);
            this.txtHora.TabIndex = 15;
            // 
            // lblProyecto
            // 
            this.lblProyecto.AutoSize = true;
            this.lblProyecto.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblProyecto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(28)))), ((int)(((byte)(46)))));
            this.lblProyecto.Location = new System.Drawing.Point(77, 27);
            this.lblProyecto.Name = "lblProyecto";
            this.lblProyecto.Size = new System.Drawing.Size(86, 23);
            this.lblProyecto.TabIndex = 9;
            this.lblProyecto.Text = "Proyecto:";
            // 
            // txtIdProyecto
            // 
            this.txtIdProyecto.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtIdProyecto.Location = new System.Drawing.Point(212, 19);
            this.txtIdProyecto.Name = "txtIdProyecto";
            this.txtIdProyecto.Size = new System.Drawing.Size(70, 31);
            this.txtIdProyecto.TabIndex = 10;
            // 
            // txtNombreProyecto
            // 
            this.txtNombreProyecto.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtNombreProyecto.Location = new System.Drawing.Point(310, 19);
            this.txtNombreProyecto.Name = "txtNombreProyecto";
            this.txtNombreProyecto.Size = new System.Drawing.Size(220, 31);
            this.txtNombreProyecto.TabIndex = 11;
            // 
            // frmFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(131)))), ((int)(((byte)(156)))));
            this.ClientSize = new System.Drawing.Size(821, 633);
            this.Controls.Add(this.gbxDetalles);
            this.Controls.Add(this.txtNombreCliente);
            this.Controls.Add(this.txtIdCliente);
            this.Controls.Add(this.lblClientes);
            this.Controls.Add(this.txtNumeroFactura);
            this.Controls.Add(this.lblNumeroFactura);
            this.Controls.Add(this.dtpFechaFactura);
            this.Controls.Add(this.lblFecha);
            this.Name = "frmFactura";
            this.Text = "frmFactura";
            this.gbxDetalles.ResumeLayout(false);
            this.gbxDetalles.PerformLayout();
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
        private System.Windows.Forms.TextBox txtHora;
        private System.Windows.Forms.Label lblCantidadHoras;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblCostoHora;
        private System.Windows.Forms.TextBox txtNombreProyecto;
        private System.Windows.Forms.TextBox txtIdProyecto;
        private System.Windows.Forms.Label lblProyecto;
    }
}