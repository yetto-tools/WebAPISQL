using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class HistCli
    {
        public string? HicEmpresa { get; set; }
        public string? HicCliente { get; set; }
        public string? HicVehNumero { get; set; }
        public string? HicVehFecha { get; set; }
        public decimal? HicVehTotal { get; set; }
        public decimal? HicVehDescuen { get; set; }
    }
}
