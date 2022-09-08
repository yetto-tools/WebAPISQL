using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class FacBackordersH
    {
        public string FbohEmpresa { get; set; } = null!;
        public int FbohNumero { get; set; }
        public string? FbohFecha { get; set; }
        public string FbohTienda { get; set; } = null!;
        public int FbohTerminal { get; set; }
        public string? FbohSerie { get; set; }
        public int? FbohFactura { get; set; }
        public int? FbohEnvio { get; set; }
        public int? FbohOrdenc { get; set; }
        public string? FbohCliente { get; set; }
        public short? FbohVendedor { get; set; }
        public string? FbohConcred { get; set; }
        public string? FbohMoneda { get; set; }
        public decimal? FbohTasacam { get; set; }
        public string? FbohObserva { get; set; }
        public string? FbohHora { get; set; }
        public string? FbohUsuario { get; set; }
    }
}
