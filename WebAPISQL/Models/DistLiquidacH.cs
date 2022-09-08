using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class DistLiquidacH
    {
        public string? DlqhEmpresa { get; set; }
        public int? DlqhLiquidac { get; set; }
        public int? DlqhUltliquidac { get; set; }
        public int? DlqhVendedor { get; set; }
        public string? DlqhFecha { get; set; }
        public string? DlqhStatus { get; set; }
        public string? DlqhObservac1 { get; set; }
        public string? DlqhObservac2 { get; set; }
        public decimal? DlqhExisCant { get; set; }
        public decimal? DlqhExisCamb { get; set; }
        public decimal? DlqhCredTotal { get; set; }
        public decimal? DlqhCobrTotal { get; set; }
        public decimal? DlqhMultas { get; set; }
        public decimal? DlqhSaldo { get; set; }
        public string DlqhFcierre { get; set; } = null!;
        public decimal? DlqhTotal { get; set; }
        public decimal? DlqhSaldoant { get; set; }
        public string? DlqhFecmaxvales { get; set; }
    }
}
