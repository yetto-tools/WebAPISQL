using System;
using System.Collections.Generic;

namespace WebAPISQL.Models
{
    public partial class Generale
    {
        public string GenEmpresa { get; set; } = null!;
        public string GenTienda { get; set; } = null!;
        public int GenTerminal { get; set; }
        public string? GenDescripcion { get; set; }
        public string? GenDireccion { get; set; }
        public string? GenBodega { get; set; }
        public string? GenSerie { get; set; }
        public string? GenEncabezado1 { get; set; }
        public string? GenEncabezado2 { get; set; }
        public string? GenEncabezado3 { get; set; }
        public string? GenEncabezado4 { get; set; }
        public string? GenEncabezado5 { get; set; }
        public string? GenMensajes1 { get; set; }
        public string? GenMensajes2 { get; set; }
        public string? GenMensajes3 { get; set; }
        public string? GenActiva { get; set; }
        public string? GenCheque1 { get; set; }
        public string? GenCheque2 { get; set; }
        public string? GenCheque3 { get; set; }
        public string? GenCheque4 { get; set; }
        public string? GenPuerto { get; set; }
        public int? GenFormato { get; set; }
    }
}
