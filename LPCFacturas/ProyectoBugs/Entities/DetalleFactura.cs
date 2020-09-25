using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LPCFacturas.Entities
{
    class DetalleFactura
    {
        private int id_detalle_factura;
        private Factura factura;
        private int numero_orden;
        private Producto producto;
        private Proyecto proyecto;
        private int precio;

        public int Id_detalle_factura { get => id_detalle_factura; set => id_detalle_factura = value; }
        public int Numero_orden { get => numero_orden; set => numero_orden = value; }
        public int Precio { get => precio; set => precio = value; }
        internal Factura Factura { get => factura; set => factura = value; }
        internal Producto Producto { get => producto; set => producto = value; }
        internal Proyecto Proyecto { get => proyecto; set => proyecto = value; }
    }
}
