using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class PagosL
    {
        public string? PaglEmpresa { get; set; }
        public string? PaglTipo { get; set; }
        public int? PaglNumero { get; set; }
        public int? PaglCorrel { get; set; }
        public string? PaglTdoc { get; set; }
        public string? PaglDocumento { get; set; }
        public decimal? PaglMonto { get; set; }
    }
}
