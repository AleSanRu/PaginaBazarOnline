//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SWLNBazarHub.EnlaceDatos
{
    using System;
    using System.Collections.Generic;
    
    public partial class DireccionesEnvio
    {
        public int DireccionID { get; set; }
        public Nullable<int> UsuarioID { get; set; }
        public string Direccion { get; set; }
        public string Ciudad { get; set; }
        public string Pais { get; set; }
        public string CodigoPostal { get; set; }
        public string RegistroEstado { get; set; }
        public Nullable<System.DateTime> FechaDeEdicion { get; set; }
    
        public virtual Usuarios Usuarios { get; set; }
    }
}