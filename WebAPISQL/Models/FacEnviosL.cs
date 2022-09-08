using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class FacEnviosL
    {
        public string? EnvflEmpresa { get; set; }
        public int? EnvflEnvio { get; set; }
        public int? EnvflLinea { get; set; }
        public string? EnvflArticulo { get; set; }
        public decimal? EnvflCantidad { get; set; }
        public decimal? EnvflPreciou { get; set; }
        public decimal? EnvflDescuento { get; set; }
        public string? EnvflSerie { get; set; }
        public string? EnvflSerieflag { get; set; }
        public string? EnvflNivel { get; set; }
    }
}
