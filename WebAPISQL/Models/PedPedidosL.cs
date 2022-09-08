using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class PedPedidosL
    {
        public string PdlEmpresa { get; set; } = null!;
        public string? PdlSerie { get; set; }
        public int PdlPedido { get; set; }
        public int PdlLinea { get; set; }
        public string? PdlInventario { get; set; }
        public string? PdlDescAdic { get; set; }
        public string? PdlBodega { get; set; }
        public string? PdlFechaEnt { get; set; }
        public string? PdlDirEnt { get; set; }
        public decimal? PdlCantidad { get; set; }
        public decimal? PdlPreciou { get; set; }
        public decimal? PdlPreciot { get; set; }
        public decimal? PdlCantFinal { get; set; }
        public decimal? PdlSaldoFac { get; set; }
    }
}
