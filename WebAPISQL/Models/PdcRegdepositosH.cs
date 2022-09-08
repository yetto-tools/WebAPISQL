using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class PdcRegdepositosH
    {
        public string PrdhEmpresa { get; set; } = null!;
        public int PrdhNumero { get; set; }
        public int? PrdhCodigo { get; set; }
        public string? PrdhCobrador { get; set; }
        public string? PrdhFecha { get; set; }
        public string? PrdhFechadoc { get; set; }
        public int? PrdhNumtransac { get; set; }
        public string? PrdhCuentabco { get; set; }
        public decimal? PrdhEfect { get; set; }
        public decimal? PrdhChqeb { get; set; }
        public decimal? PrdhChqob { get; set; }
        public decimal? PrdhChqbe { get; set; }
        public decimal? PrdhMonto { get; set; }
    }
}
