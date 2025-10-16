using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using dominio;
using service;
using Api_Productos.Models;

namespace Api_Productos.Controllers
{
    public class ImagenController : ApiController
    {
       
        // POST: api/Imagen
        public HttpResponseMessage Post([FromBody]List<ImagenDto>imagenes)
        {

            

            try {

                if(imagenes == null)
                {
                    throw new Exception("La lista de imagenes está vacía.");
                }

                List<Imagen> imagenesConvertidas = new List<Imagen>(); 

                foreach (var img in imagenes)
                {
                    Imagen imagen = new Imagen();

                    imagen.IdArticulo = img.IdArticulo;
                    imagen.URL = img.URL;
                    imagenesConvertidas.Add(imagen);
                }

           ImagenService imagenservice = new ImagenService();
           imagenservice.agregarImagenes(imagenesConvertidas);
           return Request.CreateResponse(HttpStatusCode.OK, "Imagenes agregadas correctamente");
            }

            catch (Exception ex) {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, "Ocurrió un error al agregar las imagenes. " + ex.Message);

            }

        }

    }
}
