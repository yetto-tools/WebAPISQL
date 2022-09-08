using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class LineasVta
    {
        public string LvtEmpresa { get; set; } = null!;
        public string LvtLineavta { get; set; } = null!;
        public string? LvtNombre { get; set; }
        public decimal? LvtUtilidad { get; set; }
    }
}
