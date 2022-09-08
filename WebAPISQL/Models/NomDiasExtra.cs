using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class NomDiasExtra
    {
        public string NdeEmpresa { get; set; } = null!;
        public int NdeAnio { get; set; }
        public int NdeMes { get; set; }
        public string? NdeFecha { get; set; }
        public string NdePersonal { get; set; } = null!;
        public int? NdeDias { get; set; }
    }
}
