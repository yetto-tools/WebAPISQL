using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class FelLlafe
    {
        public string FlaEmpresa { get; set; } = null!;
        public string FlaCodigo { get; set; } = null!;
        public string FlaCertificador { get; set; } = null!;
        public string FlaNit { get; set; } = null!;
        public string FlaCorreo { get; set; } = null!;
        public string FlaPrefijo { get; set; } = null!;
        public string FlaUsuario { get; set; } = null!;
        public string FlaLlave { get; set; } = null!;
        public string FlaToken { get; set; } = null!;
    }
}
