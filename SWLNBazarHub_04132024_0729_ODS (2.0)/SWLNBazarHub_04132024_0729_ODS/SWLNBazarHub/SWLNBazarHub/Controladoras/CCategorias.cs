using SWLNBazarHub.EnlaceDatos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using SWLNBazarHub.Entidades;

namespace SWLNBazarHub.Controladoras
{
    public class CCategorias
    {
        private DBBazar2Entities1 _context;

        public CCategorias()
        {
            _context = new DBBazar2Entities1();
        }

        public void AgregarCategoria(ECategorias eCategoria)
        {
            _context.Database.ExecuteSqlCommand(
                "EXEC spAgregarCategoria @Nombre, @Estado, @FechaDeEdicion",
                new SqlParameter("@Nombre", eCategoria.Nombre ?? (object)DBNull.Value),
                new SqlParameter("@Estado", eCategoria.Estado ?? (object)DBNull.Value),
                new SqlParameter("@FechaDeEdicion", (object)eCategoria.FechaDeEdicion ?? DBNull.Value)
            );
        }

        public void ActualizarCategoria(ECategorias eCategoria)
        {
            _context.Database.ExecuteSqlCommand(
                "EXEC spActualizarCategoria @CategoriaID, @Nombre, @Estado, @FechaDeEdicion",
                new SqlParameter("@CategoriaID", eCategoria.CategoriaID),
                new SqlParameter("@Nombre", eCategoria.Nombre ?? (object)DBNull.Value),
                new SqlParameter("@Estado", eCategoria.Estado ?? (object)DBNull.Value),
                new SqlParameter("@FechaDeEdicion", (object)eCategoria.FechaDeEdicion ?? DBNull.Value)
            );
        }

        public void ActualizarFechaEdicionCategoria(int categoriaID, DateTime fechaDeEdicion)
        {
            _context.Database.ExecuteSqlCommand(
                "EXEC spActualizarFechaEdicionCategoria @CategoriaID, @FechaDeEdicion",
                new SqlParameter("@CategoriaID", categoriaID),
                new SqlParameter("@FechaDeEdicion", fechaDeEdicion)
            );
        }

        public void ActualizarEstadoCategoria(int categoriaID, string estado)
        {
            _context.Database.ExecuteSqlCommand(
                "EXEC spActualizarEstadoCategoria @CategoriaID, @Estado",
                new SqlParameter("@CategoriaID", categoriaID),
                new SqlParameter("@Estado", estado ?? (object)DBNull.Value)
            );
        }

        public List<ECategorias> ObtenerTodasCategorias()
        {
            var categorias = _context.Database.SqlQuery<ECategorias>(
                "EXEC spObtenerTodasCategorias"
            ).ToList();

            return categorias;
        }
    }
}