using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class CotAutopedido
    {
        public string CotapEmpresa { get; set; } = null!;
        public int? CotapPedido { get; set; }
        public string CotapUsuario { get; set; } = null!;
        public string CotapFecha { get; set; } = null!;
        public string CotapHora { get; set; } = null!;
        public string CotapTipusuario { get; set; } = null!;
        public string CotapObservaciones { get; set; } = null!;
    }
}
