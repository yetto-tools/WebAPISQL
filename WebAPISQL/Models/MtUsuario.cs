using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class MtUsuario
    {
        public string UsrEmpresa { get; set; } = null!;
        public decimal UsrCodigo { get; set; }
        public string UsrNombre { get; set; } = null!;
        public string UsrLogin { get; set; } = null!;
        public string UsrPswd { get; set; } = null!;
        public string UsrPerfil { get; set; } = null!;
        public string UsrRol { get; set; } = null!;
        public decimal? UsrPuesto { get; set; }
        public decimal? UsrDepto { get; set; }
        public string? UsrLugar { get; set; }
        public decimal UsrEstado { get; set; }
        public string? UsrEmail { get; set; }
        public decimal? UsrJefe { get; set; }
        public decimal? UsrConsola { get; set; }
        public string? UsrFolderRep { get; set; }
        public string UsrUsuarioi { get; set; } = null!;
        public string UsrUsuariom { get; set; } = null!;
        public DateTime UsrFechai { get; set; }
        public DateTime UsrFecham { get; set; }
    }
}
