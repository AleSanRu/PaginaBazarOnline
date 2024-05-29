using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace SWLNBazarHub.Entidades
{
    [DataContract]
    public class EUsuario
    {
        [DataMember]
        public int UsuarioID { get; set; }

        [DataMember]
        public string Nombre { get; set; }

        [DataMember]
        public string Email { get; set; }

        [DataMember]
        public string Contraseña { get; set; }

        [DataMember]
        public int TipoUsuarioID { get; set; }

        [DataMember]
        public string Estado { get; set; }

        [DataMember]
        public DateTime FechaDeEdicion { get; set; }

        public EUsuario()
        {
            UsuarioID = 0;
            Nombre = string.Empty;
            Email = string.Empty;
            Contraseña = string.Empty;
            TipoUsuarioID = 0;
            Estado = string.Empty;
            FechaDeEdicion = DateTime.Now;
        }
    }
}