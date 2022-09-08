using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class PartidahH
    {
        public string? PhhEmpresa { get; set; }
        public int? PhhAno { get; set; }
        public int? PhhMes { get; set; }
        public int? PhhNumero { get; set; }
        public string? PhhFecha { get; set; }
        public string? PhhDescrip1 { get; set; }
        public string? PhhDescrip2 { get; set; }
        public string? PhhDescrip3 { get; set; }
        public decimal? PhhDebe { get; set; }
        public decimal? PhhHaber { get; set; }
        public string? PhhMoneda { get; set; }
        public decimal? PhhTasa { get; set; }
        public string? PhhUserin { get; set; }
        public string? PhhFein { get; set; }
        public string? PhhUsermo { get; set; }
        public string? PhhFemo { get; set; }
    }
}
