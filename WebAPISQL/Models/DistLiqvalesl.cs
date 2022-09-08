using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class DistLiqvalesl
    {
        public string DvlEmpresa { get; set; } = null!;
        public int DvlNumero { get; set; }
        public int DvlLinea { get; set; }
        public string? DvlInventario { get; set; }
        public decimal? DvlCantidad { get; set; }
        public decimal? DvlPreciou { get; set; }
        public string? DvlNombre { get; set; }
    }
}
