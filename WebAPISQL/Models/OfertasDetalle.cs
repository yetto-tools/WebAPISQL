using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class OfertasDetalle
    {
        public string? OfdtEmpresa { get; set; }
        public int? OfdtCodoferta { get; set; }
        public int? OfdtLinea { get; set; }
        public string? OfdtInventario { get; set; }
        public decimal? OfdtCantidad { get; set; }
    }
}
