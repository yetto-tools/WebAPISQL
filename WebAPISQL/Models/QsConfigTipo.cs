using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class QsConfigTipo
    {
        public string CfgtEmpresa { get; set; } = null!;
        public decimal CfgtCodigo { get; set; }
        public string? CfgtTipo { get; set; }
        public string? CfgtDesc { get; set; }
        public decimal? CfgtValor { get; set; }
        public string? CfgtCorta { get; set; }
        public decimal? CfgtPadre { get; set; }
        public string? CfgtUsuarioi { get; set; }
        public string? CfgtUsuariom { get; set; }
        public string? CfgtFechai { get; set; }
        public string? CfgtFecham { get; set; }
    }
}
