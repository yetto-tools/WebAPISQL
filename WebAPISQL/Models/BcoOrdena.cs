using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class BcoOrdena
    {
        public string OrdEmpresa { get; set; } = null!;
        public int OrdRandom { get; set; }
        public int OrdCorrel { get; set; }
        public string? OrdCuenta { get; set; }
        public decimal? OrdDebe { get; set; }
        public decimal? OrdHaber { get; set; }
    }
}
