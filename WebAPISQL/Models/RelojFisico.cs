using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class RelojFisico
    {
        public string RfEmpresa { get; set; } = null!;
        public string RfPersonal { get; set; } = null!;
        public int? RfAno { get; set; }
        public int? RfMes { get; set; }
        public string? RfFecha { get; set; }
        public int? RfHoras { get; set; }
    }
}
