using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class PdcRegpagosH
    {
        public string? PrphEmpresa { get; set; }
        public int? PrphNumero { get; set; }
        public int? PrphCodigo { get; set; }
        public string? PrphCobrador { get; set; }
        public string? PrphConcred { get; set; }
        public string? PrphFecha { get; set; }
        public string? PrphPosfechado { get; set; }
        public string? PrphFechadoc { get; set; }
        public string? PrphCodcuenta { get; set; }
        public int? PrphNumtransac { get; set; }
        public string? PrphCuentabco { get; set; }
        public string? PrphStatus { get; set; }
        public decimal? PrphMonto { get; set; }
        public decimal? PrphSaldo { get; set; }
        public string? PrphTipcod { get; set; }
        public string? PrphClicodcad { get; set; }
        public int? PrphLinea { get; set; }
    }
}
