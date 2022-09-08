using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class Lactar
    {
        public string NlEmpresa { get; set; } = null!;
        public string NlPersonal { get; set; } = null!;
        public string NlFecha { get; set; } = null!;
        public string? NlFechaal { get; set; }
        public string? NlHora { get; set; }
        public string? NlHora1 { get; set; }
    }
}
