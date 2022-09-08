using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class PartidaTempVentum
    {
        public string PtvEmpresa { get; set; } = null!;
        public int? PtvRandom { get; set; }
        public string PtvTienda { get; set; } = null!;
        public int PtvTerminal { get; set; }
        public string? PtvSerie { get; set; }
        public int? PtvFactura { get; set; }
        public int? PtvMes { get; set; }
        public int? PtvAnio { get; set; }
        public string? PtvFecha { get; set; }
        public int? PtvPartida { get; set; }
        public int? PtvCorrelativo { get; set; }
        public string? PtvCuenta { get; set; }
        public decimal? PtvDebe { get; set; }
        public decimal? PtvHaber { get; set; }
    }
}
