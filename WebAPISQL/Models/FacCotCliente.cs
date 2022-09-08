using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class FacCotCliente
    {
        public string FccEmpresa { get; set; } = null!;
        public int FccCotizacion { get; set; }
        public string FccNombre { get; set; } = null!;
        public string FccDireccion { get; set; } = null!;
        public string FccDireccion1 { get; set; } = null!;
        public string FccTelefono { get; set; } = null!;
        public string FccNit { get; set; } = null!;
    }
}
