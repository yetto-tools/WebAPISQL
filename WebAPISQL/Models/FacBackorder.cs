using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class FacBackorder
    {
        public string? BakoEmpresa { get; set; }
        public int? BakoNumero { get; set; }
        public int? BakoOrden { get; set; }
        public string? BakoOrdencli { get; set; }
        public int? BakoCotizacion { get; set; }
        public string? BakoCliente { get; set; }
        public int? BakoVendedor { get; set; }
        public string? BakoBodegad { get; set; }
        public int? BakoEnvio { get; set; }
        public string? BakoFechac { get; set; }
        public string? BakoFellegada { get; set; }
        public string? BakoInventario { get; set; }
        public decimal? BakoCantidad { get; set; }
        public decimal? BakoPreciou { get; set; }
    }
}
