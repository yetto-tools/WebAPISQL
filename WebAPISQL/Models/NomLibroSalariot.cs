using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class NomLibroSalariot
    {
        public string? PagtEmpresa { get; set; }
        public string? PagtPersonal { get; set; }
        public int? PagtAnio { get; set; }
        public int? PagtMes { get; set; }
        public decimal? PagtMonto { get; set; }
        public int? PagtDias { get; set; }
        public int? PagtHorasOrd { get; set; }
        public int? PagtHorasExtsim { get; set; }
        public int? PagtHorasExtraex { get; set; }
        public decimal? PagtSalarioOrd { get; set; }
        public decimal? PagtSalarioExt { get; set; }
        public decimal? PagtVacaciones { get; set; }
        public decimal? PagtIngresos { get; set; }
        public decimal? PagtIgss { get; set; }
        public decimal? PagtOtrosDeduc { get; set; }
        public decimal? PagtOtrosAnticipo { get; set; }
        public decimal? PagtIsr { get; set; }
        public decimal? PagtBantrabPresta { get; set; }
        public decimal? PagtBonificacion { get; set; }
        public int? PagtDiasFaltados { get; set; }
        public int? PagtSeptimos { get; set; }
        public decimal? PagtOtrosIngresos { get; set; }
        public decimal? PagtSueldo { get; set; }
        public decimal? PagtHrexim { get; set; }
        public decimal? PagtHrexdo { get; set; }
        public decimal? PagtTotHrexsim { get; set; }
        public decimal? PagtTotHrexdo { get; set; }
        public decimal? PagtAguinaldo { get; set; }
        public decimal? PagtBono14 { get; set; }
        public decimal? PagtIndemnizacion { get; set; }
        public decimal? PagtTotLiquidaciones { get; set; }
    }
}
