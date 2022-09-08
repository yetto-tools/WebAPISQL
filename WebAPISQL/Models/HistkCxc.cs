using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class HistkCxc
    {
        public string? HistEmpresa { get; set; }
        public int? HistCorrelativo { get; set; }
        public string? HistCliente { get; set; }
        public string? HistFecha { get; set; }
        public string? HistTipo { get; set; }
        public string? HistTienda { get; set; }
        public int? HistTerminal { get; set; }
        public string? HistDocumento { get; set; }
        public decimal? HistMonto { get; set; }
        public int? HistRecibo { get; set; }
    }
}
