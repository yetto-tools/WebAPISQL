using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class TempPartida
    {
        public string TmpEmpresa { get; set; } = null!;
        public int TmpMes { get; set; }
        public int? TmpNumAnt { get; set; }
        public int? TmpNumAct { get; set; }
    }
}
