using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class TransacVentasH
    {
        public string TvhEmpresa { get; set; } = null!;
        public string TvhCodigo { get; set; } = null!;
        public string TvhNombre { get; set; } = null!;
        public string TvhTipo { get; set; } = null!;
    }
}
