using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class PrPartidaTran
    {
        public string TransEmpresa { get; set; } = null!;
        public decimal TransCodigo { get; set; }
        public decimal TransVersion { get; set; }
        public decimal? TransPartida { get; set; }
        public decimal? TransTipo { get; set; }
        public decimal? TransProyOrigen { get; set; }
        public decimal? TransProyDestino { get; set; }
        public string? TransMesEjec { get; set; }
        public decimal? TransValorTotal { get; set; }
        public string? TransUsuarioi { get; set; }
        public string? TransUsuariom { get; set; }
        public DateTime? TransFechai { get; set; }
        public DateTime? TransFecham { get; set; }
    }
}
