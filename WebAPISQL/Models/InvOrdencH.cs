using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class InvOrdencH
    {
        public string? OrdchEmpresa { get; set; }
        public int? OrdchNumero { get; set; }
        public string? OrdchFecha { get; set; }
        public string? OrdchProveedor { get; set; }
        public string? OrdchNumCotiza { get; set; }
        public string? OrdchDespacho { get; set; }
        public string? OrdchLlegada { get; set; }
        public decimal? OrdchValor { get; set; }
        public string? OrdchMoneda { get; set; }
        public decimal? OrdchTasa { get; set; }
        public int? OrdchLiquidacion { get; set; }
        public string? OrdchTiempoest { get; set; }
        public string? OrdchUsuarioc { get; set; }
        public string? OrdchFechac { get; set; }
        public string? OrdchUsuariom { get; set; }
        public string? OrdchFecham { get; set; }
        public string? OrdchImpresion { get; set; }
    }
}
