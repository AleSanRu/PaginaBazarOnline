using SWLNBazarHub.EnlaceDatos;
using SWLNBazarHub.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace SWLNBazarHub.Controladoras
{
    public class CUsuario
    {
        private DBBazar2Entities1 _context;

        public CUsuario()
        {
            _context = new DBBazar2Entities1();
        }

        public void InsertarUsuario(EUsuario eUsuario)
        {
            _context.Database.ExecuteSqlCommand(
                "EXEC spAgregarUsuario @Nombre, @Email, @Contraseña, @TipoUsuarioID, @Estado, @FechaDeEdicion",
                new SqlParameter("@Nombre", eUsuario.Nombre ?? (object)DBNull.Value),
                new SqlParameter("@Email", eUsuario.Email ?? (object)DBNull.Value),
                new SqlParameter("@Contraseña", eUsuario.Contraseña ?? (object)DBNull.Value),
                new SqlParameter("@TipoUsuarioID", eUsuario.TipoUsuarioID),
                new SqlParameter("@Estado", eUsuario.Estado ?? (object)DBNull.Value),
                new SqlParameter("@FechaDeEdicion", (object)eUsuario.FechaDeEdicion ?? DBNull.Value)
            );
        }

        public void ActualizarUsuario(EUsuario eUsuario)
        {
            _context.Database.ExecuteSqlCommand(
                "EXEC spActualizarUsuario @UsuarioID, @Nombre, @Email, @Contraseña, @Estado, @FechaDeEdicion",
                new SqlParameter("@UsuarioID", eUsuario.UsuarioID),
                new SqlParameter("@Nombre", eUsuario.Nombre ?? (object)DBNull.Value),
                new SqlParameter("@Email", eUsuario.Email ?? (object)DBNull.Value),
                new SqlParameter("@Contraseña", eUsuario.Contraseña ?? (object)DBNull.Value),
                new SqlParameter("@Estado", eUsuario.Estado ?? (object)DBNull.Value),
                new SqlParameter("@FechaDeEdicion", (object)eUsuario.FechaDeEdicion ?? DBNull.Value)
            );
        }

        public void ActualizarFechaEdicionUsuario(int usuarioID, DateTime fechaDeEdicion)
        {
            _context.Database.ExecuteSqlCommand(
                "EXEC spActualizarFechaEdicionUsuario @UsuarioID, @FechaDeEdicion",
                new SqlParameter("@UsuarioID", usuarioID),
                new SqlParameter("@FechaDeEdicion", fechaDeEdicion)
            );
        }

        public void ActualizarEstadoUsuario(int usuarioID, string estado)
        {
            _context.Database.ExecuteSqlCommand(
                "EXEC spActualizarEstadoUsuario @UsuarioID, @Estado",
                new SqlParameter("@UsuarioID", usuarioID),
                new SqlParameter("@Estado", estado ?? (object)DBNull.Value)
            );
        }

        public List<EUsuario> ObtenerTodosUsuarios()
        {
            var usuarios = _context.Database.SqlQuery<EUsuario>(
                "EXEC spObtenerTodosUsuarios"
            ).ToList();

            return usuarios;
        }
    }
}