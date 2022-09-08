using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class PedCaracterist
    {
        public string CrtEmpresa { get; set; } = null!;
        public string CrtCodigo { get; set; } = null!;
        public int CrtNumero { get; set; }
        public string? CrtNombreSet { get; set; }
        public string? CrtNombreCar { get; set; }
        public string? CrtStatus { get; set; }
        public string? CrtOpcExcl { get; set; }
        public string? CrtObligatorio { get; set; }
        public string? CrtTexto1 { get; set; }
        public string? CrtTexto2 { get; set; }
        public string? CrtClasif1 { get; set; }
        public string? CrtClasif2 { get; set; }
    }
}
