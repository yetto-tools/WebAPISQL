using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class TempClienteExtra
    {
        public string TmpEmpresa { get; set; } = null!;
        public string TmpTienda { get; set; } = null!;
        public int TmpTerminal { get; set; }
        public int TmpNumero { get; set; }
        public string? TmpGiro { get; set; }
        public string? TmpRegistro { get; set; }
        public string? TmpSerie { get; set; }
    }
}
