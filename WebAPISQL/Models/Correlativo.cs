using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class Correlativo
    {
        public string? CorrEmpresa { get; set; }
        public string? CorrTipo { get; set; }
        public int? CorrNumero { get; set; }
    }
}
