using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class BcoVoucher
    {
        public string? ChlEmpresa { get; set; }
        public string? ChlCuentabco { get; set; }
        public int? ChlNumero { get; set; }
        public int? ChlLinea { get; set; }
        public string? ChlCuenta { get; set; }
        public decimal? ChlDebe { get; set; }
        public decimal? ChlHaber { get; set; }
        public int? ChlMes { get; set; }
    }
}
