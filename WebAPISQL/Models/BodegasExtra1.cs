using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class BodegasExtra1
    {
        public string BdxEmpresa { get; set; } = null!;
        public string BdxBodega { get; set; } = null!;
        public int? BdxLocacion { get; set; }
        public int? BdxTipinven { get; set; }
        public string? BdxInvestado { get; set; }
        public int? BdxBpt { get; set; }
    }
}
