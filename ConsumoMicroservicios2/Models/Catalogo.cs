using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ConsumoMicroservicios2.Models
{
    public class Catalogo
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
        public bool Activo { get; set; }
    }
}