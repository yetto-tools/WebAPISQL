using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class AdmGrpProdH
    {
        public string GrhEmpresa { get; set; } = null!;
        public int GrhGrupo { get; set; }
        public string? GrhFechaEm { get; set; }
        public string? GrhDescripcion { get; set; }
    }
}
