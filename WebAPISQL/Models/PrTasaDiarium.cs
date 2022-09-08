using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class PrTasaDiarium
    {
        public string TasadEmpresa { get; set; } = null!;
        public decimal TasadCodigo { get; set; }
        public decimal TasadMoneda { get; set; }
        public DateTime TasadFecha { get; set; }
        public decimal TasadTasa { get; set; }
        public string? TasadStatus { get; set; }
        public string TasadUsuarioi { get; set; } = null!;
        public DateTime TasadFechai { get; set; }
        public string TasadUsuariom { get; set; } = null!;
        public DateTime TasadFecham { get; set; }
    }
}
