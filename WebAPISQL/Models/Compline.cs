using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class Compline
    {
        public string? ColEmpresa { get; set; }
        public string? ColProveedor { get; set; }
        public string? ColSeriefactura { get; set; }
        public string? ColFactura { get; set; }
        public int? ColLinea { get; set; }
        public string? ColInventario { get; set; }
        public decimal? ColUnidades { get; set; }
        public decimal? ColPreciou { get; set; }
        public string? ColSerie { get; set; }
        public string? ColSerieflag { get; set; }
        public string? ColFechalote { get; set; }
    }
}
