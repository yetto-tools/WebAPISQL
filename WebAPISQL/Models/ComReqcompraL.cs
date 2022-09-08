using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class ComReqcompraL
    {
        public string? ReqclEmpresa { get; set; }
        public int? ReqclNumero { get; set; }
        public int? ReqclLinea { get; set; }
        public string? ReqclInventario { get; set; }
        public string? ReqclDescripcion { get; set; }
        public string? ReqclUnidad { get; set; }
        public decimal? ReqclCantidad { get; set; }
        public string? ReqclCcosto { get; set; }
        public int? ReqclOrdenc1 { get; set; }
        public int? ReqclOrdenc2 { get; set; }
    }
}
