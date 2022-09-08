using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class InvTitpre
    {
        public string TitEmpresa { get; set; } = null!;
        public string TitInventario { get; set; } = null!;
        public string? TitTitulo1 { get; set; }
        public string? TitTitulo2 { get; set; }
        public string? TitTitulo3 { get; set; }
        public string? TitTitulo4 { get; set; }
        public string? TitTitulo5 { get; set; }
        public string? TitTitulo6 { get; set; }
    }
}
