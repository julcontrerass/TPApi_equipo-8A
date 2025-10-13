using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using service;
using static System.Net.Mime.MediaTypeNames;

namespace TPApi_equipo_8A
{
    public partial class frmAltaArticulo : Form
    {

        private Articulo articulo = null;

        public frmAltaArticulo()
        {
            InitializeComponent();
        }

        public frmAltaArticulo(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
            Text = "Editar art�culo";
        }



        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            ArticuloService articuloService = new ArticuloService();
            try
            {
                if (articulo == null)
                    articulo = new Articulo();

                articulo.codigoArticulo = txbCodigoAIngresar.Text;
                articulo.nombre = txbNombreAIngresar.Text;
                articulo.descripcion = txbDescripcionAIngresar.Text;
                articulo.precio = decimal.Parse(txbPrecioAIngresar.Text);
                articulo.idMarca = (int)cbxMarca.SelectedValue;
                articulo.idCategoria = (int)cbxCategoria.SelectedValue;
                articulo.Imagen = new Imagen();
                articulo.Imagen.URL = txbUrlImagen.Text?.Trim();
                articulo.URLImagenes.Clear();


                foreach (ListViewItem item in lwImagenes.Items)
                {
                    var url = item.Text?.Trim();
                    if (!string.IsNullOrWhiteSpace(url))
                    {
                        articulo.URLImagenes.Add(new Imagen
                        {
                            URL = url,
                            IdArticulo = articulo.id
                        });
                    }
                }

                if (articulo.id != 0)
                {
                    articuloService.modificar(articulo);
                    MessageBox.Show("Modificado exitosamente");
                }
                else
                {
                    articuloService.agregar(articulo);
                    MessageBox.Show("Agregado exitosamente");
                }
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void frmAltaArticulo_Load(object sender, EventArgs e)
        {
            try
            {
                MarcaService marca = new MarcaService();
                List<Marca> listaMarcas = marca.Listar();
                cbxMarca.DataSource = listaMarcas;
                cbxMarca.DisplayMember = "descripcion";
                cbxMarca.ValueMember = "id";

                CategoriaService categoria = new CategoriaService();
                List<Categoria> listaCategorias = categoria.Listar();
                cbxCategoria.DataSource = listaCategorias;
                cbxCategoria.DisplayMember = "descripcion";
                cbxCategoria.ValueMember = "id";

                if (articulo != null)
                {
                    btnEliminarImagen.Visible = true;
                    lblTituloNuevoArticulo.Text = "Editar articulo";

                    txbCodigoAIngresar.Text = articulo.codigoArticulo;
                    txbNombreAIngresar.Text = articulo.nombre;
                    txbDescripcionAIngresar.Text = articulo.descripcion;
                    txbPrecioAIngresar.Text = articulo.precio.ToString();
                    cbxMarca.SelectedValue = articulo.idMarca;
                    cbxCategoria.SelectedValue = articulo.idCategoria;
                    foreach (var img in articulo.URLImagenes)
                        lwImagenes.Items.Add(img.URL);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnAgregarImagen_Click(object sender, EventArgs e)
        {
            string nuevaImagen = txbUrlImagen.Text;
            lwImagenes.Items.Add(nuevaImagen);
            txbUrlImagen.Clear();

        }

        private void btnEliminarImagen_Click(object sender, EventArgs e)
        {
            if (lwImagenes.SelectedItems.Count > 0)
            {
                lwImagenes.Items.Remove(lwImagenes.SelectedItems[0]);
            }
            else
            {
                MessageBox.Show("Seleccione una imagen para eliminar.");
            }

        }
    }
}
