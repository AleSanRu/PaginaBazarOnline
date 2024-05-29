using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace SWLNBazarHub.Entidades
{
    [DataContract]
    public class EProveedores
    {
        [DataMember]
        public int ProveedorID { get; set; }

        [DataMember]
        public string NombreEmpresa { get; set; }

        [DataMember]
        public string Contacto { get; set; }

        [DataMember]
        public string Email { get; set; }

        [DataMember]
        public string Estado { get; set; }

        [DataMember]
        public DateTime FechaDeEdicion { get; set; }

        public EProveedores()
        {
            ProveedorID = 0;
            NombreEmpresa = string.Empty;
            Contacto = string.Empty;
            Email = string.Empty;
            Estado = string.Empty;
            FechaDeEdicion = DateTime.Now;
        }
    }
}