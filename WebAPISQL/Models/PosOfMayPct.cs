using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class PosOfMayPct
    {
        public string OpmpEmpresa { get; set; } = null!;
        public string OpmpInventario { get; set; } = null!;
        public decimal OpmpCantidad { get; set; }
        public decimal? OpmpPrecio { get; set; }
        public string? OpmpTexto { get; set; }
        public int? OpmpActiva { get; set; }
        public string? OpmpInicio { get; set; }
        public string? OpmpFinal { get; set; }
    }
}
