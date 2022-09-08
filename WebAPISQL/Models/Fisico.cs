using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class Fisico
    {
        public string? FisEmpresa { get; set; }
        public string? FisBodega { get; set; }
        public int? FisPagina { get; set; }
        public int? FisLinea { get; set; }
        public string? FisInventario { get; set; }
        public string? FisFecha { get; set; }
        public decimal? FisUniexi { get; set; }
        public string? FisActflg { get; set; }
        public string? FisLocaliza { get; set; }
        public string? FisSerie { get; set; }
        public string? FisSerieflag { get; set; }
        public string? FisFevenci { get; set; }
    }
}
