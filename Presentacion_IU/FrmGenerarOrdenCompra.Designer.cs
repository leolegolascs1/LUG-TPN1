namespace Presentacion_IU
{
    partial class FrmGenerarOrdenCompra
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
            this.dtgOrdenesCompra = new System.Windows.Forms.DataGridView();
            this.dtgDetalleItems = new System.Windows.Forms.DataGridView();
            this.dtpFechaOrden = new System.Windows.Forms.DateTimePicker();
            this.cbxProveedor = new System.Windows.Forms.ComboBox();
            this.cbxPersonal = new System.Windows.Forms.ComboBox();
            this.cbxItems = new System.Windows.Forms.ComboBox();
            this.tbxCantidad = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblFechaOrden = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblItems = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.gbxOrdenCompra = new System.Windows.Forms.GroupBox();
            this.tbxCantidadOrdenes = new System.Windows.Forms.TextBox();
            this.lblCantidadOrden = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnNuevaOrden = new System.Windows.Forms.Button();
            this.lblNroOrden = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.tbxNroOrden = new System.Windows.Forms.TextBox();
            this.btnGenerarOrden = new System.Windows.Forms.Button();
            this.gbxDetalle = new System.Windows.Forms.GroupBox();
            this.tbxCantidadItems = new System.Windows.Forms.TextBox();
            this.lblCantidaItems = new System.Windows.Forms.Label();
            this.btnEliminarItem = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgOrdenesCompra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDetalleItems)).BeginInit();
            this.gbxOrdenCompra.SuspendLayout();
            this.gbxDetalle.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgOrdenesCompra
            // 
            this.dtgOrdenesCompra.AllowUserToResizeColumns = false;
            this.dtgOrdenesCompra.AllowUserToResizeRows = false;
            this.dtgOrdenesCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgOrdenesCompra.Location = new System.Drawing.Point(11, 177);
            this.dtgOrdenesCompra.Name = "dtgOrdenesCompra";
            this.dtgOrdenesCompra.ReadOnly = true;
            this.dtgOrdenesCompra.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgOrdenesCompra.Size = new System.Drawing.Size(684, 92);
            this.dtgOrdenesCompra.TabIndex = 0;
            this.dtgOrdenesCompra.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtgOrdenesCompra_CellClick);
            this.dtgOrdenesCompra.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtgOrdenesCompra_CellDoubleClick);
            // 
            // dtgDetalleItems
            // 
            this.dtgDetalleItems.AllowUserToResizeColumns = false;
            this.dtgDetalleItems.AllowUserToResizeRows = false;
            this.dtgDetalleItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDetalleItems.Location = new System.Drawing.Point(11, 79);
            this.dtgDetalleItems.Name = "dtgDetalleItems";
            this.dtgDetalleItems.ReadOnly = true;
            this.dtgDetalleItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgDetalleItems.Size = new System.Drawing.Size(684, 112);
            this.dtgDetalleItems.TabIndex = 0;
            // 
            // dtpFechaOrden
            // 
            this.dtpFechaOrden.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaOrden.Location = new System.Drawing.Point(132, 100);
            this.dtpFechaOrden.Name = "dtpFechaOrden";
            this.dtpFechaOrden.Size = new System.Drawing.Size(88, 20);
            this.dtpFechaOrden.TabIndex = 2;
            this.dtpFechaOrden.Value = new System.DateTime(2021, 9, 13, 0, 0, 0, 0);
            // 
            // cbxProveedor
            // 
            this.cbxProveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxProveedor.FormattingEnabled = true;
            this.cbxProveedor.Location = new System.Drawing.Point(246, 99);
            this.cbxProveedor.Name = "cbxProveedor";
            this.cbxProveedor.Size = new System.Drawing.Size(195, 21);
            this.cbxProveedor.TabIndex = 3;
            // 
            // cbxPersonal
            // 
            this.cbxPersonal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPersonal.FormattingEnabled = true;
            this.cbxPersonal.Location = new System.Drawing.Point(469, 99);
            this.cbxPersonal.Name = "cbxPersonal";
            this.cbxPersonal.Size = new System.Drawing.Size(195, 21);
            this.cbxPersonal.TabIndex = 4;
            // 
            // cbxItems
            // 
            this.cbxItems.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxItems.FormattingEnabled = true;
            this.cbxItems.Location = new System.Drawing.Point(11, 39);
            this.cbxItems.Name = "cbxItems";
            this.cbxItems.Size = new System.Drawing.Size(290, 21);
            this.cbxItems.TabIndex = 8;
            // 
            // tbxCantidad
            // 
            this.tbxCantidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tbxCantidad.Location = new System.Drawing.Point(323, 39);
            this.tbxCantidad.Name = "tbxCantidad";
            this.tbxCantidad.Size = new System.Drawing.Size(66, 20);
            this.tbxCantidad.TabIndex = 9;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(407, 33);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(119, 31);
            this.btnAgregar.TabIndex = 10;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // lblFechaOrden
            // 
            this.lblFechaOrden.AutoSize = true;
            this.lblFechaOrden.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaOrden.Location = new System.Drawing.Point(129, 83);
            this.lblFechaOrden.Name = "lblFechaOrden";
            this.lblFechaOrden.Size = new System.Drawing.Size(80, 13);
            this.lblFechaOrden.TabIndex = 7;
            this.lblFechaOrden.Text = "Fecha Orden";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(243, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Proveedor:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(466, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Personal:";
            // 
            // lblItems
            // 
            this.lblItems.AutoSize = true;
            this.lblItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItems.Location = new System.Drawing.Point(11, 23);
            this.lblItems.Name = "lblItems";
            this.lblItems.Size = new System.Drawing.Size(89, 13);
            this.lblItems.TabIndex = 7;
            this.lblItems.Text = "Agregar Items:";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(326, 23);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(61, 13);
            this.lblCantidad.TabIndex = 7;
            this.lblCantidad.Text = "Cantidad:";
            // 
            // gbxOrdenCompra
            // 
            this.gbxOrdenCompra.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gbxOrdenCompra.Controls.Add(this.tbxCantidadOrdenes);
            this.gbxOrdenCompra.Controls.Add(this.lblCantidadOrden);
            this.gbxOrdenCompra.Controls.Add(this.btnCancelar);
            this.gbxOrdenCompra.Controls.Add(this.btnNuevaOrden);
            this.gbxOrdenCompra.Controls.Add(this.dtgOrdenesCompra);
            this.gbxOrdenCompra.Controls.Add(this.lblNroOrden);
            this.gbxOrdenCompra.Controls.Add(this.btnEliminar);
            this.gbxOrdenCompra.Controls.Add(this.tbxNroOrden);
            this.gbxOrdenCompra.Controls.Add(this.btnGenerarOrden);
            this.gbxOrdenCompra.Controls.Add(this.label3);
            this.gbxOrdenCompra.Controls.Add(this.label2);
            this.gbxOrdenCompra.Controls.Add(this.cbxPersonal);
            this.gbxOrdenCompra.Controls.Add(this.lblFechaOrden);
            this.gbxOrdenCompra.Controls.Add(this.cbxProveedor);
            this.gbxOrdenCompra.Controls.Add(this.dtpFechaOrden);
            this.gbxOrdenCompra.Location = new System.Drawing.Point(25, 35);
            this.gbxOrdenCompra.Name = "gbxOrdenCompra";
            this.gbxOrdenCompra.Size = new System.Drawing.Size(707, 315);
            this.gbxOrdenCompra.TabIndex = 0;
            this.gbxOrdenCompra.TabStop = false;
            this.gbxOrdenCompra.Text = "Generar Orden de Compra";
            // 
            // tbxCantidadOrdenes
            // 
            this.tbxCantidadOrdenes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxCantidadOrdenes.Location = new System.Drawing.Point(609, 286);
            this.tbxCantidadOrdenes.Name = "tbxCantidadOrdenes";
            this.tbxCantidadOrdenes.ReadOnly = true;
            this.tbxCantidadOrdenes.Size = new System.Drawing.Size(86, 20);
            this.tbxCantidadOrdenes.TabIndex = 15;
            this.tbxCantidadOrdenes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblCantidadOrden
            // 
            this.lblCantidadOrden.AutoSize = true;
            this.lblCantidadOrden.Location = new System.Drawing.Point(528, 289);
            this.lblCantidadOrden.Name = "lblCantidadOrden";
            this.lblCantidadOrden.Size = new System.Drawing.Size(75, 13);
            this.lblCantidadOrden.TabIndex = 14;
            this.lblCantidadOrden.Text = "Cant.Ordenes:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(368, 136);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(129, 35);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // btnNuevaOrden
            // 
            this.btnNuevaOrden.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnNuevaOrden.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevaOrden.Location = new System.Drawing.Point(284, 19);
            this.btnNuevaOrden.Name = "btnNuevaOrden";
            this.btnNuevaOrden.Size = new System.Drawing.Size(138, 38);
            this.btnNuevaOrden.TabIndex = 1;
            this.btnNuevaOrden.Text = "Nueva Orden";
            this.btnNuevaOrden.UseVisualStyleBackColor = false;
            this.btnNuevaOrden.Click += new System.EventHandler(this.BtnNuevaOrden_Click);
            // 
            // lblNroOrden
            // 
            this.lblNroOrden.AutoSize = true;
            this.lblNroOrden.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNroOrden.Location = new System.Drawing.Point(38, 75);
            this.lblNroOrden.Name = "lblNroOrden";
            this.lblNroOrden.Size = new System.Drawing.Size(65, 13);
            this.lblNroOrden.TabIndex = 11;
            this.lblNroOrden.Text = "Nro.Orden";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(316, 275);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 34);
            this.btnEliminar.TabIndex = 7;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // tbxNroOrden
            // 
            this.tbxNroOrden.BackColor = System.Drawing.Color.Yellow;
            this.tbxNroOrden.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxNroOrden.Location = new System.Drawing.Point(34, 91);
            this.tbxNroOrden.Name = "tbxNroOrden";
            this.tbxNroOrden.ReadOnly = true;
            this.tbxNroOrden.Size = new System.Drawing.Size(66, 29);
            this.tbxNroOrden.TabIndex = 9;
            this.tbxNroOrden.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnGenerarOrden
            // 
            this.btnGenerarOrden.Location = new System.Drawing.Point(209, 136);
            this.btnGenerarOrden.Name = "btnGenerarOrden";
            this.btnGenerarOrden.Size = new System.Drawing.Size(130, 35);
            this.btnGenerarOrden.TabIndex = 5;
            this.btnGenerarOrden.Text = "Guardar";
            this.btnGenerarOrden.UseVisualStyleBackColor = true;
            this.btnGenerarOrden.Click += new System.EventHandler(this.BtnGenerarOrden_Click);
            // 
            // gbxDetalle
            // 
            this.gbxDetalle.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.gbxDetalle.Controls.Add(this.tbxCantidadItems);
            this.gbxDetalle.Controls.Add(this.lblCantidaItems);
            this.gbxDetalle.Controls.Add(this.btnEliminarItem);
            this.gbxDetalle.Controls.Add(this.lblCantidad);
            this.gbxDetalle.Controls.Add(this.lblItems);
            this.gbxDetalle.Controls.Add(this.btnAgregar);
            this.gbxDetalle.Controls.Add(this.tbxCantidad);
            this.gbxDetalle.Controls.Add(this.cbxItems);
            this.gbxDetalle.Controls.Add(this.dtgDetalleItems);
            this.gbxDetalle.Location = new System.Drawing.Point(25, 356);
            this.gbxDetalle.Name = "gbxDetalle";
            this.gbxDetalle.Size = new System.Drawing.Size(707, 235);
            this.gbxDetalle.TabIndex = 9;
            this.gbxDetalle.TabStop = false;
            this.gbxDetalle.Text = "Detalle Orden";
            // 
            // tbxCantidadItems
            // 
            this.tbxCantidadItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxCantidadItems.Location = new System.Drawing.Point(609, 209);
            this.tbxCantidadItems.Name = "tbxCantidadItems";
            this.tbxCantidadItems.ReadOnly = true;
            this.tbxCantidadItems.Size = new System.Drawing.Size(86, 20);
            this.tbxCantidadItems.TabIndex = 15;
            this.tbxCantidadItems.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblCantidaItems
            // 
            this.lblCantidaItems.AutoSize = true;
            this.lblCantidaItems.Location = new System.Drawing.Point(528, 212);
            this.lblCantidaItems.Name = "lblCantidaItems";
            this.lblCantidaItems.Size = new System.Drawing.Size(80, 13);
            this.lblCantidaItems.TabIndex = 14;
            this.lblCantidaItems.Text = "Cantidad Items:";
            // 
            // btnEliminarItem
            // 
            this.btnEliminarItem.Location = new System.Drawing.Point(314, 197);
            this.btnEliminarItem.Name = "btnEliminarItem";
            this.btnEliminarItem.Size = new System.Drawing.Size(75, 32);
            this.btnEliminarItem.TabIndex = 11;
            this.btnEliminarItem.Text = "Eliminar";
            this.btnEliminarItem.UseVisualStyleBackColor = true;
            this.btnEliminarItem.Click += new System.EventHandler(this.BtnEliminarItem_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(220, 6);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(317, 24);
            this.lblTitulo.TabIndex = 10;
            this.lblTitulo.Text = "GENERAR ORDEN DE COMPRA";
            // 
            // FrmGenerarOrdenCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 595);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.gbxDetalle);
            this.Controls.Add(this.gbxOrdenCompra);
            this.Name = "FrmGenerarOrdenCompra";
            this.Text = "Formulario Orden de Compra";
            this.Load += new System.EventHandler(this.FrmGenerarOrdenCompra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgOrdenesCompra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDetalleItems)).EndInit();
            this.gbxOrdenCompra.ResumeLayout(false);
            this.gbxOrdenCompra.PerformLayout();
            this.gbxDetalle.ResumeLayout(false);
            this.gbxDetalle.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgOrdenesCompra;
        private System.Windows.Forms.DataGridView dtgDetalleItems;
        private System.Windows.Forms.DateTimePicker dtpFechaOrden;
        private System.Windows.Forms.ComboBox cbxProveedor;
        private System.Windows.Forms.ComboBox cbxPersonal;
        private System.Windows.Forms.ComboBox cbxItems;
        private System.Windows.Forms.TextBox tbxCantidad;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblFechaOrden;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblItems;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.GroupBox gbxOrdenCompra;
        private System.Windows.Forms.Button btnGenerarOrden;
        private System.Windows.Forms.Label lblNroOrden;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox tbxNroOrden;
        private System.Windows.Forms.Button btnNuevaOrden;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.GroupBox gbxDetalle;
        private System.Windows.Forms.Button btnEliminarItem;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox tbxCantidadOrdenes;
        private System.Windows.Forms.Label lblCantidadOrden;
        private System.Windows.Forms.TextBox tbxCantidadItems;
        private System.Windows.Forms.Label lblCantidaItems;
    }
}