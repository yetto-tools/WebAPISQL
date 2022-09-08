using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class QsysFelNcreanuVw
    {
        public string? Empresa { get; set; }
        public string? Serie { get; set; }
        public string? Numero { get; set; }
        public string? FechaDocAnular { get; set; }
        public string? FechaAnulacion { get; set; }
        public string? Feluuid { get; set; }
        public string? Nitreceptor { get; set; }
        public string? MotivoAnulacion { get; set; }
        public string? Nitemisor { get; set; }
        public string? Cprefijo { get; set; }
        public string? Cusuario { get; set; }
        public string? Ccorreo { get; set; }
        public string? Cllave { get; set; }
        public string? Ctoken { get; set; }
    }
}
