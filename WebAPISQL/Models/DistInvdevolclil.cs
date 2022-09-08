using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class DistInvdevolclil
    {
        public string DindclEmpresa { get; set; } = null!;
        public int DindclDevnumero { get; set; }
        public int DindclLinea { get; set; }
        public string? DindclInventario { get; set; }
        public decimal? DindclCantidad { get; set; }
        public decimal? DindclPrecioucli { get; set; }
        public decimal? DindclPreciouven { get; set; }
        public decimal? DindclCosto { get; set; }
        public decimal? DindclCostotal { get; set; }
    }
}
