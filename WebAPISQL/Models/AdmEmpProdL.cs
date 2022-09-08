using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class AdmEmpProdL
    {
        public string PtlEmpresa { get; set; } = null!;
        public string PtlFechaEm { get; set; } = null!;
        public int PtlGrupo { get; set; }
        public string PtlInventario { get; set; } = null!;
        public decimal? PtlProduccion { get; set; }
        public string? PtlTipoPres { get; set; }
        public decimal? PtlCantEmp { get; set; }
        public decimal? PtlTotPan { get; set; }
        public decimal? PtlTotDesp { get; set; }
    }
}
