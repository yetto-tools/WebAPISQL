using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class Empresa
    {
        public string? EmpCodigo { get; set; }
        public string? EmpNombre { get; set; }
        public string? EmpConta { get; set; }
        public decimal? EmpIva { get; set; }
        public string? EmpAgenRetiva { get; set; }
        public decimal? EmpPorcRetiva { get; set; }
        public decimal? EmpBaseRetiva { get; set; }
        public string? EmpNoPatronal { get; set; }
        public string? EmpNoNit { get; set; }
    }
}
