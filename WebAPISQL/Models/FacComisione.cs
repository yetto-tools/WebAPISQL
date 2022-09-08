using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class FacComisione
    {
        public string FceEmpresa { get; set; } = null!;
        public int FceVendedor { get; set; }
        public string FceFecha { get; set; } = null!;
        public decimal FcePctgana { get; set; }
    }
}
