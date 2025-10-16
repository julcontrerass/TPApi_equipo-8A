using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Api_Productos.Models
{
    public class ImagenDto
    {

        public ImagenDto() { }
        public ImagenDto(string url, int idArticulo)
        {
            this.URL = url;
            this.IdArticulo = idArticulo;          
        }

        public string URL { get; set; }
        public int IdArticulo { get; set; }  


    }
}