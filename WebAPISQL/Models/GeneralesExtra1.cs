using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class GeneralesExtra1
    {
        public string Gx1Empresa { get; set; } = null!;
        public string Gx1Tienda { get; set; } = null!;
        public int Gx1Terminal { get; set; }
        public string? Gx1Serie { get; set; }
        public string? Gx1Autoriza { get; set; }
        public string? Gx1Fauto { get; set; }
        public string? Gx1Tipodoc { get; set; }
        public string? Gx1Status { get; set; }
        public int? Gx1Rango1 { get; set; }
        public int? Gx1Rango2 { get; set; }
        public int? Gx1Nfactura { get; set; }
        public string? Gx1Femision { get; set; }
        public string? Gx1Tipo { get; set; }
        public string? Gx1Descrip { get; set; }
        public string? Gx1Generaiva { get; set; }
        public string? Gx1Estado { get; set; }
    }
}
