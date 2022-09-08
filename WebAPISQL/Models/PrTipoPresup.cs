using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class PrTipoPresup
    {
        public string TipopreEmpresa { get; set; } = null!;
        public decimal TipopreCodigo { get; set; }
        public string? TipopreNombre { get; set; }
        public string? TipopreOrdenimp { get; set; }
        public string? TipopreUsuarioi { get; set; }
        public string? TipopreUsuariom { get; set; }
        public DateTime? TipopreFechai { get; set; }
        public DateTime? TipopreFecham { get; set; }
    }
}
