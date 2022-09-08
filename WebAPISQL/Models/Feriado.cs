using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class Feriado
    {
        public string TfEmpresa { get; set; } = null!;
        public string TfFecha { get; set; } = null!;
        public int? TfSemana { get; set; }
        public int? TfDia { get; set; }
        public int? TfHorasExtras { get; set; }
    }
}
