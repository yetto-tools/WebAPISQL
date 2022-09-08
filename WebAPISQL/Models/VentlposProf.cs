using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class VentlposProf
    {
        public string VlpEmpresa { get; set; } = null!;
        public string VlpTienda { get; set; } = null!;
        public int VlpTerminal { get; set; }
        public int VlpNumero { get; set; }
        public string? VlpBodega { get; set; }
        public int VlpLinea { get; set; }
        public string? VlpInventario { get; set; }
        public string? VlpSublineainv { get; set; }
        public decimal? VlpUnidades { get; set; }
        public string? VlpUnidad { get; set; }
        public decimal? VlpPrecioun { get; set; }
        public decimal? VlpCostotal { get; set; }
        public decimal? VlpCosuni { get; set; }
        public decimal? VlpDescuen { get; set; }
        public short? VlpPctdescuento { get; set; }
        public string? VlpCodigoNuevo { get; set; }
        public string? VlpCodigoNombre { get; set; }
        public decimal? VlpCosto { get; set; }
        public string? VlpFechat { get; set; }
        public decimal? VlpComision { get; set; }
        public string? VlpSerie { get; set; }
        public string? VlpSerieflag { get; set; }
        public decimal? VlpGarantia { get; set; }
    }
}
