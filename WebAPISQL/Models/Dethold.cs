using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class Dethold
    {
        public string? DethEmpresa { get; set; }
        public string? DethTienda { get; set; }
        public int? DethTerminal { get; set; }
        public int? DethNumero { get; set; }
        public string? DethBodega { get; set; }
        public int? DethLinea { get; set; }
        public string? DethInventario { get; set; }
        public string? DethSublineainv { get; set; }
        public decimal? DethUnidades { get; set; }
        public string? DethUnidad { get; set; }
        public decimal? DethPresioun { get; set; }
        public decimal? DethCototal { get; set; }
        public decimal? DethDescuen { get; set; }
        public short? DethPctdescuento { get; set; }
        public short? DethCodigoNuevo { get; set; }
        public string? DethCodigoNombre { get; set; }
        public decimal? DethDesc { get; set; }
        public decimal? DethCosto { get; set; }
        public string? DethFecha { get; set; }
        public decimal? DethComision { get; set; }
        public string? DethSerie { get; set; }
        public string? DethSerieflag { get; set; }
        public decimal? DethGarantia { get; set; }
    }
}
