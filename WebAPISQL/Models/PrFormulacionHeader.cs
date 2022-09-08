using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class PrFormulacionHeader
    {
        public string HforEmpresa { get; set; } = null!;
        public decimal HforCodigo { get; set; }
        public string? HforArticulo { get; set; }
        public decimal? HforCantidad { get; set; }
        public string? HforPlantilla { get; set; }
        public decimal? HforActiva { get; set; }
        public string? HforNivel { get; set; }
        public decimal? HforDpto { get; set; }
        public decimal? HforModuloBatch { get; set; }
        public string? HforUsuarioi { get; set; }
        public DateTime? HforFechai { get; set; }
        public string? HforUsuariom { get; set; }
        public DateTime? HforFecham { get; set; }
    }
}
