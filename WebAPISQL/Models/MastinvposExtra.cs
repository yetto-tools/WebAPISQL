using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class MastinvposExtra
    {
        public string InvxEmpresa { get; set; } = null!;
        public string InvxInventario { get; set; } = null!;
        public string? InvxColor { get; set; }
        public decimal? InvxImpuesto { get; set; }
        public string? InvxChar1 { get; set; }
        public string? InvxChar2 { get; set; }
        public string? InvxChar3 { get; set; }
        public string? InvxChar4 { get; set; }
        public string? InvxChar5 { get; set; }
        public decimal? InvxFloat1 { get; set; }
        public decimal? InvxFloat2 { get; set; }
        public decimal? InvxFloat3 { get; set; }
        public decimal? InvxFloat4 { get; set; }
        public decimal? InvxFloat5 { get; set; }
    }
}
