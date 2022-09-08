using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class ProdFormatL
    {
        public string? FrmtlEmpresa { get; set; }
        public string? FrmtlCodigo { get; set; }
        public int? FrmtlPagina { get; set; }
        public int? FrmtlParrafo { get; set; }
        public int? FrmtlLinea { get; set; }
        public string? FrmtlTipo { get; set; }
        public string? FrmtlInventario { get; set; }
    }
}
