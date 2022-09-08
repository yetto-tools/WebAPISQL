using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class VenthposVw01
    {
        public string? VehAniomes { get; set; }
        public string? VehCliente { get; set; }
        public string CliCadena { get; set; } = null!;
        public string CliSubcadena { get; set; } = null!;
        public string? VelInventario { get; set; }
        public decimal? VelUnidades { get; set; }
        public decimal? VelCostotal { get; set; }
        public int DevUnidades { get; set; }
        public int DevCostotal { get; set; }
    }
}
