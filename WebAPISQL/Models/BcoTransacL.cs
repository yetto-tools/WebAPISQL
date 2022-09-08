using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class BcoTransacL
    {
        public string? TraclEmpresa { get; set; }
        public string? TraclTransaccion { get; set; }
        public int? TraclLinea { get; set; }
        public string? TraclValorg { get; set; }
        public string? TraclCuenta { get; set; }
        public string? TraclPos { get; set; }
    }
}
