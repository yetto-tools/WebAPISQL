using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class FacBackordersL
    {
        public string FbolEmpresa { get; set; } = null!;
        public int FbolNumero { get; set; }
        public int FbolLinea { get; set; }
        public string? FbolBodega { get; set; }
        public string? FbolInventario { get; set; }
        public string? FbolSublineainv { get; set; }
        public decimal? FbolUnidades { get; set; }
        public decimal? FbolSaldouni { get; set; }
        public string? FbolUnidad { get; set; }
        public decimal? FbolPrecioun { get; set; }
        public decimal? FbolCostotal { get; set; }
        public string? FbolFecha { get; set; }
        public string? FbolSerieflag { get; set; }
        public string? FbolStatus { get; set; }
        public string? FbolUsuarioi { get; set; }
        public string? FbolFechai { get; set; }
        public string? FbolUsuariom { get; set; }
        public string? FbolFecham { get; set; }
    }
}
