using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class PrVersionPresup
    {
        public string VerpreEmpresa { get; set; } = null!;
        public decimal VerpreCodigo { get; set; }
        public DateTime? VerpreFechaver { get; set; }
        public string VerpreNombre { get; set; } = null!;
        public decimal? VerpreSaldo { get; set; }
        public DateTime? VerpreFechacEstado { get; set; }
        public string? VerpreUsuarioi { get; set; }
        public string? VerpreUsuariom { get; set; }
        public DateTime? VerpreFechai { get; set; }
        public DateTime? VerpreFecham { get; set; }
        public int? VerpreEstado { get; set; }
        public decimal? VerpreTipoModulo { get; set; }
    }
}
