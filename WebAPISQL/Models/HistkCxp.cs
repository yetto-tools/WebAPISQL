using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class HistkCxp
    {
        public string? HiskEmpresa { get; set; }
        public int? HiskCorrelativo { get; set; }
        public string? HiskProveedor { get; set; }
        public string? HiskFecha { get; set; }
        public string? HiskTipo { get; set; }
        public string? HiskTipoPago { get; set; }
        public string? HiskDocumento { get; set; }
        public decimal? HiskMonto { get; set; }
        public int? HiskContrasena { get; set; }
        public string? HiskTransaccion { get; set; }
    }
}
