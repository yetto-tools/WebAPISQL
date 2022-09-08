using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class AdmGrpProdL
    {
        public string GrlEmpresa { get; set; } = null!;
        public int GrlGrupo { get; set; }
        public string? GrlJefeGrupo { get; set; }
        public string? GrlAyu1 { get; set; }
        public string? GrlAyu2 { get; set; }
        public string? GrlAyu3 { get; set; }
    }
}
