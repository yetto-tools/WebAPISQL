using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class InvSaldoinicial
    {
        public string InvEmpresa { get; set; } = null!;
        public string InvProducto { get; set; } = null!;
        public string InvAniomes { get; set; } = null!;
        public string InvBodega { get; set; } = null!;
        public decimal InvSaldoinicio { get; set; }
    }
}
