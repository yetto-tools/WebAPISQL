using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class Conparl
    {
        public string? PalEmpresa { get; set; }
        public int? PalMes { get; set; }
        public int? PalNumero { get; set; }
        public int? PalLinea { get; set; }
        public string? PalCuenta { get; set; }
        public decimal? PalDebe { get; set; }
        public decimal? PalHaber { get; set; }
    }
}
