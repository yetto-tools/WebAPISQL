using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class InvPreciodesc
    {
        public string IpdEmpresa { get; set; } = null!;
        public string IpdInventario { get; set; } = null!;
        public string IpdMoneda { get; set; } = null!;
        public decimal? IpdDesc1 { get; set; }
        public decimal? IpdDesc2 { get; set; }
        public decimal? IpdDesc3 { get; set; }
        public decimal? IpdDesc4 { get; set; }
        public decimal? IpdDesc5 { get; set; }
        public decimal? IpdDesc6 { get; set; }
    }
}
