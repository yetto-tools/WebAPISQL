using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class BcoMovimiento
    {
        public string? ChqEmpresa { get; set; }
        public string? ChqCuentabco { get; set; }
        public int? ChqNumero { get; set; }
        public string? ChqFecha { get; set; }
        public string? ChqEmifec { get; set; }
        public string? ChqDescrip { get; set; }
        public decimal? ChqValor { get; set; }
        public string? ChqBenef { get; set; }
        public string? ChqStatus { get; set; }
        public string? ChqTipo { get; set; }
        public int? ChqNumerochq { get; set; }
        public string? ChqNumerocontra { get; set; }
        public string? ChqFlagcxp { get; set; }
        public string? ChqImpreso { get; set; }
        public int? ChqPartida { get; set; }
        public string? ChqEntregado { get; set; }
        public string? ChqUsuarioc { get; set; }
        public string? ChqFechac { get; set; }
        public string? ChqUsuariom { get; set; }
        public string? ChqFecham { get; set; }
    }
}
