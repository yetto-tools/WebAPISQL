using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class PrAreaNegocio
    {
        public string AreanegEmpresa { get; set; } = null!;
        public decimal AreanegCodigo { get; set; }
        public string? AreanegUsuarioi { get; set; }
        public string? AreanegUsuariom { get; set; }
        public DateTime? AreanegFechai { get; set; }
        public DateTime? AreanegFecham { get; set; }
        public string? AreanegNombre { get; set; }
    }
}
