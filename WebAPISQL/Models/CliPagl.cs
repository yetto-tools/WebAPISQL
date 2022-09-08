using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class CliPagl
    {
        public string? CplEmpresa { get; set; }
        public int? CplRecibo { get; set; }
        public int? CplCorrel { get; set; }
        public string? CplTienda { get; set; }
        public int? CplTerminal { get; set; }
        public string? CplTipo { get; set; }
        public string? CplDocumento { get; set; }
        public int? CplPago { get; set; }
        public decimal? CplValor { get; set; }
        public string? CplSerie { get; set; }
    }
}
