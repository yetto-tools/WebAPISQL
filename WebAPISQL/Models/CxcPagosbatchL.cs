using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class CxcPagosbatchL
    {
        public string CxcplEmpresa { get; set; } = null!;
        public string CxcplTipo { get; set; } = null!;
        public int CxcplNumero { get; set; }
        public int CxcplLinea { get; set; }
        public string CxcplCtipdoc { get; set; } = null!;
        public string CxcplCdocumento { get; set; } = null!;
        public string CxcplCfecha { get; set; } = null!;
        public decimal CxcplCmonto { get; set; }
        public string CxcplFtienda { get; set; } = null!;
        public int CxcplFterminal { get; set; }
        public string CxcplFserie { get; set; } = null!;
        public int CxcplFactura { get; set; }
        public string CxcplFelserie { get; set; } = null!;
        public string CxcplFelnumero { get; set; } = null!;
        public string CxcplFfecha { get; set; } = null!;
        public decimal CxcplFmonto { get; set; }
        public decimal CxcplFsaldo { get; set; }
        public decimal CxcplFpago { get; set; }
        public decimal CxcplFsfinal { get; set; }
        public decimal CxcplFsaldopago { get; set; }
        public string CxcplClicodigo { get; set; } = null!;
        public string CxcplRserie { get; set; } = null!;
        public int CxcplRecibo { get; set; }
        public string CxcplRfecha { get; set; } = null!;
        public decimal CxcplRmonto { get; set; }
        public string CxcplNtipo { get; set; } = null!;
        public int CxcplNnota { get; set; }
        public string CxcplNfecha { get; set; } = null!;
        public decimal CxcplNmonto { get; set; }
        public decimal CxcplMontor { get; set; }
        public decimal CxcplMonton { get; set; }
        public decimal CxcplRetfisica { get; set; }
        public decimal CxcplRetcalc { get; set; }
        public string CxcplErr { get; set; } = null!;
        public int? CxcplCfila { get; set; }
        public decimal? CxcplCvalor { get; set; }
        public decimal? CxcplCdebito { get; set; }
        public string? CxcplCdocnum1 { get; set; }
    }
}
