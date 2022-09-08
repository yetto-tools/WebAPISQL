using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class Contraco
    {
        public string? ContEmpresa { get; set; }
        public string? ContCliente { get; set; }
        public string? ContContrasena { get; set; }
        public string? ContFeRecep { get; set; }
        public string? ContFePago { get; set; }
        public decimal? ContMonto { get; set; }
    }
}
