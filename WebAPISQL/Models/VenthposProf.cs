using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class VenthposProf
    {
        public string VhpEmpresa { get; set; } = null!;
        public string VhpTienda { get; set; } = null!;
        public int VhpTerminal { get; set; }
        public int VhpNumero { get; set; }
        public string? VhpFecha { get; set; }
        public string? VhpSerie { get; set; }
        public int? VhpFactura { get; set; }
        public string? VhpCliente { get; set; }
        public short? VhpVendedor { get; set; }
        public string? VhpBodega { get; set; }
        public string? VhpStatus { get; set; }
        public string? VhpActcxc { get; set; }
        public string? VhpConcred1 { get; set; }
        public string? VhpConcred2 { get; set; }
        public string? VhpChtj1 { get; set; }
        public string? VhpChtj2 { get; set; }
        public string? VhpDocnum1 { get; set; }
        public string? VhpDocnum2 { get; set; }
        public decimal? VhpMonto1 { get; set; }
        public decimal? VhpMonto2 { get; set; }
        public decimal? VhpTotal { get; set; }
        public decimal? VhpIva { get; set; }
        public decimal? VhpValor { get; set; }
        public decimal? VhpOtros { get; set; }
        public decimal? VhpDescuen { get; set; }
        public decimal? VhpSaldo { get; set; }
        public string? VhpNumtar1 { get; set; }
        public string? VhpNuntarj2 { get; set; }
        public string? VhpNumauto1 { get; set; }
        public string? VhpNumauto2 { get; set; }
        public string? VhpHora { get; set; }
        public string? VhpUsuario { get; set; }
        public decimal? VhpTasa { get; set; }
        public string? VhpCentro { get; set; }
        public int? VhpEnvio { get; set; }
        public int? VhpOrdenc { get; set; }
        public string? VhpCobrador { get; set; }
        public string? VhpMoneda { get; set; }
        public decimal? VhpTasacam { get; set; }
        public string? VhpTransaccion { get; set; }
        public string? VhpRuta { get; set; }
        public string? VhpArea { get; set; }
        public decimal? VhpIntereses { get; set; }
        public int? VhpDiasp { get; set; }
        public string? VhpObserva { get; set; }
    }
}
