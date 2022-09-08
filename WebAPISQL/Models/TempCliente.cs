using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class TempCliente
    {
        public string? TmpEmpresa { get; set; }
        public string? TmpTienda { get; set; }
        public int? TmpTerminal { get; set; }
        public int? TmpNumero { get; set; }
        public string? TmpDireccion { get; set; }
        public string? TmpDireccion1 { get; set; }
        public string? TmpNit { get; set; }
        public string? TmpNombre { get; set; }
        public string? TmpSerie { get; set; }
    }
}
