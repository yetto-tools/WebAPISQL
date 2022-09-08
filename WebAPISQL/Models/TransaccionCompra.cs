using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class TransaccionCompra
    {
        public string? TrcEmpresa { get; set; }
        public string? TrcCodigo { get; set; }
        public string? TrcCuenta { get; set; }
        public string? TrcCampo { get; set; }
        public string? TrcDebehaber { get; set; }
    }
}
