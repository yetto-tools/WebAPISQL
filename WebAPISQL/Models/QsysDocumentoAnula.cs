using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class QsysDocumentoAnula
    {
        public string Empresa { get; set; } = null!;
        public string Tienda { get; set; } = null!;
        public int Terminal { get; set; }
        public int Factura { get; set; }
        public decimal? NotaCredito { get; set; }
        public string? Status { get; set; }
        public string? FelTipoDocumento { get; set; }
        public string? FelUuid { get; set; }
        public string? FelSerie { get; set; }
        public string? FelNumero { get; set; }
        public DateTime? FelFecha { get; set; }
        public string? FelXml { get; set; }
        public string? FelResponse { get; set; }
        public string? Usuario { get; set; }
        public DateTime? FechaGrabado { get; set; }
    }
}
