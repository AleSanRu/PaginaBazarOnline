using SWLNBazarHub.EnlaceDatos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using SWLNBazarHub.Entidades;

namespace SWLNBazarHub.Controladoras
{
    public class CDireccionesEnvio
    {
        private DBBazar2Entities1 _context;

        public CDireccionesEnvio()
        {
            _context = new DBBazar2Entities1();
        }

        public void InsertarDireccionEnvio(EDireccionesEnvio eDireccionEnvio)
        {
            _context.Database.ExecuteSqlCommand(
                "EXEC spAgregarDireccionEnvio @UsuarioID, @Direccion, @Ciudad, @Pais, @CodigoPostal, @RegistroEstado, @FechaDeEdicion",
                new SqlParameter("@UsuarioID", eDireccionEnvio.UsuarioID),
                new SqlParameter("@Direccion", eDireccionEnvio.Direccion ?? (object)DBNull.Value),
                new SqlParameter("@Ciudad", eDireccionEnvio.Ciudad ?? (object)DBNull.Value),
                new SqlParameter("@Pais", eDireccionEnvio.Pais ?? (object)DBNull.Value),
                new SqlParameter("@CodigoPostal", eDireccionEnvio.CodigoPostal ?? (object)DBNull.Value),
                new SqlParameter("@RegistroEstado", eDireccionEnvio.RegistroEstado ?? (object)DBNull.Value),
                new SqlParameter("@FechaDeEdicion", (object)eDireccionEnvio.FechaDeEdicion ?? DBNull.Value)
            );
        }

        public void ActualizarDireccionEnvio(EDireccionesEnvio eDireccionEnvio)
        {
            _context.Database.ExecuteSqlCommand(
                "EXEC spActualizarDireccionEnvio @DireccionID, @Direccion, @Ciudad, @Pais, @CodigoPostal, @RegistroEstado, @FechaDeEdicion",
                new SqlParameter("@DireccionID", eDireccionEnvio.DireccionID),
                new SqlParameter("@Direccion", eDireccionEnvio.Direccion ?? (object)DBNull.Value),
                new SqlParameter("@Ciudad", eDireccionEnvio.Ciudad ?? (object)DBNull.Value),
                new SqlParameter("@Pais", eDireccionEnvio.Pais ?? (object)DBNull.Value),
                new SqlParameter("@CodigoPostal", eDireccionEnvio.CodigoPostal ?? (object)DBNull.Value),
                new SqlParameter("@RegistroEstado", eDireccionEnvio.RegistroEstado ?? (object)DBNull.Value),
                new SqlParameter("@FechaDeEdicion", (object)eDireccionEnvio.FechaDeEdicion ?? DBNull.Value)
            );
        }

        public void ActualizarFechaEdicionDireccionEnvio(int direccionID, DateTime fechaDeEdicion)
        {
            _context.Database.ExecuteSqlCommand(
                "EXEC spActualizarFechaEdicionDireccionEnvio @DireccionID, @FechaDeEdicion",
                new SqlParameter("@DireccionID", direccionID),
                new SqlParameter("@FechaDeEdicion", fechaDeEdicion)
            );
        }

        public void ActualizarEstadoDireccionEnvio(int direccionID, string registroEstado)
        {
            _context.Database.ExecuteSqlCommand(
                "EXEC spActualizarEstadoDireccionEnvio @DireccionID, @RegistroEstado",
                new SqlParameter("@DireccionID", direccionID),
                new SqlParameter("@RegistroEstado", registroEstado ?? (object)DBNull.Value)
            );
        }

        public List<EDireccionesEnvio> ObtenerTodasDireccionesEnvio()
        {
            var direccionesEnvio = _context.Database.SqlQuery<EDireccionesEnvio>(
                "EXEC spObtenerTodasDireccionesEnvio"
            ).ToList();

            return direccionesEnvio;
        }
    }
}