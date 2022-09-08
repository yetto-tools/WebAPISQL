using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class ClasiCuentasCli
    {
        public string ClcEmpresa { get; set; } = null!;
        public string ClcCodigo { get; set; } = null!;
        public string? ClcDescripcion { get; set; }
        public string? ClcUsuarioc { get; set; }
    }
}
