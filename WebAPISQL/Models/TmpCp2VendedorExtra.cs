using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class TmpCp2VendedorExtra
    {
        public string VxtEmpresa { get; set; } = null!;
        public short VxtVendedor { get; set; }
        public string? VxtMoneda { get; set; }
        public int? VxtNivprecio { get; set; }
        public int? VxtNivprecdef { get; set; }
        public decimal? VxtPorctolera { get; set; }
        public decimal? VxtUnidcambio { get; set; }
        public decimal? VxtPorcmulta { get; set; }
        public decimal? VxtMinMulta { get; set; }
        public string? VxtBodega { get; set; }
        public string? VxtMonedadef { get; set; }
        public string? VxtTipoliquidac { get; set; }
        public string? VxtBonificacion { get; set; }
        public decimal? VxtMultfinan { get; set; }
        public string? VxtSistema { get; set; }
        public int? VxtCanal { get; set; }
        public int? VxtTipruta { get; set; }
        public string? VxtClicodigo { get; set; }
        public string? VxtClicodxz { get; set; }
        public decimal? VxtPorfact { get; set; }
        public string? VxtSeguridad { get; set; }
        public string? VxtEnvios { get; set; }
        public decimal? VxtBasecom { get; set; }
        public decimal? VxtFactorpil { get; set; }
        public decimal? VxtFactoraux { get; set; }
        public string? VxtOperasa { get; set; }
        public int? VxtLimiteparr { get; set; }
    }
}
