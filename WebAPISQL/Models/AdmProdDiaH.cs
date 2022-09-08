using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class AdmProdDiaH
    {
        public string PdhEmpresa { get; set; } = null!;
        public int PdhGrupo { get; set; }
        public string PdhFechaEm { get; set; } = null!;
        public string? PdhJefeGrupo { get; set; }
        public string? PdhAyu1 { get; set; }
        public string? PdhAyu2 { get; set; }
        public string? PdhAyu3 { get; set; }
    }
}
