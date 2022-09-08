using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class DistLiqenvio
    {
        public string? DenvEmpresa { get; set; }
        public int? DenvLiquidac { get; set; }
        public int? DenvLinea { get; set; }
        public int? DenvEnvio { get; set; }
        public string? DenvEmision { get; set; }
        public decimal? DenvTotal { get; set; }
        public string? DenvTipo { get; set; }
        public string? DenvTienda { get; set; }
        public int? DenvTerminal { get; set; }
        public string? DenvSerie { get; set; }
    }
}
