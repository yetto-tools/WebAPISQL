using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class PrUsuario
    {
        public string UsrEmpresa { get; set; } = null!;
        public decimal UsrCodigo { get; set; }
        public string UsrNombre { get; set; } = null!;
        public string UsrLogin { get; set; } = null!;
        public string UsrPswd { get; set; } = null!;
        public string? UsrLoginDb { get; set; }
        public string? UsrPswdDb { get; set; }
        public string? UsrPerfil { get; set; }
        public decimal UsrRol { get; set; }
        public decimal UsrPuesto { get; set; }
        public decimal UsrDepto { get; set; }
        public string UsrLugar { get; set; } = null!;
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
