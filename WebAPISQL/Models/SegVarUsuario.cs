using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class SegVarUsuario
    {
        public string VusrEmpresa { get; set; } = null!;
        public string VusrModulo { get; set; } = null!;
        public string VusrVariable { get; set; } = null!;
        public string? VusrUsuario { get; set; }
        public string VusrValor { get; set; } = null!;
    }
}
