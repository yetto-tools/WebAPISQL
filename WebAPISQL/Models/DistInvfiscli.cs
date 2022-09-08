using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class DistInvfiscli
    {
        public string DinftEmpresa { get; set; } = null!;
        public int DinftVendedor { get; set; }
        public string DinftClicodigo { get; set; } = null!;
        public string DinftTipoper { get; set; } = null!;
        public string? DinftPersonal { get; set; }
        public string DinftFecha { get; set; } = null!;
        public string? DinftHora { get; set; }
        public string DinftInventario { get; set; } = null!;
        public decimal? DinftBodexi { get; set; }
        public decimal? DinftGonexi { get; set; }
        public decimal? DinftTotexi { get; set; }
    }
}
