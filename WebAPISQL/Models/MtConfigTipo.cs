using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class MtConfigTipo
    {
        public string CfgtEmpresa { get; set; } = null!;
        public decimal CfgtCodigo { get; set; }
        public string CfgtTipo { get; set; } = null!;
        public string CfgtDesc { get; set; } = null!;
        public decimal CfgtValor { get; set; }
        public string CfgtCorta { get; set; } = null!;
        public decimal CfgtPadre { get; set; }
        public string CfgtUsuarioi { get; set; } = null!;
        public string CfgtUsuariom { get; set; } = null!;
        public DateTime CfgtFechai { get; set; }
        public DateTime CfgtFecham { get; set; }
    }
}
