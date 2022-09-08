using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class BcoRechaza
    {
        public string? RechEmpresa { get; set; }
        public string? RechBanco { get; set; }
        public string? RechNotab { get; set; }
        public string? RechFecha { get; set; }
        public string? RechFactura { get; set; }
        public string? RechCheque { get; set; }
        public decimal? RechMonto { get; set; }
        public string? RechCliente { get; set; }
        public string? RechCuentadepo { get; set; }
        public string? RechFecharede { get; set; }
        public decimal RechRecargo { get; set; }
        public string? RechFechar { get; set; }
        public string? RechStatus { get; set; }
    }
}
