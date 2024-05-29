using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace SWLNBazarHub.Entidades
{
    [DataContract]
    public class EProductos
    {
        [DataMember]
        public int ProductoID { get; set; }

        [DataMember]
        public string Nombre { get; set; }

        [DataMember]
        public string Descripcion { get; set; }

        [DataMember]
        public decimal Precio { get; set; }

        [DataMember]
        public int Stock { get; set; }

        [DataMember]
        public int CategoriaID { get; set; }

        [DataMember]
        public int ProveedorID { get; set; }

        [DataMember]
        public string Estado { get; set; }

        [DataMember]
        public DateTime FechaDeEdicion { get; set; }

        public EProductos()
        {
            ProductoID = 0;
            Nombre = string.Empty;
            Descripcion = string.Empty;
            Precio = 0M;
            Stock = 0;
            CategoriaID = 0;
            ProveedorID = 0;
            Estado = string.Empty;
            FechaDeEdicion = DateTime.Now;
        }
    }
}