using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class InvRequisicionl
    {
        public string? ReqlEmpresa { get; set; }
        public int? ReqlNumero { get; set; }
        public int? ReqlLinea { get; set; }
        public string? ReqlInventario { get; set; }
        public decimal? ReqlCantidad { get; set; }
        public decimal? ReqlTotal { get; set; }
        public decimal? ReqlPromedioU { get; set; }
    }
}
