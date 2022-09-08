using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class QsysfeldetalleVw
    {
        public string? VehEmpresa { get; set; }
        public string? VehTienda { get; set; }
        public int? VehTerminal { get; set; }
        public string? VehSerie { get; set; }
        public int? VehFactura { get; set; }
        public string BienOservicio { get; set; } = null!;
        public int? NumeroLinea { get; set; }
        public decimal? Cantidad { get; set; }
        public string? UnidadMedida { get; set; }
        public string? Descripcion { get; set; }
        public decimal? PrecioUnitario { get; set; }
        public decimal? Precio { get; set; }
        public decimal? Descuento { get; set; }
        public string NombreCorto { get; set; } = null!;
        public string CodigoUnidadGravable { get; set; } = null!;
        public decimal? MontoGravable { get; set; }
        public decimal? MontoImpuesto { get; set; }
        public decimal? Total { get; set; }
    }
}
