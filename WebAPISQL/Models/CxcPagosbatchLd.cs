using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class CxcPagosbatchLd
    {
        public string CxcpldEmpresa { get; set; } = null!;
        public string CxcpldTipo { get; set; } = null!;
        public int CxcpldNumero { get; set; }
        public int CxcpldLinea { get; set; }
        public string CxcpldTpago { get; set; } = null!;
        public string CxcpldCodbco { get; set; } = null!;
        public string CxcpldDocnum { get; set; } = null!;
        public string CxcpldFecha { get; set; } = null!;
        public decimal CxcpldMonto { get; set; }
    }
}
