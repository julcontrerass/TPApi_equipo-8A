using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;

namespace service
{
    public class MarcaService
    {
        public List<Marca> Listar()
        {
            List<Marca> lista = new List<Marca>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("select Id, Descripcion FROM MARCAS;");
                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    Marca aux = new Marca();
                    aux.id = (int)datos.Lector["Id"];
                    aux.descripcion = (string)datos.Lector["Descripcion"];
                    lista.Add(aux);
                }
                return lista;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al cargar la lista de marcas: " + ex.Message);
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
                // Verificar si hay artículos asociados a esta marca
                datos.setearConsulta("SELECT COUNT(*) FROM ARTICULOS WHERE IdMarca = @Id");
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
                    throw new Exception("No se puede eliminar la marca porque tiene " + cantidadArticulos + " artículo(s) asociado(s). Por favor, elimine o modifique los artículos primero.");
                }

                // Si no hay artículos asociados, proceder con la eliminación
                datos.setearConsulta("delete from MARCAS where Id = @Id");
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

        public void modificar(Marca marca)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("update MARCAS set Descripcion = @Descripcion where Id = @Id");
                datos.setearParametro("@Descripcion", marca.descripcion);
                datos.setearParametro("@Id", marca.id);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al modificar la marca: " + ex.Message);
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public void crear(Marca marca)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("insert into MARCAS (Descripcion) values (@Descripcion)");
                datos.setearParametro("@Descripcion", marca.descripcion);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al crear la marca: " + ex.Message);
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
    }
}
