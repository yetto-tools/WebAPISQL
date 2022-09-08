using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class Contrasena
    {
        public string? ContEmpresa { get; set; }
        public int? ContContrasena { get; set; }
        public string? ContProveedor { get; set; }
        public string? ContFecha { get; set; }
        public decimal? ContMonto { get; set; }
    }
}
