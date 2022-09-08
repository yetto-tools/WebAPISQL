using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class BitacoraVentaL
    {
        public string BvlEmpresa { get; set; } = null!;
        public string BvlTienda { get; set; } = null!;
        public int BvlTerminal { get; set; }
        public string? BvlSerie { get; set; }
        public int? BvlFactura { get; set; }
        public int? BvlMes { get; set; }
        public int? BvlAnio { get; set; }
        public int? BvlPartida { get; set; }
        public int? BvlCorrelativo { get; set; }
        public string? BvlCuenta { get; set; }
        public decimal? BvlDebe { get; set; }
        public decimal? BvlHaber { get; set; }
        public string? BvlTipo { get; set; }
    }
}
