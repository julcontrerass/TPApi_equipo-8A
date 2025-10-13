namespace TPApi_equipo_8A
{
    partial class frmAltaArticulo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblTituloNuevoArticulo = new System.Windows.Forms.Label();
            this.cbxCategoria = new System.Windows.Forms.ComboBox();
            this.cbxMarca = new System.Windows.Forms.ComboBox();
            this.lblUrlImagenAIngresar = new System.Windows.Forms.Label();
            this.txbPrecioAIngresar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.txbDescripcionAIngresar = new System.Windows.Forms.TextBox();
            this.txbNombreAIngresar = new System.Windows.Forms.TextBox();
            this.txbCodigoAIngresar = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txbUrlImagen = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnAgregarImagen = new System.Windows.Forms.Button();
            this.lwImagenes = new System.Windows.Forms.ListView();
            this.btnEliminarImagen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTituloNuevoArticulo
            // 
            this.lblTituloNuevoArticulo.AutoSize = true;
            this.lblTituloNuevoArticulo.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloNuevoArticulo.Location = new System.Drawing.Point(85, 32);
            this.lblTituloNuevoArticulo.Name = "lblTituloNuevoArticulo";
            this.lblTituloNuevoArticulo.Size = new System.Drawing.Size(293, 36);
            this.lblTituloNuevoArticulo.TabIndex = 35;
            this.lblTituloNuevoArticulo.Text = "Crear nuevo articulo";
            // 
            // cbxCategoria
            // 
            this.cbxCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCategoria.FormattingEnabled = true;
            this.cbxCategoria.Location = new System.Drawing.Point(134, 184);
            this.cbxCategoria.Margin = new System.Windows.Forms.Padding(2);
            this.cbxCategoria.Name = "cbxCategoria";
            this.cbxCategoria.Size = new System.Drawing.Size(195, 21);
            this.cbxCategoria.TabIndex = 34;
            // 
            // cbxMarca
            // 
            this.cbxMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMarca.FormattingEnabled = true;
            this.cbxMarca.Location = new System.Drawing.Point(134, 161);
            this.cbxMarca.Margin = new System.Windows.Forms.Padding(2);
            this.cbxMarca.Name = "cbxMarca";
            this.cbxMarca.Size = new System.Drawing.Size(195, 21);
            this.cbxMarca.TabIndex = 33;
            // 
            // lblUrlImagenAIngresar
            // 
            this.lblUrlImagenAIngresar.AutoSize = true;
            this.lblUrlImagenAIngresar.Location = new System.Drawing.Point(51, 242);
            this.lblUrlImagenAIngresar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUrlImagenAIngresar.Name = "lblUrlImagenAIngresar";
            this.lblUrlImagenAIngresar.Size = new System.Drawing.Size(61, 13);
            this.lblUrlImagenAIngresar.TabIndex = 32;
            this.lblUrlImagenAIngresar.Text = "Url Imagen:";
            // 
            // txbPrecioAIngresar
            // 
            this.txbPrecioAIngresar.Location = new System.Drawing.Point(134, 210);
            this.txbPrecioAIngresar.Margin = new System.Windows.Forms.Padding(2);
            this.txbPrecioAIngresar.Name = "txbPrecioAIngresar";
            this.txbPrecioAIngresar.Size = new System.Drawing.Size(195, 20);
            this.txbPrecioAIngresar.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 214);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "Precio:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 186);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Categoria:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 165);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Marca:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(237, 379);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(58, 19);
            this.btnCancelar.TabIndex = 26;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(132, 379);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(59, 19);
            this.btnAceptar.TabIndex = 25;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // txbDescripcionAIngresar
            // 
            this.txbDescripcionAIngresar.Location = new System.Drawing.Point(134, 137);
            this.txbDescripcionAIngresar.Margin = new System.Windows.Forms.Padding(2);
            this.txbDescripcionAIngresar.Name = "txbDescripcionAIngresar";
            this.txbDescripcionAIngresar.Size = new System.Drawing.Size(195, 20);
            this.txbDescripcionAIngresar.TabIndex = 24;
            // 
            // txbNombreAIngresar
            // 
            this.txbNombreAIngresar.Location = new System.Drawing.Point(134, 114);
            this.txbNombreAIngresar.Margin = new System.Windows.Forms.Padding(2);
            this.txbNombreAIngresar.Name = "txbNombreAIngresar";
            this.txbNombreAIngresar.Size = new System.Drawing.Size(195, 20);
            this.txbNombreAIngresar.TabIndex = 23;
            // 
            // txbCodigoAIngresar
            // 
            this.txbCodigoAIngresar.Location = new System.Drawing.Point(134, 86);
            this.txbCodigoAIngresar.Margin = new System.Windows.Forms.Padding(2);
            this.txbCodigoAIngresar.Name = "txbCodigoAIngresar";
            this.txbCodigoAIngresar.Size = new System.Drawing.Size(195, 20);
            this.txbCodigoAIngresar.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 136);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Descripcion: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(71, 116);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Nombre:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(79, 91);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Codigo: ";
            // 
            // txbUrlImagen
            // 
            this.txbUrlImagen.Location = new System.Drawing.Point(134, 240);
            this.txbUrlImagen.Margin = new System.Windows.Forms.Padding(2);
            this.txbUrlImagen.Name = "txbUrlImagen";
            this.txbUrlImagen.Size = new System.Drawing.Size(195, 20);
            this.txbUrlImagen.TabIndex = 31;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // btnAgregarImagen
            // 
            this.btnAgregarImagen.Location = new System.Drawing.Point(334, 238);
            this.btnAgregarImagen.Name = "btnAgregarImagen";
            this.btnAgregarImagen.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarImagen.TabIndex = 37;
            this.btnAgregarImagen.Text = "Agregar";
            this.btnAgregarImagen.UseVisualStyleBackColor = true;
            this.btnAgregarImagen.Click += new System.EventHandler(this.btnAgregarImagen_Click);
            // 
            // lwImagenes
            // 
            this.lwImagenes.HideSelection = false;
            this.lwImagenes.Location = new System.Drawing.Point(134, 265);
            this.lwImagenes.Name = "lwImagenes";
            this.lwImagenes.Size = new System.Drawing.Size(195, 109);
            this.lwImagenes.TabIndex = 38;
            this.lwImagenes.UseCompatibleStateImageBehavior = false;
            this.lwImagenes.View = System.Windows.Forms.View.List;
            // 
            // btnEliminarImagen
            // 
            this.btnEliminarImagen.Location = new System.Drawing.Point(336, 350);
            this.btnEliminarImagen.Name = "btnEliminarImagen";
            this.btnEliminarImagen.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarImagen.TabIndex = 39;
            this.btnEliminarImagen.Text = "Eliminar";
            this.btnEliminarImagen.UseVisualStyleBackColor = true;
            this.btnEliminarImagen.Visible = false;
            this.btnEliminarImagen.Click += new System.EventHandler(this.btnEliminarImagen_Click);
            // 
            // frmAltaArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 469);
            this.Controls.Add(this.btnEliminarImagen);
            this.Controls.Add(this.lwImagenes);
            this.Controls.Add(this.btnAgregarImagen);
            this.Controls.Add(this.lblTituloNuevoArticulo);
            this.Controls.Add(this.cbxCategoria);
            this.Controls.Add(this.cbxMarca);
            this.Controls.Add(this.lblUrlImagenAIngresar);
            this.Controls.Add(this.txbUrlImagen);
            this.Controls.Add(this.txbPrecioAIngresar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txbDescripcionAIngresar);
            this.Controls.Add(this.txbNombreAIngresar);
            this.Controls.Add(this.txbCodigoAIngresar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmAltaArticulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alta Articulo";
            this.Load += new System.EventHandler(this.frmAltaArticulo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTituloNuevoArticulo;
        private System.Windows.Forms.ComboBox cbxCategoria;
        private System.Windows.Forms.ComboBox cbxMarca;
        private System.Windows.Forms.Label lblUrlImagenAIngresar;
        private System.Windows.Forms.TextBox txbPrecioAIngresar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.TextBox txbDescripcionAIngresar;
        private System.Windows.Forms.TextBox txbNombreAIngresar;
        private System.Windows.Forms.TextBox txbCodigoAIngresar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbUrlImagen;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button btnAgregarImagen;
        private System.Windows.Forms.ListView lwImagenes;
        private System.Windows.Forms.Button btnEliminarImagen;
    }
}