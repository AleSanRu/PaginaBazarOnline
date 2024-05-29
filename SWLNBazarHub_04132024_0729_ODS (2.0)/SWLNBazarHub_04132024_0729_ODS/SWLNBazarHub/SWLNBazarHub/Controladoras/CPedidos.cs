using SWLNBazarHub.EnlaceDatos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using SWLNBazarHub.Entidades;

namespace SWLNBazarHub.Controladoras
{
    public class CPedidos
    {
        private DBBazar2Entities1 _context;

        public CPedidos()
        {
            _context = new DBBazar2Entities1();
        }

        public void AgregarPedido(EPedidos ePedido)
        {
            _context.Database.ExecuteSqlCommand(
                "EXEC spAgregarPedido @UsuarioID, @FechaPedido, @Estado, @DireccionEnvio, @FechaDeEdicion",
                new SqlParameter("@UsuarioID", ePedido.UsuarioID),
                new SqlParameter("@FechaPedido", ePedido.FechaPedido),
                new SqlParameter("@Estado", ePedido.Estado ?? (object)DBNull.Value),
                new SqlParameter("@DireccionEnvio", ePedido.DireccionEnvio ?? (object)DBNull.Value),
                new SqlParameter("@FechaDeEdicion", (object)ePedido.FechaDeEdicion ?? DBNull.Value)
            );
        }

        public void ActualizarPedido(EPedidos ePedido)
        {
            _context.Database.ExecuteSqlCommand(
                "EXEC spActualizarPedido @PedidoID, @Estado, @DireccionEnvio, @FechaDeEdicion",
                new SqlParameter("@PedidoID", ePedido.PedidoID),
                new SqlParameter("@Estado", ePedido.Estado ?? (object)DBNull.Value),
                new SqlParameter("@DireccionEnvio", ePedido.DireccionEnvio ?? (object)DBNull.Value),
                new SqlParameter("@FechaDeEdicion", (object)ePedido.FechaDeEdicion ?? DBNull.Value)
            );
        }

        public void ActualizarFechaEdicionPedido(int pedidoID, DateTime fechaDeEdicion)
        {
            _context.Database.ExecuteSqlCommand(
                "EXEC spActualizarFechaEdicionPedido @PedidoID, @FechaDeEdicion",
                new SqlParameter("@PedidoID", pedidoID),
                new SqlParameter("@FechaDeEdicion", fechaDeEdicion)
            );
        }

        public void ActualizarEstadoPedido(int pedidoID, string estado)
        {
            _context.Database.ExecuteSqlCommand(
                "EXEC spActualizarEstadoPedido @PedidoID, @Estado",
                new SqlParameter("@PedidoID", pedidoID),
                new SqlParameter("@Estado", estado ?? (object)DBNull.Value)
            );
        }

        public List<EPedidos> ObtenerTodosPedidos()
        {
            var pedidos = _context.Database.SqlQuery<EPedidos>(
                "EXEC spObtenerTodosPedidos"
            ).ToList();

            return pedidos;
        }
    }
}