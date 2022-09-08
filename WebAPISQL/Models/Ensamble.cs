using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class Ensamble
    {
        public string EnsEmpresa { get; set; } = null!;
        public string EnsInventario { get; set; } = null!;
        public string EnsInvEnsamble { get; set; } = null!;
        public string? EnsDescripcion { get; set; }
        public decimal? EnsCantidad { get; set; }
    }
}
