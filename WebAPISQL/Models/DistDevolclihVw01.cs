using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class DistDevolclihVw01
    {
        public string? VehAniomes { get; set; }
        public string? VehCliente { get; set; }
        public string CliCadena { get; set; } = null!;
        public string CliSubcadena { get; set; } = null!;
        public string? VelInventario { get; set; }
        public int VelUnidades { get; set; }
        public int VelCostotal { get; set; }
        public decimal? DevUnidades { get; set; }
        public decimal? DevCostotal { get; set; }
    }
}
