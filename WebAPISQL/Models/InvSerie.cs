using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class InvSerie
    {
        public string? InvbsEmpresa { get; set; }
        public string? InvbsBodega { get; set; }
        public string? InvbsInventario { get; set; }
        public string? InvbsSerie { get; set; }
        public string? InvbsFechain { get; set; }
        public string? InvbsPoliza { get; set; }
        public string? InvbsUbicacion { get; set; }
    }
}
