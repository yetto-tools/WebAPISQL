using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class PagosH
    {
        public string? PaghEmpresa { get; set; }
        public string? PaghTipo { get; set; }
        public int? PaghNumero { get; set; }
        public string? PaghProveedor { get; set; }
        public string? PaghFecha { get; set; }
        public decimal? PaghMonto { get; set; }
        public string? PaghCuenta { get; set; }
        public string? PaghBanco { get; set; }
        public string? PaghCheque { get; set; }
        public string? PaghStatus { get; set; }
        public string? PaghMoneda { get; set; }
        public decimal? PaghTasacam { get; set; }
        public string? PaghImpresion { get; set; }
    }
}
