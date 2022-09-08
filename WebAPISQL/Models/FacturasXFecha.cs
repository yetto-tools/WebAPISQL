using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class FacturasXFecha
    {
        public string FacxEmpresa { get; set; } = null!;
        public int? FacxCorrelativo { get; set; }
        public string FacxTienda { get; set; } = null!;
        public int? FacxTerminal { get; set; }
        public string FacxSerie { get; set; } = null!;
        public decimal? FacxFactura { get; set; }
        public string? FacxFecemi { get; set; }
        public string? FacxFecven { get; set; }
        public string? FacxCliente { get; set; }
        public string? FacxNomcli { get; set; }
        public string? FacxFpago { get; set; }
        public string? FacxStatus { get; set; }
        public decimal? FacxValor { get; set; }
    }
}
