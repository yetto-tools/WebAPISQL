using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class CxpContrasena
    {
        public string CtrEmpresa { get; set; } = null!;
        public int CtrRandom { get; set; }
        public int CtrContrasena { get; set; }
        public string? CtrProveedor { get; set; }
        public string? CtrFactura { get; set; }
        public string? CtrFechaf { get; set; }
        public string? CtrFrecep { get; set; }
        public string? CtrFpago { get; set; }
        public int? CtrPago { get; set; }
        public string? CtrFechap { get; set; }
        public decimal? CtrSaldo { get; set; }
    }
}
