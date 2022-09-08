using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class InvReporteVtasSublinea
    {
        public string CodEmpresa { get; set; } = null!;
        public string CodLinea { get; set; } = null!;
        public decimal AntCosto { get; set; }
        public decimal AntPrecio { get; set; }
        public decimal AntPorcentaje { get; set; }
    }
}
