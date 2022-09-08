using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WebAPISQL.Models
{
    [Keyless]
    public partial class Vendedor
    {
        public string? Ven_Empresa { get; set; }
        public short? Ven_Codigo { get; set; }
        public string? Ven_Nombre { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal? Ven_Comision { get; set; }
    }
}
