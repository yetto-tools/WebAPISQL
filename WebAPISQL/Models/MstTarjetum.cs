using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class MstTarjetum
    {
        public string? MsttEmpresa { get; set; }
        public string? MsttTarjeta { get; set; }
        public string? MsttNombre { get; set; }
        public string? MsttAfiliacion { get; set; }
        public decimal? MsttLimite { get; set; }
        public decimal? MsttPorcentaje { get; set; }
    }
}
