using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class InvListaPrecio
    {
        public string LstEmpresa { get; set; } = null!;
        public int LstPagina { get; set; }
        public int LstCorrel { get; set; }
        public string LstTipo { get; set; } = null!;
        public string LstCodigo { get; set; } = null!;
    }
}
