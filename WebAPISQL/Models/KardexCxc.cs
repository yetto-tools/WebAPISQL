using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class KardexCxc
    {
        public string? CxckEmpresa { get; set; }
        public int? CxckCorrelativo { get; set; }
        public string? CxckCliente { get; set; }
        public string? CxckFecha { get; set; }
        public string? CxckTipo { get; set; }
        public string? CxckTienda { get; set; }
        public int? CxckTerminal { get; set; }
        public string? CxckDocumento { get; set; }
        public decimal? CxckMonto { get; set; }
        public int? CxckRecibo { get; set; }
        public string? CxckTransaccion { get; set; }
        public string? CxckSerier { get; set; }
    }
}
