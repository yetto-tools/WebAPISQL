using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class PrPartidaTransAnual
    {
        public string TransEmpresa { get; set; } = null!;
        public decimal TransVersion { get; set; }
        public decimal? TransCodigo { get; set; }
        public decimal TransPartidaOrigen { get; set; }
        public decimal TransProyOrigen { get; set; }
        public decimal? TransPartidaDestino { get; set; }
        public decimal? TransProyDestino { get; set; }
        public decimal TransMov { get; set; }
        public string TransTipo { get; set; } = null!;
        public decimal? TransEstado { get; set; }
        public string? TransDescripcion { get; set; }
        public decimal? TransTotalMov1 { get; set; }
        public decimal? TransTotalMov2 { get; set; }
        public decimal? TransTotalMov3 { get; set; }
        public decimal? TransTotalMov4 { get; set; }
        public decimal? TransTotalMov5 { get; set; }
        public decimal? TransTotalMov6 { get; set; }
        public decimal? TransTotalMov7 { get; set; }
        public decimal? TransTotalMov8 { get; set; }
        public decimal? TransTotalMov9 { get; set; }
        public decimal? TransTotalMov10 { get; set; }
        public decimal? TransTotalMov11 { get; set; }
        public decimal? TransTotalMov12 { get; set; }
        public decimal? TransValorTotalAnterior { get; set; }
        public decimal? TransValorTotalMovimiento { get; set; }
        public decimal? TransValorTotalActual { get; set; }
        public string? TransUsuarioi { get; set; }
        public string? TransUsuariom { get; set; }
        public DateTime? TransFechai { get; set; }
        public DateTime? TransFecham { get; set; }
    }
}
