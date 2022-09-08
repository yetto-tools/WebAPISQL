using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class FacAnulacion
    {
        public string AnulEmpresa { get; set; } = null!;
        public int AnulCorrel { get; set; }
        public string AnulTipo { get; set; } = null!;
        public string? AnulTienda { get; set; }
        public int? AnulTerminal { get; set; }
        public string? AnulSerie { get; set; }
        public int? AnulNumero { get; set; }
        public string? AnulFecha { get; set; }
        public string? AnulCliente { get; set; }
        public short? AnulVendedor { get; set; }
        public decimal? AnulMonto { get; set; }
        public string? AnulMotivo { get; set; }
    }
}
