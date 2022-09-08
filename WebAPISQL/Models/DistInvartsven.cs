using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class DistInvartsven
    {
        public string DinavEmpresa { get; set; } = null!;
        public int DinavVendedor { get; set; }
        public int DinavLinea { get; set; }
        public string? DinavInventario { get; set; }
    }
}
