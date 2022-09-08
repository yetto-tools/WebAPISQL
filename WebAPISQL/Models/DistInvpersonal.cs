using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class DistInvpersonal
    {
        public string DinpEmpresa { get; set; } = null!;
        public string DinpPersonal { get; set; } = null!;
        public string? DinpNombres { get; set; }
        public string? DinpApellidos { get; set; }
        public string? DinpTipo { get; set; }
    }
}
