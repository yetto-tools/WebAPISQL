using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class SistemasVenta
    {
        public string SisEmpresa { get; set; } = null!;
        public string SisSistema { get; set; } = null!;
        public string? SisNombre { get; set; }
    }
}
