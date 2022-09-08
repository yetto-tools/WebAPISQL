using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class FacCotizaExtrah
    {
        public string CotxhEmpresa { get; set; } = null!;
        public int CotxhCotizacion { get; set; }
        public string? CotxhObservaciones1 { get; set; }
        public string? CotxhObservaciones2 { get; set; }
        public string? CotxhObservaciones3 { get; set; }
        public string? CotxhObservaciones4 { get; set; }
        public string? CotxhExtra1 { get; set; }
        public string? CotxhExtra2 { get; set; }
        public string? CotxhExtra3 { get; set; }
        public int? CotxhExtra4 { get; set; }
        public int? CotxhExtra5 { get; set; }
        public int? CotxhExtra6 { get; set; }
    }
}
