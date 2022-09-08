using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class DistArtsvenbonbol
    {
        public string BbartEmpresa { get; set; } = null!;
        public int BbartVendedor { get; set; }
        public int BbartLinea { get; set; }
        public string BbartInventario { get; set; } = null!;
    }
}
