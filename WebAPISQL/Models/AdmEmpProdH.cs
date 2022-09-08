using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class AdmEmpProdH
    {
        public string PthEmpresa { get; set; } = null!;
        public string PthFechaEm { get; set; } = null!;
        public int PthGrupo { get; set; }
        public string? PthJefeGrupo { get; set; }
    }
}
