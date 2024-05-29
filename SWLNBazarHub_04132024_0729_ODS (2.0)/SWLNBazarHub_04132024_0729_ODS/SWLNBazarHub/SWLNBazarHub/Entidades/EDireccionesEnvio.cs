using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace SWLNBazarHub.Entidades
{
    [DataContract]
    public class EDireccionesEnvio
    {
        [DataMember]
        public int DireccionID { get; set; }

        [DataMember]
        public int UsuarioID { get; set; }

        [DataMember]
        public string Direccion { get; set; }

        [DataMember]
        public string Ciudad { get; set; }

        [DataMember]
        public string Pais { get; set; }

        [DataMember]
        public string CodigoPostal { get; set; }

        [DataMember]
        public string RegistroEstado { get; set; }

        [DataMember]
        public DateTime FechaDeEdicion { get; set; }

        public EDireccionesEnvio()
        {
            DireccionID = 0;
            UsuarioID = 0;
            Direccion = string.Empty;
            Ciudad = string.Empty;
            Pais = string.Empty;
            CodigoPostal = string.Empty;
            RegistroEstado = string.Empty;
            FechaDeEdicion = DateTime.Now;
        }
    }
}