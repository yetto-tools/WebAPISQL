using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class VendePorcVolum
    {
        public string VpctEmpresa { get; set; } = null!;
        public int VpctVendedor { get; set; }
        public int VpctLinea { get; set; }
        public decimal? VpctInicio { get; set; }
        public decimal? VpctFinal { get; set; }
        public decimal? VpctPorcentaje { get; set; }
    }
}
