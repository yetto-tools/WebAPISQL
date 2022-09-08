using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class PrLineaProduc
    {
        public string LinproEmpresa { get; set; } = null!;
        public decimal LinproCodigo { get; set; }
        public string LinproNombre { get; set; } = null!;
        public string? LinproUsuarioi { get; set; }
        public string? LinproUsuariom { get; set; }
        public DateTime? LinproFechai { get; set; }
        public DateTime? LinproFecham { get; set; }
    }
}
