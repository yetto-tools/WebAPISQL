using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class FacPago
    {
        public string? PagfEmpresa { get; set; }
        public string? PagfCliente { get; set; }
        public string? PagfFactura { get; set; }
        public int? PagfPago { get; set; }
        public string? PagfFecha { get; set; }
        public decimal? PagfValor { get; set; }
        public decimal? PagfRecargos { get; set; }
        public string? PagfBanco { get; set; }
        public string? PagfCheque { get; set; }
        public string? PagfFechach { get; set; }
        public int? PagfRecibo { get; set; }
        public string? PagfFlag { get; set; }
        public decimal? PagfSaldo { get; set; }
        public string? PagfUsuarioc { get; set; }
        public string? PagfFechac { get; set; }
        public string? PagfUsuariom { get; set; }
        public string? PagfFecham { get; set; }
        public string? PagfTienda { get; set; }
        public int? PagfTerminal { get; set; }
        public string? PagfSerie { get; set; }
    }
}
