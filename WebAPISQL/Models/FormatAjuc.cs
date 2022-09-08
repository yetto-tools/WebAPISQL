using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class FormatAjuc
    {
        public string FajEmpresa { get; set; } = null!;
        public string? FajPuerto { get; set; }
        public string? FajDebito { get; set; }
        public string? FajCredito { get; set; }
        public string? FajAbono { get; set; }
        public string? FajDetcredito { get; set; }
        public string? FajDetabono { get; set; }
        public string? FajDevcredito { get; set; }
        public string? FajDevabono { get; set; }
        public string? FajCargo { get; set; }
    }
}
