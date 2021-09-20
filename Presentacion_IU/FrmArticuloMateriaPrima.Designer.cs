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
            this.cbxMaterial = new System.Windows.Forms.ComboBox();
            this.gbxControles = new System.Windows.Forms.GroupBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.tbxCodigo = new System.Windows.Forms.TextBox();
            this.dtgMateriales = new System.Windows.Forms.DataGridView();
            this.lblMaterial = new System.Windows.Forms.Label();
            this.tbxDescripcionArt = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblNroArticulo = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.tabEmpleado.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.gbxControles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMateriales)).BeginInit();
            this.SuspendLayout();
            // 
            // tabEmpleado
            // 
            this.tabEmpleado.Controls.Add(this.tabPage1);
            this.tabEmpleado.Location = new System.Drawing.Point(12, 48);
            this.tabEmpleado.Name = "tabEmpleado";
            this.tabEmpleado.SelectedIndex = 0;
            this.tabEmpleado.Size = new System.Drawing.Size(582, 499);
            this.tabEmpleado.TabIndex = 0;
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
            // cbxMaterial
            // 
            this.cbxMaterial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMaterial.FormattingEnabled = true;
            this.cbxMaterial.Location = new System.Drawing.Point(154, 84);
            this.cbxMaterial.Name = "cbxMaterial";
            this.cbxMaterial.Size = new System.Drawing.Size(167, 21);
            this.cbxMaterial.TabIndex = 2;
            // 
            // gbxControles
            // 
            this.gbxControles.Controls.Add(this.btnGuardar);
            this.gbxControles.Controls.Add(this.btnCancelar);
            this.gbxControles.Controls.Add(this.btnEliminar);
            this.gbxControles.Location = new System.Drawing.Point(53, 111);
            this.gbxControles.Name = "gbxControles";
            this.gbxControles.Size = new System.Drawing.Size(470, 52);
            this.gbxControles.TabIndex = 6;
            this.gbxControles.TabStop = false;
            this.gbxControles.Text = "Controles";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(55, 23);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 3;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(322, 24);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(193, 23);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // tbxCodigo
            // 
            this.tbxCodigo.Location = new System.Drawing.Point(154, 32);
            this.tbxCodigo.Name = "tbxCodigo";
            this.tbxCodigo.ReadOnly = true;
            this.tbxCodigo.Size = new System.Drawing.Size(70, 20);
            this.tbxCodigo.TabIndex = 4;
            this.tbxCodigo.TabStop = false;
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
            // lblMaterial
            // 
            this.lblMaterial.AutoSize = true;
            this.lblMaterial.Location = new System.Drawing.Point(98, 87);
            this.lblMaterial.Name = "lblMaterial";
            this.lblMaterial.Size = new System.Drawing.Size(47, 13);
            this.lblMaterial.TabIndex = 3;
            this.lblMaterial.Text = "Material:";
            // 
            // tbxDescripcionArt
            // 
            this.tbxDescripcionArt.Location = new System.Drawing.Point(154, 58);
            this.tbxDescripcionArt.Name = "tbxDescripcionArt";
            this.tbxDescripcionArt.Size = new System.Drawing.Size(369, 20);
            this.tbxDescripcionArt.TabIndex = 1;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(79, 61);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(66, 13);
            this.lblDescripcion.TabIndex = 3;
            this.lblDescripcion.Text = "Descripción:";
            // 
            // lblNroArticulo
            // 
            this.lblNroArticulo.AutoSize = true;
            this.lblNroArticulo.Location = new System.Drawing.Point(68, 35);
            this.lblNroArticulo.Name = "lblNroArticulo";
            this.lblNroArticulo.Size = new System.Drawing.Size(81, 13);
            this.lblNroArticulo.TabIndex = 3;
            this.lblNroArticulo.Text = "Codigo Articulo:";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(210, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(178, 20);
            this.lblTitulo.TabIndex = 8;
            this.lblTitulo.Text = "MENU MATERIALES";
            // 
            // FrmArticuloMateriaPrima
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 560);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.tabEmpleado);
            this.Name = "FrmArticuloMateriaPrima";
            this.Text = "Formulario Materia Prima";
            this.Load += new System.EventHandler(this.FrmArticuloMateriaPrima_Load);
            this.tabEmpleado.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.gbxControles.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgMateriales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabEmpleado;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox gbxControles;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox tbxCodigo;
        private System.Windows.Forms.DataGridView dtgMateriales;
        private System.Windows.Forms.TextBox tbxDescripcionArt;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblNroArticulo;
        private System.Windows.Forms.ComboBox cbxMaterial;
        private System.Windows.Forms.Label lblMaterial;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lblTitulo;
    }
}