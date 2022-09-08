using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class CxcCobranza
    {
        public string CbaEmpresa { get; set; } = null!;
        public int CbaRandom { get; set; }
        public int CbaCorrelativo { get; set; }
        public string? CbaCliente { get; set; }
        public int? CbaVendedor { get; set; }
        public string? CbaTipo { get; set; }
        public string? CbaSerrec { get; set; }
        public int? CbaNumrec { get; set; }
        public string? CbaFecrec { get; set; }
        public string? CbaTdafac { get; set; }
        public int? CbaTrmfac { get; set; }
        public string? CbaSerfac { get; set; }
        public int? CbaNumfac { get; set; }
        public string? CbaFecfac { get; set; }
        public decimal? CbaValor { get; set; }
        public string CbaLinea { get; set; } = null!;
        public string CbaSublinea { get; set; } = null!;
        public string CbaArticulo { get; set; } = null!;
        public decimal? CbaUnidades { get; set; }
    }
}
