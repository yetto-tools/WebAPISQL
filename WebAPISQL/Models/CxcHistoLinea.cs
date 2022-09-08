using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class CxcHistoLinea
    {
        public string CxhEmpresa { get; set; } = null!;
        public int CxhMesAct { get; set; }
        public int CxhAnoAct { get; set; }
        public int CxhCorrelativo { get; set; }
        public int CxhMes { get; set; }
        public int CxhAno { get; set; }
        public string? CxhCliente { get; set; }
        public int? CxhVendedor { get; set; }
        public string? CxhTipo { get; set; }
        public string? CxhTdafac { get; set; }
        public int? CxhTrmfac { get; set; }
        public string? CxhSerfac { get; set; }
        public int? CxhNumfac { get; set; }
        public string? CxhFecfac { get; set; }
        public decimal? CxhValor { get; set; }
        public string CxhLinea { get; set; } = null!;
        public string CxhSublinea { get; set; } = null!;
        public string CxhArticulo { get; set; } = null!;
        public decimal? CxhSaldo { get; set; }
        public decimal? CxhCorriente { get; set; }
        public decimal? CxhSal30 { get; set; }
        public decimal? CxhSal60 { get; set; }
        public decimal? CxhSal90 { get; set; }
        public decimal? CxhSal120 { get; set; }
        public decimal? CxhSal150 { get; set; }
        public decimal? CxhSalm150 { get; set; }
        public decimal? CxhTotrec { get; set; }
        public decimal? CxhCorriente1 { get; set; }
        public decimal? CxhSal301 { get; set; }
        public decimal? CxhSal601 { get; set; }
        public decimal? CxhSal901 { get; set; }
        public decimal? CxhSal1201 { get; set; }
        public decimal? CxhSal1501 { get; set; }
        public decimal? CxhSalm1501 { get; set; }
    }
}
