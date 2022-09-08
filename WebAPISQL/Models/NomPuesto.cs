using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class NomPuesto
    {
        public string? NpEmpresa { get; set; }
        public string? NpPuesto { get; set; }
        public string? NpDescripcion { get; set; }
        public decimal? NpSueldoini { get; set; }
        public string? NpTurno { get; set; }
        public string? NpJornadaunica { get; set; }
        public int? NpHoraentra { get; set; }
        public int? NpHorasale { get; set; }
        public int? NpHoraentra1 { get; set; }
        public int? NpHorasale1 { get; set; }
        public decimal? NpHorasdia { get; set; }
        public decimal? NpHorassemana { get; set; }
        public decimal? NpHorasmen { get; set; }
        public string? NpAutohoraex { get; set; }
    }
}
