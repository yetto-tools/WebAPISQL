using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class PartidaTempComp
    {
        public string PtcEmpresa { get; set; } = null!;
        public int? PtcRandom { get; set; }
        public string PtcProveedor { get; set; } = null!;
        public int PtcTerminal { get; set; }
        public string? PtcSerie { get; set; }
        public int? PtcFactura { get; set; }
        public int? PtcMes { get; set; }
        public int? PtcAnio { get; set; }
        public string? PtcFecha { get; set; }
        public int? PtcPartida { get; set; }
        public int? PtcCorrelativo { get; set; }
        public string? PtcCuenta { get; set; }
        public decimal? PtcDebe { get; set; }
        public decimal? PtcHaber { get; set; }
    }
}
