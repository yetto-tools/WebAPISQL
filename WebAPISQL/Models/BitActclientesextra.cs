using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class BitActclientesextra
    {
        public string BitEmpresa { get; set; } = null!;
        public DateTime? BitFecha { get; set; }
        public string BitUsuario { get; set; } = null!;
        public string BitCliente { get; set; } = null!;
        public int? BitOldDias { get; set; }
        public int? BitOldVendedor { get; set; }
        public string? BitOldNombrefac { get; set; }
        public string? BitOldMoneda { get; set; }
        public int? BitOldNivprecio { get; set; }
        public string? BitOldConcred { get; set; }
        public string? BitOldExtra6 { get; set; }
        public string? BitOldExtra7 { get; set; }
        public int? BitNewDias { get; set; }
        public int? BitNewVendedor { get; set; }
        public string? BitNewNombrefac { get; set; }
        public string? BitNewMoneda { get; set; }
        public int? BitNewNivprecio { get; set; }
        public string? BitNewConcred { get; set; }
        public string? BitNewExtra6 { get; set; }
        public string? BitNewExtra7 { get; set; }
        public string? BitAplicacion { get; set; }
        public string? BitHost { get; set; }
    }
}
