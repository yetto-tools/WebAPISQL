using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class CxpAnticiposH
    {
        public string AnthEmpresa { get; set; } = null!;
        public int AnthNumero { get; set; }
        public string? AnthProveedor { get; set; }
        public string? AnthFecha { get; set; }
        public decimal? AnthMonto { get; set; }
        public decimal? AnthSaldo { get; set; }
        public string? AnthStatus { get; set; }
        public string? AnthBanco { get; set; }
        public string? AnthCheque { get; set; }
        public string? AnthMoneda { get; set; }
        public decimal? AnthTasacam { get; set; }
        public string? AntlFechaa { get; set; }
        public string? AnthUsuario { get; set; }
    }
}
