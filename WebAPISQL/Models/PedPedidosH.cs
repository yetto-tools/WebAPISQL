using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class PedPedidosH
    {
        public string PdhEmpresa { get; set; } = null!;
        public string? PdhSerie { get; set; }
        public int PdhNumero { get; set; }
        public string? PdhFechaPed { get; set; }
        public string? PdhFechaEnt { get; set; }
        public string? PdhCliente { get; set; }
        public string? PdhNombreFact { get; set; }
        public string? PdhNitFact { get; set; }
        public string? PdhDirFact { get; set; }
        public string? PdhTelFact { get; set; }
        public string? PdhFaxFact { get; set; }
        public string? PdhNombreEnt { get; set; }
        public string? PdhDirEnt { get; set; }
        public int? PdhPedidoVend { get; set; }
        public int? PdhCotizacion { get; set; }
        public string? PdhOrdenComp { get; set; }
        public decimal? PdhTotal { get; set; }
        public decimal? PdhSaldo { get; set; }
        public string? PdhCondPago { get; set; }
        public string? PdhArte { get; set; }
        public string? PdhFechaArte { get; set; }
        public string? PdhPrensa { get; set; }
        public string? PdhFechaPrensa { get; set; }
        public string? PdhMaquila { get; set; }
        public string? PdhFechaMaq { get; set; }
        public string? PdhEmbobinado { get; set; }
        public string? PdhFechaEmb { get; set; }
        public string? PdhSalav { get; set; }
        public string? PdhFechaSalav { get; set; }
        public string? PdhTipo { get; set; }
        public string? PdhStatus { get; set; }
        public string? PdhFechaStatus { get; set; }
        public string? PdhObservac1 { get; set; }
        public string? PdhObservac2 { get; set; }
        public string? PdhObservac3 { get; set; }
        public string? PdhAprobado { get; set; }
        public string? PdhMoneda { get; set; }
        public decimal? PdhTasa { get; set; }
        public string? PdhUsuarioc { get; set; }
        public string? PdhFechac { get; set; }
        public string? PdhUsuariom { get; set; }
        public string? PdhFecham { get; set; }
    }
}
