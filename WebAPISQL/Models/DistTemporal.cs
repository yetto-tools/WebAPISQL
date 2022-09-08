using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class DistTemporal
    {
        public int DtpCorrelativo { get; set; }
        public string DtpInventario { get; set; } = null!;
        public decimal DtpRegreso { get; set; }
        public decimal DtpSalida { get; set; }
    }
}
