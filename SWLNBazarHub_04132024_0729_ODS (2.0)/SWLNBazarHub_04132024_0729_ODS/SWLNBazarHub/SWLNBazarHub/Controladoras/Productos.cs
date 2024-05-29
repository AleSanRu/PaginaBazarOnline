using SWLNBazarHub.EnlaceDatos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using SWLNBazarHub.Entidades;

namespace SWLNBazarHub.Controladoras
{
    public class Productos
    {
        private DBBazar2Entities1 _context;

        public Productos()
        {
            _context = new DBBazar2Entities1();
        }

        public void InsertarProducto(EProductos eProducto)
        {
            _context.Database.ExecuteSqlCommand(
                "EXEC spAgregarProducto @Nombre, @Descripcion, @Precio, @Stock, @CategoriaID, @ProveedorID, @Estado, @FechaDeEdicion",
                new SqlParameter("@Nombre", eProducto.Nombre ?? (object)DBNull.Value),
                new SqlParameter("@Descripcion", eProducto.Descripcion ?? (object)DBNull.Value),
                new SqlParameter("@Precio", eProducto.Precio),
                new SqlParameter("@Stock", eProducto.Stock),
                new SqlParameter("@CategoriaID", eProducto.CategoriaID),
                new SqlParameter("@ProveedorID", eProducto.ProveedorID),
                new SqlParameter("@Estado", eProducto.Estado ?? (object)DBNull.Value),
                new SqlParameter("@FechaDeEdicion", (object)eProducto.FechaDeEdicion ?? DBNull.Value)
            );
        }

        public void ActualizarProducto(EProductos eProducto)
        {
            _context.Database.ExecuteSqlCommand(
                "EXEC spActualizarProducto @ProductoID, @Nombre, @Descripcion, @Precio, @Stock, @Estado, @FechaDeEdicion",
                new SqlParameter("@ProductoID", eProducto.ProductoID),
                new SqlParameter("@Nombre", eProducto.Nombre ?? (object)DBNull.Value),
                new SqlParameter("@Descripcion", eProducto.Descripcion ?? (object)DBNull.Value),
                new SqlParameter("@Precio", eProducto.Precio),
                new SqlParameter("@Stock", eProducto.Stock),
                new SqlParameter("@Estado", eProducto.Estado ?? (object)DBNull.Value),
                new SqlParameter("@FechaDeEdicion", (object)eProducto.FechaDeEdicion ?? DBNull.Value)
            );
        }

        public void ActualizarFechaEdicionProducto(int productoID, DateTime fechaDeEdicion)
        {
            _context.Database.ExecuteSqlCommand(
                "EXEC spActualizarFechaEdicionProducto @ProductoID, @FechaDeEdicion",
                new SqlParameter("@ProductoID", productoID),
                new SqlParameter("@FechaDeEdicion", fechaDeEdicion)
            );
        }

        public void ActualizarEstadoProducto(int productoID, string estado)
        {
            _context.Database.ExecuteSqlCommand(
                "EXEC spActualizarEstadoProducto @ProductoID, @Estado",
                new SqlParameter("@ProductoID", productoID),
                new SqlParameter("@Estado", estado ?? (object)DBNull.Value)
            );
        }

        public List<EProductos> ObtenerTodosProductos()
        {
            var productos = _context.Database.SqlQuery<EProductos>(
                "EXEC spObtenerTodosProductos"
            ).ToList();

            return productos;
        }
    }
}