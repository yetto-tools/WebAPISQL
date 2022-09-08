using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class MantDificultad
    {
        public string MdifEmpresa { get; set; } = null!;
        public string MdifCodigo { get; set; } = null!;
        public string? MdifDescrip { get; set; }
    }
}
