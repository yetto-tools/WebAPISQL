using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class QsysDocumento
    {
        public string Empresa { get; set; } = null!;
        public string Tienda { get; set; } = null!;
        public int Terminal { get; set; }
        public int Factura { get; set; }
        public string? Estado { get; set; }
        public DateTime? Fecha { get; set; }
        public decimal? Monto { get; set; }
        public string? TipoCertificacion { get; set; }
        public string? FormaPago { get; set; }
        public string? Exenta { get; set; }
        public string? Tipo { get; set; }
        public string? FirmaElectronica { get; set; }
        public string? ErrorFirma { get; set; }
        public string? FelTipoDocumento { get; set; }
        public string? FelUuid { get; set; }
        public string? FelSerie { get; set; }
        public string? FelNumero { get; set; }
        public DateTime? FelFecha { get; set; }
        public string? FelXml { get; set; }
        public string? FelResponse { get; set; }
        public string? Usuario { get; set; }
        public DateTime? FechaGrabado { get; set; }
        public int? Bitacora { get; set; }
        public bool? XmlGenerado { get; set; }
        public decimal? NotaCredito { get; set; }
    }
}
