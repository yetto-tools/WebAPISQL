using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class PrExplosion
    {
        public string ExpEmpresa { get; set; } = null!;
        public decimal ExpVersion { get; set; }
        public decimal ExpCodigo { get; set; }
        public string? ExpCodinventario { get; set; }
        public decimal? ExpCantproducir { get; set; }
        public string? ExpCodinventexp { get; set; }
        public decimal? ExpCantexp { get; set; }
        public decimal? ExpNivel { get; set; }
        public string? ExpEstado { get; set; }
        public decimal? ExpCodpartida { get; set; }
        public decimal? ExpCodproyecto { get; set; }
        public decimal? ExpCodversion { get; set; }
    }
}
