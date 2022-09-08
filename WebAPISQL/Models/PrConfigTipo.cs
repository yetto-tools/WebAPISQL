using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class PrConfigTipo
    {
        public string CfgtEmpresa { get; set; } = null!;
        public decimal CfgtCodigo { get; set; }
        public string CfgtTipo { get; set; } = null!;
        public string? CfgtDesc { get; set; }
        public decimal CfgtValor { get; set; }
        public string? CfgtCorta { get; set; }
        public decimal? CfgtPadre { get; set; }
        public string? CfgtUsuarioi { get; set; }
        public string? CfgtUsuariom { get; set; }
        public DateTime? CfgtFechai { get; set; }
        public DateTime? CfgtFecham { get; set; }
    }
}
