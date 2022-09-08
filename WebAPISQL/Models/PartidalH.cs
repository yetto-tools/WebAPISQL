using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class PartidalH
    {
        public string? PlhEmpresa { get; set; }
        public int? PlhAno { get; set; }
        public int? PlhMes { get; set; }
        public int? PlhNumero { get; set; }
        public int? PlhLinea { get; set; }
        public string? PlhCuenta { get; set; }
        public decimal? PlhDebe { get; set; }
        public decimal? PlhHaber { get; set; }
    }
}
