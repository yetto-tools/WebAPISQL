using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class ClasificaCliente
    {
        public string ClaEmpresa { get; set; } = null!;
        public string ClaCodigo { get; set; } = null!;
        public string? ClaDescripcion { get; set; }
        public string? ClaUsuarioc { get; set; }
    }
}
