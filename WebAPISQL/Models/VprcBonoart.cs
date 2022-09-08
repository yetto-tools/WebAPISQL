using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class VprcBonoart
    {
        public string BoprcEmpresa { get; set; } = null!;
        public int BoprcVendedor { get; set; }
        public int BoprcLinea { get; set; }
        public decimal? BoprcInicio { get; set; }
        public decimal? BoprcFinal { get; set; }
        public decimal? BoprcPorcentaje { get; set; }
    }
}
