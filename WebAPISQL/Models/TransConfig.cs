using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class TransConfig
    {
        public string? Transaccion { get; set; }
        public string? Modulo { get; set; }
        public string? Empresa { get; set; }
        public decimal? TipoDocu { get; set; }
        public decimal? TipoTrans { get; set; }
        public string? Descripcion { get; set; }
    }
}
