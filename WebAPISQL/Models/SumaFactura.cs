using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class SumaFactura
    {
        public string SumEmpresa { get; set; } = null!;
        public int SumRandom { get; set; }
        public int SumFactura { get; set; }
        public decimal? SumValor { get; set; }
    }
}
