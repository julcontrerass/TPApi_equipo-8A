using dominio;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace service
{
    public class ImagenService
    {

        public ImagenService() { }
        public List<Imagen> Listar()
        {
            List<Imagen> lista = new List<Imagen>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("select IdArticulo, ImagenUrl FROM IMAGENES;");
                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    Imagen aux = new Imagen();
                    aux.IdArticulo = (int)datos.Lector["IdArticulo"];
                    aux.URL = (string)datos.Lector["ImagenUrl"];
                    lista.Add(aux);
                }
                return lista;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
        public void eliminar(int idArticulo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("delete from IMAGENES where IdArticulo = @idArticulo");
                datos.setearParametro("@idArticulo", idArticulo);
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

        public void agregarImagenes(List<Imagen> imagenes)
        {

            var datos = new AccesoDatos();
            datos.abrirConexion();
            SqlTransaction transaccion = datos.iniciarTransaccion();


            try
            {
                foreach (var img in imagenes)
                {


                    datos.limpiarParametros();
                    datos.setearConsulta("SELECT COUNT(*) FROM ARTICULOS WHERE Id = @IdArticulo");
                    datos.setearParametro("@IdArticulo", img.IdArticulo);
                    int productoExiste = (int)datos.ejecutarScalarMismaTransaccion();

                    if (productoExiste == 0)
                        throw new Exception($"El artículo con ID {img.IdArticulo} no existe.");


                    datos.limpiarParametros();
                    datos.setearConsulta(
                        "INSERT INTO IMAGENES (IdArticulo, ImagenUrl) VALUES (@IdArticulo, @ImagenUrl)");
                    datos.setearParametro("@IdArticulo", img.IdArticulo);
                    datos.setearParametro("@ImagenUrl", img.URL.Trim());
                    datos.ejecutarAccionMismaTransaccion();
                }

                transaccion.Commit();
            }
            catch (Exception ex)
            {
                transaccion.Rollback();
                throw new Exception("Error al guardar las imágenes del artículo: " + ex.Message);

            }
           

            datos.cerrarConexion();
        }
    }

}
