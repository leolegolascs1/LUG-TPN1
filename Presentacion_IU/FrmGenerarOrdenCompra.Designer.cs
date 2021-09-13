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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cbxProveedor = new System.Windows.Forms.ComboBox();
            this.cbxPersonal = new System.Windows.Forms.ComboBox();
            this.cbxItems = new System.Windows.Forms.ComboBox();
            this.tbxCantidad = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgOrdenesCompra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgOrdenesCompra
            // 
            this.dtgOrdenesCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgOrdenesCompra.Location = new System.Drawing.Point(40, 165);
            this.dtgOrdenesCompra.Name = "dtgOrdenesCompra";
            this.dtgOrdenesCompra.Size = new System.Drawing.Size(677, 112);
            this.dtgOrdenesCompra.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(40, 351);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(677, 112);
            this.dataGridView1.TabIndex = 0;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(40, 72);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(88, 20);
            this.dateTimePicker1.TabIndex = 1;
            this.dateTimePicker1.Value = new System.DateTime(2021, 9, 13, 0, 0, 0, 0);
            // 
            // cbxProveedor
            // 
            this.cbxProveedor.FormattingEnabled = true;
            this.cbxProveedor.Location = new System.Drawing.Point(157, 71);
            this.cbxProveedor.Name = "cbxProveedor";
            this.cbxProveedor.Size = new System.Drawing.Size(195, 21);
            this.cbxProveedor.TabIndex = 2;
            // 
            // cbxPersonal
            // 
            this.cbxPersonal.FormattingEnabled = true;
            this.cbxPersonal.Location = new System.Drawing.Point(398, 71);
            this.cbxPersonal.Name = "cbxPersonal";
            this.cbxPersonal.Size = new System.Drawing.Size(195, 21);
            this.cbxPersonal.TabIndex = 3;
            // 
            // cbxItems
            // 
            this.cbxItems.FormattingEnabled = true;
            this.cbxItems.Location = new System.Drawing.Point(40, 138);
            this.cbxItems.Name = "cbxItems";
            this.cbxItems.Size = new System.Drawing.Size(290, 21);
            this.cbxItems.TabIndex = 4;
            // 
            // tbxCantidad
            // 
            this.tbxCantidad.Location = new System.Drawing.Point(348, 139);
            this.tbxCantidad.Name = "tbxCantidad";
            this.tbxCantidad.Size = new System.Drawing.Size(66, 20);
            this.tbxCantidad.TabIndex = 5;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(432, 136);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // FrmGenerarOrdenCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 475);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.tbxCantidad);
            this.Controls.Add(this.cbxItems);
            this.Controls.Add(this.cbxPersonal);
            this.Controls.Add(this.cbxProveedor);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dtgOrdenesCompra);
            this.Name = "FrmGenerarOrdenCompra";
            this.Text = "FrmGenerarOrdenCompra";
            ((System.ComponentModel.ISupportInitialize)(this.dtgOrdenesCompra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgOrdenesCompra;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox cbxProveedor;
        private System.Windows.Forms.ComboBox cbxPersonal;
        private System.Windows.Forms.ComboBox cbxItems;
        private System.Windows.Forms.TextBox tbxCantidad;
        private System.Windows.Forms.Button btnAgregar;
    }
}