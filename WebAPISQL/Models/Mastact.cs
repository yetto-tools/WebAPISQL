using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class Mastact
    {
        public string? ActEmpresa { get; set; }
        public string? ActCodigo { get; set; }
        public string? ActClase { get; set; }
        public string? ActDescripcion { get; set; }
        public string? ActFealta { get; set; }
        public string? ActFebaja { get; set; }
        public decimal? ActCosto { get; set; }
        public decimal? ActValorlib { get; set; }
        public decimal? ActSalva { get; set; }
        public string? ActSerie { get; set; }
        public string? ActUbicacion { get; set; }
        public string? ActFactura { get; set; }
        public string? ActMarca { get; set; }
        public string? ActCuenta { get; set; }
        public string? ActProveedor { get; set; }
        public string? ActNomprov { get; set; }
        public int? ActLiquidacion { get; set; }
        public string? ActSeguro { get; set; }
    }
}
