using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class VerifFecha
    {
        public string VerEmpresa { get; set; } = null!;
        public string VerModulo { get; set; } = null!;
        public int VerAno { get; set; }
        public int VerMes { get; set; }
    }
}
