namespace TPApi_equipo_8A
{
    partial class frmModificarMarcasyCategorias
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
            this.rbCrear = new System.Windows.Forms.RadioButton();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.rbEliminar = new System.Windows.Forms.RadioButton();
            this.rbuttonModificar = new System.Windows.Forms.RadioButton();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.cbSeleccion = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblTituloEdicion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rbCrear
            // 
            this.rbCrear.AutoSize = true;
            this.rbCrear.Location = new System.Drawing.Point(170, 81);
            this.rbCrear.Name = "rbCrear";
            this.rbCrear.Size = new System.Drawing.Size(50, 17);
            this.rbCrear.TabIndex = 21;
            this.rbCrear.Text = "Crear";
            this.rbCrear.UseVisualStyleBackColor = true;
            this.rbCrear.CheckedChanged += new System.EventHandler(this.rbCrear_CheckedChanged);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(202, 194);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 20;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // rbEliminar
            // 
            this.rbEliminar.AutoSize = true;
            this.rbEliminar.Location = new System.Drawing.Point(226, 81);
            this.rbEliminar.Name = "rbEliminar";
            this.rbEliminar.Size = new System.Drawing.Size(61, 17);
            this.rbEliminar.TabIndex = 19;
            this.rbEliminar.Text = "Eliminar";
            this.rbEliminar.UseVisualStyleBackColor = true;
            this.rbEliminar.CheckedChanged += new System.EventHandler(this.rbEliminar_CheckedChanged);
            // 
            // rbuttonModificar
            // 
            this.rbuttonModificar.AutoSize = true;
            this.rbuttonModificar.Checked = true;
            this.rbuttonModificar.Location = new System.Drawing.Point(96, 81);
            this.rbuttonModificar.Name = "rbuttonModificar";
            this.rbuttonModificar.Size = new System.Drawing.Size(68, 17);
            this.rbuttonModificar.TabIndex = 18;
            this.rbuttonModificar.TabStop = true;
            this.rbuttonModificar.Text = "Modificar";
            this.rbuttonModificar.UseVisualStyleBackColor = true;
            this.rbuttonModificar.CheckedChanged += new System.EventHandler(this.rbuttonModificar_CheckedChanged);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(121, 194);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmar.TabIndex = 17;
            this.btnConfirmar.Text = "Confirmar ";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // cbSeleccion
            // 
            this.cbSeleccion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSeleccion.FormattingEnabled = true;
            this.cbSeleccion.Location = new System.Drawing.Point(79, 149);
            this.cbSeleccion.Name = "cbSeleccion";
            this.cbSeleccion.Size = new System.Drawing.Size(121, 21);
            this.cbSeleccion.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Selecciona";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(217, 149);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 14;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(219, 133);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 13;
            this.lblNombre.Text = "Nombre";
            // 
            // lblTituloEdicion
            // 
            this.lblTituloEdicion.AutoSize = true;
            this.lblTituloEdicion.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloEdicion.Location = new System.Drawing.Point(74, 24);
            this.lblTituloEdicion.Name = "lblTituloEdicion";
            this.lblTituloEdicion.Size = new System.Drawing.Size(264, 28);
            this.lblTituloEdicion.TabIndex = 12;
            this.lblTituloEdicion.Text = "Modificacion de marcas";
            // 
            // frmModificarMarcasyCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 254);
            this.Controls.Add(this.rbCrear);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.rbEliminar);
            this.Controls.Add(this.rbuttonModificar);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.cbSeleccion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblTituloEdicion);
            this.Name = "frmModificarMarcasyCategorias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificacion Marcas y Categorias";
            this.Load += new System.EventHandler(this.frmModificarMarcasyCategorias_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbCrear;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.RadioButton rbEliminar;
        private System.Windows.Forms.RadioButton rbuttonModificar;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.ComboBox cbSeleccion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblTituloEdicion;
    }
}