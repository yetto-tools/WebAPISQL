using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class QsysFelHndebVw
    {
        public string? Empresa { get; set; }
        public string? Serie { get; set; }
        public string? Numero { get; set; }
        public string? Enit { get; set; }
        public string? Erazon { get; set; }
        public string? Encomercial { get; set; }
        public string? Edireccion { get; set; }
        public string Ccertifica { get; set; } = null!;
        public string Cprefijo { get; set; } = null!;
        public string Cusuario { get; set; } = null!;
        public string Ccorreo { get; set; } = null!;
        public string Cllave { get; set; } = null!;
        public string Ctoken { get; set; } = null!;
        public string? Fecha { get; set; }
        public string Moneda { get; set; } = null!;
        public string IsWalmart { get; set; } = null!;
        public string? Rnit { get; set; }
        public string? Rnombre { get; set; }
        public string? Rdireccion { get; set; }
        public string RcodigoPostal { get; set; } = null!;
        public string Rmunicipio { get; set; } = null!;
        public string Rdepartamento { get; set; } = null!;
        public string Rpais { get; set; } = null!;
        public string? Rcorreo { get; set; }
        public string TipoDoc { get; set; } = null!;
        public string Eregimen { get; set; } = null!;
        public string Ecpostal { get; set; } = null!;
        public string Emunicipio { get; set; } = null!;
        public string Edepartamento { get; set; } = null!;
        public string Epais { get; set; } = null!;
        public decimal? Nmonto { get; set; }
        public string? Descripcion { get; set; }
        public string? Fuuid { get; set; }
        public string? Ffecha { get; set; }
        public decimal? MontoSinIva { get; set; }
        public decimal? MontoIva { get; set; }
    }
}
