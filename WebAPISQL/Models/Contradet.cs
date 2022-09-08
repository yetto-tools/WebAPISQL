using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class Contradet
    {
        public string? CodEmpresa { get; set; }
        public string? CodCliente { get; set; }
        public string? CodContrasena { get; set; }
        public int? CodCorrelativo { get; set; }
        public string? CodTienda { get; set; }
        public int? CodTerminal { get; set; }
        public string? CodFactura { get; set; }
        public decimal? CodMonto { get; set; }
    }
}
