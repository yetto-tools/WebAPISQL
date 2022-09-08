using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class EstaCxp
    {
        public string? CxpeEmpresa { get; set; }
        public string? CxpeProveedor { get; set; }
        public int? CxpeAno { get; set; }
        public int? CxpeMes { get; set; }
        public decimal? CxpeInicio { get; set; }
        public decimal? CxpeCargos { get; set; }
        public decimal? CxpeAbonos { get; set; }
    }
}
