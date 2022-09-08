using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class MastAsigTal
    {
        public string? MatEmpresa { get; set; }
        public int? MatCodigo { get; set; }
        public string? MatCobrador { get; set; }
        public string? MatFecha { get; set; }
        public int? MatNumtalonario { get; set; }
        public string? MatSerie { get; set; }
        public int? MatNuminicial { get; set; }
        public int? MatNumfinal { get; set; }
        public int? MatActinicial { get; set; }
        public int? MatActfinal { get; set; }
        public int? MatDevinicial { get; set; }
        public int? MatDevfinal { get; set; }
        public string? MatStatus { get; set; }
        public string? MatDescripcion { get; set; }
    }
}
