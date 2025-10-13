namespace TPApi_equipo_8A
{
    partial class GertorDeArticulos
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pbImagenProducto = new System.Windows.Forms.PictureBox();
            this.lblCategoriaFiltro = new System.Windows.Forms.Label();
            this.lblMarcaFiltro = new System.Windows.Forms.Label();
            this.cbFiltroCategoria = new System.Windows.Forms.ComboBox();
            this.cbFiltroMarca = new System.Windows.Forms.ComboBox();
            this.lblFiltro = new System.Windows.Forms.Label();
            this.lblBuscador = new System.Windows.Forms.Label();
            this.txtbBuscador = new System.Windows.Forms.TextBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dgvTablaArticulos = new System.Windows.Forms.DataGridView();
            this.lblTituloArticulos = new System.Windows.Forms.Label();
            this.btnImagenAnterior = new System.Windows.Forms.Button();
            this.btnImagenSiguiente = new System.Windows.Forms.Button();
            this.labelimagenActual = new System.Windows.Forms.Label();
            this.btnModCategoria = new System.Windows.Forms.Button();
            this.btnModMarcas = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagenProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablaArticulos)).BeginInit();
            this.SuspendLayout();
            // 
            // pbImagenProducto
            // 
            this.pbImagenProducto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbImagenProducto.Location = new System.Drawing.Point(866, 122);
            this.pbImagenProducto.Name = "pbImagenProducto";
            this.pbImagenProducto.Size = new System.Drawing.Size(337, 219);
            this.pbImagenProducto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImagenProducto.TabIndex = 27;
            this.pbImagenProducto.TabStop = false;
            // 
            // lblCategoriaFiltro
            // 
            this.lblCategoriaFiltro.AutoSize = true;
            this.lblCategoriaFiltro.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoriaFiltro.Location = new System.Drawing.Point(21, 221);
            this.lblCategoriaFiltro.Name = "lblCategoriaFiltro";
            this.lblCategoriaFiltro.Size = new System.Drawing.Size(57, 16);
            this.lblCategoriaFiltro.TabIndex = 25;
            this.lblCategoriaFiltro.Text = "Categoria";
            // 
            // lblMarcaFiltro
            // 
            this.lblMarcaFiltro.AutoSize = true;
            this.lblMarcaFiltro.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarcaFiltro.Location = new System.Drawing.Point(21, 170);
            this.lblMarcaFiltro.Name = "lblMarcaFiltro";
            this.lblMarcaFiltro.Size = new System.Drawing.Size(45, 17);
            this.lblMarcaFiltro.TabIndex = 24;
            this.lblMarcaFiltro.Text = "Marca";
            // 
            // cbFiltroCategoria
            // 
            this.cbFiltroCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFiltroCategoria.FormattingEnabled = true;
            this.cbFiltroCategoria.Location = new System.Drawing.Point(24, 237);
            this.cbFiltroCategoria.Name = "cbFiltroCategoria";
            this.cbFiltroCategoria.Size = new System.Drawing.Size(121, 21);
            this.cbFiltroCategoria.TabIndex = 23;
            this.cbFiltroCategoria.SelectedIndexChanged += new System.EventHandler(this.cbFiltroCategoria_SelectedIndexChanged);
            // 
            // cbFiltroMarca
            // 
            this.cbFiltroMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFiltroMarca.FormattingEnabled = true;
            this.cbFiltroMarca.Location = new System.Drawing.Point(24, 190);
            this.cbFiltroMarca.Name = "cbFiltroMarca";
            this.cbFiltroMarca.Size = new System.Drawing.Size(121, 21);
            this.cbFiltroMarca.TabIndex = 22;
            this.cbFiltroMarca.SelectedIndexChanged += new System.EventHandler(this.cbFiltroMarca_SelectedIndexChanged);
            // 
            // lblFiltro
            // 
            this.lblFiltro.AutoSize = true;
            this.lblFiltro.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltro.Location = new System.Drawing.Point(20, 138);
            this.lblFiltro.Name = "lblFiltro";
            this.lblFiltro.Size = new System.Drawing.Size(49, 21);
            this.lblFiltro.TabIndex = 21;
            this.lblFiltro.Text = "Filtro";
            // 
            // lblBuscador
            // 
            this.lblBuscador.AutoSize = true;
            this.lblBuscador.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscador.Location = new System.Drawing.Point(272, 101);
            this.lblBuscador.Name = "lblBuscador";
            this.lblBuscador.Size = new System.Drawing.Size(53, 19);
            this.lblBuscador.TabIndex = 20;
            this.lblBuscador.Text = "Buscar:";
            // 
            // txtbBuscador
            // 
            this.txtbBuscador.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbBuscador.Location = new System.Drawing.Point(331, 103);
            this.txtbBuscador.Name = "txtbBuscador";
            this.txtbBuscador.Size = new System.Drawing.Size(183, 20);
            this.txtbBuscador.TabIndex = 19;
            this.txtbBuscador.TextChanged += new System.EventHandler(this.txtbBuscador_TextChanged);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEliminar.Location = new System.Drawing.Point(637, 349);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 18;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEditar.Location = new System.Drawing.Point(494, 349);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 17;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAgregar.Location = new System.Drawing.Point(350, 349);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 16;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // dgvTablaArticulos
            // 
            this.dgvTablaArticulos.AllowUserToAddRows = false;
            this.dgvTablaArticulos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvTablaArticulos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTablaArticulos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTablaArticulos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvTablaArticulos.BackgroundColor = System.Drawing.Color.White;
            this.dgvTablaArticulos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTablaArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTablaArticulos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvTablaArticulos.Location = new System.Drawing.Point(180, 138);
            this.dgvTablaArticulos.MaximumSize = new System.Drawing.Size(1000, 600);
            this.dgvTablaArticulos.MultiSelect = false;
            this.dgvTablaArticulos.Name = "dgvTablaArticulos";
            this.dgvTablaArticulos.ReadOnly = true;
            this.dgvTablaArticulos.RowHeadersWidth = 62;
            this.dgvTablaArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTablaArticulos.Size = new System.Drawing.Size(680, 190);
            this.dgvTablaArticulos.TabIndex = 15;
            this.dgvTablaArticulos.SelectionChanged += new System.EventHandler(this.dgvTablaArticulos_SelectionChanged);
            // 
            // lblTituloArticulos
            // 
            this.lblTituloArticulos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTituloArticulos.AutoSize = true;
            this.lblTituloArticulos.Font = new System.Drawing.Font("Microsoft YaHei UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloArticulos.Location = new System.Drawing.Point(324, 42);
            this.lblTituloArticulos.Name = "lblTituloArticulos";
            this.lblTituloArticulos.Size = new System.Drawing.Size(229, 42);
            this.lblTituloArticulos.TabIndex = 14;
            this.lblTituloArticulos.Text = "Tus Articulos";
            // 
            // btnImagenAnterior
            // 
            this.btnImagenAnterior.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImagenAnterior.Location = new System.Drawing.Point(964, 373);
            this.btnImagenAnterior.Margin = new System.Windows.Forms.Padding(1);
            this.btnImagenAnterior.Name = "btnImagenAnterior";
            this.btnImagenAnterior.Size = new System.Drawing.Size(74, 24);
            this.btnImagenAnterior.TabIndex = 28;
            this.btnImagenAnterior.Text = "Anterior";
            this.btnImagenAnterior.UseVisualStyleBackColor = true;
            this.btnImagenAnterior.Click += new System.EventHandler(this.btnImagenAnterior_Click);
            // 
            // btnImagenSiguiente
            // 
            this.btnImagenSiguiente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImagenSiguiente.Location = new System.Drawing.Point(1040, 373);
            this.btnImagenSiguiente.Margin = new System.Windows.Forms.Padding(1);
            this.btnImagenSiguiente.Name = "btnImagenSiguiente";
            this.btnImagenSiguiente.Size = new System.Drawing.Size(74, 24);
            this.btnImagenSiguiente.TabIndex = 29;
            this.btnImagenSiguiente.Text = "Siguiente";
            this.btnImagenSiguiente.UseVisualStyleBackColor = true;
            this.btnImagenSiguiente.Click += new System.EventHandler(this.btnImagenSiguiente_Click);
            // 
            // labelimagenActual
            // 
            this.labelimagenActual.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelimagenActual.AutoSize = true;
            this.labelimagenActual.Location = new System.Drawing.Point(996, 350);
            this.labelimagenActual.Name = "labelimagenActual";
            this.labelimagenActual.Size = new System.Drawing.Size(42, 13);
            this.labelimagenActual.TabIndex = 30;
            this.labelimagenActual.Text = "Imagen";
            // 
            // btnModCategoria
            // 
            this.btnModCategoria.Location = new System.Drawing.Point(24, 318);
            this.btnModCategoria.Name = "btnModCategoria";
            this.btnModCategoria.Size = new System.Drawing.Size(121, 23);
            this.btnModCategoria.TabIndex = 32;
            this.btnModCategoria.Text = "Modificar Categorias";
            this.btnModCategoria.UseVisualStyleBackColor = true;
            this.btnModCategoria.Click += new System.EventHandler(this.btnModCategoria_Click);
            // 
            // btnModMarcas
            // 
            this.btnModMarcas.Location = new System.Drawing.Point(24, 275);
            this.btnModMarcas.Name = "btnModMarcas";
            this.btnModMarcas.Size = new System.Drawing.Size(121, 23);
            this.btnModMarcas.TabIndex = 31;
            this.btnModMarcas.Text = "Modificar marcas";
            this.btnModMarcas.UseVisualStyleBackColor = true;
            this.btnModMarcas.Click += new System.EventHandler(this.btnModMarcas_Click);
            // 
            // GertorDeArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1283, 554);
            this.Controls.Add(this.btnModCategoria);
            this.Controls.Add(this.btnModMarcas);
            this.Controls.Add(this.labelimagenActual);
            this.Controls.Add(this.btnImagenSiguiente);
            this.Controls.Add(this.btnImagenAnterior);
            this.Controls.Add(this.pbImagenProducto);
            this.Controls.Add(this.lblCategoriaFiltro);
            this.Controls.Add(this.lblMarcaFiltro);
            this.Controls.Add(this.cbFiltroCategoria);
            this.Controls.Add(this.cbFiltroMarca);
            this.Controls.Add(this.lblFiltro);
            this.Controls.Add(this.lblBuscador);
            this.Controls.Add(this.txtbBuscador);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dgvTablaArticulos);
            this.Controls.Add(this.lblTituloArticulos);
            this.MinimumSize = new System.Drawing.Size(1282, 581);
            this.Name = "GertorDeArticulos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestor De Articulos";
            this.Load += new System.EventHandler(this.GertorDeArticulos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbImagenProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablaArticulos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbImagenProducto;
        private System.Windows.Forms.Label lblCategoriaFiltro;
        private System.Windows.Forms.Label lblMarcaFiltro;
        private System.Windows.Forms.ComboBox cbFiltroCategoria;
        private System.Windows.Forms.ComboBox cbFiltroMarca;
        private System.Windows.Forms.Label lblFiltro;
        private System.Windows.Forms.Label lblBuscador;
        private System.Windows.Forms.TextBox txtbBuscador;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView dgvTablaArticulos;
        private System.Windows.Forms.Label lblTituloArticulos;
        private System.Windows.Forms.Button btnImagenAnterior;
        private System.Windows.Forms.Button btnImagenSiguiente;
        private System.Windows.Forms.Label labelimagenActual;
        private System.Windows.Forms.Button btnModCategoria;
        private System.Windows.Forms.Button btnModMarcas;
    }
}


