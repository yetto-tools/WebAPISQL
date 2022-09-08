using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class MovBol
    {
        public string? MblEmpresa { get; set; }
        public int? MblNumero { get; set; }
        public int? MblLinea { get; set; }
        public string? MblInventario { get; set; }
        public decimal? MblCantidad { get; set; }
        public decimal? MblCosto { get; set; }
        public string? MblFechat { get; set; }
        public string? MblSerie { get; set; }
        public string? MblSerieflag { get; set; }
        public string? MblFechav { get; set; }
    }
}
