using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace SWLNBazarHub.Entidades
{
    [DataContract]
    public class EDetallesPedido
    {
        [DataMember]
        public int DetalleID { get; set; }

        [DataMember]
        public int PedidoID { get; set; }

        [DataMember]
        public int ProductoID { get; set; }

        [DataMember]
        public int Cantidad { get; set; }

        [DataMember]
        public decimal PrecioUnitario { get; set; }

        [DataMember]
        public decimal Descuento { get; set; }

        [DataMember]
        public string Estado { get; set; }

        [DataMember]
        public DateTime FechaDeEdicion { get; set; }

        public EDetallesPedido()
        {
            DetalleID = 0;
            PedidoID = 0;
            ProductoID = 0;
            Cantidad = 0;
            PrecioUnitario = 0M;
            Descuento = 0M;
            Estado = string.Empty;
            FechaDeEdicion = DateTime.Now;
        }
    }
}