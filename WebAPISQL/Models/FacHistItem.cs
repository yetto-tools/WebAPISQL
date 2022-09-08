using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class FacHistItem
    {
        public string? ItehEmpresa { get; set; }
        public int? ItehCorrelativo { get; set; }
        public string? ItehCliente { get; set; }
        public string? ItehTipocliente { get; set; }
        public string? ItehNombre { get; set; }
        public string? ItehDireccion { get; set; }
        public string? ItehTelefono { get; set; }
        public string? ItehFax { get; set; }
        public string? ItehInventario { get; set; }
        public string? ItehDescripcion { get; set; }
        public string? ItehSerieflag { get; set; }
        public string? ItehSerie { get; set; }
        public string? ItehFactura { get; set; }
        public string? ItehFecha { get; set; }
        public string? ItehFechaact { get; set; }
        public string? ItehStatus { get; set; }
        public int? ItehMesesgar { get; set; }
        public string? ItehCondicion { get; set; }
        public int? ItehVendedor { get; set; }
        public string? ItehVnombre { get; set; }
        public string? ItehFechafac { get; set; }
        public string? ItehTipoventa { get; set; }
    }
}
