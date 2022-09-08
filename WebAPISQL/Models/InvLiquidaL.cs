using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class InvLiquidaL
    {
        public string? LiqlEmpresa { get; set; }
        public int? LiqlLiquidacion { get; set; }
        public int? LiqlLinea { get; set; }
        public string? LiqlProveedor { get; set; }
        public int? LiqlNordencom { get; set; }
        public string? LiqlEnviop { get; set; }
        public string? LiqlFactura { get; set; }
        public string? LiqlInventario { get; set; }
        public decimal? LiqlCantidad { get; set; }
        public decimal? LiqlCostou { get; set; }
        public decimal? LiqlGprorateado { get; set; }
    }
}
