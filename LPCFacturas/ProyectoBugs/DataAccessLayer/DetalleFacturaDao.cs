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
    class DetalleFacturaDao
    {
        ProductoDao oProducto = new ProductoDao();
        ProyectoDao oProyecto = new ProyectoDao();
        public IList<DetalleFactura> GetAll()
        {
            List<DetalleFactura> listadoDetalleFactura = new List<DetalleFactura>();

            var strSql = " SELECT id_detalle_factura, numero_orden, id_producto, id_proyecto, precio " +
                         " FROM FacturasDetalle WHERE p.borrado=0";

            var resultadoConsulta = DataManager.GetInstance().ConsultaSQL(strSql);

            foreach (DataRow row in resultadoConsulta.Rows)
            {
                listadoDetalleFactura.Add(MappingDetalleFactura(row));
            }

            return listadoDetalleFactura;
        }

        public IList<DetalleFactura> GetAll(string idFactura)
        {
            List<DetalleFactura> listadoDetalleFactura = new List<DetalleFactura>();

            var strSql = " SELECT id_detalle_factura, numero_orden, id_producto, id_proyecto, precio " +
                         " FROM FacturasDetalle WHERE p.borrado=0 AND id_factura = " + idFactura;

            var resultadoConsulta = DataManager.GetInstance().ConsultaSQL(strSql);

            foreach (DataRow row in resultadoConsulta.Rows)
            {
                listadoDetalleFactura.Add(MappingDetalleFactura(row));
            }

            return listadoDetalleFactura;
        }

        private DetalleFactura MappingDetalleFactura(DataRow row)
        {
            DetalleFactura oDetalleFactura;
            if (row["id_producto"].ToString() != "NULL")
            {
                oDetalleFactura = new DetalleFactura
                {
                    Id_detalle_factura = Convert.ToInt32(row["id_detalle_factura"].ToString()),
                    Numero_orden = Convert.ToInt32(row["numero_orden"].ToString()),
                    Producto = oProducto.GetProducto(row["id_producto"].ToString()),
                    //Proyecto = oProyecto.GetProyecto(row["id_cliente"].ToString()),
                    Precio = Convert.ToInt32(row["precio"].ToString())
                };
            }
            else
            {
                oDetalleFactura = new DetalleFactura
                {
                    Id_detalle_factura = Convert.ToInt32(row["id_detalle_factura"].ToString()),
                    Numero_orden = Convert.ToInt32(row["numero_orden"].ToString()),
                    //Producto = oProducto.GetProducto(row["id_cliente"].ToString()),
                    Proyecto = oProyecto.GetProyecto(row["id_producto"].ToString()),
                    Precio = Convert.ToInt32(row["precio"].ToString())
                };
            }

            return oDetalleFactura;
        }
    }
}
