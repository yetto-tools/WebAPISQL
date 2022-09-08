using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class TablaPorcentaje
    {
        public string? PctEmpresa { get; set; }
        public string? PctTipo { get; set; }
        public int? PctLinea { get; set; }
        public decimal? PctInicio { get; set; }
        public decimal? PctFinal { get; set; }
        public decimal? PctPorcentaje { get; set; }
    }
}
