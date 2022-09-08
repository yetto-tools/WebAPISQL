using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class PedidoSugerido
    {
        public string? PesEmpresa { get; set; }
        public int? PesCorrelativo { get; set; }
        public string? PesProveedor { get; set; }
        public string? PesInventario { get; set; }
        public decimal? PesCantidad { get; set; }
        public decimal? PesCosto { get; set; }
    }
}
