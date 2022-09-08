using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class CxcAntiguedad2
    {
        public string AntEmpresa { get; set; } = null!;
        public int AntRandom { get; set; }
        public int AntCorrelativo { get; set; }
        public string? AntCliente { get; set; }
        public string? AntTipo { get; set; }
        public string? AntSerie { get; set; }
        public int? AntDocumento { get; set; }
        public int? AntPago { get; set; }
        public string? AntFechafact { get; set; }
        public string? AntFechavenc { get; set; }
        public string? AntFechaupag { get; set; }
        public decimal? AntSaldoCor { get; set; }
        public decimal? AntSaldo30 { get; set; }
        public decimal? AntSaldo60 { get; set; }
        public decimal? AntSaldo90 { get; set; }
        public decimal? AntSaldo120 { get; set; }
        public decimal? AntSaldoM120 { get; set; }
        public int? AntVendedor { get; set; }
        public string? AntRuta { get; set; }
        public string? AntArea { get; set; }
        public string? AntExtra1 { get; set; }
        public int? AntExtra2 { get; set; }
        public string? AntFelserie { get; set; }
        public string? AntFelnumero { get; set; }
    }
}
