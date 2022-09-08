using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class InvOrdencL
    {
        public string? OrdclEmpresa { get; set; }
        public int? OrdclNumero { get; set; }
        public int? OrdclLinea { get; set; }
        public string? OrdclInventario { get; set; }
        public string? OrdclNombre { get; set; }
        public string? OrdclCodprov { get; set; }
        public decimal? OrdclCantidad { get; set; }
        public decimal? OrdclDescuento { get; set; }
        public decimal? OrdclCostou { get; set; }
    }
}
