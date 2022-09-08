using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class PrFormulacionDetail
    {
        public string DforEmpresa { get; set; } = null!;
        public decimal DforCodigo { get; set; }
        public string? DforArticuloPadre { get; set; }
        public string? DforArticulo { get; set; }
        public decimal? DforCantidad { get; set; }
        public decimal? DforEstado { get; set; }
        public string? DforBodega { get; set; }
        public string? DforUsuarioi { get; set; }
        public DateTime? DforFechai { get; set; }
        public string? DforUsuariom { get; set; }
        public DateTime? DforFecham { get; set; }
    }
}
