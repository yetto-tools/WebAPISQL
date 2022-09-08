using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class DistInvocomclil
    {
        public string DinoclEmpresa { get; set; } = null!;
        public int DinoclOcnumero { get; set; }
        public int DinoclLinea { get; set; }
        public string? DinoclInventario { get; set; }
        public decimal? DinoclCantidad { get; set; }
        public decimal? DinoclPrecioucli { get; set; }
        public decimal? DinoclPreciouven { get; set; }
        public decimal? DinoclCosto { get; set; }
    }
}
