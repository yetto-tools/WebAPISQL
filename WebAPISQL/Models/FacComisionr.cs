using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class FacComisionr
    {
        public string FcrEmpresa { get; set; } = null!;
        public decimal FcrCostoini { get; set; }
        public decimal FcrCostofin { get; set; }
        public decimal FcrPctgana { get; set; }
    }
}
