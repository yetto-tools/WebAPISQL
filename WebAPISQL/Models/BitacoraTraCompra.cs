using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class BitacoraTraCompra
    {
        public string? BtrcEmpresa { get; set; }
        public string? BtrcProveedor { get; set; }
        public string? BtrcFactura { get; set; }
        public int? BtrcMes { get; set; }
        public int? BtrcPartida { get; set; }
        public decimal? BtrcTotal { get; set; }
        public string? BtrcFecha { get; set; }
        public string? BtrcHora { get; set; }
        public string? BtrcUsuario { get; set; }
        public int? BtrcAnticipo { get; set; }
        public string? BtrcTipo { get; set; }
    }
}
