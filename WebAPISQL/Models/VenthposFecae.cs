using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class VenthposFecae
    {
        public string? VehEmpresa { get; set; }
        public string? VehTienda { get; set; }
        public int? VehTerminal { get; set; }
        public string? VehSerie { get; set; }
        public int? VehFactura { get; set; }
        public string? VehFechaemi { get; set; }
        public string? VehHoraemi { get; set; }
        public string? VehFechacfe { get; set; }
        public string? VehHoracfe { get; set; }
        public string? VehCae { get; set; }
    }
}
