using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class AjustesCxcDetalle
    {
        public string AjucdEmpresa { get; set; } = null!;
        public string AjucdTipo { get; set; } = null!;
        public int AjucdNumero { get; set; }
        public int AjucdLinea { get; set; }
        public string? AjucdTienda { get; set; }
        public int? AjucdTerminal { get; set; }
        public string? AjucdSerie { get; set; }
        public int? AjucdNumfac { get; set; }
        public string? AjucdInventario { get; set; }
        public decimal? AjucdUnidades { get; set; }
        public decimal? AjucdPrecioun { get; set; }
        public decimal? AjucdCostotal { get; set; }
        public decimal? AjucdDescuento { get; set; }
        public decimal? AjucdDescuenval { get; set; }
        public short? AjucdPctdescuento { get; set; }
        public string? AjucdBodega { get; set; }
    }
}
