using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WebAPISQL.Models
{
    [Keyless]
    public partial class Usuario
    {        
        public string? User_Empresa { get ; set; }
        public string? User_Usuario { get; set; }
        public string? User_Password { get; set; }
        public string? User_Nombre { get; set; }
    }


}
