using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class DistInvocomclih
    {
        public string DinochEmpresa { get; set; } = null!;
        public int DinochOcnumero { get; set; }
        public int? DinochVendedor { get; set; }
        public string? DinochClicodigo { get; set; }
        public string? DinochFecha { get; set; }
        public string? DinochTipoc { get; set; }
        public string? DinochNumoc { get; set; }
        public string? DinochNotas { get; set; }
        public string? DinochFechaoc { get; set; }
        public string? DinochStatus { get; set; }
        public string? DinochHora { get; set; }
        public decimal? DinochTotal { get; set; }
    }
}
