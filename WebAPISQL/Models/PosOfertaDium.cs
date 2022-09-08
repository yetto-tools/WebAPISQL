using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class PosOfertaDium
    {
        public string OfpdEmpresa { get; set; } = null!;
        public string OfpdInventario { get; set; } = null!;
        public decimal? OfpdPrecio { get; set; }
        public int? OfpdLunes { get; set; }
        public int? OfpdMartes { get; set; }
        public int? OfpdMiercoles { get; set; }
        public int? OfpdJueves { get; set; }
        public int? OfpdViernes { get; set; }
        public int? OfpdSabado { get; set; }
        public int? OfpdDomingo { get; set; }
        public string? OfpdTexto { get; set; }
        public int? OfpdActiva { get; set; }
    }
}
