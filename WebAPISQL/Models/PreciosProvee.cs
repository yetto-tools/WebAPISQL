using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class PreciosProvee
    {
        public string? PrvEmpresa { get; set; }
        public string? PrvProveedor { get; set; }
        public string? PrvInventario { get; set; }
        public decimal? PrvPrecio { get; set; }
    }
}
