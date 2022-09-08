using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class PrCcxpp
    {
        public string CcppEmpresa { get; set; } = null!;
        public decimal CcppCodigo { get; set; }
        public decimal CcppVersion { get; set; }
        public decimal CcppPartida { get; set; }
        public string CcppCtaContable { get; set; } = null!;
        public decimal CcppEstado { get; set; }
        public string CcppUsuarioi { get; set; } = null!;
        public string CcppUsuariom { get; set; } = null!;
        public DateTime CcppFechai { get; set; }
        public DateTime CcppFecham { get; set; }
    }
}
