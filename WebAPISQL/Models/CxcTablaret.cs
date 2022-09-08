using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class CxcTablaret
    {
        public string CxcrEmpresa { get; set; } = null!;
        public string CxcrTabla { get; set; } = null!;
        public string? CxcrDescrip { get; set; }
        public decimal? CxcrBase { get; set; }
        public decimal? CxcrPorcen { get; set; }
    }
}
