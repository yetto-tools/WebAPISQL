using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class Masttran
    {
        public string? TrnpEmpresa { get; set; }
        public int? TrnpCodigo { get; set; }
        public string? TrnpNombre { get; set; }
        public string? TrnpDireccion { get; set; }
        public string? TrnpTelefono { get; set; }
        public string? TrnpCelular { get; set; }
        public string? TrnpEmail { get; set; }
        public string? TrnpContacto { get; set; }
        public string? TrnpUltmovim { get; set; }
    }
}
