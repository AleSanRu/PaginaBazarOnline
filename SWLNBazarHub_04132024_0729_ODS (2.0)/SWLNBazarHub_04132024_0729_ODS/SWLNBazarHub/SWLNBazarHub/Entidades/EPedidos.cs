using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace SWLNBazarHub.Entidades
{
    [DataContract]
    public class EPedidos
    {
        [DataMember]
        public int PedidoID { get; set; }

        [DataMember]
        public int UsuarioID { get; set; }

        [DataMember]
        public DateTime FechaPedido { get; set; }

        [DataMember]
        public string Estado { get; set; }

        [DataMember]
        public string DireccionEnvio { get; set; }

        [DataMember]
        public DateTime FechaDeEdicion { get; set; }

        public EPedidos()
        {
            PedidoID = 0;
            UsuarioID = 0;
            FechaPedido = DateTime.Now;
            Estado = string.Empty;
            DireccionEnvio = string.Empty;
            FechaDeEdicion = DateTime.Now;
        }
    }
}