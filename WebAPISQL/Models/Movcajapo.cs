using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class Movcajapo
    {
        public string? MovcEmpresa { get; set; }
        public string? MovcTienda { get; set; }
        public int? MovcTerminal { get; set; }
        public int? MovcNumero { get; set; }
        public string? MovcTipo { get; set; }
        public string? MovcDocumento { get; set; }
        public string? MovcFecha { get; set; }
        public string? MovcHora { get; set; }
        public string? MovcDescrip { get; set; }
        public decimal? MovcMonto { get; set; }
    }
}
