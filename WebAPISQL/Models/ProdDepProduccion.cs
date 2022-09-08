using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class ProdDepProduccion
    {
        public string DpEmpresa { get; set; } = null!;
        public decimal DpCodigo { get; set; }
        public string DpNombre { get; set; } = null!;
        public string DpCodResponsable { get; set; } = null!;
        public string? DpTipo { get; set; }
        public string? DpCuentaMprima { get; set; }
        public string? DpCuentaMobra { get; set; }
        public string? DpCuentaOvh { get; set; }
        public string? DpCuentaPp { get; set; }
        public string? DpCuentaPt { get; set; }
        public string? DpMovSalida { get; set; }
        public string? DpMovEntrada { get; set; }
        public string? DpCcMovsalida { get; set; }
        public string? DpCcMoventrada { get; set; }
        public decimal? DpCodBodega { get; set; }
        public string DpUsuarioi { get; set; } = null!;
        public string DpUsuariom { get; set; } = null!;
        public DateTime DpFechai { get; set; }
        public DateTime DpFecham { get; set; }
    }
}
