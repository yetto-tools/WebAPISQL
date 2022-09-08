using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class Profile
    {
        public string? PrfEmpresa { get; set; }
        public string? PrfUsuario { get; set; }
        public string? PrfModulo { get; set; }
        public string? PrfOpcion { get; set; }
        public string? PrfParam { get; set; }
    }
}
