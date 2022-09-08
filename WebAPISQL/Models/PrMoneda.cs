using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class PrMoneda
    {
        public string MonEmpresa { get; set; } = null!;
        public decimal MonCodigo { get; set; }
        public string? MonNombre { get; set; }
        public string MonMoneda { get; set; } = null!;
        public decimal? MonReferencia { get; set; }
        public string? MonUsuarioi { get; set; }
        public DateTime? MonFechai { get; set; }
        public string? MonUsuariom { get; set; }
        public DateTime? MonFecham { get; set; }
    }
}
