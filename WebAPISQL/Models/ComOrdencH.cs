using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class ComOrdencH
    {
        public string? OrdchEmpresa { get; set; }
        public int? OrdchNumero { get; set; }
        public string? OrdchFecha { get; set; }
        public string? OrdchProveedor { get; set; }
        public int? OrdchCotizacion { get; set; }
        public string? OrdchCotizaprov { get; set; }
        public string? OrdchFdespacho { get; set; }
        public string? OrdchFllegada { get; set; }
        public decimal? OrdchValor { get; set; }
        public decimal? OrdchDescuento { get; set; }
        public string? OrdchMoneda { get; set; }
        public decimal? OrdchTasa { get; set; }
        public int? OrdchLiquidacion { get; set; }
        public string? OrdchFactura { get; set; }
        public string? OrdchEnviada { get; set; }
        public string? OrdchCerrada { get; set; }
        public string? OrdchUsuarioc { get; set; }
        public string? OrdchFechac { get; set; }
        public string? OrdchUsuariom { get; set; }
        public string? OrdchFecham { get; set; }
        public string? OrdchImpresion { get; set; }
    }
}
