using dominio;
using service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPApi_equipo_8A
{
    public partial class GertorDeArticulos : Form
    {
        public GertorDeArticulos()
        {
            InitializeComponent();
        }
        private ArticuloService ArticuloService{ get; set; } = new ArticuloService();
        private List<Articulo> listaArticulos {  get; set; }
        private Articulo ArticuloActual { get; set; }
        private int indexImagenActual { get; set; }
        


        // Métodos de clase
        private void cargarTabla()

        {            
            listaArticulos = ArticuloService.Listar();

            dgvTablaArticulos.DataSource = listaArticulos;
            ArticuloActual = listaArticulos[0];
            FormatearYOcultarColumnas();        

            indexImagenActual = 0;
            labelimagenActual.Text = "Imagen " + (indexImagenActual + 1).ToString() + " de " + ArticuloActual.URLImagenes.Count.ToString();
            cargarImagen(indexImagenActual);

            if (ArticuloActual.URLImagenes.Count < 2)
            {
                btnImagenSiguiente.Enabled = false;
                btnImagenAnterior.Enabled = false;
            }

           
        }
        private void cargarImagen(int nuevoIndex)
        {

            labelimagenActual.Text = "Imagen " + (indexImagenActual + 1).ToString() + " de " + ArticuloActual.URLImagenes.Count.ToString();
            string imagenBackup = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSjOZugSlXrDIB3SLtuip9ZDU1iJScEqfby_Q&s";
            string imagenArticuloActual = ArticuloActual.URLImagenes[nuevoIndex].URL;

            // Botones imagen anterior-siguiente:
            if (ArticuloActual.URLImagenes.Count < 2)
            {
                btnImagenAnterior.Enabled = false;
                btnImagenSiguiente.Enabled = false;
            }
            else
            {
                btnImagenAnterior.Visible = true;
                btnImagenSiguiente.Visible = true;
                btnImagenAnterior.Enabled = true;
                btnImagenSiguiente.Enabled = true;
            }



            try
            {
                pbImagenProducto.Load(imagenArticuloActual);

            }
            catch (Exception)
            {
                pbImagenProducto.Load(imagenBackup);
            }
        }

        private void cambiarImagen(int nuevoIndice)
        {   
             
                
              int potencialNuevoindex = indexImagenActual + nuevoIndice;

            if (potencialNuevoindex < 0 || potencialNuevoindex >= ArticuloActual.URLImagenes.Count)
            {
                return;
            }
            else
            {

                indexImagenActual = potencialNuevoindex;                
                labelimagenActual.Text = "Imagen " + (indexImagenActual + 1).ToString() + " de " + ArticuloActual.URLImagenes.Count.ToString();
                cargarImagen(indexImagenActual);
                mostrarUOcultarImagenYSelector(listaArticulos, ArticuloActual);

            }


        }

        
        private void mostrarUOcultarImagenYSelector(List<Articulo> listaArticulos, Articulo articuloSeleccionado)
        {

            if(listaArticulos.Count == 0 || articuloSeleccionado.URLImagenes[indexImagenActual].URL == "")
            {
                pbImagenProducto.Visible = false;
                btnImagenAnterior.Visible = false;
                btnImagenSiguiente.Visible = false;
                labelimagenActual.Visible = false;
               
            }else
            {
                pbImagenProducto.Visible = true;
                btnImagenAnterior.Visible = true;
                btnImagenSiguiente.Visible = true;
                labelimagenActual.Visible = true;
            }           
        }

        private void FormatearYOcultarColumnas() {
            dgvTablaArticulos.Columns["idCategoria"].Visible = false;
            dgvTablaArticulos.Columns["idMarca"].Visible = false;
            dgvTablaArticulos.Columns["precio"].DefaultCellStyle.Format = "N2";
            dgvTablaArticulos.Columns["imagen"].Visible = false;

        }

        private void CargarMarcas()
        {
            cbFiltroMarca.Items.Clear();
            MarcaService marcaService = new MarcaService();
            List<Marca> listadoMarcas = marcaService.Listar();
            cbFiltroMarca.Items.Add("");
            listadoMarcas.ForEach(marca => cbFiltroMarca.Items.Add(marca.descripcion));
        }
        private void CargarCategorias()
        {
            cbFiltroCategoria.Items.Clear();
            CategoriaService categoriaService = new CategoriaService();
            List<Categoria> listaCategorias = categoriaService.Listar();
            cbFiltroCategoria.Items.Add("");
            listaCategorias.ForEach(categoria => cbFiltroCategoria.Items.Add(categoria.descripcion));
        }
        private void filtrarPorMarcaOCategoria()
        {           
            string filtroMarca = "";
            string filtroCategoria = "";
            txtbBuscador.Text = "";

            if (cbFiltroMarca.SelectedItem != null)
            {
                filtroMarca = cbFiltroMarca.SelectedItem.ToString();
            }
            if (cbFiltroCategoria.SelectedItem != null)
            {
                filtroCategoria = cbFiltroCategoria.SelectedItem.ToString();
            }

            if (filtroMarca == "" && filtroCategoria == "")
            {
                dgvTablaArticulos.DataSource = null;
                dgvTablaArticulos.Rows.Clear();
                dgvTablaArticulos.DataSource = listaArticulos;                
                return;
            }

            List<Articulo> listaArticulosFiltrada = ArticuloService.filtroAvanzado(filtroMarca, filtroCategoria);

            dgvTablaArticulos.DataSource = null;
            dgvTablaArticulos.Rows.Clear();
            dgvTablaArticulos.DataSource = listaArticulosFiltrada;
        }
          
     

        //eventos:
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAltaArticulo alta = new frmAltaArticulo();
            alta.ShowDialog();
            cargarTabla();

        }
        private void GertorDeArticulos_Load(object sender, EventArgs e)
        {
            cargarTabla();
            CargarCategorias();
            CargarMarcas();
        }
        private void dgvTablaArticulos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvTablaArticulos.CurrentRow == null) return;
            ArticuloActual = ((Articulo)dgvTablaArticulos.CurrentRow.DataBoundItem);
            indexImagenActual = 0;
            cambiarImagen(0);
            FormatearYOcultarColumnas();
        }
        private void btnImagenSiguiente_Click(object sender, EventArgs e)
        {
            int cantidadDeImagenesArticulo = ArticuloActual.URLImagenes.Count;

            if (cantidadDeImagenesArticulo == 1) return;

            cambiarImagen(1);
        }
        private void btnImagenAnterior_Click(object sender, EventArgs e)
        {

            int cantidadDeImagenesArticulo = ArticuloActual.URLImagenes.Count;

            if (cantidadDeImagenesArticulo == 1) return;

            cambiarImagen(-1);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ArticuloService articuloService = new ArticuloService();
            Articulo seleccionado;
            try
            {
                DialogResult resultado = MessageBox.Show("¿Seguro que desea eliminar el artículo?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (resultado == DialogResult.Yes)
                {
                    seleccionado = (Articulo)dgvTablaArticulos.CurrentRow.DataBoundItem;
                    articuloService.eliminar(seleccionado.id);
                    MessageBox.Show("Artículo eliminado");
                }
                cargarTabla();
                eliminarFiltros();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }


        private void btnEditar_Click(object sender, EventArgs e)
        {
            Articulo seleccionado;
            if (dgvTablaArticulos.CurrentRow == null)
            {
                MessageBox.Show("No hay ningún artículo seleccionado");
                return;
            }
            seleccionado = (Articulo)dgvTablaArticulos.CurrentRow.DataBoundItem;
            frmAltaArticulo modificar = new frmAltaArticulo(seleccionado);
            modificar.ShowDialog();
            cargarTabla();
            eliminarFiltros();
        }


        private void txtbBuscador_TextChanged(object sender, EventArgs e)
        {            
            //filtrar por nombre o marca
            string busqueda = txtbBuscador.Text;            
            List<Articulo> listaFiltrada;
            if (busqueda.Length >= 2)
            {
                listaFiltrada = listaArticulos.FindAll(el => el.nombre.ToUpper().Contains(busqueda.ToUpper()) || el.Marca.descripcion.ToUpper().Contains(busqueda.ToUpper()));

                    dgvTablaArticulos.DataSource = null;
                    dgvTablaArticulos.Rows.Clear();
                    dgvTablaArticulos.DataSource = listaFiltrada;
                }               
            
            else
            {
                dgvTablaArticulos.DataSource = null;
                dgvTablaArticulos.Rows.Clear();
                dgvTablaArticulos.DataSource = listaArticulos;
            }


        }

       
        private void btnModMarcas_Click(object sender, EventArgs e)
        {
            frmModificarMarcasyCategorias frmModificarMarcasyCategorias = new frmModificarMarcasyCategorias("Marca");
            frmModificarMarcasyCategorias.ShowDialog();
            cargarTabla();
            CargarMarcas();
        }

        private void btnModCategoria_Click(object sender, EventArgs e)
        {
            frmModificarMarcasyCategorias frmModificarMarcasyCategorias = new frmModificarMarcasyCategorias("Categoria");
            frmModificarMarcasyCategorias.ShowDialog();
            cargarTabla();
            CargarCategorias();
            eliminarFiltros();
        }              

        private void eliminarFiltros()
        {            
            cbFiltroMarca.SelectedIndex = 0;
            cbFiltroCategoria.SelectedIndex = 0;    
           
        }
        private void cbFiltroCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            filtrarPorMarcaOCategoria();
        }

        private void cbFiltroMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            filtrarPorMarcaOCategoria();
        }
    }
}

