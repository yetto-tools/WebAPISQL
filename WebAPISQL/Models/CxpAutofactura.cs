using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class CxpAutofactura
    {
        public string? CxpafEmpresa { get; set; }
        public string? CxpafProveedor { get; set; }
        public string? CxpafSeriefactura { get; set; }
        public string? CxpafFactura { get; set; }
        public string? CxpafUsuario { get; set; }
        public string? CxpafFecha { get; set; }
        public string? CxpafHora { get; set; }
        public string? CxpafObservaciones { get; set; }
    }
}
