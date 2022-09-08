using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class CxcGlobalLinea
    {
        public string CxgEmpresa { get; set; } = null!;
        public int CxgMesAct { get; set; }
        public int CxgAnoAct { get; set; }
        public int CxgCorrelativo { get; set; }
        public int CxgMes { get; set; }
        public int CxgAno { get; set; }
        public string? CxgCliente { get; set; }
        public int? CxgVendedor { get; set; }
        public string? CxgTipo { get; set; }
        public string? CxgTdafac { get; set; }
        public int? CxgTrmfac { get; set; }
        public string? CxgSerfac { get; set; }
        public int? CxgNumfac { get; set; }
        public string? CxgFecfac { get; set; }
        public decimal? CxgValor { get; set; }
        public string CxgLinea { get; set; } = null!;
        public string CxgSublinea { get; set; } = null!;
        public string CxgArticulo { get; set; } = null!;
        public decimal? CxgSaldo { get; set; }
        public decimal? CxgCorriente { get; set; }
        public decimal? CxgSal30 { get; set; }
        public decimal? CxgSal60 { get; set; }
        public decimal? CxgSal90 { get; set; }
        public decimal? CxgSal120 { get; set; }
        public decimal? CxgSal150 { get; set; }
        public decimal? CxgSalm150 { get; set; }
        public decimal? CxgTotrec { get; set; }
        public decimal? CxgCorriente1 { get; set; }
        public decimal? CxgSal301 { get; set; }
        public decimal? CxgSal601 { get; set; }
        public decimal? CxgSal901 { get; set; }
        public decimal? CxgSal1201 { get; set; }
        public decimal? CxgSal1501 { get; set; }
        public decimal? CxgSalm1501 { get; set; }
        public decimal? CxgTotfactu { get; set; }
        public decimal? CxgTotrecib { get; set; }
        public decimal? CxgTotcredi { get; set; }
        public string? CxgCentro { get; set; }
    }
}
