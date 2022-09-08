using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class ClientesAgen
    {
        public string CliagEmpresa { get; set; } = null!;
        public string CliagCliente { get; set; } = null!;
        public string? CliagAgenteret { get; set; }
        public string? CliagTablaret { get; set; }
    }
}
