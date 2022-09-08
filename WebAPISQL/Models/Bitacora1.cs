using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class Bitacora1
    {
        public string? BisEmpresa { get; set; }
        public string? BisTienda { get; set; }
        public int? BisTerminal { get; set; }
        public int? BisNumero { get; set; }
        public string? BisRutina { get; set; }
        public int? BisTicket { get; set; }
        public short? BisPanta { get; set; }
        public string? BisUsuario { get; set; }
        public string? BisFecha { get; set; }
        public string? BisHora { get; set; }
        public decimal? BisValor { get; set; }
    }
}
