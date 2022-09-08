using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class KardexCxp
    {
        public string? CxpkEmpresa { get; set; }
        public int? CxpkCorrelativo { get; set; }
        public string? CxpkProveedor { get; set; }
        public string? CxpkFecha { get; set; }
        public string? CxpkTipo { get; set; }
        public string? CxpkTipoPago { get; set; }
        public string? CxpkDocumento { get; set; }
        public decimal? CxpkMonto { get; set; }
        public int? CxpkContrasena { get; set; }
        public string? CxpkTransaccion { get; set; }
    }
}
