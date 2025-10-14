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
    public class ProductoController : ApiController
    {
        // GET: api/Producto
        public IEnumerable<Articulo> Get()
        {
            ArticuloService servicio = new ArticuloService();
            return servicio.Listar();
        }

        // GET: api/Producto/5
        public Articulo Get(int id)
        {
            ArticuloService articuloService = new ArticuloService();
            List<Articulo> lista = articuloService.Listar();
            return lista.Find(x => x.id == id);
        }

        // POST: api/Producto
        public HttpResponseMessage Post([FromBody]ArticuloDto art)
        {
            try
            {
                ArticuloService articuloService = new ArticuloService();
                Articulo nuevo = new Articulo();
                nuevo.codigoArticulo = art.codigoArticulo;
                nuevo.nombre = art.nombre;
                nuevo.descripcion = art.descripcion;
                nuevo.idMarca = art.idMarca;
                nuevo.idCategoria = art.idCategoria;
                nuevo.precio = art.precio;
                articuloService.agregar(nuevo);

                return Request.CreateResponse(HttpStatusCode.OK, "Artículo agregado correctamente.");
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, "Ocurrió un error al agregar el artículo.");
            }
        }

        // PUT: api/Producto/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Producto/5
        public HttpResponseMessage Delete(int id)
        {
            try
            {
                ArticuloService articuloService = new ArticuloService();
                articuloService.eliminar(id);

                return Request.CreateResponse(HttpStatusCode.OK, "Artículo eliminado correctamente.");
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, "Ocurrió un error al eliminar el artículo.");
            }
        }
    }
}
