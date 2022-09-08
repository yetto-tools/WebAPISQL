using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class DistLiqvalesh
    {
        public string DvhEmpresa { get; set; } = null!;
        public int DvhNumero { get; set; }
        public int? DvhVendedor { get; set; }
        public string? DvhTipodoc { get; set; }
        public string? DvhDocserie { get; set; }
        public int? DvhDocumento { get; set; }
        public string? DvhFecha { get; set; }
        public string? DvhStatus { get; set; }
        public string? DvhObservacion { get; set; }
        public string? DvhImpresion { get; set; }
        public int? DvhLiquidac { get; set; }
        public string? DvhBodega { get; set; }
    }
}
