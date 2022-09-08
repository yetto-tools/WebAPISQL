using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class VensalPorcVolum
    {
        public string VsvvEmpresa { get; set; } = null!;
        public int VsvvVendedor { get; set; }
        public int VsvvLinea { get; set; }
        public decimal? VsvvInicio { get; set; }
        public decimal? VsvvFinal { get; set; }
        public decimal? VsvvPorcentaje { get; set; }
    }
}
