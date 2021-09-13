namespace Presentacion_IU
{
    partial class FrmArticuloMateriaPrima
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
            this.tabEmpleado = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.gbxControles = new System.Windows.Forms.GroupBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.tbxCodigo = new System.Windows.Forms.TextBox();
            this.dtgMateriales = new System.Windows.Forms.DataGridView();
            this.tbxDescripcionArt = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblNroArticulo = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.gbxBusqueda = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.lblListaPersonal = new System.Windows.Forms.Label();
            this.lblMaterial = new System.Windows.Forms.Label();
            this.cbxMaterial = new System.Windows.Forms.ComboBox();
            this.tabEmpleado.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.gbxControles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMateriales)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.gbxBusqueda.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabEmpleado
            // 
            this.tabEmpleado.Controls.Add(this.tabPage1);
            this.tabEmpleado.Controls.Add(this.tabPage2);
            this.tabEmpleado.Location = new System.Drawing.Point(12, 48);
            this.tabEmpleado.Name = "tabEmpleado";
            this.tabEmpleado.SelectedIndex = 0;
            this.tabEmpleado.Size = new System.Drawing.Size(582, 499);
            this.tabEmpleado.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tabPage1.Controls.Add(this.cbxMaterial);
            this.tabPage1.Controls.Add(this.gbxControles);
            this.tabPage1.Controls.Add(this.tbxCodigo);
            this.tabPage1.Controls.Add(this.dtgMateriales);
            this.tabPage1.Controls.Add(this.lblMaterial);
            this.tabPage1.Controls.Add(this.tbxDescripcionArt);
            this.tabPage1.Controls.Add(this.lblDescripcion);
            this.tabPage1.Controls.Add(this.lblNroArticulo);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(574, 473);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Articulo";
            // 
            // gbxControles
            // 
            this.gbxControles.Controls.Add(this.btnModificar);
            this.gbxControles.Controls.Add(this.btnCancelar);
            this.gbxControles.Controls.Add(this.btnEliminar);
            this.gbxControles.Controls.Add(this.btnAgregar);
            this.gbxControles.Location = new System.Drawing.Point(53, 111);
            this.gbxControles.Name = "gbxControles";
            this.gbxControles.Size = new System.Drawing.Size(470, 52);
            this.gbxControles.TabIndex = 6;
            this.gbxControles.TabStop = false;
            this.gbxControles.Text = "Controles";
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(142, 24);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 4;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(322, 24);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(232, 24);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(47, 24);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // tbxCodigo
            // 
            this.tbxCodigo.Location = new System.Drawing.Point(211, 29);
            this.tbxCodigo.Name = "tbxCodigo";
            this.tbxCodigo.ReadOnly = true;
            this.tbxCodigo.Size = new System.Drawing.Size(70, 20);
            this.tbxCodigo.TabIndex = 4;
            // 
            // dtgMateriales
            // 
            this.dtgMateriales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgMateriales.Location = new System.Drawing.Point(7, 169);
            this.dtgMateriales.Name = "dtgMateriales";
            this.dtgMateriales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgMateriales.Size = new System.Drawing.Size(561, 298);
            this.dtgMateriales.TabIndex = 0;
            this.dtgMateriales.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtgMateriales_CellDoubleClick);
            // 
            // tbxDescripcionArt
            // 
            this.tbxDescripcionArt.Location = new System.Drawing.Point(211, 55);
            this.tbxDescripcionArt.Name = "tbxDescripcionArt";
            this.tbxDescripcionArt.Size = new System.Drawing.Size(205, 20);
            this.tbxDescripcionArt.TabIndex = 1;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(136, 58);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(66, 13);
            this.lblDescripcion.TabIndex = 3;
            this.lblDescripcion.Text = "Descripción:";
            // 
            // lblNroArticulo
            // 
            this.lblNroArticulo.AutoSize = true;
            this.lblNroArticulo.Location = new System.Drawing.Point(125, 32);
            this.lblNroArticulo.Name = "lblNroArticulo";
            this.lblNroArticulo.Size = new System.Drawing.Size(81, 13);
            this.lblNroArticulo.TabIndex = 3;
            this.lblNroArticulo.Text = "Codigo Articulo:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.gbxBusqueda);
            this.tabPage2.Controls.Add(this.lblListaPersonal);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(574, 473);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Busqueda";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // gbxBusqueda
            // 
            this.gbxBusqueda.Controls.Add(this.radioButton3);
            this.gbxBusqueda.Controls.Add(this.radioButton2);
            this.gbxBusqueda.Controls.Add(this.radioButton1);
            this.gbxBusqueda.Location = new System.Drawing.Point(9, 6);
            this.gbxBusqueda.Name = "gbxBusqueda";
            this.gbxBusqueda.Size = new System.Drawing.Size(558, 48);
            this.gbxBusqueda.TabIndex = 2;
            this.gbxBusqueda.TabStop = false;
            this.gbxBusqueda.Text = "Buscar Por:";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(249, 19);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(81, 17);
            this.radioButton3.TabIndex = 0;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Por Nombre";
            this.radioButton3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(145, 19);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(81, 17);
            this.radioButton2.TabIndex = 0;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Por Apellido";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(45, 19);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(77, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Por Código";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // lblListaPersonal
            // 
            this.lblListaPersonal.AutoSize = true;
            this.lblListaPersonal.Location = new System.Drawing.Point(6, 57);
            this.lblListaPersonal.Name = "lblListaPersonal";
            this.lblListaPersonal.Size = new System.Drawing.Size(76, 13);
            this.lblListaPersonal.TabIndex = 1;
            this.lblListaPersonal.Text = "Lista Personal:";
            // 
            // lblMaterial
            // 
            this.lblMaterial.AutoSize = true;
            this.lblMaterial.Location = new System.Drawing.Point(155, 84);
            this.lblMaterial.Name = "lblMaterial";
            this.lblMaterial.Size = new System.Drawing.Size(47, 13);
            this.lblMaterial.TabIndex = 3;
            this.lblMaterial.Text = "Material:";
            // 
            // cbxMaterial
            // 
            this.cbxMaterial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMaterial.FormattingEnabled = true;
            this.cbxMaterial.Location = new System.Drawing.Point(211, 81);
            this.cbxMaterial.Name = "cbxMaterial";
            this.cbxMaterial.Size = new System.Drawing.Size(161, 21);
            this.cbxMaterial.TabIndex = 7;
            // 
            // FrmArticuloMateriaPrima
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 560);
            this.Controls.Add(this.tabEmpleado);
            this.Name = "FrmArticuloMateriaPrima";
            this.Text = "FrmArticuloMateriaPrima";
            this.Load += new System.EventHandler(this.FrmArticuloMateriaPrima_Load);
            this.tabEmpleado.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.gbxControles.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgMateriales)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.gbxBusqueda.ResumeLayout(false);
            this.gbxBusqueda.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabEmpleado;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox gbxControles;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox tbxCodigo;
        private System.Windows.Forms.DataGridView dtgMateriales;
        private System.Windows.Forms.TextBox tbxDescripcionArt;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblNroArticulo;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox gbxBusqueda;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label lblListaPersonal;
        private System.Windows.Forms.ComboBox cbxMaterial;
        private System.Windows.Forms.Label lblMaterial;
    }
}