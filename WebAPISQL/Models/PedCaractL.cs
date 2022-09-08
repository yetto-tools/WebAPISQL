using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class PedCaractL
    {
        public string CrlEmpresa { get; set; } = null!;
        public string? CrlSerie { get; set; }
        public int CrlPedido { get; set; }
        public int CrlLinea { get; set; }
        public string CrlCodCaract { get; set; } = null!;
        public int CrlNumCaract { get; set; }
        public string? CrlValCaract { get; set; }
        public string? CrlInventario { get; set; }
        public string? CrlDescAdic { get; set; }
    }
}
