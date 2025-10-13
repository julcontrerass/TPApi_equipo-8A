using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;

namespace service
{
    internal class ImagenService
    {
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
    }



}
