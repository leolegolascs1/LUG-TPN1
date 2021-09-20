namespace Presentacion_IU
{
    partial class FrmInformesGenerales
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
            this.gbxInforme = new System.Windows.Forms.GroupBox();
            this.lblCPersonal = new System.Windows.Forms.Label();
            this.tbxPersonal = new System.Windows.Forms.TextBox();
            this.lblCProveedor = new System.Windows.Forms.Label();
            this.tbxProveedores = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxOrdenes = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxItemPedidos = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbxInforme.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxInforme
            // 
            this.gbxInforme.Controls.Add(this.tbxItemPedidos);
            this.gbxInforme.Controls.Add(this.label3);
            this.gbxInforme.Controls.Add(this.tbxOrdenes);
            this.gbxInforme.Controls.Add(this.label2);
            this.gbxInforme.Controls.Add(this.tbxProveedores);
            this.gbxInforme.Controls.Add(this.lblCProveedor);
            this.gbxInforme.Controls.Add(this.tbxPersonal);
            this.gbxInforme.Controls.Add(this.lblCPersonal);
            this.gbxInforme.Location = new System.Drawing.Point(30, 62);
            this.gbxInforme.Name = "gbxInforme";
            this.gbxInforme.Size = new System.Drawing.Size(439, 235);
            this.gbxInforme.TabIndex = 1;
            this.gbxInforme.TabStop = false;
            this.gbxInforme.Text = "Informes";
            // 
            // lblCPersonal
            // 
            this.lblCPersonal.AutoSize = true;
            this.lblCPersonal.Location = new System.Drawing.Point(88, 45);
            this.lblCPersonal.Name = "lblCPersonal";
            this.lblCPersonal.Size = new System.Drawing.Size(111, 13);
            this.lblCPersonal.TabIndex = 0;
            this.lblCPersonal.Text = "Cantidad de Personal:";
            // 
            // tbxPersonal
            // 
            this.tbxPersonal.Location = new System.Drawing.Point(205, 42);
            this.tbxPersonal.Name = "tbxPersonal";
            this.tbxPersonal.ReadOnly = true;
            this.tbxPersonal.Size = new System.Drawing.Size(100, 20);
            this.tbxPersonal.TabIndex = 1;
            // 
            // lblCProveedor
            // 
            this.lblCProveedor.AutoSize = true;
            this.lblCProveedor.Location = new System.Drawing.Point(69, 84);
            this.lblCProveedor.Name = "lblCProveedor";
            this.lblCProveedor.Size = new System.Drawing.Size(130, 13);
            this.lblCProveedor.TabIndex = 0;
            this.lblCProveedor.Text = "Cantidad de Proveedores:";
            // 
            // tbxProveedores
            // 
            this.tbxProveedores.Location = new System.Drawing.Point(205, 81);
            this.tbxProveedores.Name = "tbxProveedores";
            this.tbxProveedores.ReadOnly = true;
            this.tbxProveedores.Size = new System.Drawing.Size(100, 20);
            this.tbxProveedores.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Cantidad de Ordenes Registradas:";
            // 
            // tbxOrdenes
            // 
            this.tbxOrdenes.Location = new System.Drawing.Point(205, 122);
            this.tbxOrdenes.Name = "tbxOrdenes";
            this.tbxOrdenes.ReadOnly = true;
            this.tbxOrdenes.Size = new System.Drawing.Size(100, 20);
            this.tbxOrdenes.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Total de Items Pedidos";
            // 
            // tbxItemPedidos
            // 
            this.tbxItemPedidos.Location = new System.Drawing.Point(205, 161);
            this.tbxItemPedidos.Name = "tbxItemPedidos";
            this.tbxItemPedidos.ReadOnly = true;
            this.tbxItemPedidos.Size = new System.Drawing.Size(100, 20);
            this.tbxItemPedidos.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(194, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "INFORMES";
            // 
            // FrmInformesGenerales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 322);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbxInforme);
            this.Name = "FrmInformesGenerales";
            this.Text = "FrmInformesGenerales";
            this.Load += new System.EventHandler(this.FrmInformesGenerales_Load);
            this.gbxInforme.ResumeLayout(false);
            this.gbxInforme.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox gbxInforme;
        private System.Windows.Forms.Label lblCPersonal;
        private System.Windows.Forms.TextBox tbxItemPedidos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxOrdenes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxProveedores;
        private System.Windows.Forms.Label lblCProveedor;
        private System.Windows.Forms.TextBox tbxPersonal;
        private System.Windows.Forms.Label label1;
    }
}