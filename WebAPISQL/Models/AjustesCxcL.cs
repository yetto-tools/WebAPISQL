using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class AjustesCxcL
    {
        public string? AjclEmpresa { get; set; }
        public string? AjclTipo { get; set; }
        public int? AjclNumero { get; set; }
        public int? AjclLinea { get; set; }
        public string? AjclReferencia { get; set; }
        public string? AjclTienda { get; set; }
        public int? AjclTerminal { get; set; }
        public int? AjclDocumento { get; set; }
        public decimal? AjclMonto { get; set; }
    }
}
