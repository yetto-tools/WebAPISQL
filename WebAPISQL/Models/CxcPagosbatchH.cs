using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class CxcPagosbatchH
    {
        public string CxcphEmpresa { get; set; } = null!;
        public string CxcphTipo { get; set; } = null!;
        public int CxcphNumero { get; set; }
        public string CxcphFecha { get; set; } = null!;
        public string CxcphStatus { get; set; } = null!;
        public string CxcphArchivo { get; set; } = null!;
        public string CxcphChar { get; set; } = null!;
        public string CxcphCtienda { get; set; } = null!;
        public int CxcphCterminal { get; set; }
        public decimal CxcphMonto { get; set; }
        public int CxcphNfac { get; set; }
        public decimal CxcphFacmonto { get; set; }
        public int CxcphNdev { get; set; }
        public decimal CxcphDevmonto { get; set; }
        public decimal CxcphLiquido { get; set; }
        public decimal CxcphPagos { get; set; }
        public decimal CxcphBasereten { get; set; }
        public decimal CxcphDif { get; set; }
        public decimal CxcphDif2 { get; set; }
        public int CxcphFacinexis { get; set; }
        public int CxcphFacsinsaldo { get; set; }
        public string CxcphObserva { get; set; } = null!;
        public decimal CxcphSaldo { get; set; }
        public decimal CxcphTotxapli { get; set; }
        public decimal CxcphTotrecxapli { get; set; }
        public decimal CxcphTotnotxapli { get; set; }
        public decimal CxcphTotapli { get; set; }
        public decimal CxcphNrecapli { get; set; }
        public decimal CxcphTotrecapli { get; set; }
        public decimal CxcphNnotapli { get; set; }
        public decimal CxcphTotnotapli { get; set; }
        public decimal CxcphTotaplidif { get; set; }
        public string CxcphUsuarioa { get; set; } = null!;
        public string CxcphFechaa { get; set; } = null!;
        public string CxcphUsuarioc { get; set; } = null!;
        public string CxcphFechac { get; set; } = null!;
        public string CxcphUsuariom { get; set; } = null!;
        public string CxcphFecham { get; set; } = null!;
        public int? CxcphNret { get; set; }
        public decimal? CxcphRetmonto { get; set; }
        public int? CxcphNcre { get; set; }
        public decimal? CxcphCremonto { get; set; }
    }
}
