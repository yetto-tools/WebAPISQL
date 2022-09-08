using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class MastprovExt1
    {
        public string PexEmpresa { get; set; } = null!;
        public string PexProveedor { get; set; } = null!;
        public string? PexNombre { get; set; }
        public string? PexDireccion { get; set; }
    }
}
