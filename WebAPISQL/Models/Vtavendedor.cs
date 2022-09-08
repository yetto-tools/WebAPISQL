using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class Vtavendedor
    {
        public string? VenvEmpresa { get; set; }
        public short? VenvVendedor { get; set; }
        public int? VenvAnio { get; set; }
        public int? VenvMes { get; set; }
        public decimal? VenvVtatot { get; set; }
        public decimal? VenvComision { get; set; }
    }
}
