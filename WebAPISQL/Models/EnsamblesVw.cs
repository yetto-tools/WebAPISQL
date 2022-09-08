using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class EnsamblesVw
    {
        public string EnsEmpresa { get; set; } = null!;
        public string EnsInventario { get; set; } = null!;
        public string EnsInvEnsamble { get; set; } = null!;
        public string EnsCliente { get; set; } = null!;
        public string EnsFechai { get; set; } = null!;
        public string EnsFechaf { get; set; } = null!;
        public decimal? EnsCantidad { get; set; }
        public decimal? Preciov { get; set; }
        public int Tipo { get; set; }
    }
}
