using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class AdmFormTipL
    {
        public string FrlEmpresa { get; set; } = null!;
        public string FrlInventario { get; set; } = null!;
        public string FrlCodigoMp { get; set; } = null!;
        public string? FrlDescMp { get; set; }
        public string? FrlUnMedida { get; set; }
        public int? FrlCantidad { get; set; }
    }
}
