using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class VendePorcBonbol
    {
        public string BbprcEmpresa { get; set; } = null!;
        public int BbprcVendedor { get; set; }
        public int BbprcLinea { get; set; }
        public decimal? BbprcInicio { get; set; }
        public decimal? BbprcFinal { get; set; }
        public decimal? BbprcPorcentaje { get; set; }
    }
}
