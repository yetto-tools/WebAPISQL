using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class CxpPago
    {
        public string? PagpEmpresa { get; set; }
        public string? PagpProveedor { get; set; }
        public string? PagpFactura { get; set; }
        public int? PagpPago { get; set; }
        public string? PagpFecha { get; set; }
        public decimal? PagpValor { get; set; }
        public decimal? PagpSaldo { get; set; }
        public string? PagpBanco { get; set; }
        public int? PagpCheque { get; set; }
        public string? PagpFechach { get; set; }
        public string? PagpRecibo { get; set; }
        public string? PagpFlag { get; set; }
        public string? PagpUsuarioc { get; set; }
        public string? PagpFechac { get; set; }
        public string? PagpUsuariom { get; set; }
        public string? PagpFecham { get; set; }
    }
}
