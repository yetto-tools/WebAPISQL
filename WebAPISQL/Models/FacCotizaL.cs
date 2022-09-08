using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class FacCotizaL
    {
        public string? CotflEmpresa { get; set; }
        public int? CotflCotizacion { get; set; }
        public int? CotflLinea { get; set; }
        public string? CotflInventario { get; set; }
        public decimal? CotflCantidad { get; set; }
        public decimal? CotflPreciou { get; set; }
        public decimal? CotflDescuento { get; set; }
        public string? CotflNivel { get; set; }
    }
}
