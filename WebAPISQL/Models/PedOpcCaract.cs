using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class PedOpcCaract
    {
        public string CocEmpresa { get; set; } = null!;
        public string CocCodigo { get; set; } = null!;
        public string CocNombreCar { get; set; } = null!;
        public int? CocNumero { get; set; }
        public string? CocNombre { get; set; }
    }
}
