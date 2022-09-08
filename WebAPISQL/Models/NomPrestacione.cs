using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class NomPrestacione
    {
        public string PreEmpresa { get; set; } = null!;
        public string PrePersonal { get; set; } = null!;
        public string PreTipo { get; set; } = null!;
        public string? PreFecha { get; set; }
        public int PreAnio { get; set; }
        public int? PreDiasTrab { get; set; }
        public int? PreDiasVac { get; set; }
        public decimal? PrePromDiar { get; set; }
        public decimal? PreDeudas { get; set; }
        public decimal? PreIndemniza { get; set; }
        public decimal? PreVentajas { get; set; }
        public decimal? PreVacaciones { get; set; }
        public decimal? PreAguinaldo { get; set; }
        public decimal? PreBono14 { get; set; }
        public decimal? PreBaseVac { get; set; }
        public decimal? PreDiasliqVac { get; set; }
        public decimal? PreTotalliqVac { get; set; }
        public decimal? PreBaseAgu { get; set; }
        public decimal? PreDiasliqAgu { get; set; }
        public decimal? PreTotalliqAgu { get; set; }
        public decimal? PreBaseB14 { get; set; }
        public decimal? PreDiasliqB14 { get; set; }
        public decimal? PreTotalliqB14 { get; set; }
        public decimal? PreBaseInv { get; set; }
        public decimal? PreDiasliqInv { get; set; }
        public decimal? PreTotalliqInv { get; set; }
        public decimal? PreLiqMotivo { get; set; }
        public decimal? PreLiqMotivo1 { get; set; }
    }
}
