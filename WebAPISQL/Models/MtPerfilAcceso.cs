using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class MtPerfilAcceso
    {
        public string PrfEmpresa { get; set; } = null!;
        public string PrfNombrePerfil { get; set; } = null!;
        public string PrfNombrePagina { get; set; } = null!;
        public string PrfLectura { get; set; } = null!;
        public string PrfEscritura { get; set; } = null!;
        public string PrfModificacion { get; set; } = null!;
        public string PrfEliminacion { get; set; } = null!;
        public string? PrfUsuarioi { get; set; }
        public DateTime? PrfFechai { get; set; }
        public string? PrfUsuariom { get; set; }
        public DateTime? PrfFecham { get; set; }
    }
}
