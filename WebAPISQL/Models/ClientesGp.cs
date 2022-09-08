using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class ClientesGp
    {
        public string? CgpsEmpresa { get; set; }
        public string? CgpsCliente { get; set; }
        public decimal? CgpsLatitud { get; set; }
        public decimal? CgpsLongitud { get; set; }
        public decimal? CgpsAltitud { get; set; }
        public string? CgpsCod { get; set; }
        public string? CgpsGln { get; set; }
    }
}
