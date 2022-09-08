using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class PrConcepPartidum
    {
        public string ConcparEmpresa { get; set; } = null!;
        public decimal ConcparCodigo { get; set; }
        public string ConcparNombre { get; set; } = null!;
        public string? ConcparDescrip { get; set; }
        public string? ConcparUsuarioi { get; set; }
        public string? ConcparUsuariom { get; set; }
        public DateTime? ConcparFechai { get; set; }
        public DateTime? ConcparFecham { get; set; }
    }
}
