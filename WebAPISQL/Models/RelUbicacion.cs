using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class RelUbicacion
    {
        public string UbiEmpresa { get; set; } = null!;
        public string UbiCodigo { get; set; } = null!;
        public string? UbiDescripcion { get; set; }
        public string? UbiDireccion { get; set; }
        public string? UbiTelefono { get; set; }
        public string? UbiEncargado { get; set; }
    }
}
