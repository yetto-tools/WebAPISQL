using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class CorrelativoEspecial
    {
        public string CoreEmpresa { get; set; } = null!;
        public string CoreTipo { get; set; } = null!;
        public int? CoreInicial { get; set; }
        public int? CoreFinal { get; set; }
        public int? CoreActual { get; set; }
        public string? CoreFechaMod { get; set; }
        public string? CoreUsuariom { get; set; }
    }
}
