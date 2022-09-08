using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class SublineasVta
    {
        public string SvtEmpresa { get; set; } = null!;
        public string? SvtLineavta { get; set; }
        public string SvtSublineavta { get; set; } = null!;
        public string? SvtNombre { get; set; }
        public decimal? SvtUtilidad { get; set; }
    }
}
