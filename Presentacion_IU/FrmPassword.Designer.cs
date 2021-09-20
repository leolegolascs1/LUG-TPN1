namespace Presentacion_IU
{
    partial class FrmPassword
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
            this.tbxNuevoRepite = new System.Windows.Forms.TextBox();
            this.tbxNuevo = new System.Windows.Forms.TextBox();
            this.tbxActual = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblAnterior = new System.Windows.Forms.Label();
            this.lblActual = new System.Windows.Forms.Label();
            this.lblConfirma = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbxNuevoRepite
            // 
            this.tbxNuevoRepite.Location = new System.Drawing.Point(104, 148);
            this.tbxNuevoRepite.Name = "tbxNuevoRepite";
            this.tbxNuevoRepite.Size = new System.Drawing.Size(163, 20);
            this.tbxNuevoRepite.TabIndex = 2;
            this.tbxNuevoRepite.UseSystemPasswordChar = true;
            // 
            // tbxNuevo
            // 
            this.tbxNuevo.Location = new System.Drawing.Point(104, 109);
            this.tbxNuevo.Name = "tbxNuevo";
            this.tbxNuevo.Size = new System.Drawing.Size(163, 20);
            this.tbxNuevo.TabIndex = 1;
            this.tbxNuevo.UseSystemPasswordChar = true;
            // 
            // tbxActual
            // 
            this.tbxActual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.tbxActual.Location = new System.Drawing.Point(104, 56);
            this.tbxActual.Name = "tbxActual";
            this.tbxActual.Size = new System.Drawing.Size(163, 20);
            this.tbxActual.TabIndex = 0;
            this.tbxActual.UseSystemPasswordChar = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(49, 195);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 3;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // lblAnterior
            // 
            this.lblAnterior.AutoSize = true;
            this.lblAnterior.Location = new System.Drawing.Point(115, 40);
            this.lblAnterior.Name = "lblAnterior";
            this.lblAnterior.Size = new System.Drawing.Size(127, 13);
            this.lblAnterior.TabIndex = 2;
            this.lblAnterior.Text = "Ingrese Password Actual:";
            // 
            // lblActual
            // 
            this.lblActual.AutoSize = true;
            this.lblActual.Location = new System.Drawing.Point(125, 93);
            this.lblActual.Name = "lblActual";
            this.lblActual.Size = new System.Drawing.Size(129, 13);
            this.lblActual.TabIndex = 2;
            this.lblActual.Text = "Ingrese Nuevo Password:";
            // 
            // lblConfirma
            // 
            this.lblConfirma.AutoSize = true;
            this.lblConfirma.Location = new System.Drawing.Point(128, 132);
            this.lblConfirma.Name = "lblConfirma";
            this.lblConfirma.Size = new System.Drawing.Size(114, 13);
            this.lblConfirma.TabIndex = 2;
            this.lblConfirma.Text = "Ingreses Nuevamente:";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(122, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(126, 13);
            this.lblTitulo.TabIndex = 3;
            this.lblTitulo.Text = "MENU PASSWORDS";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(155, 195);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(271, 195);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 5;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // FrmPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 230);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblConfirma);
            this.Controls.Add(this.lblActual);
            this.Controls.Add(this.lblAnterior);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.tbxActual);
            this.Controls.Add(this.tbxNuevo);
            this.Controls.Add(this.tbxNuevoRepite);
            this.Name = "FrmPassword";
            this.Text = "Formulario Password";
            this.Load += new System.EventHandler(this.FrmPassword_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxNuevoRepite;
        private System.Windows.Forms.TextBox tbxNuevo;
        private System.Windows.Forms.TextBox tbxActual;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lblAnterior;
        private System.Windows.Forms.Label lblActual;
        private System.Windows.Forms.Label lblConfirma;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnLimpiar;
    }
}