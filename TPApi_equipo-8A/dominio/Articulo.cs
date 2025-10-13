using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Articulo
    {
        public int id { get; set; }

        [DisplayName("Cod Articulo")]
        public string codigoArticulo { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public int idMarca { get; set; }
        public int idCategoria { get; set; }
        public decimal precio { get; set; }
        public Marca Marca { get; set; }
        public Categoria Categoria { get; set; }       
        public List<Imagen> URLImagenes { get; set; } = new List<Imagen>();

        public Imagen Imagen { get; set; }
        
    }
}
