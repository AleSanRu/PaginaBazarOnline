using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace SWLNBazarHub.Entidades
{
    [DataContract]
    public class ETipoUsuario
    {
        [DataMember]
        public int TipoUsuarioID { get; set; }

        [DataMember]
        public string Nombre { get; set; }

        [DataMember]
        public string Estado { get; set; }

        [DataMember]
        public DateTime FechaDeEdicion { get; set; }

        public ETipoUsuario()
        {
            TipoUsuarioID = 0;
            Nombre = string.Empty;
            Estado = string.Empty;
            FechaDeEdicion = DateTime.Now;
        }
    }
}