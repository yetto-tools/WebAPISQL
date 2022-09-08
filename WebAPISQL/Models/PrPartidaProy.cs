using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class PrPartidaProy
    {
        public string ProyEmpresa { get; set; } = null!;
        public decimal ProyVersion { get; set; }
        public decimal ProyPartida { get; set; }
        public decimal ProyCodigo { get; set; }
        public string? ProyNombre { get; set; }
        public string? ProyDescripcion { get; set; }
        public string? ProyCodInv { get; set; }
        public string? ProyCodLinea { get; set; }
        public decimal? ProyCantUnidad { get; set; }
        public decimal? ProyValorUni { get; set; }
        public decimal? ProyPrecio { get; set; }
        public decimal? ProyHorasMod { get; set; }
        public decimal? ProyCostoHmod { get; set; }
        public decimal? ProyValorTotal { get; set; }
        public int? ProyMesEjec { get; set; }
        public int? ProyGrupo { get; set; }
        public decimal? ProyOrigen { get; set; }
        public string? ProyUsuarioi { get; set; }
        public string? ProyUsuariom { get; set; }
        public DateTime? ProyFechai { get; set; }
        public DateTime? ProyFecham { get; set; }
    }
}
