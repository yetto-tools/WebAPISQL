using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class AdmFormTipH
    {
        public string FrhEmpresa { get; set; } = null!;
        public string FrhInventario { get; set; } = null!;
        public int? FrhUniTeo { get; set; }
    }
}
