using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class Templine
    {
        public string? TmplEmpresa { get; set; }
        public string? TmplTienda { get; set; }
        public int? TmplTerminal { get; set; }
        public int? TmplNumero { get; set; }
        public string? TmplBodega { get; set; }
        public int? TmplLinea { get; set; }
        public string? TmplInventario { get; set; }
        public string? TmplSublineainv { get; set; }
        public decimal? TmplUnidades { get; set; }
        public string? TmplUnidad { get; set; }
        public decimal? TmplPrecioun { get; set; }
        public decimal? TmplCostotal { get; set; }
        public decimal? TmplCosuni { get; set; }
        public decimal? TmplDescuen { get; set; }
        public short? TmplPctdescuento { get; set; }
        public string? TmplInvNuevo { get; set; }
        public string? TmplInvNombre { get; set; }
        public decimal? TmplCosto { get; set; }
        public string? TmplFechat { get; set; }
        public decimal? TmplComision { get; set; }
        public string? TmplSerie { get; set; }
        public string? TmplSerieflag { get; set; }
        public decimal? TmplGarantia { get; set; }
    }
}
