using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class InvCalculoprc
    {
        public string ClpEmpresa { get; set; } = null!;
        public int ClpNivel { get; set; }
        public decimal ClpCostoini { get; set; }
        public decimal ClpCostofin { get; set; }
        public decimal ClpPctgana { get; set; }
    }
}
