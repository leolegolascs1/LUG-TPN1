namespace Presentacion_IU
{
    partial class FrmPersonal
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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.gbxControles = new System.Windows.Forms.GroupBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tbxNroEmpleado = new System.Windows.Forms.TextBox();
            this.tbxApellido = new System.Windows.Forms.TextBox();
            this.tbxNombre = new System.Windows.Forms.TextBox();
            this.tbxDocumento = new System.Windows.Forms.TextBox();
            this.dtgPersonal = new System.Windows.Forms.DataGridView();
            this.lblTipoEmpleado = new System.Windows.Forms.Label();
            this.lblDocumento = new System.Windows.Forms.Label();
            this.cbxTipoEmpleado = new System.Windows.Forms.ComboBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblNroEmpleado = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.tabEmpleado = new System.Windows.Forms.TabControl();
            this.btnGenerarPass = new System.Windows.Forms.Button();
            this.tabPage1.SuspendLayout();
            this.gbxControles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPersonal)).BeginInit();
            this.tabEmpleado.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tabPage1.Controls.Add(this.gbxControles);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.tbxNroEmpleado);
            this.tabPage1.Controls.Add(this.tbxApellido);
            this.tabPage1.Controls.Add(this.tbxNombre);
            this.tabPage1.Controls.Add(this.tbxDocumento);
            this.tabPage1.Controls.Add(this.dtgPersonal);
            this.tabPage1.Controls.Add(this.lblTipoEmpleado);
            this.tabPage1.Controls.Add(this.lblDocumento);
            this.tabPage1.Controls.Add(this.cbxTipoEmpleado);
            this.tabPage1.Controls.Add(this.lblNombre);
            this.tabPage1.Controls.Add(this.lblNroEmpleado);
            this.tabPage1.Controls.Add(this.lblApellido);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(574, 473);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Empleado";
            // 
            // gbxControles
            // 
            this.gbxControles.Controls.Add(this.btnGenerarPass);
            this.gbxControles.Controls.Add(this.btnModificar);
            this.gbxControles.Controls.Add(this.btnCancelar);
            this.gbxControles.Controls.Add(this.btnEliminar);
            this.gbxControles.Controls.Add(this.btnAgregar);
            this.gbxControles.Location = new System.Drawing.Point(7, 160);
            this.gbxControles.Name = "gbxControles";
            this.gbxControles.Size = new System.Drawing.Size(561, 69);
            this.gbxControles.TabIndex = 6;
            this.gbxControles.TabStop = false;
            this.gbxControles.Text = "Controles";
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(194, 29);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 4;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(374, 29);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(284, 29);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(99, 29);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(466, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbxNroEmpleado
            // 
            this.tbxNroEmpleado.Location = new System.Drawing.Point(211, 29);
            this.tbxNroEmpleado.Name = "tbxNroEmpleado";
            this.tbxNroEmpleado.ReadOnly = true;
            this.tbxNroEmpleado.Size = new System.Drawing.Size(70, 20);
            this.tbxNroEmpleado.TabIndex = 4;
            // 
            // tbxApellido
            // 
            this.tbxApellido.Location = new System.Drawing.Point(211, 81);
            this.tbxApellido.Name = "tbxApellido";
            this.tbxApellido.Size = new System.Drawing.Size(205, 20);
            this.tbxApellido.TabIndex = 1;
            // 
            // tbxNombre
            // 
            this.tbxNombre.Location = new System.Drawing.Point(211, 55);
            this.tbxNombre.Name = "tbxNombre";
            this.tbxNombre.Size = new System.Drawing.Size(205, 20);
            this.tbxNombre.TabIndex = 1;
            // 
            // tbxDocumento
            // 
            this.tbxDocumento.Location = new System.Drawing.Point(211, 107);
            this.tbxDocumento.Name = "tbxDocumento";
            this.tbxDocumento.Size = new System.Drawing.Size(107, 20);
            this.tbxDocumento.TabIndex = 1;
            // 
            // dtgPersonal
            // 
            this.dtgPersonal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgPersonal.Location = new System.Drawing.Point(6, 235);
            this.dtgPersonal.Name = "dtgPersonal";
            this.dtgPersonal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgPersonal.Size = new System.Drawing.Size(561, 232);
            this.dtgPersonal.TabIndex = 0;
            this.dtgPersonal.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgPersonal_CellDoubleClick);
            // 
            // lblTipoEmpleado
            // 
            this.lblTipoEmpleado.AutoSize = true;
            this.lblTipoEmpleado.Location = new System.Drawing.Point(124, 136);
            this.lblTipoEmpleado.Name = "lblTipoEmpleado";
            this.lblTipoEmpleado.Size = new System.Drawing.Size(81, 13);
            this.lblTipoEmpleado.TabIndex = 3;
            this.lblTipoEmpleado.Text = "Tipo Empleado:";
            // 
            // lblDocumento
            // 
            this.lblDocumento.AutoSize = true;
            this.lblDocumento.Location = new System.Drawing.Point(137, 110);
            this.lblDocumento.Name = "lblDocumento";
            this.lblDocumento.Size = new System.Drawing.Size(65, 13);
            this.lblDocumento.TabIndex = 3;
            this.lblDocumento.Text = "Documento:";
            // 
            // cbxTipoEmpleado
            // 
            this.cbxTipoEmpleado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTipoEmpleado.FormattingEnabled = true;
            this.cbxTipoEmpleado.Location = new System.Drawing.Point(211, 133);
            this.cbxTipoEmpleado.Name = "cbxTipoEmpleado";
            this.cbxTipoEmpleado.Size = new System.Drawing.Size(121, 21);
            this.cbxTipoEmpleado.TabIndex = 2;
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
            // lblNroEmpleado
            // 
            this.lblNroEmpleado.AutoSize = true;
            this.lblNroEmpleado.Location = new System.Drawing.Point(125, 32);
            this.lblNroEmpleado.Name = "lblNroEmpleado";
            this.lblNroEmpleado.Size = new System.Drawing.Size(77, 13);
            this.lblNroEmpleado.TabIndex = 3;
            this.lblNroEmpleado.Text = "Nro.Empleado:";
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
            // tabEmpleado
            // 
            this.tabEmpleado.Controls.Add(this.tabPage1);
            this.tabEmpleado.Location = new System.Drawing.Point(23, 47);
            this.tabEmpleado.Name = "tabEmpleado";
            this.tabEmpleado.SelectedIndex = 0;
            this.tabEmpleado.Size = new System.Drawing.Size(582, 499);
            this.tabEmpleado.TabIndex = 6;
            // 
            // btnGenerarPass
            // 
            this.btnGenerarPass.Location = new System.Drawing.Point(480, 19);
            this.btnGenerarPass.Name = "btnGenerarPass";
            this.btnGenerarPass.Size = new System.Drawing.Size(75, 42);
            this.btnGenerarPass.TabIndex = 7;
            this.btnGenerarPass.Text = "Generar Password";
            this.btnGenerarPass.UseVisualStyleBackColor = true;
            this.btnGenerarPass.Click += new System.EventHandler(this.BtnGenerarPass_Click);
            // 
            // FrmPersonal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 558);
            this.Controls.Add(this.tabEmpleado);
            this.Name = "FrmPersonal";
            this.Text = "FrmPersonal";
            this.Load += new System.EventHandler(this.FrmPersonal_Load);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.gbxControles.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgPersonal)).EndInit();
            this.tabEmpleado.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox gbxControles;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbxNroEmpleado;
        private System.Windows.Forms.TextBox tbxApellido;
        private System.Windows.Forms.TextBox tbxNombre;
        private System.Windows.Forms.TextBox tbxDocumento;
        private System.Windows.Forms.DataGridView dtgPersonal;
        private System.Windows.Forms.Label lblTipoEmpleado;
        private System.Windows.Forms.Label lblDocumento;
        private System.Windows.Forms.ComboBox cbxTipoEmpleado;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblNroEmpleado;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TabControl tabEmpleado;
        private System.Windows.Forms.Button btnGenerarPass;
    }
}