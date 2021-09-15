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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnGenerarOrden = new System.Windows.Forms.Button();
            this.tbxNroOrden = new System.Windows.Forms.TextBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblNroOrden = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgOrdenesCompra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDetalleItems)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgOrdenesCompra
            // 
            this.dtgOrdenesCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgOrdenesCompra.Location = new System.Drawing.Point(38, 213);
            this.dtgOrdenesCompra.Name = "dtgOrdenesCompra";
            this.dtgOrdenesCompra.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgOrdenesCompra.Size = new System.Drawing.Size(677, 92);
            this.dtgOrdenesCompra.TabIndex = 0;
            this.dtgOrdenesCompra.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtgOrdenesCompra_CellClick);
            // 
            // dtgDetalleItems
            // 
            this.dtgDetalleItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDetalleItems.Location = new System.Drawing.Point(38, 373);
            this.dtgDetalleItems.Name = "dtgDetalleItems";
            this.dtgDetalleItems.Size = new System.Drawing.Size(677, 112);
            this.dtgDetalleItems.TabIndex = 0;
            // 
            // dtpFechaOrden
            // 
            this.dtpFechaOrden.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaOrden.Location = new System.Drawing.Point(35, 72);
            this.dtpFechaOrden.Name = "dtpFechaOrden";
            this.dtpFechaOrden.Size = new System.Drawing.Size(88, 20);
            this.dtpFechaOrden.TabIndex = 1;
            this.dtpFechaOrden.Value = new System.DateTime(2021, 9, 13, 0, 0, 0, 0);
            // 
            // cbxProveedor
            // 
            this.cbxProveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxProveedor.FormattingEnabled = true;
            this.cbxProveedor.Location = new System.Drawing.Point(176, 71);
            this.cbxProveedor.Name = "cbxProveedor";
            this.cbxProveedor.Size = new System.Drawing.Size(195, 21);
            this.cbxProveedor.TabIndex = 2;
            // 
            // cbxPersonal
            // 
            this.cbxPersonal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPersonal.FormattingEnabled = true;
            this.cbxPersonal.Location = new System.Drawing.Point(417, 71);
            this.cbxPersonal.Name = "cbxPersonal";
            this.cbxPersonal.Size = new System.Drawing.Size(195, 21);
            this.cbxPersonal.TabIndex = 3;
            // 
            // cbxItems
            // 
            this.cbxItems.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxItems.FormattingEnabled = true;
            this.cbxItems.Location = new System.Drawing.Point(39, 346);
            this.cbxItems.Name = "cbxItems";
            this.cbxItems.Size = new System.Drawing.Size(290, 21);
            this.cbxItems.TabIndex = 4;
            // 
            // tbxCantidad
            // 
            this.tbxCantidad.Location = new System.Drawing.Point(347, 347);
            this.tbxCantidad.Name = "tbxCantidad";
            this.tbxCantidad.Size = new System.Drawing.Size(66, 20);
            this.tbxCantidad.TabIndex = 5;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(431, 344);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // lblFechaOrden
            // 
            this.lblFechaOrden.AutoSize = true;
            this.lblFechaOrden.Location = new System.Drawing.Point(32, 55);
            this.lblFechaOrden.Name = "lblFechaOrden";
            this.lblFechaOrden.Size = new System.Drawing.Size(69, 13);
            this.lblFechaOrden.TabIndex = 7;
            this.lblFechaOrden.Text = "Fecha Orden";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(173, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Proveedor:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(414, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Personal:";
            // 
            // lblItems
            // 
            this.lblItems.AutoSize = true;
            this.lblItems.Location = new System.Drawing.Point(36, 330);
            this.lblItems.Name = "lblItems";
            this.lblItems.Size = new System.Drawing.Size(75, 13);
            this.lblItems.TabIndex = 7;
            this.lblItems.Text = "Agregar Items:";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(344, 331);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(52, 13);
            this.lblCantidad.TabIndex = 7;
            this.lblCantidad.Text = "Cantidad:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblNroOrden);
            this.groupBox1.Controls.Add(this.btnEliminar);
            this.groupBox1.Controls.Add(this.tbxNroOrden);
            this.groupBox1.Controls.Add(this.btnGenerarOrden);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbxPersonal);
            this.groupBox1.Controls.Add(this.lblFechaOrden);
            this.groupBox1.Controls.Add(this.cbxProveedor);
            this.groupBox1.Controls.Add(this.dtpFechaOrden);
            this.groupBox1.Location = new System.Drawing.Point(38, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(677, 154);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Generar Orden de Compra";
            // 
            // btnGenerarOrden
            // 
            this.btnGenerarOrden.Location = new System.Drawing.Point(245, 118);
            this.btnGenerarOrden.Name = "btnGenerarOrden";
            this.btnGenerarOrden.Size = new System.Drawing.Size(130, 23);
            this.btnGenerarOrden.TabIndex = 8;
            this.btnGenerarOrden.Text = "Guardar";
            this.btnGenerarOrden.UseVisualStyleBackColor = true;
            this.btnGenerarOrden.Click += new System.EventHandler(this.BtnGenerarOrden_Click);
            // 
            // tbxNroOrden
            // 
            this.tbxNroOrden.Location = new System.Drawing.Point(296, 28);
            this.tbxNroOrden.Name = "tbxNroOrden";
            this.tbxNroOrden.ReadOnly = true;
            this.tbxNroOrden.Size = new System.Drawing.Size(66, 20);
            this.tbxNroOrden.TabIndex = 9;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(381, 118);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 10;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // lblNroOrden
            // 
            this.lblNroOrden.AutoSize = true;
            this.lblNroOrden.Location = new System.Drawing.Point(300, 12);
            this.lblNroOrden.Name = "lblNroOrden";
            this.lblNroOrden.Size = new System.Drawing.Size(56, 13);
            this.lblNroOrden.TabIndex = 11;
            this.lblNroOrden.Text = "Nro.Orden";
            // 
            // FrmGenerarOrdenCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 557);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.lblItems);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.tbxCantidad);
            this.Controls.Add(this.cbxItems);
            this.Controls.Add(this.dtgDetalleItems);
            this.Controls.Add(this.dtgOrdenesCompra);
            this.Name = "FrmGenerarOrdenCompra";
            this.Text = "FrmGenerarOrdenCompra";
            this.Load += new System.EventHandler(this.FrmGenerarOrdenCompra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgOrdenesCompra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDetalleItems)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnGenerarOrden;
        private System.Windows.Forms.Label lblNroOrden;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox tbxNroOrden;
    }
}