using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class TempEstado
    {
        public string TmpEmpresa { get; set; } = null!;
        public int TmpRandom { get; set; }
        public string TmpTienda { get; set; } = null!;
        public int TmpTerminal { get; set; }
        public string TmpFecha { get; set; } = null!;
        public string? TmpTipo { get; set; }
        public string? TmpSerie { get; set; }
        public int? TmpDocumento { get; set; }
        public string? TmpCliente { get; set; }
        public decimal? TmpMonto { get; set; }
        public decimal? TmpSaldo { get; set; }
        public string? TmpMoneda { get; set; }
        public decimal? TmpTasacam { get; set; }
        public int? TmpOrdena { get; set; }
        public string? TmpDoctoafec { get; set; }
    }
}
