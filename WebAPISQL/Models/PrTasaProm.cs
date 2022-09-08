using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class PrTasaProm
    {
        public string TasapEmpresa { get; set; } = null!;
        public decimal TasapCodigo { get; set; }
        public decimal TasapMoneda { get; set; }
        public DateTime TasapFecIni { get; set; }
        public DateTime TasapFecFin { get; set; }
        public decimal TasapTasa { get; set; }
        public string TasapUsuarioi { get; set; } = null!;
        public DateTime TasapFechai { get; set; }
        public string TasapUsuariom { get; set; } = null!;
        public DateTime TasapFecham { get; set; }
    }
}
