using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class CtaContTiendum
    {
        public string CctEmpresa { get; set; } = null!;
        public string CctTienda { get; set; } = null!;
        public string CctSublinea { get; set; } = null!;
        public string CctCtaIngr { get; set; } = null!;
        public string? CctCtaEgre { get; set; }
    }
}
