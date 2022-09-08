using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WebAPISQL.Models
{
    [Keyless]
    public partial class Mastcli
    {
        public string? Cli_Empresa { get; set; }
        public string? Cli_Codigo { get; set; }
        public string? Cli_Nombre { get; set; }
        public string? Cli_Direccion { get; set; }
        public string? Cli_Direccion1 { get; set; }
        public string? Cli_Ciudad { get; set; }
        public string? Cli_Depto { get; set; }
        public string? Cli_Phones { get; set; }
        public string? Cli_Nit { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal? Cli_Limite { get; set; }
        public int? Cli_Diascred { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal? Cli_Saldo { get; set; }
        public int? Cli_Pctdescuento { get; set; }
        public string? Cli_Afecto { get; set; }
        public int? Cli_Vendedor { get; set; }
        public string? Cli_Cobrador { get; set; }
        public string? Cli_Ruta { get; set; }
        public string? Cli_Area { get; set; }
        public string? Cli_Fechac { get; set; }
        public string? Cli_Clasificacion { get; set; }
        public string? Cli_Cuenta { get; set; }
        public string? Cli_Suspencion { get; set; }
        public string? Cli_Suspvfe { get; set; }
        public string? Cli_Dircor1 { get; set; }
        public string? Cli_Dircor2 { get; set; }
        public string? Cli_Tipo { get; set; }
        public string? Cli_Feulpago { get; set; }
        public string? Cli_Feulcompra { get; set; }
        public string? Cli_Zona { get; set; }
        public string? Cli_Contacto { get; set; }
    }
}
