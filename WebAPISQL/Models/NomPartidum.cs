using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class NomPartidum
    {
        public string ParEmpresa { get; set; } = null!;
        public int ParRandom { get; set; }
        public int ParCorrel { get; set; }
        public string? ParCuenta { get; set; }
        public decimal? ParDebe { get; set; }
        public decimal? ParHaber { get; set; }
    }
}
