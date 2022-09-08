using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class Visita
    {
        public string? VisEmpresa { get; set; }
        public int? VisVisita { get; set; }
        public string? VisCliente { get; set; }
        public string? VisFecha { get; set; }
        public int? VisVendedor { get; set; }
        public string? VisResul1 { get; set; }
        public string? VisResul2 { get; set; }
        public string? VisResul3 { get; set; }
    }
}
