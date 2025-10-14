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
            catch (Exception ex)
            {
                throw new Exception("Error al cargar la lista de categorías: " + ex.Message);
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
                // Verificar si hay artículos asociados a esta categoría
                datos.setearConsulta("SELECT COUNT(*) FROM ARTICULOS WHERE IdCategoria = @Id");
                datos.setearParametro("@Id", id);
                datos.ejecutarLectura();

                int cantidadArticulos = 0;
                if (datos.Lector.Read())
                {
                    cantidadArticulos = (int)datos.Lector[0];
                }
                datos.cerrarConexion();

                if (cantidadArticulos > 0)
                {
                    throw new Exception("No se puede eliminar la categoría porque tiene " + cantidadArticulos + " artículo(s) asociado(s). Por favor, elimine o modifique los artículos primero.");
                }

                // Si no hay artículos asociados, proceder con la eliminación
                datos.setearConsulta("delete from CATEGORIAS where Id = @Id");
                datos.setearParametro("@Id", id);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
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
                throw new Exception("Error al modificar la categoría: " + ex.Message);
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
                throw new Exception("Error al agregar la categoría: " + ex.Message);
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
                    throw new Exception("Error al crear la categoría: " + ex.Message);
                }
                finally
                {
                    datos.cerrarConexion();
                }

            }
        }
    }
}
