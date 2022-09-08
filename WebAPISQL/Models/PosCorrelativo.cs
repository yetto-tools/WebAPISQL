using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class PosCorrelativo
    {
        public string? PoscorCodigo { get; set; }
        public string? PoscorTienda { get; set; }
        public int? PoscorTerminal { get; set; }
        public int? PoscorCorrelativo { get; set; }
        public int? PoscorVehnumero { get; set; }
        public int? PoscorVehfactura { get; set; }
        public int? PoscorCorte { get; set; }
        public int? PoscorCortex { get; set; }
        public int? PoscorCortez { get; set; }
        public int? PoscorMovscaja { get; set; }
        public decimal? PoscorGrantotal { get; set; }
        public int? PoscorHold { get; set; }
    }
}
