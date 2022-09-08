using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class DistReportesg
    {
        public string RpgEmpresa { get; set; } = null!;
        public string RpgTipo { get; set; } = null!;
        public int RpgLiquidacion { get; set; }
        public int RpgCorrelLiq { get; set; }
        public string? RpgFecha { get; set; }
        public string? RpgSistema { get; set; }
        public int? RpgVendedor { get; set; }
        public string? RpgInventario { get; set; }
        public decimal? RpgUnidades { get; set; }
        public decimal? RpgValor { get; set; }
        public decimal? RpgCambios { get; set; }
    }
}
