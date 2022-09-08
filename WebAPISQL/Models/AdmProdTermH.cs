using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class AdmProdTermH
    {
        public string PrhEmpresa { get; set; } = null!;
        public string PrhInventario { get; set; } = null!;
        public string? PrhDescripcion { get; set; }
        public decimal? PrhLunes { get; set; }
        public decimal? PrhMartes { get; set; }
        public decimal? PrhMiercoles { get; set; }
        public decimal? PrhJueves { get; set; }
        public decimal? PrhViernes { get; set; }
        public decimal? PrhSabado { get; set; }
        public decimal? PrhDomingo { get; set; }
    }
}
