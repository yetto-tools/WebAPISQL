using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class TmpVtadev
    {
        public int? Correl { get; set; }
        public string? VehEmpresa { get; set; }
        public string? CliCad { get; set; }
        public string? CliCaddesc { get; set; }
        public string? CliSca { get; set; }
        public string? CliScadesc { get; set; }
        public string? VehCliente { get; set; }
        public string? VelInventario { get; set; }
        public decimal? VelUnidades { get; set; }
        public decimal? VelTotal { get; set; }
        public decimal? DevUnidades { get; set; }
        public decimal? DevTotal { get; set; }
    }
}
