using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class AjusExtraCxp
    {
        public string AjuxEmpresa { get; set; } = null!;
        public int AjuxNumero { get; set; }
        public string? AjuxClasificacion { get; set; }
        public string? AjuxBodega { get; set; }
        public string? AjuxFechar { get; set; }
    }
}
