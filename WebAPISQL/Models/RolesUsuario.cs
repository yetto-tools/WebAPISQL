using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class RolesUsuario
    {
        public string UserEmpresa { get; set; } = null!;
        public string UserUsuario { get; set; } = null!;
        public string UserRole { get; set; } = null!;
    }
}
