using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class CxpPagRealizar
    {
        public string PxrEmpresa { get; set; } = null!;
        public int PxrRandom { get; set; }
        public int PxrCorrelativo { get; set; }
        public string? PxrProveedor { get; set; }
        public string? PxrFactura { get; set; }
        public int? PxrContrasena { get; set; }
        public string? PxrFecha { get; set; }
        public string? PxrFpago { get; set; }
        public int? PxrPago { get; set; }
        public decimal? PxrValor { get; set; }
        public string? PxrBodega { get; set; }
    }
}
