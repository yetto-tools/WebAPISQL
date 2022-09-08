using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class PrFuncionalidad
    {
        public string FunEmpresa { get; set; } = null!;
        public string FunCodFuncionalidad { get; set; } = null!;
        public string? FunPagina { get; set; }
        public string? FunCodigo { get; set; }
        public string FunNombreMenu { get; set; } = null!;
        public string FunMenuPadre { get; set; } = null!;
        public string? FunCodPadre { get; set; }
        public string? FunNivel { get; set; }
        public string FunEstructura { get; set; } = null!;
        public string? FunTituloPagina { get; set; }
    }
}
