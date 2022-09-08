using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class DistInvdevolclih
    {
        public string DindchEmpresa { get; set; } = null!;
        public int DindchDevnumero { get; set; }
        public int? DindchVendedor { get; set; }
        public string? DindchClicodigo { get; set; }
        public string? DindchFecha { get; set; }
        public string? DindchTipdev { get; set; }
        public string? DindchNumrecl { get; set; }
        public string? DindchLoterecl { get; set; }
        public string? DindchFecharecla { get; set; }
        public string? DindchStatus { get; set; }
        public int? DindchNuminven { get; set; }
        public string? DindchTipingreso { get; set; }
        public string? DindchHora { get; set; }
        public decimal? DindchTotal { get; set; }
        public string? DindchTipestado { get; set; }
    }
}
