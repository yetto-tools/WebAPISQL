using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class PrConfigReporte
    {
        public string CfgEmpresa { get; set; } = null!;
        public decimal CfgCodigo { get; set; }
        public string CfgPathWeb { get; set; } = null!;
        public string CfgStatus { get; set; } = null!;
        public string CfgUsuarioi { get; set; } = null!;
        public DateTime CfgFechai { get; set; }
    }
}
