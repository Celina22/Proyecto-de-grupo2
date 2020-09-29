using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using LPCFacturas.Entities;
using System.Data;


namespace LPCFacturas.DataAccessLayer
{
    class FacturaDao
    {
        ClienteDao oCliente = new ClienteDao();
        UsuarioDao oUsuario = new UsuarioDao();
        DetalleFacturaDao oDetalle = new DetalleFacturaDao();
        public IList<Factura> GetAll()
        {
            List<Factura> listadoFactura = new List<Factura>();

            var strSql = " SELECT id_factura, numero_factura, id_cliente, fecha, id_usuario_creador " +
                         " FROM Facturas WHERE p.borrado=0";

            var resultadoConsulta = DataManager.GetInstance().ConsultaSQL(strSql);

            foreach (DataRow row in resultadoConsulta.Rows)
            {
                listadoFactura.Add(MappingFactura(row));
            }

            return listadoFactura;
        }

        private Factura MappingFactura(DataRow row)
        {
            Factura oFactura = new Factura
            {
                Id_factura = Convert.ToInt32(row["id_factura"].ToString()),
                Detalles = oDetalle.GetAll(row["id_factura"].ToString()),
                Numero_factura = Convert.ToInt32(row["numero_factura"].ToString()),
                Cliente = oCliente.GetCliente(row["id_cliente"].ToString()),
                Fecha = row["fecha"].ToString(),
                Usuario_creador = oUsuario.GetUserId(row["id_usuario_creador"].ToString()),
            };

            return oFactura;
        }
    }
}
