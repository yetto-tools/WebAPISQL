using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class TransacVentasL
    {
        public string TvlEmpresa { get; set; } = null!;
        public string TvlCodigo { get; set; } = null!;
        public string TvlCuenta { get; set; } = null!;
        public int TvlCorrelativo { get; set; }
        public string TvlCampo { get; set; } = null!;
        public string TvlDebeHaber { get; set; } = null!;
    }
}
