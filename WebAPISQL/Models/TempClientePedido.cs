using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class TempClientePedido
    {
        public string TmpEmpresa { get; set; } = null!;
        public int TmpOrden { get; set; }
        public string? TmpDireccion { get; set; }
        public string? TmpDireccion1 { get; set; }
        public string? TmpNit { get; set; }
        public string? TmpPhones { get; set; }
        public string? TmpNombre { get; set; }
    }
}
