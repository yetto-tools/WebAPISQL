using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class PrimerLune
    {
        public string TlEmpresa { get; set; } = null!;
        public string TlFecha { get; set; } = null!;
        public int? TlSemana { get; set; }
        public int? TlDia { get; set; }
        public int? TlHorasExtras { get; set; }
    }
}
