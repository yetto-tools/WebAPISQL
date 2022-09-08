using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class QsysfelheaderVw
    {
        public string? VehEmpresa { get; set; }
        public string? VehTienda { get; set; }
        public int? VehTerminal { get; set; }
        public string? VehSerie { get; set; }
        public int? VehFactura { get; set; }
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
        public string? Fvenc { get; set; }
        public int? DiasCredito { get; set; }
        public string? Concred1 { get; set; }
        public string Eregimen { get; set; } = null!;
        public string Ecpostal { get; set; } = null!;
        public string Emunicipio { get; set; } = null!;
        public string Edepartamento { get; set; } = null!;
        public string Epais { get; set; } = null!;
        public decimal? TotalImpuesto { get; set; }
        public decimal? GranTotal { get; set; }
        public string? Rexento { get; set; }
    }
}
