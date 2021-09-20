namespace Presentacion_IU
{
    partial class FrmProveedor
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
            this.tabProveedor = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.gbxControles = new System.Windows.Forms.GroupBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.tbxNroProveedor = new System.Windows.Forms.TextBox();
            this.dtgProveedores = new System.Windows.Forms.DataGridView();
            this.tbxDireccion = new System.Windows.Forms.TextBox();
            this.tbxLocalidad = new System.Windows.Forms.TextBox();
            this.tbxRazonSocial = new System.Windows.Forms.TextBox();
            this.tbxTelefono = new System.Windows.Forms.TextBox();
            this.tbxEmail = new System.Windows.Forms.TextBox();
            this.tbxApellido = new System.Windows.Forms.TextBox();
            this.tbxNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxCUIT = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblCUIT = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblRazonSocial = new System.Windows.Forms.Label();
            this.lblLocalidad = new System.Windows.Forms.Label();
            this.lblNroProveedor = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.tabProveedor.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.gbxControles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProveedores)).BeginInit();
            this.SuspendLayout();
            // 
            // tabProveedor
            // 
            this.tabProveedor.Controls.Add(this.tabPage1);
            this.tabProveedor.Location = new System.Drawing.Point(12, 27);
            this.tabProveedor.Name = "tabProveedor";
            this.tabProveedor.SelectedIndex = 0;
            this.tabProveedor.Size = new System.Drawing.Size(654, 535);
            this.tabProveedor.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tabPage1.Controls.Add(this.gbxControles);
            this.tabPage1.Controls.Add(this.tbxNroProveedor);
            this.tabPage1.Controls.Add(this.dtgProveedores);
            this.tabPage1.Controls.Add(this.tbxDireccion);
            this.tabPage1.Controls.Add(this.tbxLocalidad);
            this.tabPage1.Controls.Add(this.tbxRazonSocial);
            this.tabPage1.Controls.Add(this.tbxTelefono);
            this.tabPage1.Controls.Add(this.tbxEmail);
            this.tabPage1.Controls.Add(this.tbxApellido);
            this.tabPage1.Controls.Add(this.tbxNombre);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.tbxCUIT);
            this.tabPage1.Controls.Add(this.lblTelefono);
            this.tabPage1.Controls.Add(this.lblCUIT);
            this.tabPage1.Controls.Add(this.lblDireccion);
            this.tabPage1.Controls.Add(this.lblNombre);
            this.tabPage1.Controls.Add(this.lblRazonSocial);
            this.tabPage1.Controls.Add(this.lblLocalidad);
            this.tabPage1.Controls.Add(this.lblNroProveedor);
            this.tabPage1.Controls.Add(this.lblApellido);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(646, 509);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Empleado";
            // 
            // gbxControles
            // 
            this.gbxControles.Controls.Add(this.btnGuardar);
            this.gbxControles.Controls.Add(this.btnCancelar);
            this.gbxControles.Controls.Add(this.btnEliminar);
            this.gbxControles.Location = new System.Drawing.Point(86, 263);
            this.gbxControles.Name = "gbxControles";
            this.gbxControles.Size = new System.Drawing.Size(470, 52);
            this.gbxControles.TabIndex = 10;
            this.gbxControles.TabStop = false;
            this.gbxControles.Text = "Controles";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(41, 23);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 15;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(330, 23);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 14;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(183, 23);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 13;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // tbxNroProveedor
            // 
            this.tbxNroProveedor.Location = new System.Drawing.Point(211, 29);
            this.tbxNroProveedor.Name = "tbxNroProveedor";
            this.tbxNroProveedor.ReadOnly = true;
            this.tbxNroProveedor.Size = new System.Drawing.Size(70, 20);
            this.tbxNroProveedor.TabIndex = 4;
            this.tbxNroProveedor.TabStop = false;
            // 
            // dtgProveedores
            // 
            this.dtgProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgProveedores.Location = new System.Drawing.Point(6, 321);
            this.dtgProveedores.Name = "dtgProveedores";
            this.dtgProveedores.ReadOnly = true;
            this.dtgProveedores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgProveedores.Size = new System.Drawing.Size(634, 166);
            this.dtgProveedores.TabIndex = 0;
            this.dtgProveedores.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtgProveedores_CellDoubleClick);
            // 
            // tbxDireccion
            // 
            this.tbxDireccion.Location = new System.Drawing.Point(211, 237);
            this.tbxDireccion.Name = "tbxDireccion";
            this.tbxDireccion.Size = new System.Drawing.Size(205, 20);
            this.tbxDireccion.TabIndex = 9;
            // 
            // tbxLocalidad
            // 
            this.tbxLocalidad.Location = new System.Drawing.Point(211, 211);
            this.tbxLocalidad.Name = "tbxLocalidad";
            this.tbxLocalidad.Size = new System.Drawing.Size(205, 20);
            this.tbxLocalidad.TabIndex = 8;
            // 
            // tbxRazonSocial
            // 
            this.tbxRazonSocial.Location = new System.Drawing.Point(211, 107);
            this.tbxRazonSocial.Name = "tbxRazonSocial";
            this.tbxRazonSocial.Size = new System.Drawing.Size(205, 20);
            this.tbxRazonSocial.TabIndex = 3;
            // 
            // tbxTelefono
            // 
            this.tbxTelefono.Location = new System.Drawing.Point(211, 185);
            this.tbxTelefono.Name = "tbxTelefono";
            this.tbxTelefono.Size = new System.Drawing.Size(205, 20);
            this.tbxTelefono.TabIndex = 7;
            // 
            // tbxEmail
            // 
            this.tbxEmail.Location = new System.Drawing.Point(211, 159);
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.Size = new System.Drawing.Size(205, 20);
            this.tbxEmail.TabIndex = 6;
            // 
            // tbxApellido
            // 
            this.tbxApellido.Location = new System.Drawing.Point(211, 81);
            this.tbxApellido.Name = "tbxApellido";
            this.tbxApellido.Size = new System.Drawing.Size(205, 20);
            this.tbxApellido.TabIndex = 2;
            // 
            // tbxNombre
            // 
            this.tbxNombre.Location = new System.Drawing.Point(211, 55);
            this.tbxNombre.Name = "tbxNombre";
            this.tbxNombre.Size = new System.Drawing.Size(205, 20);
            this.tbxNombre.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(155, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Telefono:";
            // 
            // tbxCUIT
            // 
            this.tbxCUIT.Location = new System.Drawing.Point(211, 133);
            this.tbxCUIT.Name = "tbxCUIT";
            this.tbxCUIT.Size = new System.Drawing.Size(107, 20);
            this.tbxCUIT.TabIndex = 4;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(163, 162);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(39, 13);
            this.lblTelefono.TabIndex = 3;
            this.lblTelefono.Text = "E-Mail:";
            // 
            // lblCUIT
            // 
            this.lblCUIT.AutoSize = true;
            this.lblCUIT.Location = new System.Drawing.Point(167, 136);
            this.lblCUIT.Name = "lblCUIT";
            this.lblCUIT.Size = new System.Drawing.Size(35, 13);
            this.lblCUIT.TabIndex = 3;
            this.lblCUIT.Text = "CUIT:";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(152, 240);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(55, 13);
            this.lblDireccion.TabIndex = 3;
            this.lblDireccion.Text = "Dirección:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(155, 58);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblRazonSocial
            // 
            this.lblRazonSocial.AutoSize = true;
            this.lblRazonSocial.Location = new System.Drawing.Point(129, 110);
            this.lblRazonSocial.Name = "lblRazonSocial";
            this.lblRazonSocial.Size = new System.Drawing.Size(73, 13);
            this.lblRazonSocial.TabIndex = 3;
            this.lblRazonSocial.Text = "Razón Social:";
            // 
            // lblLocalidad
            // 
            this.lblLocalidad.AutoSize = true;
            this.lblLocalidad.Location = new System.Drawing.Point(155, 214);
            this.lblLocalidad.Name = "lblLocalidad";
            this.lblLocalidad.Size = new System.Drawing.Size(56, 13);
            this.lblLocalidad.TabIndex = 3;
            this.lblLocalidad.Text = "Localidad:";
            // 
            // lblNroProveedor
            // 
            this.lblNroProveedor.AutoSize = true;
            this.lblNroProveedor.Location = new System.Drawing.Point(125, 32);
            this.lblNroProveedor.Name = "lblNroProveedor";
            this.lblNroProveedor.Size = new System.Drawing.Size(79, 13);
            this.lblNroProveedor.TabIndex = 3;
            this.lblNroProveedor.Text = "Nro.Proveedor:";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(155, 84);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(47, 13);
            this.lblApellido.TabIndex = 3;
            this.lblApellido.Text = "Apellido:";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(234, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(177, 20);
            this.lblTitulo.TabIndex = 8;
            this.lblTitulo.Text = "MENU PROVEEDOR";
            // 
            // FrmProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 574);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.tabProveedor);
            this.Name = "FrmProveedor";
            this.Text = "Formulario Proveedor";
            this.Load += new System.EventHandler(this.FrmProveedor_Load);
            this.tabProveedor.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.gbxControles.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgProveedores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabProveedor;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox gbxControles;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox tbxNroProveedor;
        private System.Windows.Forms.DataGridView dtgProveedores;
        private System.Windows.Forms.TextBox tbxApellido;
        private System.Windows.Forms.TextBox tbxNombre;
        private System.Windows.Forms.TextBox tbxCUIT;
        private System.Windows.Forms.Label lblCUIT;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblNroProveedor;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox tbxDireccion;
        private System.Windows.Forms.TextBox tbxLocalidad;
        private System.Windows.Forms.TextBox tbxRazonSocial;
        private System.Windows.Forms.TextBox tbxEmail;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblRazonSocial;
        private System.Windows.Forms.Label lblLocalidad;
        private System.Windows.Forms.TextBox tbxTelefono;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lblTitulo;
    }
}