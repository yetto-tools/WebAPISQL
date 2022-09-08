using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class CxpAntiguedad
    {
        public string AnpEmpresa { get; set; } = null!;
        public int AnpRandom { get; set; }
        public int AnpCorrelativo { get; set; }
        public string? AnpProveedor { get; set; }
        public string? AnpTipo { get; set; }
        public string? AnpDocumento { get; set; }
        public int? AnpOrdenpago { get; set; }
        public string? AnpFechafact { get; set; }
        public string? AnpFechaupag { get; set; }
        public decimal? AnpSaldoCor { get; set; }
        public decimal? AnpSaldo30 { get; set; }
        public decimal? AnpSaldo60 { get; set; }
        public decimal? AnpSaldo90 { get; set; }
        public decimal? AnpSaldo120 { get; set; }
        public decimal? AnpSaldoM120 { get; set; }
        public string? AnpExtra1 { get; set; }
        public int? AnpExtra2 { get; set; }
    }
}
