using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class PrCorrelativo
    {
        public string CorEmpresa { get; set; } = null!;
        public string CorCorrelativo { get; set; } = null!;
        public decimal CorActual { get; set; }
        public string? CorUsuarioi { get; set; }
        public DateTime CorFechai { get; set; }
    }
}
