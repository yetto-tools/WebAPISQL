using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class CxcAntiguedad1
    {
        public string AntiEmpresa { get; set; } = null!;
        public int AntiRandom { get; set; }
        public int AntiCorrelativo { get; set; }
        public string? AntiCliente { get; set; }
        public string? AntiTipo { get; set; }
        public string? AntiSerie { get; set; }
        public int? AntiDocumento { get; set; }
        public int? AntiPago { get; set; }
        public string? AntiFechafact { get; set; }
        public string? AntiFechavenc { get; set; }
        public string? AntiFechaupag { get; set; }
        public decimal? AntiSaldoCor { get; set; }
        public decimal? AntiSaldo7 { get; set; }
        public decimal? AntiSaldo14 { get; set; }
        public decimal? AntiSaldo21 { get; set; }
        public decimal? AntiSaldo30 { get; set; }
        public int? AntiVendedor { get; set; }
        public string? AntiRuta { get; set; }
        public string? AntiArea { get; set; }
        public string? AntiExtra1 { get; set; }
        public int? AntiExtra2 { get; set; }
    }
}
