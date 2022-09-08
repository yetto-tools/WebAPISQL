using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class Clientesporvendedor
    {
        public string? CpvEmpresa { get; set; }
        public int? CpvVendedor { get; set; }
        public string? CpvCliente { get; set; }
    }
}
