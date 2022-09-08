using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class FacRentabilidad
    {
        public string RenEmpresa { get; set; } = null!;
        public int RenRandom { get; set; }
        public int RenCorrel { get; set; }
        public string? RenTienda { get; set; }
        public int? RenCaja { get; set; }
        public string? RenSerie { get; set; }
        public string? RenFecha { get; set; }
        public int? RenFactura { get; set; }
        public int? RenNumero { get; set; }
        public string? RenStatus { get; set; }
        public string? RenLinea { get; set; }
        public string? RenSublinea { get; set; }
        public string? RenInventario { get; set; }
        public string? RenCliente { get; set; }
        public int? RenVendedor { get; set; }
        public decimal? RenTotalVenta { get; set; }
        public decimal? RenDescuentos { get; set; }
        public decimal? RenVentaNeta { get; set; }
        public decimal? RenCostoVenta { get; set; }
        public decimal? RenUtilidad { get; set; }
        public decimal? RenPrcUtil { get; set; }
        public string? RenExtra1 { get; set; }
        public string? RenExtra2 { get; set; }
        public decimal? RenExtra3 { get; set; }
        public decimal? RenExtra4 { get; set; }
    }
}
