using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;

namespace service
{
    public class CategoriaService
    {
        public List<dominio.Categoria> Listar()
        {
            List<dominio.Categoria> lista = new List<dominio.Categoria>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("select Id, Descripcion FROM CATEGORIAS;");
                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    dominio.Categoria aux = new dominio.Categoria();
                    aux.id = (int)datos.Lector["Id"];
                    aux.descripcion = (string)datos.Lector["Descripcion"];
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

        public void eliminar(int id)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("delete from MARCAS where Id = @Id");
                datos.setearParametro("@Id", id);
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
        public void modificar(Categoria categoria)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("update CATEGORIAS set Descripcion = @Descripcion where Id = @Id");
                datos.setearParametro("@Descripcion", categoria.descripcion);
                datos.setearParametro("@Id", categoria.id);
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
        public void agregar(Categoria categoria)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("insert into CATEGORIAS (Descripcion) values (@Descripcion)");
                datos.setearParametro("@Descripcion", categoria.descripcion);
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
        public void crear(Categoria categoria)
        {
            {
                AccesoDatos datos = new AccesoDatos();
                try
                {
                    datos.setearConsulta("insert into CATEGORIAS (Descripcion) values (@Descripcion)");
                    datos.setearParametro("@Descripcion", categoria.descripcion);
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
}
