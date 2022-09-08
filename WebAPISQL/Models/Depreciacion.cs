using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class Depreciacion
    {
        public string? DepEmpresa { get; set; }
        public string? DepActivo { get; set; }
        public int? DepMes { get; set; }
        public int? DepAno { get; set; }
        public decimal? DepMonto { get; set; }
        public string? DepStatus { get; set; }
    }
}
