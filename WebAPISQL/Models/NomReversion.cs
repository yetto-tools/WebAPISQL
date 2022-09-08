using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class NomReversion
    {
        public string? RevEmpresa { get; set; }
        public string? RevTiponom { get; set; }
        public int? RevMes { get; set; }
        public int? RevAnio { get; set; }
        public string? RevMovant { get; set; }
        public string? RevFecharev { get; set; }
        public string? RevUsuario { get; set; }
        public DateTime? RevHora { get; set; }
    }
}
