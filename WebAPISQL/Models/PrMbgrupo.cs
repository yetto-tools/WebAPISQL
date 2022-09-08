using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class PrMbgrupo
    {
        public string MbgEmpresa { get; set; } = null!;
        public decimal MbgCodigo { get; set; }
        public decimal MbgUsuario { get; set; }
        public decimal MbgGrupo { get; set; }
        public decimal MbgTipo { get; set; }
        public decimal MbgJefe { get; set; }
        public decimal? MbgEjecucion { get; set; }
        public decimal MbgEstado { get; set; }
        public string MbgUsuarioi { get; set; } = null!;
        public string MbgUsuariom { get; set; } = null!;
        public DateTime MbgFechai { get; set; }
        public DateTime MbgFecham { get; set; }
    }
}
