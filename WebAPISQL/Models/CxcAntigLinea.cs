using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class CxcAntigLinea
    {
        public string CxlEmpresa { get; set; } = null!;
        public int CxlRandom { get; set; }
        public int CxlCorrelativo { get; set; }
        public string? CxlCliente { get; set; }
        public int? CxlVendedor { get; set; }
        public string? CxlTipo { get; set; }
        public string? CxlSerrec { get; set; }
        public int? CxlNumrec { get; set; }
        public string? CxlFecrec { get; set; }
        public string? CxlTdafac { get; set; }
        public int? CxlTrmfac { get; set; }
        public string? CxlSerfac { get; set; }
        public int? CxlNumfac { get; set; }
        public string? CxlFecfac { get; set; }
        public decimal? CxlValor { get; set; }
        public string CxlLinea { get; set; } = null!;
        public string CxlSublinea { get; set; } = null!;
        public string CxlArticulo { get; set; } = null!;
        public decimal? CxlSaldo { get; set; }
        public int? CxlMes { get; set; }
        public int? CxlAno { get; set; }
        public decimal? CxlCorriente { get; set; }
        public decimal? CxlSal30 { get; set; }
        public decimal? CxlSal60 { get; set; }
        public decimal? CxlSal90 { get; set; }
        public decimal? CxlSal120 { get; set; }
        public decimal? CxlSal150 { get; set; }
        public decimal? CxlSalm150 { get; set; }
    }
}
