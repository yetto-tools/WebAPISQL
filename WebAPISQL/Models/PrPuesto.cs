using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class PrPuesto
    {
        public string PuestoEmpresa { get; set; } = null!;
        public decimal PuestoCodPuesto { get; set; }
        public string? PuestoNomPuesto { get; set; }
        public decimal? PuestoCodOrgnivel { get; set; }
        public decimal? PuestoCodEscpuesto { get; set; }
        public decimal? PuestoCodGradoreq { get; set; }
        public decimal? PuestoCodPuestosup { get; set; }
        public decimal? PuestoTotalPtos { get; set; }
        public decimal? PuestoSuelPuesto { get; set; }
        public string? PuestoObservac1 { get; set; }
        public string? PuestoObservac2 { get; set; }
        public string? PuestoObservac3 { get; set; }
        public string? PuestoUsuarioi { get; set; }
        public DateTime? PuestoFechai { get; set; }
        public string? PuestoUsuariom { get; set; }
        public DateTime? PuestoFecham { get; set; }
        public decimal? PuestoEstrCodigo { get; set; }
    }
}
