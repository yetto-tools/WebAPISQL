using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class EnvDocumento
    {
        public string EnvEmpresa { get; set; } = null!;
        public int EnvRandom { get; set; }
        public int? EnvLinea { get; set; }
        public int? EnvEnvio { get; set; }
        public string? EnvEmision { get; set; }
        public decimal? EnvTotal { get; set; }
        public string? EnvTipo { get; set; }
        public string? EnvTienda { get; set; }
        public int? EnvTerminal { get; set; }
        public string? EnvSerie { get; set; }
        public int? EnvLiquidac { get; set; }
        public int? EnvNumero { get; set; }
        public string? EnvCliente { get; set; }
        public decimal? EnvValor { get; set; }
        public string? EnvFechadoc { get; set; }
        public string? EnvTipopago { get; set; }
    }
}
