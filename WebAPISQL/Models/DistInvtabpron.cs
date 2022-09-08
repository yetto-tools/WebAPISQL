using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class DistInvtabpron
    {
        public string DitpEmpresa { get; set; } = null!;
        public string DitpCodigo { get; set; } = null!;
        public string? DitpDescripcion { get; set; }
        public decimal? DitpPorc { get; set; }
        public string? DitpUsuarioc { get; set; }
    }
}
