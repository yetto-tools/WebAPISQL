using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class Conparh
    {
        public string? PahEmpresa { get; set; }
        public int? PahMes { get; set; }
        public int? PahNumero { get; set; }
        public string? PahFecha { get; set; }
        public string? PahDescrip1 { get; set; }
        public string? PahDescrip2 { get; set; }
        public string? PahDescrip3 { get; set; }
        public decimal? PahDebe { get; set; }
        public decimal? PahHaber { get; set; }
        public string? PahMoneda { get; set; }
        public decimal? PahTasa { get; set; }
        public string? PahUsuarioc { get; set; }
        public string? PahFechac { get; set; }
        public string? PahUsuariom { get; set; }
        public string? PahFecham { get; set; }
    }
}
