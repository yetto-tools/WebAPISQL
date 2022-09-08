using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class BitacoraVentaH
    {
        public string? BvhEmpresa { get; set; }
        public string? BvhTienda { get; set; }
        public int? BvhTerminal { get; set; }
        public string? BvhSerie { get; set; }
        public int? BvhFactura { get; set; }
        public int? BvhMes { get; set; }
        public int? BvhAnio { get; set; }
        public int? BvhPartida { get; set; }
        public string? BvhTipo { get; set; }
        public string? BvhFecha { get; set; }
    }
}
