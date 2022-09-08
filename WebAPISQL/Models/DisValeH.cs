using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class DisValeH
    {
        public string DvhEmpresa { get; set; } = null!;
        public int DvhNumero { get; set; }
        public string? DvhDocumento { get; set; }
        public string? DvhFecha { get; set; }
        public string? DvhBodegaO { get; set; }
        public string? DvhBodegaD { get; set; }
        public string? DvhRequi { get; set; }
        public string? DvhStatus { get; set; }
        public decimal? DvhTasa { get; set; }
        public string? DvhCentro { get; set; }
        public string? DvhUsuario { get; set; }
        public string? DvhObservacion { get; set; }
        public string? DvhCliente { get; set; }
        public string? DvhInventario { get; set; }
        public string? DvhSerie { get; set; }
        public string? DvhFactura { get; set; }
        public string? DvhUsuarioc { get; set; }
        public string? DvhFechac { get; set; }
        public string? DvhUsuariom { get; set; }
        public string? DvhFecham { get; set; }
        public string? DvhImpresion { get; set; }
    }
}
