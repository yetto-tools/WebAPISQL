using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class CentroHistorico
    {
        public string? CenhEmpresa { get; set; }
        public int? CenhAno { get; set; }
        public string? CenhCentro { get; set; }
        public string? CenhDescripcion { get; set; }
    }
}
