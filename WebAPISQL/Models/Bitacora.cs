using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class Bitacora
    {
        public string? BitEmpresa { get; set; }
        public string? BitTienda { get; set; }
        public int? BitTerminal { get; set; }
        public int? BitNumero { get; set; }
        public string? BitRutina { get; set; }
        public string? BitInventario { get; set; }
        public string? BitUsuario { get; set; }
        public string? BitFecha { get; set; }
        public string? BitHora { get; set; }
        public decimal? BitValor1 { get; set; }
        public decimal? BitValor2 { get; set; }
    }
}
