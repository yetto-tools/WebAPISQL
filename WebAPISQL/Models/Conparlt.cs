using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class Conparlt
    {
        public string? PaltEmpresa { get; set; }
        public int? PaltMes { get; set; }
        public int? PaltNumero { get; set; }
        public int? PaltLinea { get; set; }
        public string? PaltCuenta { get; set; }
        public decimal? PaltDebe { get; set; }
        public decimal? PaltHaber { get; set; }
    }
}
