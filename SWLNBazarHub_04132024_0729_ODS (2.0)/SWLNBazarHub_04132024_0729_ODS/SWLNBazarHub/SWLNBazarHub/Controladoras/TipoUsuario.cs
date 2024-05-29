using SWLNBazarHub.EnlaceDatos;
using SWLNBazarHub.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace SWLNBazarHub.Controladoras
{
    public class TipoUsuario
    {
        private DBBazar2Entities1 _context;

        public TipoUsuario()
        {
            _context = new DBBazar2Entities1();
        }

        public int InsertarTipoUsuario(ETipoUsuario eTipoUsuario)
        {
            var tipoUsuarioId = _context.Database.SqlQuery<int>(
                "EXEC spAgregarTipoUsuario @Nombre, @Estado, @FechaDeEdicion",
                new SqlParameter("@Nombre", eTipoUsuario.Nombre ?? (object)DBNull.Value),
                new SqlParameter("@Estado", eTipoUsuario.Estado ?? (object)DBNull.Value),
                new SqlParameter("@FechaDeEdicion", (object)eTipoUsuario.FechaDeEdicion ?? DBNull.Value)
            ).Single();
            return tipoUsuarioId;
        }

        public void ActualizarTipoUsuario(ETipoUsuario eTipoUsuario)
        {
            _context.Database.ExecuteSqlCommand(
                "EXEC spActualizarTipoUsuario @TipoUsuarioID, @Nombre, @Estado, @FechaDeEdicion",
                new SqlParameter("@TipoUsuarioID", eTipoUsuario.TipoUsuarioID),
                new SqlParameter("@Nombre", eTipoUsuario.Nombre ?? (object)DBNull.Value),
                new SqlParameter("@Estado", eTipoUsuario.Estado ?? (object)DBNull.Value),
                new SqlParameter("@FechaDeEdicion", (object)eTipoUsuario.FechaDeEdicion ?? DBNull.Value)
            );
        }

        public void ActualizarFechaEdicionTipoUsuario(int tipoUsuarioID, DateTime fechaDeEdicion)
        {
            _context.Database.ExecuteSqlCommand(
                "EXEC spActualizarFechaEdicionTipoUsuario @TipoUsuarioID, @FechaDeEdicion",
                new SqlParameter("@TipoUsuarioID", tipoUsuarioID),
                new SqlParameter("@FechaDeEdicion", fechaDeEdicion)
            );
        }

        public void ActualizarEstadoTipoUsuario(int tipoUsuarioID, string estado)
        {
            _context.Database.ExecuteSqlCommand(
                "EXEC spActualizarEstadoTipoUsuario @TipoUsuarioID, @Estado",
                new SqlParameter("@TipoUsuarioID", tipoUsuarioID),
                new SqlParameter("@Estado", estado ?? (object)DBNull.Value)
            );
        }

        public List<ETipoUsuario> ObtenerTodosTipoUsuario()
        {
            var tiposUsuario = _context.Database.SqlQuery<ETipoUsuario>("EXEC spObtenerTodosTipoUsuario").ToList();
            return tiposUsuario;
        }
    }
}