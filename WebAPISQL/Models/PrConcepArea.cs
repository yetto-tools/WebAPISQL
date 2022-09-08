using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class PrConcepArea
    {
        public string ConareaEmpresa { get; set; } = null!;
        public decimal ConareaConcepto { get; set; }
        public decimal ConareaArea { get; set; }
        public string? ConareaUsuarioi { get; set; }
        public string? ConareaUsuariom { get; set; }
        public DateTime? ConareaFechai { get; set; }
        public DateTime? ConareaFecham { get; set; }
    }
}
