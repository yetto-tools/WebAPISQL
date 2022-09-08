using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class AdmProdTermL
    {
        public string PrlEmpresa { get; set; } = null!;
        public string PrlInventario { get; set; } = null!;
        public string PrlCodEmp { get; set; } = null!;
        public int? PrlUniEmp { get; set; }
    }
}
