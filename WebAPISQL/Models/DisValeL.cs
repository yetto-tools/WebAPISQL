using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class DisValeL
    {
        public string DvlEmpresa { get; set; } = null!;
        public int DvlNumero { get; set; }
        public int DvlLinea { get; set; }
        public string? DvlInventario { get; set; }
        public decimal? DvlCantidad { get; set; }
        public decimal? DvlCosto { get; set; }
        public string? DvlFechat { get; set; }
        public string? DvlSerie { get; set; }
        public string? DvlSerieflag { get; set; }
        public string? DvlFechav { get; set; }
    }
}
