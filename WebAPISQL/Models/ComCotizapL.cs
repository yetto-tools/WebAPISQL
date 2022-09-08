using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class ComCotizapL
    {
        public string? CtplEmpresa { get; set; }
        public int? CtplNumero { get; set; }
        public int? CtplLinea { get; set; }
        public string? CtplInventario { get; set; }
        public string? CtplDescripcion { get; set; }
        public string? CtplArtProv { get; set; }
        public string? CtplUnidad { get; set; }
        public decimal? CtplCantidad { get; set; }
        public decimal? CtplPreciouN { get; set; }
        public decimal? CtplPreciouE { get; set; }
        public int? CtplRequisicion { get; set; }
        public int? CtplLineaReq { get; set; }
        public string? CtplAprobada { get; set; }
    }
}
