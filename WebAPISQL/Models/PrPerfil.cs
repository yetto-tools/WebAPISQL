using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class PrPerfil
    {
        public string PrfEmpresa { get; set; } = null!;
        public string PrfNombrePerfil { get; set; } = null!;
        public string PrfNombrePagina { get; set; } = null!;
        public string? PrfLectura { get; set; }
        public string? PrfEscritura { get; set; }
        public string? PrfModificacion { get; set; }
        public string? PrfEliminacion { get; set; }
        public string? PrfUsuarioi { get; set; }
        public string? PrfUsuariom { get; set; }
        public DateTime? PrfFechai { get; set; }
        public DateTime? PrfFecham { get; set; }
    }
}
