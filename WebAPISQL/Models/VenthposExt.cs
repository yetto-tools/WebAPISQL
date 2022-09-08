using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class VenthposExt
    {
        public string VehxEmpresa { get; set; } = null!;
        public string VehxTienda { get; set; } = null!;
        public int VehxTerminal { get; set; }
        public string? VehxSerie { get; set; }
        public int? VehxFactura { get; set; }
        public string? VehxCliente { get; set; }
        public short? VehxVendedor { get; set; }
        public string? VehxFecha { get; set; }
        public string? VehxFechaVenc { get; set; }
        public string? VehxStatus { get; set; }
        public string? VehxCentro { get; set; }
        public int? VehxDiasCli { get; set; }
        public decimal? VehxDescuento { get; set; }
        public string? VehxDescDescuento { get; set; }
        public decimal? VehxPctglobal { get; set; }
        public int? VehxPeriodomes { get; set; }
        public int? VehxPeriodoano { get; set; }
    }
}
