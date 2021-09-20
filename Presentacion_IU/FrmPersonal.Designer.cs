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
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnGenerarPass = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.tbxNroEmpleado = new System.Windows.Forms.TextBox();
            this.tbxApellido = new System.Windows.Forms.TextBox();
            this.tbxNombre = new System.Windows.Forms.TextBox();
            this.tbxDocumento = new System.Windows.Forms.TextBox();
            this.dtgPersonal = new System.Windows.Forms.DataGridView();
            this.lblRol = new System.Windows.Forms.Label();
            this.lblDocumento = new System.Windows.Forms.Label();
            this.cbxTipoEmpleado = new System.Windows.Forms.ComboBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblNroEmpleado = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.tabEmpleado = new System.Windows.Forms.TabControl();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblSueldos = new System.Windows.Forms.Label();
            this.tabPage1.SuspendLayout();
            this.gbxControles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPersonal)).BeginInit();
            this.tabEmpleado.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tabPage1.Controls.Add(this.lblSueldos);
            this.tabPage1.Controls.Add(this.gbxControles);
            this.tabPage1.Controls.Add(this.tbxNroEmpleado);
            this.tabPage1.Controls.Add(this.tbxApellido);
            this.tabPage1.Controls.Add(this.tbxNombre);
            this.tabPage1.Controls.Add(this.tbxDocumento);
            this.tabPage1.Controls.Add(this.dtgPersonal);
            this.tabPage1.Controls.Add(this.lblRol);
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
            this.gbxControles.Controls.Add(this.btnGuardar);
            this.gbxControles.Controls.Add(this.btnGenerarPass);
            this.gbxControles.Controls.Add(this.btnCancelar);
            this.gbxControles.Controls.Add(this.btnEliminar);
            this.gbxControles.Location = new System.Drawing.Point(7, 160);
            this.gbxControles.Name = "gbxControles";
            this.gbxControles.Size = new System.Drawing.Size(561, 69);
            this.gbxControles.TabIndex = 6;
            this.gbxControles.TabStop = false;
            this.gbxControles.Text = "Controles";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(92, 29);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 5;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnGenerarPass
            // 
            this.btnGenerarPass.Location = new System.Drawing.Point(480, 19);
            this.btnGenerarPass.Name = "btnGenerarPass";
            this.btnGenerarPass.Size = new System.Drawing.Size(75, 42);
            this.btnGenerarPass.TabIndex = 8;
            this.btnGenerarPass.Text = "Generar Password";
            this.btnGenerarPass.UseVisualStyleBackColor = true;
            this.btnGenerarPass.Click += new System.EventHandler(this.BtnGenerarPass_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(374, 29);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(236, 29);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 6;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // tbxNroEmpleado
            // 
            this.tbxNroEmpleado.Location = new System.Drawing.Point(211, 29);
            this.tbxNroEmpleado.Name = "tbxNroEmpleado";
            this.tbxNroEmpleado.ReadOnly = true;
            this.tbxNroEmpleado.Size = new System.Drawing.Size(70, 20);
            this.tbxNroEmpleado.TabIndex = 4;
            this.tbxNroEmpleado.TabStop = false;
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
            // tbxDocumento
            // 
            this.tbxDocumento.Location = new System.Drawing.Point(211, 107);
            this.tbxDocumento.Name = "tbxDocumento";
            this.tbxDocumento.Size = new System.Drawing.Size(107, 20);
            this.tbxDocumento.TabIndex = 3;
            // 
            // dtgPersonal
            // 
            this.dtgPersonal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgPersonal.Location = new System.Drawing.Point(6, 235);
            this.dtgPersonal.Name = "dtgPersonal";
            this.dtgPersonal.ReadOnly = true;
            this.dtgPersonal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgPersonal.Size = new System.Drawing.Size(561, 163);
            this.dtgPersonal.TabIndex = 0;
            this.dtgPersonal.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgPersonal_CellDoubleClick);
            // 
            // lblRol
            // 
            this.lblRol.AutoSize = true;
            this.lblRol.Location = new System.Drawing.Point(176, 136);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(26, 13);
            this.lblRol.TabIndex = 3;
            this.lblRol.Text = "Rol:";
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
            this.cbxTipoEmpleado.TabIndex = 4;
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
            this.tabEmpleado.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(218, 24);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(160, 20);
            this.lblTitulo.TabIndex = 7;
            this.lblTitulo.Text = "MENU PERSONAL";
            // 
            // lblSueldos
            // 
            this.lblSueldos.AutoSize = true;
            this.lblSueldos.Location = new System.Drawing.Point(28, 415);
            this.lblSueldos.Name = "lblSueldos";
            this.lblSueldos.Size = new System.Drawing.Size(35, 13);
            this.lblSueldos.TabIndex = 7;
            this.lblSueldos.Text = "label1";
            // 
            // FrmPersonal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 558);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.tabEmpleado);
            this.Name = "FrmPersonal";
            this.Text = "Formulario Personal";
            this.Load += new System.EventHandler(this.FrmPersonal_Load);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.gbxControles.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgPersonal)).EndInit();
            this.tabEmpleado.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox gbxControles;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox tbxNroEmpleado;
        private System.Windows.Forms.TextBox tbxApellido;
        private System.Windows.Forms.TextBox tbxNombre;
        private System.Windows.Forms.TextBox tbxDocumento;
        private System.Windows.Forms.DataGridView dtgPersonal;
        private System.Windows.Forms.Label lblRol;
        private System.Windows.Forms.Label lblDocumento;
        private System.Windows.Forms.ComboBox cbxTipoEmpleado;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblNroEmpleado;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TabControl tabEmpleado;
        private System.Windows.Forms.Button btnGenerarPass;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSueldos;
    }
}