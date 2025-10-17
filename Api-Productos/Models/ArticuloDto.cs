using dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace Api_Productos.Models
{
    public class ArticuloDto
    {

        public string codigoArticulo { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public int idMarca { get; set; }
        public int idCategoria { get; set; }
        public decimal precio { get; set; }
        public int? id { get; set; }
        //public string UrlImagen { get; set; }

    }
}