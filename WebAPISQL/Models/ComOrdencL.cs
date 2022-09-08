using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class ComOrdencL
    {
        public string? OrdclEmpresa { get; set; }
        public int? OrdclNumero { get; set; }
        public int? OrdclLinea { get; set; }
        public string? OrdclInventario { get; set; }
        public string? OrdclDescripcion { get; set; }
        public string? OrdclArtProv { get; set; }
        public string? OrdclUnidad { get; set; }
        public decimal? OrdclCantidad { get; set; }
        public decimal? OrdclPreciouN { get; set; }
        public decimal? OrdclPreciouE { get; set; }
        public int? OrdclRequisicion { get; set; }
        public int? OrdclLineaReq { get; set; }
    }
}
