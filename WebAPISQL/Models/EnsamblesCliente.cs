using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class EnsamblesCliente
    {
        public string EnscEmpresa { get; set; } = null!;
        public string EnscInventario { get; set; } = null!;
        public string EnscCliente { get; set; } = null!;
        public string EnscFechai { get; set; } = null!;
        public string EnscFechaf { get; set; } = null!;
        public string EnscInvEnsamble { get; set; } = null!;
        public string? EnscDescripcion { get; set; }
        public decimal? EnscCantidad { get; set; }
        public decimal? EnscPreciov { get; set; }
    }
}
