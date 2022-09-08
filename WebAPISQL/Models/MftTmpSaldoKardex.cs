using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class MftTmpSaldoKardex
    {
        public int CodRepKardex { get; set; }
        public string? InvEmpresa { get; set; }
        public string InvInventario { get; set; } = null!;
        public string InvNombre { get; set; } = null!;
        public string InvUnidad { get; set; } = null!;
        public string TraBodega { get; set; } = null!;
        public string BodNombre { get; set; } = null!;
        public string TraTipo { get; set; } = null!;
        public decimal InvSaldo { get; set; }
    }
}
