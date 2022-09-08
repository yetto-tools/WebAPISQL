using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class PrGrupo
    {
        public string GrpEmpresa { get; set; } = null!;
        public decimal GrpCodigo { get; set; }
        public string GrpNombre { get; set; } = null!;
        public decimal GrpArea { get; set; }
        public decimal GrpUsuario { get; set; }
        public decimal GrpTipo { get; set; }
        public decimal GrpEstado { get; set; }
        public string GrpDireccion { get; set; } = null!;
        public string? GrpContacto { get; set; }
        public string? GrpMail { get; set; }
        public string? GrpBuzon { get; set; }
        public string GrpUsuarioi { get; set; } = null!;
        public string GrpUsuariom { get; set; } = null!;
        public DateTime GrpFechai { get; set; }
        public DateTime GrpFecham { get; set; }
    }
}
