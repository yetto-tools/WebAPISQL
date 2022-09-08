using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class EnsamblesClaCliente
    {
        public string EnccEmpresa { get; set; } = null!;
        public string EnccInventario { get; set; } = null!;
        public string EnccClasifica { get; set; } = null!;
        public string EnccFechai { get; set; } = null!;
        public string EnccFechaf { get; set; } = null!;
        public string EnccInvEnsamble { get; set; } = null!;
        public string? EnccDescripcion { get; set; }
        public decimal? EnccCantidad { get; set; }
        public decimal? EnccPreciov { get; set; }
    }
}
