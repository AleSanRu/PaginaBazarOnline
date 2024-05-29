using SWLNBazarHub.EnlaceDatos;
using SWLNBazarHub.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;


namespace SWLNBazarHub.Controladoras
{
    public class CProvedorees
    {
        private DBBazar2Entities1 _context;

        public CProvedorees()
        {
            _context = new DBBazar2Entities1();
        }

        public void AgregarProveedor(EProveedores eProveedor)
        {
            _context.Database.ExecuteSqlCommand(
                "EXEC spAgregarProveedor @NombreEmpresa, @Contacto, @Email, @Estado, @FechaDeEdicion",
                new SqlParameter("@NombreEmpresa", eProveedor.NombreEmpresa ?? (object)DBNull.Value),
                new SqlParameter("@Contacto", eProveedor.Contacto ?? (object)DBNull.Value),
                new SqlParameter("@Email", eProveedor.Email ?? (object)DBNull.Value),
                new SqlParameter("@Estado", eProveedor.Estado ?? (object)DBNull.Value),
                new SqlParameter("@FechaDeEdicion", (object)eProveedor.FechaDeEdicion ?? DBNull.Value)
            );
        }

        public void ActualizarProveedor(EProveedores eProveedor)
        {
            _context.Database.ExecuteSqlCommand(
                "EXEC spActualizarProveedor @ProveedorID, @Contacto, @Email, @Estado, @FechaDeEdicion",
                new SqlParameter("@ProveedorID", eProveedor.ProveedorID),
                new SqlParameter("@Contacto", eProveedor.Contacto ?? (object)DBNull.Value),
                new SqlParameter("@Email", eProveedor.Email ?? (object)DBNull.Value),
                new SqlParameter("@Estado", eProveedor.Estado ?? (object)DBNull.Value),
                new SqlParameter("@FechaDeEdicion", (object)eProveedor.FechaDeEdicion ?? DBNull.Value)
            );
        }

        public void ActualizarFechaEdicionProveedor(int proveedorID, DateTime fechaDeEdicion)
        {
            _context.Database.ExecuteSqlCommand(
                "EXEC spActualizarFechaEdicionProveedor @ProveedorID, @FechaDeEdicion",
                new SqlParameter("@ProveedorID", proveedorID),
                new SqlParameter("@FechaDeEdicion", fechaDeEdicion)
            );
        }

        public void ActualizarEstadoProveedor(int proveedorID, string estado)
        {
            _context.Database.ExecuteSqlCommand(
                "EXEC spActualizarEstadoProveedor @ProveedorID, @Estado",
                new SqlParameter("@ProveedorID", proveedorID),
                new SqlParameter("@Estado", estado ?? (object)DBNull.Value)
            );
        }

        public List<EProveedores> ObtenerTodosProveedores()
        {
            var proveedores = _context.Database.SqlQuery<EProveedores>(
                "EXEC spObtenerTodosProveedores"
            ).ToList();

            return proveedores;
        }
    }
}