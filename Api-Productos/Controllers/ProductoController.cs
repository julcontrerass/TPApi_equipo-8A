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
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Producto/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Producto/5
        public void Delete(int id)
        {
        }
    }
}
