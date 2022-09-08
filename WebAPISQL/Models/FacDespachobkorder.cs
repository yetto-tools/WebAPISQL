using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class FacDespachobkorder
    {
        public string? FdboEmpresa { get; set; }
        public string? FdboVehTienda { get; set; }
        public int? FdboVehTerminal { get; set; }
        public string? FdboVehSerie { get; set; }
        public int? FdboVehFactura { get; set; }
        public int? FdboVehNumero { get; set; }
        public int? FdboVelLinea { get; set; }
        public int? FdboLinea { get; set; }
        public string? FdboFecha { get; set; }
        public string? FdboStatus { get; set; }
        public int? FdboFbohNumero { get; set; }
        public int? FdboFbolLinea { get; set; }
        public string? FdboFbolInventario { get; set; }
        public string? FdboFbolBodega { get; set; }
        public decimal? FdboCantidad { get; set; }
        public decimal? FdboPreciou { get; set; }
        public string? FdboUsuarioc { get; set; }
        public string? FdboFechac { get; set; }
    }
}
