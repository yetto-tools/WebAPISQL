using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class Comphead
    {
        public string? CohEmpresa { get; set; }
        public string? CohProveedor { get; set; }
        public string? CohFactura { get; set; }
        public string? CohFecha { get; set; }
        public decimal? CohTotal { get; set; }
        public decimal? CohIva { get; set; }
        public decimal? CohValor { get; set; }
        public decimal? CohOtros { get; set; }
        public string? CohConcred { get; set; }
        public string? CohStatus { get; set; }
        public decimal? CohSaldo { get; set; }
        public decimal? CohDescuen { get; set; }
        public decimal? CohNoserv { get; set; }
        public decimal? CohNocomp { get; set; }
        public decimal? CohServ { get; set; }
        public decimal? CohComp { get; set; }
        public string? CohBodega { get; set; }
        public decimal? CohTasa { get; set; }
        public int? CohContrasena { get; set; }
        public int? CohOrdenc { get; set; }
        public string? CohEnvioprov { get; set; }
        public int? CohLiquidacion { get; set; }
        public string? CohTransaccion { get; set; }
        public string? CohFrecep { get; set; }
        public string? CohFpago { get; set; }
        public string? CohAutorizado { get; set; }
        public string? CohBanco { get; set; }
        public int? CohCheque { get; set; }
        public decimal? CohImpuesto1 { get; set; }
        public decimal? CohImpuesto2 { get; set; }
        public decimal? CohImpuesto3 { get; set; }
        public decimal? CohImpuesto4 { get; set; }
        public decimal? CohImpuesto5 { get; set; }
        public string? CohDescrip { get; set; }
        public string? CohFechaVenc { get; set; }
    }
}
