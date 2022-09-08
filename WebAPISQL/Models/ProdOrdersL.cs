using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class ProdOrdersL
    {
        public string? OrdlEmpresa { get; set; }
        public int? OrdlOrden { get; set; }
        public int? OrdlLinea { get; set; }
        public string? OrdlInventario { get; set; }
        public decimal? OrdlCantidad { get; set; }
        public decimal? OrdlPreciou { get; set; }
        public decimal? OrdlDescuento { get; set; }
        public string? OrdlSkunumber { get; set; }
        public string? OrdlPackage { get; set; }
        public decimal? OrdlDespachado { get; set; }
        public string? OrdlBodega { get; set; }
        public decimal? OrdlPorcentaje { get; set; }
        public decimal? OrdlDescvalor { get; set; }
    }
}
