using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class PrEjecPresup
    {
        public string EjpEmpresa { get; set; } = null!;
        public decimal EjpCodigo { get; set; }
        public decimal EjpNumversion { get; set; }
        public string? EjpSerie { get; set; }
        public decimal EjpPartidaPresup { get; set; }
        public decimal EjpProyectoPresup { get; set; }
        public int EjpMesEjec { get; set; }
        public DateTime EjpFechaTrans { get; set; }
        public string EjpOrdenCompra { get; set; } = null!;
        public string EjpFacturaCompra { get; set; } = null!;
        public string EjpCuentaBancaria { get; set; } = null!;
        public string EjpNumcheque { get; set; } = null!;
        public decimal EjpPartidaContable { get; set; }
        public decimal? EjpNumctacontable { get; set; }
        public decimal? EjpMesParcont { get; set; }
        public decimal EjpTipoOrigentrans { get; set; }
        public decimal? EjpValorReserva { get; set; }
        public decimal? EjpValorReservaMr { get; set; }
        public decimal? EjpValorReservaMe { get; set; }
        public decimal EjpValorEjecutado { get; set; }
        public decimal? EjpValorEjecutadoMr { get; set; }
        public decimal? EjpValorEjecutadoMe { get; set; }
        public string EjpCodInventario { get; set; } = null!;
        public string EjpLineaInventario { get; set; } = null!;
        public decimal EjpCantUnid { get; set; }
        public decimal? EjpEstado { get; set; }
        public string? EjpObservacion { get; set; }
        public string? EjpDescripcion { get; set; }
        public decimal? EjpUsrSolicita { get; set; }
        public decimal? EjpUsrAutoriza { get; set; }
        public decimal? EjpUsrConfirma { get; set; }
        public string? EjpMonedaBase { get; set; }
        public string? EjpMonedaReferencia { get; set; }
        public string? EjpMonedaEjecucion { get; set; }
        public decimal? EjpTasaMonbase { get; set; }
        public decimal? EjpTasaMonreferencia { get; set; }
        public decimal? EjpTasaMonejecucion { get; set; }
        public string? EjpUsuarioi { get; set; }
        public string? EjpUsuariom { get; set; }
        public DateTime? EjpFechai { get; set; }
        public DateTime? EjpFecham { get; set; }
    }
}
