using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class Actualizacion
    {
        public string ActgEmpresa { get; set; } = null!;
        public string ActgFuncion { get; set; } = null!;
        public string? ActgFecha { get; set; }
        public string? ActgHora { get; set; }
        public string? ActgDocumento { get; set; }
        public int? ActgBatch { get; set; }
        public string? ActgUsuario { get; set; }
    }
}
