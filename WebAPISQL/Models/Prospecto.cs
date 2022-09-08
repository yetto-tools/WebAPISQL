using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class Prospecto
    {
        public string? ProsEmpresa { get; set; }
        public int? ProsCorrelativo { get; set; }
        public string? ProsNombre { get; set; }
        public string? ProsIndustria { get; set; }
        public string? ProsUbicacion { get; set; }
        public string? ProsFecha { get; set; }
        public int? ProsVendedor { get; set; }
        public string? ProsContacto { get; set; }
        public string? ProsTelefono { get; set; }
        public string? ProsFax { get; set; }
        public string? ProsEmail { get; set; }
    }
}
