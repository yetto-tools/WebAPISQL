using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class NotNotificacione
    {
        public string NtfEmpresa { get; set; } = null!;
        public int NtfNumero { get; set; }
        public string NtfFecha { get; set; } = null!;
        public string NtfHora { get; set; } = null!;
        public string NtfEnvia { get; set; } = null!;
        public string NtfRecibe { get; set; } = null!;
        public string? NtfObserv { get; set; }
        public string? NtfObjeto { get; set; }
        public string? NtfLlave1 { get; set; }
        public string? NtfLlave2 { get; set; }
        public int? NtfLlave3 { get; set; }
    }
}
