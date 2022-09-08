using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class InvLoteFecha
    {
        public string? LotEmpresa { get; set; }
        public string? LotBodega { get; set; }
        public string? LotInventario { get; set; }
        public string? LotSerie { get; set; }
        public string? LotFechain { get; set; }
        public string? LotFechaven { get; set; }
        public decimal? LotExistencia { get; set; }
        public string? LotUbicacion { get; set; }
    }
}
