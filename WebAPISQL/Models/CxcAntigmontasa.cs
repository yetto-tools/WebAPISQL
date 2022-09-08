using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class CxcAntigmontasa
    {
        public string AntmEmpresa { get; set; } = null!;
        public int AntmRandom { get; set; }
        public int AntmCorrelativo { get; set; }
        public string? AntmCliente { get; set; }
        public string? AntmTipo { get; set; }
        public string? AntmSerie { get; set; }
        public int? AntmDocumento { get; set; }
        public int? AntmPago { get; set; }
        public string? AntmFechafact { get; set; }
        public string? AntmFechavenc { get; set; }
        public string? AntmFechaupag { get; set; }
        public decimal? AntmSaldoCor { get; set; }
        public decimal? AntmSaldo30 { get; set; }
        public decimal? AntmSaldo60 { get; set; }
        public decimal? AntmSaldo90 { get; set; }
        public decimal? AntmSaldo120 { get; set; }
        public decimal? AntmSaldoM120 { get; set; }
        public int? AntmVendedor { get; set; }
        public string? AntmRuta { get; set; }
        public string? AntmArea { get; set; }
        public string? AntmExtra1 { get; set; }
        public int? AntmExtra2 { get; set; }
        public string? AntmMoneda { get; set; }
        public decimal? AntmTasacam { get; set; }
    }
}
