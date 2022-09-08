using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class BcoMaestro
    {
        public string? BcoEmpresa { get; set; }
        public string? BcoCuentabco { get; set; }
        public string? BcoNombre { get; set; }
        public string? BcoNumcuenta { get; set; }
        public string? BcoCuenta { get; set; }
        public decimal? BcoSaldo { get; set; }
        public string? BcoMoneda { get; set; }
        public string? BcoFormato { get; set; }
    }
}
