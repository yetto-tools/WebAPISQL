using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class PrEmpresa
    {
        public string EmpEmpresa { get; set; } = null!;
        public string EmpNombre { get; set; } = null!;
        public decimal EmpVersionActiva { get; set; }
        public string? EmpModuloq { get; set; }
        public string? EmpMonedaq { get; set; }
        public string? EmpDescripcion { get; set; }
        public string EmpMesiniCiclo { get; set; } = null!;
        public string EmpMonedaBase { get; set; } = null!;
        public string? EmpMonedaReferencia { get; set; }
        public string? EmpMonedaEjecucion { get; set; }
        public decimal? EmpCodmonedaBase { get; set; }
        public decimal? EmpCodmonedaReferencia { get; set; }
        public decimal? EmpCodmonedaEjecucion { get; set; }
        public string? EmpNivelsubp { get; set; }
        public string EmpUsuarioi { get; set; } = null!;
        public DateTime EmpFechai { get; set; }
        public string EmpUsuariom { get; set; } = null!;
        public DateTime EmpFecham { get; set; }
        public decimal EmpCodigo { get; set; }
    }
}
