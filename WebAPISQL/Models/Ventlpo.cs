using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class Ventlpo
    {
        public string? VelEmpresa { get; set; }
        public string? VelTienda { get; set; }
        public int? VelTerminal { get; set; }
        public int? VelNumero { get; set; }
        public string? VelBodega { get; set; }
        public int? VelLinea { get; set; }
        public string? VelInventario { get; set; }
        public string? VelSublineainv { get; set; }
        public decimal? VelUnidades { get; set; }
        public string? VelUnidad { get; set; }
        public decimal? VelPrecioun { get; set; }
        public decimal? VelCostotal { get; set; }
        public decimal? VelCosuni { get; set; }
        public decimal? VelDescuen { get; set; }
        public short? VelPctdescuento { get; set; }
        public string? VelCodigoNuevo { get; set; }
        public string? VelCodigoNombre { get; set; }
        public decimal? VelCosto { get; set; }
        public string? VelFechat { get; set; }
        public decimal? VelComision { get; set; }
        public string? VelSerie { get; set; }
        public string? VelSerieflag { get; set; }
        public decimal? VelGarantia { get; set; }
    }
}
