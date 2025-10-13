using dominio;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace service
{
    public class ArticuloService
    {
        public List<Articulo> Listar() 
        {
            AccesoDatos datos = new AccesoDatos();
            List<Articulo> lista = new List<Articulo>();

            try
            {

                datos.setearConsulta("SELECT  A.id AS idArticulo, A.Codigo, A.Nombre, A.descripcion AS descArticulo, A.Precio, A.IdMarca, A.IdCategoria,M.Id AS codigoMarca, M.Descripcion AS descMarca,C.Id AS codigoCategoria, C.Descripcion AS descCategoria, ISNULL(I.ImagenUrl, '') AS URLImagen,ISNULL(I.Id, 0) AS idImagen FROM ARTICULOS A INNER JOIN MARCAS M ON M.id = A.idMarca INNER JOIN CATEGORIAS C ON C.id = A.IdCategoria LEFT JOIN IMAGENES I ON A.Id = I.IdArticulo;");
                datos.ejecutarLectura();

                int? prodAnterior = null;


                while (datos.Lector.Read())
                {
                   
                    int idProductoActual = (int)datos.Lector["idArticulo"];
                    string URL = (string)datos.Lector["URLImagen"];
                    int idImagen = (int)datos.Lector["idImagen"];

                    if (idProductoActual == prodAnterior)
                    {
                        Imagen imagen = new Imagen();
                        imagen.IdImagen = idImagen;
                        imagen.URL = URL;
                        imagen.IdArticulo = idProductoActual;
                        lista.Last().URLImagenes.Add(imagen);
                    }
                    else
                    {
                        //Articulo:
                        Articulo aux = new Articulo();
                        aux.id = idProductoActual;
                        aux.codigoArticulo = (string)datos.Lector["Codigo"];
                        aux.nombre = (string)datos.Lector["Nombre"];
                        aux.descripcion = (string)datos.Lector["descArticulo"];
                        aux.idMarca = (int)datos.Lector["idMarca"];
                        aux.idCategoria = (int)datos.Lector["idCategoria"];
                        aux.precio = (decimal)datos.Lector["Precio"];
                        //Imagen:
                        Imagen imagen = new Imagen();
                        imagen.IdImagen = idImagen;
                        imagen.URL = URL;
                        imagen.IdArticulo = idProductoActual;
                        aux.URLImagenes.Add(imagen);
                        //Marca:
                        aux.Marca = new Marca();
                        aux.Marca.id = (int)datos.Lector["codigoMarca"];
                        aux.Marca.descripcion = (string)datos.Lector["descMarca"];
                        //Categoria:
                        aux.Categoria = new Categoria();
                        aux.Categoria.id = (int)datos.Lector["codigoCategoria"];
                        aux.Categoria.descripcion = (string)datos.Lector["descCategoria"];
                        lista.Add(aux);
                    }
                    prodAnterior = idProductoActual;
                }

                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public void agregar(Articulo nuevo)
        {
            var datos = new AccesoDatos();
            try
            {
                datos.setearConsulta(
                    "INSERT INTO ARTICULOS (Codigo, Nombre, Descripcion, IdMarca, IdCategoria, Precio) " +
                    "OUTPUT INSERTED.Id VALUES (@Codigo, @Nombre, @Descripcion, @IdMarca, @IdCategoria, @Precio)");
                datos.setearParametro("@Codigo", nuevo.codigoArticulo);
                datos.setearParametro("@Nombre", nuevo.nombre);
                datos.setearParametro("@Descripcion", nuevo.descripcion);
                datos.setearParametro("@IdMarca", nuevo.idMarca);
                datos.setearParametro("@IdCategoria", nuevo.idCategoria);
                datos.setearParametro("@Precio", nuevo.precio);

                int nuevoId = (int)datos.ejecutarScalar();
                datos.cerrarConexion();

                if (nuevo.URLImagenes != null && nuevo.URLImagenes.Count > 0)
                {
                    foreach (var img in nuevo.URLImagenes)
                    {
                        if (string.IsNullOrWhiteSpace(img.URL)) continue;

                        var datosImg = new AccesoDatos();
                        try
                        {
                            datosImg.setearConsulta(
                                "INSERT INTO IMAGENES (IdArticulo, ImagenUrl) VALUES (@IdArticulo, @ImagenUrl)");
                            datosImg.setearParametro("@IdArticulo", nuevoId);
                            datosImg.setearParametro("@ImagenUrl", img.URL.Trim());
                            datosImg.ejecutarAccion();
                        }
                        finally
                        {
                            datosImg.cerrarConexion();
                        }
                    }
                }
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public void eliminar(int id)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("delete from ARTICULOS where Id = @Id");
                datos.setearParametro("@Id", id);
                datos.ejecutarAccion();
                datos.cerrarConexion();

                datos.setearConsulta("delete from Imagenes where IdArticulo = @IdArticulo");
                datos.setearParametro("@IdArticulo", id);
                datos.ejecutarAccion();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public void modificar(Articulo articulo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("UPDATE ARTICULOS SET Codigo=@codigo, Nombre=@nombre, Descripcion=@descripcion, IdMarca=@idMarca, IdCategoria=@idCategoria, Precio=@precio WHERE Id=@id");
                datos.setearParametro("@codigo", articulo.codigoArticulo);
                datos.setearParametro("@nombre", articulo.nombre);
                datos.setearParametro("@descripcion", articulo.descripcion);
                datos.setearParametro("@idMarca", articulo.idMarca);
                datos.setearParametro("@idCategoria", articulo.idCategoria);
                datos.setearParametro("@precio", articulo.precio);
                datos.setearParametro("@id", articulo.id);
                datos.ejecutarAccion();
                datos.cerrarConexion();
                datos.limpiarParametros();

                datos.setearConsulta("DELETE FROM IMAGENES WHERE IdArticulo = @IdArticulo");
                datos.setearParametro("@IdArticulo", articulo.id);
                datos.ejecutarAccion();
                datos.cerrarConexion();
                datos.limpiarParametros(); 

                if (articulo.URLImagenes != null && articulo.URLImagenes.Count > 0)
                {
                    foreach (var img in articulo.URLImagenes)
                    {
                        if (string.IsNullOrWhiteSpace(img.URL)) continue;

                        datos.setearConsulta("INSERT INTO IMAGENES (IdArticulo, ImagenUrl) VALUES (@IdArticulo, @ImagenUrl)");
                        datos.setearParametro("@IdArticulo", articulo.id);
                        datos.setearParametro("@ImagenUrl", img.URL.Trim());
                        datos.ejecutarAccion();
                        datos.cerrarConexion();
                        datos.limpiarParametros();   
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
        public List<Articulo> filtroAvanzado(string marca, string categoria)
        {
            AccesoDatos datos = new AccesoDatos();

            List<Articulo> listaFiltrada = new List<Articulo>();

            bool hayFiltroMarca = marca != "";
            bool hayFiltroCategoria = categoria != "";
            string consulta; 

            if(hayFiltroMarca && hayFiltroCategoria)
            {
                consulta = "SELECT  A.id AS idArticulo, A.Codigo, A.Nombre, A.descripcion AS descArticulo, A.Precio, A.IdMarca, A.IdCategoria,M.Id AS codigoMarca, M.Descripcion AS descMarca,C.Id AS codigoCategoria, C.Descripcion AS descCategoria, ISNULL(I.ImagenUrl, '') AS URLImagen,ISNULL(I.Id, 0) AS idImagen FROM ARTICULOS A INNER JOIN MARCAS M ON M.id = A.idMarca INNER JOIN CATEGORIAS C ON C.id = A.IdCategoria LEFT JOIN IMAGENES I ON A.Id = I.IdArticulo WHERE M.Descripcion = @marca and C.Descripcion = @categoria";

                datos.setearConsulta(consulta);
                datos.setearParametro("@categoria", categoria);
                datos.setearParametro("@marca", marca);
            }
            else if (hayFiltroMarca)
            {
                consulta = "SELECT  A.id AS idArticulo, A.Codigo, A.Nombre, A.descripcion AS descArticulo, A.Precio, A.IdMarca, A.IdCategoria,M.Id AS codigoMarca, M.Descripcion AS descMarca,C.Id AS codigoCategoria, C.Descripcion AS descCategoria, ISNULL(I.ImagenUrl, '') AS URLImagen,ISNULL(I.Id, 0) AS idImagen FROM ARTICULOS A INNER JOIN MARCAS M ON M.id = A.idMarca INNER JOIN CATEGORIAS C ON C.id = A.IdCategoria LEFT JOIN IMAGENES I ON A.Id = I.IdArticulo WHERE M.Descripcion = @marca";
                datos.setearConsulta(consulta);
                datos.setearParametro("@marca", marca);

            }
            else
            {
                consulta = "SELECT  A.id AS idArticulo, A.Codigo, A.Nombre, A.descripcion AS descArticulo, A.Precio, A.IdMarca, A.IdCategoria,M.Id AS codigoMarca, M.Descripcion AS descMarca,C.Id AS codigoCategoria, C.Descripcion AS descCategoria, ISNULL(I.ImagenUrl, '') AS URLImagen,ISNULL(I.Id, 0) AS idImagen FROM ARTICULOS A INNER JOIN MARCAS M ON M.id = A.idMarca INNER JOIN CATEGORIAS C ON C.id = A.IdCategoria LEFT JOIN IMAGENES I ON A.Id = I.IdArticulo WHERE C.Descripcion = @categoria";
                datos.setearConsulta(consulta);
                datos.setearParametro("@categoria", categoria);

            }


            try
                {

                    datos.ejecutarLectura();

                    int? prodAnterior = null;


                    while (datos.Lector.Read())
                    {

                        int idProductoActual = (int)datos.Lector["idArticulo"];
                        string URL = (string)datos.Lector["URLImagen"];
                        int idImagen = (int)datos.Lector["idImagen"];

                        if (idProductoActual == prodAnterior)
                        {
                            Imagen imagen = new Imagen();
                            imagen.IdImagen = idImagen;
                            imagen.URL = URL;
                            imagen.IdArticulo = idProductoActual;
                            listaFiltrada.Last().URLImagenes.Add(imagen);
                        }
                        else
                        {
                            //Articulo:
                            Articulo aux = new Articulo();
                            aux.id = idProductoActual;
                            aux.codigoArticulo = (string)datos.Lector["Codigo"];
                            aux.nombre = (string)datos.Lector["Nombre"];
                            aux.descripcion = (string)datos.Lector["descArticulo"];
                            aux.idMarca = (int)datos.Lector["idMarca"];
                            aux.idCategoria = (int)datos.Lector["idCategoria"];
                            aux.precio = (decimal)datos.Lector["Precio"];
                            //Imagen:
                            Imagen imagen = new Imagen();
                            imagen.IdImagen = idImagen;
                            imagen.URL = URL;
                            imagen.IdArticulo = idProductoActual;
                            aux.URLImagenes.Add(imagen);
                            //Marca:
                            aux.Marca = new Marca();
                            aux.Marca.id = (int)datos.Lector["codigoMarca"];
                            aux.Marca.descripcion = (string)datos.Lector["descMarca"];
                            //Categoria:
                            aux.Categoria = new Categoria();
                            aux.Categoria.id = (int)datos.Lector["codigoCategoria"];
                            aux.Categoria.descripcion = (string)datos.Lector["descCategoria"];
                            listaFiltrada.Add(aux);
                        }
                        prodAnterior = idProductoActual;
                    }

                    return listaFiltrada;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    datos.cerrarConexion();
                }
        }

    }
}

