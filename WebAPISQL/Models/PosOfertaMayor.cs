using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class PosOfertaMayor
    {
        public string OfpmEmpresa { get; set; } = null!;
        public string OfpmInventario { get; set; } = null!;
        public decimal OfpmCantidad { get; set; }
        public decimal? OfpmPrecio { get; set; }
        public string? OfpmTexto { get; set; }
        public int? OfpmActiva { get; set; }
    }
}
