using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class BcoSaldo
    {
        public string? BsalEmpresa { get; set; }
        public string? BsalCuentabco { get; set; }
        public int? BsalAno { get; set; }
        public int? BsalMes { get; set; }
        public decimal? BsalSaldoini { get; set; }
        public decimal? BsalCargos { get; set; }
        public decimal? BsalAbonos { get; set; }
        public decimal? BsalSaldofin { get; set; }
    }
}
