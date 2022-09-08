using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class CxpFacCuentum
    {
        public string FxcEmpresa { get; set; } = null!;
        public int FxcRandom { get; set; }
        public int FxcCorrelativo { get; set; }
        public string? FxcCuenta { get; set; }
        public string? FxcProveedor { get; set; }
        public string? FxcFactura { get; set; }
        public string? FxcFecha { get; set; }
        public string? FxcFpago { get; set; }
        public decimal? FxcDebe { get; set; }
        public decimal? FxcHaber { get; set; }
        public int? FxcMes { get; set; }
        public int? FxcPartida { get; set; }
    }
}
