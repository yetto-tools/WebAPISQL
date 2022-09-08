using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class CxpLibroiva
    {
        public string LicEmpresa { get; set; } = null!;
        public int LicRandom { get; set; }
        public int LicCorrelativo { get; set; }
        public string? LicProveedor { get; set; }
        public string? LicDocumento { get; set; }
        public string? LicFechaDoc { get; set; }
        public string? LicFechaRec { get; set; }
        public string? LicTipo { get; set; }
        public decimal? LicTotal { get; set; }
        public decimal? LicSnoafecto { get; set; }
        public decimal? LicCnoafecto { get; set; }
        public decimal? LicSafecto { get; set; }
        public decimal? LicCafecto { get; set; }
        public string? LicExtra1 { get; set; }
        public decimal? LicExtra2 { get; set; }
    }
}
