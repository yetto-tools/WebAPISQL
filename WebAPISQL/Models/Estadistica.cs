using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class Estadistica
    {
        public string? EstEmpresa { get; set; }
        public string? EstInventario { get; set; }
        public int? EstAno { get; set; }
        public int? EstMes { get; set; }
        public decimal? EstInicio { get; set; }
        public decimal? EstInicioval { get; set; }
        public decimal? EstCompuni { get; set; }
        public decimal? EstCompval { get; set; }
        public decimal? EstVentuni { get; set; }
        public decimal? EstVentval { get; set; }
        public decimal? EstMoveuni { get; set; }
        public decimal? EstMoveval { get; set; }
        public decimal? EstMovsuni { get; set; }
        public decimal? EstMovsval { get; set; }
    }
}
