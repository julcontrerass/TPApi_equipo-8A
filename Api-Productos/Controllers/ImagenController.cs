using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using dominio;
using service;

namespace Api_Productos.Controllers
{
    public class ImagenController : ApiController
    {
       
        // POST: api/Imagen
        public HttpResponseMessage Post([FromBody]List<Imagen>imagenes)
        {

            try {
           ImagenService imagenservice = new ImagenService();
           imagenservice.agregarImagenes(imagenes);
           return Request.CreateResponse(HttpStatusCode.OK, "Imagenes agregadas correctamente");
            }
            catch (Exception ex) {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, "Ocurrió un error al agregar las imagenes. " + ex.Message);

            }

        }

    }
}
