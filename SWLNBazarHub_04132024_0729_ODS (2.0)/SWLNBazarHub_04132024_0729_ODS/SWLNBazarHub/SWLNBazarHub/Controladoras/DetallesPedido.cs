using SWLNBazarHub.EnlaceDatos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using SWLNBazarHub.Entidades;

namespace SWLNBazarHub.Controladoras
{
    public class DetallesPedido
    {
        private DBBazar2Entities1 _context;

        public DetallesPedido()
        {
            _context = new DBBazar2Entities1();
        }

        public void InsertarDetallePedido(EDetallesPedido eDetallePedido)
        {
            _context.Database.ExecuteSqlCommand(
                "EXEC spAgregarDetallePedido @PedidoID, @ProductoID, @Cantidad, @PrecioUnitario, @Descuento, @Estado, @FechaDeEdicion",
                new SqlParameter("@PedidoID", eDetallePedido.PedidoID),
                new SqlParameter("@ProductoID", eDetallePedido.ProductoID),
                new SqlParameter("@Cantidad", eDetallePedido.Cantidad),
                new SqlParameter("@PrecioUnitario", eDetallePedido.PrecioUnitario),
                new SqlParameter("@Descuento", eDetallePedido.Descuento),
                new SqlParameter("@Estado", eDetallePedido.Estado ?? (object)DBNull.Value),
                new SqlParameter("@FechaDeEdicion", (object)eDetallePedido.FechaDeEdicion ?? DBNull.Value)
            );
        }

        public void ActualizarDetallePedido(EDetallesPedido eDetallePedido)
        {
            _context.Database.ExecuteSqlCommand(
                "EXEC spActualizarDetallePedido @DetalleID, @Cantidad, @PrecioUnitario, @Descuento, @Estado, @FechaDeEdicion",
                new SqlParameter("@DetalleID", eDetallePedido.DetalleID),
                new SqlParameter("@Cantidad", eDetallePedido.Cantidad),
                new SqlParameter("@PrecioUnitario", eDetallePedido.PrecioUnitario),
                new SqlParameter("@Descuento", eDetallePedido.Descuento),
                new SqlParameter("@Estado", eDetallePedido.Estado ?? (object)DBNull.Value),
                new SqlParameter("@FechaDeEdicion", (object)eDetallePedido.FechaDeEdicion ?? DBNull.Value)
            );
        }

        public void ActualizarFechaEdicionDetallePedido(int detalleID, DateTime fechaDeEdicion)
        {
            _context.Database.ExecuteSqlCommand(
                "EXEC spActualizarFechaEdicionDetallePedido @DetalleID, @FechaDeEdicion",
                new SqlParameter("@DetalleID", detalleID),
                new SqlParameter("@FechaDeEdicion", fechaDeEdicion)
            );
        }

        public void ActualizarEstadoDetallePedido(int detalleID, string estado)
        {
            _context.Database.ExecuteSqlCommand(
                "EXEC spActualizarEstadoDetallePedido @DetalleID, @Estado",
                new SqlParameter("@DetalleID", detalleID),
                new SqlParameter("@Estado", estado ?? (object)DBNull.Value)
            );
        }

        public List<EDetallesPedido> ObtenerTodosDetallesPedidos()
        {
            var detallesPedidos = _context.Database.SqlQuery<EDetallesPedido>(
                "EXEC spObtenerTodosDetallesPedidos"
            ).ToList();

            return detallesPedidos;
        }
    }
}