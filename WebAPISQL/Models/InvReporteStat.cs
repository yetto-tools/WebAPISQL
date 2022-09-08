using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class InvReporteStat
    {
        public string Empresa { get; set; } = null!;
        public string Linea { get; set; } = null!;
        public string LineaNombre { get; set; } = null!;
        public string Sublinea { get; set; } = null!;
        public string SublineaNombre { get; set; } = null!;
        public string Producto { get; set; } = null!;
        public string ProductoNombre { get; set; } = null!;
        public decimal CostoPromedio { get; set; }
        public decimal SaldoInicial { get; set; }
        public decimal ValorSaldoInicial { get; set; }
        public decimal? IngresoCompras { get; set; }
        public decimal? IngresoTotal { get; set; }
        public decimal? IngresoProduccion { get; set; }
        public decimal? IngresoReacon { get; set; }
        public decimal? IngresoOferta { get; set; }
        public decimal? IngresoDevolucion { get; set; }
        public decimal? IngresoOtros { get; set; }
        public decimal? VentasLocales { get; set; }
        public decimal? VentasExportaciones { get; set; }
        public decimal? SalidasTotal { get; set; }
        public decimal? SalidasBonificaciones { get; set; }
        public decimal? SalidasMuestras { get; set; }
        public decimal? SalidasCambios { get; set; }
        public decimal? SalidasTraslados { get; set; }
    }
}
