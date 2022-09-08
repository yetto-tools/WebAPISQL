using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class InvColore
    {
        public string ColEmpresa { get; set; } = null!;
        public string ColColor { get; set; } = null!;
        public string? ColDescripcion { get; set; }
    }
}
