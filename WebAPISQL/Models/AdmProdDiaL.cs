using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class AdmProdDiaL
    {
        public string PdlEmpresa { get; set; } = null!;
        public int PdlGrupo { get; set; }
        public string PdlFechaEm { get; set; } = null!;
        public string PdlInventario { get; set; } = null!;
        public decimal? PdlCantQq { get; set; }
        public decimal? PdlUniProd { get; set; }
    }
}
