using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LPCFacturas.Entities
{
    class Factura
    {
        private int id_factura;
        private int numero_factura;
        private Cliente cliente;
        private string fecha;
        private Usuario usuario_creador;
        private IList<DetalleFactura> detalles;

        public int Id_factura { get => id_factura; set => id_factura = value; }
        public int Numero_factura { get => numero_factura; set => numero_factura = value; }
        public string Fecha { get => fecha; set => fecha = value; }
        public Usuario Usuario_creador { get => usuario_creador; set => usuario_creador = value; }
        public Cliente Cliente { get => cliente; set => cliente = value; }
        public IList<DetalleFactura> Detalles { get => detalles; set => detalles = value; }
    }
}
