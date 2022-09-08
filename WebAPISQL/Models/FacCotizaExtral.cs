using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class FacCotizaExtral
    {
        public string CotxlEmpresa { get; set; } = null!;
        public int CotxlCotizacion { get; set; }
        public int CotxlLinea { get; set; }
        public string? CotxlBodega { get; set; }
        public string? CotxlExtra1 { get; set; }
        public string? CotxlExtra2 { get; set; }
        public string? CotxlExtra3 { get; set; }
        public int? CotxlExtra4 { get; set; }
        public int? CotxlExtra5 { get; set; }
        public int? CotxlExtra6 { get; set; }
    }
}
