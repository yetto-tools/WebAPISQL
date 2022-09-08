using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class DistInvclicla
    {
        public string DclclaEmpresa { get; set; } = null!;
        public string DclclaCodigo { get; set; } = null!;
        public string? DclclaDescripcion { get; set; }
        public string? DclclaTipo { get; set; }
        public string? DclclaUsuarioc { get; set; }
    }
}
