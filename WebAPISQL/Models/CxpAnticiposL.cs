using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class CxpAnticiposL
    {
        public string AntlEmpresa { get; set; } = null!;
        public int AntlNumero { get; set; }
        public int AntlCorrel { get; set; }
        public string? AntlTdoc { get; set; }
        public string? AntlDocumento { get; set; }
        public decimal? AntlMonto { get; set; }
        public string? AntlFechaa { get; set; }
        public string? AntlUsuario { get; set; }
    }
}
