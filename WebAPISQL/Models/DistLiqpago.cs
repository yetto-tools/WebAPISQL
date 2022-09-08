using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class DistLiqpago
    {
        public string? DpagEmpresa { get; set; }
        public int? DpagLiquidac { get; set; }
        public int? DpagLinea { get; set; }
        public string? DpagSerie { get; set; }
        public int? DpagRecibo { get; set; }
        public string? DpagFecha { get; set; }
        public decimal? DpagValor { get; set; }
    }
}
