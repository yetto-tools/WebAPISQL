using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class NomSuspension
    {
        public string? SusEmpresa { get; set; }
        public int? SusNumero { get; set; }
        public string? SusPersonal { get; set; }
        public string? SusTipo { get; set; }
        public string? SusInicio { get; set; }
        public string? SusFinal { get; set; }
        public string? SusDescripcion { get; set; }
        public string? SusDescripcion1 { get; set; }
        public string? SusDescuentasep { get; set; }
        public string? SusDescuentadia { get; set; }
    }
}
