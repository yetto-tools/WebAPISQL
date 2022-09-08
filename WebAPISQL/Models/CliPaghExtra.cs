using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class CliPaghExtra
    {
        public string CphxEmpresa { get; set; } = null!;
        public string CphxSerie { get; set; } = null!;
        public int CphxRecibo { get; set; }
        public string? CphxDescripcion { get; set; }
        public string? CphxExtra1 { get; set; }
        public string? CphxExtra2 { get; set; }
        public string? CphxExtra3 { get; set; }
        public string? CphxExtra4 { get; set; }
        public decimal? CphxExtra5 { get; set; }
        public decimal? CphxExtra6 { get; set; }
        public decimal? CphxExtra7 { get; set; }
        public decimal? CphxExtra8 { get; set; }
    }
}
