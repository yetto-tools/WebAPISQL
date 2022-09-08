using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class DistInvcfg
    {
        public string DicfEmpresa { get; set; } = null!;
        public string DicfUsuario { get; set; } = null!;
        public string? DicfPronostico { get; set; }
        public int? DicfNumsemcal { get; set; }
    }
}
