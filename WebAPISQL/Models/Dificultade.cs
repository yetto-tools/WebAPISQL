using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class Dificultade
    {
        public string DifEmpresa { get; set; } = null!;
        public int DifCorrelativo { get; set; }
        public int DifFactura { get; set; }
        public string DifSerie { get; set; } = null!;
        public string DifTienda { get; set; } = null!;
        public int DifTerminal { get; set; }
        public int DifPago { get; set; }
        public string? DifDificultad { get; set; }
        public string? DifObservacion { get; set; }
        public string? DifFecha { get; set; }
    }
}
