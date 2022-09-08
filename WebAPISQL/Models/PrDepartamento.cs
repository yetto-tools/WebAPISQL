using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class PrDepartamento
    {
        public string DeptoEmpresa { get; set; } = null!;
        public decimal DeptoCodigo { get; set; }
        public string DeptoNombre { get; set; } = null!;
        public string DeptoNomcorto { get; set; } = null!;
        public string DeptoInbox { get; set; } = null!;
        public decimal DeptoEncargado { get; set; }
        public decimal DeptoEstado { get; set; }
        public string DeptoUsuarioi { get; set; } = null!;
        public string DeptoUsuariom { get; set; } = null!;
        public DateTime DeptoFechai { get; set; }
        public DateTime DeptoFecham { get; set; }
    }
}
