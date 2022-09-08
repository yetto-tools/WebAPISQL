using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class EstaCxc
    {
        public string CxceEmpresa { get; set; } = null!;
        public string CxceCliente { get; set; } = null!;
        public int CxceAno { get; set; }
        public int CxceMes { get; set; }
        public decimal? CxceInicio { get; set; }
        public decimal? CxceCargos { get; set; }
        public decimal? CxceAbonos { get; set; }
    }
}
