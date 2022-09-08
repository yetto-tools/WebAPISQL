using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class IngBodegal
    {
        public string? InlEmpresa { get; set; }
        public int? InlInhNumero { get; set; }
        public int? InlLinea { get; set; }
        public string? InlProveedor { get; set; }
        public int? InlNordencom { get; set; }
        public string? InlEnviop { get; set; }
        public string? InlFactura { get; set; }
        public string? InlInventario { get; set; }
        public decimal? InlUnidades { get; set; }
        public decimal? InlPreciou { get; set; }
        public string? InlSerie { get; set; }
        public string? InlSerieflag { get; set; }
        public string? InlFechav { get; set; }
    }
}
