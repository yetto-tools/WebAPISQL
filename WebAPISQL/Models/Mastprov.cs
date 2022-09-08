using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class Mastprov
    {
        public string? ProEmpresa { get; set; }
        public string? ProProveedor { get; set; }
        public string? ProNombre { get; set; }
        public string? ProDireccion { get; set; }
        public string? ProCodPostal { get; set; }
        public string? ProCiudad { get; set; }
        public string? ProDepto { get; set; }
        public string? ProPhones { get; set; }
        public string? ProNit { get; set; }
        public decimal? ProSaldo { get; set; }
        public string? ProFechac { get; set; }
        public string? ProCuenta { get; set; }
    }
}
