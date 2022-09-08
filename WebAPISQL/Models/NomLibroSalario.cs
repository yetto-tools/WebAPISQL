using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class NomLibroSalario
    {
        public string? PagEmpresa { get; set; }
        public string? PagPersonal { get; set; }
        public int? PagAnio { get; set; }
        public int? PagMes { get; set; }
        public decimal? PagMonto { get; set; }
        public decimal? PagDias { get; set; }
        public decimal? PagHorasOrd { get; set; }
        public decimal? PagHorasExtsim { get; set; }
        public decimal? PagHorasExtraex { get; set; }
        public decimal? PagSalarioOrd { get; set; }
        public decimal? PagSalarioExt { get; set; }
        public decimal? PagVacaciones { get; set; }
        public decimal? PagIngresos { get; set; }
        public decimal? PagIgss { get; set; }
        public decimal? PagOtrosDeduc { get; set; }
        public decimal? PagOtrosAnticipo { get; set; }
        public decimal? PagIsr { get; set; }
        public decimal? PagBantrabPresta { get; set; }
        public decimal? PagBonificacion { get; set; }
        public decimal? PagDiasFaltados { get; set; }
        public decimal? PagSeptimos { get; set; }
        public decimal? PagOtrosIngresos { get; set; }
        public decimal? PagSueldo { get; set; }
        public decimal? PagHrexim { get; set; }
        public decimal? PagHrexdo { get; set; }
        public decimal? PagTotHrexsim { get; set; }
        public decimal? PagTotHrexdo { get; set; }
        public decimal? PagAguinaldo { get; set; }
        public decimal? PagBono14 { get; set; }
        public decimal? PagIndemnizacion { get; set; }
        public decimal? PagTotLiquidaciones { get; set; }
    }
}
