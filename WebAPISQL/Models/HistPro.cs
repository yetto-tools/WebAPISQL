using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class HistPro
    {
        public string? HprEmpresa { get; set; }
        public string? HprProveedor { get; set; }
        public string? HprCohFactura { get; set; }
        public string? HprCohFecha { get; set; }
        public decimal? HprTotal { get; set; }
        public decimal? HprDescuen { get; set; }
    }
}
