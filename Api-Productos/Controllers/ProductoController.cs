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
        public void Post([FromBody]ArticuloDto art)
        {
            ArticuloService articuloService = new ArticuloService();
            Articulo nuevo = new Articulo();
            nuevo.codigoArticulo = art.codigoArticulo;
            nuevo.nombre = art.nombre;
            nuevo.descripcion = art.descripcion;
            nuevo.idMarca = art.idMarca;
            nuevo.idCategoria = art.idCategoria;
            nuevo.precio = art.precio;
            //nuevo.Imagen = new Imagen();
            articuloService.agregar(nuevo);
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
