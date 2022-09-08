using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class QsysContingencium
    {
        public string FecEmpresa { get; set; } = null!;
        public string FecTienda { get; set; } = null!;
        public int FecTerminal { get; set; }
        public string? FecSerie { get; set; }
        public int FecFactura { get; set; }
        public decimal? FecContingencia { get; set; }
        public string? FecUsuario { get; set; }
        public DateTime? FecFecha { get; set; }
    }
}
