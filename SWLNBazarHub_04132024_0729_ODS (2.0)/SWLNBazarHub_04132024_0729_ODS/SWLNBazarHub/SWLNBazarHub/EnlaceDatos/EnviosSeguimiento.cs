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
    
    public partial class EnviosSeguimiento
    {
        public int EnvioID { get; set; }
        public Nullable<int> PedidoID { get; set; }
        public string EstadoEnvio { get; set; }
        public Nullable<System.DateTime> Fecha { get; set; }
    
        public virtual Pedidos Pedidos { get; set; }
    }
}
