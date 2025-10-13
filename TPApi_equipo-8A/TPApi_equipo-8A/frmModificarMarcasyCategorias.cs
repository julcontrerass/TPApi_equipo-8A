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

namespace TPApi_equipo_8A
{
    public partial class frmModificarMarcasyCategorias : Form
    {
        private string Modificar = "";
        public frmModificarMarcasyCategorias(string aModificar)
        {
            InitializeComponent();
            Modificar = aModificar;

        }

        private void frmModificarMarcasyCategorias_Load(object sender, EventArgs e)
        {
            try
            {
                if (Modificar == "Marca")
                {
                    lblTituloEdicion.Text = "Modificar Marcas";
                    lblNombre.Text = "Nombre de la Marca";
                    MarcaService marcaService = new MarcaService();
                    cbSeleccion.DataSource = marcaService.Listar();
                    cbSeleccion.ValueMember = "id";
                    cbSeleccion.DisplayMember = "descripcion";
                    cbSeleccion.SelectedIndex = -1;
                }
                else if (Modificar == "Categoria")
                {
                    lblTituloEdicion.Text = "Modificar Categorías";
                    lblNombre.Text = "Nombre de la Categoría";
                    CategoriaService categoriaService = new CategoriaService();
                    cbSeleccion.DataSource = categoriaService.Listar();
                    cbSeleccion.ValueMember = "id";
                    cbSeleccion.DisplayMember = "descripcion";
                    cbSeleccion.SelectedIndex = -1;
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void rbuttonModificar_CheckedChanged(object sender, EventArgs e)
        {
            if (rbuttonModificar.Checked)
            {
                txtNombre.Enabled = true;
                cbSeleccion.Enabled = true;

            }
        }

        private void rbCrear_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCrear.Checked)
            {
                txtNombre.Enabled = true;
                cbSeleccion.Enabled = false;
            }

        }

        private void rbEliminar_CheckedChanged(object sender, EventArgs e)
        {
            if (rbEliminar.Checked)
            {
                txtNombre.Enabled = false;
                cbSeleccion.Enabled = true;

            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Modificar == "Categoria")
                {
                    if (rbEliminar.Checked)
                    {
                        try
                        {
                            Categoria categoria = (Categoria)cbSeleccion.SelectedItem;
                            CategoriaService categoriaService = new CategoriaService();
                            categoriaService.eliminar(categoria.id);
                            MessageBox.Show("Categoría eliminada con exito");
                            this.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString());
                        }
                    }
                    else if (rbuttonModificar.Checked)
                    {
                        try
                        {
                            Categoria categoria = (Categoria)cbSeleccion.SelectedItem;
                            categoria.descripcion = txtNombre.Text;
                            CategoriaService categoriaService = new CategoriaService();
                            categoriaService.modificar(categoria);
                            MessageBox.Show("Categoría modificada con exito");
                            this.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString());
                        }
                    }
                    else if (rbCrear.Checked)
                    {
                        try
                        {
                            Categoria categoria = new Categoria();
                            categoria.descripcion = txtNombre.Text;
                            CategoriaService categoriaService = new CategoriaService();
                            categoriaService.crear(categoria);
                            MessageBox.Show("Categoría creada con exito");
                            this.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString());
                        }
                    }
                    else
                    {
                        MessageBox.Show("Seleccione una opción");
                    }




                }
                else if (Modificar == "Marca")
                {
                    if (rbEliminar.Checked)
                    {
                        try
                        {
                            Marca marca = (Marca)cbSeleccion.SelectedItem;
                            MarcaService marcaService = new MarcaService();
                            marcaService.eliminar(marca.id);
                            MessageBox.Show("Marca eliminada con exito");
                            this.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString());
                        }
                    }
                    else if (rbuttonModificar.Checked)
                    {
                        try
                        {
                            Marca marca = (Marca)cbSeleccion.SelectedItem;
                            marca.descripcion = txtNombre.Text;
                            MarcaService marcaService = new MarcaService();
                            marcaService.modificar(marca);
                            MessageBox.Show("Marca modificada con exito");
                            this.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString());
                        }
                    }
                    else if (rbCrear.Checked)
                    {
                        try
                        {
                            Marca marca = new Marca();
                            marca.descripcion = txtNombre.Text;
                            MarcaService marcaService = new MarcaService();
                            marcaService.crear(marca);
                            MessageBox.Show("Marca creada con exito");
                            this.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString());
                        }
                    }
                    else
                    {
                        MessageBox.Show("Seleccione una opción");
                    }

                }
               

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            {
                this.Close();
            }
        }
    }
}
