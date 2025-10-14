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
                // Validaciones
                if (string.IsNullOrWhiteSpace(txbCodigoAIngresar.Text))
                {
                    MessageBox.Show("Por favor, ingrese el código del artículo.", "Campo requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txbCodigoAIngresar.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(txbNombreAIngresar.Text))
                {
                    MessageBox.Show("Por favor, ingrese el nombre del artículo.", "Campo requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txbNombreAIngresar.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(txbDescripcionAIngresar.Text))
                {
                    MessageBox.Show("Por favor, ingrese la descripción del artículo.", "Campo requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txbDescripcionAIngresar.Focus();
                    return;
                }

                if (cbxMarca.SelectedValue == null || (int)cbxMarca.SelectedValue == 0)
                {
                    MessageBox.Show("Por favor, seleccione una marca válida.", "Campo requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cbxMarca.Focus();
                    return;
                }

                if (cbxCategoria.SelectedValue == null || (int)cbxCategoria.SelectedValue == 0)
                {
                    MessageBox.Show("Por favor, seleccione una categoría válida.", "Campo requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cbxCategoria.Focus();
                    return;
                }

                // Validación de precio
                decimal precio;
                if (!decimal.TryParse(txbPrecioAIngresar.Text, out precio))
                {
                    MessageBox.Show("Por favor, ingrese un precio válido.", "Precio inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txbPrecioAIngresar.Focus();
                    return;
                }

                if (precio <= 0)
                {
                    MessageBox.Show("El precio debe ser mayor a cero.", "Precio inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txbPrecioAIngresar.Focus();
                    return;
                }

                if (articulo == null)
                    articulo = new Articulo();

                articulo.codigoArticulo = txbCodigoAIngresar.Text.Trim();
                articulo.nombre = txbNombreAIngresar.Text.Trim();
                articulo.descripcion = txbDescripcionAIngresar.Text.Trim();
                articulo.precio = precio;
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
                MessageBox.Show("Error al guardar el artículo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmAltaArticulo_Load(object sender, EventArgs e)
        {
            try
            {
                MarcaService marca = new MarcaService();
                List<Marca> listaMarcas = marca.Listar();
                listaMarcas.Insert(0, new Marca { id = 0, descripcion = "Seleccione una marca..." });
                cbxMarca.DataSource = listaMarcas;
                cbxMarca.DisplayMember = "descripcion";
                cbxMarca.ValueMember = "id";

                CategoriaService categoria = new CategoriaService();
                List<Categoria> listaCategorias = categoria.Listar();
                listaCategorias.Insert(0, new Categoria { id = 0, descripcion = "Seleccione una categoría..." });
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
                MessageBox.Show("Error al cargar el formulario: " + ex.Message);
            }
        }

        private void btnAgregarImagen_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txbUrlImagen.Text))
            {
                MessageBox.Show("Por favor, ingrese una URL de imagen válida.", "URL requerida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txbUrlImagen.Focus();
                return;
            }

            string nuevaImagen = txbUrlImagen.Text.Trim();
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
