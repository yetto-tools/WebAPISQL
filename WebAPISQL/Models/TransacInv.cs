using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class TransacInv
    {
        public string? TraEmpresa { get; set; }
        public int? TraCorrelativo { get; set; }
        public string? TraTipo { get; set; }
        public string? TraTipodoc { get; set; }
        public string? TraDocumento { get; set; }
        public string? TraCentro { get; set; }
        public string? TraFechat { get; set; }
        public string? TraBodega { get; set; }
        public string? TraSublineainv { get; set; }
        public string? TraInventario { get; set; }
        public decimal? TraCantidad { get; set; }
        public decimal? TraTasa { get; set; }
        public decimal? TraCosto { get; set; }
        public decimal? TraPrecio { get; set; }
        public string? TraCliente { get; set; }
    }
}
