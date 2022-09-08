using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class BcoMovExtra
    {
        public string ChxEmpresa { get; set; } = null!;
        public string ChxCuentabco { get; set; } = null!;
        public int ChxNumero { get; set; }
        public string ChxTipo { get; set; } = null!;
        public string ChxElaborado { get; set; } = null!;
        public string ChxRevisado { get; set; } = null!;
        public string ChxAutorizado { get; set; } = null!;
        public string ChxExtra1 { get; set; } = null!;
        public string ChxExtra2 { get; set; } = null!;
        public decimal ChxExtra3 { get; set; }
        public decimal ChxExtra4 { get; set; }
        public string? ChxDesc2 { get; set; }
        public string? ChxDesc3 { get; set; }
    }
}
