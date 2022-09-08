using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class DistInvclivend
    {
        public string DincvEmpresa { get; set; } = null!;
        public int DincvVendedor { get; set; }
        public int DincvLinea { get; set; }
        public string? DincvClicodigo { get; set; }
        public string? DincvEtiqueta { get; set; }
        public string? DincvFisicoref { get; set; }
        public string? DincvEntfrec { get; set; }
        public string? DincvEntlun { get; set; }
        public string? DincvEntmar { get; set; }
        public string? DincvEntmie { get; set; }
        public string? DincvEntjue { get; set; }
        public string? DincvEntvie { get; set; }
        public string? DincvEntsab { get; set; }
        public string? DincvEntdom { get; set; }
        public int? DincvMesentd1 { get; set; }
        public int? DincvMesentd2 { get; set; }
        public int? DincvMesentd3 { get; set; }
        public string? DincvVisfrec { get; set; }
        public string? DincvVislun { get; set; }
        public string? DincvVismar { get; set; }
        public string? DincvVismie { get; set; }
        public string? DincvVisjue { get; set; }
        public string? DincvVisvie { get; set; }
        public string? DincvVissab { get; set; }
        public string? DincvVisdom { get; set; }
        public int? DincvMesvisd1 { get; set; }
        public int? DincvMesvisd2 { get; set; }
        public int? DincvMesvisd3 { get; set; }
    }
}
