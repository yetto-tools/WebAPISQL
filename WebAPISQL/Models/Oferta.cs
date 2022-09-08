using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class Oferta
    {
        public string? OferEmpresa { get; set; }
        public int? OferCodigo { get; set; }
        public string? OferDescripcion { get; set; }
        public string? OferMoneda { get; set; }
        public string? OferInventario { get; set; }
        public string? OferVigenciaFechai { get; set; }
        public string? OferVigenciaFechaf { get; set; }
        public decimal? OferXporcentaje { get; set; }
        public decimal? OferXprecio { get; set; }
        public decimal? OferXcantidad { get; set; }
        public decimal? OferXcantidadgratis { get; set; }
        public string? OferAplicaTodos { get; set; }
        public string? OferAplicaLunes { get; set; }
        public string? OferAplicaMartes { get; set; }
        public string? OferAplicaMiercoles { get; set; }
        public string? OferAplicaJueves { get; set; }
        public string? OferAplicaViernes { get; set; }
        public string? OferAplicaSabado { get; set; }
        public string? OferAplicaDomingo { get; set; }
        public string? OferUsuarioi { get; set; }
        public string? OferFechai { get; set; }
        public string? OferUsuariom { get; set; }
        public string? OferFecham { get; set; }
    }
}
