using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class BodegasCategorium
    {
        public string BcatEmpresa { get; set; } = null!;
        public int BcatCategoria { get; set; }
        public string BcatDescripcion { get; set; } = null!;
        public string BcatStatus { get; set; } = null!;
    }
}
