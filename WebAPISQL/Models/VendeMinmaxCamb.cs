using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class VendeMinmaxCamb
    {
        public string VminEmpresa { get; set; } = null!;
        public int VminVendedor { get; set; }
        public string VminInventario { get; set; } = null!;
        public decimal? VminMinimo { get; set; }
        public decimal? VminMaximo { get; set; }
        public string? VminExtra1 { get; set; }
        public string? VminExtra2 { get; set; }
        public decimal? VminExtra3 { get; set; }
        public decimal? VminExtra4 { get; set; }
    }
}
