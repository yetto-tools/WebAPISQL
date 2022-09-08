using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class QsysFelFactAnuVw
    {
        public string? VehEmpresa { get; set; }
        public string? VehTienda { get; set; }
        public int? VehTerminal { get; set; }
        public string? VehSerie { get; set; }
        public int? VehFactura { get; set; }
        public string? FechaDocAnular { get; set; }
        public string? FechaAnulacion { get; set; }
        public string? Feluuid { get; set; }
        public string? Nitreceptor { get; set; }
        public string? MotivoAnulacion { get; set; }
        public string? Nitemisor { get; set; }
        public string? Cprefijo { get; set; }
        public string? Cusuario { get; set; }
        public string? Ccorreo { get; set; }
        public string? Cllave { get; set; }
        public string? Ctoken { get; set; }
    }
}
