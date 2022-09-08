using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class DistLiqregreso
    {
        public string? DrelEmpresa { get; set; }
        public int? DrelLiquidac { get; set; }
        public int? DrelLinea { get; set; }
        public string? DrelInventario { get; set; }
        public decimal? DrelUnidades { get; set; }
        public decimal? DrelCambios { get; set; }
        public decimal? DrelPreciou { get; set; }
        public string? DrelTipdev { get; set; }
        public string? DrelTipestado { get; set; }
    }
}
