using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class FacOrdencL
    {
        public string? OrdflEmpresa { get; set; }
        public int? OrdflOrdenc { get; set; }
        public int? OrdflLinea { get; set; }
        public string? OrdflInventario { get; set; }
        public decimal? OrdflCantidad { get; set; }
        public decimal? OrdflPreciou { get; set; }
        public decimal? OrdflDescuento { get; set; }
        public decimal? OrdflDescuenpct { get; set; }
    }
}
