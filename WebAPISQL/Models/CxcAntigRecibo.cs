using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class CxcAntigRecibo
    {
        public string CxrEmpresa { get; set; } = null!;
        public int CxrRandom { get; set; }
        public int CxrCorrelativo { get; set; }
        public string? CxrCliente { get; set; }
        public int? CxrVendedor { get; set; }
        public string? CxrTipo { get; set; }
        public string? CxrSerrec { get; set; }
        public int? CxrNumrec { get; set; }
        public string? CxrFecrec { get; set; }
        public string? CxrTdafac { get; set; }
        public int? CxrTrmfac { get; set; }
        public string? CxrSerfac { get; set; }
        public int? CxrNumfac { get; set; }
        public string? CxrFecfac { get; set; }
        public decimal? CxrValor { get; set; }
        public string CxrLinea { get; set; } = null!;
        public string CxrSublinea { get; set; } = null!;
        public string CxrArticulo { get; set; } = null!;
        public decimal? CxrSaldo { get; set; }
        public int? CxrMes { get; set; }
        public int? CxrAno { get; set; }
        public decimal? CxrTotal { get; set; }
    }
}
