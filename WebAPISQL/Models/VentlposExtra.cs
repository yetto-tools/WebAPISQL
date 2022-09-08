using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class VentlposExtra
    {
        public string? VxlEmpresa { get; set; }
        public string? VxlTienda { get; set; }
        public int? VxlTerminal { get; set; }
        public int? VxlNumero { get; set; }
        public string? VxlBodega { get; set; }
        public int? VxlLinea { get; set; }
        public string? VxlInventario { get; set; }
        public string? VxlSublineainv { get; set; }
        public decimal? VxlUnidades { get; set; }
        public string? VxlUnidad { get; set; }
        public decimal? VxlPrecioun { get; set; }
        public decimal? VxlCostotal { get; set; }
        public decimal? VxlCosuni { get; set; }
        public decimal? VxlDescuen { get; set; }
        public short? VxlPctdescuento { get; set; }
        public string? VxlCodigoNuevo { get; set; }
        public string? VxlCodigoNombre { get; set; }
        public decimal? VxlCosto { get; set; }
        public string? VxlFechat { get; set; }
        public decimal? VxlComision { get; set; }
        public string? VxlSerie { get; set; }
        public string? VxlSerieflag { get; set; }
        public decimal? VxlGarantia { get; set; }
    }
}
