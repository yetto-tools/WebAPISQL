using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class PrFunModulo
    {
        public string FunmEmpresa { get; set; } = null!;
        public decimal FunmTipoModulo { get; set; }
        public int FunmEstado { get; set; }
        public string FunmCodFuncionalidad { get; set; } = null!;
    }
}
